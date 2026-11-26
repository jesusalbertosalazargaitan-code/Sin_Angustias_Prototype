using System;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEditor.Events;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class SetupSanAgustinUI
{
    private const string MAIN_MENU_SCENE_PATH = "Assets/_Scenes/MainMenú.unity";
    private const string LVL2_SCENE_PATH = "Assets/_Scenes/Lvl 2.unity";

    private const string FRAME_GOLD_PATH = "Assets/_Picture/Spriter/UI_Frame_StoneGold.png";
    private const string FRAME_MOSS_PATH = "Assets/_Picture/Spriter/UI_Frame_StoneMoss.png";
    private const string MENU_BG_PATH = "Assets/_Picture/UI_SanAgustin_MenuBg.jpg";
    private const string SLIDER_BG_PATH = "Assets/_Picture/Spriter/Slider1.png";
    private const string SLIDER_FILL_PATH = "Assets/_Picture/Spriter/Slider3.png";

    private const string OSWALD_FONT_PATH = "Assets/TextMesh Pro/Examples & Extras/Resources/Fonts & Materials/Oswald Bold SDF.asset";
    private const string ROBOTO_FONT_PATH = "Assets/TextMesh Pro/Examples & Extras/Resources/Fonts & Materials/Roboto-Bold SDF.asset";
    private const string ROBOTO_SHADOW_MAT_PATH = "Assets/TextMesh Pro/Examples & Extras/Resources/Fonts & Materials/Roboto-Bold SDF - Drop Shadow.mat";
    private const string LIB_FONT_PATH = "Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF.asset";
    private const string LIB_SHADOW_MAT_PATH = "Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF - Drop Shadow.mat";
    private const string LIB_FALLBACK_PATH = "Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF - Fallback.asset";

    // Paleta San Agustín (Piedra volcánica, oro precolombino, pergamino y jade)
    private static readonly Color STONE_BG = new Color(0.06f, 0.07f, 0.06f, 0.90f);       // #0F120F
    private static readonly Color STONE_CARD = new Color(0.06f, 0.07f, 0.06f, 0.94f);     // #0F120F
    private static readonly Color SCRIM_DARK = new Color(0.03f, 0.04f, 0.03f, 0.84f);
    private static readonly Color GOLD_BORDER = new Color(0.78f, 0.62f, 0.24f, 0.85f);    // #C89D3C
    private static readonly Color GOLD_TEXT = new Color(0.95f, 0.82f, 0.48f, 1.00f);      // #F2D17B
    private static readonly Color PARCHMENT_TEXT = new Color(0.96f, 0.94f, 0.88f, 1.00f); // #F4EFE1
    private static readonly Color SHADOW_DARK = new Color(0.00f, 0.00f, 0.00f, 0.85f);

    private static readonly Color BTN_SPRITE_NORMAL = new Color(0.93f, 0.91f, 0.87f, 1.0f);
    private static readonly Color BTN_SPRITE_HIGHLIGHT = new Color(1.00f, 0.98f, 0.86f, 1.0f);
    private static readonly Color BTN_SPRITE_PRESSED = new Color(0.68f, 0.65f, 0.58f, 1.0f);
    private static readonly Color BTN_SPRITE_SELECTED = new Color(1.00f, 0.96f, 0.82f, 1.0f);

    private struct UIAssets
    {
        public Sprite frameGold;
        public Sprite frameMoss;
        public Texture2D menuBgTex;
        public Sprite sliderBg;
        public Sprite sliderFill;
        public TMP_FontAsset oswaldFont;
        public Material oswaldMat;
        public TMP_FontAsset robotoFont;
        public Material robotoShadowMat;
        public TMP_FontAsset libFont;
        public Material libShadowMat;
    }

    [MenuItem("Tools/Setup San Agustin UI (MainMenu & Lvl 2)")]
    public static void Execute()
    {
        Debug.Log("[SetupSanAgustinUI] Starting San Agustin UI overhaul & Game Over setup (MainMenú & Lvl 2 ONLY)...");

        ConfigureTextureImporters();
        UIAssets assets = LoadUIAssets();

        if (assets.frameGold == null || assets.frameMoss == null || assets.menuBgTex == null)
        {
            Debug.LogError("[SetupSanAgustinUI] Missing imported theme sprites or menu background under Assets/_Picture/.");
            return;
        }

        // 1. Redesign MainMenú.unity
        ProcessMainMenuScene(assets);

        // 2. Redesign Lvl 2.unity + Panel_GameOver
        ProcessLvl2Scene(assets);

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        Debug.Log("[SetupSanAgustinUI] COMPLETED SUCCESSFULLY (Lvl 1.unity untouched).");
    }

    // =========================================================================
    // 1. ASSET IMPORTING & FONTS
    // =========================================================================
    private static void ConfigureTextureImporters()
    {
        ConfigureNineSliceSprite(FRAME_GOLD_PATH, new Vector4(160f, 62f, 160f, 62f));
        ConfigureNineSliceSprite(FRAME_MOSS_PATH, new Vector4(160f, 62f, 160f, 62f));

        AssetDatabase.ImportAsset(MENU_BG_PATH, ImportAssetOptions.ForceUpdate);
        TextureImporter bgImp = AssetImporter.GetAtPath(MENU_BG_PATH) as TextureImporter;
        if (bgImp != null)
        {
            bgImp.textureType = TextureImporterType.Default;
            bgImp.mipmapEnabled = false;
            bgImp.maxTextureSize = 2048;
            bgImp.SaveAndReimport();
        }
    }

    private static void ConfigureNineSliceSprite(string path, Vector4 border)
    {
        AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate);
        TextureImporter imp = AssetImporter.GetAtPath(path) as TextureImporter;
        if (imp == null)
        {
            Debug.LogError("[SetupSanAgustinUI] Failed to get TextureImporter for " + path);
            return;
        }

        imp.textureType = TextureImporterType.Sprite;
        imp.spriteImportMode = SpriteImportMode.Single;
        imp.alphaIsTransparency = true;
        imp.mipmapEnabled = false;
        imp.maxTextureSize = 2048;
        imp.spritePixelsPerUnit = 100f;
        imp.spriteBorder = border;
        imp.SaveAndReimport();

        Sprite sp = AssetDatabase.LoadAssetAtPath<Sprite>(path);
        Debug.Log($"[SetupSanAgustinUI] Imported Sprite '{path}': rect={sp?.rect}, border={sp?.border}");
    }

    private static UIAssets LoadUIAssets()
    {
        UIAssets a = new UIAssets();
        a.frameGold = AssetDatabase.LoadAssetAtPath<Sprite>(FRAME_GOLD_PATH);
        a.frameMoss = AssetDatabase.LoadAssetAtPath<Sprite>(FRAME_MOSS_PATH);
        a.menuBgTex = AssetDatabase.LoadAssetAtPath<Texture2D>(MENU_BG_PATH);
        a.sliderBg = AssetDatabase.LoadAssetAtPath<Sprite>(SLIDER_BG_PATH);
        a.sliderFill = AssetDatabase.LoadAssetAtPath<Sprite>(SLIDER_FILL_PATH);

        a.oswaldFont = AssetDatabase.LoadAssetAtPath<TMP_FontAsset>(OSWALD_FONT_PATH);
        a.robotoFont = AssetDatabase.LoadAssetAtPath<TMP_FontAsset>(ROBOTO_FONT_PATH);
        a.robotoShadowMat = AssetDatabase.LoadAssetAtPath<Material>(ROBOTO_SHADOW_MAT_PATH);
        a.libFont = AssetDatabase.LoadAssetAtPath<TMP_FontAsset>(LIB_FONT_PATH);
        a.libShadowMat = AssetDatabase.LoadAssetAtPath<Material>(LIB_SHADOW_MAT_PATH);
        TMP_FontAsset libFallback = AssetDatabase.LoadAssetAtPath<TMP_FontAsset>(LIB_FALLBACK_PATH);

        EnsureSpanishFallback(a.oswaldFont, a.libFont, libFallback);
        EnsureSpanishFallback(a.robotoFont, a.libFont, libFallback);

        if (a.oswaldFont != null) a.oswaldMat = a.oswaldFont.material;
        return a;
    }

    private static void EnsureSpanishFallback(TMP_FontAsset primary, TMP_FontAsset libMain, TMP_FontAsset libFallback)
    {
        if (primary == null) return;
        if (primary.fallbackFontAssetTable == null)
        {
            primary.fallbackFontAssetTable = new List<TMP_FontAsset>();
        }
        bool changed = false;
        if (libMain != null && !primary.fallbackFontAssetTable.Contains(libMain))
        {
            primary.fallbackFontAssetTable.Add(libMain);
            changed = true;
        }
        if (libFallback != null && !primary.fallbackFontAssetTable.Contains(libFallback))
        {
            primary.fallbackFontAssetTable.Add(libFallback);
            changed = true;
        }
        if (changed) EditorUtility.SetDirty(primary);
    }

    // =========================================================================
    // 2. MAIN MENU SCENE
    // =========================================================================
    private static void ProcessMainMenuScene(UIAssets assets)
    {
        Scene scene = EditorSceneManager.OpenScene(MAIN_MENU_SCENE_PATH, OpenSceneMode.Single);

        Canvas mainCanvas = null;
        Canvas optionsCanvas = null;
        foreach (Canvas c in UnityEngine.Object.FindObjectsOfType<Canvas>(true))
        {
            if (c.gameObject.name == "Canvas") mainCanvas = c;
            else if (c.gameObject.name == "Options") optionsCanvas = c;
        }

        if (mainCanvas != null)
        {
            Configure1080pScaler(mainCanvas);
            StyleFullScreenBackground(mainCanvas.transform.Find("RawImage"), assets.menuBgTex, Color.white);

            // Title banner at top of Main Menu (non-raycastable ornamental stone banner)
            GameObject banner = EnsureChildUI(mainCanvas.gameObject, "Header_TituloJuego", true);
            RectTransform bannerRT = banner.GetComponent<RectTransform>();
            bannerRT.anchorMin = new Vector2(0.5f, 0.5f);
            bannerRT.anchorMax = new Vector2(0.5f, 0.5f);
            bannerRT.pivot = new Vector2(0.5f, 0.5f);
            bannerRT.anchoredPosition = new Vector2(0f, 305f);
            bannerRT.sizeDelta = new Vector2(780f, 128f);
            Image bannerImg = GetOrAdd<Image>(banner);
            bannerImg.sprite = assets.frameGold;
            bannerImg.type = Image.Type.Sliced;
            bannerImg.pixelsPerUnitMultiplier = 2.0f;
            bannerImg.color = Color.white;
            bannerImg.raycastTarget = false;

            GameObject titleGO = EnsureChildUI(banner, "Text_Titulo", false);
            StretchFill(titleGO.GetComponent<RectTransform>(), 65f, 18f, 65f, 18f);
            ApplyOswaldText(GetOrAdd<TextMeshProUGUI>(titleGO), "SIN ANGUSTIAS", 52f, GOLD_TEXT, assets);

            // Preserve existing buttons & their OnClick listeners
            StyleTemplatedButton(mainCanvas.transform.Find("Play"), "JUGAR", new Vector2(0f, 105f), new Vector2(420f, 104f), assets.frameMoss, 2.2f, 38f, assets);
            StyleTemplatedButton(mainCanvas.transform.Find("options"), "OPCIONES", new Vector2(0f, -25f), new Vector2(420f, 104f), assets.frameMoss, 2.2f, 38f, assets);
            StyleTemplatedButton(mainCanvas.transform.Find("Quit"), "SALIR", new Vector2(0f, -155f), new Vector2(420f, 104f), assets.frameMoss, 2.2f, 38f, assets);

            EditorUtility.SetDirty(mainCanvas.gameObject);
        }

        if (optionsCanvas != null)
        {
            RedesignOptionsCanvas(optionsCanvas, assets);
        }

        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        Debug.Log("[SetupSanAgustinUI] Saved MainMenú.unity.");
    }

    // =========================================================================
    // 3. LVL 2 SCENE (UI OVERHAUL + PANEL GAME OVER)
    // =========================================================================
    private static void ProcessLvl2Scene(UIAssets assets)
    {
        Scene scene = EditorSceneManager.OpenScene(LVL2_SCENE_PATH, OpenSceneMode.Single);

        Canvas pauseCanvas = null;
        Canvas hudCanvas = null;
        Canvas optionsCanvas = null;
        Canvas historiaCanvas = null;

        foreach (Canvas c in UnityEngine.Object.FindObjectsOfType<Canvas>(true))
        {
            if (c.renderMode == RenderMode.WorldSpace) continue;

            if (c.gameObject.name == "Options")
            {
                optionsCanvas = c;
            }
            else if (c.gameObject.name == "Historia")
            {
                historiaCanvas = c;
            }
            else if (c.gameObject.name == "Canvas")
            {
                if (c.transform.Find("Continue") != null || c.transform.Find("Panel_Pausa") != null)
                {
                    pauseCanvas = c;
                }
                else
                {
                    hudCanvas = c;
                }
            }
        }

        // A. Pause Canvas
        if (pauseCanvas != null)
        {
            Configure1080pScaler(pauseCanvas);
            StyleFullScreenBackground(pauseCanvas.transform.Find("RawImage"), assets.menuBgTex, new Color(0.45f, 0.45f, 0.45f, 1f));

            GameObject pausePanel = EnsureChildUI(pauseCanvas.gameObject, "Panel_Pausa", false);
            RectTransform ppRT = pausePanel.GetComponent<RectTransform>();
            ppRT.anchorMin = new Vector2(0.5f, 0.5f);
            ppRT.anchorMax = new Vector2(0.5f, 0.5f);
            ppRT.pivot = new Vector2(0.5f, 0.5f);
            ppRT.anchoredPosition = Vector2.zero;
            ppRT.sizeDelta = new Vector2(560f, 540f);
            ApplyStoneCardStyle(pausePanel, STONE_BG, GOLD_BORDER, 2f, true);

            GameObject headerGO = EnsureChildUI(pausePanel, "Header_Pausa", false);
            RectTransform headerRT = headerGO.GetComponent<RectTransform>();
            headerRT.anchorMin = new Vector2(0.5f, 0.5f);
            headerRT.anchorMax = new Vector2(0.5f, 0.5f);
            headerRT.pivot = new Vector2(0.5f, 0.5f);
            headerRT.anchoredPosition = new Vector2(0f, 195f);
            headerRT.sizeDelta = new Vector2(480f, 92f);
            Image headerImg = GetOrAdd<Image>(headerGO);
            headerImg.sprite = assets.frameMoss;
            headerImg.type = Image.Type.Sliced;
            headerImg.pixelsPerUnitMultiplier = 2.4f;
            headerImg.color = Color.white;
            headerImg.raycastTarget = false;

            GameObject headerTextGO = EnsureChildUI(headerGO, "Text_Titulo", false);
            StretchFill(headerTextGO.GetComponent<RectTransform>(), 40f, 10f, 40f, 10f);
            ApplyOswaldText(GetOrAdd<TextMeshProUGUI>(headerTextGO), "PAUSA", 38f, GOLD_TEXT, assets);

            // Re-parent buttons into Panel_Pausa while preserving their Button.onClick persistent calls
            MoveAndStylePauseButton(pauseCanvas.transform, pausePanel.transform, "Continue", "CONTINUAR", new Vector2(0f, 70f), assets);
            MoveAndStylePauseButton(pauseCanvas.transform, pausePanel.transform, "options", "OPCIONES", new Vector2(0f, -45f), assets);
            MoveAndStylePauseButton(pauseCanvas.transform, pausePanel.transform, "Quit", "MENÚ PRINCIPAL", new Vector2(0f, -160f), assets);

            EditorUtility.SetDirty(pauseCanvas.gameObject);
        }

        // B. Options Canvas
        if (optionsCanvas != null)
        {
            RedesignOptionsCanvas(optionsCanvas, assets);
        }

        // C. HUD Canvas + Panel_GameOver
        if (hudCanvas != null)
        {
            Configure1080pScaler(hudCanvas);

            // 1. PanelInventarioReliquias
            Transform invT = hudCanvas.transform.Find("PanelInventarioReliquias");
            if (invT != null)
            {
                RectTransform invRT = invT.GetComponent<RectTransform>();
                invRT.anchorMin = new Vector2(1f, 1f);
                invRT.anchorMax = new Vector2(1f, 1f);
                invRT.pivot = new Vector2(1f, 1f);
                invRT.anchoredPosition = new Vector2(-30f, -30f);
                invRT.sizeDelta = new Vector2(360f, 185f);
                ApplyStoneCardStyle(invT.gameObject, STONE_BG, GOLD_BORDER, 2f, false);

                Transform titleT = invT.Find("Text_Titulo");
                if (titleT != null)
                {
                    RectTransform rt = titleT.GetComponent<RectTransform>();
                    rt.anchorMin = new Vector2(0f, 1f);
                    rt.anchorMax = new Vector2(1f, 1f);
                    rt.pivot = new Vector2(0.5f, 1f);
                    rt.anchoredPosition = new Vector2(0f, -12f);
                    rt.sizeDelta = new Vector2(-24f, 34f);
                    ApplyOswaldText(titleT.GetComponent<TextMeshProUGUI>(), "RELIQUIAS ANCESTRALES", 24f, GOLD_TEXT, assets);
                }

                StyleRelicSlot(invT.Find("Slot_Sol"), -56f, assets);
                StyleRelicSlot(invT.Find("Slot_Luna"), -96f, assets);
                StyleRelicSlot(invT.Find("Slot_Mezcla"), -136f, assets);
                EditorUtility.SetDirty(invT.gameObject);
            }

            // 2. PanelAltarPopup
            Transform altarT = hudCanvas.transform.Find("PanelAltarPopup");
            if (altarT != null)
            {
                RectTransform altarRT = altarT.GetComponent<RectTransform>();
                altarRT.anchorMin = new Vector2(0.5f, 0.5f);
                altarRT.anchorMax = new Vector2(0.5f, 0.5f);
                altarRT.pivot = new Vector2(0.5f, 0.5f);
                altarRT.anchoredPosition = new Vector2(0f, -140f);
                altarRT.sizeDelta = new Vector2(820f, 175f);

                Outline oldOut = altarT.GetComponent<Outline>();
                if (oldOut != null) UnityEngine.Object.DestroyImmediate(oldOut);

                Image altarImg = GetOrAdd<Image>(altarT.gameObject);
                altarImg.sprite = assets.frameMoss;
                altarImg.type = Image.Type.Sliced;
                altarImg.pixelsPerUnitMultiplier = 1.6f;
                altarImg.color = Color.white;
                altarImg.raycastTarget = false;

                Transform msgT = altarT.Find("Text_Message");
                if (msgT != null)
                {
                    StretchFill(msgT.GetComponent<RectTransform>(), 95f, 34f, 95f, 34f);
                    TextMeshProUGUI tmp = msgT.GetComponent<TextMeshProUGUI>();
                    ApplyBodyText(tmp, tmp.text, 26f, PARCHMENT_TEXT, TextAlignmentOptions.Center, assets.libFont, assets.libShadowMat);
                }
                EditorUtility.SetDirty(altarT.gameObject);
            }

            // 3. Panel_Stamina_HUD
            Transform stamT = hudCanvas.transform.Find("Panel_Stamina_HUD");
            if (stamT != null)
            {
                RectTransform stamRT = stamT.GetComponent<RectTransform>();
                stamRT.anchorMin = new Vector2(0f, 0f);
                stamRT.anchorMax = new Vector2(0f, 0f);
                stamRT.pivot = new Vector2(0f, 0f);
                stamRT.anchoredPosition = new Vector2(36f, 36f);
                stamRT.sizeDelta = new Vector2(320f, 26f);

                ApplyStoneCardStyle(stamT.gameObject, STONE_BG, GOLD_BORDER, 2f, false);

                Transform barFillT = stamT.Find("Bar_Fill");
                if (barFillT != null)
                {
                    StretchFill(barFillT.GetComponent<RectTransform>(), 3f, 3f, 3f, 3f);
                    Image barImg = barFillT.GetComponent<Image>();
                    if (barImg != null)
                    {
                        barImg.type = Image.Type.Filled;
                        barImg.fillMethod = Image.FillMethod.Horizontal;
                        barImg.raycastTarget = false;
                        EditorUtility.SetDirty(barImg);
                    }
                }

                StaminaBarUI stamUI = stamT.GetComponent<StaminaBarUI>();
                if (stamUI != null)
                {
                    stamUI.normalColor = new Color(0.27f, 0.72f, 0.42f, 1.0f);     // #45B86B
                    stamUI.lowColor = new Color(0.90f, 0.62f, 0.14f, 1.0f);        // #E69E24
                    stamUI.exhaustedColor = new Color(0.79f, 0.23f, 0.17f, 1.0f);  // #C93B2B
                    EditorUtility.SetDirty(stamUI);
                }
                EditorUtility.SetDirty(stamT.gameObject);
            }

            // 4. Create / Update Panel_GameOver (Last sibling of active HUD Canvas)
            SetupGameOverPopup(hudCanvas, assets);
            EditorUtility.SetDirty(hudCanvas.gameObject);
        }

        // D. Historia Canvas (BookV2)
        if (historiaCanvas != null)
        {
            Configure1080pScaler(historiaCanvas);
            historiaCanvas.gameObject.SetActive(true);

            Transform promptT = historiaCanvas.transform.Find("Panel_Prompt_E_Press");
            if (promptT != null)
            {
                RectTransform rt = promptT.GetComponent<RectTransform>();
                rt.anchorMin = new Vector2(0.5f, 0.14f);
                rt.anchorMax = new Vector2(0.5f, 0.14f);
                rt.pivot = new Vector2(0.5f, 0.5f);
                rt.anchoredPosition = Vector2.zero;
                rt.sizeDelta = new Vector2(500f, 78f);

                Image img = GetOrAdd<Image>(promptT.gameObject);
                img.sprite = assets.frameGold;
                img.type = Image.Type.Sliced;
                img.pixelsPerUnitMultiplier = 2.4f;
                img.color = Color.white;
                img.raycastTarget = false;

                Transform textT = promptT.Find("Text_Prompt");
                if (textT != null)
                {
                    StretchFill(textT.GetComponent<RectTransform>(), 48f, 12f, 48f, 12f);
                    TextMeshProUGUI tmp = textT.GetComponent<TextMeshProUGUI>();
                    ApplyBodyText(tmp, string.IsNullOrEmpty(tmp.text) ? "Presiona [E] para leer Registro" : tmp.text, 22f, PARCHMENT_TEXT, TextAlignmentOptions.Center, assets.robotoFont, assets.robotoShadowMat);
                }
            }

            Transform panelT = historiaCanvas.transform.Find("Panel");
            if (panelT != null)
            {
                RectTransform rt = panelT.GetComponent<RectTransform>();
                rt.anchorMin = new Vector2(0.5f, 0.5f);
                rt.anchorMax = new Vector2(0.5f, 0.5f);
                rt.pivot = new Vector2(0.5f, 0.5f);
                rt.anchoredPosition = Vector2.zero;
                rt.sizeDelta = new Vector2(960f, 540f);
                ApplyStoneCardStyle(panelT.gameObject, new Color(0.06f, 0.07f, 0.06f, 0.94f), GOLD_BORDER, 2.5f, false);

                Transform bodyT = panelT.Find("Text (TMP)");
                if (bodyT != null)
                {
                    StretchFill(bodyT.GetComponent<RectTransform>(), 48f, 42f, 48f, 42f);
                    TextMeshProUGUI tmp = bodyT.GetComponent<TextMeshProUGUI>();
                    ApplyBodyText(tmp, tmp.text, 24f, PARCHMENT_TEXT, TextAlignmentOptions.TopLeft, assets.libFont, assets.libShadowMat);
                }

                panelT.gameObject.SetActive(false);

                // Ensure any InteraccionHistoria points panelHistoriaUI -> Panel child
                foreach (InteraccionHistoria ih in UnityEngine.Object.FindObjectsOfType<InteraccionHistoria>(true))
                {
                    ih.panelHistoriaUI = panelT.gameObject;
                    EditorUtility.SetDirty(ih);
                }
            }

            EditorUtility.SetDirty(historiaCanvas.gameObject);
        }

        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene);
        Debug.Log("[SetupSanAgustinUI] Saved Lvl 2.unity.");
    }

    // =========================================================================
    // 4. SHARED OPTIONS REDESIGN
    // =========================================================================
    private static void RedesignOptionsCanvas(Canvas optionsCanvas, UIAssets assets)
    {
        Configure1080pScaler(optionsCanvas);
        StyleFullScreenBackground(optionsCanvas.transform.Find("RawImage"), assets.menuBgTex, new Color(0.48f, 0.48f, 0.48f, 1f));

        GameObject panelOpciones = EnsureChildUI(optionsCanvas.gameObject, "Panel_Opciones", false);
        RectTransform panelRT = panelOpciones.GetComponent<RectTransform>();
        panelRT.anchorMin = new Vector2(0.5f, 0.5f);
        panelRT.anchorMax = new Vector2(0.5f, 0.5f);
        panelRT.pivot = new Vector2(0.5f, 0.5f);
        panelRT.anchoredPosition = Vector2.zero;
        panelRT.sizeDelta = new Vector2(720f, 540f);
        ApplyStoneCardStyle(panelOpciones, STONE_BG, GOLD_BORDER, 2f, true);

        // Header banner
        GameObject headerGO = EnsureChildUI(panelOpciones, "Header_Opciones", false);
        RectTransform headerRT = headerGO.GetComponent<RectTransform>();
        headerRT.anchorMin = new Vector2(0.5f, 0.5f);
        headerRT.anchorMax = new Vector2(0.5f, 0.5f);
        headerRT.pivot = new Vector2(0.5f, 0.5f);
        headerRT.anchoredPosition = new Vector2(0f, 200f);
        headerRT.sizeDelta = new Vector2(640f, 92f);
        Image headerImg = GetOrAdd<Image>(headerGO);
        headerImg.sprite = assets.frameMoss;
        headerImg.type = Image.Type.Sliced;
        headerImg.pixelsPerUnitMultiplier = 2.3f;
        headerImg.color = Color.white;
        headerImg.raycastTarget = false;

        GameObject headerTextGO = EnsureChildUI(headerGO, "Text_Titulo", false);
        StretchFill(headerTextGO.GetComponent<RectTransform>(), 50f, 10f, 50f, 10f);
        ApplyOswaldText(GetOrAdd<TextMeshProUGUI>(headerTextGO), "OPCIONES", 38f, GOLD_TEXT, assets);

        // Row 1: Fullscreen label + existing Pantalla button
        GameObject labelPantalla = EnsureChildUI(panelOpciones, "Label_Pantalla", false);
        RectTransform lpRT = labelPantalla.GetComponent<RectTransform>();
        lpRT.anchorMin = new Vector2(0.5f, 0.5f);
        lpRT.anchorMax = new Vector2(0.5f, 0.5f);
        lpRT.pivot = new Vector2(0.5f, 0.5f);
        lpRT.anchoredPosition = new Vector2(-115f, 80f);
        lpRT.sizeDelta = new Vector2(360f, 56f);
        TextMeshProUGUI lpTMP = GetOrAdd<TextMeshProUGUI>(labelPantalla);
        ApplyOswaldText(lpTMP, "PANTALLA COMPLETA", 28f, PARCHMENT_TEXT, assets);
        lpTMP.alignment = TextAlignmentOptions.Left;

        Transform pantallaBtnT = FindDeepChild(optionsCanvas.transform, "Pantalla");
        if (pantallaBtnT != null)
        {
            pantallaBtnT.SetParent(panelOpciones.transform, false);
            StyleTemplatedButton(pantallaBtnT, "ALTERNAR", new Vector2(175f, 80f), new Vector2(220f, 70f), assets.frameGold, 3.0f, 26f, assets);
        }

        // Row 2: Volumen label (stripped of redundant decorative Button/Image) + Slider underneath
        Transform volumenT = FindDeepChild(optionsCanvas.transform, "Volumen");
        if (volumenT != null)
        {
            volumenT.SetParent(panelOpciones.transform, false);
            Button decBtn = volumenT.GetComponent<Button>();
            if (decBtn != null) UnityEngine.Object.DestroyImmediate(decBtn);
            Image decImg = volumenT.GetComponent<Image>();
            if (decImg != null) UnityEngine.Object.DestroyImmediate(decImg);

            RectTransform vRT = volumenT.GetComponent<RectTransform>();
            vRT.anchorMin = new Vector2(0.5f, 0.5f);
            vRT.anchorMax = new Vector2(0.5f, 0.5f);
            vRT.pivot = new Vector2(0.5f, 0.5f);
            vRT.anchoredPosition = new Vector2(0f, -10f);
            vRT.sizeDelta = new Vector2(400f, 44f);

            Transform vChild = volumenT.Find("Text (TMP)");
            if (vChild != null)
            {
                StretchFill(vChild.GetComponent<RectTransform>(), 0f, 0f, 0f, 0f);
                ApplyOswaldText(vChild.GetComponent<TextMeshProUGUI>(), "VOLUMEN", 28f, PARCHMENT_TEXT, assets);
            }
        }

        Transform sliderT = FindDeepChild(optionsCanvas.transform, "Slider");
        if (sliderT != null)
        {
            sliderT.SetParent(panelOpciones.transform, false);
            RectTransform sRT = sliderT.GetComponent<RectTransform>();
            sRT.anchorMin = new Vector2(0.5f, 0.5f);
            sRT.anchorMax = new Vector2(0.5f, 0.5f);
            sRT.pivot = new Vector2(0.5f, 0.5f);
            sRT.anchoredPosition = new Vector2(0f, -68f);
            sRT.sizeDelta = new Vector2(540f, 30f);

            Transform bgT = sliderT.Find("Background");
            if (bgT != null)
            {
                RectTransform bgRT = bgT.GetComponent<RectTransform>();
                bgRT.anchorMin = new Vector2(0f, 0.25f);
                bgRT.anchorMax = new Vector2(1f, 0.75f);
                bgRT.offsetMin = Vector2.zero;
                bgRT.offsetMax = Vector2.zero;
                ApplyStoneCardStyle(bgT.gameObject, new Color(0.11f, 0.12f, 0.10f, 0.98f), new Color(0.78f, 0.62f, 0.24f, 0.75f), 1.5f, false);
            }

            Transform fillAreaT = sliderT.Find("Fill Area");
            if (fillAreaT != null)
            {
                RectTransform faRT = fillAreaT.GetComponent<RectTransform>();
                faRT.anchorMin = new Vector2(0f, 0.30f);
                faRT.anchorMax = new Vector2(1f, 0.70f);
                faRT.offsetMin = new Vector2(3f, 0f);
                faRT.offsetMax = new Vector2(-3f, 0f);

                Transform fillT = fillAreaT.Find("Fill");
                if (fillT != null)
                {
                    RectTransform fRT = fillT.GetComponent<RectTransform>();
                    fRT.sizeDelta = Vector2.zero;
                    Image fillImg = fillT.GetComponent<Image>();
                    if (fillImg != null)
                    {
                        fillImg.sprite = null;
                        fillImg.type = Image.Type.Simple;
                        fillImg.color = new Color(0.84f, 0.67f, 0.28f, 1.0f);
                    }
                }
            }

            Transform handleAreaT = sliderT.Find("Handle Slide Area");
            if (handleAreaT != null)
            {
                RectTransform haRT = handleAreaT.GetComponent<RectTransform>();
                haRT.anchorMin = new Vector2(0f, 0.5f);
                haRT.anchorMax = new Vector2(1f, 0.5f);
                haRT.pivot = new Vector2(0.5f, 0.5f);
                haRT.offsetMin = new Vector2(14f, -14f);
                haRT.offsetMax = new Vector2(-14f, 14f);

                Transform handleT = handleAreaT.Find("Handle");
                if (handleT != null)
                {
                    RectTransform hRT = handleT.GetComponent<RectTransform>();
                    hRT.anchorMin = new Vector2(hRT.anchorMin.x, 0f);
                    hRT.anchorMax = new Vector2(hRT.anchorMax.x, 1f);
                    hRT.sizeDelta = new Vector2(28f, 0f);
                    Image handleImg = handleT.GetComponent<Image>();
                    if (handleImg != null)
                    {
                        handleImg.color = GOLD_TEXT;
                    }
                    Shadow handleShadow = GetOrAdd<Shadow>(handleT.gameObject);
                    handleShadow.effectColor = SHADOW_DARK;
                    handleShadow.effectDistance = new Vector2(1.5f, -1.5f);
                }
            }
        }

        // Row 3: Back button (Regresar)
        Transform backBtnT = FindDeepChild(optionsCanvas.transform, "Regresar");
        if (backBtnT != null)
        {
            backBtnT.SetParent(panelOpciones.transform, false);
            StyleTemplatedButton(backBtnT, "VOLVER", new Vector2(0f, -185f), new Vector2(320f, 82f), assets.frameGold, 2.5f, 32f, assets);
        }

        EditorUtility.SetDirty(optionsCanvas.gameObject);
    }

    // =========================================================================
    // 5. FASE 2: PANEL_GAMEOVER POP-UP IN LVL 2 HUD CANVAS
    // =========================================================================
    private static void SetupGameOverPopup(Canvas hudCanvas, UIAssets assets)
    {
        GameOverUIController goCtrl = GetOrAdd<GameOverUIController>(hudCanvas.gameObject);

        GameObject panelGO = EnsureChildUI(hudCanvas.gameObject, "Panel_GameOver", false);
        panelGO.transform.SetAsLastSibling();
        StretchFill(panelGO.GetComponent<RectTransform>(), 0f, 0f, 0f, 0f);

        CanvasGroup cg = GetOrAdd<CanvasGroup>(panelGO);
        cg.alpha = 1f;
        cg.interactable = true;
        cg.blocksRaycasts = true;

        // 1. Dark full-screen scrim
        GameObject overlayGO = EnsureChildUI(panelGO, "Overlay_GameOver", false);
        StretchFill(overlayGO.GetComponent<RectTransform>(), 0f, 0f, 0f, 0f);
        Image overlayImg = GetOrAdd<Image>(overlayGO);
        overlayImg.sprite = null;
        overlayImg.color = SCRIM_DARK;
        overlayImg.raycastTarget = true;

        // 2. Central Card
        GameObject cardGO = EnsureChildUI(panelGO, "Card_GameOver", false);
        RectTransform cardRT = cardGO.GetComponent<RectTransform>();
        cardRT.anchorMin = new Vector2(0.5f, 0.5f);
        cardRT.anchorMax = new Vector2(0.5f, 0.5f);
        cardRT.pivot = new Vector2(0.5f, 0.5f);
        cardRT.anchoredPosition = Vector2.zero;
        cardRT.sizeDelta = new Vector2(760f, 440f);
        ApplyStoneCardStyle(cardGO, STONE_CARD, GOLD_BORDER, 2.5f, true);

        // Header banner
        GameObject headerGO = EnsureChildUI(cardGO, "Header_GameOver", false);
        RectTransform headerRT = headerGO.GetComponent<RectTransform>();
        headerRT.anchorMin = new Vector2(0.5f, 0.5f);
        headerRT.anchorMax = new Vector2(0.5f, 0.5f);
        headerRT.pivot = new Vector2(0.5f, 0.5f);
        headerRT.anchoredPosition = new Vector2(0f, 145f);
        headerRT.sizeDelta = new Vector2(700f, 96f);
        Image headerImg = GetOrAdd<Image>(headerGO);
        headerImg.sprite = assets.frameMoss;
        headerImg.type = Image.Type.Sliced;
        headerImg.pixelsPerUnitMultiplier = 2.3f;
        headerImg.color = Color.white;
        headerImg.raycastTarget = false;

        GameObject titleGO = EnsureChildUI(headerGO, "Text_Title", false);
        StretchFill(titleGO.GetComponent<RectTransform>(), 55f, 12f, 55f, 12f);
        ApplyOswaldText(GetOrAdd<TextMeshProUGUI>(titleGO), "HAS CAÍDO EN LAS CATACUMBAS", 36f, GOLD_TEXT, assets);

        // Subtitle
        GameObject subGO = EnsureChildUI(cardGO, "Text_Subtitle", false);
        RectTransform subRT = subGO.GetComponent<RectTransform>();
        subRT.anchorMin = new Vector2(0.5f, 0.5f);
        subRT.anchorMax = new Vector2(0.5f, 0.5f);
        subRT.pivot = new Vector2(0.5f, 0.5f);
        subRT.anchoredPosition = new Vector2(0f, 12f);
        subRT.sizeDelta = new Vector2(640f, 80f);
        ApplyBodyText(GetOrAdd<TextMeshProUGUI>(subGO), "El guardián ancestral ha reclamado tu alma.", 25f, PARCHMENT_TEXT, TextAlignmentOptions.Center, assets.libFont, assets.libShadowMat);

        // Buttons: Reintentar + Menú Principal
        GameObject btnRetry = SetupGameOverButton(cardGO, "Btn_Reintentar", "REINTENTAR", new Vector2(-170f, -115f), new Vector2(300f, 86f), 30f, assets, goCtrl.RestartLevel);
        GameObject btnMenu = SetupGameOverButton(cardGO, "Btn_MenuPrincipal", "MENÚ PRINCIPAL", new Vector2(170f, -115f), new Vector2(300f, 86f), 28f, assets, goCtrl.ReturnToMainMenu);

        goCtrl.panelGameOver = panelGO;
        goCtrl.panelCanvasGroup = cg;
        panelGO.SetActive(false);

        EditorUtility.SetDirty(goCtrl);
        EditorUtility.SetDirty(panelGO);
        EditorUtility.SetDirty(btnRetry);
        EditorUtility.SetDirty(btnMenu);
    }

    private static GameObject SetupGameOverButton(
        GameObject parent,
        string btnName,
        string label,
        Vector2 pos,
        Vector2 size,
        float fontSize,
        UIAssets assets,
        UnityAction action)
    {
        GameObject btnGO = EnsureChildUI(parent, btnName, false);
        GetOrAdd<Image>(btnGO);
        Button btn = GetOrAdd<Button>(btnGO);

        // Remove duplicate persistent calls cleanly and bind fresh listener
        int count = btn.onClick.GetPersistentEventCount();
        for (int i = count - 1; i >= 0; i--)
        {
            UnityEventTools.RemovePersistentListener(btn.onClick, i);
        }
        UnityEventTools.AddPersistentListener(btn.onClick, action);

        GameObject textGO = EnsureChildUI(btnGO, "Text (TMP)", false);
        StretchFill(textGO.GetComponent<RectTransform>(), 24f, 8f, 24f, 8f);
        GetOrAdd<TextMeshProUGUI>(textGO);

        StyleTemplatedButton(btnGO.transform, label, pos, size, assets.frameGold, 2.5f, fontSize, assets);
        return btnGO;
    }

    // =========================================================================
    // 6. STYLING HELPERS
    // =========================================================================
    private static void Configure1080pScaler(Canvas c)
    {
        CanvasScaler scaler = GetOrAdd<CanvasScaler>(c.gameObject);
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(1920f, 1080f);
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
        scaler.matchWidthOrHeight = 0.5f;
        EditorUtility.SetDirty(scaler);
    }

    private static void StyleFullScreenBackground(Transform rawT, Texture2D tex, Color tint)
    {
        if (rawT == null) return;
        RectTransform rt = rawT.GetComponent<RectTransform>();
        if (rt != null)
        {
            StretchFill(rt, 0f, 0f, 0f, 0f);
        }
        RawImage raw = rawT.GetComponent<RawImage>();
        if (raw != null)
        {
            if (tex != null) raw.texture = tex;
            raw.color = tint;
            raw.raycastTarget = false;
            EditorUtility.SetDirty(raw);
        }
    }

    private static void MoveAndStylePauseButton(
        Transform oldParent,
        Transform newParent,
        string btnName,
        string spanishLabel,
        Vector2 anchoredPos,
        UIAssets assets)
    {
        Transform btnT = oldParent.Find(btnName) ?? newParent.Find(btnName);
        if (btnT == null) return;
        btnT.SetParent(newParent, false);
        StyleTemplatedButton(btnT, spanishLabel, anchoredPos, new Vector2(380f, 86f), assets.frameGold, 2.5f, 30f, assets);
    }

    private static void StyleTemplatedButton(
        Transform btnT,
        string label,
        Vector2 anchoredPos,
        Vector2 sizeDelta,
        Sprite frameSprite,
        float ppuMult,
        float fontSize,
        UIAssets assets)
    {
        if (btnT == null) return;

        RectTransform rt = btnT.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0.5f, 0.5f);
        rt.anchorMax = new Vector2(0.5f, 0.5f);
        rt.pivot = new Vector2(0.5f, 0.5f);
        rt.anchoredPosition = anchoredPos;
        rt.sizeDelta = sizeDelta;
        rt.localScale = Vector3.one;

        Image img = GetOrAdd<Image>(btnT.gameObject);
        img.sprite = frameSprite;
        img.type = Image.Type.Sliced;
        img.pixelsPerUnitMultiplier = ppuMult;
        img.color = Color.white;
        img.raycastTarget = true;

        Outline oldOutline = btnT.GetComponent<Outline>();
        if (oldOutline != null) UnityEngine.Object.DestroyImmediate(oldOutline);

        Button btn = btnT.GetComponent<Button>();
        if (btn != null)
        {
            btn.transition = Selectable.Transition.ColorTint;
            ColorBlock cb = btn.colors;
            cb.normalColor = BTN_SPRITE_NORMAL;
            cb.highlightedColor = BTN_SPRITE_HIGHLIGHT;
            cb.pressedColor = BTN_SPRITE_PRESSED;
            cb.selectedColor = BTN_SPRITE_SELECTED;
            cb.disabledColor = new Color(0.4f, 0.4f, 0.4f, 0.6f);
            cb.colorMultiplier = 1f;
            cb.fadeDuration = 0.1f;
            btn.colors = cb;
            btn.targetGraphic = img;
            EditorUtility.SetDirty(btn);
        }

        Transform textT = btnT.Find("Text (TMP)");
        if (textT != null)
        {
            StretchFill(textT.GetComponent<RectTransform>(), 24f, 8f, 24f, 8f);
            TextMeshProUGUI tmp = textT.GetComponent<TextMeshProUGUI>();
            ApplyOswaldText(tmp, label, fontSize, GOLD_TEXT, assets);
        }

        EditorUtility.SetDirty(btnT.gameObject);
    }

    private static void StyleRelicSlot(Transform slotT, float posY, UIAssets assets)
    {
        if (slotT == null) return;
        RectTransform rt = slotT.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0f, 1f);
        rt.anchorMax = new Vector2(1f, 1f);
        rt.pivot = new Vector2(0f, 1f);
        rt.anchoredPosition = new Vector2(22f, posY);
        rt.sizeDelta = new Vector2(-44f, 32f);

        TextMeshProUGUI tmp = slotT.GetComponent<TextMeshProUGUI>();
        if (tmp != null)
        {
            ApplyBodyText(tmp, tmp.text, 20f, tmp.color, TextAlignmentOptions.Left, assets.robotoFont, assets.robotoShadowMat);
        }
    }

    private static void ApplyStoneCardStyle(GameObject go, Color bgColor, Color borderColor, float borderThickness, bool blockRaycasts)
    {
        Outline oldOut = go.GetComponent<Outline>();
        if (oldOut != null) UnityEngine.Object.DestroyImmediate(oldOut);

        Image bg = GetOrAdd<Image>(go);
        bg.sprite = null;
        bg.type = Image.Type.Simple;
        bg.color = bgColor;
        bg.raycastTarget = blockRaycasts;

        CreateBorderStrip(go, "Border_Top", new Vector2(0f, 1f), new Vector2(1f, 1f), new Vector2(0.5f, 1f), new Vector2(0f, borderThickness), borderColor);
        CreateBorderStrip(go, "Border_Bottom", new Vector2(0f, 0f), new Vector2(1f, 0f), new Vector2(0.5f, 0f), new Vector2(0f, borderThickness), borderColor);
        CreateBorderStrip(go, "Border_Left", new Vector2(0f, 0f), new Vector2(0f, 1f), new Vector2(0f, 0.5f), new Vector2(borderThickness, 0f), borderColor);
        CreateBorderStrip(go, "Border_Right", new Vector2(1f, 0f), new Vector2(1f, 1f), new Vector2(1f, 0.5f), new Vector2(borderThickness, 0f), borderColor);
    }

    private static void CreateBorderStrip(
        GameObject parent,
        string stripName,
        Vector2 anchorMin,
        Vector2 anchorMax,
        Vector2 pivot,
        Vector2 sizeDelta,
        Color color)
    {
        GameObject strip = EnsureChildUI(parent, stripName, false);
        RectTransform rt = strip.GetComponent<RectTransform>();
        rt.anchorMin = anchorMin;
        rt.anchorMax = anchorMax;
        rt.pivot = pivot;
        rt.anchoredPosition = Vector2.zero;
        rt.sizeDelta = sizeDelta;
        rt.localScale = Vector3.one;

        Image img = GetOrAdd<Image>(strip);
        img.sprite = null;
        img.type = Image.Type.Simple;
        img.color = color;
        img.raycastTarget = false;

        strip.transform.SetAsLastSibling();
    }

    private static void ApplyOswaldText(TextMeshProUGUI tmp, string text, float fontSize, Color color, UIAssets assets)
    {
        if (tmp == null) return;
        if (assets.oswaldFont != null) tmp.font = assets.oswaldFont;
        if (assets.oswaldMat != null) tmp.fontSharedMaterial = assets.oswaldMat;

        tmp.text = text;
        tmp.fontSize = fontSize;
        tmp.enableAutoSizing = false;
        tmp.fontStyle = FontStyles.Normal;
        tmp.alignment = TextAlignmentOptions.Center;
        tmp.enableWordWrapping = false;
        tmp.overflowMode = TextOverflowModes.Overflow;
        tmp.color = color;
        tmp.raycastTarget = false;

        Shadow sh = GetOrAdd<Shadow>(tmp.gameObject);
        sh.effectColor = SHADOW_DARK;
        sh.effectDistance = new Vector2(2f, -2f);

        EditorUtility.SetDirty(tmp);
    }

    private static void ApplyBodyText(
        TextMeshProUGUI tmp,
        string text,
        float fontSize,
        Color color,
        TextAlignmentOptions alignment,
        TMP_FontAsset font,
        Material shadowMat)
    {
        if (tmp == null) return;
        if (font != null)
        {
            tmp.font = font;
            tmp.fontSharedMaterial = shadowMat != null ? shadowMat : font.material;
        }

        tmp.text = text;
        tmp.fontSize = fontSize;
        tmp.enableAutoSizing = false;
        tmp.fontStyle = FontStyles.Normal;
        tmp.alignment = alignment;
        tmp.enableWordWrapping = true;
        tmp.overflowMode = TextOverflowModes.Overflow;
        tmp.color = color;
        tmp.raycastTarget = false;

        // Clean any uGUI Shadow/Outline when using TMP Drop Shadow material preset
        Shadow sh = tmp.GetComponent<Shadow>();
        if (sh != null && !(sh is Outline)) UnityEngine.Object.DestroyImmediate(sh);

        EditorUtility.SetDirty(tmp);
    }

    private static GameObject EnsureChildUI(GameObject parent, string name, bool asSecondSibling)
    {
        Transform existing = parent.transform.Find(name);
        if (existing != null)
        {
            if (asSecondSibling && parent.transform.childCount > 1)
                existing.SetSiblingIndex(1);
            return existing.gameObject;
        }

        GameObject go = new GameObject(name, typeof(RectTransform));
        go.layer = 5; // UI layer
        go.transform.SetParent(parent.transform, false);
        if (asSecondSibling && parent.transform.childCount > 1)
        {
            go.transform.SetSiblingIndex(1);
        }
        return go;
    }

    private static void StretchFill(RectTransform rt, float left, float bottom, float right, float top)
    {
        if (rt == null) return;
        rt.anchorMin = Vector2.zero;
        rt.anchorMax = Vector2.one;
        rt.pivot = new Vector2(0.5f, 0.5f);
        rt.offsetMin = new Vector2(left, bottom);
        rt.offsetMax = new Vector2(-right, -top);
        rt.localScale = Vector3.one;
    }

    private static T GetOrAdd<T>(GameObject go) where T : Component
    {
        T comp = go.GetComponent<T>();
        if (comp == null) comp = go.AddComponent<T>();
        return comp;
    }

    private static Transform FindDeepChild(Transform root, string exactName)
    {
        foreach (Transform t in root.GetComponentsInChildren<Transform>(true))
        {
            if (t.name == exactName) return t;
        }
        return null;
    }
}
