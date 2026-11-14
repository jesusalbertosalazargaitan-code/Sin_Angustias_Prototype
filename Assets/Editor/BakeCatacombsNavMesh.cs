using UnityEngine;
using UnityEditor;
using Unity.AI.Navigation;

public static class BakeCatacombsNavMesh
{
    [MenuItem("Tools/Bake Catacombs NavMesh")]
    public static void Bake()
    {
        GameObject p1 = GameObject.Find("p1");
        if (p1 == null)
        {
            Debug.LogError("[BakeCatacombsNavMesh] Could not find GameObject 'p1'");
            return;
        }

        NavMeshSurface surface = p1.GetComponent<NavMeshSurface>();
        if (surface == null)
        {
            Debug.LogError("[BakeCatacombsNavMesh] 'p1' has no NavMeshSurface component");
            return;
        }

        Debug.Log("[BakeCatacombsNavMesh] Starting NavMesh bake for Catacombs...");
        surface.BuildNavMesh();
        Debug.Log("[BakeCatacombsNavMesh] NavMesh successfully baked for Catacombs!");
    }
}

