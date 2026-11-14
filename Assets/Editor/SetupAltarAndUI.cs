using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using TMPro;

public static class SetupAltarAndUI
{
    [MenuItem("Tools/Setup Altar and UI")]
    public static void Execute()
    {
        // 1. Locate the active HUD Canvas
        Canvas[] canvases = Object.FindObjectsOfType<Canvas>(true);
        Canvas targetCanvas = null;
        foreach (var c in canvases)
        {
            if (c.gameObject.name == "Canvas" && c.gameObject.activeSelf)
            {
                targetCanvas = c;
                break;
            }
        }

        if (targetCanvas == null)
        {
            foreach (var c in canvases)
            {
                if (c.gameObject.activeInHierarchy)
                {
                    targetCanvas = c;
                    break;
                }
            }
        }

        if (targetCanvas == null)
        {
            Debug.LogError("[SetupAltarAndUI] No active Canvas found!");
            return;
        }

        Undo.RegisterFullObjectHierarchyUndo(targetCanvas.gameObject, "Setup Altar UI");

        // 2. Create or find PanelAltarPopup under targetCanvas
        Transform existingPanel = targetCanvas.transform.Find("PanelAltarPopup");
        GameObject panelGO;
        if (existingPanel != null)
        {
            panelGO = existingPanel.gameObject;
        }
        else
        {
            panelGO = new GameObject("PanelAltarPopup");
            panelGO.transform.SetParent(targetCanvas.transform, false);
            Undo.RegisterCreatedObjectUndo(panelGO, "Create PanelAltarPopup");
        }

        RectTransform panelRT = panelGO.GetComponent<RectTransform>();
        if (panelRT == null) panelRT = panelGO.AddComponent<RectTransform>();

        panelRT.anchorMin = new Vector2(0.5f, 0.5f);
        panelRT.anchorMax = new Vector2(0.5f, 0.5f);
        panelRT.pivot = new Vector2(0.5f, 0.5f);
        panelRT.anchoredPosition = new Vector2(0f, -80f);
        panelRT.sizeDelta = new Vector2(700f, 150f);

        Image panelImage = panelGO.GetComponent<Image>();
        if (panelImage == null) panelImage = panelGO.AddComponent<Image>();
        panelImage.color = new Color(0.05f, 0.05f, 0.08f, 0.85f);

        // Add or find TextMeshProUGUI
        Transform existingText = panelGO.transform.Find("Text_Message");
        GameObject textGO;
        if (existingText != null)
        {
            textGO = existingText.gameObject;
        }
        else
        {
            textGO = new GameObject("Text_Message");
            textGO.transform.SetParent(panelGO.transform, false);
            Undo.RegisterCreatedObjectUndo(textGO, "Create Text_Message");
        }

        RectTransform textRT = textGO.GetComponent<RectTransform>();
        if (textRT == null) textRT = textGO.AddComponent<RectTransform>();
        textRT.anchorMin = Vector2.zero;
        textRT.anchorMax = Vector2.one;
        textRT.pivot = new Vector2(0.5f, 0.5f);
        textRT.offsetMin = new Vector2(30f, 20f);
        textRT.offsetMax = new Vector2(-30f, -20f);

        TextMeshProUGUI tmp = textGO.GetComponent<TextMeshProUGUI>();
        if (tmp == null) tmp = textGO.AddComponent<TextMeshProUGUI>();

        tmp.text = "Este es el altar de la diosa del sol y la luna";
        tmp.alignment = TextAlignmentOptions.Center;
        tmp.fontSize = 28f;
        tmp.color = Color.white;
        tmp.enableWordWrapping = true;

        TextMeshProUGUI existingTmp = targetCanvas.GetComponentInChildren<TextMeshProUGUI>(true);
        if (existingTmp != null && existingTmp != tmp && existingTmp.font != null)
        {
            tmp.font = existingTmp.font;
            if (existingTmp.fontSharedMaterial != null)
            {
                tmp.fontSharedMaterial = existingTmp.fontSharedMaterial;
            }
        }

        panelGO.SetActive(false);

        // 3. Create or find Altar_Placeholder
        Vector3 altarPos = new Vector3(78.20f, 0.13f, 49.39f);
        GameObject altarGO = GameObject.Find("Altar_Placeholder");
        if (altarGO == null)
        {
            altarGO = new GameObject("Altar_Placeholder");
            Undo.RegisterCreatedObjectUndo(altarGO, "Create Altar_Placeholder");
        }
        else
        {
            Undo.RegisterFullObjectHierarchyUndo(altarGO, "Update Altar_Placeholder");
        }

        altarGO.transform.position = altarPos;
        altarGO.transform.rotation = Quaternion.identity;
        altarGO.transform.localScale = Vector3.one;

        BoxCollider triggerCol = altarGO.GetComponent<BoxCollider>();
        if (triggerCol == null) triggerCol = altarGO.AddComponent<BoxCollider>();
        triggerCol.isTrigger = true;
        triggerCol.center = new Vector3(0f, 1.2f, 0f);
        triggerCol.size = new Vector3(7.0f, 3.5f, 7.0f);

        Transform existingMesh = altarGO.transform.Find("Altar_Model");
        GameObject meshGO;
        if (existingMesh != null)
        {
            meshGO = existingMesh.gameObject;
        }
        else
        {
            meshGO = GameObject.CreatePrimitive(PrimitiveType.Cube);
            meshGO.name = "Altar_Model";
            meshGO.transform.SetParent(altarGO.transform, false);
            Undo.RegisterCreatedObjectUndo(meshGO, "Create Altar_Model");
        }

        meshGO.transform.localPosition = new Vector3(0f, 0.6f, 0f);
        meshGO.transform.localRotation = Quaternion.identity;
        meshGO.transform.localScale = new Vector3(2.4f, 1.2f, 1.8f);

        BoxCollider meshCol = meshGO.GetComponent<BoxCollider>();
        if (meshCol != null)
        {
            meshCol.isTrigger = false;
        }

        GameObject caverGO = GameObject.Find("Caver");
        if (caverGO != null)
        {
            MeshRenderer caverRend = caverGO.GetComponent<MeshRenderer>();
            if (caverRend != null && caverRend.sharedMaterial != null)
            {
                MeshRenderer altarRend = meshGO.GetComponent<MeshRenderer>();
                if (altarRend != null)
                {
                    altarRend.sharedMaterial = caverRend.sharedMaterial;
                }
            }
        }

        // 4. Attach AltarInteraction script and assign panel
        AltarInteraction interaction = altarGO.GetComponent<AltarInteraction>();
        if (interaction == null) interaction = altarGO.AddComponent<AltarInteraction>();
        interaction.panelAltarPopup = panelGO;

        EditorUtility.SetDirty(altarGO);
        EditorUtility.SetDirty(panelGO);
        UnityEditor.SceneManagement.EditorSceneManager.MarkSceneDirty(
            UnityEditor.SceneManagement.EditorSceneManager.GetActiveScene());

        Debug.Log("[SetupAltarAndUI] Successfully created Altar_Placeholder and PanelAltarPopup!");
    }
}

