using TMPro;
using UnityEditor;
using UnityEditor.Events;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class FixLvl2Issues
{
    private const string LVL2_SCENE_PATH = "Assets/_Scenes/Lvl 2.unity";
    private const string FRAME_GOLD_PATH = "Assets/_Picture/Spriter/UI_Frame_StoneGold.png";
    private const string OSWALD_FONT_PATH = "Assets/TextMesh Pro/Examples & Extras/Resources/Fonts & Materials/Oswald Bold SDF.asset";
    private const string LIB_FONT_PATH = "Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF.asset";
    private const string LIB_SHADOW_MAT_PATH = "Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF - Drop Shadow.mat";

    private static readonly Color STONE_CARD = new Color(0.06f, 0.07f, 0.06f, 0.94f);
    private static readonly Color GOLD_BORDER = new Color(0.78f, 0.62f, 0.24f, 0.85f);
    private static readonly Color GOLD_TEXT = new Color(0.95f, 0.82f, 0.48f, 1.00f);
    private static readonly Color PARCHMENT_TEXT = new Color(0.96f, 0.94f, 0.88f, 1.00f);
    private static readonly Color SHADOW_DARK = new Color(0.00f, 0.00f, 0.00f, 0.85f);

    [MenuItem("Tools/Fix Lvl 2 UI & Interactions (Lvl 2 ONLY)")]
    public static void Execute()
    {
        Scene scene = EditorSceneManager.OpenScene(LVL2_SCENE_PATH, OpenSceneMode.Single);

        Sprite frameGold = AssetDatabase.LoadAssetAtPath<Sprite>(FRAME_GOLD_PATH);
        TMP_FontAsset oswaldFont = AssetDatabase.LoadAssetAtPath<TMP_FontAsset>(OSWALD_FONT_PATH);
        TMP_FontAsset libFont = AssetDatabase.LoadAssetAtPath<TMP_FontAsset>(LIB_FONT_PATH);
        Material libShadowMat = AssetDatabase.LoadAssetAtPath<Material>(LIB_SHADOW_MAT_PATH);

        if (frameGold == null || oswaldFont == null || libFont == null || libShadowMat == null)
        {
            Debug.LogError("[FixLvl2Issues] Missing required sprite or TMP font/material assets.");
            return;
        }

        FixHistoriaAndAltarOverlays(libFont, libShadowMat);
        FixGameOverPopupAndEvents();
        FixWorldSpaceCanvases(frameGold, oswaldFont);

        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        AssetDatabase.SaveAssets();
        Debug.Log("[FixLvl2Issues] COMPLETED & SAVED Lvl 2.unity ONLY.");
    }

    private static void FixHistoriaAndAltarOverlays(TMP_FontAsset libFont, Material libShadowMat)
    {
        Canvas historiaCanvas = null;
        foreach (Canvas c in Object.FindObjectsOfType<Canvas>(true))
        {
            if (c.gameObject.name == "Historia" && c.renderMode == RenderMode.ScreenSpaceOverlay)
            {
                historiaCanvas = c;
                break;
            }
        }

        GameObject historiaPanelGO = null;
        TextMeshProUGUI historiaTextTMP = null;

        if (historiaCanvas != null)
        {
            historiaCanvas.gameObject.SetActive(true);
            historiaCanvas.overrideSorting = true;
            historiaCanvas.sortingOrder = 20;

            CanvasScaler scaler = GetOrAdd<CanvasScaler>(historiaCanvas.gameObject);
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1920f, 1080f);
            scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
            scaler.matchWidthOrHeight = 0.5f;

            Transform panelT = historiaCanvas.transform.Find("Panel");
            if (panelT != null)
            {
                historiaPanelGO = panelT.gameObject;
                RectTransform panelRT = panelT.GetComponent<RectTransform>();
                panelRT.anchorMin = new Vector2(0.5f, 0.5f);
                panelRT.anchorMax = new Vector2(0.5f, 0.5f);
                panelRT.pivot = new Vector2(0.5f, 0.5f);
                panelRT.anchoredPosition = Vector2.zero;
                panelRT.sizeDelta = new Vector2(960f, 540f);
                panelRT.localScale = Vector3.one;
                panelRT.localRotation = Quaternion.identity;

                Image bgImg = GetOrAdd<Image>(historiaPanelGO);
                bgImg.sprite = null;
                bgImg.type = Image.Type.Simple;
                bgImg.color = STONE_CARD;
                bgImg.raycastTarget = false;

                foreach (Image img in historiaPanelGO.GetComponentsInChildren<Image>(true))
                {
                    img.raycastTarget = false;
                }

                Transform txtT = panelT.Find("Text (TMP)");
                if (txtT != null)
                {
                    RectTransform rt = txtT.GetComponent<RectTransform>();
                    rt.anchorMin = Vector2.zero;
                    rt.anchorMax = Vector2.one;
                    rt.pivot = new Vector2(0.5f, 0.5f);
                    rt.offsetMin = new Vector2(55f, 45f);
                    rt.offsetMax = new Vector2(-55f, -45f);
                    rt.localScale = Vector3.one;
                    rt.localRotation = Quaternion.identity;
                    rt.localPosition = new Vector3(rt.localPosition.x, rt.localPosition.y, 0f);

                    historiaTextTMP = txtT.GetComponent<TextMeshProUGUI>();
                    if (historiaTextTMP != null)
                    {
                        historiaTextTMP.margin = Vector4.zero;
                        historiaTextTMP.font = libFont;
                        historiaTextTMP.fontSharedMaterial = libShadowMat;
                        historiaTextTMP.enableAutoSizing = true;
                        historiaTextTMP.fontSizeMin = 26f;
                        historiaTextTMP.fontSizeMax = 36f;
                        historiaTextTMP.fontSize = 32f;
                        historiaTextTMP.fontStyle = FontStyles.Normal;
                        historiaTextTMP.alignment = TextAlignmentOptions.Center;
                        historiaTextTMP.enableWordWrapping = true;
                        historiaTextTMP.overflowMode = TextOverflowModes.Overflow;
                        historiaTextTMP.color = PARCHMENT_TEXT;
                        historiaTextTMP.raycastTarget = false;
                        historiaTextTMP.text = "";
                        EditorUtility.SetDirty(historiaTextTMP);
                    }
                }

                historiaPanelGO.SetActive(false);
                EditorUtility.SetDirty(historiaPanelGO);
            }

            EditorUtility.SetDirty(historiaCanvas.gameObject);
        }

        // Rewire every InteraccionHistoria to unified Historia/Panel + Historia/Panel/Text (TMP)
        foreach (InteraccionHistoria ih in Object.FindObjectsOfType<InteraccionHistoria>(true))
        {
            if (historiaPanelGO != null) ih.panelHistoriaUI = historiaPanelGO;
            if (historiaTextTMP != null) ih.textoHistoriaUI = historiaTextTMP;
            ih.mensajeAviso = string.IsNullOrEmpty(ih.mensajeAviso) ? "Presiona [E] para traducir" : ih.mensajeAviso.Trim();
            EditorUtility.SetDirty(ih);
        }

        // Disable orphaned always-active ScreenSpaceOverlay Canvases under Altar
        GameObject altarGO = GameObject.Find("Altar");
        if (altarGO != null)
        {
            foreach (Canvas c in altarGO.GetComponentsInChildren<Canvas>(true))
            {
                if (c.renderMode != RenderMode.ScreenSpaceOverlay) continue;

                GraphicRaycaster gr = c.GetComponent<GraphicRaycaster>();
                if (gr != null) gr.enabled = false;

                foreach (Image img in c.GetComponentsInChildren<Image>(true))
                {
                    img.raycastTarget = false;
                }
                foreach (TextMeshProUGUI tmp in c.GetComponentsInChildren<TextMeshProUGUI>(true))
                {
                    tmp.text = "";
                    tmp.font = libFont;
                    tmp.fontSharedMaterial = libShadowMat;
                    tmp.raycastTarget = false;
                }

                c.gameObject.SetActive(false);
                EditorUtility.SetDirty(c.gameObject);
            }
        }
    }

    private static void FixGameOverPopupAndEvents()
    {
        GameManager gm = Object.FindObjectOfType<GameManager>(true);
        GameOverUIController goCtrl = Object.FindObjectOfType<GameOverUIController>(true);

        if (goCtrl != null && goCtrl.panelGameOver != null)
        {
            GameObject panelGO = goCtrl.panelGameOver;

            Canvas panelCanvas = GetOrAdd<Canvas>(panelGO);
            panelCanvas.overrideSorting = true;
            panelCanvas.sortingOrder = 100;

            GraphicRaycaster panelGR = GetOrAdd<GraphicRaycaster>(panelGO);
            panelGR.enabled = true;

            CanvasGroup cg = GetOrAdd<CanvasGroup>(panelGO);
            cg.alpha = 1f;
            cg.interactable = true;
            cg.blocksRaycasts = true;
            cg.ignoreParentGroups = true;

            // Update title to "HAS MUERTO"
            Transform titleT = panelGO.transform.Find("Card_GameOver/Header_GameOver/Text_Title");
            if (titleT != null)
            {
                TextMeshProUGUI titleTMP = titleT.GetComponent<TextMeshProUGUI>();
                if (titleTMP != null)
                {
                    titleTMP.text = "HAS MUERTO";
                    EditorUtility.SetDirty(titleTMP);
                }
            }

            // Ensure decorative texts/borders never block button raycasts
            foreach (TextMeshProUGUI tmp in panelGO.GetComponentsInChildren<TextMeshProUGUI>(true))
            {
                tmp.raycastTarget = false;
            }
            foreach (Transform tr in panelGO.GetComponentsInChildren<Transform>(true))
            {
                if (tr.name.StartsWith("Border_"))
                {
                    Image borderImg = tr.GetComponent<Image>();
                    if (borderImg != null) borderImg.raycastTarget = false;
                }
            }

            if (gm != null)
            {
                BindButtonAction(panelGO.transform.Find("Card_GameOver/Btn_Reintentar"), gm.RestartLevel);
                BindButtonAction(panelGO.transform.Find("Card_GameOver/Btn_MenuPrincipal"), gm.ReturnToMainMenu);
            }
            else
            {
                Debug.LogError("[FixLvl2Issues] GameManager not found in Lvl 2.unity!");
            }

            panelGO.SetActive(false);
            EditorUtility.SetDirty(panelGO);
        }

        // Ensure EventSystem + StandaloneInputModule are active
        foreach (EventSystem es in Object.FindObjectsOfType<EventSystem>(true))
        {
            es.gameObject.SetActive(true);
            es.enabled = true;
            StandaloneInputModule sim = es.GetComponent<StandaloneInputModule>();
            if (sim != null) sim.enabled = true;
            EditorUtility.SetDirty(es.gameObject);
        }
    }

    private static void BindButtonAction(Transform btnT, UnityEngine.Events.UnityAction action)
    {
        if (btnT == null) return;
        Image img = btnT.GetComponent<Image>();
        if (img != null) img.raycastTarget = true;

        Button btn = btnT.GetComponent<Button>();
        if (btn == null) return;

        btn.interactable = true;
        int count = btn.onClick.GetPersistentEventCount();
        for (int i = count - 1; i >= 0; i--)
        {
            UnityEventTools.RemovePersistentListener(btn.onClick, i);
        }
        UnityEventTools.AddPersistentListener(btn.onClick, action);
        EditorUtility.SetDirty(btn);
    }

    private static void FixWorldSpaceCanvases(Sprite frameGold, TMP_FontAsset oswaldFont)
    {
        foreach (Canvas c in Object.FindObjectsOfType<Canvas>(true))
        {
            if (c.renderMode != RenderMode.WorldSpace) continue;

            GraphicRaycaster gr = c.GetComponent<GraphicRaycaster>();
            if (gr != null) gr.enabled = false;

            Transform planeT = c.transform.Find("Plane");
            if (planeT != null)
            {
                MeshCollider mc = planeT.GetComponent<MeshCollider>();
                if (mc != null) Object.DestroyImmediate(mc);
                MeshRenderer mr = planeT.GetComponent<MeshRenderer>();
                if (mr != null) Object.DestroyImmediate(mr);
                MeshFilter mf = planeT.GetComponent<MeshFilter>();
                if (mf != null) Object.DestroyImmediate(mf);

                RectTransform prt = GetOrAdd<RectTransform>(planeT.gameObject);
                prt.localRotation = Quaternion.identity;
                float parentScale = Mathf.Abs(c.transform.localScale.x);
                float plaqueScale = parentScale > 0.001f ? (1.6f / (540f * parentScale)) : 0.014f;
                prt.localScale = new Vector3(plaqueScale, plaqueScale, plaqueScale);
                prt.anchorMin = new Vector2(0.5f, 0.5f);
                prt.anchorMax = new Vector2(0.5f, 0.5f);
                prt.pivot = new Vector2(0.5f, 0.5f);
                prt.sizeDelta = new Vector2(540f, 92f);

                Image plaque = GetOrAdd<Image>(planeT.gameObject);
                plaque.sprite = frameGold;
                plaque.type = Image.Type.Sliced;
                plaque.pixelsPerUnitMultiplier = 2.4f;
                plaque.color = Color.white;
                plaque.raycastTarget = false;

                Transform txtT = planeT.Find("Text (TMP)");
                if (txtT != null)
                {
                    RectTransform trt = GetOrAdd<RectTransform>(txtT.gameObject);
                    trt.anchorMin = Vector2.zero;
                    trt.anchorMax = Vector2.one;
                    trt.pivot = new Vector2(0.5f, 0.5f);
                    trt.offsetMin = new Vector2(42f, 12f);
                    trt.offsetMax = new Vector2(-42f, -12f);
                    trt.localRotation = Quaternion.identity;
                    trt.localScale = Vector3.one;
                    trt.localPosition = new Vector3(trt.localPosition.x, trt.localPosition.y, 0f);

                    TextMeshProUGUI tmp = txtT.GetComponent<TextMeshProUGUI>();
                    if (tmp != null)
                    {
                        tmp.margin = Vector4.zero;
                        tmp.font = oswaldFont;
                        tmp.fontSharedMaterial = oswaldFont.material;
                        tmp.enableAutoSizing = true;
                        tmp.fontSizeMin = 20f;
                        tmp.fontSizeMax = 32f;
                        tmp.fontSize = 30f;
                        tmp.fontStyle = FontStyles.Normal;
                        tmp.alignment = TextAlignmentOptions.Center;
                        tmp.enableWordWrapping = false;
                        tmp.overflowMode = TextOverflowModes.Overflow;
                        tmp.color = GOLD_TEXT;
                        tmp.raycastTarget = false;
                        tmp.text = "Presiona [E] para traducir";

                        Shadow sh = GetOrAdd<Shadow>(txtT.gameObject);
                        sh.effectColor = SHADOW_DARK;
                        sh.effectDistance = new Vector2(2f, -2f);

                        EditorUtility.SetDirty(tmp);
                    }
                }

                planeT.gameObject.SetActive(false);
                EditorUtility.SetDirty(planeT.gameObject);
            }

            EditorUtility.SetDirty(c.gameObject);
        }
    }

    private static T GetOrAdd<T>(GameObject go) where T : Component
    {
        T comp = go.GetComponent<T>();
        if (comp == null) comp = go.AddComponent<T>();
        return comp;
    }
}
