using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using TMPro;

public static class SetupFase5
{
    private const string FONT_PATH = "Assets/TextMesh Pro/Examples & Extras/Resources/Fonts & Materials/Bangers SDF.asset";
    private const string MAT_PATH = "Assets/TextMesh Pro/Examples & Extras/Resources/Fonts & Materials/Bangers SDF Glow.mat";

    [MenuItem("Tools/Setup Fase 5 (Relics, Inventory, Altar & Exit)")]
    public static void Execute()
    {
        Debug.Log("[SetupFase5] Iniciando configuración de la Fase 5...");

        TMP_FontAsset fontAsset = AssetDatabase.LoadAssetAtPath<TMP_FontAsset>(FONT_PATH);
        Material fontMat = AssetDatabase.LoadAssetAtPath<Material>(MAT_PATH);

        // =========================================================================
        // 1. HUD: Crear PanelInventarioReliquias en Canvas principal (GO:874196380)
        // =========================================================================
        Canvas[] canvases = Object.FindObjectsOfType<Canvas>(true);
        Canvas hudCanvas = null;
        foreach (var c in canvases)
        {
            if (c.gameObject.name == "Canvas" && c.gameObject.activeInHierarchy)
            {
                hudCanvas = c;
                break;
            }
        }

        if (hudCanvas == null)
        {
            Debug.LogError("[SetupFase5] No se encontró el Canvas HUD activo.");
            return;
        }

        Undo.RegisterFullObjectHierarchyUndo(hudCanvas.gameObject, "Setup Relic Inventory UI");

        Transform existingInv = hudCanvas.transform.Find("PanelInventarioReliquias");
        if (existingInv != null && existingInv.GetComponent<RectTransform>() == null)
        {
            Object.DestroyImmediate(existingInv.gameObject);
            existingInv = null;
        }

        GameObject invGO;
        if (existingInv != null)
        {
            invGO = existingInv.gameObject;
        }
        else
        {
            invGO = new GameObject("PanelInventarioReliquias", typeof(RectTransform));
            invGO.transform.SetParent(hudCanvas.transform, false);
            Undo.RegisterCreatedObjectUndo(invGO, "Create PanelInventarioReliquias");
        }

        RectTransform invRT = GetOrAddComponent<RectTransform>(invGO);
        invRT.anchorMin = new Vector2(1f, 1f);
        invRT.anchorMax = new Vector2(1f, 1f);
        invRT.pivot = new Vector2(1f, 1f);
        invRT.anchoredPosition = new Vector2(-20f, -20f);
        invRT.sizeDelta = new Vector2(280f, 130f);

        Image invBg = GetOrAddComponent<Image>(invGO);
        invBg.color = new Color(0.05f, 0.05f, 0.08f, 0.80f);

        RelicInventoryUI invUI = GetOrAddComponent<RelicInventoryUI>(invGO);

        // Título del inventario
        GameObject titleGO = GetOrCreateChild(invGO, "Text_Titulo");
        RectTransform titleRT = GetOrAddComponent<RectTransform>(titleGO);
        titleRT.anchorMin = new Vector2(0f, 1f);
        titleRT.anchorMax = new Vector2(1f, 1f);
        titleRT.pivot = new Vector2(0.5f, 1f);
        titleRT.anchoredPosition = new Vector2(0f, -8f);
        titleRT.sizeDelta = new Vector2(260f, 24f);

        TextMeshProUGUI titleTMP = GetOrAddComponent<TextMeshProUGUI>(titleGO);
        ApplyFont(titleTMP, fontAsset, fontMat);
        titleTMP.text = "RELIQUIAS ANCESTRALES";
        titleTMP.fontSize = 17f;
        titleTMP.alignment = TextAlignmentOptions.Center;
        titleTMP.color = new Color(1.0f, 0.9f, 0.5f, 1.0f);

        // Slot Sol
        GameObject slotSolGO = GetOrCreateChild(invGO, "Slot_Sol");
        RectTransform solRT = GetOrAddComponent<RectTransform>(slotSolGO);
        solRT.anchorMin = new Vector2(0f, 1f);
        solRT.anchorMax = new Vector2(1f, 1f);
        solRT.pivot = new Vector2(0f, 1f);
        solRT.anchoredPosition = new Vector2(18f, -38f);
        solRT.sizeDelta = new Vector2(250f, 24f);

        TextMeshProUGUI solTMP = GetOrAddComponent<TextMeshProUGUI>(slotSolGO);
        ApplyFont(solTMP, fontAsset, fontMat);
        solTMP.text = "[ ] Reliquia del Sol";
        solTMP.fontSize = 18f;
        solTMP.alignment = TextAlignmentOptions.Left;
        solTMP.color = new Color(0.70f, 0.70f, 0.70f, 0.85f);
        invUI.slotSolText = solTMP;

        // Slot Luna
        GameObject slotLunaGO = GetOrCreateChild(invGO, "Slot_Luna");
        RectTransform lunaRT = GetOrAddComponent<RectTransform>(slotLunaGO);
        lunaRT.anchorMin = new Vector2(0f, 1f);
        lunaRT.anchorMax = new Vector2(1f, 1f);
        lunaRT.pivot = new Vector2(0f, 1f);
        lunaRT.anchoredPosition = new Vector2(18f, -66f);
        lunaRT.sizeDelta = new Vector2(250f, 24f);

        TextMeshProUGUI lunaTMP = GetOrAddComponent<TextMeshProUGUI>(slotLunaGO);
        ApplyFont(lunaTMP, fontAsset, fontMat);
        lunaTMP.text = "[ ] Reliquia de la Luna";
        lunaTMP.fontSize = 18f;
        lunaTMP.alignment = TextAlignmentOptions.Left;
        lunaTMP.color = new Color(0.70f, 0.70f, 0.70f, 0.85f);
        invUI.slotLunaText = lunaTMP;

        // Slot Mezcla
        GameObject slotMezclaGO = GetOrCreateChild(invGO, "Slot_Mezcla");
        RectTransform mezclaRT = GetOrAddComponent<RectTransform>(slotMezclaGO);
        mezclaRT.anchorMin = new Vector2(0f, 1f);
        mezclaRT.anchorMax = new Vector2(1f, 1f);
        mezclaRT.pivot = new Vector2(0f, 1f);
        mezclaRT.anchoredPosition = new Vector2(18f, -94f);
        mezclaRT.sizeDelta = new Vector2(250f, 24f);

        TextMeshProUGUI mezclaTMP = GetOrAddComponent<TextMeshProUGUI>(slotMezclaGO);
        ApplyFont(mezclaTMP, fontAsset, fontMat);
        mezclaTMP.text = "[ ] Reliquia Sol y Luna";
        mezclaTMP.fontSize = 18f;
        mezclaTMP.alignment = TextAlignmentOptions.Left;
        mezclaTMP.color = new Color(0.70f, 0.70f, 0.70f, 0.85f);
        invUI.slotMezclaText = mezclaTMP;

        invGO.SetActive(true);

        // =========================================================================
        // 2. Instanciar y Posicionar las 3 Reliquias en las Catacumbas
        // =========================================================================
        GameObject oreRedPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Mine/Prefabs/Rocks/OreRed.prefab");
        GameObject oreBluePrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Mine/Prefabs/Rocks/OreBlue.prefab");
        GameObject oreGreenPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Mine/Prefabs/Rocks/OreGreen.prefab");

        // Reliquia Sol en Caver (2): (102.10, 0.60, -10.70)
        SetupRelicPickup("Reliquia_Sol", oreRedPrefab, new Vector3(102.10f, 0.60f, -10.70f), RelicType.Sol, new Color(1.0f, 0.5f, 0.1f));

        // Reliquia Luna en corredor este (Turn3 11): (140.0f, 0.60f, 25.0f)
        SetupRelicPickup("Reliquia_Luna", oreBluePrefab, new Vector3(140.00f, 0.60f, 25.00f), RelicType.Luna, new Color(0.2f, 0.6f, 1.0f));

        // Reliquia Mezcla en corredor oeste: (60.0f, 0.60f, 35.0f)
        SetupRelicPickup("Reliquia_Mezcla", oreGreenPrefab, new Vector3(60.00f, 0.60f, 35.00f), RelicType.Mezcla, new Color(0.2f, 1.0f, 0.4f));

        // =========================================================================
        // 3. Puerta de Salida y Trigger de Escape en Caver (1) (pos: 138.20, 0.13, 61.29)
        // =========================================================================
        Vector3 caver1Pos = new Vector3(138.20f, 0.13f, 61.29f);
        Vector3 doorPos = caver1Pos + new Vector3(0f, 1.5f, 5.5f);
        Vector3 escapeTriggerPos = doorPos + new Vector3(0f, 0f, 2.5f);

        GameObject doorGO = GameObject.Find("Puerta_Salida_Caver1");
        if (doorGO == null)
        {
            doorGO = GameObject.CreatePrimitive(PrimitiveType.Cube);
            doorGO.name = "Puerta_Salida_Caver1";
            Undo.RegisterCreatedObjectUndo(doorGO, "Create Puerta_Salida_Caver1");
        }
        doorGO.transform.position = doorPos;
        doorGO.transform.rotation = Quaternion.identity;
        doorGO.transform.localScale = new Vector3(5.0f, 4.0f, 1.2f);
        doorGO.SetActive(true);

        // Copiar material rocoso de Caver (1)
        GameObject caver1GO = GameObject.Find("Caver (1)");
        if (caver1GO != null)
        {
            MeshRenderer caver1Rend = caver1GO.GetComponent<MeshRenderer>();
            if (caver1Rend != null && caver1Rend.sharedMaterial != null)
            {
                MeshRenderer doorRend = doorGO.GetComponent<MeshRenderer>();
                if (doorRend != null) doorRend.sharedMaterial = caver1Rend.sharedMaterial;
            }
        }

        // Trigger Escape Detrás de la Puerta
        GameObject escapeGO = GameObject.Find("Trigger_Escape_MVP");
        if (escapeGO == null)
        {
            escapeGO = new GameObject("Trigger_Escape_MVP");
            Undo.RegisterCreatedObjectUndo(escapeGO, "Create Trigger_Escape_MVP");
        }
        escapeGO.transform.position = escapeTriggerPos;
        escapeGO.transform.rotation = Quaternion.identity;
        escapeGO.tag = "End";

        BoxCollider escCol = GetOrAddComponent<BoxCollider>(escapeGO);
        escCol.isTrigger = true;
        escCol.center = Vector3.zero;
        escCol.size = new Vector3(5.0f, 4.0f, 3.0f);

        LevelTransitionTrigger escapeTrigger = GetOrAddComponent<LevelTransitionTrigger>(escapeGO);
        escapeTrigger.targetSceneName = "MainMenú";

        // =========================================================================
        // 4. Altar_Placeholder: Pedestales visuales y AltarInteraction actualizado
        // =========================================================================
        GameObject altarGO = GameObject.Find("Altar_Placeholder");
        if (altarGO != null)
        {
            Undo.RegisterFullObjectHierarchyUndo(altarGO, "Update Altar_Placeholder Fase 5");

            // Crear 3 pedestales/ofrendas sobre el altar
            GameObject pedSol = SetupAltarPedestal(altarGO, "Pedestal_Sol", oreRedPrefab, new Vector3(-0.65f, 1.25f, 0f), new Color(1.0f, 0.6f, 0.1f));
            GameObject pedLuna = SetupAltarPedestal(altarGO, "Pedestal_Luna", oreBluePrefab, new Vector3(0f, 1.25f, 0f), new Color(0.2f, 0.7f, 1.0f));
            GameObject pedMezcla = SetupAltarPedestal(altarGO, "Pedestal_Mezcla", oreGreenPrefab, new Vector3(0.65f, 1.25f, 0f), new Color(0.2f, 1.0f, 0.5f));

            AltarInteraction altarInt = GetOrAddComponent<AltarInteraction>(altarGO);

            Transform popupTrans = hudCanvas.transform.Find("PanelAltarPopup");
            if (popupTrans != null)
            {
                altarInt.panelAltarPopup = popupTrans.gameObject;
                TextMeshProUGUI popupMsg = popupTrans.GetComponentInChildren<TextMeshProUGUI>(true);
                if (popupMsg != null) altarInt.popupText = popupMsg;
            }

            altarInt.pedestalSol = pedSol;
            altarInt.pedestalLuna = pedLuna;
            altarInt.pedestalMezcla = pedMezcla;
            altarInt.puertaSalidaCaver1 = doorGO;
            altarInt.altarRestaurado = false;

            EditorUtility.SetDirty(altarInt);
            EditorUtility.SetDirty(altarGO);
        }
        else
        {
            Debug.LogError("[SetupFase5] No se encontró Altar_Placeholder en la escena.");
        }

        EditorUtility.SetDirty(invGO);
        UnityEditor.SceneManagement.EditorSceneManager.MarkSceneDirty(
            UnityEditor.SceneManagement.EditorSceneManager.GetActiveScene());

        Debug.Log("[SetupFase5] ¡Fase 5 configurada exitosamente!");
    }

    private static GameObject SetupRelicPickup(string name, GameObject prefab, Vector3 worldPos, RelicType type, Color lightColor)
    {
        GameObject relicGO = GameObject.Find(name);
        if (relicGO == null)
        {
            if (prefab != null)
            {
                relicGO = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
                relicGO.name = name;
            }
            else
            {
                relicGO = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                relicGO.name = name;
            }
            Undo.RegisterCreatedObjectUndo(relicGO, "Create " + name);
        }
        else
        {
            Undo.RegisterFullObjectHierarchyUndo(relicGO, "Update " + name);
        }

        relicGO.transform.position = worldPos;
        relicGO.transform.rotation = Quaternion.identity;
        relicGO.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
        relicGO.SetActive(true);

        // Asegurar que no sea estático para que pueda rotar y flotar
        relicGO.isStatic = false;
        foreach (Transform t in relicGO.GetComponentsInChildren<Transform>(true)) t.gameObject.isStatic = false;

        // Remover cualquier MeshCollider que venga del prefab para usar únicamente el SphereCollider trigger
        MeshCollider[] meshCols = relicGO.GetComponentsInChildren<MeshCollider>(true);
        foreach (var mc in meshCols) Object.DestroyImmediate(mc);

        SphereCollider sc = GetOrAddComponent<SphereCollider>(relicGO);
        sc.isTrigger = true;
        sc.radius = 1.0f;

        RelicItem item = GetOrAddComponent<RelicItem>(relicGO);
        item.relicType = type;
        item.rotationSpeed = 65f;
        item.bobbingAmount = 0.12f;

        Light ptLight = relicGO.GetComponentInChildren<Light>();
        if (ptLight == null)
        {
            GameObject lightChild = new GameObject("GlowLight");
            lightChild.transform.SetParent(relicGO.transform, false);
            ptLight = lightChild.AddComponent<Light>();
        }
        ptLight.type = LightType.Point;
        ptLight.color = lightColor;
        ptLight.range = 4.5f;
        ptLight.intensity = 1.8f;

        EditorUtility.SetDirty(relicGO);
        return relicGO;
    }

    private static GameObject SetupAltarPedestal(GameObject altarRoot, string name, GameObject prefab, Vector3 localPos, Color glowColor)
    {
        Transform existing = altarRoot.transform.Find(name);
        GameObject pedGO;
        if (existing != null)
        {
            pedGO = existing.gameObject;
        }
        else
        {
            if (prefab != null)
            {
                pedGO = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
                pedGO.name = name;
                pedGO.transform.SetParent(altarRoot.transform, false);
            }
            else
            {
                pedGO = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                pedGO.name = name;
                pedGO.transform.SetParent(altarRoot.transform, false);
            }
            Undo.RegisterCreatedObjectUndo(pedGO, "Create " + name);
        }

        pedGO.transform.localPosition = localPos;
        pedGO.transform.localRotation = Quaternion.identity;
        pedGO.transform.localScale = new Vector3(0.55f, 0.55f, 0.55f);

        Collider[] cols = pedGO.GetComponentsInChildren<Collider>();
        foreach (var c in cols) Object.DestroyImmediate(c);

        Light ptLight = pedGO.GetComponentInChildren<Light>();
        if (ptLight == null)
        {
            GameObject lightChild = new GameObject("PedestalGlow");
            lightChild.transform.SetParent(pedGO.transform, false);
            ptLight = lightChild.AddComponent<Light>();
        }
        ptLight.type = LightType.Point;
        ptLight.color = glowColor;
        ptLight.range = 2.5f;
        ptLight.intensity = 1.2f;

        pedGO.SetActive(false);
        EditorUtility.SetDirty(pedGO);
        return pedGO;
    }

    private static GameObject GetOrCreateChild(GameObject parent, string childName)
    {
        Transform child = parent.transform.Find(childName);
        if (child != null) return child.gameObject;

        GameObject go = new GameObject(childName, typeof(RectTransform));
        go.transform.SetParent(parent.transform, false);
        Undo.RegisterCreatedObjectUndo(go, "Create " + childName);
        return go;
    }

    private static T GetOrAddComponent<T>(GameObject go) where T : Component
    {
        T comp = go.GetComponent<T>();
        if (comp == null)
        {
            comp = go.AddComponent<T>();
        }
        return comp;
    }

    private static void ApplyFont(TextMeshProUGUI tmp, TMP_FontAsset font, Material mat)
    {
        if (font != null) tmp.font = font;
        if (mat != null) tmp.fontSharedMaterial = mat;
    }
}
