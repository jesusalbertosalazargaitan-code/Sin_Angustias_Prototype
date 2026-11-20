using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.InputSystem;
using Cinemachine;

public static class SetupCinemachine
{
    private const string SCENE_LVL1 = "Assets/_Scenes/Lvl 1.unity";
    private const string SCENE_LVL2 = "Assets/_Scenes/Lvl 2.unity";

    [MenuItem("Tools/Setup Cinemachine First Person")]
    public static void ExecuteAll()
    {
        Debug.Log("[SetupCinemachine] Starting Cinemachine setup on Lvl 1 and Lvl 2...");
        ConfigureScene(SCENE_LVL1);
        ConfigureScene(SCENE_LVL2);

        // Reopen Lvl 1 when finished
        EditorSceneManager.OpenScene(SCENE_LVL1, OpenSceneMode.Single);
        AssetDatabase.SaveAssets();
        Debug.Log("[SetupCinemachine] Finished successfully!");
    }

    private static void ConfigureScene(string scenePath)
    {
        var scene = EditorSceneManager.OpenScene(scenePath, OpenSceneMode.Single);
        Debug.Log($"[SetupCinemachine] Configuring scene: {scenePath}");

        GameObject player = GameObject.Find("Player");
        if (player == null)
        {
            Debug.LogError($"[SetupCinemachine] Player not found in {scenePath}");
            return;
        }

        // 1. CameraRoot under Player
        Transform cameraRoot = player.transform.Find("CameraRoot");
        if (cameraRoot == null)
        {
            GameObject crObj = new GameObject("CameraRoot");
            Undo.RegisterCreatedObjectUndo(crObj, "Create CameraRoot");
            crObj.transform.SetParent(player.transform);
            cameraRoot = crObj.transform;
            Debug.Log("[SetupCinemachine] Created CameraRoot");
        }
        Undo.RecordObject(cameraRoot, "Update CameraRoot Position");
        cameraRoot.localPosition = new Vector3(0f, 1.56f, 0.15f);
        cameraRoot.localRotation = Quaternion.identity;

        // 2. Main Camera
        GameObject mainCamObj = GameObject.Find("Player/Main Camera");
        if (mainCamObj == null) mainCamObj = GameObject.Find("Main Camera");

        if (mainCamObj == null)
        {
            Debug.LogError($"[SetupCinemachine] Main Camera not found in {scenePath}");
            return;
        }

        CinemachineBrain brain = mainCamObj.GetComponent<CinemachineBrain>();
        if (brain == null)
        {
            brain = Undo.AddComponent<CinemachineBrain>(mainCamObj);
            Debug.Log("[SetupCinemachine] Added CinemachineBrain to Main Camera");
        }
        brain.m_UpdateMethod = CinemachineBrain.UpdateMethod.LateUpdate;
        brain.m_BlendUpdateMethod = CinemachineBrain.BrainUpdateMethod.LateUpdate;

        // Clean up redundant PlayerInput on Main Camera
        PlayerInput camInput = mainCamObj.GetComponent<PlayerInput>();
        if (camInput != null)
        {
            Undo.DestroyObjectImmediate(camInput);
            Debug.Log("[SetupCinemachine] Removed redundant PlayerInput on Main Camera");
        }

        // 3. Virtual Camera
        GameObject vcamObj = GameObject.Find("CM vcam_FirstPerson");
        CinemachineVirtualCamera vcam;
        if (vcamObj == null)
        {
            vcamObj = new GameObject("CM vcam_FirstPerson");
            Undo.RegisterCreatedObjectUndo(vcamObj, "Create CM vcam_FirstPerson");
            vcam = vcamObj.AddComponent<CinemachineVirtualCamera>();
            Debug.Log("[SetupCinemachine] Created CM vcam_FirstPerson");
        }
        else
        {
            vcam = vcamObj.GetComponent<CinemachineVirtualCamera>();
        }

        vcam.Follow = cameraRoot;
        vcam.m_Lens.FieldOfView = 70f;
        vcam.m_Lens.NearClipPlane = 0.15f;
        vcam.m_Lens.FarClipPlane = 1000f;

        // Hard Lock to Target
        var hardLock = vcam.GetCinemachineComponent<CinemachineHardLockToTarget>();
        if (hardLock == null)
        {
            hardLock = vcam.AddCinemachineComponent<CinemachineHardLockToTarget>();
        }

        // POV
        var pov = vcam.GetCinemachineComponent<CinemachinePOV>();
        if (pov == null)
        {
            pov = vcam.AddCinemachineComponent<CinemachinePOV>();
        }
        pov.m_VerticalAxis.m_MinValue = -60f;
        pov.m_VerticalAxis.m_MaxValue = 65f;
        pov.m_VerticalAxis.m_Wrap = false;
        pov.m_HorizontalAxis.m_MinValue = -180f;
        pov.m_HorizontalAxis.m_MaxValue = 180f;
        pov.m_HorizontalAxis.m_Wrap = true;

        EditorUtility.SetDirty(vcam);
        EditorUtility.SetDirty(pov);

        float gain = 15f * 0.015f;
        pov.m_VerticalAxis.m_SpeedMode = AxisState.SpeedMode.InputValueGain;
        pov.m_HorizontalAxis.m_SpeedMode = AxisState.SpeedMode.InputValueGain;
        pov.m_VerticalAxis.m_MaxSpeed = gain;
        pov.m_HorizontalAxis.m_MaxSpeed = gain;

        // Input provider
        var inputProvider = vcamObj.GetComponent<CinemachineInputProvider>();
        if (inputProvider == null)
        {
            inputProvider = vcamObj.AddComponent<CinemachineInputProvider>();
        }

        InputActionAsset inputAsset = AssetDatabase.LoadAssetAtPath<InputActionAsset>("Assets/PlayerControllerInput.inputactions");
        if (inputAsset != null)
        {
            InputAction camAction = inputAsset.FindAction("Player/camera");
            if (camAction != null)
            {
                inputProvider.XYAxis = InputActionReference.Create(camAction);
            }
        }

        // Wire to CameraController
        CameraController camCtrl = mainCamObj.GetComponent<CameraController>();
        if (camCtrl != null)
        {
            camCtrl.virtualCamera = vcam;
            camCtrl.playerController = player.GetComponent<PlayerController>();
            camCtrl.player = player.transform;
            EditorUtility.SetDirty(camCtrl);
        }

        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        Debug.Log($"[SetupCinemachine] Saved scene: {scenePath}");
    }
}
