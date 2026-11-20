using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.UI;
using TMPro;

public static class SetupRemyDialogue
{
    private const string SCENE_PATH = "Assets/_Scenes/Lvl 1.unity";

    [MenuItem("Tools/Setup Remy Dialogue")]
    public static void Execute()
    {
        var scene = EditorSceneManager.OpenScene(SCENE_PATH, OpenSceneMode.Single);
        Debug.Log("[SetupRemyDialogue] Configuring Remy dialogue in Lvl 1.unity...");

        // 1. Locate Remy GameObject
        GameObject remyGO = GameObject.Find("Remy");
        if (remyGO == null)
        {
            Debug.LogError("[SetupRemyDialogue] GameObject 'Remy' not found in scene!");
            return;
        }

        // 2. Add / Configure SphereCollider on Remy
        SphereCollider col = remyGO.GetComponent<SphereCollider>();
        if (col == null)
        {
            col = Undo.AddComponent<SphereCollider>(remyGO);
        }
        col.isTrigger = true;
        col.center = new Vector3(0f, 1.0f, 0f);
        col.radius = 3.2f;
        EditorUtility.SetDirty(col);

        // 3. Locate HUD Canvas (active Canvas with TextMeshProUGUI counter)
        Canvas[] canvases = Object.FindObjectsOfType<Canvas>(true);
        Canvas hudCanvas = null;
        foreach (var c in canvases)
        {
            if (c.gameObject.activeSelf && c.transform.Find("Text (TMP)") != null && c.transform.Find("Continue") == null)
            {
                hudCanvas = c;
                break;
            }
        }

        if (hudCanvas == null)
        {
            foreach (var c in canvases)
            {
                if (c.gameObject.activeSelf && c.name == "Canvas" && c.transform.Find("Continue") == null)
                {
                    hudCanvas = c;
                    break;
                }
            }
        }

        if (hudCanvas == null)
        {
            Debug.LogError("[SetupRemyDialogue] Active HUD Canvas not found!");
            return;
        }

        Undo.RegisterFullObjectHierarchyUndo(hudCanvas.gameObject, "Setup Remy Dialogue UI");

        // 4. Create or update Panel_Prompt_E under hudCanvas
        Transform promptTform = hudCanvas.transform.Find("Panel_Prompt_E");
        GameObject promptGO;
        if (promptTform != null)
        {
            promptGO = promptTform.gameObject;
        }
        else
        {
            promptGO = new GameObject("Panel_Prompt_E");
            promptGO.transform.SetParent(hudCanvas.transform, false);
            Undo.RegisterCreatedObjectUndo(promptGO, "Create Panel_Prompt_E");
        }

        RectTransform promptRT = promptGO.GetComponent<RectTransform>();
        if (promptRT == null) promptRT = promptGO.AddComponent<RectTransform>();
        promptRT.anchorMin = new Vector2(0.5f, 0.15f);
        promptRT.anchorMax = new Vector2(0.5f, 0.15f);
        promptRT.pivot = new Vector2(0.5f, 0.5f);
        promptRT.anchoredPosition = Vector2.zero;
        promptRT.sizeDelta = new Vector2(420f, 55f);

        Image promptImg = promptGO.GetComponent<Image>();
        if (promptImg == null) promptImg = promptGO.AddComponent<Image>();
        promptImg.color = new Color(0.05f, 0.05f, 0.08f, 0.85f);

        // Prompt text
        Transform promptTextTform = promptGO.transform.Find("Text_Prompt");
        GameObject promptTextGO;
        if (promptTextTform != null)
        {
            promptTextGO = promptTextTform.gameObject;
        }
        else
        {
            promptTextGO = new GameObject("Text_Prompt");
            promptTextGO.transform.SetParent(promptGO.transform, false);
            Undo.RegisterCreatedObjectUndo(promptTextGO, "Create Text_Prompt");
        }

        RectTransform promptTextRT = promptTextGO.GetComponent<RectTransform>();
        if (promptTextRT == null) promptTextRT = promptTextGO.AddComponent<RectTransform>();
        promptTextRT.anchorMin = Vector2.zero;
        promptTextRT.anchorMax = Vector2.one;
        promptTextRT.pivot = new Vector2(0.5f, 0.5f);
        promptTextRT.offsetMin = Vector2.zero;
        promptTextRT.offsetMax = Vector2.zero;

        TextMeshProUGUI promptTMP = promptTextGO.GetComponent<TextMeshProUGUI>();
        if (promptTMP == null) promptTMP = promptTextGO.AddComponent<TextMeshProUGUI>();
        promptTMP.text = "Presiona [E] para hablar";
        promptTMP.alignment = TextAlignmentOptions.Center;
        promptTMP.fontSize = 24f;
        promptTMP.color = Color.white;

        // Copy font asset if available
        TextMeshProUGUI referenceTMP = hudCanvas.GetComponentInChildren<TextMeshProUGUI>(true);
        if (referenceTMP != null && referenceTMP.font != null)
        {
            promptTMP.font = referenceTMP.font;
            if (referenceTMP.fontSharedMaterial != null) promptTMP.fontSharedMaterial = referenceTMP.fontSharedMaterial;
        }

        promptGO.SetActive(false);

        // 5. Create or update Panel_Dialogo_Remy under hudCanvas
        Transform dialogueTform = hudCanvas.transform.Find("Panel_Dialogo_Remy");
        GameObject dialogueGO;
        if (dialogueTform != null)
        {
            dialogueGO = dialogueTform.gameObject;
        }
        else
        {
            dialogueGO = new GameObject("Panel_Dialogo_Remy");
            dialogueGO.transform.SetParent(hudCanvas.transform, false);
            Undo.RegisterCreatedObjectUndo(dialogueGO, "Create Panel_Dialogo_Remy");
        }

        RectTransform dialogueRT = dialogueGO.GetComponent<RectTransform>();
        if (dialogueRT == null) dialogueRT = dialogueGO.AddComponent<RectTransform>();
        dialogueRT.anchorMin = new Vector2(0.5f, 0.18f);
        dialogueRT.anchorMax = new Vector2(0.5f, 0.18f);
        dialogueRT.pivot = new Vector2(0.5f, 0.5f);
        dialogueRT.anchoredPosition = Vector2.zero;
        dialogueRT.sizeDelta = new Vector2(820f, 190f);

        Image dialogueImg = dialogueGO.GetComponent<Image>();
        if (dialogueImg == null) dialogueImg = dialogueGO.AddComponent<Image>();
        dialogueImg.color = new Color(0.05f, 0.05f, 0.08f, 0.90f);

        // Header: NPC Name
        Transform nameTform = dialogueGO.transform.Find("Text_Name");
        GameObject nameGO;
        if (nameTform != null)
        {
            nameGO = nameTform.gameObject;
        }
        else
        {
            nameGO = new GameObject("Text_Name");
            nameGO.transform.SetParent(dialogueGO.transform, false);
            Undo.RegisterCreatedObjectUndo(nameGO, "Create Text_Name");
        }

        RectTransform nameRT = nameGO.GetComponent<RectTransform>();
        if (nameRT == null) nameRT = nameGO.AddComponent<RectTransform>();
        nameRT.anchorMin = new Vector2(0f, 1f);
        nameRT.anchorMax = new Vector2(1f, 1f);
        nameRT.pivot = new Vector2(0.5f, 1f);
        nameRT.anchoredPosition = new Vector2(0f, -12f);
        nameRT.sizeDelta = new Vector2(-40f, 32f);

        TextMeshProUGUI nameTMP = nameGO.GetComponent<TextMeshProUGUI>();
        if (nameTMP == null) nameTMP = nameGO.AddComponent<TextMeshProUGUI>();
        nameTMP.text = "Remy";
        nameTMP.alignment = TextAlignmentOptions.Left;
        nameTMP.fontSize = 24f;
        nameTMP.fontStyle = FontStyles.Bold;
        nameTMP.color = new Color(1.0f, 0.85f, 0.2f, 1.0f); // Dorado/cálido
        if (referenceTMP != null && referenceTMP.font != null)
        {
            nameTMP.font = referenceTMP.font;
            if (referenceTMP.fontSharedMaterial != null) nameTMP.fontSharedMaterial = referenceTMP.fontSharedMaterial;
        }

        // Body: Dialogue Text
        Transform bodyTform = dialogueGO.transform.Find("Text_Dialogue");
        GameObject bodyGO;
        if (bodyTform != null)
        {
            bodyGO = bodyTform.gameObject;
        }
        else
        {
            bodyGO = new GameObject("Text_Dialogue");
            bodyGO.transform.SetParent(dialogueGO.transform, false);
            Undo.RegisterCreatedObjectUndo(bodyGO, "Create Text_Dialogue");
        }

        RectTransform bodyRT = bodyGO.GetComponent<RectTransform>();
        if (bodyRT == null) bodyRT = bodyGO.AddComponent<RectTransform>();
        bodyRT.anchorMin = new Vector2(0f, 0f);
        bodyRT.anchorMax = new Vector2(1f, 1f);
        bodyRT.pivot = new Vector2(0.5f, 0.5f);
        bodyRT.offsetMin = new Vector2(25f, 35f);
        bodyRT.offsetMax = new Vector2(-25f, -48f);

        TextMeshProUGUI bodyTMP = bodyGO.GetComponent<TextMeshProUGUI>();
        if (bodyTMP == null) bodyTMP = bodyGO.AddComponent<TextMeshProUGUI>();
        bodyTMP.text = "";
        bodyTMP.alignment = TextAlignmentOptions.Center;
        bodyTMP.fontSize = 20f;
        bodyTMP.color = Color.white;
        bodyTMP.enableWordWrapping = true;
        if (referenceTMP != null && referenceTMP.font != null)
        {
            bodyTMP.font = referenceTMP.font;
            if (referenceTMP.fontSharedMaterial != null) bodyTMP.fontSharedMaterial = referenceTMP.fontSharedMaterial;
        }

        // Footer: Hint Text
        Transform footerTform = dialogueGO.transform.Find("Text_Footer");
        GameObject footerGO;
        if (footerTform != null)
        {
            footerGO = footerTform.gameObject;
        }
        else
        {
            footerGO = new GameObject("Text_Footer");
            footerGO.transform.SetParent(dialogueGO.transform, false);
            Undo.RegisterCreatedObjectUndo(footerGO, "Create Text_Footer");
        }

        RectTransform footerRT = footerGO.GetComponent<RectTransform>();
        if (footerRT == null) footerRT = footerGO.AddComponent<RectTransform>();
        footerRT.anchorMin = new Vector2(0f, 0f);
        footerRT.anchorMax = new Vector2(1f, 0f);
        footerRT.pivot = new Vector2(0.5f, 0f);
        footerRT.anchoredPosition = new Vector2(0f, 8f);
        footerRT.sizeDelta = new Vector2(-40f, 24f);

        TextMeshProUGUI footerTMP = footerGO.GetComponent<TextMeshProUGUI>();
        if (footerTMP == null) footerTMP = footerGO.AddComponent<TextMeshProUGUI>();
        footerTMP.text = "Presiona [E] para continuar...";
        footerTMP.alignment = TextAlignmentOptions.Right;
        footerTMP.fontSize = 15f;
        footerTMP.color = new Color(0.7f, 0.7f, 0.7f, 0.8f);
        if (referenceTMP != null && referenceTMP.font != null)
        {
            footerTMP.font = referenceTMP.font;
            if (referenceTMP.fontSharedMaterial != null) footerTMP.fontSharedMaterial = referenceTMP.fontSharedMaterial;
        }

        dialogueGO.SetActive(false);

        // 6. Configure NPCDialogueInteraction on Remy
        NPCDialogueInteraction dialogueComp = remyGO.GetComponent<NPCDialogueInteraction>();
        if (dialogueComp == null)
        {
            dialogueComp = Undo.AddComponent<NPCDialogueInteraction>(remyGO);
        }

        dialogueComp.promptUI = promptGO;
        dialogueComp.dialoguePanel = dialogueGO;
        dialogueComp.npcNameText = nameTMP;
        dialogueComp.dialogueText = bodyTMP;
        dialogueComp.npcName = "Remy";

        dialogueComp.dialogues = new string[]
        {
            "Alto ahí, explorador... Este bosque oculta una pirámide antigua y objetos arqueológicos que no debes tomar a la ligera.",
            "Quienes intentaron llevarse lo que hay dentro activaron una trampa y cayeron directo a unas catacumbas subterráneas.",
            "Allí abajo hallarás pistas para orientarte, pero el lugar está vigilado por momias que te perseguirán.",
            "Cada objeto que recojas hará que las momias se vuelvan más rápidas y agresivas.",
            "Debes reunir los objetos del dios del sol y la luna, y llevarlos hasta la salida para escapar.",
            "Usa tu linterna con la tecla F en la oscuridad y avanza con cuidado cuando estés listo."
        };

        EditorUtility.SetDirty(remyGO);
        EditorUtility.SetDirty(dialogueComp);
        EditorUtility.SetDirty(promptGO);
        EditorUtility.SetDirty(dialogueGO);

        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        Debug.Log("[SetupRemyDialogue] Successfully configured Remy and UI in Lvl 1.unity!");
    }
}
