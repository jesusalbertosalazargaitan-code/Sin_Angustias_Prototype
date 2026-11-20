using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class MigrateMedievalPropsMaterials
{
    private const string TARGET_FOLDER = "Assets/Medieval props";

    [MenuItem("Tools/Migrate Medieval Props To URP")]
    public static void Execute()
    {
        Shader urpLitShader = Shader.Find("Universal Render Pipeline/Lit");
        if (urpLitShader == null)
        {
            Debug.LogError("[MigrateMedievalProps] Shader 'Universal Render Pipeline/Lit' not found!");
            return;
        }

        string[] guids = AssetDatabase.FindAssets("t:Material", new[] { TARGET_FOLDER });
        Debug.Log($"[MigrateMedievalProps] Found {guids.Length} material candidate(s) under '{TARGET_FOLDER}'.");

        List<string> converted = new List<string>();
        List<string> skipped = new List<string>();

        // Pre-cache textures strictly within TARGET_FOLDER for fallback
        string[] texGuids = AssetDatabase.FindAssets("t:Texture", new[] { TARGET_FOLDER });
        Dictionary<string, Texture2D> localTextures = new Dictionary<string, Texture2D>(System.StringComparer.OrdinalIgnoreCase);
        foreach (var tg in texGuids)
        {
            string tp = AssetDatabase.GUIDToAssetPath(tg);
            if (tp.StartsWith(TARGET_FOLDER + "/"))
            {
                Texture2D tex = AssetDatabase.LoadAssetAtPath<Texture2D>(tp);
                if (tex != null && !localTextures.ContainsKey(tex.name))
                {
                    localTextures[tex.name] = tex;
                }
            }
        }

        foreach (var guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            // Strict isolation check: MUST start with TARGET_FOLDER + "/"
            if (!path.StartsWith(TARGET_FOLDER + "/"))
            {
                Debug.LogWarning($"[MigrateMedievalProps] Skipping out-of-scope asset: {path}");
                continue;
            }

            Material mat = AssetDatabase.LoadAssetAtPath<Material>(path);
            if (mat == null) continue;

            // 1. Read existing properties prior to shader change
            Texture mainTex = null;
            if (mat.HasProperty("_MainTex")) mainTex = mat.GetTexture("_MainTex");
            if (mainTex == null && mat.HasProperty("_BaseMap")) mainTex = mat.GetTexture("_BaseMap");

            // Fallback search strictly within localTextures if mainTex is null
            if (mainTex == null)
            {
                string baseName = mat.name;
                // Try exact match or baseName_D / baseName_Diffuse
                if (localTextures.ContainsKey(baseName))
                {
                    mainTex = localTextures[baseName];
                }
                else if (localTextures.ContainsKey(baseName + "_D"))
                {
                    mainTex = localTextures[baseName + "_D"];
                }
                else if (localTextures.ContainsKey(baseName + "_Diffuse"))
                {
                    mainTex = localTextures[baseName + "_Diffuse"];
                }
                else if (localTextures.ContainsKey("T_" + baseName))
                {
                    mainTex = localTextures["T_" + baseName];
                }
            }

            Color baseColor = Color.white;
            if (mat.HasProperty("_Color")) baseColor = mat.GetColor("_Color");
            else if (mat.HasProperty("_BaseColor")) baseColor = mat.GetColor("_BaseColor");

            Texture bumpMap = null;
            if (mat.HasProperty("_BumpMap")) bumpMap = mat.GetTexture("_BumpMap");

            float bumpScale = 1.0f;
            if (mat.HasProperty("_BumpScale")) bumpScale = mat.GetFloat("_BumpScale");

            Texture metallicGlossMap = null;
            if (mat.HasProperty("_MetallicGlossMap")) metallicGlossMap = mat.GetTexture("_MetallicGlossMap");

            float metallic = 0.0f;
            if (mat.HasProperty("_Metallic")) metallic = mat.GetFloat("_Metallic");

            float glossiness = 0.5f;
            if (mat.HasProperty("_Glossiness")) glossiness = mat.GetFloat("_Glossiness");
            else if (mat.HasProperty("_Smoothness")) glossiness = mat.GetFloat("_Smoothness");

            Texture occlusionMap = null;
            if (mat.HasProperty("_OcclusionMap")) occlusionMap = mat.GetTexture("_OcclusionMap");

            Texture emissionMap = null;
            if (mat.HasProperty("_EmissionMap")) emissionMap = mat.GetTexture("_EmissionMap");

            Color emissionColor = Color.black;
            if (mat.HasProperty("_EmissionColor")) emissionColor = mat.GetColor("_EmissionColor");

            float cutoff = 0.5f;
            if (mat.HasProperty("_Cutoff")) cutoff = mat.GetFloat("_Cutoff");

            float mode = 0f;
            if (mat.HasProperty("_Mode")) mode = mat.GetFloat("_Mode");

            Vector2 scale = mat.mainTextureScale;
            Vector2 offset = mat.mainTextureOffset;

            // 2. Change shader to Universal Render Pipeline/Lit
            Undo.RecordObject(mat, "Migrate to URP Lit");
            mat.shader = urpLitShader;

            // 3. Reassign properties in URP
            if (mainTex != null)
            {
                mat.SetTexture("_BaseMap", mainTex);
            }
            mat.SetColor("_BaseColor", baseColor);

            if (bumpMap != null)
            {
                mat.SetTexture("_BumpMap", bumpMap);
                mat.SetFloat("_BumpScale", bumpScale);
                mat.EnableKeyword("_NORMALMAP");
            }
            else
            {
                mat.DisableKeyword("_NORMALMAP");
            }

            if (metallicGlossMap != null)
            {
                mat.SetTexture("_MetallicGlossMap", metallicGlossMap);
            }
            mat.SetFloat("_Metallic", metallic);
            mat.SetFloat("_Smoothness", glossiness);

            if (occlusionMap != null)
            {
                mat.SetTexture("_OcclusionMap", occlusionMap);
            }

            if (emissionMap != null || (emissionColor.maxColorComponent > 0.001f))
            {
                if (emissionMap != null) mat.SetTexture("_EmissionMap", emissionMap);
                mat.SetColor("_EmissionColor", emissionColor);
                mat.EnableKeyword("_EMISSION");
            }
            else
            {
                mat.DisableKeyword("_EMISSION");
            }

            // Surface type: 0 = Opaque, 1 = Transparent
            if (Mathf.Approximately(mode, 2f) || Mathf.Approximately(mode, 3f))
            {
                mat.SetFloat("_Surface", 1f);
                mat.SetOverrideTag("RenderType", "Transparent");
                mat.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
            }
            else
            {
                mat.SetFloat("_Surface", 0f);
                mat.SetOverrideTag("RenderType", "Opaque");
                mat.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Geometry;
            }

            // Alpha clip: 1 if cutout (mode == 1)
            if (Mathf.Approximately(mode, 1f))
            {
                mat.SetFloat("_AlphaClip", 1f);
                mat.SetFloat("_Cutoff", cutoff);
                mat.EnableKeyword("_ALPHATEST_ON");
            }
            else
            {
                mat.SetFloat("_AlphaClip", 0f);
                mat.DisableKeyword("_ALPHATEST_ON");
            }

            mat.mainTextureScale = scale;
            mat.mainTextureOffset = offset;

            EditorUtility.SetDirty(mat);
            converted.Add(path);
        }

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        Debug.Log($"[MigrateMedievalProps] Finished! Successfully converted {converted.Count} materials inside '{TARGET_FOLDER}'.");
        foreach (var c in converted)
        {
            Debug.Log($"[MigrateMedievalProps] Converted: {c}");
        }
    }
}
