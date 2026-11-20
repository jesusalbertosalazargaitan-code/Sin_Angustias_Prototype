using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public static class SetupURPMigration
{
    private const string SCENE_LVL1 = "Assets/_Scenes/Lvl 1.unity";
    private const string TREE_BRANCHES_MAT = "Assets/Fantasy Forest Environment Free Sample/Materials/tree_branches.mat";
    private const string TREE_BRANCHES_TEX = "Assets/Fantasy Forest Environment Free Sample/Textures/tree_branches.png";
    private const string URP_TERRAIN_LIT_MAT = "Packages/com.unity.render-pipelines.universal/Runtime/Materials/TerrainLit.mat";

    [MenuItem("Tools/Migrate Project To URP")]
    public static void ExecuteAll()
    {
        Debug.Log("[SetupURPMigration] === INICIANDO MIGRACIÓN A URP ===");

        // 1. Verificar y asignar UniversalRenderPipelineAsset
        UniversalRenderPipelineAsset urpAsset = EnsureURPPipelineAsset();
        if (urpAsset == null)
        {
            Debug.LogError("[SetupURPMigration] No se pudo localizar ni crear un UniversalRenderPipelineAsset válido.");
            return;
        }

        // 2. Convertir materiales Standard / Built-in / rotos a Universal Render Pipeline/Lit
        int convertedCount = 0;
        int alreadyUrpFixedCount = 0;
        int skippedCount = 0;
        List<string> convertedPaths = new List<string>();

        Shader urpLit = Shader.Find("Universal Render Pipeline/Lit");
        if (urpLit == null)
        {
            Debug.LogError("[SetupURPMigration] Shader 'Universal Render Pipeline/Lit' devolvió null.");
            return;
        }

        string[] matGuids = AssetDatabase.FindAssets("t:Material", new[] { "Assets" });
        foreach (string guid in matGuids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            if (string.IsNullOrEmpty(path) || !path.EndsWith(".mat", StringComparison.OrdinalIgnoreCase))
                continue;

            if (string.Equals(path, TREE_BRANCHES_MAT, StringComparison.OrdinalIgnoreCase))
                continue;

            Material mat = AssetDatabase.LoadAssetAtPath<Material>(path);
            if (mat == null) continue;

            string shaderName = mat.shader != null ? mat.shader.name : string.Empty;

            if (shaderName.Contains("Skybox") ||
                shaderName.StartsWith("Shader Graphs/", StringComparison.Ordinal) ||
                shaderName.StartsWith("UI/", StringComparison.Ordinal) ||
                shaderName.StartsWith("Sprites/", StringComparison.Ordinal) ||
                shaderName.Contains("TextMeshPro") ||
                shaderName.Contains("TMP_"))
            {
                skippedCount++;
                continue;
            }

            SavedMaterialProps saved = ReadSavedProperties(mat);

            bool isTargetBuiltIn =
                shaderName == "Standard" ||
                shaderName == "Standard (Specular setup)" ||
                shaderName == "Legacy Shaders/Diffuse" ||
                shaderName == "Fantasy Forest/StandardNoCulling" ||
                shaderName == "Custom/VientoArbolBuiltIn" ||
                shaderName == "Toon/Team Fortress 2" ||
                shaderName == "Hidden/InternalErrorShader";

            bool isBrokenUrpMissingBaseMap =
                shaderName == "Universal Render Pipeline/Lit" &&
                mat.GetTexture("_BaseMap") == null &&
                saved.MainTex != null;

            if (!isTargetBuiltIn && !isBrokenUrpMissingBaseMap)
            {
                skippedCount++;
                continue;
            }

            ConvertMaterialToURPLit(mat, urpLit, saved, isTargetBuiltIn);
            convertedPaths.Add($"{path} (antes: {shaderName})");

            if (isTargetBuiltIn) convertedCount++;
            else alreadyUrpFixedCount++;
        }

        // 3. Verificar / configurar tree_branches.mat con Shader Graphs/Viento
        ConfigureTreeBranchesMaterial();

        // 4. Restaurar Terrain y guardar Lvl 1.unity
        RestoreTerrainInLvl1();

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        Debug.Log($"[SetupURPMigration] Resumen: {convertedCount} materiales convertidos a URP/Lit, {alreadyUrpFixedCount} materiales URP reparados (_BaseMap), {skippedCount} materiales omitidos.");
        foreach (string item in convertedPaths)
        {
            Debug.Log($"[SetupURPMigration] Migrado: {item}");
        }
    }

    private static UniversalRenderPipelineAsset EnsureURPPipelineAsset()
    {
        UniversalRenderPipelineAsset asset = GraphicsSettings.defaultRenderPipeline as UniversalRenderPipelineAsset;
        if (asset == null)
        {
            asset = AssetDatabase.LoadAssetAtPath<UniversalRenderPipelineAsset>("Assets/Settings/Ultra_PipelineAsset.asset");
        }
        if (asset == null)
        {
            string[] urpGuids = AssetDatabase.FindAssets("t:UniversalRenderPipelineAsset", new[] { "Assets" });
            if (urpGuids.Length > 0)
            {
                asset = AssetDatabase.LoadAssetAtPath<UniversalRenderPipelineAsset>(AssetDatabase.GUIDToAssetPath(urpGuids[0]));
            }
        }
        if (asset == null)
        {
            if (!AssetDatabase.IsValidFolder("Assets/Settings"))
            {
                AssetDatabase.CreateFolder("Assets", "Settings");
            }
            UniversalRendererData rendererData = ScriptableObject.CreateInstance<UniversalRendererData>();
            AssetDatabase.CreateAsset(rendererData, "Assets/Settings/URP_Renderer.asset");
            asset = UniversalRenderPipelineAsset.Create(rendererData);
            AssetDatabase.CreateAsset(asset, "Assets/Settings/URP_Asset.asset");
            AssetDatabase.SaveAssets();
            Debug.Log("[SetupURPMigration] Creado nuevo URP_Asset en Assets/Settings/URP_Asset.asset");
        }

        if (GraphicsSettings.defaultRenderPipeline != asset)
        {
            GraphicsSettings.defaultRenderPipeline = asset;
        }

        int currentQuality = QualitySettings.GetQualityLevel();
        string[] names = QualitySettings.names;
        for (int i = 0; i < names.Length; i++)
        {
            QualitySettings.SetQualityLevel(i, false);
            if (QualitySettings.renderPipeline == null)
            {
                QualitySettings.renderPipeline = asset;
                Debug.Log($"[SetupURPMigration] Asignado URP Asset a Quality Level '{names[i]}'");
            }
        }
        QualitySettings.SetQualityLevel(currentQuality, false);

        if (QualitySettings.renderPipeline == null)
        {
            QualitySettings.renderPipeline = asset;
        }

        Debug.Log($"[SetupURPMigration] GraphicsSettings.defaultRenderPipeline = {GraphicsSettings.defaultRenderPipeline?.name}; QualitySettings.renderPipeline = {QualitySettings.renderPipeline?.name}");
        return asset;
    }

    private struct SavedMaterialProps
    {
        public Texture MainTex;
        public Vector2 MainTexScale;
        public Vector2 MainTexOffset;
        public Texture BaseMap;
        public Vector2 BaseMapScale;
        public Vector2 BaseMapOffset;
        public bool HasColor;
        public Color Color;
        public bool HasBaseColor;
        public Color BaseColor;
        public Texture BumpMap;
        public float BumpScale;
        public Texture MetallicGlossMap;
        public float Metallic;
        public float Glossiness;
        public Texture OcclusionMap;
        public float OcclusionStrength;
        public Texture EmissionMap;
        public Color EmissionColor;
        public float Mode;
        public float Cutoff;
        public bool EmissionEnabled;
    }

    private static SavedMaterialProps ReadSavedProperties(Material mat)
    {
        SavedMaterialProps props = new SavedMaterialProps
        {
            MainTexScale = Vector2.one,
            MainTexOffset = Vector2.zero,
            BaseMapScale = Vector2.one,
            BaseMapOffset = Vector2.zero,
            Color = Color.white,
            BaseColor = Color.white,
            BumpScale = 1f,
            Metallic = 0f,
            Glossiness = 0.5f,
            OcclusionStrength = 1f,
            EmissionColor = Color.black,
            Mode = 0f,
            Cutoff = 0.5f,
            EmissionEnabled = mat.IsKeywordEnabled("_EMISSION")
        };

        SerializedObject so = new SerializedObject(mat);
        SerializedProperty savedProps = so.FindProperty("m_SavedProperties");
        if (savedProps == null) return props;

        SerializedProperty texEnvs = savedProps.FindPropertyRelative("m_TexEnvs");
        if (texEnvs != null && texEnvs.isArray)
        {
            for (int i = 0; i < texEnvs.arraySize; i++)
            {
                SerializedProperty entry = texEnvs.GetArrayElementAtIndex(i);
                string propName = entry.FindPropertyRelative("first").stringValue;
                SerializedProperty val = entry.FindPropertyRelative("second");
                Texture tex = val.FindPropertyRelative("m_Texture").objectReferenceValue as Texture;
                Vector2 scale = val.FindPropertyRelative("m_Scale").vector2Value;
                Vector2 offset = val.FindPropertyRelative("m_Offset").vector2Value;

                switch (propName)
                {
                    case "_MainTex":
                        props.MainTex = tex;
                        props.MainTexScale = scale;
                        props.MainTexOffset = offset;
                        break;
                    case "_BaseMap":
                        props.BaseMap = tex;
                        props.BaseMapScale = scale;
                        props.BaseMapOffset = offset;
                        break;
                    case "_BumpMap":
                        props.BumpMap = tex;
                        break;
                    case "_MetallicGlossMap":
                        props.MetallicGlossMap = tex;
                        break;
                    case "_OcclusionMap":
                        props.OcclusionMap = tex;
                        break;
                    case "_EmissionMap":
                        props.EmissionMap = tex;
                        break;
                }
            }
        }

        SerializedProperty floats = savedProps.FindPropertyRelative("m_Floats");
        if (floats != null && floats.isArray)
        {
            for (int i = 0; i < floats.arraySize; i++)
            {
                SerializedProperty entry = floats.GetArrayElementAtIndex(i);
                string propName = entry.FindPropertyRelative("first").stringValue;
                float fVal = entry.FindPropertyRelative("second").floatValue;

                switch (propName)
                {
                    case "_BumpScale": props.BumpScale = fVal; break;
                    case "_Metallic": props.Metallic = fVal; break;
                    case "_Glossiness": props.Glossiness = fVal; break;
                    case "_OcclusionStrength": props.OcclusionStrength = fVal; break;
                    case "_Mode": props.Mode = fVal; break;
                    case "_Cutoff": props.Cutoff = fVal; break;
                }
            }
        }

        SerializedProperty colors = savedProps.FindPropertyRelative("m_Colors");
        if (colors != null && colors.isArray)
        {
            for (int i = 0; i < colors.arraySize; i++)
            {
                SerializedProperty entry = colors.GetArrayElementAtIndex(i);
                string propName = entry.FindPropertyRelative("first").stringValue;
                Color cVal = entry.FindPropertyRelative("second").colorValue;

                switch (propName)
                {
                    case "_Color":
                        props.HasColor = true;
                        props.Color = cVal;
                        break;
                    case "_BaseColor":
                        props.HasBaseColor = true;
                        props.BaseColor = cVal;
                        break;
                    case "_EmissionColor":
                        props.EmissionColor = cVal;
                        break;
                }
            }
        }

        return props;
    }

    private static void ConvertMaterialToURPLit(Material mat, Shader urpLit, SavedMaterialProps saved, bool changeShader)
    {
        Undo.RecordObject(mat, "Convert Material to URP Lit");

        if (changeShader)
        {
            mat.shader = urpLit;
        }

        Texture albedoTex = saved.MainTex != null ? saved.MainTex : saved.BaseMap;
        Vector2 albedoScale = saved.MainTex != null ? saved.MainTexScale : saved.BaseMapScale;
        Vector2 albedoOffset = saved.MainTex != null ? saved.MainTexOffset : saved.BaseMapOffset;
        if (albedoScale == Vector2.zero) albedoScale = Vector2.one;

        if (albedoTex != null)
        {
            mat.SetTexture("_BaseMap", albedoTex);
            mat.SetTextureScale("_BaseMap", albedoScale);
            mat.SetTextureOffset("_BaseMap", albedoOffset);
            if (mat.HasProperty("_MainTex"))
            {
                mat.SetTexture("_MainTex", albedoTex);
                mat.SetTextureScale("_MainTex", albedoScale);
                mat.SetTextureOffset("_MainTex", albedoOffset);
            }
        }

        Color baseColor = saved.HasColor ? saved.Color : (saved.HasBaseColor ? saved.BaseColor : Color.white);
        if (saved.Mode <= 1f && baseColor.a <= 0.001f)
        {
            baseColor.a = 1f;
        }
        if (albedoTex != null && baseColor.r <= 0.001f && baseColor.g <= 0.001f && baseColor.b <= 0.001f)
        {
            baseColor = new Color(1f, 1f, 1f, baseColor.a);
        }
        mat.SetColor("_BaseColor", baseColor);
        if (mat.HasProperty("_Color")) mat.SetColor("_Color", baseColor);

        if (saved.BumpMap != null)
        {
            mat.SetTexture("_BumpMap", saved.BumpMap);
            mat.SetFloat("_BumpScale", saved.BumpScale);
            mat.EnableKeyword("_NORMALMAP");
        }

        if (saved.MetallicGlossMap != null)
        {
            mat.SetTexture("_MetallicGlossMap", saved.MetallicGlossMap);
            mat.EnableKeyword("_METALLICSPECGLOSSMAP");
        }
        mat.SetFloat("_Metallic", saved.Metallic);
        mat.SetFloat("_Smoothness", saved.Glossiness);

        if (saved.OcclusionMap != null)
        {
            mat.SetTexture("_OcclusionMap", saved.OcclusionMap);
            mat.SetFloat("_OcclusionStrength", saved.OcclusionStrength);
        }

        if (saved.EmissionMap != null || (saved.EmissionEnabled && saved.EmissionColor.maxColorComponent > 0.001f))
        {
            if (saved.EmissionMap != null) mat.SetTexture("_EmissionMap", saved.EmissionMap);
            mat.SetColor("_EmissionColor", saved.EmissionColor);
            mat.EnableKeyword("_EMISSION");
        }
        else
        {
            mat.DisableKeyword("_EMISSION");
        }

        bool isTransparent = saved.Mode >= 2f;
        bool isCutout = Mathf.Approximately(saved.Mode, 1f);

        mat.SetFloat("_Surface", isTransparent ? 1f : 0f);
        mat.SetFloat("_AlphaClip", isCutout ? 1f : 0f);
        mat.SetFloat("_Cutoff", saved.Cutoff);

        if (isCutout)
        {
            mat.EnableKeyword("_ALPHATEST_ON");
            mat.DisableKeyword("_SURFACE_TYPE_TRANSPARENT");
            mat.SetOverrideTag("RenderType", "TransparentCutout");
            mat.SetInt("_SrcBlend", (int)BlendMode.One);
            mat.SetInt("_DstBlend", (int)BlendMode.Zero);
            mat.SetInt("_ZWrite", 1);
            mat.renderQueue = (int)RenderQueue.AlphaTest;
        }
        else if (isTransparent)
        {
            mat.DisableKeyword("_ALPHATEST_ON");
            mat.EnableKeyword("_SURFACE_TYPE_TRANSPARENT");
            mat.SetOverrideTag("RenderType", "Transparent");
            mat.SetInt("_Blend", 0);
            mat.SetInt("_SrcBlend", (int)BlendMode.SrcAlpha);
            mat.SetInt("_DstBlend", (int)BlendMode.OneMinusSrcAlpha);
            mat.SetInt("_ZWrite", 0);
            mat.renderQueue = (int)RenderQueue.Transparent;
        }
        else
        {
            mat.DisableKeyword("_ALPHATEST_ON");
            mat.DisableKeyword("_SURFACE_TYPE_TRANSPARENT");
            mat.SetOverrideTag("RenderType", "Opaque");
            mat.SetInt("_SrcBlend", (int)BlendMode.One);
            mat.SetInt("_DstBlend", (int)BlendMode.Zero);
            mat.SetInt("_ZWrite", 1);
            mat.renderQueue = -1;
        }

        EditorUtility.SetDirty(mat);
    }

    private static void ConfigureTreeBranchesMaterial()
    {
        Material treeMat = AssetDatabase.LoadAssetAtPath<Material>(TREE_BRANCHES_MAT);
        if (treeMat == null)
        {
            Debug.LogError("[SetupURPMigration] No se encontró tree_branches.mat en: " + TREE_BRANCHES_MAT);
            return;
        }

        Texture2D leafTex = AssetDatabase.LoadAssetAtPath<Texture2D>(TREE_BRANCHES_TEX);
        Shader vientoShader = Shader.Find("Shader Graphs/Viento");

        Undo.RecordObject(treeMat, "Configure tree_branches URP Wind");

        if (vientoShader != null && vientoShader.isSupported)
        {
            treeMat.shader = vientoShader;
            if (leafTex != null)
            {
                if (treeMat.HasProperty("_BaseMap")) treeMat.SetTexture("_BaseMap", leafTex);
                if (treeMat.HasProperty("_MainTex")) treeMat.SetTexture("_MainTex", leafTex);
            }
            if (treeMat.HasProperty("_Color")) treeMat.SetColor("_Color", Color.white);
            if (treeMat.HasProperty("_BaseColor")) treeMat.SetColor("_BaseColor", Color.white);
            if (treeMat.HasProperty("_Cutoff")) treeMat.SetFloat("_Cutoff", 0.4f);
            treeMat.renderQueue = (int)RenderQueue.AlphaTest;
            Debug.Log("[SetupURPMigration] tree_branches.mat asignado a 'Shader Graphs/Viento' (soportado en URP, Cutout Two-Sided).");
        }
        else
        {
            Debug.LogWarning("[SetupURPMigration] 'Shader Graphs/Viento' no soportado; usando respaldo URP/Lit Cutout Two-Sided.");
            Shader urpLit = Shader.Find("Universal Render Pipeline/Lit");
            if (urpLit != null)
            {
                treeMat.shader = urpLit;
                if (leafTex != null) treeMat.SetTexture("_BaseMap", leafTex);
                treeMat.SetColor("_BaseColor", Color.white);
                treeMat.SetFloat("_Surface", 0f);
                treeMat.SetFloat("_AlphaClip", 1f);
                treeMat.SetFloat("_Cutoff", 0.4f);
                treeMat.SetFloat("_Cull", 0f);
                treeMat.EnableKeyword("_ALPHATEST_ON");
                treeMat.renderQueue = (int)RenderQueue.AlphaTest;
            }
        }

        EditorUtility.SetDirty(treeMat);
    }

    private static void RestoreTerrainInLvl1()
    {
        var scene = EditorSceneManager.GetActiveScene();
        if (scene.path != SCENE_LVL1)
        {
            scene = EditorSceneManager.OpenScene(SCENE_LVL1, OpenSceneMode.Single);
        }

        Terrain terrain = UnityEngine.Object.FindFirstObjectByType<Terrain>();
        if (terrain != null)
        {
            if (terrain.materialTemplate == null ||
                terrain.materialTemplate.shader == null ||
                terrain.materialTemplate.shader.name == "Hidden/InternalErrorShader" ||
                terrain.materialTemplate.shader.name.Contains("Nature/Terrain"))
            {
                Material urpTerrainMat = AssetDatabase.LoadAssetAtPath<Material>(URP_TERRAIN_LIT_MAT);
                if (urpTerrainMat != null)
                {
                    Undo.RecordObject(terrain, "Assign URP TerrainLit Material");
                    terrain.materialTemplate = urpTerrainMat;
                    Debug.Log("[SetupURPMigration] Asignado TerrainLit.mat al Terrain de Lvl 1.");
                }
            }

            if (terrain.terrainData != null)
            {
                terrain.terrainData.RefreshPrototypes();
            }
            terrain.Flush();
        }
        else
        {
            Debug.LogWarning("[SetupURPMigration] No se encontró Terrain en Lvl 1.unity.");
        }

        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        Debug.Log("[SetupURPMigration] Escena Lvl 1 guardada correctamente.");
    }
}
