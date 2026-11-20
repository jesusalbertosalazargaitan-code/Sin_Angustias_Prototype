using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class SetupAudioSystem
{
    private const string SCENE_MENU = "Assets/_Scenes/MainMenú.unity";
    private const string SCENE_LVL1 = "Assets/_Scenes/Lvl 1.unity";
    private const string SCENE_LVL2 = "Assets/_Scenes/Lvl 2.unity";

    private const string CLIP_AMBIENTE_LVL1 = "Assets/_Music/ambiente_level1.mp3";
    private const string CLIP_SUSPENSO = "Assets/_Music/Ambiente_suspenso.mp3";
    private const string CLIP_LINTERNA = "Assets/_Music/Linterna_.mp3";
    private const string CLIP_PASOS_LVL1 = "Assets/_Music/Pasos en pasto (Nivel 1).mp3";
    private const string CLIP_PASOS_LVL2 = "Assets/_Music/Pasos en cueva (Nivel 2).mp3";
    private const string CLIP_RECOLECTABLES_LVL2 = "Assets/_Music/Sonido de Recolectables (Nivel 2).mp3";

    [MenuItem("Tools/Setup Audio System")]
    public static void ExecuteAll()
    {
        AudioClip ambienteLvl1Clip = LoadClipOrFail(CLIP_AMBIENTE_LVL1);
        AudioClip suspensoClip = LoadClipOrFail(CLIP_SUSPENSO);
        AudioClip linternaClip = LoadClipOrFail(CLIP_LINTERNA);
        AudioClip pasosLvl1Clip = LoadClipOrFail(CLIP_PASOS_LVL1);
        AudioClip pasosLvl2Clip = LoadClipOrFail(CLIP_PASOS_LVL2);
        AudioClip recolectablesLvl2Clip = LoadClipOrFail(CLIP_RECOLECTABLES_LVL2);

        if (ambienteLvl1Clip == null || suspensoClip == null || linternaClip == null ||
            pasosLvl1Clip == null || pasosLvl2Clip == null || recolectablesLvl2Clip == null)
        {
            Debug.LogError("[SetupAudioSystem] Aborting: one or more AudioClips could not be loaded.");
            return;
        }

        string initialScenePath = SceneManager.GetActiveScene().path;

        ConfigureMainMenu(ambienteLvl1Clip);
        ConfigureLevel1(ambienteLvl1Clip, pasosLvl1Clip, linternaClip);
        ConfigureLevel2(pasosLvl2Clip, linternaClip, recolectablesLvl2Clip, suspensoClip);

        if (!string.IsNullOrEmpty(initialScenePath))
        {
            EditorSceneManager.OpenScene(initialScenePath, OpenSceneMode.Single);
        }

        AssetDatabase.SaveAssets();
        Debug.Log("[SetupAudioSystem] Audio setup completed across MainMenú, Lvl 1, and Lvl 2.");
    }

    private static AudioClip LoadClipOrFail(string path)
    {
        AudioClip clip = AssetDatabase.LoadAssetAtPath<AudioClip>(path);
        if (clip == null)
        {
            Debug.LogError($"[SetupAudioSystem] Missing AudioClip at '{path}'");
        }
        return clip;
    }

    private static void ConfigureMainMenu(AudioClip ambienteClip)
    {
        Scene scene = EditorSceneManager.OpenScene(SCENE_MENU, OpenSceneMode.Single);

        AudioSource src = EnsureSceneAudioObject("Audio_Ambiente_Menu");
        src.clip = ambienteClip;
        src.playOnAwake = true;
        src.loop = true;
        src.spatialBlend = 0f;
        src.volume = 0.35f;
        EditorUtility.SetDirty(src);

        VerifyGameManagerSlider(SCENE_MENU);

        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        Debug.Log("[SetupAudioSystem] Saved MainMenú.unity cleanly.");
    }

    private static void ConfigureLevel1(AudioClip ambienteClip, AudioClip pasosClip, AudioClip linternaClip)
    {
        Scene scene = EditorSceneManager.OpenScene(SCENE_LVL1, OpenSceneMode.Single);

        AudioSource ambSrc = EnsureSceneAudioObject("Audio_Ambiente_Lvl1");
        ambSrc.clip = ambienteClip;
        ambSrc.playOnAwake = true;
        ambSrc.loop = true;
        ambSrc.spatialBlend = 0f;
        ambSrc.volume = 0.5f;
        EditorUtility.SetDirty(ambSrc);

        ConfigurePlayerAudio(SCENE_LVL1, pasosClip, linternaClip);

        // Ensure NO SuspenseAudioController exists in Lvl 1.unity
        SuspenseAudioController[] straySuspense = Object.FindObjectsOfType<SuspenseAudioController>(true);
        foreach (var ctrl in straySuspense)
        {
            Debug.LogWarning($"[SetupAudioSystem] Removing unexpected SuspenseAudioController from Lvl 1 on '{ctrl.gameObject.name}'.");
            Undo.DestroyObjectImmediate(ctrl.gameObject);
        }

        VerifyGameManagerSlider(SCENE_LVL1);

        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        Debug.Log("[SetupAudioSystem] Saved Lvl 1.unity cleanly.");
    }

    private static void ConfigureLevel2(AudioClip pasosClip, AudioClip linternaClip, AudioClip pickupClip, AudioClip suspensoClip)
    {
        Scene scene = EditorSceneManager.OpenScene(SCENE_LVL2, OpenSceneMode.Single);

        ConfigurePlayerAudio(SCENE_LVL2, pasosClip, linternaClip);

        RelicInventoryUI relicUI = Object.FindObjectOfType<RelicInventoryUI>(true);
        if (relicUI == null)
        {
            Debug.LogError("[SetupAudioSystem] RelicInventoryUI not found in Lvl 2.unity!");
        }
        else
        {
            AudioSource pickupSrc = relicUI.GetComponent<AudioSource>();
            if (pickupSrc == null)
            {
                pickupSrc = Undo.AddComponent<AudioSource>(relicUI.gameObject);
            }
            pickupSrc.clip = null;
            pickupSrc.playOnAwake = false;
            pickupSrc.loop = false;
            pickupSrc.spatialBlend = 0f;
            pickupSrc.volume = 1.0f;

            relicUI.pickupAudioSource = pickupSrc;
            relicUI.pickupClip = pickupClip;

            EditorUtility.SetDirty(pickupSrc);
            EditorUtility.SetDirty(relicUI);
            Debug.Log($"[SetupAudioSystem] Configured RelicInventoryUI audio on '{relicUI.gameObject.name}'.");
        }

        AudioSource suspSrc = EnsureSceneAudioObject("Audio_Suspenso_Lvl2");
        suspSrc.clip = null;
        suspSrc.playOnAwake = false;
        suspSrc.loop = false;
        suspSrc.spatialBlend = 0f;
        suspSrc.volume = 0.85f;

        SuspenseAudioController suspenseCtrl = suspSrc.GetComponent<SuspenseAudioController>();
        if (suspenseCtrl == null)
        {
            suspenseCtrl = Undo.AddComponent<SuspenseAudioController>(suspSrc.gameObject);
        }
        suspenseCtrl.suspenseSource = suspSrc;
        suspenseCtrl.suspenseClip = suspensoClip;
        suspenseCtrl.minCooldown = 28f;
        suspenseCtrl.minRandomInterval = 30f;
        suspenseCtrl.maxRandomInterval = 45f;
        suspenseCtrl.volume = 0.85f;
        EditorUtility.SetDirty(suspSrc);
        EditorUtility.SetDirty(suspenseCtrl);

        // Log verification of untouched Lvl 2 audio sources
        AudioSource[] allSources = Object.FindObjectsOfType<AudioSource>(true);
        foreach (var s in allSources)
        {
            if (s.clip != null && (s.clip.name.Contains("Zombie") || s.clip.name.Contains("Cadena")))
            {
                Debug.Log($"[SetupAudioSystem] Verified existing Lvl 2 AudioSource on '{s.gameObject.name}' -> clip='{s.clip.name}', playOnAwake={s.playOnAwake}, loop={s.loop}");
            }
        }

        VerifyGameManagerSlider(SCENE_LVL2);

        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        Debug.Log("[SetupAudioSystem] Saved Lvl 2.unity cleanly.");
    }

    private static AudioSource EnsureSceneAudioObject(string objectName)
    {
        GameObject go = GameObject.Find(objectName);
        if (go == null)
        {
            go = new GameObject(objectName);
            Undo.RegisterCreatedObjectUndo(go, "Create " + objectName);
        }
        AudioSource src = go.GetComponent<AudioSource>();
        if (src == null)
        {
            src = Undo.AddComponent<AudioSource>(go);
        }
        return src;
    }

    private static void ConfigurePlayerAudio(string scenePath, AudioClip pasosClip, AudioClip linternaClip)
    {
        PlayerController playerCtrl = Object.FindObjectOfType<PlayerController>(true);
        if (playerCtrl == null)
        {
            Debug.LogError($"[SetupAudioSystem] PlayerController not found in {scenePath}");
            return;
        }

        GameObject playerGO = playerCtrl.gameObject;
        AudioSource[] existing = playerGO.GetComponents<AudioSource>();

        AudioSource footstepSrc = playerCtrl.footstepSource;
        if (footstepSrc == null)
        {
            footstepSrc = existing.Length >= 1 ? existing[0] : Undo.AddComponent<AudioSource>(playerGO);
        }

        AudioSource sfxSrc = playerCtrl.sfxSource;
        if (sfxSrc == null || sfxSrc == footstepSrc)
        {
            sfxSrc = null;
            foreach (var src in existing)
            {
                if (src != footstepSrc)
                {
                    sfxSrc = src;
                    break;
                }
            }
            if (sfxSrc == null)
            {
                sfxSrc = Undo.AddComponent<AudioSource>(playerGO);
            }
        }

        footstepSrc.clip = pasosClip;
        footstepSrc.playOnAwake = false;
        footstepSrc.loop = true;
        footstepSrc.spatialBlend = 0f;
        footstepSrc.volume = 0.65f;

        sfxSrc.clip = null;
        sfxSrc.playOnAwake = false;
        sfxSrc.loop = false;
        sfxSrc.spatialBlend = 0f;
        sfxSrc.volume = 1.0f;

        playerCtrl.footstepSource = footstepSrc;
        playerCtrl.sfxSource = sfxSrc;
        playerCtrl.flashlightClip = linternaClip;

        EditorUtility.SetDirty(footstepSrc);
        EditorUtility.SetDirty(sfxSrc);
        EditorUtility.SetDirty(playerCtrl);
        Debug.Log($"[SetupAudioSystem] Configured Player audio in {scenePath}: footsteps='{pasosClip.name}', sfx='{linternaClip.name}'.");
    }

    private static void VerifyGameManagerSlider(string scenePath)
    {
        GameManager gm = Object.FindObjectOfType<GameManager>(true);
        if (gm == null)
        {
            Debug.LogWarning($"[SetupAudioSystem] GameManager not found in {scenePath}");
            return;
        }

        if (gm.options == null)
        {
            Debug.LogWarning($"[SetupAudioSystem] GameManager.options is null in {scenePath}");
            return;
        }

        Slider slider = gm.options.GetComponentInChildren<Slider>(true);
        if (slider == null)
        {
            Debug.LogWarning($"[SetupAudioSystem] No Slider found inside GameManager.options ('{gm.options.name}') in {scenePath}");
            return;
        }

        if (Mathf.Approximately(slider.value, 0f))
        {
            slider.value = 1f;
            EditorUtility.SetDirty(slider);
        }
        Debug.Log($"[SetupAudioSystem] Verified GameManager.options ('{gm.options.name}') -> Slider ('{slider.name}') value={slider.value} in {scenePath}");
    }
}
