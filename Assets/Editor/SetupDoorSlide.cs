using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public static class SetupDoorSlide
{
    private const string AUDIO_CLIP_PATH = "Assets/_Music/Cadena_arrastrandose.mp3";

    [MenuItem("Tools/Setup Door Slide Controller")]
    public static void Execute()
    {
        Debug.Log("[SetupDoorSlide] Iniciando configuración de DoorSlideController...");

        // 1. Localizar Puerta_Salida_Caver1
        GameObject puerta = GameObject.Find("Puerta_Salida_Caver1");
        if (puerta == null)
        {
            Debug.LogError("[SetupDoorSlide] No se encontró el objeto 'Puerta_Salida_Caver1' en la escena.");
            return;
        }

        Undo.RegisterCompleteObjectUndo(puerta, "Configure DoorSlideController on Puerta_Salida_Caver1");

        // Configurar DoorSlideController
        DoorSlideController doorController = puerta.GetComponent<DoorSlideController>();
        if (doorController == null)
        {
            doorController = puerta.AddComponent<DoorSlideController>();
        }

        doorController.slideDistance = 4.2f;
        doorController.slideSpeed = 1.5f;

        // Configurar AudioSource
        AudioSource audioSource = puerta.GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = puerta.AddComponent<AudioSource>();
        }

        audioSource.playOnAwake = false;
        audioSource.loop = false;
        audioSource.spatialBlend = 1.0f; // Audio 3D posicional en catacumbas
        audioSource.minDistance = 3f;
        audioSource.maxDistance = 35f;

        AudioClip clip = AssetDatabase.LoadAssetAtPath<AudioClip>(AUDIO_CLIP_PATH);
        if (clip != null)
        {
            audioSource.clip = clip;
            Debug.Log($"[SetupDoorSlide] Audio clip asignado: {AUDIO_CLIP_PATH}");
        }
        else
        {
            Debug.LogWarning($"[SetupDoorSlide] No se encontró el audio clip en {AUDIO_CLIP_PATH}");
        }

        doorController.audioSource = audioSource;
        EditorUtility.SetDirty(puerta);

        // 2. Enlazar en RelicInventoryUI
        RelicInventoryUI relicUI = Object.FindObjectOfType<RelicInventoryUI>();
        if (relicUI != null)
        {
            Undo.RegisterCompleteObjectUndo(relicUI, "Link exitDoor in RelicInventoryUI");
            relicUI.exitDoor = doorController;
            EditorUtility.SetDirty(relicUI);
            Debug.Log("[SetupDoorSlide] Enlazado exitDoor en RelicInventoryUI exitosamente.");
        }
        else
        {
            Debug.LogWarning("[SetupDoorSlide] No se encontró RelicInventoryUI en la escena.");
        }

        // 3. Verificar y asegurar enlace en AltarInteraction
        AltarInteraction altar = Object.FindObjectOfType<AltarInteraction>();
        if (altar != null)
        {
            Undo.RegisterCompleteObjectUndo(altar, "Verify puertaSalidaCaver1 in AltarInteraction");
            altar.puertaSalidaCaver1 = puerta;
            EditorUtility.SetDirty(altar);
            Debug.Log("[SetupDoorSlide] Enlace de puertaSalidaCaver1 en AltarInteraction verificado.");
        }
        else
        {
            Debug.LogWarning("[SetupDoorSlide] No se encontró AltarInteraction en la escena.");
        }

        // 4. Marcar escena como sucia para guardar
        EditorSceneManager.MarkSceneDirty(puerta.scene);
        Debug.Log("[SetupDoorSlide] Configuración completada con éxito.");
    }
}
