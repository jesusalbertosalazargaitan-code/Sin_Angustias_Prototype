using System;
using System.Collections.Generic;
using Cinemachine;
using UnityEditor;
using UnityEditor.Animations;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public static class SetupIntegralPhases
{
    private const string HODAART_ANIM_DIR = "Assets/Hodaart/StylizedCharacterCollection1/Animations/";
    private const string ANIM_DIR = "Assets/_Animations/";
    private const string PLAYER_CH01_ANIM_DIR = "Assets/_Animations/PlayerCh01";
    private const string PLAYER_FBX_PATH = "Assets/Character/Player.fbx";
    private const string ENEMY_PREFAB_PATH = "Assets/_Prefabs/Enemy.prefab";
    private const string ENEMY_MAT_PREFAB_PATH = "Assets/_Prefabs/MaterialsEnemy/Enemy.prefab";
    private const string LVL1_SCENE_PATH = "Assets/_Scenes/Lvl 1.unity";
    private const string LVL2_SCENE_PATH = "Assets/_Scenes/Lvl 2.unity";

    private class PlayerFlashlightSnapshot
    {
        public Dictionary<string, Quaternion> armBoneRotations = new Dictionary<string, Quaternion>();
        public Vector3 linternaLocalPos;
        public Quaternion linternaLocalRot;
        public Vector3 linternaLocalScale;
        public bool hasLinternaTransform;
        public Vector3 spotLocalPos;
        public Quaternion spotLocalRot;
        public float spotRange;
        public float spotAngle;
        public float spotIntensity;
        public Color spotColor;
        public LightShadows spotShadows;
        public bool hasSpotLight;
        public string linternaParentBoneName = "mixamorig:RightHand";
    }

    private static readonly string[] RIGHT_ARM_CHAIN_BONES = new[]
    {
        "mixamorig:RightShoulder", "mixamorig:RightArm", "mixamorig:RightForeArm", "mixamorig:RightHand",
        "mixamorig:RightHandThumb1", "mixamorig:RightHandThumb2", "mixamorig:RightHandThumb3",
        "mixamorig:RightHandIndex1", "mixamorig:RightHandIndex2", "mixamorig:RightHandIndex3",
        "mixamorig:RightHandMiddle1", "mixamorig:RightHandMiddle2", "mixamorig:RightHandMiddle3",
        "mixamorig:RightHandRing1", "mixamorig:RightHandRing2", "mixamorig:RightHandRing3",
        "mixamorig:RightHandPinky1", "mixamorig:RightHandPinky2", "mixamorig:RightHandPinky3"
    };

    [MenuItem("Tools/Setup Integral Phases (1-4)")]
    public static void Execute()
    {
        Debug.Log("[SetupIntegralPhases] Starting full repair & unification across Lvl 2 and Lvl 1...");

        // 1. Repair shared Player clips & PlayerAnim.controller (including Light transitions)
        AnimatorController playerCtrl = RepairPlayerClipsAndController();

        // 2. Repair EnemyAnimator.controller
        RepairEnemyController();

        // 3. Process Lvl 2.unity FIRST to capture reference Player + Linterna snapshot
        PlayerFlashlightSnapshot lvl2Snapshot = null;
        if (System.IO.File.Exists(LVL2_SCENE_PATH))
        {
            Scene lvl2 = EditorSceneManager.OpenScene(LVL2_SCENE_PATH, OpenSceneMode.Single);
            GameObject p2 = SetupOrReplacePlayerInActiveScene(playerCtrl);
            EqualizeEnemiesInActiveScene(p2);
            lvl2Snapshot = CaptureFlashlightSnapshot(p2);
            EditorSceneManager.MarkSceneDirty(lvl2);
            EditorSceneManager.SaveScene(lvl2);
            Debug.Log("[SetupIntegralPhases] Saved Lvl 2.unity.");
        }

        // 4. Process Lvl 1.unity: Ambient NPCs + clear waypoints, sync Player & flashlight from Lvl 2, Remy
        if (System.IO.File.Exists(LVL1_SCENE_PATH))
        {
            Scene lvl1 = EditorSceneManager.OpenScene(LVL1_SCENE_PATH, OpenSceneMode.Single);
            ExecutePhase1_AmbientNPCs();
            GameObject p1 = SetupOrReplacePlayerInActiveScene(playerCtrl);
            if (lvl2Snapshot != null)
            {
                ApplyFlashlightSnapshotToPlayer(p1, lvl2Snapshot);
            }
            EqualizeEnemiesInActiveScene(p1);
            ExecutePhase4_RemyStandAndTalk();
            EditorSceneManager.MarkSceneDirty(lvl1);
            EditorSceneManager.SaveScene(lvl1);
            Debug.Log("[SetupIntegralPhases] Saved Lvl 1.unity.");
        }

        // 5. Update Enemy prefabs (note: modify prefabs BEFORE saving assets, and keep Lvl 1 clean afterwards)
        GameObject playerAsset = AssetDatabase.LoadAssetAtPath<GameObject>(PLAYER_FBX_PATH);
        float playerUnitH = MeasureCharacterHeight(playerAsset, 1.75f);
        UpdateEnemyPrefab(ENEMY_PREFAB_PATH, playerUnitH);
        UpdateEnemyPrefab(ENEMY_MAT_PREFAB_PATH, playerUnitH);

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        Debug.Log("[SetupIntegralPhases] ALL URGENT FIXES & SCENES COMPLETED SUCCESSFULLY.");
    }

    // =========================================================================
    // SHARED CLIPS & CONTROLLERS
    // =========================================================================
    private static AnimatorController RepairPlayerClipsAndController()
    {
        AnimationClip origIdle = AssetDatabase.LoadAssetAtPath<AnimationClip>(ANIM_DIR + "Idle.anim");
        AnimationClip origWalk = AssetDatabase.LoadAssetAtPath<AnimationClip>(ANIM_DIR + "Walking.anim");
        AnimationClip origRun = AssetDatabase.LoadAssetAtPath<AnimationClip>(ANIM_DIR + "Running.anim");
        AnimationClip origLight = AssetDatabase.LoadAssetAtPath<AnimationClip>(ANIM_DIR + "Light.anim");
        AnimationClip origDead = AssetDatabase.LoadAssetAtPath<AnimationClip>(ANIM_DIR + "Player dead.anim");

        if (origIdle != null) SetClipLoop(origIdle, true);
        if (origWalk != null) SetClipLoop(origWalk, true);
        if (origRun != null) SetClipLoop(origRun, true);
        if (origDead != null) SetClipLoop(origDead, false);

        if (origLight != null)
        {
            RepairLightClipWithIdleArmPose(origLight, origIdle);
            SetClipLoop(origLight, true);
        }

        AnimatorController playerCtrl = AssetDatabase.LoadAssetAtPath<AnimatorController>(ANIM_DIR + "PlayerAnim.controller");
        if (playerCtrl != null)
        {
            AnimatorStateMachine sm = playerCtrl.layers[0].stateMachine;
            AnimatorState idleState = null;
            AnimatorState speedState = null;
            AnimatorState lightState = null;
            AnimatorState deadState = null;

            foreach (ChildAnimatorState cs in sm.states)
            {
                if (cs.state.name == "Idle")
                {
                    idleState = cs.state;
                    if (origIdle != null) cs.state.motion = origIdle;
                }
                else if (cs.state.name == "Light")
                {
                    lightState = cs.state;
                    if (origLight != null) cs.state.motion = origLight;
                }
                else if (cs.state.name == "Player dead")
                {
                    deadState = cs.state;
                    if (origDead != null) cs.state.motion = origDead;
                    cs.state.speed = 1.0f; // 1:1 sync (0-4s decapitation + 4-7.03s head held & dropped)
                }
                else if (cs.state.name == "StateSpeed Tree")
                {
                    speedState = cs.state;
                    if (cs.state.motion is BlendTree bt)
                    {
                        ChildMotion[] children = bt.children;
                        for (int i = 0; i < children.Length; i++)
                        {
                            if (i == 0 && origWalk != null) children[i].motion = origWalk;
                            if (i == 1 && origRun != null) children[i].motion = origRun;
                        }
                        bt.children = children;
                        EditorUtility.SetDirty(bt);
                    }
                }
            }

            if (speedState != null && idleState != null)
            {
                foreach (AnimatorStateTransition tr in speedState.transitions)
                {
                    if (tr.destinationState == idleState)
                    {
                        tr.hasExitTime = false;
                        tr.duration = 0.15f;
                    }
                }
            }

            if (lightState != null)
            {
                foreach (ChildAnimatorState cs in sm.states)
                {
                    foreach (AnimatorStateTransition tr in cs.state.transitions)
                    {
                        if (tr.destinationState == lightState)
                        {
                            tr.hasExitTime = false;
                            tr.duration = 0.05f;
                            tr.exitTime = 0f;
                        }
                    }
                }

                foreach (AnimatorStateTransition tr in lightState.transitions)
                {
                    if (tr.destinationState == idleState || tr.destinationState == speedState)
                    {
                        tr.hasExitTime = true;
                        tr.exitTime = 0.85f;
                        tr.duration = 0.15f;
                    }
                }
            }

            foreach (ChildAnimatorState cs in sm.states)
            {
                foreach (AnimatorStateTransition tr in cs.state.transitions)
                {
                    if (deadState != null && tr.destinationState == deadState)
                    {
                        tr.hasExitTime = false;
                        tr.duration = 0f;
                        tr.exitTime = 0f;
                    }
                }
            }

            EditorUtility.SetDirty(playerCtrl);
        }

        // Remove broken PlayerCh01 remapped clips folder if present
        if (AssetDatabase.IsValidFolder(PLAYER_CH01_ANIM_DIR))
        {
            AssetDatabase.DeleteAsset(PLAYER_CH01_ANIM_DIR);
        }

        return playerCtrl;
    }

    private static void RepairLightClipWithIdleArmPose(AnimationClip lightClip, AnimationClip idleClip)
    {
        if (lightClip == null || idleClip == null) return;

        // Bones that define holding the flashlight forward (skip RightHandThumb1 which Light.anim already animates)
        string[] armPaths = new[]
        {
            "mixamorig:Hips/mixamorig:Spine/mixamorig:Spine1/mixamorig:Spine2/mixamorig:RightShoulder",
            "mixamorig:Hips/mixamorig:Spine/mixamorig:Spine1/mixamorig:Spine2/mixamorig:RightShoulder/mixamorig:RightArm",
            "mixamorig:Hips/mixamorig:Spine/mixamorig:Spine1/mixamorig:Spine2/mixamorig:RightShoulder/mixamorig:RightArm/mixamorig:RightForeArm",
            "mixamorig:Hips/mixamorig:Spine/mixamorig:Spine1/mixamorig:Spine2/mixamorig:RightShoulder/mixamorig:RightArm/mixamorig:RightForeArm/mixamorig:RightHand"
        };

        EditorCurveBinding[] idleBindings = AnimationUtility.GetCurveBindings(idleClip);
        EditorCurveBinding[] lightBindings = AnimationUtility.GetCurveBindings(lightClip);

        foreach (string armPath in armPaths)
        {
            // Collect localRotation.x/y/z/w from Idle at t=0
            Dictionary<string, float> rotVals = new Dictionary<string, float>();
            foreach (EditorCurveBinding b in idleBindings)
            {
                if (b.path == armPath && b.type == typeof(Transform) && b.propertyName.StartsWith("m_LocalRotation."))
                {
                    AnimationCurve src = AnimationUtility.GetEditorCurve(idleClip, b);
                    if (src != null)
                    {
                        rotVals[b.propertyName] = src.Evaluate(0f);
                    }
                }
            }

            if (rotVals.Count == 4)
            {
                foreach (var kv in rotVals)
                {
                    EditorCurveBinding targetBinding = new EditorCurveBinding
                    {
                        path = armPath,
                        type = typeof(Transform),
                        propertyName = kv.Key
                    };
                    AnimationCurve c = new AnimationCurve(
                        new Keyframe(0f, kv.Value),
                        new Keyframe(1f, kv.Value)
                    );
                    AnimationUtility.SetEditorCurve(lightClip, targetBinding, c);
                }
            }
        }

        // Remove empty m_LocalEulerAngles curves on RightHandThumb1 if zero-keyed, preserving real localEulerAnglesRaw
        foreach (EditorCurveBinding b in lightBindings)
        {
            AnimationCurve existing = AnimationUtility.GetEditorCurve(lightClip, b);
            if (existing != null && existing.length == 0)
            {
                AnimationUtility.SetEditorCurve(lightClip, b, null);
            }
        }

        EditorUtility.SetDirty(lightClip);
    }

    private static void RepairEnemyController()
    {
        AnimatorController enemyCtrl = AssetDatabase.LoadAssetAtPath<AnimatorController>(ANIM_DIR + "EnemyAnimator.controller");
        if (enemyCtrl == null) return;

        AnimatorStateMachine sm = enemyCtrl.layers[0].stateMachine;
        AnimatorState deadState = null;
        foreach (ChildAnimatorState cs in sm.states)
        {
            if (cs.state.name == "DeadPlayerforEnemy")
            {
                deadState = cs.state;
                cs.state.speed = 1.0f;
                break;
            }
        }

        if (deadState != null)
        {
            foreach (ChildAnimatorState cs in sm.states)
            {
                foreach (AnimatorStateTransition tr in cs.state.transitions)
                {
                    if (tr.destinationState == deadState)
                    {
                        tr.hasExitTime = false;
                        tr.duration = 0f;
                        tr.exitTime = 0f;
                    }
                }
            }
            EditorUtility.SetDirty(enemyCtrl);
        }
    }

    // =========================================================================
    // PLAYER UNIFICATION & REPLACEMENT IN ACTIVE SCENE
    // =========================================================================
    private static GameObject SetupOrReplacePlayerInActiveScene(AnimatorController playerCtrl)
    {
        GameObject oldPlayer = GameObject.FindWithTag("Player");
        if (oldPlayer == null) oldPlayer = GameObject.Find("Player");
        if (oldPlayer == null)
        {
            Debug.LogError("[SetupIntegralPhases] Could not find Player in scene " + SceneManager.GetActiveScene().name);
            return null;
        }

        bool isXBot = FindBoneRecursive(oldPlayer.transform, "Beta_Surface") != null
                   || FindBoneRecursive(oldPlayer.transform, "Beta_Joints") != null;

        GameObject targetPlayer = oldPlayer;

        if (isXBot)
        {
            targetPlayer = ReplaceXBotWithNewPlayer(oldPlayer, playerCtrl);
        }
        else
        {
            if (PrefabUtility.IsPartOfPrefabInstance(targetPlayer))
            {
                PrefabUtility.UnpackPrefabInstance(targetPlayer, PrefabUnpackMode.OutermostRoot, InteractionMode.AutomatedAction);
            }
        }

        // Rename mixamorig12:* -> mixamorig:* so ALL original mixamorig:* clips work 1:1 with zero loss
        int renamed = 0;
        foreach (Transform t in targetPlayer.GetComponentsInChildren<Transform>(true))
        {
            if (t.name.StartsWith("mixamorig12:"))
            {
                t.name = t.name.Replace("mixamorig12:", "mixamorig:");
                renamed++;
            }
        }

        // Configure Animator for Generic mixamorig:* clips
        Animator anim = targetPlayer.GetComponent<Animator>();
        if (anim == null) anim = targetPlayer.AddComponent<Animator>();
        anim.runtimeAnimatorController = playerCtrl;
        anim.avatar = null;
        anim.applyRootMotion = false;
        anim.cullingMode = AnimatorCullingMode.AlwaysAnimate;
        EditorUtility.SetDirty(anim);

        // Ensure CameraController references are wired accurately
        Transform mainCamT = targetPlayer.transform.Find("Main Camera");
        if (mainCamT == null)
        {
            Camera mainCam = Camera.main;
            if (mainCam != null && mainCam.transform.IsChildOf(targetPlayer.transform))
                mainCamT = mainCam.transform;
        }

        if (mainCamT != null)
        {
            CameraController camCtrl = mainCamT.GetComponent<CameraController>();
            if (camCtrl != null)
            {
                camCtrl.player = targetPlayer.transform;
                camCtrl.playerController = targetPlayer.GetComponent<PlayerController>();
                Transform rightArm = FindExactBone(targetPlayer.transform, "mixamorig:RightArm");
                if (rightArm != null) camCtrl.armBone = rightArm;
                if (camCtrl.flashlightTransform == null)
                {
                    Transform linterna = FindBoneRecursive(targetPlayer.transform, "Linterna");
                    if (linterna != null)
                    {
                        Light spot = linterna.GetComponentInChildren<Light>(true);
                        if (spot != null) camCtrl.flashlightTransform = spot.transform;
                    }
                    if (camCtrl.flashlightTransform == null)
                    {
                        foreach (Light l in targetPlayer.GetComponentsInChildren<Light>(true))
                        {
                            if (l.transform != mainCamT && !l.transform.IsChildOf(mainCamT))
                            {
                                camCtrl.flashlightTransform = l.transform;
                                break;
                            }
                        }
                    }
                }
                EditorUtility.SetDirty(camCtrl);
            }
        }

        EditorUtility.SetDirty(targetPlayer);
        Debug.Log($"[SetupIntegralPhases] Scene '{SceneManager.GetActiveScene().name}': Player ready (replacedXBot={isXBot}, renamedBones={renamed}).");
        return targetPlayer;
    }

    private static GameObject ReplaceXBotWithNewPlayer(GameObject oldPlayer, AnimatorController playerCtrl)
    {
        GameObject playerModelAsset = AssetDatabase.LoadAssetAtPath<GameObject>(PLAYER_FBX_PATH);
        if (playerModelAsset == null)
        {
            Debug.LogError("[SetupIntegralPhases] Missing " + PLAYER_FBX_PATH);
            return oldPlayer;
        }

        GameObject newPlayer = (GameObject)PrefabUtility.InstantiatePrefab(playerModelAsset);
        PrefabUtility.UnpackPrefabInstance(newPlayer, PrefabUnpackMode.OutermostRoot, InteractionMode.AutomatedAction);

        newPlayer.name = "Player";
        newPlayer.tag = "Player";
        newPlayer.layer = oldPlayer.layer;
        newPlayer.transform.position = oldPlayer.transform.position;
        newPlayer.transform.rotation = oldPlayer.transform.rotation;
        newPlayer.transform.localScale = oldPlayer.transform.localScale;

        // Rename mixamorig12:* -> mixamorig:* right away so hand bone lookup works seamlessly
        foreach (Transform t in newPlayer.GetComponentsInChildren<Transform>(true))
        {
            if (t.name.StartsWith("mixamorig12:"))
            {
                t.name = t.name.Replace("mixamorig12:", "mixamorig:");
            }
        }

        // CapsuleCollider
        CapsuleCollider newCol = newPlayer.GetComponent<CapsuleCollider>();
        if (newCol == null) newCol = newPlayer.AddComponent<CapsuleCollider>();
        CapsuleCollider oldCol = oldPlayer.GetComponent<CapsuleCollider>();
        if (oldCol != null)
        {
            newCol.isTrigger = oldCol.isTrigger;
            newCol.radius = oldCol.radius;
            newCol.height = oldCol.height;
            newCol.direction = oldCol.direction;
            newCol.center = oldCol.center;
            newCol.sharedMaterial = oldCol.sharedMaterial;
        }

        // Rigidbody
        Rigidbody newRb = newPlayer.GetComponent<Rigidbody>();
        if (newRb == null) newRb = newPlayer.AddComponent<Rigidbody>();
        Rigidbody oldRb = oldPlayer.GetComponent<Rigidbody>();
        if (oldRb != null)
        {
            newRb.mass = oldRb.mass;
            newRb.drag = oldRb.drag;
            newRb.angularDrag = oldRb.angularDrag;
            newRb.useGravity = oldRb.useGravity;
            newRb.isKinematic = oldRb.isKinematic;
            newRb.constraints = oldRb.constraints;
        }
        newRb.interpolation = RigidbodyInterpolation.Interpolate;
        newRb.collisionDetectionMode = CollisionDetectionMode.Continuous;

        // AudioSources
        PlayerController oldPC = oldPlayer.GetComponent<PlayerController>();
        AudioSource[] oldSources = oldPlayer.GetComponents<AudioSource>();
        AudioSource newFootstep = null;
        AudioSource newSfx = null;
        foreach (AudioSource oldSrc in oldSources)
        {
            AudioSource added = newPlayer.AddComponent<AudioSource>();
            EditorUtility.CopySerialized(oldSrc, added);
            if (oldPC != null && oldSrc == oldPC.footstepSource) newFootstep = added;
            else if (oldPC != null && oldSrc == oldPC.sfxSource) newSfx = added;
        }

        // PlayerController
        PlayerController newPC = newPlayer.AddComponent<PlayerController>();
        if (oldPC != null)
        {
            newPC.suavizadoAnimacion = oldPC.suavizadoAnimacion;
            newPC.speed = oldPC.speed;
            newPC.gameManager = oldPC.gameManager;
            newPC.footstepSource = newFootstep;
            newPC.sfxSource = newSfx;
            newPC.flashlightClip = oldPC.flashlightClip;
        }

        // PlayerStamina
        PlayerStamina oldStam = oldPlayer.GetComponent<PlayerStamina>();
        PlayerStamina newStam = null;
        if (oldStam != null)
        {
            newStam = newPlayer.AddComponent<PlayerStamina>();
            newStam.maxStamina = oldStam.maxStamina;
            newStam.currentStamina = oldStam.currentStamina;
            newStam.drainRate = oldStam.drainRate;
            newStam.regenRate = oldStam.regenRate;
            newStam.exhaustedRegenRate = oldStam.exhaustedRegenRate;
            newStam.exhaustionCooldown = oldStam.exhaustionCooldown;
            newStam.minSprintThreshold = oldStam.minSprintThreshold;
            newStam.playerController = newPC;
        }

        // Animator
        Animator oldAnim = oldPlayer.GetComponent<Animator>();
        Animator newAnim = newPlayer.GetComponent<Animator>();
        if (newAnim == null) newAnim = newPlayer.AddComponent<Animator>();
        newAnim.runtimeAnimatorController = playerCtrl;
        newAnim.avatar = null;
        newAnim.applyRootMotion = false;
        newAnim.cullingMode = AnimatorCullingMode.AlwaysAnimate;

        // Reparent CameraRoot & Main Camera
        Transform camRoot = oldPlayer.transform.Find("CameraRoot");
        if (camRoot != null)
        {
            Vector3 lp = camRoot.localPosition;
            Quaternion lr = camRoot.localRotation;
            Vector3 ls = camRoot.localScale;
            camRoot.SetParent(newPlayer.transform, false);
            camRoot.localPosition = lp;
            camRoot.localRotation = lr;
            camRoot.localScale = ls;
        }

        Transform mainCam = oldPlayer.transform.Find("Main Camera");
        if (mainCam != null)
        {
            Vector3 lp = mainCam.localPosition;
            Quaternion lr = mainCam.localRotation;
            Vector3 ls = mainCam.localScale;
            mainCam.SetParent(newPlayer.transform, false);
            mainCam.localPosition = lp;
            mainCam.localRotation = lr;
            mainCam.localScale = ls;
        }

        // Reparent Linterna-Untitled (or flashlight object) to matching bone on new Player
        Transform linterna = FindBoneRecursive(oldPlayer.transform, "Linterna");
        if (linterna != null)
        {
            string oldParentName = linterna.parent != null ? linterna.parent.name : "mixamorig:RightHand";
            Transform targetBone = FindExactBone(newPlayer.transform, oldParentName);
            if (targetBone == null) targetBone = FindExactBone(newPlayer.transform, "mixamorig:RightHand");
            if (targetBone == null) targetBone = newPlayer.transform;

            Vector3 lp = linterna.localPosition;
            Quaternion lr = linterna.localRotation;
            Vector3 ls = linterna.localScale;
            linterna.SetParent(targetBone, false);
            linterna.localPosition = lp;
            linterna.localRotation = lr;
            linterna.localScale = ls;
        }

        // Copy PlayerInput and re-target actionEvents oldPC -> newPC
        PlayerInput oldInput = oldPlayer.GetComponent<PlayerInput>();
        if (oldInput != null)
        {
            UnityEditorInternal.ComponentUtility.CopyComponent(oldInput);
            UnityEditorInternal.ComponentUtility.PasteComponentAsNew(newPlayer);
            PlayerInput newInput = newPlayer.GetComponent<PlayerInput>();
            if (newInput != null)
            {
                SerializedObject soInput = new SerializedObject(newInput);
                SerializedProperty actionEvents = soInput.FindProperty("m_ActionEvents");
                if (actionEvents != null && actionEvents.isArray)
                {
                    for (int i = 0; i < actionEvents.arraySize; i++)
                    {
                        SerializedProperty calls = actionEvents.GetArrayElementAtIndex(i).FindPropertyRelative("m_PersistentCalls.m_Calls");
                        if (calls != null && calls.isArray)
                        {
                            for (int j = 0; j < calls.arraySize; j++)
                            {
                                SerializedProperty targetProp = calls.GetArrayElementAtIndex(j).FindPropertyRelative("m_Target");
                                if (targetProp != null && oldPC != null && targetProp.objectReferenceValue == oldPC)
                                {
                                    targetProp.objectReferenceValue = newPC;
                                }
                            }
                        }
                    }
                }
                soInput.ApplyModifiedPropertiesWithoutUndo();
                EditorUtility.SetDirty(newInput);
            }
        }

        // Copy Right Arm / Hand / Fingers initial pose from old X Bot onto new Player so flashlight rests cleanly
        CopyArmBonePose(oldPlayer.transform, newPlayer.transform);

        // Re-map ALL serialized scene references from oldPlayer components to newPlayer components
        Dictionary<UnityEngine.Object, UnityEngine.Object> remap = new Dictionary<UnityEngine.Object, UnityEngine.Object>();
        remap[oldPlayer] = newPlayer;
        remap[oldPlayer.transform] = newPlayer.transform;
        if (oldPC != null) remap[oldPC] = newPC;
        if (oldStam != null && newStam != null) remap[oldStam] = newStam;
        if (oldCol != null) remap[oldCol] = newCol;
        if (oldRb != null) remap[oldRb] = newRb;
        if (oldAnim != null) remap[oldAnim] = newAnim;

        int remappedProps = RemapSceneReferences(SceneManager.GetActiveScene(), oldPlayer, remap);
        Debug.Log($"[SetupIntegralPhases] Remapped {remappedProps} serialized reference(s) in '{SceneManager.GetActiveScene().name}'.");

        Undo.DestroyObjectImmediate(oldPlayer);
        return newPlayer;
    }

    private static void CopyArmBonePose(Transform srcRoot, Transform dstRoot)
    {
        foreach (string bName in RIGHT_ARM_CHAIN_BONES)
        {
            Transform src = FindExactBone(srcRoot, bName);
            Transform dst = FindExactBone(dstRoot, bName);
            if (src != null && dst != null)
            {
                dst.localRotation = src.localRotation;
            }
        }
    }

    private static PlayerFlashlightSnapshot CaptureFlashlightSnapshot(GameObject player)
    {
        if (player == null) return null;
        PlayerFlashlightSnapshot snap = new PlayerFlashlightSnapshot();

        foreach (string bName in RIGHT_ARM_CHAIN_BONES)
        {
            Transform b = FindExactBone(player.transform, bName);
            if (b != null)
            {
                snap.armBoneRotations[bName] = b.localRotation;
            }
        }

        Transform linterna = FindBoneRecursive(player.transform, "Linterna");
        if (linterna != null)
        {
            snap.hasLinternaTransform = true;
            snap.linternaParentBoneName = linterna.parent != null ? linterna.parent.name : "mixamorig:RightHand";
            snap.linternaLocalPos = linterna.localPosition;
            snap.linternaLocalRot = linterna.localRotation;
            snap.linternaLocalScale = linterna.localScale;

            Light spot = linterna.GetComponentInChildren<Light>(true);
            if (spot != null)
            {
                snap.hasSpotLight = true;
                snap.spotLocalPos = spot.transform.localPosition;
                snap.spotLocalRot = spot.transform.localRotation;
                snap.spotRange = spot.range;
                snap.spotAngle = spot.spotAngle;
                snap.spotIntensity = spot.intensity;
                snap.spotColor = spot.color;
                snap.spotShadows = spot.shadows;
            }
        }

        Debug.Log($"[SetupIntegralPhases] Captured Lvl 2 flashlight snapshot: armBones={snap.armBoneRotations.Count}, hasLinterna={snap.hasLinternaTransform}, hasSpot={snap.hasSpotLight}.");
        return snap;
    }

    private static void ApplyFlashlightSnapshotToPlayer(GameObject player, PlayerFlashlightSnapshot snap)
    {
        if (player == null || snap == null) return;

        foreach (var kv in snap.armBoneRotations)
        {
            Transform dst = FindExactBone(player.transform, kv.Key);
            if (dst != null)
            {
                dst.localRotation = kv.Value;
                EditorUtility.SetDirty(dst);
            }
        }

        Transform linterna = FindBoneRecursive(player.transform, "Linterna");
        Light spotLight = null;
        if (linterna != null && snap.hasLinternaTransform)
        {
            Transform targetParent = FindExactBone(player.transform, snap.linternaParentBoneName)
                                  ?? FindExactBone(player.transform, "mixamorig:RightHand")
                                  ?? player.transform;
            if (linterna.parent != targetParent)
            {
                linterna.SetParent(targetParent, false);
            }
            linterna.localPosition = snap.linternaLocalPos;
            linterna.localRotation = snap.linternaLocalRot;
            linterna.localScale = snap.linternaLocalScale;
            EditorUtility.SetDirty(linterna);

            spotLight = linterna.GetComponentInChildren<Light>(true);
            if (spotLight != null && snap.hasSpotLight)
            {
                spotLight.transform.localPosition = snap.spotLocalPos;
                spotLight.transform.localRotation = snap.spotLocalRot;
                spotLight.range = snap.spotRange;
                spotLight.spotAngle = snap.spotAngle;
                spotLight.intensity = snap.spotIntensity;
                spotLight.color = snap.spotColor;
                spotLight.shadows = snap.spotShadows;
                EditorUtility.SetDirty(spotLight);
            }
        }

        Transform mainCamT = player.transform.Find("Main Camera");
        if (mainCamT != null)
        {
            CameraController camCtrl = mainCamT.GetComponent<CameraController>();
            if (camCtrl != null)
            {
                camCtrl.armBone = FindExactBone(player.transform, "mixamorig:RightArm");
                if (spotLight != null) camCtrl.flashlightTransform = spotLight.transform;
                EditorUtility.SetDirty(camCtrl);
            }
        }

        if (spotLight != null)
        {
            GameManager gm = UnityEngine.Object.FindObjectOfType<GameManager>(true);
            if (gm != null && gm.lightF == null)
            {
                gm.lightF = spotLight;
                EditorUtility.SetDirty(gm);
            }
        }

        Debug.Log("[SetupIntegralPhases] Applied Lvl 2 flashlight pose & Linterna transform to Lvl 1 Player.");
    }

    private static int RemapSceneReferences(
        Scene scene,
        GameObject skipRoot,
        Dictionary<UnityEngine.Object, UnityEngine.Object> remap)
    {
        int count = 0;
        foreach (GameObject root in scene.GetRootGameObjects())
        {
            if (root == skipRoot) continue;
            Component[] comps = root.GetComponentsInChildren<Component>(true);
            foreach (Component comp in comps)
            {
                if (comp == null) continue;
                SerializedObject so = new SerializedObject(comp);
                SerializedProperty it = so.GetIterator();
                bool changed = false;
                while (it.NextVisible(true))
                {
                    if (it.propertyType == SerializedPropertyType.ObjectReference && it.objectReferenceValue != null)
                    {
                        if (remap.TryGetValue(it.objectReferenceValue, out UnityEngine.Object replacement))
                        {
                            it.objectReferenceValue = replacement;
                            changed = true;
                            count++;
                        }
                    }
                }
                if (changed)
                {
                    so.ApplyModifiedPropertiesWithoutUndo();
                    EditorUtility.SetDirty(comp);
                }
            }
        }
        return count;
    }

    // =========================================================================
    // ENEMY HEIGHT MATCHING & SYNCED GRAB CALIBRATION
    // =========================================================================
    private static void EqualizeEnemiesInActiveScene(GameObject player)
    {
        if (player == null) return;

        float playerHeight = MeasureCharacterHeight(player, 1.75f * player.transform.lossyScale.y);
        float playerScale = player.transform.lossyScale.y;
        float calibratedGrabDist = CalibrateGrabDistance(playerScale);

        EnemyIA[] enemies = UnityEngine.Object.FindObjectsOfType<EnemyIA>(true);
        foreach (EnemyIA ia in enemies)
        {
            if (ia == null) continue;
            GameObject enemyGO = ia.gameObject;
            Undo.RecordObject(enemyGO, "Equalize Enemy " + enemyGO.name);

            float enemyUnitH = MeasureCharacterHeight(enemyGO, 1.85f * Mathf.Max(0.01f, enemyGO.transform.lossyScale.y))
                             / Mathf.Max(0.01f, enemyGO.transform.lossyScale.y);
            float matchedScale = playerHeight / Mathf.Max(0.1f, enemyUnitH);

            enemyGO.transform.localScale = new Vector3(matchedScale, matchedScale, matchedScale);

            // Ensure Collider tag matches Enemy if tag exists
            if (HasTag("Enemy"))
            {
                enemyGO.tag = "Enemy";
            }

            ia.jugador = player.transform;
            ia.killSyncDistance = calibratedGrabDist;
            ia.deathSequenceDuration = 7.0f;
            EditorUtility.SetDirty(ia);

            NavMeshAgent agent = enemyGO.GetComponent<NavMeshAgent>();
            if (agent != null)
            {
                agent.baseOffset = 0f;
                EditorUtility.SetDirty(agent);
            }

            Animator eAnim = enemyGO.GetComponent<Animator>();
            if (eAnim != null)
            {
                eAnim.applyRootMotion = false;
                eAnim.cullingMode = AnimatorCullingMode.AlwaysAnimate;
                EditorUtility.SetDirty(eAnim);
            }

            EditorUtility.SetDirty(enemyGO);
            Debug.Log($"[SetupIntegralPhases] '{SceneManager.GetActiveScene().name}' -> '{enemyGO.name}': playerH={playerHeight:F3}m, enemyUnitH={enemyUnitH:F3}m, matchedScale={matchedScale:F3}, killSyncDist={calibratedGrabDist:F3}m");
        }
    }

    private static void UpdateEnemyPrefab(string prefabPath, float playerUnitHeight)
    {
        if (!System.IO.File.Exists(prefabPath)) return;

        GameObject contents = PrefabUtility.LoadPrefabContents(prefabPath);
        if (contents == null) return;

        float curScale = Mathf.Max(0.01f, contents.transform.lossyScale.y);
        float enemyUnitH = MeasureCharacterHeight(contents, 1.85f * curScale) / curScale;
        float matchedUnitScale = playerUnitHeight / Mathf.Max(0.1f, enemyUnitH);
        contents.transform.localScale = new Vector3(matchedUnitScale, matchedUnitScale, matchedUnitScale);

        if (HasTag("Enemy"))
        {
            contents.tag = "Enemy";
        }

        EnemyIA ia = contents.GetComponent<EnemyIA>();
        if (ia != null)
        {
            ia.killSyncDistance = CalibrateGrabDistance(1.0f);
            ia.deathSequenceDuration = 7.0f;
            EditorUtility.SetDirty(ia);
        }

        NavMeshAgent agent = contents.GetComponent<NavMeshAgent>();
        if (agent != null)
        {
            agent.baseOffset = 0f;
            EditorUtility.SetDirty(agent);
        }

        Animator eAnim = contents.GetComponent<Animator>();
        if (eAnim != null)
        {
            eAnim.applyRootMotion = false;
            eAnim.cullingMode = AnimatorCullingMode.AlwaysAnimate;
            EditorUtility.SetDirty(eAnim);
        }

        PrefabUtility.SaveAsPrefabAsset(contents, prefabPath);
        PrefabUtility.UnloadPrefabContents(contents);
        Debug.Log($"[SetupIntegralPhases] Updated prefab '{prefabPath}': matchedUnitScale={matchedUnitScale:F3}");
    }

    private static float MeasureCharacterHeight(GameObject character, float fallbackHeight)
    {
        if (character == null) return fallbackHeight;

        Transform root = character.transform;
        Transform headTop = FindBoneRecursive(root, "HeadTop_End")
                         ?? FindBoneRecursive(root, "mixamorig:Head")
                         ?? FindBoneRecursive(root, "mixamorig12:Head");

        if (headTop != null)
        {
            float boneHeight = headTop.position.y - root.position.y;
            // If Head (not HeadTop_End), add ~0.18 * scale for crown of head
            if (!headTop.name.Contains("HeadTop_End"))
            {
                boneHeight += 0.18f * root.lossyScale.y;
            }
            if (boneHeight > 0.5f) return boneHeight;
        }

        SkinnedMeshRenderer smr = character.GetComponentInChildren<SkinnedMeshRenderer>(true);
        if (smr != null && smr.bounds.size.y > 0.5f)
        {
            return smr.bounds.size.y;
        }

        return fallbackHeight;
    }

    private static float CalibrateGrabDistance(float playerScale)
    {
        // Measure DeadPlayerforEnemy.anim outstretched RightHand Z at grab/hold time
        AnimationClip enemyDeadClip = AssetDatabase.LoadAssetAtPath<AnimationClip>(ANIM_DIR + "DeadPlayerforEnemy.anim");
        GameObject enemyPrefab = AssetDatabase.LoadAssetAtPath<GameObject>(ENEMY_PREFAB_PATH);
        if (enemyDeadClip != null && enemyPrefab != null)
        {
            GameObject temp = UnityEngine.Object.Instantiate(enemyPrefab);
            temp.transform.position = Vector3.zero;
            temp.transform.rotation = Quaternion.identity;
            temp.transform.localScale = Vector3.one * playerScale;
            enemyDeadClip.SampleAnimation(temp, 2.0f);
            Transform rightHand = FindBoneRecursive(temp.transform, "RightHand");
            float measuredZ = rightHand != null ? Mathf.Abs(rightHand.position.z) : 0f;
            float handY = rightHand != null ? rightHand.position.y : 0f;
            UnityEngine.Object.DestroyImmediate(temp);

            if (measuredZ > 0.35f)
            {
                // Account for Main Camera initial forward offset (0.093 * playerScale) during grab
                float syncDist = Mathf.Clamp(measuredZ + 0.093f * playerScale, 0.70f * playerScale, 1.15f * playerScale);
                Debug.Log($"[SetupIntegralPhases] Sampled DeadPlayerforEnemy t=2s: RightHand.z={measuredZ:F3}, RightHand.y={handY:F3} -> syncDist={syncDist:F3}");
                return syncDist;
            }
        }
        return 0.95f * playerScale;
    }

    private static bool HasTag(string tagName)
    {
        foreach (string t in UnityEditorInternal.InternalEditorUtility.tags)
        {
            if (t == tagName) return true;
        }
        return false;
    }

    // =========================================================================
    // PHASE 1: 8 HODAART AMBIENT NPCS IN LVL 1
    // =========================================================================
    private static void ExecutePhase1_AmbientNPCs()
    {
        AnimationClip idleA = AssetDatabase.LoadAssetAtPath<AnimationClip>(HODAART_ANIM_DIR + "Idle_A.anim");
        AnimationClip idleB = AssetDatabase.LoadAssetAtPath<AnimationClip>(HODAART_ANIM_DIR + "Idle_B.anim");
        AnimationClip walkA = AssetDatabase.LoadAssetAtPath<AnimationClip>(HODAART_ANIM_DIR + "Walk_A.anim");
        AnimationClip walkB = AssetDatabase.LoadAssetAtPath<AnimationClip>(HODAART_ANIM_DIR + "Walk_B.anim");
        AnimationClip walkSad = AssetDatabase.LoadAssetAtPath<AnimationClip>(HODAART_ANIM_DIR + "Walk_Sad.anim");

        if (idleA == null || idleB == null || walkA == null || walkB == null || walkSad == null)
        {
            Debug.LogWarning("[SetupIntegralPhases] Phase 1 skipped: Missing Hodaart clips.");
            return;
        }

        AnimationClip talkingClip = CreateHumanoidTalkingClip(ANIM_DIR + "NPC_Talking.anim", idleB, 4.0f, 1.0f);

        string baseCtrlPath = ANIM_DIR + "NPC_Ambient.controller";
        if (AssetDatabase.LoadAssetAtPath<AnimatorController>(baseCtrlPath) != null)
        {
            AssetDatabase.DeleteAsset(baseCtrlPath);
        }

        AnimatorController baseCtrl = AnimatorController.CreateAnimatorControllerAtPath(baseCtrlPath);
        baseCtrl.AddParameter("Speed", AnimatorControllerParameterType.Float);
        baseCtrl.AddParameter("IdleVariant", AnimatorControllerParameterType.Float);
        baseCtrl.AddParameter("IsTalking", AnimatorControllerParameterType.Bool);

        BlendTree locoTree;
        AnimatorState locoState = baseCtrl.CreateBlendTreeInController("Locomotion", out locoTree, 0);
        locoState.writeDefaultValues = false;
        locoTree.name = "LocomotionBlendTree";
        locoTree.blendType = BlendTreeType.FreeformCartesian2D;
        locoTree.blendParameter = "IdleVariant";
        locoTree.blendParameterY = "Speed";
        locoTree.useAutomaticThresholds = false;
        locoTree.AddChild(idleA, new Vector2(0f, 0f));
        locoTree.AddChild(idleB, new Vector2(1f, 0f));
        locoTree.AddChild(walkA, new Vector2(0f, 1f));
        locoTree.AddChild(walkA, new Vector2(1f, 1f));

        AnimatorStateMachine sm = baseCtrl.layers[0].stateMachine;
        sm.defaultState = locoState;

        AnimatorState talkState = sm.AddState("Talking", new Vector3(300f, 180f, 0f));
        talkState.motion = talkingClip;
        talkState.writeDefaultValues = false;

        AnimatorStateTransition toTalk = locoState.AddTransition(talkState);
        toTalk.AddCondition(AnimatorConditionMode.If, 0f, "IsTalking");
        toTalk.hasExitTime = false;
        toTalk.duration = 0.25f;

        AnimatorStateTransition fromTalk = talkState.AddTransition(locoState);
        fromTalk.AddCondition(AnimatorConditionMode.IfNot, 0f, "IsTalking");
        fromTalk.hasExitTime = false;
        fromTalk.duration = 0.25f;

        EditorUtility.SetDirty(locoTree);
        EditorUtility.SetDirty(baseCtrl);

        AnimatorOverrideController walkBCtrl = CreateOrUpdateOverride(
            ANIM_DIR + "NPC_Ambient_WalkB.overrideController", baseCtrl, walkA, walkB);
        AnimatorOverrideController walkSadCtrl = CreateOrUpdateOverride(
            ANIM_DIR + "NPC_Ambient_WalkSad.overrideController", baseCtrl, walkA, walkSad);

        GameObject wpContainer = GameObject.Find("NPC_Waypoints");
        if (wpContainer == null)
        {
            wpContainer = new GameObject("NPC_Waypoints");
        }

        Transform[] wpBoy = CreateOrUpdateWaypointGroup(wpContainer.transform, "Waypoints_Boy", "WP_Boy", new Vector3[]
        {
            new Vector3(408.84f, 0f, 477.71f),
            new Vector3(405.50f, 0f, 480.50f),
            new Vector3(406.50f, 0f, 474.50f)
        });

        Transform[] wpMiguel1 = CreateOrUpdateWaypointGroup(wpContainer.transform, "Waypoints_Miguel1", "WP_Miguel1", new Vector3[]
        {
            new Vector3(407.14f, 0f, 477.38f),
            new Vector3(403.50f, 0f, 484.00f),
            new Vector3(401.50f, 0f, 476.50f)
        });

        Transform[] wpAbuelito1 = CreateOrUpdateWaypointGroup(wpContainer.transform, "Waypoints_Abuelito1", "WP_Abuelito1", new Vector3[]
        {
            new Vector3(387.48f, 0f, 482.31f),
            new Vector3(391.50f, 0f, 486.00f),
            new Vector3(389.50f, 0f, 479.00f)
        });

        GameObject miguel2 = GameObject.Find("Miguel 2");
        GameObject mujer1 = GameObject.Find("Mujer 1");
        GameObject abuelita2 = GameObject.Find("Abuelita 2");
        GameObject abuelito2 = GameObject.Find("Abuelito 2");
        GameObject boy = GameObject.Find("Boy");
        GameObject miguel1 = GameObject.Find("Miguel 1");
        GameObject abuelito1 = GameObject.Find("Abuelito 1");
        GameObject abuelita1 = GameObject.Find("Abuelita 1");

        ConfigureAmbientNPC(miguel2, baseCtrl, 1.50f, NPCMode.TalkingPair, mujer1 != null ? mujer1.transform : null, null, 1.45f);
        ConfigureAmbientNPC(mujer1, walkBCtrl, 1.50f, NPCMode.TalkingPair, miguel2 != null ? miguel2.transform : null, null, 1.45f);
        ConfigureAmbientNPC(abuelita2, walkSadCtrl, 1.45f, NPCMode.TalkingPair, abuelito2 != null ? abuelito2.transform : null, null, 1.1f);
        ConfigureAmbientNPC(abuelito2, walkSadCtrl, 1.50f, NPCMode.TalkingPair, abuelita2 != null ? abuelita2.transform : null, null, 1.1f);
        ConfigureAmbientNPC(boy, walkBCtrl, 1.15f, NPCMode.WaypointRoam, null, wpBoy, 1.40f);
        ConfigureAmbientNPC(miguel1, baseCtrl, 1.50f, NPCMode.WaypointRoam, null, wpMiguel1, 1.45f);
        ConfigureAmbientNPC(abuelito1, walkSadCtrl, 1.50f, NPCMode.WaypointRoam, null, wpAbuelito1, 1.00f);
        ConfigureAmbientNPC(abuelita1, walkBCtrl, 1.45f, NPCMode.StaticIdle, null, null, 1.1f);

        // Ensure Physics colliders are synced before validating obstacle-free waypoint paths
        Physics.SyncTransforms();
        ClearWaypointsFromObstacles(wpBoy, "Waypoints_Boy");
        ClearWaypointsFromObstacles(wpMiguel1, "Waypoints_Miguel1");
        ClearWaypointsFromObstacles(wpAbuelito1, "Waypoints_Abuelito1");
    }

    private static void ConfigureAmbientNPC(
        GameObject npc,
        RuntimeAnimatorController ctrl,
        float capsuleHeight,
        NPCMode mode,
        Transform talkPartner,
        Transform[] waypoints,
        float walkSpeed)
    {
        if (npc == null) return;

        // Clean any duplicate child AmbientNPCController or CapsuleCollider (e.g. Boy/Boy)
        foreach (AmbientNPCController childCtrl in npc.GetComponentsInChildren<AmbientNPCController>(true))
        {
            if (childCtrl.gameObject != npc)
            {
                UnityEngine.Object.DestroyImmediate(childCtrl);
            }
        }
        foreach (CapsuleCollider childCol in npc.GetComponentsInChildren<CapsuleCollider>(true))
        {
            if (childCol.gameObject != npc)
            {
                UnityEngine.Object.DestroyImmediate(childCol);
            }
        }

        Animator anim = npc.GetComponent<Animator>();
        if (anim != null)
        {
            anim.runtimeAnimatorController = ctrl;
            anim.applyRootMotion = false;
            anim.cullingMode = AnimatorCullingMode.AlwaysAnimate;
            EditorUtility.SetDirty(anim);
        }

        CapsuleCollider col = npc.GetComponent<CapsuleCollider>();
        if (col == null) col = npc.AddComponent<CapsuleCollider>();
        col.isTrigger = false;
        col.radius = 0.25f;
        col.height = capsuleHeight;
        col.center = new Vector3(0f, capsuleHeight * 0.5f, 0f);
        EditorUtility.SetDirty(col);

        AmbientNPCController npcCtrl = npc.GetComponent<AmbientNPCController>();
        if (npcCtrl == null) npcCtrl = npc.AddComponent<AmbientNPCController>();
        npcCtrl.mode = mode;
        npcCtrl.talkPartner = talkPartner;
        npcCtrl.waypoints = waypoints;
        npcCtrl.walkSpeed = walkSpeed;
        EditorUtility.SetDirty(npcCtrl);
        EditorUtility.SetDirty(npc);
    }

    private static void ClearWaypointsFromObstacles(Transform[] wps, string groupName)
    {
        if (wps == null || wps.Length == 0) return;

        for (int pass = 0; pass < 2; pass++)
        {
            for (int i = 0; i < wps.Length; i++)
            {
                if (wps[i] == null) continue;
                Transform prev = wps[(i - 1 + wps.Length) % wps.Length];
                Transform next = wps[(i + 1) % wps.Length];

                Vector3 current = wps[i].position;
                bool pointOk = IsPointClearOfObstacles(current, 0.85f);
                bool prevOk = prev == null || prev == wps[i] || IsSegmentClearOfObstacles(prev.position, current, 0.45f);
                bool nextOk = next == null || next == wps[i] || IsSegmentClearOfObstacles(current, next.position, 0.45f);

                if (pointOk && prevOk && nextOk) continue;

                bool relocated = false;
                for (float r = 1.0f; r <= 7.0f && !relocated; r += 0.75f)
                {
                    for (int deg = 0; deg < 360; deg += 30)
                    {
                        float rad = deg * Mathf.Deg2Rad;
                        Vector3 cand = new Vector3(current.x + Mathf.Cos(rad) * r, current.y, current.z + Mathf.Sin(rad) * r);
                        cand.y = AmbientNPCController.SampleGroundY(cand.x, current.y, cand.z);

                        if (!IsPointClearOfObstacles(cand, 0.85f)) continue;
                        if (prev != null && prev != wps[i] && !IsSegmentClearOfObstacles(prev.position, cand, 0.45f)) continue;
                        if (next != null && next != wps[i] && !IsSegmentClearOfObstacles(cand, next.position, 0.45f)) continue;

                        wps[i].position = cand;
                        EditorUtility.SetDirty(wps[i]);
                        Debug.Log($"[SetupIntegralPhases] Relocated {groupName}[{i}] from {current} -> {cand} to clear obstacle.");
                        relocated = true;
                        break;
                    }
                }
            }
        }
    }

    private static bool IsWaypointColliderObstacle(Collider col)
    {
        if (col == null || col.isTrigger) return false;
        if (col is TerrainCollider) return false;
        if (col.GetComponentInParent<AmbientNPCController>() != null) return false;
        if (col.GetComponentInParent<PlayerController>() != null) return false;
        return true;
    }

    private static bool IsPointClearOfObstacles(Vector3 p, float radius)
    {
        Vector3 checkPos = new Vector3(p.x, p.y + 0.9f, p.z);
        Collider[] cols = Physics.OverlapSphere(checkPos, radius, ~0, QueryTriggerInteraction.Ignore);
        foreach (Collider c in cols)
        {
            if (IsWaypointColliderObstacle(c)) return false;
        }
        return true;
    }

    private static bool IsSegmentClearOfObstacles(Vector3 a, Vector3 b, float radius)
    {
        Vector3 flatA = new Vector3(a.x, 0f, a.z);
        Vector3 flatB = new Vector3(b.x, 0f, b.z);
        Vector3 diff = flatB - flatA;
        float dist = diff.magnitude;
        if (dist < 0.05f) return true;

        Vector3 dir = diff / dist;
        Vector3 p1 = new Vector3(a.x, a.y + 0.55f, a.z);
        Vector3 p2 = new Vector3(a.x, a.y + 1.35f, a.z);

        RaycastHit[] hits = Physics.CapsuleCastAll(p1, p2, radius, dir, dist, ~0, QueryTriggerInteraction.Ignore);
        foreach (RaycastHit h in hits)
        {
            if (IsWaypointColliderObstacle(h.collider)) return false;
        }
        return true;
    }

    private static Transform[] CreateOrUpdateWaypointGroup(Transform parent, string groupName, string prefix, Vector3[] pts)
    {
        Transform existing = parent.Find(groupName);
        GameObject grp = existing != null ? existing.gameObject : new GameObject(groupName);
        if (existing == null) grp.transform.SetParent(parent, false);

        Transform[] result = new Transform[pts.Length];
        for (int i = 0; i < pts.Length; i++)
        {
            string wpName = prefix + "_" + (i + 1);
            Transform t = grp.transform.Find(wpName);
            GameObject wp = t != null ? t.gameObject : new GameObject(wpName);
            if (t == null) wp.transform.SetParent(grp.transform, false);
            Vector3 p = pts[i];
            p.y = AmbientNPCController.SampleGroundY(p.x, p.y, p.z);
            wp.transform.position = p;
            result[i] = wp.transform;
        }
        return result;
    }

    private static AnimatorOverrideController CreateOrUpdateOverride(
        string assetPath, AnimatorController baseCtrl, AnimationClip origWalk, AnimationClip newWalk)
    {
        AnimatorOverrideController ov = AssetDatabase.LoadAssetAtPath<AnimatorOverrideController>(assetPath);
        if (ov == null)
        {
            ov = new AnimatorOverrideController(baseCtrl);
            AssetDatabase.CreateAsset(ov, assetPath);
        }
        else
        {
            ov.runtimeAnimatorController = baseCtrl;
        }

        var overrides = new List<KeyValuePair<AnimationClip, AnimationClip>>();
        ov.GetOverrides(overrides);
        for (int i = 0; i < overrides.Count; i++)
        {
            if (overrides[i].Key == origWalk)
            {
                overrides[i] = new KeyValuePair<AnimationClip, AnimationClip>(origWalk, newWalk);
            }
        }
        ov.ApplyOverrides(overrides);
        EditorUtility.SetDirty(ov);
        return ov;
    }

    // =========================================================================
    // PHASE 4: REMY STAND UP & TALK
    // =========================================================================
    private static void ExecutePhase4_RemyStandAndTalk()
    {
        AnimationClip idleA = AssetDatabase.LoadAssetAtPath<AnimationClip>(HODAART_ANIM_DIR + "Idle_A.anim");
        AnimationClip sittingClip = LoadSubAnimationClip(ANIM_DIR + "Remy@Sitting.fbx");
        if (idleA == null || sittingClip == null) return;

        AnimationClip remyStandUp = CreateRemyStandUpClip(ANIM_DIR + "Remy_StandUp.anim", sittingClip, idleA, 1.2f);
        AnimationClip remyTalking = CreateHumanoidTalkingClip(ANIM_DIR + "Remy_Talking.anim", idleA, 3.5f, 1.25f);

        string remyCtrlPath = ANIM_DIR + "Remy Sitting.controller";
        if (AssetDatabase.LoadAssetAtPath<AnimatorController>(remyCtrlPath) != null)
        {
            AssetDatabase.DeleteAsset(remyCtrlPath);
        }
        AnimatorController remyCtrl = AnimatorController.CreateAnimatorControllerAtPath(remyCtrlPath);
        remyCtrl.AddParameter("IsPlayerNear", AnimatorControllerParameterType.Bool);
        remyCtrl.AddParameter("IsTalking", AnimatorControllerParameterType.Bool);

        AnimatorStateMachine sm = remyCtrl.layers[0].stateMachine;

        AnimatorState sitState = sm.AddState("Sitting", new Vector3(260f, 100f, 0f));
        sitState.motion = sittingClip;
        sitState.writeDefaultValues = false;
        sm.defaultState = sitState;

        AnimatorState standUpState = sm.AddState("StandUp", new Vector3(520f, 40f, 0f));
        standUpState.motion = remyStandUp;
        standUpState.writeDefaultValues = false;

        AnimatorState idleStandState = sm.AddState("Idle_Stand", new Vector3(780f, 100f, 0f));
        idleStandState.motion = idleA;
        idleStandState.writeDefaultValues = false;

        AnimatorState talkState = sm.AddState("Talking", new Vector3(780f, 240f, 0f));
        talkState.motion = remyTalking;
        talkState.writeDefaultValues = false;

        AnimatorStateTransition trSitToStand = sitState.AddTransition(standUpState);
        trSitToStand.AddCondition(AnimatorConditionMode.If, 0f, "IsPlayerNear");
        trSitToStand.hasExitTime = false;
        trSitToStand.duration = 0.2f;

        AnimatorStateTransition trStandToIdle = standUpState.AddTransition(idleStandState);
        trStandToIdle.hasExitTime = true;
        trStandToIdle.exitTime = 0.9f;
        trStandToIdle.duration = 0.2f;

        AnimatorStateTransition trIdleToTalk = idleStandState.AddTransition(talkState);
        trIdleToTalk.AddCondition(AnimatorConditionMode.If, 0f, "IsTalking");
        trIdleToTalk.hasExitTime = false;
        trIdleToTalk.duration = 0.2f;

        AnimatorStateTransition trTalkToIdle = talkState.AddTransition(idleStandState);
        trTalkToIdle.AddCondition(AnimatorConditionMode.IfNot, 0f, "IsTalking");
        trTalkToIdle.hasExitTime = false;
        trTalkToIdle.duration = 0.2f;

        foreach (AnimatorState st in new[] { standUpState, idleStandState, talkState })
        {
            AnimatorStateTransition trBack = st.AddTransition(sitState);
            trBack.AddCondition(AnimatorConditionMode.IfNot, 0f, "IsPlayerNear");
            trBack.hasExitTime = false;
            trBack.duration = 0.35f;
        }
        EditorUtility.SetDirty(remyCtrl);

        GameObject remy = GameObject.Find("Remy");
        if (remy != null)
        {
            Animator remyAnim = remy.GetComponent<Animator>();
            if (remyAnim != null)
            {
                remyAnim.runtimeAnimatorController = remyCtrl;
                remyAnim.applyRootMotion = false;
                remyAnim.cullingMode = AnimatorCullingMode.AlwaysAnimate;
                EditorUtility.SetDirty(remyAnim);
            }

            CapsuleCollider bodyCol = remy.GetComponent<CapsuleCollider>();
            if (bodyCol == null) bodyCol = remy.AddComponent<CapsuleCollider>();
            bodyCol.isTrigger = false;
            bodyCol.radius = 0.32f;
            bodyCol.height = 1.75f;
            bodyCol.center = new Vector3(0f, 0.875f, 0f);
            EditorUtility.SetDirty(bodyCol);
            EditorUtility.SetDirty(remy);
        }
    }

    // =========================================================================
    // HELPERS
    // =========================================================================
    private static Transform FindExactBone(Transform root, string exactName)
    {
        foreach (Transform t in root.GetComponentsInChildren<Transform>(true))
        {
            if (t.name == exactName) return t;
        }
        return null;
    }

    private static Transform FindBoneRecursive(Transform root, string nameOrPart)
    {
        foreach (Transform t in root.GetComponentsInChildren<Transform>(true))
        {
            if (t.name == nameOrPart || t.name.Contains(nameOrPart)) return t;
        }
        return null;
    }

    private static AnimationClip LoadSubAnimationClip(string assetPath)
    {
        UnityEngine.Object[] objs = AssetDatabase.LoadAllAssetsAtPath(assetPath);
        foreach (UnityEngine.Object o in objs)
        {
            if (o is AnimationClip clip && !clip.name.StartsWith("__preview__")) return clip;
        }
        return null;
    }

    private static void SetClipLoop(AnimationClip clip, bool loop)
    {
        AnimationClipSettings settings = AnimationUtility.GetAnimationClipSettings(clip);
        settings.loopTime = loop;
        AnimationUtility.SetAnimationClipSettings(clip, settings);
        EditorUtility.SetDirty(clip);
    }

    private static AnimationClip CreateHumanoidTalkingClip(string destPath, AnimationClip baseIdle, float duration, float amplitudeScale)
    {
        if (AssetDatabase.LoadAssetAtPath<AnimationClip>(destPath) != null)
        {
            AssetDatabase.DeleteAsset(destPath);
        }

        AnimationClip clip = new AnimationClip();
        clip.name = System.IO.Path.GetFileNameWithoutExtension(destPath);
        clip.frameRate = 30f;

        EditorCurveBinding[] bindings = AnimationUtility.GetCurveBindings(baseIdle);
        foreach (EditorCurveBinding b in bindings)
        {
            AnimationCurve src = AnimationUtility.GetEditorCurve(baseIdle, b);
            if (src == null) continue;

            float v0 = src.Evaluate(0f);
            float vMid = src.Evaluate(Mathf.Min(duration * 0.5f, baseIdle.length));
            AnimationCurve c = new AnimationCurve(
                new Keyframe(0f, v0),
                new Keyframe(duration * 0.5f, vMid),
                new Keyframe(duration, v0)
            );
            AnimationUtility.SetEditorCurve(clip, b, c);
        }

        AddLoopGestureCurve(clip, "Head Nod Down-Up", duration, new[] { 0.05f, 0.18f * amplitudeScale, -0.05f, 0.14f * amplitudeScale, 0.05f });
        AddLoopGestureCurve(clip, "Head Turn Left-Right", duration, new[] { -0.08f, 0.12f * amplitudeScale, 0.02f, -0.14f * amplitudeScale, -0.08f });
        AddLoopGestureCurve(clip, "Head Tilt Left-Right", duration, new[] { 0.0f, 0.08f * amplitudeScale, -0.06f, 0.06f * amplitudeScale, 0.0f });
        AddLoopGestureCurve(clip, "Spine Twist Left-Right", duration, new[] { -0.04f, 0.06f * amplitudeScale, -0.02f, -0.07f * amplitudeScale, -0.04f });
        AddLoopGestureCurve(clip, "Chest Front-Back", duration, new[] { 0.04f, 0.10f * amplitudeScale, 0.02f, 0.09f * amplitudeScale, 0.04f });

        AddLoopGestureCurve(clip, "Right Arm Down-Up", duration, new[] { -0.35f, -0.15f, -0.25f, -0.10f, -0.35f });
        AddLoopGestureCurve(clip, "Right Arm Front-Back", duration, new[] { 0.15f, 0.42f * amplitudeScale, 0.22f, 0.35f * amplitudeScale, 0.15f });
        AddLoopGestureCurve(clip, "Right Forearm Stretch", duration, new[] { -0.10f, 0.38f * amplitudeScale, 0.05f, 0.28f * amplitudeScale, -0.10f });
        AddLoopGestureCurve(clip, "Right Hand Down-Up", duration, new[] { 0.05f, 0.25f * amplitudeScale, -0.10f, 0.20f * amplitudeScale, 0.05f });

        AddLoopGestureCurve(clip, "Left Arm Down-Up", duration, new[] { -0.38f, -0.22f, -0.18f, -0.30f, -0.38f });
        AddLoopGestureCurve(clip, "Left Arm Front-Back", duration, new[] { 0.12f, 0.20f, 0.38f * amplitudeScale, 0.18f, 0.12f });
        AddLoopGestureCurve(clip, "Left Forearm Stretch", duration, new[] { -0.12f, 0.10f, 0.34f * amplitudeScale, 0.05f, -0.12f });
        AddLoopGestureCurve(clip, "Left Hand Down-Up", duration, new[] { 0.0f, -0.08f, 0.22f * amplitudeScale, -0.05f, 0.0f });

        AnimationClipSettings settings = AnimationUtility.GetAnimationClipSettings(baseIdle);
        settings.loopTime = true;
        settings.keepOriginalPositionY = true;
        AnimationUtility.SetAnimationClipSettings(clip, settings);

        AssetDatabase.CreateAsset(clip, destPath);
        EditorUtility.SetDirty(clip);
        return clip;
    }

    private static void AddLoopGestureCurve(AnimationClip clip, string muscleProp, float duration, float[] values5)
    {
        EditorCurveBinding b = new EditorCurveBinding
        {
            type = typeof(Animator),
            path = "",
            propertyName = muscleProp
        };

        Keyframe[] keys = new Keyframe[values5.Length];
        for (int i = 0; i < values5.Length; i++)
        {
            float t = (duration * i) / (values5.Length - 1);
            keys[i] = new Keyframe(t, values5[i]);
        }
        AnimationCurve curve = new AnimationCurve(keys);
        for (int i = 0; i < keys.Length; i++)
        {
            AnimationUtility.SetKeyBroken(curve, i, false);
        }
        AnimationUtility.SetEditorCurve(clip, b, curve);
    }

    private static AnimationClip CreateRemyStandUpClip(string destPath, AnimationClip sitClip, AnimationClip standIdleClip, float duration)
    {
        if (AssetDatabase.LoadAssetAtPath<AnimationClip>(destPath) != null)
        {
            AssetDatabase.DeleteAsset(destPath);
        }

        AnimationClip clip = new AnimationClip();
        clip.name = System.IO.Path.GetFileNameWithoutExtension(destPath);
        clip.frameRate = 30f;

        Dictionary<string, EditorCurveBinding> allBindings = new Dictionary<string, EditorCurveBinding>();
        Dictionary<string, float> startVals = new Dictionary<string, float>();
        Dictionary<string, float> endVals = new Dictionary<string, float>();

        foreach (EditorCurveBinding b in AnimationUtility.GetCurveBindings(sitClip))
        {
            AnimationCurve c = AnimationUtility.GetEditorCurve(sitClip, b);
            if (c == null) continue;
            string k = b.path + "|" + b.propertyName;
            allBindings[k] = b;
            startVals[k] = c.Evaluate(0f);
        }

        foreach (EditorCurveBinding b in AnimationUtility.GetCurveBindings(standIdleClip))
        {
            AnimationCurve c = AnimationUtility.GetEditorCurve(standIdleClip, b);
            if (c == null) continue;
            string k = b.path + "|" + b.propertyName;
            if (!allBindings.ContainsKey(k)) allBindings[k] = b;
            endVals[k] = c.Evaluate(0f);
        }

        foreach (var kv in allBindings)
        {
            float vStart = startVals.ContainsKey(kv.Key) ? startVals[kv.Key] : 0f;
            float vEnd = endVals.ContainsKey(kv.Key) ? endVals[kv.Key] : 0f;
            float vMid = Mathf.Lerp(vStart, vEnd, 0.45f);

            if (kv.Value.propertyName == "Spine Front-Back" || kv.Value.propertyName == "Chest Front-Back")
            {
                vMid += 0.20f;
            }

            AnimationCurve curve = new AnimationCurve(
                new Keyframe(0f, vStart),
                new Keyframe(duration * 0.42f, vMid),
                new Keyframe(duration, vEnd)
            );
            AnimationUtility.SetEditorCurve(clip, kv.Value, curve);
        }

        AnimationClipSettings settings = AnimationUtility.GetAnimationClipSettings(standIdleClip);
        settings.loopTime = false;
        settings.keepOriginalPositionY = true;
        AnimationUtility.SetAnimationClipSettings(clip, settings);

        AssetDatabase.CreateAsset(clip, destPath);
        EditorUtility.SetDirty(clip);
        return clip;
    }
}
