using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using System.Reflection;
using System.Collections.Generic;

public static class SetupLightingFix
{
    private const string SCENE_MENU = "Assets/_Scenes/MainMenú.unity";
    private const string SCENE_LVL1 = "Assets/_Scenes/Lvl 1.unity";
    private const string SCENE_LVL2 = "Assets/_Scenes/Lvl 2.unity";

    [MenuItem("Tools/Apply Lighting and Atmosphere Fix")]
    public static void ExecuteAll()
    {
        Debug.Log("======================================================================");
        Debug.Log("[SetupLightingFix] INICIANDO APLICACIÓN DEL PLAN TÉCNICO DE ILUMINACIÓN");
        Debug.Log("======================================================================");

        // PASO 1, 2, 3, 4: Configurar escenas en estricto orden técnico
        ConfigureMainMenu();
        ConfigureLvl1();
        ConfigureLvl2();

        // PASO 5: Verificación integral
        RunVerification();

        // Abrir Lvl 1 por defecto al terminar
        EditorSceneManager.OpenScene(SCENE_LVL1, OpenSceneMode.Single);

        AssetDatabase.SaveAssets();
        Debug.Log("======================================================================");
        Debug.Log("[SetupLightingFix] ¡PLAN TÉCNICO COMPLETADO Y GUARDADO EXITOSAMENTE!");
        Debug.Log("======================================================================");
    }

    private static void DisableOrphanBakedGI()
    {
        Lightmapping.bakedGI = false;
        Lightmapping.realtimeGI = false;

        // Limpiar referencia de LightingDataAsset huérfano si existe a nivel de editor
        PropertyInfo ldaProp = typeof(Lightmapping).GetProperty("lightingDataAsset", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
        if (ldaProp != null && ldaProp.CanWrite)
        {
            ldaProp.SetValue(null, null);
        }

        System.Type lightmapEditorSettingsType = typeof(LightmapEditorSettings);
        PropertyInfo bakedProp = lightmapEditorSettingsType.GetProperty("bakedGI", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
        if (bakedProp != null && bakedProp.CanWrite)
        {
            bakedProp.SetValue(null, false);
        }
        PropertyInfo realtimeProp = lightmapEditorSettingsType.GetProperty("realtimeGI", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
        if (realtimeProp != null && realtimeProp.CanWrite)
        {
            realtimeProp.SetValue(null, false);
        }

        // Acceder directamente a LightmapSettings en la escena a través de SerializedObject
        LightmapSettings[] allLms = Resources.FindObjectsOfTypeAll<LightmapSettings>();
        Debug.Log("[DisableOrphanBakedGI] Found LightmapSettings count: " + allLms.Length);
        foreach (var s in allLms)
        {
            SerializedObject so = new SerializedObject(s);
            SerializedProperty gi = so.FindProperty("m_GISettings");
            if (gi != null)
            {
                SerializedProperty baked = gi.FindPropertyRelative("m_EnableBakedLightmaps");
                if (baked != null)
                {
                    baked.boolValue = false;
                }
                SerializedProperty realtime = gi.FindPropertyRelative("m_EnableRealtimeLightmaps");
                if (realtime != null)
                {
                    realtime.boolValue = false;
                }
                so.ApplyModifiedProperties();
                Debug.Log($"[DisableOrphanBakedGI] Modificado LightmapSettings '{s.name}' con éxito: Baked=0, Realtime=0.");
            }
        }
    }

    private static void ConfigureMainMenu()
    {
        Debug.Log("\n--- CONFIGURANDO: " + SCENE_MENU + " ---");
        Scene scene = EditorSceneManager.OpenScene(SCENE_MENU, OpenSceneMode.Single);

        DisableOrphanBakedGI();

        // PASO 3: Optimización de MainMenú.unity
        Light[] lights = Object.FindObjectsOfType<Light>(true);
        foreach (Light l in lights)
        {
            if (l.type == LightType.Directional)
            {
                l.shadows = LightShadows.None;
                l.lightmapBakeType = LightmapBakeType.Realtime;
                EditorUtility.SetDirty(l);
                Debug.Log($"[MainMenú] Directional Light '{l.name}': Shadows=None, Mode=Realtime");
            }
            if (l.type == LightType.Point)
            {
                l.shadows = LightShadows.None;
                EditorUtility.SetDirty(l);
                Debug.Log($"[MainMenú] Point Light '{l.name}': Shadows=None");
            }
        }

        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        Debug.Log("[MainMenú] Guardada con éxito.");
    }

    private static void ConfigureLvl1()
    {
        Debug.Log("\n--- CONFIGURANDO: " + SCENE_LVL1 + " (Bosque y Pirámide) ---");
        Scene scene = EditorSceneManager.OpenScene(SCENE_LVL1, OpenSceneMode.Single);

        // PASO 1.1: Desactivar Baked GI huérfano
        DisableOrphanBakedGI();

        // PASO 1.2: Cambiar Ambient Mode a Trilight (Gradient) y colores exteriores
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Trilight;
        RenderSettings.ambientSkyColor = new Color(0.55f, 0.62f, 0.75f, 1.0f);
        RenderSettings.ambientEquatorColor = new Color(0.45f, 0.42f, 0.38f, 1.0f);
        RenderSettings.ambientGroundColor = new Color(0.25f, 0.22f, 0.18f, 1.0f);
        RenderSettings.ambientIntensity = 1.2f;
        Debug.Log("[Lvl 1] AmbientMode=Trilight, Intensity=1.2, Sky=RGBA(0.55, 0.62, 0.75, 1.0)");

        // PASO 4.1: Niebla Andina (San Agustín)
        RenderSettings.fog = true;
        RenderSettings.fogMode = FogMode.Linear;
        RenderSettings.fogStartDistance = 30f;
        RenderSettings.fogEndDistance = 160f;
        RenderSettings.fogColor = new Color(0.48f, 0.54f, 0.65f, 1.0f);
        Debug.Log("[Lvl 1] Fog=true, Mode=Linear (30m - 160m), Color=RGBA(0.48, 0.54, 0.65, 1.0)");

        // PASO 1.3: Ajustar Directional Light (ID: 984701940)
        Light dirLight = null;
        Light[] lights = Object.FindObjectsOfType<Light>(true);
        foreach (Light l in lights)
        {
            if (l.type == LightType.Directional)
            {
                dirLight = l;
                l.lightmapBakeType = LightmapBakeType.Realtime;
                l.shadows = LightShadows.Soft;
                l.shadowStrength = 0.72f;
                l.intensity = 1.15f;
                EditorUtility.SetDirty(l);
                Debug.Log($"[Lvl 1] Directional Light '{l.name}': Shadows=Soft, Strength=0.72, Intensity=1.15, Mode=Realtime");
            }
        }

        if (dirLight != null)
        {
            RenderSettings.sun = dirLight;
            Debug.Log("[Lvl 1] RenderSettings.sun enlazado a: " + dirLight.name);
        }

        // PASO 2.1: Eliminar residuos IntermitentL.cs en Lvl 1
        IntermitentL[] intermitents = Object.FindObjectsOfType<IntermitentL>(true);
        foreach (var item in intermitents)
        {
            Debug.Log($"[Lvl 1] Eliminando GameObject residual con IntermitentL: '{item.gameObject.name}'");
            Object.DestroyImmediate(item.gameObject);
        }

        // PASO 2.2: Corregir conflicto de doble luz en el Jugador (Player)
        GameObject player = GameObject.Find("Player");
        if (player != null)
        {
            Transform cam = player.transform.Find("Main Camera");
            if (cam != null)
            {
                Transform camPointLight = cam.Find("Point Light");
                if (camPointLight != null)
                {
                    Debug.Log("[Lvl 1] Eliminando Point Light redundante en la cámara del jugador: " + camPointLight.name);
                    Object.DestroyImmediate(camPointLight.gameObject);
                }
            }

            // Ajustar linterna Spot Light
            Light[] playerLights = player.GetComponentsInChildren<Light>(true);
            foreach (Light pl in playerLights)
            {
                if (pl.type == LightType.Spot)
                {
                    pl.innerSpotAngle = 25.0f;
                    pl.spotAngle = 55.0f;
                    pl.range = 15.0f;
                    pl.intensity = 1.4f;
                    pl.shadows = LightShadows.None;
                    EditorUtility.SetDirty(pl);
                    Debug.Log($"[Lvl 1] Spot Light linterna ajustada: InnerAngle=25.0, OuterAngle=55.0, Range=15.0m, Intensity=1.4, Shadows=None");
                }
            }
        }

        // Asegurar que ninguna Point Light en Lvl 1 tenga sombras activadas
        lights = Object.FindObjectsOfType<Light>(true);
        foreach (Light l in lights)
        {
            if (l.type == LightType.Point)
            {
                l.shadows = LightShadows.None;
                EditorUtility.SetDirty(l);
            }
        }

        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        Debug.Log("[Lvl 1] Guardada con éxito.");
    }

    private static void ConfigureLvl2()
    {
        Debug.Log("\n--- CONFIGURANDO: " + SCENE_LVL2 + " (Catacumbas y Altar) ---");
        Scene scene = EditorSceneManager.OpenScene(SCENE_LVL2, OpenSceneMode.Single);

        // PASO 1.1: Desactivar Baked GI huérfano
        DisableOrphanBakedGI();

        // PASO 1.2: Cambiar Ambient Mode a Trilight y colores tenues de catacumbas
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Trilight;
        RenderSettings.ambientSkyColor = new Color(0.12f, 0.14f, 0.18f, 1.0f);
        RenderSettings.ambientEquatorColor = new Color(0.08f, 0.08f, 0.10f, 1.0f);
        RenderSettings.ambientGroundColor = new Color(0.05f, 0.04f, 0.04f, 1.0f);
        RenderSettings.ambientIntensity = 1.0f;
        Debug.Log("[Lvl 2] AmbientMode=Trilight, Sky=RGBA(0.12, 0.14, 0.18), Equator=RGBA(0.08, 0.08, 0.10), Ground=RGBA(0.05, 0.04, 0.04)");

        // PASO 4.2: Niebla en Catacumbas
        RenderSettings.fog = true;
        RenderSettings.fogMode = FogMode.ExponentialSquared;
        RenderSettings.fogDensity = 0.022f;
        RenderSettings.fogColor = new Color(0.07f, 0.06f, 0.05f, 1.0f);
        Debug.Log("[Lvl 2] Fog=true, Mode=ExponentialSquared (Density=0.022), Color=RGBA(0.07, 0.06, 0.05, 1.0)");

        // PASO 2.1: Eliminar residuos IntermitentL.cs en Lvl 2
        IntermitentL[] intermitents = Object.FindObjectsOfType<IntermitentL>(true);
        foreach (var item in intermitents)
        {
            Debug.Log($"[Lvl 2] Eliminando GameObject residual con IntermitentL: '{item.gameObject.name}'");
            Object.DestroyImmediate(item.gameObject);
        }

        // PASO 2.2: Corregir Player en Lvl 2
        GameObject player = GameObject.Find("Player");
        if (player != null)
        {
            Transform cam = player.transform.Find("Main Camera");
            if (cam != null)
            {
                Transform camPointLight = cam.Find("Point Light");
                if (camPointLight != null)
                {
                    Light plLight = camPointLight.GetComponent<Light>();
                    if (plLight != null)
                    {
                        plLight.range = 3.5f;
                        plLight.intensity = 0.25f;
                        plLight.color = new Color(1.0f, 0.9f, 0.75f, 1.0f);
                        plLight.shadows = LightShadows.None;
                        EditorUtility.SetDirty(plLight);
                        Debug.Log("[Lvl 2] Player Camera Point Light: Range=3.5, Intensity=0.25, Color=RGBA(1.0, 0.9, 0.75), Shadows=None");
                    }
                }
            }

            // Spot Light de linterna
            Light[] playerLights = player.GetComponentsInChildren<Light>(true);
            foreach (Light pl in playerLights)
            {
                if (pl.type == LightType.Spot)
                {
                    pl.innerSpotAngle = 25.0f;
                    pl.spotAngle = 55.0f;
                    pl.range = 15.0f;
                    pl.intensity = 1.4f;
                    pl.shadows = LightShadows.None;
                    EditorUtility.SetDirty(pl);
                    Debug.Log($"[Lvl 2] Spot Light linterna ajustada: InnerAngle=25.0, OuterAngle=55.0, Range=15.0m, Intensity=1.4, Shadows=None");
                }
            }
        }

        // Asegurar que ninguna Point Light en Lvl 2 tenga sombras (incluyendo reliquias y pedestales)
        Light[] lights = Object.FindObjectsOfType<Light>(true);
        foreach (Light l in lights)
        {
            if (l.type == LightType.Point)
            {
                l.shadows = LightShadows.None;
                EditorUtility.SetDirty(l);
            }
        }

        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        Debug.Log("[Lvl 2] Guardada con éxito.");
    }

    private static void RunVerification()
    {
        Debug.Log("\n=================================================");
        Debug.Log("[SetupLightingFix] EJECUTANDO VERIFICACIÓN POST-EJECUCIÓN");
        Debug.Log("=================================================");

        string[] scenes = { SCENE_MENU, SCENE_LVL1, SCENE_LVL2 };
        int pointLightsWithShadows = 0;

        foreach (string s in scenes)
        {
            Scene scene = EditorSceneManager.OpenScene(s, OpenSceneMode.Single);
            Light[] lights = Object.FindObjectsOfType<Light>(true);

            foreach (Light l in lights)
            {
                if (l.type == LightType.Point && l.shadows != LightShadows.None)
                {
                    pointLightsWithShadows++;
                    Debug.LogError($"[VERIFICACIÓN ERROR] {s}: Point Light '{l.name}' tiene sombras: {l.shadows}");
                }
                if (s == SCENE_LVL1 && l.type == LightType.Directional)
                {
                    if (l.shadowStrength > 0.75f)
                    {
                        Debug.LogError($"[VERIFICACIÓN ERROR] Lvl 1 Directional Light shadowStrength es {l.shadowStrength} > 0.75");
                    }
                    else
                    {
                        Debug.Log($"[VERIFICACIÓN OK] Lvl 1 Directional Light shadowStrength = {l.shadowStrength} (<= 0.75)");
                    }
                }
            }
        }

        if (pointLightsWithShadows == 0)
        {
            Debug.Log("[VERIFICACIÓN OK] Cero Point Lights tienen sombras activadas en todas las escenas.");
        }
    }
}
