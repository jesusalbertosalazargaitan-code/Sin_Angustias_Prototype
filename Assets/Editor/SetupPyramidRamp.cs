using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public static class SetupPyramidRamp
{
    private const string SCENE_PATH = "Assets/_Scenes/Lvl 1.unity";

    [MenuItem("Tools/Setup Pyramid Ramp")]
    public static void Execute()
    {
        var scene = EditorSceneManager.OpenScene(SCENE_PATH, OpenSceneMode.Single);
        Debug.Log("[SetupPyramidRamp] Configuring Pyramid_Stair_Ramp in Lvl 1.unity...");

        // 1. Locate or create Pyramid_Stair_Ramp
        GameObject rampGO = GameObject.Find("Pyramid_Stair_Ramp");
        if (rampGO == null)
        {
            rampGO = new GameObject("Pyramid_Stair_Ramp");
            Undo.RegisterCreatedObjectUndo(rampGO, "Create Pyramid_Stair_Ramp");
        }
        else
        {
            Undo.RegisterFullObjectHierarchyUndo(rampGO, "Update Pyramid_Stair_Ramp");
        }

        // Clean any renderers if present
        MeshRenderer mr = rampGO.GetComponent<MeshRenderer>();
        if (mr != null) Undo.DestroyObjectImmediate(mr);
        MeshFilter mf = rampGO.GetComponent<MeshFilter>();
        if (mf != null) Undo.DestroyObjectImmediate(mf);

        // Parameters
        // Delta Y = 21.10 - (-0.20) = 21.30 m
        // Delta Z = 556.80 - 535.50 = 21.30 m (slope = 1.0, 45 degrees)
        // Center:
        // x = 396.4556f
        // y = (21.10 + (-0.20)) / 2 = 10.45f + 0.0424f (for 0.06m offset normal) = 10.4924f
        // z = (556.80 + 535.50) / 2 = 546.15f - 0.0424f (for 0.06m offset normal) = 546.1076f
        // Rotation: (-45, 0, 0)
        // In local coordinates of rampGO:
        // local +Y points up-back (normal: (0, cos(45), -sin(45)) = (0, 0.7071, -0.7071))
        // Wait, rotX = -45 deg:
        // Local forward (+Z) rotated by -45 on X:
        // (0, -sin(-45), cos(-45)) = (0, sin(45), cos(45)) = (0, 0.7071, 0.7071) -> goes up and forward along the stairs!
        // Local up (+Y) rotated by -45 on X:
        // (0, cos(-45), sin(-45)) = (0, cos(45), -sin(45)) = (0, 0.7071, -0.7071) -> perpendicular to stairs (outward normal)!
        // Therefore, local +Y is the normal outward from stairs, local +Z is along the slope going up to the summit!
        // Length along slope: 21.30 * sqrt(2) = 30.12275 m
        // Thickness in Y: 0.50 m
        // Width in X: 8.00 m

        rampGO.transform.position = new Vector3(396.4556f, 10.4924f, 546.1076f);
        rampGO.transform.rotation = Quaternion.Euler(-45f, 0f, 0f);
        rampGO.transform.localScale = Vector3.one;

        BoxCollider col = rampGO.GetComponent<BoxCollider>();
        if (col == null)
        {
            col = Undo.AddComponent<BoxCollider>(rampGO);
        }

        col.isTrigger = false;
        col.center = Vector3.zero;
        col.size = new Vector3(8.0f, 0.5f, 30.1228f);

        // Assign Bounce PhysicMaterial
        PhysicMaterial mat = AssetDatabase.LoadAssetAtPath<PhysicMaterial>("Assets/Bounce.physicMaterial");
        if (mat != null)
        {
            col.sharedMaterial = mat;
        }
        else
        {
            Debug.LogWarning("[SetupPyramidRamp] Assets/Bounce.physicMaterial not found!");
        }

        EditorUtility.SetDirty(rampGO);
        EditorUtility.SetDirty(col);

        // 2. Link with PyramidTrapRelic in both relics
        GameObject relic1 = GameObject.Find("Reliquia_Nivel1");
        if (relic1 != null)
        {
            PyramidTrapRelic trap1 = relic1.GetComponent<PyramidTrapRelic>();
            if (trap1 != null)
            {
                Undo.RecordObject(trap1, "Set trapDoor Reliquia_Nivel1");
                trap1.trapDoor = rampGO;
                EditorUtility.SetDirty(trap1);
                Debug.Log("[SetupPyramidRamp] Assigned ramp to Reliquia_Nivel1.trapDoor");
            }
        }

        GameObject relic2 = GameObject.Find("Reliquia_Nivel1 (1)");
        if (relic2 != null)
        {
            PyramidTrapRelic trap2 = relic2.GetComponent<PyramidTrapRelic>();
            if (trap2 != null)
            {
                Undo.RecordObject(trap2, "Set trapDoor Reliquia_Nivel1 (1)");
                trap2.trapDoor = rampGO;
                EditorUtility.SetDirty(trap2);
                Debug.Log("[SetupPyramidRamp] Assigned ramp to Reliquia_Nivel1 (1).trapDoor");
            }
        }

        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        Debug.Log("[SetupPyramidRamp] Pyramid_Stair_Ramp setup completed and scene saved!");
    }
}
