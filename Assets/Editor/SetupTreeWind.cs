using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public static class SetupTreeWind
{
    private const string MATERIAL_PATH = "Assets/Fantasy Forest Environment Free Sample/Materials/tree_branches.mat";
    private const string TEXTURE_PATH = "Assets/Fantasy Forest Environment Free Sample/Textures/tree_branches.png";
    private const string SHADER_NAME = "Custom/VientoArbolBuiltIn";
    private const string SCENE_LVL1 = "Assets/_Scenes/Lvl 1.unity";

    [MenuItem("Tools/Apply Tree Wind BuiltIn Shader")]
    public static void ApplyTreeWindShader()
    {
        Material mat = AssetDatabase.LoadAssetAtPath<Material>(MATERIAL_PATH);
        if (mat == null)
        {
            Debug.LogError("[SetupTreeWind] Material not found at: " + MATERIAL_PATH);
            return;
        }

        Shader windShader = Shader.Find(SHADER_NAME);
        if (windShader == null)
        {
            Debug.LogError("[SetupTreeWind] Shader not found: " + SHADER_NAME);
            return;
        }

        Texture2D tex = AssetDatabase.LoadAssetAtPath<Texture2D>(TEXTURE_PATH);
        if (tex == null)
        {
            Debug.LogError("[SetupTreeWind] Texture not found at: " + TEXTURE_PATH);
            return;
        }

        Undo.RecordObject(mat, "Apply VientoArbolBuiltIn Shader");
        mat.shader = windShader;
        mat.SetTexture("_MainTex", tex);
        mat.SetColor("_Color", new Color(1f, 1f, 1f, 1f));
        mat.SetFloat("_Cutoff", 0.4f);
        mat.SetFloat("_WindSpeed", 1.6f);
        mat.SetFloat("_WindStrength", 0.12f);
        EditorUtility.SetDirty(mat);

        AssetDatabase.SaveAssets();

        var scene = EditorSceneManager.GetActiveScene();
        if (scene.path != SCENE_LVL1)
        {
            scene = EditorSceneManager.OpenScene(SCENE_LVL1, OpenSceneMode.Single);
        }

        Terrain terrain = Object.FindFirstObjectByType<Terrain>();
        if (terrain == null)
        {
            Debug.LogError("[SetupTreeWind] Terrain not found in scene: " + scene.path);
            return;
        }

        if (terrain.terrainData != null)
        {
            terrain.terrainData.RefreshPrototypes();
        }
        terrain.Flush();

        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        AssetDatabase.SaveAssets();

        Debug.Log("[SetupTreeWind] Successfully applied Custom/VientoArbolBuiltIn to tree_branches.mat and refreshed Terrain in Lvl 1.");
    }
}
