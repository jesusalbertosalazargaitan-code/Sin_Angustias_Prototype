This file is a merged representation of a subset of the codebase, containing specifically included files and files not matching ignore patterns, combined into a single document by Repomix.
The content has been processed where line numbers have been added.

# File Summary

## Purpose
This file contains a packed representation of a subset of the repository's contents that is considered the most important context.
It is designed to be easily consumable by AI systems for analysis, code review,
or other automated processes.

## File Format
The content is organized as follows:
1. This summary section
2. Repository information
3. Directory structure
4. Repository files (if enabled)
5. Multiple file entries, each consisting of:
  a. A header with the file path (## File: path/to/file)
  b. The full contents of the file in a code block

## Usage Guidelines
- This file should be treated as read-only. Any changes should be made to the
  original repository files, not this packed version.
- When processing this file, use the file path to distinguish
  between different files in the repository.
- Be aware that this file may contain sensitive information. Handle it with
  the same level of security as you would the original repository.

## Notes
- Some files may have been excluded based on .gitignore rules and Repomix's configuration
- Binary files are not included in this packed representation. Please refer to the Repository Structure section for a complete list of file paths, including binary files
- Only files matching these patterns are included: Assets/_Scripts/CameraController.cs, Assets/_Scripts/ElementsMove.cs, Assets/_Scripts/EnemyIA.cs, Assets/_Scripts/FriendlyIA.cs, Assets/_Scripts/GameManager.cs, Assets/_Scripts/IntermitentL.cs, Assets/_Scripts/Objects.cs, Assets/_Scripts/PlayerController.cs, Assets/PlayerControllerInput.inputactions, Assets/_Prefabs/Contain.prefab, Assets/_Prefabs/Enemy.prefab, Assets/_Prefabs/FrendlyIA.prefab, Assets/_Prefabs/Player.prefab, Assets/_Prefabs/rust_key.prefab, Assets/_Scenes/MainMen*.unity, Assets/_Scenes/Lvl 1.unity, Assets/_Scenes/Lvl 2.unity, ProjectSettings/EditorBuildSettings.asset, ProjectSettings/TagManager.asset, Packages/manifest.json
- Files matching these patterns are excluded: Library/**, Temp/**, obj/**, Obj/**, Logs/**, UserSettings/**, Builds/**, MemoryCaptures/**, ProjectFinalV3/**, proyectoFinalSenaV3/**, **/*.meta, **/*.png, **/*.jpg, **/*.fbx, **/*.blend, **/*.wav, **/*.mp3, **/*.mp4, **/*.psd, **/*.tif, **/*.csproj, **/*.sln, Assets/TextMesh Pro/**, Assets/_AllSkyFree/**, Assets/Fantasy Forest Environment Free Sample/**, Assets/Mine/**, Assets/StaffOfPain/**, Assets/_Rust Key/**, Assets/_Scripts/NewBehaviourScript.cs, Assets/_Scripts/Test.cs, Assets/_Scenes/lvl11.unity, Assets/Kbh_skel.unity, Library/**, Temp/**, Obj/**, Logs/**, UserSettings/**
- Files matching patterns in .gitignore are excluded
- Files matching default ignore patterns are excluded
- Line numbers have been added to the beginning of each line
- Files are sorted by Git change count (files with more changes are at the bottom)

# Directory Structure
```
Assets/
  _Prefabs/
    Contain.prefab
    Enemy.prefab
    FrendlyIA.prefab
    Player.prefab
    rust_key.prefab
  _Scenes/
    Lvl 1.unity
    Lvl 2.unity
    MainMenú.unity
  _Scripts/
    CameraController.cs
    ElementsMove.cs
    EnemyIA.cs
    FriendlyIA.cs
    GameManager.cs
    IntermitentL.cs
    Objects.cs
    PlayerController.cs
  PlayerControllerInput.inputactions
Packages/
  manifest.json
ProjectSettings/
  EditorBuildSettings.asset
  TagManager.asset
```

# Files

## File: Assets/_Scenes/MainMenú.unity
```
   1: %YAML 1.1
   2: %TAG !u! tag:unity3d.com,2011:
   3: --- !u!29 &1
   4: OcclusionCullingSettings:
   5:   m_ObjectHideFlags: 0
   6:   serializedVersion: 2
   7:   m_OcclusionBakeSettings:
   8:     smallestOccluder: 5
   9:     smallestHole: 0.25
  10:     backfaceThreshold: 100
  11:   m_SceneGUID: 00000000000000000000000000000000
  12:   m_OcclusionCullingData: {fileID: 0}
  13: --- !u!104 &2
  14: RenderSettings:
  15:   m_ObjectHideFlags: 0
  16:   serializedVersion: 9
  17:   m_Fog: 0
  18:   m_FogColor: {r: 0.5, g: 0.5, b: 0.5, a: 1}
  19:   m_FogMode: 3
  20:   m_FogDensity: 0.01
  21:   m_LinearFogStart: 0
  22:   m_LinearFogEnd: 300
  23:   m_AmbientSkyColor: {r: 0.212, g: 0.227, b: 0.259, a: 1}
  24:   m_AmbientEquatorColor: {r: 0.114, g: 0.125, b: 0.133, a: 1}
  25:   m_AmbientGroundColor: {r: 0.047, g: 0.043, b: 0.035, a: 1}
  26:   m_AmbientIntensity: 1
  27:   m_AmbientMode: 0
  28:   m_SubtractiveShadowColor: {r: 0.42, g: 0.478, b: 0.627, a: 1}
  29:   m_SkyboxMaterial: {fileID: 10304, guid: 0000000000000000f000000000000000, type: 0}
  30:   m_HaloStrength: 0.5
  31:   m_FlareStrength: 1
  32:   m_FlareFadeSpeed: 3
  33:   m_HaloTexture: {fileID: 0}
  34:   m_SpotCookie: {fileID: 10001, guid: 0000000000000000e000000000000000, type: 0}
  35:   m_DefaultReflectionMode: 0
  36:   m_DefaultReflectionResolution: 128
  37:   m_ReflectionBounces: 1
  38:   m_ReflectionIntensity: 1
  39:   m_CustomReflection: {fileID: 0}
  40:   m_Sun: {fileID: 0}
  41:   m_UseRadianceAmbientProbe: 0
  42: --- !u!157 &3
  43: LightmapSettings:
  44:   m_ObjectHideFlags: 0
  45:   serializedVersion: 12
  46:   m_GIWorkflowMode: 1
  47:   m_GISettings:
  48:     serializedVersion: 2
  49:     m_BounceScale: 1
  50:     m_IndirectOutputScale: 1
  51:     m_AlbedoBoost: 1
  52:     m_EnvironmentLightingMode: 0
  53:     m_EnableBakedLightmaps: 1
  54:     m_EnableRealtimeLightmaps: 0
  55:   m_LightmapEditorSettings:
  56:     serializedVersion: 12
  57:     m_Resolution: 2
  58:     m_BakeResolution: 40
  59:     m_AtlasSize: 1024
  60:     m_AO: 0
  61:     m_AOMaxDistance: 1
  62:     m_CompAOExponent: 1
  63:     m_CompAOExponentDirect: 0
  64:     m_ExtractAmbientOcclusion: 0
  65:     m_Padding: 2
  66:     m_LightmapParameters: {fileID: 0}
  67:     m_LightmapsBakeMode: 1
  68:     m_TextureCompression: 1
  69:     m_FinalGather: 0
  70:     m_FinalGatherFiltering: 1
  71:     m_FinalGatherRayCount: 256
  72:     m_ReflectionCompression: 2
  73:     m_MixedBakeMode: 2
  74:     m_BakeBackend: 1
  75:     m_PVRSampling: 1
  76:     m_PVRDirectSampleCount: 32
  77:     m_PVRSampleCount: 512
  78:     m_PVRBounces: 2
  79:     m_PVREnvironmentSampleCount: 256
  80:     m_PVREnvironmentReferencePointCount: 2048
  81:     m_PVRFilteringMode: 1
  82:     m_PVRDenoiserTypeDirect: 1
  83:     m_PVRDenoiserTypeIndirect: 1
  84:     m_PVRDenoiserTypeAO: 1
  85:     m_PVRFilterTypeDirect: 0
  86:     m_PVRFilterTypeIndirect: 0
  87:     m_PVRFilterTypeAO: 0
  88:     m_PVREnvironmentMIS: 1
  89:     m_PVRCulling: 1
  90:     m_PVRFilteringGaussRadiusDirect: 1
  91:     m_PVRFilteringGaussRadiusIndirect: 5
  92:     m_PVRFilteringGaussRadiusAO: 2
  93:     m_PVRFilteringAtrousPositionSigmaDirect: 0.5
  94:     m_PVRFilteringAtrousPositionSigmaIndirect: 2
  95:     m_PVRFilteringAtrousPositionSigmaAO: 1
  96:     m_ExportTrainingData: 0
  97:     m_TrainingDataDestination: TrainingData
  98:     m_LightProbeSampleCountMultiplier: 4
  99:   m_LightingDataAsset: {fileID: 0}
 100:   m_LightingSettings: {fileID: 0}
 101: --- !u!196 &4
 102: NavMeshSettings:
 103:   serializedVersion: 2
 104:   m_ObjectHideFlags: 0
 105:   m_BuildSettings:
 106:     serializedVersion: 3
 107:     agentTypeID: 0
 108:     agentRadius: 0.5
 109:     agentHeight: 2
 110:     agentSlope: 45
 111:     agentClimb: 0.4
 112:     ledgeDropHeight: 0
 113:     maxJumpAcrossDistance: 0
 114:     minRegionArea: 2
 115:     manualCellSize: 0
 116:     cellSize: 0.16666667
 117:     manualTileSize: 0
 118:     tileSize: 256
 119:     buildHeightMesh: 0
 120:     maxJobWorkers: 0
 121:     preserveTilesOutsideBounds: 0
 122:     debug:
 123:       m_Flags: 0
 124:   m_NavMeshData: {fileID: 0}
 125: --- !u!1 &1056416
 126: GameObject:
 127:   m_ObjectHideFlags: 0
 128:   m_CorrespondingSourceObject: {fileID: 0}
 129:   m_PrefabInstance: {fileID: 0}
 130:   m_PrefabAsset: {fileID: 0}
 131:   serializedVersion: 6
 132:   m_Component:
 133:   - component: {fileID: 1056417}
 134:   - component: {fileID: 1056419}
 135:   - component: {fileID: 1056418}
 136:   m_Layer: 5
 137:   m_Name: RawImage
 138:   m_TagString: Untagged
 139:   m_Icon: {fileID: 0}
 140:   m_NavMeshLayer: 0
 141:   m_StaticEditorFlags: 0
 142:   m_IsActive: 1
 143: --- !u!224 &1056417
 144: RectTransform:
 145:   m_ObjectHideFlags: 0
 146:   m_CorrespondingSourceObject: {fileID: 0}
 147:   m_PrefabInstance: {fileID: 0}
 148:   m_PrefabAsset: {fileID: 0}
 149:   m_GameObject: {fileID: 1056416}
 150:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
 151:   m_LocalPosition: {x: 0, y: 0, z: 0}
 152:   m_LocalScale: {x: 1, y: 1, z: 1}
 153:   m_ConstrainProportionsScale: 0
 154:   m_Children: []
 155:   m_Father: {fileID: 1662025907}
 156:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 157:   m_AnchorMin: {x: 0.5, y: 0.5}
 158:   m_AnchorMax: {x: 0.5, y: 0.5}
 159:   m_AnchoredPosition: {x: 0, y: 0.0007915497}
 160:   m_SizeDelta: {x: 800, y: 450.16}
 161:   m_Pivot: {x: 0.5, y: 0.5}
 162: --- !u!114 &1056418
 163: MonoBehaviour:
 164:   m_ObjectHideFlags: 0
 165:   m_CorrespondingSourceObject: {fileID: 0}
 166:   m_PrefabInstance: {fileID: 0}
 167:   m_PrefabAsset: {fileID: 0}
 168:   m_GameObject: {fileID: 1056416}
 169:   m_Enabled: 1
 170:   m_EditorHideFlags: 0
 171:   m_Script: {fileID: 11500000, guid: 1344c3c82d62a2a41a3576d8abb8e3ea, type: 3}
 172:   m_Name: 
 173:   m_EditorClassIdentifier: 
 174:   m_Material: {fileID: 0}
 175:   m_Color: {r: 1, g: 1, b: 1, a: 1}
 176:   m_RaycastTarget: 1
 177:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
 178:   m_Maskable: 1
 179:   m_OnCullStateChanged:
 180:     m_PersistentCalls:
 181:       m_Calls: []
 182:   m_Texture: {fileID: 2800000, guid: c50cf53deda4a444791ad8c26d6f135b, type: 3}
 183:   m_UVRect:
 184:     serializedVersion: 2
 185:     x: 0
 186:     y: 0
 187:     width: 1
 188:     height: 1
 189: --- !u!222 &1056419
 190: CanvasRenderer:
 191:   m_ObjectHideFlags: 0
 192:   m_CorrespondingSourceObject: {fileID: 0}
 193:   m_PrefabInstance: {fileID: 0}
 194:   m_PrefabAsset: {fileID: 0}
 195:   m_GameObject: {fileID: 1056416}
 196:   m_CullTransparentMesh: 1
 197: --- !u!1 &33020376
 198: GameObject:
 199:   m_ObjectHideFlags: 0
 200:   m_CorrespondingSourceObject: {fileID: 0}
 201:   m_PrefabInstance: {fileID: 0}
 202:   m_PrefabAsset: {fileID: 0}
 203:   serializedVersion: 6
 204:   m_Component:
 205:   - component: {fileID: 33020377}
 206:   - component: {fileID: 33020380}
 207:   - component: {fileID: 33020379}
 208:   - component: {fileID: 33020378}
 209:   m_Layer: 5
 210:   m_Name: Quit
 211:   m_TagString: Untagged
 212:   m_Icon: {fileID: 0}
 213:   m_NavMeshLayer: 0
 214:   m_StaticEditorFlags: 0
 215:   m_IsActive: 1
 216: --- !u!224 &33020377
 217: RectTransform:
 218:   m_ObjectHideFlags: 0
 219:   m_CorrespondingSourceObject: {fileID: 0}
 220:   m_PrefabInstance: {fileID: 0}
 221:   m_PrefabAsset: {fileID: 0}
 222:   m_GameObject: {fileID: 33020376}
 223:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
 224:   m_LocalPosition: {x: 0, y: 0, z: 0}
 225:   m_LocalScale: {x: 1, y: 1, z: 1}
 226:   m_ConstrainProportionsScale: 0
 227:   m_Children:
 228:   - {fileID: 893179711}
 229:   m_Father: {fileID: 1662025907}
 230:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 231:   m_AnchorMin: {x: 0.5, y: 0.5}
 232:   m_AnchorMax: {x: 0.5, y: 0.5}
 233:   m_AnchoredPosition: {x: 0, y: -149.2}
 234:   m_SizeDelta: {x: 169.1472, y: 69.4794}
 235:   m_Pivot: {x: 0.5, y: 0.5}
 236: --- !u!114 &33020378
 237: MonoBehaviour:
 238:   m_ObjectHideFlags: 0
 239:   m_CorrespondingSourceObject: {fileID: 0}
 240:   m_PrefabInstance: {fileID: 0}
 241:   m_PrefabAsset: {fileID: 0}
 242:   m_GameObject: {fileID: 33020376}
 243:   m_Enabled: 1
 244:   m_EditorHideFlags: 0
 245:   m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
 246:   m_Name: 
 247:   m_EditorClassIdentifier: 
 248:   m_Navigation:
 249:     m_Mode: 3
 250:     m_WrapAround: 0
 251:     m_SelectOnUp: {fileID: 0}
 252:     m_SelectOnDown: {fileID: 0}
 253:     m_SelectOnLeft: {fileID: 0}
 254:     m_SelectOnRight: {fileID: 0}
 255:   m_Transition: 1
 256:   m_Colors:
 257:     m_NormalColor: {r: 0.7075472, g: 0, b: 0, a: 0.14901961}
 258:     m_HighlightedColor: {r: 0.754717, g: 0.3025988, b: 0.3025988, a: 0.34117648}
 259:     m_PressedColor: {r: 0.7169812, g: 0.26041296, b: 0.26041296, a: 0.43137255}
 260:     m_SelectedColor: {r: 0.745283, g: 0.1511659, b: 0.1511659, a: 0.70980394}
 261:     m_DisabledColor: {r: 1, g: 0, b: 0, a: 1}
 262:     m_ColorMultiplier: 1
 263:     m_FadeDuration: 0.1
 264:   m_SpriteState:
 265:     m_HighlightedSprite: {fileID: 0}
 266:     m_PressedSprite: {fileID: 0}
 267:     m_SelectedSprite: {fileID: 0}
 268:     m_DisabledSprite: {fileID: 0}
 269:   m_AnimationTriggers:
 270:     m_NormalTrigger: Normal
 271:     m_HighlightedTrigger: Highlighted
 272:     m_PressedTrigger: Pressed
 273:     m_SelectedTrigger: Selected
 274:     m_DisabledTrigger: Disabled
 275:   m_Interactable: 1
 276:   m_TargetGraphic: {fileID: 33020379}
 277:   m_OnClick:
 278:     m_PersistentCalls:
 279:       m_Calls:
 280:       - m_Target: {fileID: 123974546}
 281:         m_TargetAssemblyTypeName: GameManager, Assembly-CSharp
 282:         m_MethodName: ExitGame
 283:         m_Mode: 1
 284:         m_Arguments:
 285:           m_ObjectArgument: {fileID: 0}
 286:           m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
 287:           m_IntArgument: 0
 288:           m_FloatArgument: 0
 289:           m_StringArgument: 
 290:           m_BoolArgument: 0
 291:         m_CallState: 2
 292: --- !u!114 &33020379
 293: MonoBehaviour:
 294:   m_ObjectHideFlags: 0
 295:   m_CorrespondingSourceObject: {fileID: 0}
 296:   m_PrefabInstance: {fileID: 0}
 297:   m_PrefabAsset: {fileID: 0}
 298:   m_GameObject: {fileID: 33020376}
 299:   m_Enabled: 1
 300:   m_EditorHideFlags: 0
 301:   m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
 302:   m_Name: 
 303:   m_EditorClassIdentifier: 
 304:   m_Material: {fileID: 0}
 305:   m_Color: {r: 1, g: 1, b: 1, a: 1}
 306:   m_RaycastTarget: 1
 307:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
 308:   m_Maskable: 1
 309:   m_OnCullStateChanged:
 310:     m_PersistentCalls:
 311:       m_Calls: []
 312:   m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
 313:   m_Type: 1
 314:   m_PreserveAspect: 0
 315:   m_FillCenter: 1
 316:   m_FillMethod: 4
 317:   m_FillAmount: 1
 318:   m_FillClockwise: 1
 319:   m_FillOrigin: 0
 320:   m_UseSpriteMesh: 0
 321:   m_PixelsPerUnitMultiplier: 1
 322: --- !u!222 &33020380
 323: CanvasRenderer:
 324:   m_ObjectHideFlags: 0
 325:   m_CorrespondingSourceObject: {fileID: 0}
 326:   m_PrefabInstance: {fileID: 0}
 327:   m_PrefabAsset: {fileID: 0}
 328:   m_GameObject: {fileID: 33020376}
 329:   m_CullTransparentMesh: 1
 330: --- !u!1 &92151545
 331: GameObject:
 332:   m_ObjectHideFlags: 0
 333:   m_CorrespondingSourceObject: {fileID: 0}
 334:   m_PrefabInstance: {fileID: 0}
 335:   m_PrefabAsset: {fileID: 0}
 336:   serializedVersion: 6
 337:   m_Component:
 338:   - component: {fileID: 92151548}
 339:   - component: {fileID: 92151547}
 340:   - component: {fileID: 92151546}
 341:   m_Layer: 0
 342:   m_Name: EventSystem
 343:   m_TagString: Untagged
 344:   m_Icon: {fileID: 0}
 345:   m_NavMeshLayer: 0
 346:   m_StaticEditorFlags: 0
 347:   m_IsActive: 1
 348: --- !u!114 &92151546
 349: MonoBehaviour:
 350:   m_ObjectHideFlags: 0
 351:   m_CorrespondingSourceObject: {fileID: 0}
 352:   m_PrefabInstance: {fileID: 0}
 353:   m_PrefabAsset: {fileID: 0}
 354:   m_GameObject: {fileID: 92151545}
 355:   m_Enabled: 1
 356:   m_EditorHideFlags: 0
 357:   m_Script: {fileID: 11500000, guid: 4f231c4fb786f3946a6b90b886c48677, type: 3}
 358:   m_Name: 
 359:   m_EditorClassIdentifier: 
 360:   m_SendPointerHoverToParent: 1
 361:   m_HorizontalAxis: Horizontal
 362:   m_VerticalAxis: Vertical
 363:   m_SubmitButton: Submit
 364:   m_CancelButton: Cancel
 365:   m_InputActionsPerSecond: 10
 366:   m_RepeatDelay: 0.5
 367:   m_ForceModuleActive: 0
 368: --- !u!114 &92151547
 369: MonoBehaviour:
 370:   m_ObjectHideFlags: 0
 371:   m_CorrespondingSourceObject: {fileID: 0}
 372:   m_PrefabInstance: {fileID: 0}
 373:   m_PrefabAsset: {fileID: 0}
 374:   m_GameObject: {fileID: 92151545}
 375:   m_Enabled: 1
 376:   m_EditorHideFlags: 0
 377:   m_Script: {fileID: 11500000, guid: 76c392e42b5098c458856cdf6ecaaaa1, type: 3}
 378:   m_Name: 
 379:   m_EditorClassIdentifier: 
 380:   m_FirstSelected: {fileID: 0}
 381:   m_sendNavigationEvents: 1
 382:   m_DragThreshold: 10
 383: --- !u!4 &92151548
 384: Transform:
 385:   m_ObjectHideFlags: 0
 386:   m_CorrespondingSourceObject: {fileID: 0}
 387:   m_PrefabInstance: {fileID: 0}
 388:   m_PrefabAsset: {fileID: 0}
 389:   m_GameObject: {fileID: 92151545}
 390:   serializedVersion: 2
 391:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
 392:   m_LocalPosition: {x: 0, y: 0, z: 0}
 393:   m_LocalScale: {x: 1, y: 1, z: 1}
 394:   m_ConstrainProportionsScale: 0
 395:   m_Children: []
 396:   m_Father: {fileID: 0}
 397:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 398: --- !u!1 &123974545
 399: GameObject:
 400:   m_ObjectHideFlags: 0
 401:   m_CorrespondingSourceObject: {fileID: 0}
 402:   m_PrefabInstance: {fileID: 0}
 403:   m_PrefabAsset: {fileID: 0}
 404:   serializedVersion: 6
 405:   m_Component:
 406:   - component: {fileID: 123974547}
 407:   - component: {fileID: 123974546}
 408:   m_Layer: 0
 409:   m_Name: Game Manager
 410:   m_TagString: Untagged
 411:   m_Icon: {fileID: 0}
 412:   m_NavMeshLayer: 0
 413:   m_StaticEditorFlags: 0
 414:   m_IsActive: 1
 415: --- !u!114 &123974546
 416: MonoBehaviour:
 417:   m_ObjectHideFlags: 0
 418:   m_CorrespondingSourceObject: {fileID: 0}
 419:   m_PrefabInstance: {fileID: 0}
 420:   m_PrefabAsset: {fileID: 0}
 421:   m_GameObject: {fileID: 123974545}
 422:   m_Enabled: 1
 423:   m_EditorHideFlags: 0
 424:   m_Script: {fileID: 11500000, guid: 09771279f7ea7e54e961eb14f635a122, type: 3}
 425:   m_Name: 
 426:   m_EditorClassIdentifier: 
 427:   sceneChange: 1
 428:   menuOff: 0
 429:   prefab1: 0
 430:   prefab2: 0
 431:   count: {fileID: 0}
 432:   countOut: {fileID: 0}
 433:   pause: {fileID: 0}
 434:   next: {fileID: 0}
 435:   options: {fileID: 1518948668}
 436:   menu: {fileID: 1662025903}
 437:   score: {fileID: 0}
 438:   enemy: {fileID: 0}
 439:   vectors3: []
 440:   lightF: {fileID: 0}
 441:   objectScore: 0
 442: --- !u!4 &123974547
 443: Transform:
 444:   m_ObjectHideFlags: 0
 445:   m_CorrespondingSourceObject: {fileID: 0}
 446:   m_PrefabInstance: {fileID: 0}
 447:   m_PrefabAsset: {fileID: 0}
 448:   m_GameObject: {fileID: 123974545}
 449:   serializedVersion: 2
 450:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
 451:   m_LocalPosition: {x: 0, y: 0, z: 0}
 452:   m_LocalScale: {x: 1, y: 1, z: 1}
 453:   m_ConstrainProportionsScale: 0
 454:   m_Children: []
 455:   m_Father: {fileID: 0}
 456:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 457: --- !u!1 &164198535
 458: GameObject:
 459:   m_ObjectHideFlags: 0
 460:   m_CorrespondingSourceObject: {fileID: 0}
 461:   m_PrefabInstance: {fileID: 0}
 462:   m_PrefabAsset: {fileID: 0}
 463:   serializedVersion: 6
 464:   m_Component:
 465:   - component: {fileID: 164198536}
 466:   - component: {fileID: 164198539}
 467:   - component: {fileID: 164198538}
 468:   - component: {fileID: 164198537}
 469:   m_Layer: 5
 470:   m_Name: Regresar
 471:   m_TagString: Untagged
 472:   m_Icon: {fileID: 0}
 473:   m_NavMeshLayer: 0
 474:   m_StaticEditorFlags: 0
 475:   m_IsActive: 1
 476: --- !u!224 &164198536
 477: RectTransform:
 478:   m_ObjectHideFlags: 0
 479:   m_CorrespondingSourceObject: {fileID: 0}
 480:   m_PrefabInstance: {fileID: 0}
 481:   m_PrefabAsset: {fileID: 0}
 482:   m_GameObject: {fileID: 164198535}
 483:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
 484:   m_LocalPosition: {x: 0, y: 0, z: 0}
 485:   m_LocalScale: {x: 1, y: 1, z: 1}
 486:   m_ConstrainProportionsScale: 0
 487:   m_Children:
 488:   - {fileID: 240184756}
 489:   m_Father: {fileID: 1518948672}
 490:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 491:   m_AnchorMin: {x: 0.5, y: 0.5}
 492:   m_AnchorMax: {x: 0.5, y: 0.5}
 493:   m_AnchoredPosition: {x: -180.8, y: -69.7}
 494:   m_SizeDelta: {x: 169.9877, y: 48.0902}
 495:   m_Pivot: {x: 0.5, y: 0.5}
 496: --- !u!114 &164198537
 497: MonoBehaviour:
 498:   m_ObjectHideFlags: 0
 499:   m_CorrespondingSourceObject: {fileID: 0}
 500:   m_PrefabInstance: {fileID: 0}
 501:   m_PrefabAsset: {fileID: 0}
 502:   m_GameObject: {fileID: 164198535}
 503:   m_Enabled: 1
 504:   m_EditorHideFlags: 0
 505:   m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
 506:   m_Name: 
 507:   m_EditorClassIdentifier: 
 508:   m_Navigation:
 509:     m_Mode: 3
 510:     m_WrapAround: 0
 511:     m_SelectOnUp: {fileID: 0}
 512:     m_SelectOnDown: {fileID: 0}
 513:     m_SelectOnLeft: {fileID: 0}
 514:     m_SelectOnRight: {fileID: 0}
 515:   m_Transition: 1
 516:   m_Colors:
 517:     m_NormalColor: {r: 0.7075472, g: 0, b: 0, a: 0.14901961}
 518:     m_HighlightedColor: {r: 0.754717, g: 0.3025988, b: 0.3025988, a: 0.34117648}
 519:     m_PressedColor: {r: 0.7169812, g: 0.26041296, b: 0.26041296, a: 0.43137255}
 520:     m_SelectedColor: {r: 0.745283, g: 0.1511659, b: 0.1511659, a: 0.70980394}
 521:     m_DisabledColor: {r: 1, g: 0, b: 0, a: 1}
 522:     m_ColorMultiplier: 1
 523:     m_FadeDuration: 0.1
 524:   m_SpriteState:
 525:     m_HighlightedSprite: {fileID: 0}
 526:     m_PressedSprite: {fileID: 0}
 527:     m_SelectedSprite: {fileID: 0}
 528:     m_DisabledSprite: {fileID: 0}
 529:   m_AnimationTriggers:
 530:     m_NormalTrigger: Normal
 531:     m_HighlightedTrigger: Highlighted
 532:     m_PressedTrigger: Pressed
 533:     m_SelectedTrigger: Selected
 534:     m_DisabledTrigger: Disabled
 535:   m_Interactable: 1
 536:   m_TargetGraphic: {fileID: 164198538}
 537:   m_OnClick:
 538:     m_PersistentCalls:
 539:       m_Calls:
 540:       - m_Target: {fileID: 123974546}
 541:         m_TargetAssemblyTypeName: GameManager, Assembly-CSharp
 542:         m_MethodName: Back
 543:         m_Mode: 1
 544:         m_Arguments:
 545:           m_ObjectArgument: {fileID: 0}
 546:           m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
 547:           m_IntArgument: 0
 548:           m_FloatArgument: 0
 549:           m_StringArgument: 
 550:           m_BoolArgument: 0
 551:         m_CallState: 2
 552: --- !u!114 &164198538
 553: MonoBehaviour:
 554:   m_ObjectHideFlags: 0
 555:   m_CorrespondingSourceObject: {fileID: 0}
 556:   m_PrefabInstance: {fileID: 0}
 557:   m_PrefabAsset: {fileID: 0}
 558:   m_GameObject: {fileID: 164198535}
 559:   m_Enabled: 1
 560:   m_EditorHideFlags: 0
 561:   m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
 562:   m_Name: 
 563:   m_EditorClassIdentifier: 
 564:   m_Material: {fileID: 0}
 565:   m_Color: {r: 1, g: 1, b: 1, a: 1}
 566:   m_RaycastTarget: 1
 567:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
 568:   m_Maskable: 1
 569:   m_OnCullStateChanged:
 570:     m_PersistentCalls:
 571:       m_Calls: []
 572:   m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
 573:   m_Type: 1
 574:   m_PreserveAspect: 0
 575:   m_FillCenter: 1
 576:   m_FillMethod: 4
 577:   m_FillAmount: 1
 578:   m_FillClockwise: 1
 579:   m_FillOrigin: 0
 580:   m_UseSpriteMesh: 0
 581:   m_PixelsPerUnitMultiplier: 1
 582: --- !u!222 &164198539
 583: CanvasRenderer:
 584:   m_ObjectHideFlags: 0
 585:   m_CorrespondingSourceObject: {fileID: 0}
 586:   m_PrefabInstance: {fileID: 0}
 587:   m_PrefabAsset: {fileID: 0}
 588:   m_GameObject: {fileID: 164198535}
 589:   m_CullTransparentMesh: 1
 590: --- !u!1 &218326793
 591: GameObject:
 592:   m_ObjectHideFlags: 0
 593:   m_CorrespondingSourceObject: {fileID: 0}
 594:   m_PrefabInstance: {fileID: 0}
 595:   m_PrefabAsset: {fileID: 0}
 596:   serializedVersion: 6
 597:   m_Component:
 598:   - component: {fileID: 218326794}
 599:   - component: {fileID: 218326796}
 600:   - component: {fileID: 218326795}
 601:   m_Layer: 5
 602:   m_Name: Text (TMP)
 603:   m_TagString: Untagged
 604:   m_Icon: {fileID: 0}
 605:   m_NavMeshLayer: 0
 606:   m_StaticEditorFlags: 0
 607:   m_IsActive: 1
 608: --- !u!224 &218326794
 609: RectTransform:
 610:   m_ObjectHideFlags: 0
 611:   m_CorrespondingSourceObject: {fileID: 0}
 612:   m_PrefabInstance: {fileID: 0}
 613:   m_PrefabAsset: {fileID: 0}
 614:   m_GameObject: {fileID: 218326793}
 615:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
 616:   m_LocalPosition: {x: 0, y: 0, z: 0}
 617:   m_LocalScale: {x: 1, y: 1, z: 1}
 618:   m_ConstrainProportionsScale: 0
 619:   m_Children: []
 620:   m_Father: {fileID: 729054714}
 621:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 622:   m_AnchorMin: {x: 0, y: 0}
 623:   m_AnchorMax: {x: 1, y: 1}
 624:   m_AnchoredPosition: {x: 0, y: 0}
 625:   m_SizeDelta: {x: 0, y: 0}
 626:   m_Pivot: {x: 0.5, y: 0.5}
 627: --- !u!114 &218326795
 628: MonoBehaviour:
 629:   m_ObjectHideFlags: 0
 630:   m_CorrespondingSourceObject: {fileID: 0}
 631:   m_PrefabInstance: {fileID: 0}
 632:   m_PrefabAsset: {fileID: 0}
 633:   m_GameObject: {fileID: 218326793}
 634:   m_Enabled: 1
 635:   m_EditorHideFlags: 0
 636:   m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
 637:   m_Name: 
 638:   m_EditorClassIdentifier: 
 639:   m_Material: {fileID: 0}
 640:   m_Color: {r: 1, g: 1, b: 1, a: 1}
 641:   m_RaycastTarget: 1
 642:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
 643:   m_Maskable: 1
 644:   m_OnCullStateChanged:
 645:     m_PersistentCalls:
 646:       m_Calls: []
 647:   m_text: Options
 648:   m_isRightToLeft: 0
 649:   m_fontAsset: {fileID: 11400000, guid: 125cb55b44b24c4393181402bc6200e6, type: 2}
 650:   m_sharedMaterial: {fileID: 2100000, guid: d75b8f41e959450c84ac6e967084d3e1, type: 2}
 651:   m_fontSharedMaterials: []
 652:   m_fontMaterial: {fileID: 0}
 653:   m_fontMaterials: []
 654:   m_fontColor32:
 655:     serializedVersion: 2
 656:     rgba: 4281216654
 657:   m_fontColor: {r: 0.5566038, g: 0.18115878, b: 0.18115878, a: 1}
 658:   m_enableVertexGradient: 0
 659:   m_colorMode: 3
 660:   m_fontColorGradient:
 661:     topLeft: {r: 1, g: 1, b: 1, a: 1}
 662:     topRight: {r: 1, g: 1, b: 1, a: 1}
 663:     bottomLeft: {r: 1, g: 1, b: 1, a: 1}
 664:     bottomRight: {r: 1, g: 1, b: 1, a: 1}
 665:   m_fontColorGradientPreset: {fileID: 0}
 666:   m_spriteAsset: {fileID: 0}
 667:   m_tintAllSprites: 0
 668:   m_StyleSheet: {fileID: 0}
 669:   m_TextStyleHashCode: -1183493901
 670:   m_overrideHtmlColors: 0
 671:   m_faceColor:
 672:     serializedVersion: 2
 673:     rgba: 4294967295
 674:   m_fontSize: 50
 675:   m_fontSizeBase: 50
 676:   m_fontWeight: 400
 677:   m_enableAutoSizing: 0
 678:   m_fontSizeMin: 0
 679:   m_fontSizeMax: 0
 680:   m_fontStyle: 0
 681:   m_HorizontalAlignment: 2
 682:   m_VerticalAlignment: 512
 683:   m_textAlignment: 65535
 684:   m_characterSpacing: 0
 685:   m_wordSpacing: 0
 686:   m_lineSpacing: 0
 687:   m_lineSpacingMax: 0
 688:   m_paragraphSpacing: 0
 689:   m_charWidthMaxAdj: 0
 690:   m_enableWordWrapping: 0
 691:   m_wordWrappingRatios: 0.4
 692:   m_overflowMode: 0
 693:   m_linkedTextComponent: {fileID: 0}
 694:   parentLinkedComponent: {fileID: 0}
 695:   m_enableKerning: 0
 696:   m_enableExtraPadding: 0
 697:   checkPaddingRequired: 0
 698:   m_isRichText: 1
 699:   m_parseCtrlCharacters: 1
 700:   m_isOrthographic: 1
 701:   m_isCullingEnabled: 0
 702:   m_horizontalMapping: 0
 703:   m_verticalMapping: 0
 704:   m_uvLineOffset: 0
 705:   m_geometrySortingOrder: 0
 706:   m_IsTextObjectScaleStatic: 0
 707:   m_VertexBufferAutoSizeReduction: 0
 708:   m_useMaxVisibleDescender: 1
 709:   m_pageToDisplay: 1
 710:   m_margin: {x: 0, y: 0, z: 0, w: 0}
 711:   m_isUsingLegacyAnimationComponent: 0
 712:   m_isVolumetricText: 0
 713:   m_hasFontAssetChanged: 0
 714:   m_baseMaterial: {fileID: 0}
 715:   m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
 716: --- !u!222 &218326796
 717: CanvasRenderer:
 718:   m_ObjectHideFlags: 0
 719:   m_CorrespondingSourceObject: {fileID: 0}
 720:   m_PrefabInstance: {fileID: 0}
 721:   m_PrefabAsset: {fileID: 0}
 722:   m_GameObject: {fileID: 218326793}
 723:   m_CullTransparentMesh: 1
 724: --- !u!1 &240184755
 725: GameObject:
 726:   m_ObjectHideFlags: 0
 727:   m_CorrespondingSourceObject: {fileID: 0}
 728:   m_PrefabInstance: {fileID: 0}
 729:   m_PrefabAsset: {fileID: 0}
 730:   serializedVersion: 6
 731:   m_Component:
 732:   - component: {fileID: 240184756}
 733:   - component: {fileID: 240184758}
 734:   - component: {fileID: 240184757}
 735:   m_Layer: 5
 736:   m_Name: Text (TMP)
 737:   m_TagString: Untagged
 738:   m_Icon: {fileID: 0}
 739:   m_NavMeshLayer: 0
 740:   m_StaticEditorFlags: 0
 741:   m_IsActive: 1
 742: --- !u!224 &240184756
 743: RectTransform:
 744:   m_ObjectHideFlags: 0
 745:   m_CorrespondingSourceObject: {fileID: 0}
 746:   m_PrefabInstance: {fileID: 0}
 747:   m_PrefabAsset: {fileID: 0}
 748:   m_GameObject: {fileID: 240184755}
 749:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
 750:   m_LocalPosition: {x: 0, y: 0, z: 0}
 751:   m_LocalScale: {x: 1, y: 1, z: 1}
 752:   m_ConstrainProportionsScale: 0
 753:   m_Children: []
 754:   m_Father: {fileID: 164198536}
 755:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 756:   m_AnchorMin: {x: 0, y: 0}
 757:   m_AnchorMax: {x: 1, y: 1}
 758:   m_AnchoredPosition: {x: 0, y: 0}
 759:   m_SizeDelta: {x: 0, y: 0}
 760:   m_Pivot: {x: 0.5, y: 0.5}
 761: --- !u!114 &240184757
 762: MonoBehaviour:
 763:   m_ObjectHideFlags: 0
 764:   m_CorrespondingSourceObject: {fileID: 0}
 765:   m_PrefabInstance: {fileID: 0}
 766:   m_PrefabAsset: {fileID: 0}
 767:   m_GameObject: {fileID: 240184755}
 768:   m_Enabled: 1
 769:   m_EditorHideFlags: 0
 770:   m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
 771:   m_Name: 
 772:   m_EditorClassIdentifier: 
 773:   m_Material: {fileID: 0}
 774:   m_Color: {r: 1, g: 1, b: 1, a: 1}
 775:   m_RaycastTarget: 1
 776:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
 777:   m_Maskable: 1
 778:   m_OnCullStateChanged:
 779:     m_PersistentCalls:
 780:       m_Calls: []
 781:   m_text: Volver
 782:   m_isRightToLeft: 0
 783:   m_fontAsset: {fileID: 11400000, guid: 125cb55b44b24c4393181402bc6200e6, type: 2}
 784:   m_sharedMaterial: {fileID: 2100000, guid: d75b8f41e959450c84ac6e967084d3e1, type: 2}
 785:   m_fontSharedMaterials: []
 786:   m_fontMaterial: {fileID: 0}
 787:   m_fontMaterials: []
 788:   m_fontColor32:
 789:     serializedVersion: 2
 790:     rgba: 4281216654
 791:   m_fontColor: {r: 0.5566038, g: 0.18115878, b: 0.18115878, a: 1}
 792:   m_enableVertexGradient: 0
 793:   m_colorMode: 3
 794:   m_fontColorGradient:
 795:     topLeft: {r: 1, g: 1, b: 1, a: 1}
 796:     topRight: {r: 1, g: 1, b: 1, a: 1}
 797:     bottomLeft: {r: 1, g: 1, b: 1, a: 1}
 798:     bottomRight: {r: 1, g: 1, b: 1, a: 1}
 799:   m_fontColorGradientPreset: {fileID: 0}
 800:   m_spriteAsset: {fileID: 0}
 801:   m_tintAllSprites: 0
 802:   m_StyleSheet: {fileID: 0}
 803:   m_TextStyleHashCode: -1183493901
 804:   m_overrideHtmlColors: 0
 805:   m_faceColor:
 806:     serializedVersion: 2
 807:     rgba: 4294967295
 808:   m_fontSize: 40
 809:   m_fontSizeBase: 40
 810:   m_fontWeight: 400
 811:   m_enableAutoSizing: 0
 812:   m_fontSizeMin: 0
 813:   m_fontSizeMax: 0
 814:   m_fontStyle: 0
 815:   m_HorizontalAlignment: 2
 816:   m_VerticalAlignment: 512
 817:   m_textAlignment: 65535
 818:   m_characterSpacing: 0
 819:   m_wordSpacing: 0
 820:   m_lineSpacing: 0
 821:   m_lineSpacingMax: 0
 822:   m_paragraphSpacing: 0
 823:   m_charWidthMaxAdj: 0
 824:   m_enableWordWrapping: 0
 825:   m_wordWrappingRatios: 0.4
 826:   m_overflowMode: 0
 827:   m_linkedTextComponent: {fileID: 0}
 828:   parentLinkedComponent: {fileID: 0}
 829:   m_enableKerning: 0
 830:   m_enableExtraPadding: 0
 831:   checkPaddingRequired: 0
 832:   m_isRichText: 1
 833:   m_parseCtrlCharacters: 1
 834:   m_isOrthographic: 1
 835:   m_isCullingEnabled: 0
 836:   m_horizontalMapping: 0
 837:   m_verticalMapping: 0
 838:   m_uvLineOffset: 0
 839:   m_geometrySortingOrder: 0
 840:   m_IsTextObjectScaleStatic: 0
 841:   m_VertexBufferAutoSizeReduction: 0
 842:   m_useMaxVisibleDescender: 1
 843:   m_pageToDisplay: 1
 844:   m_margin: {x: 0, y: 0, z: 0, w: 0}
 845:   m_isUsingLegacyAnimationComponent: 0
 846:   m_isVolumetricText: 0
 847:   m_hasFontAssetChanged: 0
 848:   m_baseMaterial: {fileID: 0}
 849:   m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
 850: --- !u!222 &240184758
 851: CanvasRenderer:
 852:   m_ObjectHideFlags: 0
 853:   m_CorrespondingSourceObject: {fileID: 0}
 854:   m_PrefabInstance: {fileID: 0}
 855:   m_PrefabAsset: {fileID: 0}
 856:   m_GameObject: {fileID: 240184755}
 857:   m_CullTransparentMesh: 1
 858: --- !u!1 &479897090
 859: GameObject:
 860:   m_ObjectHideFlags: 0
 861:   m_CorrespondingSourceObject: {fileID: 0}
 862:   m_PrefabInstance: {fileID: 0}
 863:   m_PrefabAsset: {fileID: 0}
 864:   serializedVersion: 6
 865:   m_Component:
 866:   - component: {fileID: 479897091}
 867:   - component: {fileID: 479897092}
 868:   m_Layer: 5
 869:   m_Name: Slider
 870:   m_TagString: Untagged
 871:   m_Icon: {fileID: 0}
 872:   m_NavMeshLayer: 0
 873:   m_StaticEditorFlags: 0
 874:   m_IsActive: 1
 875: --- !u!224 &479897091
 876: RectTransform:
 877:   m_ObjectHideFlags: 0
 878:   m_CorrespondingSourceObject: {fileID: 0}
 879:   m_PrefabInstance: {fileID: 0}
 880:   m_PrefabAsset: {fileID: 0}
 881:   m_GameObject: {fileID: 479897090}
 882:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
 883:   m_LocalPosition: {x: 0, y: 0, z: 0}
 884:   m_LocalScale: {x: 1, y: 1, z: 1}
 885:   m_ConstrainProportionsScale: 0
 886:   m_Children:
 887:   - {fileID: 1421303959}
 888:   - {fileID: 1254730485}
 889:   - {fileID: 728527148}
 890:   m_Father: {fileID: 1518948672}
 891:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 892:   m_AnchorMin: {x: 0.5, y: 0.5}
 893:   m_AnchorMax: {x: 0.5, y: 0.5}
 894:   m_AnchoredPosition: {x: -173.4, y: 17.8}
 895:   m_SizeDelta: {x: 250, y: 20}
 896:   m_Pivot: {x: 0.5, y: 0.5}
 897: --- !u!114 &479897092
 898: MonoBehaviour:
 899:   m_ObjectHideFlags: 0
 900:   m_CorrespondingSourceObject: {fileID: 0}
 901:   m_PrefabInstance: {fileID: 0}
 902:   m_PrefabAsset: {fileID: 0}
 903:   m_GameObject: {fileID: 479897090}
 904:   m_Enabled: 1
 905:   m_EditorHideFlags: 0
 906:   m_Script: {fileID: 11500000, guid: 67db9e8f0e2ae9c40bc1e2b64352a6b4, type: 3}
 907:   m_Name: 
 908:   m_EditorClassIdentifier: 
 909:   m_Navigation:
 910:     m_Mode: 3
 911:     m_WrapAround: 0
 912:     m_SelectOnUp: {fileID: 0}
 913:     m_SelectOnDown: {fileID: 0}
 914:     m_SelectOnLeft: {fileID: 0}
 915:     m_SelectOnRight: {fileID: 0}
 916:   m_Transition: 1
 917:   m_Colors:
 918:     m_NormalColor: {r: 1, g: 1, b: 1, a: 1}
 919:     m_HighlightedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
 920:     m_PressedColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 1}
 921:     m_SelectedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
 922:     m_DisabledColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 0.5019608}
 923:     m_ColorMultiplier: 1
 924:     m_FadeDuration: 0.1
 925:   m_SpriteState:
 926:     m_HighlightedSprite: {fileID: 0}
 927:     m_PressedSprite: {fileID: 0}
 928:     m_SelectedSprite: {fileID: 0}
 929:     m_DisabledSprite: {fileID: 0}
 930:   m_AnimationTriggers:
 931:     m_NormalTrigger: Normal
 932:     m_HighlightedTrigger: Highlighted
 933:     m_PressedTrigger: Pressed
 934:     m_SelectedTrigger: Selected
 935:     m_DisabledTrigger: Disabled
 936:   m_Interactable: 1
 937:   m_TargetGraphic: {fileID: 2105303962}
 938:   m_FillRect: {fileID: 1524174883}
 939:   m_HandleRect: {fileID: 2105303961}
 940:   m_Direction: 0
 941:   m_MinValue: 0
 942:   m_MaxValue: 1
 943:   m_WholeNumbers: 0
 944:   m_Value: 0
 945:   m_OnValueChanged:
 946:     m_PersistentCalls:
 947:       m_Calls: []
 948: --- !u!1 &650266550
 949: GameObject:
 950:   m_ObjectHideFlags: 0
 951:   m_CorrespondingSourceObject: {fileID: 0}
 952:   m_PrefabInstance: {fileID: 0}
 953:   m_PrefabAsset: {fileID: 0}
 954:   serializedVersion: 6
 955:   m_Component:
 956:   - component: {fileID: 650266551}
 957:   - component: {fileID: 650266553}
 958:   - component: {fileID: 650266552}
 959:   m_Layer: 5
 960:   m_Name: Text (TMP)
 961:   m_TagString: Untagged
 962:   m_Icon: {fileID: 0}
 963:   m_NavMeshLayer: 0
 964:   m_StaticEditorFlags: 0
 965:   m_IsActive: 1
 966: --- !u!224 &650266551
 967: RectTransform:
 968:   m_ObjectHideFlags: 0
 969:   m_CorrespondingSourceObject: {fileID: 0}
 970:   m_PrefabInstance: {fileID: 0}
 971:   m_PrefabAsset: {fileID: 0}
 972:   m_GameObject: {fileID: 650266550}
 973:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
 974:   m_LocalPosition: {x: 0, y: 0, z: 0}
 975:   m_LocalScale: {x: 1, y: 1, z: 1}
 976:   m_ConstrainProportionsScale: 0
 977:   m_Children: []
 978:   m_Father: {fileID: 1686965930}
 979:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 980:   m_AnchorMin: {x: 0, y: 0}
 981:   m_AnchorMax: {x: 1, y: 1}
 982:   m_AnchoredPosition: {x: -180.5, y: 0}
 983:   m_SizeDelta: {x: 0, y: 0}
 984:   m_Pivot: {x: 0.5, y: 0.5}
 985: --- !u!114 &650266552
 986: MonoBehaviour:
 987:   m_ObjectHideFlags: 0
 988:   m_CorrespondingSourceObject: {fileID: 0}
 989:   m_PrefabInstance: {fileID: 0}
 990:   m_PrefabAsset: {fileID: 0}
 991:   m_GameObject: {fileID: 650266550}
 992:   m_Enabled: 1
 993:   m_EditorHideFlags: 0
 994:   m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
 995:   m_Name: 
 996:   m_EditorClassIdentifier: 
 997:   m_Material: {fileID: 0}
 998:   m_Color: {r: 1, g: 1, b: 1, a: 1}
 999:   m_RaycastTarget: 1
1000:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
1001:   m_Maskable: 1
1002:   m_OnCullStateChanged:
1003:     m_PersistentCalls:
1004:       m_Calls: []
1005:   m_text: Pantalla Completa
1006:   m_isRightToLeft: 0
1007:   m_fontAsset: {fileID: 11400000, guid: 125cb55b44b24c4393181402bc6200e6, type: 2}
1008:   m_sharedMaterial: {fileID: 2100000, guid: d75b8f41e959450c84ac6e967084d3e1, type: 2}
1009:   m_fontSharedMaterials: []
1010:   m_fontMaterial: {fileID: 0}
1011:   m_fontMaterials: []
1012:   m_fontColor32:
1013:     serializedVersion: 2
1014:     rgba: 4281216654
1015:   m_fontColor: {r: 0.5566038, g: 0.18115878, b: 0.18115878, a: 1}
1016:   m_enableVertexGradient: 0
1017:   m_colorMode: 3
1018:   m_fontColorGradient:
1019:     topLeft: {r: 1, g: 1, b: 1, a: 1}
1020:     topRight: {r: 1, g: 1, b: 1, a: 1}
1021:     bottomLeft: {r: 1, g: 1, b: 1, a: 1}
1022:     bottomRight: {r: 1, g: 1, b: 1, a: 1}
1023:   m_fontColorGradientPreset: {fileID: 0}
1024:   m_spriteAsset: {fileID: 0}
1025:   m_tintAllSprites: 0
1026:   m_StyleSheet: {fileID: 0}
1027:   m_TextStyleHashCode: -1183493901
1028:   m_overrideHtmlColors: 0
1029:   m_faceColor:
1030:     serializedVersion: 2
1031:     rgba: 4294967295
1032:   m_fontSize: 40
1033:   m_fontSizeBase: 40
1034:   m_fontWeight: 400
1035:   m_enableAutoSizing: 0
1036:   m_fontSizeMin: 0
1037:   m_fontSizeMax: 0
1038:   m_fontStyle: 0
1039:   m_HorizontalAlignment: 2
1040:   m_VerticalAlignment: 512
1041:   m_textAlignment: 65535
1042:   m_characterSpacing: 0
1043:   m_wordSpacing: 0
1044:   m_lineSpacing: 0
1045:   m_lineSpacingMax: 0
1046:   m_paragraphSpacing: 0
1047:   m_charWidthMaxAdj: 0
1048:   m_enableWordWrapping: 0
1049:   m_wordWrappingRatios: 0.4
1050:   m_overflowMode: 0
1051:   m_linkedTextComponent: {fileID: 0}
1052:   parentLinkedComponent: {fileID: 0}
1053:   m_enableKerning: 0
1054:   m_enableExtraPadding: 0
1055:   checkPaddingRequired: 0
1056:   m_isRichText: 1
1057:   m_parseCtrlCharacters: 1
1058:   m_isOrthographic: 1
1059:   m_isCullingEnabled: 0
1060:   m_horizontalMapping: 0
1061:   m_verticalMapping: 0
1062:   m_uvLineOffset: 0
1063:   m_geometrySortingOrder: 0
1064:   m_IsTextObjectScaleStatic: 0
1065:   m_VertexBufferAutoSizeReduction: 0
1066:   m_useMaxVisibleDescender: 1
1067:   m_pageToDisplay: 1
1068:   m_margin: {x: 0, y: 0, z: 0, w: 0}
1069:   m_isUsingLegacyAnimationComponent: 0
1070:   m_isVolumetricText: 0
1071:   m_hasFontAssetChanged: 0
1072:   m_baseMaterial: {fileID: 0}
1073:   m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
1074: --- !u!222 &650266553
1075: CanvasRenderer:
1076:   m_ObjectHideFlags: 0
1077:   m_CorrespondingSourceObject: {fileID: 0}
1078:   m_PrefabInstance: {fileID: 0}
1079:   m_PrefabAsset: {fileID: 0}
1080:   m_GameObject: {fileID: 650266550}
1081:   m_CullTransparentMesh: 1
1082: --- !u!1 &713136666
1083: GameObject:
1084:   m_ObjectHideFlags: 0
1085:   m_CorrespondingSourceObject: {fileID: 0}
1086:   m_PrefabInstance: {fileID: 0}
1087:   m_PrefabAsset: {fileID: 0}
1088:   serializedVersion: 6
1089:   m_Component:
1090:   - component: {fileID: 713136667}
1091:   - component: {fileID: 713136669}
1092:   - component: {fileID: 713136668}
1093:   m_Layer: 5
1094:   m_Name: RawImage
1095:   m_TagString: Untagged
1096:   m_Icon: {fileID: 0}
1097:   m_NavMeshLayer: 0
1098:   m_StaticEditorFlags: 0
1099:   m_IsActive: 1
1100: --- !u!224 &713136667
1101: RectTransform:
1102:   m_ObjectHideFlags: 0
1103:   m_CorrespondingSourceObject: {fileID: 0}
1104:   m_PrefabInstance: {fileID: 0}
1105:   m_PrefabAsset: {fileID: 0}
1106:   m_GameObject: {fileID: 713136666}
1107:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
1108:   m_LocalPosition: {x: 0, y: 0, z: 0}
1109:   m_LocalScale: {x: 1, y: 1, z: 1}
1110:   m_ConstrainProportionsScale: 0
1111:   m_Children: []
1112:   m_Father: {fileID: 1518948672}
1113:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
1114:   m_AnchorMin: {x: 0.5, y: 0.5}
1115:   m_AnchorMax: {x: 0.5, y: 0.5}
1116:   m_AnchoredPosition: {x: 40.034714, y: 46.45597}
1117:   m_SizeDelta: {x: 1118.8356, y: 619.7322}
1118:   m_Pivot: {x: 0.5, y: 0.5}
1119: --- !u!114 &713136668
1120: MonoBehaviour:
1121:   m_ObjectHideFlags: 0
1122:   m_CorrespondingSourceObject: {fileID: 0}
1123:   m_PrefabInstance: {fileID: 0}
1124:   m_PrefabAsset: {fileID: 0}
1125:   m_GameObject: {fileID: 713136666}
1126:   m_Enabled: 1
1127:   m_EditorHideFlags: 0
1128:   m_Script: {fileID: 11500000, guid: 1344c3c82d62a2a41a3576d8abb8e3ea, type: 3}
1129:   m_Name: 
1130:   m_EditorClassIdentifier: 
1131:   m_Material: {fileID: 0}
1132:   m_Color: {r: 1, g: 1, b: 1, a: 1}
1133:   m_RaycastTarget: 1
1134:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
1135:   m_Maskable: 1
1136:   m_OnCullStateChanged:
1137:     m_PersistentCalls:
1138:       m_Calls: []
1139:   m_Texture: {fileID: 2800000, guid: c50cf53deda4a444791ad8c26d6f135b, type: 3}
1140:   m_UVRect:
1141:     serializedVersion: 2
1142:     x: 0
1143:     y: 0
1144:     width: 1
1145:     height: 1
1146: --- !u!222 &713136669
1147: CanvasRenderer:
1148:   m_ObjectHideFlags: 0
1149:   m_CorrespondingSourceObject: {fileID: 0}
1150:   m_PrefabInstance: {fileID: 0}
1151:   m_PrefabAsset: {fileID: 0}
1152:   m_GameObject: {fileID: 713136666}
1153:   m_CullTransparentMesh: 1
1154: --- !u!1 &728527147
1155: GameObject:
1156:   m_ObjectHideFlags: 0
1157:   m_CorrespondingSourceObject: {fileID: 0}
1158:   m_PrefabInstance: {fileID: 0}
1159:   m_PrefabAsset: {fileID: 0}
1160:   serializedVersion: 6
1161:   m_Component:
1162:   - component: {fileID: 728527148}
1163:   m_Layer: 5
1164:   m_Name: Handle Slide Area
1165:   m_TagString: Untagged
1166:   m_Icon: {fileID: 0}
1167:   m_NavMeshLayer: 0
1168:   m_StaticEditorFlags: 0
1169:   m_IsActive: 1
1170: --- !u!224 &728527148
1171: RectTransform:
1172:   m_ObjectHideFlags: 0
1173:   m_CorrespondingSourceObject: {fileID: 0}
1174:   m_PrefabInstance: {fileID: 0}
1175:   m_PrefabAsset: {fileID: 0}
1176:   m_GameObject: {fileID: 728527147}
1177:   m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
1178:   m_LocalPosition: {x: 0, y: 0, z: 0}
1179:   m_LocalScale: {x: 1, y: 1, z: 1}
1180:   m_ConstrainProportionsScale: 0
1181:   m_Children:
1182:   - {fileID: 2105303961}
1183:   m_Father: {fileID: 479897091}
1184:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
1185:   m_AnchorMin: {x: 0, y: 0}
1186:   m_AnchorMax: {x: 1, y: 1}
1187:   m_AnchoredPosition: {x: 0, y: 0}
1188:   m_SizeDelta: {x: -20, y: 0}
1189:   m_Pivot: {x: 0.5, y: 0.5}
1190: --- !u!1 &729054713
1191: GameObject:
1192:   m_ObjectHideFlags: 0
1193:   m_CorrespondingSourceObject: {fileID: 0}
1194:   m_PrefabInstance: {fileID: 0}
1195:   m_PrefabAsset: {fileID: 0}
1196:   serializedVersion: 6
1197:   m_Component:
1198:   - component: {fileID: 729054714}
1199:   - component: {fileID: 729054717}
1200:   - component: {fileID: 729054716}
1201:   - component: {fileID: 729054715}
1202:   m_Layer: 5
1203:   m_Name: options
1204:   m_TagString: Untagged
1205:   m_Icon: {fileID: 0}
1206:   m_NavMeshLayer: 0
1207:   m_StaticEditorFlags: 0
1208:   m_IsActive: 1
1209: --- !u!224 &729054714
1210: RectTransform:
1211:   m_ObjectHideFlags: 0
1212:   m_CorrespondingSourceObject: {fileID: 0}
1213:   m_PrefabInstance: {fileID: 0}
1214:   m_PrefabAsset: {fileID: 0}
1215:   m_GameObject: {fileID: 729054713}
1216:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
1217:   m_LocalPosition: {x: 0, y: 0, z: 0}
1218:   m_LocalScale: {x: 1, y: 1, z: 1}
1219:   m_ConstrainProportionsScale: 0
1220:   m_Children:
1221:   - {fileID: 218326794}
1222:   m_Father: {fileID: 1662025907}
1223:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
1224:   m_AnchorMin: {x: 0.5, y: 0.5}
1225:   m_AnchorMax: {x: 0.5, y: 0.5}
1226:   m_AnchoredPosition: {x: 0, y: -39.1}
1227:   m_SizeDelta: {x: 169.1472, y: 69.4794}
1228:   m_Pivot: {x: 0.5, y: 0.5}
1229: --- !u!114 &729054715
1230: MonoBehaviour:
1231:   m_ObjectHideFlags: 0
1232:   m_CorrespondingSourceObject: {fileID: 0}
1233:   m_PrefabInstance: {fileID: 0}
1234:   m_PrefabAsset: {fileID: 0}
1235:   m_GameObject: {fileID: 729054713}
1236:   m_Enabled: 1
1237:   m_EditorHideFlags: 0
1238:   m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
1239:   m_Name: 
1240:   m_EditorClassIdentifier: 
1241:   m_Navigation:
1242:     m_Mode: 3
1243:     m_WrapAround: 0
1244:     m_SelectOnUp: {fileID: 0}
1245:     m_SelectOnDown: {fileID: 0}
1246:     m_SelectOnLeft: {fileID: 0}
1247:     m_SelectOnRight: {fileID: 0}
1248:   m_Transition: 1
1249:   m_Colors:
1250:     m_NormalColor: {r: 0.7075472, g: 0, b: 0, a: 0.14901961}
1251:     m_HighlightedColor: {r: 0.754717, g: 0.3025988, b: 0.3025988, a: 0.34117648}
1252:     m_PressedColor: {r: 0.7169812, g: 0.26041296, b: 0.26041296, a: 0.43137255}
1253:     m_SelectedColor: {r: 0.745283, g: 0.1511659, b: 0.1511659, a: 0.70980394}
1254:     m_DisabledColor: {r: 1, g: 0, b: 0, a: 1}
1255:     m_ColorMultiplier: 1
1256:     m_FadeDuration: 0.1
1257:   m_SpriteState:
1258:     m_HighlightedSprite: {fileID: 0}
1259:     m_PressedSprite: {fileID: 0}
1260:     m_SelectedSprite: {fileID: 0}
1261:     m_DisabledSprite: {fileID: 0}
1262:   m_AnimationTriggers:
1263:     m_NormalTrigger: Normal
1264:     m_HighlightedTrigger: Highlighted
1265:     m_PressedTrigger: Pressed
1266:     m_SelectedTrigger: Selected
1267:     m_DisabledTrigger: Disabled
1268:   m_Interactable: 1
1269:   m_TargetGraphic: {fileID: 729054716}
1270:   m_OnClick:
1271:     m_PersistentCalls:
1272:       m_Calls:
1273:       - m_Target: {fileID: 123974546}
1274:         m_TargetAssemblyTypeName: GameManager, Assembly-CSharp
1275:         m_MethodName: Options
1276:         m_Mode: 1
1277:         m_Arguments:
1278:           m_ObjectArgument: {fileID: 0}
1279:           m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
1280:           m_IntArgument: 0
1281:           m_FloatArgument: 0
1282:           m_StringArgument: 
1283:           m_BoolArgument: 0
1284:         m_CallState: 2
1285: --- !u!114 &729054716
1286: MonoBehaviour:
1287:   m_ObjectHideFlags: 0
1288:   m_CorrespondingSourceObject: {fileID: 0}
1289:   m_PrefabInstance: {fileID: 0}
1290:   m_PrefabAsset: {fileID: 0}
1291:   m_GameObject: {fileID: 729054713}
1292:   m_Enabled: 1
1293:   m_EditorHideFlags: 0
1294:   m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
1295:   m_Name: 
1296:   m_EditorClassIdentifier: 
1297:   m_Material: {fileID: 0}
1298:   m_Color: {r: 1, g: 1, b: 1, a: 1}
1299:   m_RaycastTarget: 1
1300:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
1301:   m_Maskable: 1
1302:   m_OnCullStateChanged:
1303:     m_PersistentCalls:
1304:       m_Calls: []
1305:   m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
1306:   m_Type: 1
1307:   m_PreserveAspect: 0
1308:   m_FillCenter: 1
1309:   m_FillMethod: 4
1310:   m_FillAmount: 1
1311:   m_FillClockwise: 1
1312:   m_FillOrigin: 0
1313:   m_UseSpriteMesh: 0
1314:   m_PixelsPerUnitMultiplier: 1
1315: --- !u!222 &729054717
1316: CanvasRenderer:
1317:   m_ObjectHideFlags: 0
1318:   m_CorrespondingSourceObject: {fileID: 0}
1319:   m_PrefabInstance: {fileID: 0}
1320:   m_PrefabAsset: {fileID: 0}
1321:   m_GameObject: {fileID: 729054713}
1322:   m_CullTransparentMesh: 1
1323: --- !u!1 &796269214
1324: GameObject:
1325:   m_ObjectHideFlags: 0
1326:   m_CorrespondingSourceObject: {fileID: 0}
1327:   m_PrefabInstance: {fileID: 0}
1328:   m_PrefabAsset: {fileID: 0}
1329:   serializedVersion: 6
1330:   m_Component:
1331:   - component: {fileID: 796269215}
1332:   - component: {fileID: 796269218}
1333:   - component: {fileID: 796269217}
1334:   - component: {fileID: 796269216}
1335:   m_Layer: 5
1336:   m_Name: Volumen
1337:   m_TagString: Untagged
1338:   m_Icon: {fileID: 0}
1339:   m_NavMeshLayer: 0
1340:   m_StaticEditorFlags: 0
1341:   m_IsActive: 1
1342: --- !u!224 &796269215
1343: RectTransform:
1344:   m_ObjectHideFlags: 0
1345:   m_CorrespondingSourceObject: {fileID: 0}
1346:   m_PrefabInstance: {fileID: 0}
1347:   m_PrefabAsset: {fileID: 0}
1348:   m_GameObject: {fileID: 796269214}
1349:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
1350:   m_LocalPosition: {x: 0, y: 0, z: 0}
1351:   m_LocalScale: {x: 1, y: 1, z: 1}
1352:   m_ConstrainProportionsScale: 0
1353:   m_Children:
1354:   - {fileID: 1721047801}
1355:   m_Father: {fileID: 1518948672}
1356:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
1357:   m_AnchorMin: {x: 0.5, y: 0.5}
1358:   m_AnchorMax: {x: 0.5, y: 0.5}
1359:   m_AnchoredPosition: {x: -176.9, y: 17.9}
1360:   m_SizeDelta: {x: 274.1145, y: 41.8655}
1361:   m_Pivot: {x: 0.5, y: 0.5}
1362: --- !u!114 &796269216
1363: MonoBehaviour:
1364:   m_ObjectHideFlags: 0
1365:   m_CorrespondingSourceObject: {fileID: 0}
1366:   m_PrefabInstance: {fileID: 0}
1367:   m_PrefabAsset: {fileID: 0}
1368:   m_GameObject: {fileID: 796269214}
1369:   m_Enabled: 1
1370:   m_EditorHideFlags: 0
1371:   m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
1372:   m_Name: 
1373:   m_EditorClassIdentifier: 
1374:   m_Navigation:
1375:     m_Mode: 3
1376:     m_WrapAround: 0
1377:     m_SelectOnUp: {fileID: 0}
1378:     m_SelectOnDown: {fileID: 0}
1379:     m_SelectOnLeft: {fileID: 0}
1380:     m_SelectOnRight: {fileID: 0}
1381:   m_Transition: 1
1382:   m_Colors:
1383:     m_NormalColor: {r: 0.7075472, g: 0, b: 0, a: 0.14901961}
1384:     m_HighlightedColor: {r: 0.754717, g: 0.3025988, b: 0.3025988, a: 0.34117648}
1385:     m_PressedColor: {r: 0.7169812, g: 0.26041296, b: 0.26041296, a: 0.43137255}
1386:     m_SelectedColor: {r: 0.745283, g: 0.1511659, b: 0.1511659, a: 0.70980394}
1387:     m_DisabledColor: {r: 1, g: 0, b: 0, a: 1}
1388:     m_ColorMultiplier: 1
1389:     m_FadeDuration: 0.1
1390:   m_SpriteState:
1391:     m_HighlightedSprite: {fileID: 0}
1392:     m_PressedSprite: {fileID: 0}
1393:     m_SelectedSprite: {fileID: 0}
1394:     m_DisabledSprite: {fileID: 0}
1395:   m_AnimationTriggers:
1396:     m_NormalTrigger: Normal
1397:     m_HighlightedTrigger: Highlighted
1398:     m_PressedTrigger: Pressed
1399:     m_SelectedTrigger: Selected
1400:     m_DisabledTrigger: Disabled
1401:   m_Interactable: 1
1402:   m_TargetGraphic: {fileID: 796269217}
1403:   m_OnClick:
1404:     m_PersistentCalls:
1405:       m_Calls: []
1406: --- !u!114 &796269217
1407: MonoBehaviour:
1408:   m_ObjectHideFlags: 0
1409:   m_CorrespondingSourceObject: {fileID: 0}
1410:   m_PrefabInstance: {fileID: 0}
1411:   m_PrefabAsset: {fileID: 0}
1412:   m_GameObject: {fileID: 796269214}
1413:   m_Enabled: 1
1414:   m_EditorHideFlags: 0
1415:   m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
1416:   m_Name: 
1417:   m_EditorClassIdentifier: 
1418:   m_Material: {fileID: 0}
1419:   m_Color: {r: 1, g: 1, b: 1, a: 1}
1420:   m_RaycastTarget: 1
1421:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
1422:   m_Maskable: 1
1423:   m_OnCullStateChanged:
1424:     m_PersistentCalls:
1425:       m_Calls: []
1426:   m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
1427:   m_Type: 1
1428:   m_PreserveAspect: 0
1429:   m_FillCenter: 1
1430:   m_FillMethod: 4
1431:   m_FillAmount: 1
1432:   m_FillClockwise: 1
1433:   m_FillOrigin: 0
1434:   m_UseSpriteMesh: 0
1435:   m_PixelsPerUnitMultiplier: 1
1436: --- !u!222 &796269218
1437: CanvasRenderer:
1438:   m_ObjectHideFlags: 0
1439:   m_CorrespondingSourceObject: {fileID: 0}
1440:   m_PrefabInstance: {fileID: 0}
1441:   m_PrefabAsset: {fileID: 0}
1442:   m_GameObject: {fileID: 796269214}
1443:   m_CullTransparentMesh: 1
1444: --- !u!1 &893179710
1445: GameObject:
1446:   m_ObjectHideFlags: 0
1447:   m_CorrespondingSourceObject: {fileID: 0}
1448:   m_PrefabInstance: {fileID: 0}
1449:   m_PrefabAsset: {fileID: 0}
1450:   serializedVersion: 6
1451:   m_Component:
1452:   - component: {fileID: 893179711}
1453:   - component: {fileID: 893179713}
1454:   - component: {fileID: 893179712}
1455:   m_Layer: 5
1456:   m_Name: Text (TMP)
1457:   m_TagString: Untagged
1458:   m_Icon: {fileID: 0}
1459:   m_NavMeshLayer: 0
1460:   m_StaticEditorFlags: 0
1461:   m_IsActive: 1
1462: --- !u!224 &893179711
1463: RectTransform:
1464:   m_ObjectHideFlags: 0
1465:   m_CorrespondingSourceObject: {fileID: 0}
1466:   m_PrefabInstance: {fileID: 0}
1467:   m_PrefabAsset: {fileID: 0}
1468:   m_GameObject: {fileID: 893179710}
1469:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
1470:   m_LocalPosition: {x: 0, y: 0, z: 0}
1471:   m_LocalScale: {x: 1, y: 1, z: 1}
1472:   m_ConstrainProportionsScale: 0
1473:   m_Children: []
1474:   m_Father: {fileID: 33020377}
1475:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
1476:   m_AnchorMin: {x: 0, y: 0}
1477:   m_AnchorMax: {x: 1, y: 1}
1478:   m_AnchoredPosition: {x: 0, y: 0}
1479:   m_SizeDelta: {x: 0, y: 0}
1480:   m_Pivot: {x: 0.5, y: 0.5}
1481: --- !u!114 &893179712
1482: MonoBehaviour:
1483:   m_ObjectHideFlags: 0
1484:   m_CorrespondingSourceObject: {fileID: 0}
1485:   m_PrefabInstance: {fileID: 0}
1486:   m_PrefabAsset: {fileID: 0}
1487:   m_GameObject: {fileID: 893179710}
1488:   m_Enabled: 1
1489:   m_EditorHideFlags: 0
1490:   m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
1491:   m_Name: 
1492:   m_EditorClassIdentifier: 
1493:   m_Material: {fileID: 0}
1494:   m_Color: {r: 1, g: 1, b: 1, a: 1}
1495:   m_RaycastTarget: 1
1496:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
1497:   m_Maskable: 1
1498:   m_OnCullStateChanged:
1499:     m_PersistentCalls:
1500:       m_Calls: []
1501:   m_text: Quit
1502:   m_isRightToLeft: 0
1503:   m_fontAsset: {fileID: 11400000, guid: 125cb55b44b24c4393181402bc6200e6, type: 2}
1504:   m_sharedMaterial: {fileID: 2100000, guid: d75b8f41e959450c84ac6e967084d3e1, type: 2}
1505:   m_fontSharedMaterials: []
1506:   m_fontMaterial: {fileID: 0}
1507:   m_fontMaterials: []
1508:   m_fontColor32:
1509:     serializedVersion: 2
1510:     rgba: 4281216654
1511:   m_fontColor: {r: 0.5566038, g: 0.18115878, b: 0.18115878, a: 1}
1512:   m_enableVertexGradient: 0
1513:   m_colorMode: 3
1514:   m_fontColorGradient:
1515:     topLeft: {r: 1, g: 1, b: 1, a: 1}
1516:     topRight: {r: 1, g: 1, b: 1, a: 1}
1517:     bottomLeft: {r: 1, g: 1, b: 1, a: 1}
1518:     bottomRight: {r: 1, g: 1, b: 1, a: 1}
1519:   m_fontColorGradientPreset: {fileID: 0}
1520:   m_spriteAsset: {fileID: 0}
1521:   m_tintAllSprites: 0
1522:   m_StyleSheet: {fileID: 0}
1523:   m_TextStyleHashCode: -1183493901
1524:   m_overrideHtmlColors: 0
1525:   m_faceColor:
1526:     serializedVersion: 2
1527:     rgba: 4294967295
1528:   m_fontSize: 50
1529:   m_fontSizeBase: 50
1530:   m_fontWeight: 400
1531:   m_enableAutoSizing: 0
1532:   m_fontSizeMin: 0
1533:   m_fontSizeMax: 0
1534:   m_fontStyle: 0
1535:   m_HorizontalAlignment: 2
1536:   m_VerticalAlignment: 512
1537:   m_textAlignment: 65535
1538:   m_characterSpacing: 0
1539:   m_wordSpacing: 0
1540:   m_lineSpacing: 0
1541:   m_lineSpacingMax: 0
1542:   m_paragraphSpacing: 0
1543:   m_charWidthMaxAdj: 0
1544:   m_enableWordWrapping: 0
1545:   m_wordWrappingRatios: 0.4
1546:   m_overflowMode: 0
1547:   m_linkedTextComponent: {fileID: 0}
1548:   parentLinkedComponent: {fileID: 0}
1549:   m_enableKerning: 0
1550:   m_enableExtraPadding: 0
1551:   checkPaddingRequired: 0
1552:   m_isRichText: 1
1553:   m_parseCtrlCharacters: 1
1554:   m_isOrthographic: 1
1555:   m_isCullingEnabled: 0
1556:   m_horizontalMapping: 0
1557:   m_verticalMapping: 0
1558:   m_uvLineOffset: 0
1559:   m_geometrySortingOrder: 0
1560:   m_IsTextObjectScaleStatic: 0
1561:   m_VertexBufferAutoSizeReduction: 0
1562:   m_useMaxVisibleDescender: 1
1563:   m_pageToDisplay: 1
1564:   m_margin: {x: 0, y: 0, z: 0, w: 0}
1565:   m_isUsingLegacyAnimationComponent: 0
1566:   m_isVolumetricText: 0
1567:   m_hasFontAssetChanged: 0
1568:   m_baseMaterial: {fileID: 0}
1569:   m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
1570: --- !u!222 &893179713
1571: CanvasRenderer:
1572:   m_ObjectHideFlags: 0
1573:   m_CorrespondingSourceObject: {fileID: 0}
1574:   m_PrefabInstance: {fileID: 0}
1575:   m_PrefabAsset: {fileID: 0}
1576:   m_GameObject: {fileID: 893179710}
1577:   m_CullTransparentMesh: 1
1578: --- !u!1 &1201988939
1579: GameObject:
1580:   m_ObjectHideFlags: 0
1581:   m_CorrespondingSourceObject: {fileID: 0}
1582:   m_PrefabInstance: {fileID: 0}
1583:   m_PrefabAsset: {fileID: 0}
1584:   serializedVersion: 6
1585:   m_Component:
1586:   - component: {fileID: 1201988940}
1587:   - component: {fileID: 1201988943}
1588:   - component: {fileID: 1201988942}
1589:   - component: {fileID: 1201988941}
1590:   m_Layer: 5
1591:   m_Name: Play
1592:   m_TagString: Untagged
1593:   m_Icon: {fileID: 0}
1594:   m_NavMeshLayer: 0
1595:   m_StaticEditorFlags: 0
1596:   m_IsActive: 1
1597: --- !u!224 &1201988940
1598: RectTransform:
1599:   m_ObjectHideFlags: 0
1600:   m_CorrespondingSourceObject: {fileID: 0}
1601:   m_PrefabInstance: {fileID: 0}
1602:   m_PrefabAsset: {fileID: 0}
1603:   m_GameObject: {fileID: 1201988939}
1604:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
1605:   m_LocalPosition: {x: 0, y: 0, z: 0}
1606:   m_LocalScale: {x: 1, y: 1, z: 1}
1607:   m_ConstrainProportionsScale: 0
1608:   m_Children:
1609:   - {fileID: 2015550095}
1610:   m_Father: {fileID: 1662025907}
1611:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
1612:   m_AnchorMin: {x: 0.5, y: 0.5}
1613:   m_AnchorMax: {x: 0.5, y: 0.5}
1614:   m_AnchoredPosition: {x: 0, y: 67.2}
1615:   m_SizeDelta: {x: 169.1472, y: 69.4794}
1616:   m_Pivot: {x: 0.5, y: 0.5}
1617: --- !u!114 &1201988941
1618: MonoBehaviour:
1619:   m_ObjectHideFlags: 0
1620:   m_CorrespondingSourceObject: {fileID: 0}
1621:   m_PrefabInstance: {fileID: 0}
1622:   m_PrefabAsset: {fileID: 0}
1623:   m_GameObject: {fileID: 1201988939}
1624:   m_Enabled: 1
1625:   m_EditorHideFlags: 0
1626:   m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
1627:   m_Name: 
1628:   m_EditorClassIdentifier: 
1629:   m_Navigation:
1630:     m_Mode: 3
1631:     m_WrapAround: 0
1632:     m_SelectOnUp: {fileID: 0}
1633:     m_SelectOnDown: {fileID: 0}
1634:     m_SelectOnLeft: {fileID: 0}
1635:     m_SelectOnRight: {fileID: 0}
1636:   m_Transition: 1
1637:   m_Colors:
1638:     m_NormalColor: {r: 0.7075472, g: 0, b: 0, a: 0.14901961}
1639:     m_HighlightedColor: {r: 0.754717, g: 0.3025988, b: 0.3025988, a: 0.34117648}
1640:     m_PressedColor: {r: 0.7169812, g: 0.26041296, b: 0.26041296, a: 0.43137255}
1641:     m_SelectedColor: {r: 0.745283, g: 0.1511659, b: 0.1511659, a: 0.70980394}
1642:     m_DisabledColor: {r: 1, g: 0, b: 0, a: 1}
1643:     m_ColorMultiplier: 1
1644:     m_FadeDuration: 0.1
1645:   m_SpriteState:
1646:     m_HighlightedSprite: {fileID: 0}
1647:     m_PressedSprite: {fileID: 0}
1648:     m_SelectedSprite: {fileID: 0}
1649:     m_DisabledSprite: {fileID: 0}
1650:   m_AnimationTriggers:
1651:     m_NormalTrigger: Normal
1652:     m_HighlightedTrigger: Highlighted
1653:     m_PressedTrigger: Pressed
1654:     m_SelectedTrigger: Selected
1655:     m_DisabledTrigger: Disabled
1656:   m_Interactable: 1
1657:   m_TargetGraphic: {fileID: 1201988942}
1658:   m_OnClick:
1659:     m_PersistentCalls:
1660:       m_Calls:
1661:       - m_Target: {fileID: 123974546}
1662:         m_TargetAssemblyTypeName: GameManager, Assembly-CSharp
1663:         m_MethodName: PlayGame
1664:         m_Mode: 1
1665:         m_Arguments:
1666:           m_ObjectArgument: {fileID: 0}
1667:           m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
1668:           m_IntArgument: 0
1669:           m_FloatArgument: 0
1670:           m_StringArgument: 
1671:           m_BoolArgument: 0
1672:         m_CallState: 2
1673: --- !u!114 &1201988942
1674: MonoBehaviour:
1675:   m_ObjectHideFlags: 0
1676:   m_CorrespondingSourceObject: {fileID: 0}
1677:   m_PrefabInstance: {fileID: 0}
1678:   m_PrefabAsset: {fileID: 0}
1679:   m_GameObject: {fileID: 1201988939}
1680:   m_Enabled: 1
1681:   m_EditorHideFlags: 0
1682:   m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
1683:   m_Name: 
1684:   m_EditorClassIdentifier: 
1685:   m_Material: {fileID: 0}
1686:   m_Color: {r: 1, g: 1, b: 1, a: 1}
1687:   m_RaycastTarget: 1
1688:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
1689:   m_Maskable: 1
1690:   m_OnCullStateChanged:
1691:     m_PersistentCalls:
1692:       m_Calls: []
1693:   m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
1694:   m_Type: 1
1695:   m_PreserveAspect: 0
1696:   m_FillCenter: 1
1697:   m_FillMethod: 4
1698:   m_FillAmount: 1
1699:   m_FillClockwise: 1
1700:   m_FillOrigin: 0
1701:   m_UseSpriteMesh: 0
1702:   m_PixelsPerUnitMultiplier: 1
1703: --- !u!222 &1201988943
1704: CanvasRenderer:
1705:   m_ObjectHideFlags: 0
1706:   m_CorrespondingSourceObject: {fileID: 0}
1707:   m_PrefabInstance: {fileID: 0}
1708:   m_PrefabAsset: {fileID: 0}
1709:   m_GameObject: {fileID: 1201988939}
1710:   m_CullTransparentMesh: 1
1711: --- !u!1 &1254730484
1712: GameObject:
1713:   m_ObjectHideFlags: 0
1714:   m_CorrespondingSourceObject: {fileID: 0}
1715:   m_PrefabInstance: {fileID: 0}
1716:   m_PrefabAsset: {fileID: 0}
1717:   serializedVersion: 6
1718:   m_Component:
1719:   - component: {fileID: 1254730485}
1720:   m_Layer: 5
1721:   m_Name: Fill Area
1722:   m_TagString: Untagged
1723:   m_Icon: {fileID: 0}
1724:   m_NavMeshLayer: 0
1725:   m_StaticEditorFlags: 0
1726:   m_IsActive: 1
1727: --- !u!224 &1254730485
1728: RectTransform:
1729:   m_ObjectHideFlags: 0
1730:   m_CorrespondingSourceObject: {fileID: 0}
1731:   m_PrefabInstance: {fileID: 0}
1732:   m_PrefabAsset: {fileID: 0}
1733:   m_GameObject: {fileID: 1254730484}
1734:   m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
1735:   m_LocalPosition: {x: 0, y: 0, z: 0}
1736:   m_LocalScale: {x: 1, y: 1, z: 1}
1737:   m_ConstrainProportionsScale: 0
1738:   m_Children:
1739:   - {fileID: 1524174883}
1740:   m_Father: {fileID: 479897091}
1741:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
1742:   m_AnchorMin: {x: 0, y: 0.25}
1743:   m_AnchorMax: {x: 1, y: 0.75}
1744:   m_AnchoredPosition: {x: -5, y: 0}
1745:   m_SizeDelta: {x: -20, y: 0}
1746:   m_Pivot: {x: 0.5, y: 0.5}
1747: --- !u!1 &1421303958
1748: GameObject:
1749:   m_ObjectHideFlags: 0
1750:   m_CorrespondingSourceObject: {fileID: 0}
1751:   m_PrefabInstance: {fileID: 0}
1752:   m_PrefabAsset: {fileID: 0}
1753:   serializedVersion: 6
1754:   m_Component:
1755:   - component: {fileID: 1421303959}
1756:   - component: {fileID: 1421303961}
1757:   - component: {fileID: 1421303960}
1758:   m_Layer: 5
1759:   m_Name: Background
1760:   m_TagString: Untagged
1761:   m_Icon: {fileID: 0}
1762:   m_NavMeshLayer: 0
1763:   m_StaticEditorFlags: 0
1764:   m_IsActive: 1
1765: --- !u!224 &1421303959
1766: RectTransform:
1767:   m_ObjectHideFlags: 0
1768:   m_CorrespondingSourceObject: {fileID: 0}
1769:   m_PrefabInstance: {fileID: 0}
1770:   m_PrefabAsset: {fileID: 0}
1771:   m_GameObject: {fileID: 1421303958}
1772:   m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
1773:   m_LocalPosition: {x: 0, y: 0, z: 0}
1774:   m_LocalScale: {x: 1, y: 1, z: 1}
1775:   m_ConstrainProportionsScale: 0
1776:   m_Children: []
1777:   m_Father: {fileID: 479897091}
1778:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
1779:   m_AnchorMin: {x: 0, y: 0.25}
1780:   m_AnchorMax: {x: 1, y: 0.75}
1781:   m_AnchoredPosition: {x: 0, y: 0}
1782:   m_SizeDelta: {x: 0, y: 0}
1783:   m_Pivot: {x: 0.5, y: 0.5}
1784: --- !u!114 &1421303960
1785: MonoBehaviour:
1786:   m_ObjectHideFlags: 0
1787:   m_CorrespondingSourceObject: {fileID: 0}
1788:   m_PrefabInstance: {fileID: 0}
1789:   m_PrefabAsset: {fileID: 0}
1790:   m_GameObject: {fileID: 1421303958}
1791:   m_Enabled: 1
1792:   m_EditorHideFlags: 0
1793:   m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
1794:   m_Name: 
1795:   m_EditorClassIdentifier: 
1796:   m_Material: {fileID: 0}
1797:   m_Color: {r: 1, g: 1, b: 1, a: 1}
1798:   m_RaycastTarget: 1
1799:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
1800:   m_Maskable: 1
1801:   m_OnCullStateChanged:
1802:     m_PersistentCalls:
1803:       m_Calls: []
1804:   m_Sprite: {fileID: 10907, guid: 0000000000000000f000000000000000, type: 0}
1805:   m_Type: 1
1806:   m_PreserveAspect: 0
1807:   m_FillCenter: 1
1808:   m_FillMethod: 4
1809:   m_FillAmount: 1
1810:   m_FillClockwise: 1
1811:   m_FillOrigin: 0
1812:   m_UseSpriteMesh: 0
1813:   m_PixelsPerUnitMultiplier: 1
1814: --- !u!222 &1421303961
1815: CanvasRenderer:
1816:   m_ObjectHideFlags: 0
1817:   m_CorrespondingSourceObject: {fileID: 0}
1818:   m_PrefabInstance: {fileID: 0}
1819:   m_PrefabAsset: {fileID: 0}
1820:   m_GameObject: {fileID: 1421303958}
1821:   m_CullTransparentMesh: 1
1822: --- !u!1 &1518948668
1823: GameObject:
1824:   m_ObjectHideFlags: 0
1825:   m_CorrespondingSourceObject: {fileID: 0}
1826:   m_PrefabInstance: {fileID: 0}
1827:   m_PrefabAsset: {fileID: 0}
1828:   serializedVersion: 6
1829:   m_Component:
1830:   - component: {fileID: 1518948672}
1831:   - component: {fileID: 1518948671}
1832:   - component: {fileID: 1518948670}
1833:   - component: {fileID: 1518948669}
1834:   m_Layer: 5
1835:   m_Name: Options
1836:   m_TagString: Untagged
1837:   m_Icon: {fileID: 0}
1838:   m_NavMeshLayer: 0
1839:   m_StaticEditorFlags: 0
1840:   m_IsActive: 0
1841: --- !u!114 &1518948669
1842: MonoBehaviour:
1843:   m_ObjectHideFlags: 0
1844:   m_CorrespondingSourceObject: {fileID: 0}
1845:   m_PrefabInstance: {fileID: 0}
1846:   m_PrefabAsset: {fileID: 0}
1847:   m_GameObject: {fileID: 1518948668}
1848:   m_Enabled: 1
1849:   m_EditorHideFlags: 0
1850:   m_Script: {fileID: 11500000, guid: dc42784cf147c0c48a680349fa168899, type: 3}
1851:   m_Name: 
1852:   m_EditorClassIdentifier: 
1853:   m_IgnoreReversedGraphics: 1
1854:   m_BlockingObjects: 0
1855:   m_BlockingMask:
1856:     serializedVersion: 2
1857:     m_Bits: 4294967295
1858: --- !u!114 &1518948670
1859: MonoBehaviour:
1860:   m_ObjectHideFlags: 0
1861:   m_CorrespondingSourceObject: {fileID: 0}
1862:   m_PrefabInstance: {fileID: 0}
1863:   m_PrefabAsset: {fileID: 0}
1864:   m_GameObject: {fileID: 1518948668}
1865:   m_Enabled: 1
1866:   m_EditorHideFlags: 0
1867:   m_Script: {fileID: 11500000, guid: 0cd44c1031e13a943bb63640046fad76, type: 3}
1868:   m_Name: 
1869:   m_EditorClassIdentifier: 
1870:   m_UiScaleMode: 1
1871:   m_ReferencePixelsPerUnit: 100
1872:   m_ScaleFactor: 1
1873:   m_ReferenceResolution: {x: 800, y: 600}
1874:   m_ScreenMatchMode: 0
1875:   m_MatchWidthOrHeight: 0
1876:   m_PhysicalUnit: 3
1877:   m_FallbackScreenDPI: 96
1878:   m_DefaultSpriteDPI: 96
1879:   m_DynamicPixelsPerUnit: 1
1880:   m_PresetInfoIsWorld: 0
1881: --- !u!223 &1518948671
1882: Canvas:
1883:   m_ObjectHideFlags: 0
1884:   m_CorrespondingSourceObject: {fileID: 0}
1885:   m_PrefabInstance: {fileID: 0}
1886:   m_PrefabAsset: {fileID: 0}
1887:   m_GameObject: {fileID: 1518948668}
1888:   m_Enabled: 1
1889:   serializedVersion: 3
1890:   m_RenderMode: 0
1891:   m_Camera: {fileID: 0}
1892:   m_PlaneDistance: 100
1893:   m_PixelPerfect: 0
1894:   m_ReceivesEvents: 1
1895:   m_OverrideSorting: 0
1896:   m_OverridePixelPerfect: 0
1897:   m_SortingBucketNormalizedSize: 0
1898:   m_VertexColorAlwaysGammaSpace: 0
1899:   m_AdditionalShaderChannelsFlag: 25
1900:   m_UpdateRectTransformForStandalone: 0
1901:   m_SortingLayerID: 0
1902:   m_SortingOrder: 0
1903:   m_TargetDisplay: 0
1904: --- !u!224 &1518948672
1905: RectTransform:
1906:   m_ObjectHideFlags: 0
1907:   m_CorrespondingSourceObject: {fileID: 0}
1908:   m_PrefabInstance: {fileID: 0}
1909:   m_PrefabAsset: {fileID: 0}
1910:   m_GameObject: {fileID: 1518948668}
1911:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
1912:   m_LocalPosition: {x: 0, y: 0, z: 0}
1913:   m_LocalScale: {x: 0, y: 0, z: 0}
1914:   m_ConstrainProportionsScale: 0
1915:   m_Children:
1916:   - {fileID: 713136667}
1917:   - {fileID: 1686965930}
1918:   - {fileID: 796269215}
1919:   - {fileID: 164198536}
1920:   - {fileID: 479897091}
1921:   m_Father: {fileID: 0}
1922:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
1923:   m_AnchorMin: {x: 0, y: 0}
1924:   m_AnchorMax: {x: 0, y: 0}
1925:   m_AnchoredPosition: {x: 0, y: 0}
1926:   m_SizeDelta: {x: 0, y: 0}
1927:   m_Pivot: {x: 0, y: 0}
1928: --- !u!1 &1524174882
1929: GameObject:
1930:   m_ObjectHideFlags: 0
1931:   m_CorrespondingSourceObject: {fileID: 0}
1932:   m_PrefabInstance: {fileID: 0}
1933:   m_PrefabAsset: {fileID: 0}
1934:   serializedVersion: 6
1935:   m_Component:
1936:   - component: {fileID: 1524174883}
1937:   - component: {fileID: 1524174885}
1938:   - component: {fileID: 1524174884}
1939:   m_Layer: 5
1940:   m_Name: Fill
1941:   m_TagString: Untagged
1942:   m_Icon: {fileID: 0}
1943:   m_NavMeshLayer: 0
1944:   m_StaticEditorFlags: 0
1945:   m_IsActive: 1
1946: --- !u!224 &1524174883
1947: RectTransform:
1948:   m_ObjectHideFlags: 0
1949:   m_CorrespondingSourceObject: {fileID: 0}
1950:   m_PrefabInstance: {fileID: 0}
1951:   m_PrefabAsset: {fileID: 0}
1952:   m_GameObject: {fileID: 1524174882}
1953:   m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
1954:   m_LocalPosition: {x: 0, y: 0, z: 0}
1955:   m_LocalScale: {x: 1, y: 1, z: 1}
1956:   m_ConstrainProportionsScale: 0
1957:   m_Children: []
1958:   m_Father: {fileID: 1254730485}
1959:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
1960:   m_AnchorMin: {x: 0, y: 0}
1961:   m_AnchorMax: {x: 0, y: 1}
1962:   m_AnchoredPosition: {x: 0, y: 0}
1963:   m_SizeDelta: {x: 10, y: 0}
1964:   m_Pivot: {x: 0.5, y: 0.5}
1965: --- !u!114 &1524174884
1966: MonoBehaviour:
1967:   m_ObjectHideFlags: 0
1968:   m_CorrespondingSourceObject: {fileID: 0}
1969:   m_PrefabInstance: {fileID: 0}
1970:   m_PrefabAsset: {fileID: 0}
1971:   m_GameObject: {fileID: 1524174882}
1972:   m_Enabled: 1
1973:   m_EditorHideFlags: 0
1974:   m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
1975:   m_Name: 
1976:   m_EditorClassIdentifier: 
1977:   m_Material: {fileID: 0}
1978:   m_Color: {r: 1, g: 1, b: 1, a: 1}
1979:   m_RaycastTarget: 1
1980:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
1981:   m_Maskable: 1
1982:   m_OnCullStateChanged:
1983:     m_PersistentCalls:
1984:       m_Calls: []
1985:   m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
1986:   m_Type: 1
1987:   m_PreserveAspect: 0
1988:   m_FillCenter: 1
1989:   m_FillMethod: 4
1990:   m_FillAmount: 1
1991:   m_FillClockwise: 1
1992:   m_FillOrigin: 0
1993:   m_UseSpriteMesh: 0
1994:   m_PixelsPerUnitMultiplier: 1
1995: --- !u!222 &1524174885
1996: CanvasRenderer:
1997:   m_ObjectHideFlags: 0
1998:   m_CorrespondingSourceObject: {fileID: 0}
1999:   m_PrefabInstance: {fileID: 0}
2000:   m_PrefabAsset: {fileID: 0}
2001:   m_GameObject: {fileID: 1524174882}
2002:   m_CullTransparentMesh: 1
2003: --- !u!1 &1633417895
2004: GameObject:
2005:   m_ObjectHideFlags: 0
2006:   m_CorrespondingSourceObject: {fileID: 0}
2007:   m_PrefabInstance: {fileID: 0}
2008:   m_PrefabAsset: {fileID: 0}
2009:   serializedVersion: 6
2010:   m_Component:
2011:   - component: {fileID: 1633417898}
2012:   - component: {fileID: 1633417897}
2013:   - component: {fileID: 1633417896}
2014:   m_Layer: 0
2015:   m_Name: Main Camera
2016:   m_TagString: MainCamera
2017:   m_Icon: {fileID: 0}
2018:   m_NavMeshLayer: 0
2019:   m_StaticEditorFlags: 0
2020:   m_IsActive: 1
2021: --- !u!81 &1633417896
2022: AudioListener:
2023:   m_ObjectHideFlags: 0
2024:   m_CorrespondingSourceObject: {fileID: 0}
2025:   m_PrefabInstance: {fileID: 0}
2026:   m_PrefabAsset: {fileID: 0}
2027:   m_GameObject: {fileID: 1633417895}
2028:   m_Enabled: 1
2029: --- !u!20 &1633417897
2030: Camera:
2031:   m_ObjectHideFlags: 0
2032:   m_CorrespondingSourceObject: {fileID: 0}
2033:   m_PrefabInstance: {fileID: 0}
2034:   m_PrefabAsset: {fileID: 0}
2035:   m_GameObject: {fileID: 1633417895}
2036:   m_Enabled: 1
2037:   serializedVersion: 2
2038:   m_ClearFlags: 1
2039:   m_BackGroundColor: {r: 0.19215687, g: 0.3019608, b: 0.4745098, a: 0}
2040:   m_projectionMatrixMode: 1
2041:   m_GateFitMode: 2
2042:   m_FOVAxisMode: 0
2043:   m_Iso: 200
2044:   m_ShutterSpeed: 0.005
2045:   m_Aperture: 16
2046:   m_FocusDistance: 10
2047:   m_FocalLength: 50
2048:   m_BladeCount: 5
2049:   m_Curvature: {x: 2, y: 11}
2050:   m_BarrelClipping: 0.25
2051:   m_Anamorphism: 0
2052:   m_SensorSize: {x: 36, y: 24}
2053:   m_LensShift: {x: 0, y: 0}
2054:   m_NormalizedViewPortRect:
2055:     serializedVersion: 2
2056:     x: 0
2057:     y: 0
2058:     width: 1
2059:     height: 1
2060:   near clip plane: 0.3
2061:   far clip plane: 1000
2062:   field of view: 60
2063:   orthographic: 0
2064:   orthographic size: 5
2065:   m_Depth: -1
2066:   m_CullingMask:
2067:     serializedVersion: 2
2068:     m_Bits: 4294967295
2069:   m_RenderingPath: -1
2070:   m_TargetTexture: {fileID: 0}
2071:   m_TargetDisplay: 0
2072:   m_TargetEye: 3
2073:   m_HDR: 1
2074:   m_AllowMSAA: 1
2075:   m_AllowDynamicResolution: 0
2076:   m_ForceIntoRT: 0
2077:   m_OcclusionCulling: 1
2078:   m_StereoConvergence: 10
2079:   m_StereoSeparation: 0.022
2080: --- !u!4 &1633417898
2081: Transform:
2082:   m_ObjectHideFlags: 0
2083:   m_CorrespondingSourceObject: {fileID: 0}
2084:   m_PrefabInstance: {fileID: 0}
2085:   m_PrefabAsset: {fileID: 0}
2086:   m_GameObject: {fileID: 1633417895}
2087:   serializedVersion: 2
2088:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
2089:   m_LocalPosition: {x: 0, y: 1, z: -10}
2090:   m_LocalScale: {x: 1, y: 1, z: 1}
2091:   m_ConstrainProportionsScale: 0
2092:   m_Children: []
2093:   m_Father: {fileID: 0}
2094:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
2095: --- !u!1 &1662025903
2096: GameObject:
2097:   m_ObjectHideFlags: 0
2098:   m_CorrespondingSourceObject: {fileID: 0}
2099:   m_PrefabInstance: {fileID: 0}
2100:   m_PrefabAsset: {fileID: 0}
2101:   serializedVersion: 6
2102:   m_Component:
2103:   - component: {fileID: 1662025907}
2104:   - component: {fileID: 1662025906}
2105:   - component: {fileID: 1662025905}
2106:   - component: {fileID: 1662025904}
2107:   m_Layer: 5
2108:   m_Name: Canvas
2109:   m_TagString: Untagged
2110:   m_Icon: {fileID: 0}
2111:   m_NavMeshLayer: 0
2112:   m_StaticEditorFlags: 0
2113:   m_IsActive: 1
2114: --- !u!114 &1662025904
2115: MonoBehaviour:
2116:   m_ObjectHideFlags: 0
2117:   m_CorrespondingSourceObject: {fileID: 0}
2118:   m_PrefabInstance: {fileID: 0}
2119:   m_PrefabAsset: {fileID: 0}
2120:   m_GameObject: {fileID: 1662025903}
2121:   m_Enabled: 1
2122:   m_EditorHideFlags: 0
2123:   m_Script: {fileID: 11500000, guid: dc42784cf147c0c48a680349fa168899, type: 3}
2124:   m_Name: 
2125:   m_EditorClassIdentifier: 
2126:   m_IgnoreReversedGraphics: 1
2127:   m_BlockingObjects: 0
2128:   m_BlockingMask:
2129:     serializedVersion: 2
2130:     m_Bits: 4294967295
2131: --- !u!114 &1662025905
2132: MonoBehaviour:
2133:   m_ObjectHideFlags: 0
2134:   m_CorrespondingSourceObject: {fileID: 0}
2135:   m_PrefabInstance: {fileID: 0}
2136:   m_PrefabAsset: {fileID: 0}
2137:   m_GameObject: {fileID: 1662025903}
2138:   m_Enabled: 1
2139:   m_EditorHideFlags: 0
2140:   m_Script: {fileID: 11500000, guid: 0cd44c1031e13a943bb63640046fad76, type: 3}
2141:   m_Name: 
2142:   m_EditorClassIdentifier: 
2143:   m_UiScaleMode: 1
2144:   m_ReferencePixelsPerUnit: 100
2145:   m_ScaleFactor: 1
2146:   m_ReferenceResolution: {x: 800, y: 600}
2147:   m_ScreenMatchMode: 0
2148:   m_MatchWidthOrHeight: 0
2149:   m_PhysicalUnit: 3
2150:   m_FallbackScreenDPI: 96
2151:   m_DefaultSpriteDPI: 96
2152:   m_DynamicPixelsPerUnit: 1
2153:   m_PresetInfoIsWorld: 0
2154: --- !u!223 &1662025906
2155: Canvas:
2156:   m_ObjectHideFlags: 0
2157:   m_CorrespondingSourceObject: {fileID: 0}
2158:   m_PrefabInstance: {fileID: 0}
2159:   m_PrefabAsset: {fileID: 0}
2160:   m_GameObject: {fileID: 1662025903}
2161:   m_Enabled: 1
2162:   serializedVersion: 3
2163:   m_RenderMode: 0
2164:   m_Camera: {fileID: 0}
2165:   m_PlaneDistance: 100
2166:   m_PixelPerfect: 0
2167:   m_ReceivesEvents: 1
2168:   m_OverrideSorting: 0
2169:   m_OverridePixelPerfect: 0
2170:   m_SortingBucketNormalizedSize: 0
2171:   m_VertexColorAlwaysGammaSpace: 0
2172:   m_AdditionalShaderChannelsFlag: 25
2173:   m_UpdateRectTransformForStandalone: 0
2174:   m_SortingLayerID: 0
2175:   m_SortingOrder: 0
2176:   m_TargetDisplay: 0
2177: --- !u!224 &1662025907
2178: RectTransform:
2179:   m_ObjectHideFlags: 0
2180:   m_CorrespondingSourceObject: {fileID: 0}
2181:   m_PrefabInstance: {fileID: 0}
2182:   m_PrefabAsset: {fileID: 0}
2183:   m_GameObject: {fileID: 1662025903}
2184:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
2185:   m_LocalPosition: {x: 0, y: 0, z: 0}
2186:   m_LocalScale: {x: 0, y: 0, z: 0}
2187:   m_ConstrainProportionsScale: 0
2188:   m_Children:
2189:   - {fileID: 1056417}
2190:   - {fileID: 1201988940}
2191:   - {fileID: 729054714}
2192:   - {fileID: 33020377}
2193:   m_Father: {fileID: 0}
2194:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
2195:   m_AnchorMin: {x: 0, y: 0}
2196:   m_AnchorMax: {x: 0, y: 0}
2197:   m_AnchoredPosition: {x: 0, y: 0}
2198:   m_SizeDelta: {x: 0, y: 0}
2199:   m_Pivot: {x: 0, y: 0}
2200: --- !u!1 &1686965929
2201: GameObject:
2202:   m_ObjectHideFlags: 0
2203:   m_CorrespondingSourceObject: {fileID: 0}
2204:   m_PrefabInstance: {fileID: 0}
2205:   m_PrefabAsset: {fileID: 0}
2206:   serializedVersion: 6
2207:   m_Component:
2208:   - component: {fileID: 1686965930}
2209:   - component: {fileID: 1686965933}
2210:   - component: {fileID: 1686965932}
2211:   - component: {fileID: 1686965931}
2212:   m_Layer: 5
2213:   m_Name: Pantalla
2214:   m_TagString: Untagged
2215:   m_Icon: {fileID: 0}
2216:   m_NavMeshLayer: 0
2217:   m_StaticEditorFlags: 0
2218:   m_IsActive: 1
2219: --- !u!224 &1686965930
2220: RectTransform:
2221:   m_ObjectHideFlags: 0
2222:   m_CorrespondingSourceObject: {fileID: 0}
2223:   m_PrefabInstance: {fileID: 0}
2224:   m_PrefabAsset: {fileID: 0}
2225:   m_GameObject: {fileID: 1686965929}
2226:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
2227:   m_LocalPosition: {x: 0, y: 0, z: 0}
2228:   m_LocalScale: {x: 1, y: 1, z: 1}
2229:   m_ConstrainProportionsScale: 0
2230:   m_Children:
2231:   - {fileID: 650266551}
2232:   m_Father: {fileID: 1518948672}
2233:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
2234:   m_AnchorMin: {x: 0.5, y: 0.5}
2235:   m_AnchorMax: {x: 0.5, y: 0.5}
2236:   m_AnchoredPosition: {x: -12.9, y: 133.76202}
2237:   m_SizeDelta: {x: 43.3052, y: 41.8655}
2238:   m_Pivot: {x: 0.5, y: 0.5}
2239: --- !u!114 &1686965931
2240: MonoBehaviour:
2241:   m_ObjectHideFlags: 0
2242:   m_CorrespondingSourceObject: {fileID: 0}
2243:   m_PrefabInstance: {fileID: 0}
2244:   m_PrefabAsset: {fileID: 0}
2245:   m_GameObject: {fileID: 1686965929}
2246:   m_Enabled: 1
2247:   m_EditorHideFlags: 0
2248:   m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
2249:   m_Name: 
2250:   m_EditorClassIdentifier: 
2251:   m_Navigation:
2252:     m_Mode: 3
2253:     m_WrapAround: 0
2254:     m_SelectOnUp: {fileID: 0}
2255:     m_SelectOnDown: {fileID: 0}
2256:     m_SelectOnLeft: {fileID: 0}
2257:     m_SelectOnRight: {fileID: 0}
2258:   m_Transition: 1
2259:   m_Colors:
2260:     m_NormalColor: {r: 0.7075472, g: 0, b: 0, a: 0.14901961}
2261:     m_HighlightedColor: {r: 0.754717, g: 0.3025988, b: 0.3025988, a: 0.34117648}
2262:     m_PressedColor: {r: 0.7169812, g: 0.26041296, b: 0.26041296, a: 0.43137255}
2263:     m_SelectedColor: {r: 0.745283, g: 0.1511659, b: 0.1511659, a: 0.70980394}
2264:     m_DisabledColor: {r: 1, g: 0, b: 0, a: 1}
2265:     m_ColorMultiplier: 1
2266:     m_FadeDuration: 0.1
2267:   m_SpriteState:
2268:     m_HighlightedSprite: {fileID: 0}
2269:     m_PressedSprite: {fileID: 0}
2270:     m_SelectedSprite: {fileID: 0}
2271:     m_DisabledSprite: {fileID: 0}
2272:   m_AnimationTriggers:
2273:     m_NormalTrigger: Normal
2274:     m_HighlightedTrigger: Highlighted
2275:     m_PressedTrigger: Pressed
2276:     m_SelectedTrigger: Selected
2277:     m_DisabledTrigger: Disabled
2278:   m_Interactable: 1
2279:   m_TargetGraphic: {fileID: 1686965932}
2280:   m_OnClick:
2281:     m_PersistentCalls:
2282:       m_Calls: []
2283: --- !u!114 &1686965932
2284: MonoBehaviour:
2285:   m_ObjectHideFlags: 0
2286:   m_CorrespondingSourceObject: {fileID: 0}
2287:   m_PrefabInstance: {fileID: 0}
2288:   m_PrefabAsset: {fileID: 0}
2289:   m_GameObject: {fileID: 1686965929}
2290:   m_Enabled: 1
2291:   m_EditorHideFlags: 0
2292:   m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
2293:   m_Name: 
2294:   m_EditorClassIdentifier: 
2295:   m_Material: {fileID: 0}
2296:   m_Color: {r: 1, g: 1, b: 1, a: 1}
2297:   m_RaycastTarget: 1
2298:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
2299:   m_Maskable: 1
2300:   m_OnCullStateChanged:
2301:     m_PersistentCalls:
2302:       m_Calls: []
2303:   m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
2304:   m_Type: 1
2305:   m_PreserveAspect: 0
2306:   m_FillCenter: 1
2307:   m_FillMethod: 4
2308:   m_FillAmount: 1
2309:   m_FillClockwise: 1
2310:   m_FillOrigin: 0
2311:   m_UseSpriteMesh: 0
2312:   m_PixelsPerUnitMultiplier: 1
2313: --- !u!222 &1686965933
2314: CanvasRenderer:
2315:   m_ObjectHideFlags: 0
2316:   m_CorrespondingSourceObject: {fileID: 0}
2317:   m_PrefabInstance: {fileID: 0}
2318:   m_PrefabAsset: {fileID: 0}
2319:   m_GameObject: {fileID: 1686965929}
2320:   m_CullTransparentMesh: 1
2321: --- !u!1 &1721047800
2322: GameObject:
2323:   m_ObjectHideFlags: 0
2324:   m_CorrespondingSourceObject: {fileID: 0}
2325:   m_PrefabInstance: {fileID: 0}
2326:   m_PrefabAsset: {fileID: 0}
2327:   serializedVersion: 6
2328:   m_Component:
2329:   - component: {fileID: 1721047801}
2330:   - component: {fileID: 1721047803}
2331:   - component: {fileID: 1721047802}
2332:   m_Layer: 5
2333:   m_Name: Text (TMP)
2334:   m_TagString: Untagged
2335:   m_Icon: {fileID: 0}
2336:   m_NavMeshLayer: 0
2337:   m_StaticEditorFlags: 0
2338:   m_IsActive: 1
2339: --- !u!224 &1721047801
2340: RectTransform:
2341:   m_ObjectHideFlags: 0
2342:   m_CorrespondingSourceObject: {fileID: 0}
2343:   m_PrefabInstance: {fileID: 0}
2344:   m_PrefabAsset: {fileID: 0}
2345:   m_GameObject: {fileID: 1721047800}
2346:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
2347:   m_LocalPosition: {x: 0, y: 0, z: 0}
2348:   m_LocalScale: {x: 1, y: 1, z: 1}
2349:   m_ConstrainProportionsScale: 0
2350:   m_Children: []
2351:   m_Father: {fileID: 796269215}
2352:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
2353:   m_AnchorMin: {x: 0, y: 0}
2354:   m_AnchorMax: {x: 1, y: 1}
2355:   m_AnchoredPosition: {x: -8, y: 41.4}
2356:   m_SizeDelta: {x: 0, y: 0}
2357:   m_Pivot: {x: 0.5, y: 0.5}
2358: --- !u!114 &1721047802
2359: MonoBehaviour:
2360:   m_ObjectHideFlags: 0
2361:   m_CorrespondingSourceObject: {fileID: 0}
2362:   m_PrefabInstance: {fileID: 0}
2363:   m_PrefabAsset: {fileID: 0}
2364:   m_GameObject: {fileID: 1721047800}
2365:   m_Enabled: 1
2366:   m_EditorHideFlags: 0
2367:   m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
2368:   m_Name: 
2369:   m_EditorClassIdentifier: 
2370:   m_Material: {fileID: 0}
2371:   m_Color: {r: 1, g: 1, b: 1, a: 1}
2372:   m_RaycastTarget: 1
2373:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
2374:   m_Maskable: 1
2375:   m_OnCullStateChanged:
2376:     m_PersistentCalls:
2377:       m_Calls: []
2378:   m_text: Volumen
2379:   m_isRightToLeft: 0
2380:   m_fontAsset: {fileID: 11400000, guid: 125cb55b44b24c4393181402bc6200e6, type: 2}
2381:   m_sharedMaterial: {fileID: 2100000, guid: d75b8f41e959450c84ac6e967084d3e1, type: 2}
2382:   m_fontSharedMaterials: []
2383:   m_fontMaterial: {fileID: 0}
2384:   m_fontMaterials: []
2385:   m_fontColor32:
2386:     serializedVersion: 2
2387:     rgba: 4281216654
2388:   m_fontColor: {r: 0.5566038, g: 0.18115878, b: 0.18115878, a: 1}
2389:   m_enableVertexGradient: 0
2390:   m_colorMode: 3
2391:   m_fontColorGradient:
2392:     topLeft: {r: 1, g: 1, b: 1, a: 1}
2393:     topRight: {r: 1, g: 1, b: 1, a: 1}
2394:     bottomLeft: {r: 1, g: 1, b: 1, a: 1}
2395:     bottomRight: {r: 1, g: 1, b: 1, a: 1}
2396:   m_fontColorGradientPreset: {fileID: 0}
2397:   m_spriteAsset: {fileID: 0}
2398:   m_tintAllSprites: 0
2399:   m_StyleSheet: {fileID: 0}
2400:   m_TextStyleHashCode: -1183493901
2401:   m_overrideHtmlColors: 0
2402:   m_faceColor:
2403:     serializedVersion: 2
2404:     rgba: 4294967295
2405:   m_fontSize: 40
2406:   m_fontSizeBase: 40
2407:   m_fontWeight: 400
2408:   m_enableAutoSizing: 0
2409:   m_fontSizeMin: 0
2410:   m_fontSizeMax: 0
2411:   m_fontStyle: 0
2412:   m_HorizontalAlignment: 2
2413:   m_VerticalAlignment: 512
2414:   m_textAlignment: 65535
2415:   m_characterSpacing: 0
2416:   m_wordSpacing: 0
2417:   m_lineSpacing: 0
2418:   m_lineSpacingMax: 0
2419:   m_paragraphSpacing: 0
2420:   m_charWidthMaxAdj: 0
2421:   m_enableWordWrapping: 0
2422:   m_wordWrappingRatios: 0.4
2423:   m_overflowMode: 0
2424:   m_linkedTextComponent: {fileID: 0}
2425:   parentLinkedComponent: {fileID: 0}
2426:   m_enableKerning: 0
2427:   m_enableExtraPadding: 0
2428:   checkPaddingRequired: 0
2429:   m_isRichText: 1
2430:   m_parseCtrlCharacters: 1
2431:   m_isOrthographic: 1
2432:   m_isCullingEnabled: 0
2433:   m_horizontalMapping: 0
2434:   m_verticalMapping: 0
2435:   m_uvLineOffset: 0
2436:   m_geometrySortingOrder: 0
2437:   m_IsTextObjectScaleStatic: 0
2438:   m_VertexBufferAutoSizeReduction: 0
2439:   m_useMaxVisibleDescender: 1
2440:   m_pageToDisplay: 1
2441:   m_margin: {x: 0, y: 0, z: 0, w: 0}
2442:   m_isUsingLegacyAnimationComponent: 0
2443:   m_isVolumetricText: 0
2444:   m_hasFontAssetChanged: 0
2445:   m_baseMaterial: {fileID: 0}
2446:   m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
2447: --- !u!222 &1721047803
2448: CanvasRenderer:
2449:   m_ObjectHideFlags: 0
2450:   m_CorrespondingSourceObject: {fileID: 0}
2451:   m_PrefabInstance: {fileID: 0}
2452:   m_PrefabAsset: {fileID: 0}
2453:   m_GameObject: {fileID: 1721047800}
2454:   m_CullTransparentMesh: 1
2455: --- !u!1 &1944728888
2456: GameObject:
2457:   m_ObjectHideFlags: 0
2458:   m_CorrespondingSourceObject: {fileID: 0}
2459:   m_PrefabInstance: {fileID: 0}
2460:   m_PrefabAsset: {fileID: 0}
2461:   serializedVersion: 6
2462:   m_Component:
2463:   - component: {fileID: 1944728890}
2464:   - component: {fileID: 1944728889}
2465:   m_Layer: 0
2466:   m_Name: Directional Light
2467:   m_TagString: Untagged
2468:   m_Icon: {fileID: 0}
2469:   m_NavMeshLayer: 0
2470:   m_StaticEditorFlags: 0
2471:   m_IsActive: 1
2472: --- !u!108 &1944728889
2473: Light:
2474:   m_ObjectHideFlags: 0
2475:   m_CorrespondingSourceObject: {fileID: 0}
2476:   m_PrefabInstance: {fileID: 0}
2477:   m_PrefabAsset: {fileID: 0}
2478:   m_GameObject: {fileID: 1944728888}
2479:   m_Enabled: 1
2480:   serializedVersion: 10
2481:   m_Type: 1
2482:   m_Shape: 0
2483:   m_Color: {r: 1, g: 0.95686275, b: 0.8392157, a: 1}
2484:   m_Intensity: 1
2485:   m_Range: 10
2486:   m_SpotAngle: 30
2487:   m_InnerSpotAngle: 21.80208
2488:   m_CookieSize: 10
2489:   m_Shadows:
2490:     m_Type: 2
2491:     m_Resolution: -1
2492:     m_CustomResolution: -1
2493:     m_Strength: 1
2494:     m_Bias: 0.05
2495:     m_NormalBias: 0.4
2496:     m_NearPlane: 0.2
2497:     m_CullingMatrixOverride:
2498:       e00: 1
2499:       e01: 0
2500:       e02: 0
2501:       e03: 0
2502:       e10: 0
2503:       e11: 1
2504:       e12: 0
2505:       e13: 0
2506:       e20: 0
2507:       e21: 0
2508:       e22: 1
2509:       e23: 0
2510:       e30: 0
2511:       e31: 0
2512:       e32: 0
2513:       e33: 1
2514:     m_UseCullingMatrixOverride: 0
2515:   m_Cookie: {fileID: 0}
2516:   m_DrawHalo: 0
2517:   m_Flare: {fileID: 0}
2518:   m_RenderMode: 0
2519:   m_CullingMask:
2520:     serializedVersion: 2
2521:     m_Bits: 4294967295
2522:   m_RenderingLayerMask: 1
2523:   m_Lightmapping: 4
2524:   m_LightShadowCasterMode: 0
2525:   m_AreaSize: {x: 1, y: 1}
2526:   m_BounceIntensity: 1
2527:   m_ColorTemperature: 6570
2528:   m_UseColorTemperature: 0
2529:   m_BoundingSphereOverride: {x: 0, y: 0, z: 0, w: 0}
2530:   m_UseBoundingSphereOverride: 0
2531:   m_UseViewFrustumForShadowCasterCull: 1
2532:   m_ShadowRadius: 0
2533:   m_ShadowAngle: 0
2534: --- !u!4 &1944728890
2535: Transform:
2536:   m_ObjectHideFlags: 0
2537:   m_CorrespondingSourceObject: {fileID: 0}
2538:   m_PrefabInstance: {fileID: 0}
2539:   m_PrefabAsset: {fileID: 0}
2540:   m_GameObject: {fileID: 1944728888}
2541:   serializedVersion: 2
2542:   m_LocalRotation: {x: 0.40821788, y: -0.23456968, z: 0.10938163, w: 0.8754261}
2543:   m_LocalPosition: {x: 0, y: 3, z: 0}
2544:   m_LocalScale: {x: 1, y: 1, z: 1}
2545:   m_ConstrainProportionsScale: 0
2546:   m_Children: []
2547:   m_Father: {fileID: 0}
2548:   m_LocalEulerAnglesHint: {x: 50, y: -30, z: 0}
2549: --- !u!1 &2015550094
2550: GameObject:
2551:   m_ObjectHideFlags: 0
2552:   m_CorrespondingSourceObject: {fileID: 0}
2553:   m_PrefabInstance: {fileID: 0}
2554:   m_PrefabAsset: {fileID: 0}
2555:   serializedVersion: 6
2556:   m_Component:
2557:   - component: {fileID: 2015550095}
2558:   - component: {fileID: 2015550097}
2559:   - component: {fileID: 2015550096}
2560:   m_Layer: 5
2561:   m_Name: Text (TMP)
2562:   m_TagString: Untagged
2563:   m_Icon: {fileID: 0}
2564:   m_NavMeshLayer: 0
2565:   m_StaticEditorFlags: 0
2566:   m_IsActive: 1
2567: --- !u!224 &2015550095
2568: RectTransform:
2569:   m_ObjectHideFlags: 0
2570:   m_CorrespondingSourceObject: {fileID: 0}
2571:   m_PrefabInstance: {fileID: 0}
2572:   m_PrefabAsset: {fileID: 0}
2573:   m_GameObject: {fileID: 2015550094}
2574:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
2575:   m_LocalPosition: {x: 0, y: 0, z: 0}
2576:   m_LocalScale: {x: 1, y: 1, z: 1}
2577:   m_ConstrainProportionsScale: 0
2578:   m_Children: []
2579:   m_Father: {fileID: 1201988940}
2580:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
2581:   m_AnchorMin: {x: 0, y: 0}
2582:   m_AnchorMax: {x: 1, y: 1}
2583:   m_AnchoredPosition: {x: 0, y: 0}
2584:   m_SizeDelta: {x: 0, y: 0}
2585:   m_Pivot: {x: 0.5, y: 0.5}
2586: --- !u!114 &2015550096
2587: MonoBehaviour:
2588:   m_ObjectHideFlags: 0
2589:   m_CorrespondingSourceObject: {fileID: 0}
2590:   m_PrefabInstance: {fileID: 0}
2591:   m_PrefabAsset: {fileID: 0}
2592:   m_GameObject: {fileID: 2015550094}
2593:   m_Enabled: 1
2594:   m_EditorHideFlags: 0
2595:   m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
2596:   m_Name: 
2597:   m_EditorClassIdentifier: 
2598:   m_Material: {fileID: 0}
2599:   m_Color: {r: 1, g: 1, b: 1, a: 1}
2600:   m_RaycastTarget: 1
2601:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
2602:   m_Maskable: 1
2603:   m_OnCullStateChanged:
2604:     m_PersistentCalls:
2605:       m_Calls: []
2606:   m_text: Play
2607:   m_isRightToLeft: 0
2608:   m_fontAsset: {fileID: 11400000, guid: 125cb55b44b24c4393181402bc6200e6, type: 2}
2609:   m_sharedMaterial: {fileID: 2100000, guid: d75b8f41e959450c84ac6e967084d3e1, type: 2}
2610:   m_fontSharedMaterials: []
2611:   m_fontMaterial: {fileID: 0}
2612:   m_fontMaterials: []
2613:   m_fontColor32:
2614:     serializedVersion: 2
2615:     rgba: 4281216654
2616:   m_fontColor: {r: 0.5566038, g: 0.18115878, b: 0.18115878, a: 1}
2617:   m_enableVertexGradient: 0
2618:   m_colorMode: 3
2619:   m_fontColorGradient:
2620:     topLeft: {r: 1, g: 1, b: 1, a: 1}
2621:     topRight: {r: 1, g: 1, b: 1, a: 1}
2622:     bottomLeft: {r: 1, g: 1, b: 1, a: 1}
2623:     bottomRight: {r: 1, g: 1, b: 1, a: 1}
2624:   m_fontColorGradientPreset: {fileID: 0}
2625:   m_spriteAsset: {fileID: 0}
2626:   m_tintAllSprites: 0
2627:   m_StyleSheet: {fileID: 0}
2628:   m_TextStyleHashCode: -1183493901
2629:   m_overrideHtmlColors: 0
2630:   m_faceColor:
2631:     serializedVersion: 2
2632:     rgba: 4294967295
2633:   m_fontSize: 50
2634:   m_fontSizeBase: 50
2635:   m_fontWeight: 400
2636:   m_enableAutoSizing: 0
2637:   m_fontSizeMin: 0
2638:   m_fontSizeMax: 0
2639:   m_fontStyle: 0
2640:   m_HorizontalAlignment: 2
2641:   m_VerticalAlignment: 512
2642:   m_textAlignment: 65535
2643:   m_characterSpacing: 0
2644:   m_wordSpacing: 0
2645:   m_lineSpacing: 0
2646:   m_lineSpacingMax: 0
2647:   m_paragraphSpacing: 0
2648:   m_charWidthMaxAdj: 0
2649:   m_enableWordWrapping: 0
2650:   m_wordWrappingRatios: 0.4
2651:   m_overflowMode: 0
2652:   m_linkedTextComponent: {fileID: 0}
2653:   parentLinkedComponent: {fileID: 0}
2654:   m_enableKerning: 0
2655:   m_enableExtraPadding: 0
2656:   checkPaddingRequired: 0
2657:   m_isRichText: 1
2658:   m_parseCtrlCharacters: 1
2659:   m_isOrthographic: 1
2660:   m_isCullingEnabled: 0
2661:   m_horizontalMapping: 0
2662:   m_verticalMapping: 0
2663:   m_uvLineOffset: 0
2664:   m_geometrySortingOrder: 0
2665:   m_IsTextObjectScaleStatic: 0
2666:   m_VertexBufferAutoSizeReduction: 0
2667:   m_useMaxVisibleDescender: 1
2668:   m_pageToDisplay: 1
2669:   m_margin: {x: 0, y: 0, z: 0, w: 0}
2670:   m_isUsingLegacyAnimationComponent: 0
2671:   m_isVolumetricText: 0
2672:   m_hasFontAssetChanged: 0
2673:   m_baseMaterial: {fileID: 0}
2674:   m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
2675: --- !u!222 &2015550097
2676: CanvasRenderer:
2677:   m_ObjectHideFlags: 0
2678:   m_CorrespondingSourceObject: {fileID: 0}
2679:   m_PrefabInstance: {fileID: 0}
2680:   m_PrefabAsset: {fileID: 0}
2681:   m_GameObject: {fileID: 2015550094}
2682:   m_CullTransparentMesh: 1
2683: --- !u!1 &2105303960
2684: GameObject:
2685:   m_ObjectHideFlags: 0
2686:   m_CorrespondingSourceObject: {fileID: 0}
2687:   m_PrefabInstance: {fileID: 0}
2688:   m_PrefabAsset: {fileID: 0}
2689:   serializedVersion: 6
2690:   m_Component:
2691:   - component: {fileID: 2105303961}
2692:   - component: {fileID: 2105303963}
2693:   - component: {fileID: 2105303962}
2694:   m_Layer: 5
2695:   m_Name: Handle
2696:   m_TagString: Untagged
2697:   m_Icon: {fileID: 0}
2698:   m_NavMeshLayer: 0
2699:   m_StaticEditorFlags: 0
2700:   m_IsActive: 1
2701: --- !u!224 &2105303961
2702: RectTransform:
2703:   m_ObjectHideFlags: 0
2704:   m_CorrespondingSourceObject: {fileID: 0}
2705:   m_PrefabInstance: {fileID: 0}
2706:   m_PrefabAsset: {fileID: 0}
2707:   m_GameObject: {fileID: 2105303960}
2708:   m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
2709:   m_LocalPosition: {x: 0, y: 0, z: 0}
2710:   m_LocalScale: {x: 1, y: 1, z: 1}
2711:   m_ConstrainProportionsScale: 0
2712:   m_Children: []
2713:   m_Father: {fileID: 728527148}
2714:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
2715:   m_AnchorMin: {x: 0, y: 0}
2716:   m_AnchorMax: {x: 0, y: 1}
2717:   m_AnchoredPosition: {x: 0, y: 0}
2718:   m_SizeDelta: {x: 20, y: 0}
2719:   m_Pivot: {x: 0.5, y: 0.5}
2720: --- !u!114 &2105303962
2721: MonoBehaviour:
2722:   m_ObjectHideFlags: 0
2723:   m_CorrespondingSourceObject: {fileID: 0}
2724:   m_PrefabInstance: {fileID: 0}
2725:   m_PrefabAsset: {fileID: 0}
2726:   m_GameObject: {fileID: 2105303960}
2727:   m_Enabled: 1
2728:   m_EditorHideFlags: 0
2729:   m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
2730:   m_Name: 
2731:   m_EditorClassIdentifier: 
2732:   m_Material: {fileID: 0}
2733:   m_Color: {r: 1, g: 1, b: 1, a: 1}
2734:   m_RaycastTarget: 1
2735:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
2736:   m_Maskable: 1
2737:   m_OnCullStateChanged:
2738:     m_PersistentCalls:
2739:       m_Calls: []
2740:   m_Sprite: {fileID: 10913, guid: 0000000000000000f000000000000000, type: 0}
2741:   m_Type: 0
2742:   m_PreserveAspect: 0
2743:   m_FillCenter: 1
2744:   m_FillMethod: 4
2745:   m_FillAmount: 1
2746:   m_FillClockwise: 1
2747:   m_FillOrigin: 0
2748:   m_UseSpriteMesh: 0
2749:   m_PixelsPerUnitMultiplier: 1
2750: --- !u!222 &2105303963
2751: CanvasRenderer:
2752:   m_ObjectHideFlags: 0
2753:   m_CorrespondingSourceObject: {fileID: 0}
2754:   m_PrefabInstance: {fileID: 0}
2755:   m_PrefabAsset: {fileID: 0}
2756:   m_GameObject: {fileID: 2105303960}
2757:   m_CullTransparentMesh: 1
2758: --- !u!1660057539 &9223372036854775807
2759: SceneRoots:
2760:   m_ObjectHideFlags: 0
2761:   m_Roots:
2762:   - {fileID: 1633417898}
2763:   - {fileID: 1944728890}
2764:   - {fileID: 1662025907}
2765:   - {fileID: 92151548}
2766:   - {fileID: 1518948672}
2767:   - {fileID: 123974547}
```

## File: Assets/_Prefabs/Contain.prefab
```
  1: %YAML 1.1
  2: %TAG !u! tag:unity3d.com,2011:
  3: --- !u!1 &6581710663154360527
  4: GameObject:
  5:   m_ObjectHideFlags: 0
  6:   m_CorrespondingSourceObject: {fileID: 0}
  7:   m_PrefabInstance: {fileID: 0}
  8:   m_PrefabAsset: {fileID: 0}
  9:   serializedVersion: 6
 10:   m_Component:
 11:   - component: {fileID: 3333120263655268114}
 12:   - component: {fileID: 3501842608460178568}
 13:   - component: {fileID: 2486642289788777521}
 14:   - component: {fileID: 2767822457884646269}
 15:   - component: {fileID: 3328155227325760353}
 16:   m_Layer: 0
 17:   m_Name: Contain
 18:   m_TagString: score
 19:   m_Icon: {fileID: 0}
 20:   m_NavMeshLayer: 0
 21:   m_StaticEditorFlags: 0
 22:   m_IsActive: 1
 23: --- !u!4 &3333120263655268114
 24: Transform:
 25:   m_ObjectHideFlags: 0
 26:   m_CorrespondingSourceObject: {fileID: 0}
 27:   m_PrefabInstance: {fileID: 0}
 28:   m_PrefabAsset: {fileID: 0}
 29:   m_GameObject: {fileID: 6581710663154360527}
 30:   serializedVersion: 2
 31:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
 32:   m_LocalPosition: {x: 0, y: 0.5, z: 0}
 33:   m_LocalScale: {x: 1, y: 1, z: 1}
 34:   m_ConstrainProportionsScale: 0
 35:   m_Children: []
 36:   m_Father: {fileID: 0}
 37:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 38: --- !u!33 &3501842608460178568
 39: MeshFilter:
 40:   m_ObjectHideFlags: 0
 41:   m_CorrespondingSourceObject: {fileID: 0}
 42:   m_PrefabInstance: {fileID: 0}
 43:   m_PrefabAsset: {fileID: 0}
 44:   m_GameObject: {fileID: 6581710663154360527}
 45:   m_Mesh: {fileID: 10207, guid: 0000000000000000e000000000000000, type: 0}
 46: --- !u!23 &2486642289788777521
 47: MeshRenderer:
 48:   m_ObjectHideFlags: 0
 49:   m_CorrespondingSourceObject: {fileID: 0}
 50:   m_PrefabInstance: {fileID: 0}
 51:   m_PrefabAsset: {fileID: 0}
 52:   m_GameObject: {fileID: 6581710663154360527}
 53:   m_Enabled: 1
 54:   m_CastShadows: 1
 55:   m_ReceiveShadows: 1
 56:   m_DynamicOccludee: 1
 57:   m_StaticShadowCaster: 0
 58:   m_MotionVectors: 1
 59:   m_LightProbeUsage: 1
 60:   m_ReflectionProbeUsage: 1
 61:   m_RayTracingMode: 2
 62:   m_RayTraceProcedural: 0
 63:   m_RenderingLayerMask: 1
 64:   m_RendererPriority: 0
 65:   m_Materials:
 66:   - {fileID: 10303, guid: 0000000000000000f000000000000000, type: 0}
 67:   m_StaticBatchInfo:
 68:     firstSubMesh: 0
 69:     subMeshCount: 0
 70:   m_StaticBatchRoot: {fileID: 0}
 71:   m_ProbeAnchor: {fileID: 0}
 72:   m_LightProbeVolumeOverride: {fileID: 0}
 73:   m_ScaleInLightmap: 1
 74:   m_ReceiveGI: 1
 75:   m_PreserveUVs: 0
 76:   m_IgnoreNormalsForChartDetection: 0
 77:   m_ImportantGI: 0
 78:   m_StitchLightmapSeams: 1
 79:   m_SelectedEditorRenderState: 3
 80:   m_MinimumChartSize: 4
 81:   m_AutoUVMaxDistance: 0.5
 82:   m_AutoUVMaxAngle: 89
 83:   m_LightmapParameters: {fileID: 0}
 84:   m_SortingLayerID: 0
 85:   m_SortingLayer: 0
 86:   m_SortingOrder: 0
 87:   m_AdditionalVertexStreams: {fileID: 0}
 88: --- !u!135 &2767822457884646269
 89: SphereCollider:
 90:   m_ObjectHideFlags: 0
 91:   m_CorrespondingSourceObject: {fileID: 0}
 92:   m_PrefabInstance: {fileID: 0}
 93:   m_PrefabAsset: {fileID: 0}
 94:   m_GameObject: {fileID: 6581710663154360527}
 95:   m_Material: {fileID: 0}
 96:   m_IncludeLayers:
 97:     serializedVersion: 2
 98:     m_Bits: 0
 99:   m_ExcludeLayers:
100:     serializedVersion: 2
101:     m_Bits: 0
102:   m_LayerOverridePriority: 0
103:   m_IsTrigger: 0
104:   m_ProvidesContacts: 0
105:   m_Enabled: 1
106:   serializedVersion: 3
107:   m_Radius: 0.5
108:   m_Center: {x: 0, y: 0, z: 0}
109: --- !u!114 &3328155227325760353
110: MonoBehaviour:
111:   m_ObjectHideFlags: 0
112:   m_CorrespondingSourceObject: {fileID: 0}
113:   m_PrefabInstance: {fileID: 0}
114:   m_PrefabAsset: {fileID: 0}
115:   m_GameObject: {fileID: 6581710663154360527}
116:   m_Enabled: 1
117:   m_EditorHideFlags: 0
118:   m_Script: {fileID: 11500000, guid: 301479c94ebc9b94b83d3737cc30dfc6, type: 3}
119:   m_Name: 
120:   m_EditorClassIdentifier:
```

## File: Assets/_Prefabs/Enemy.prefab
```
  1: %YAML 1.1
  2: %TAG !u! tag:unity3d.com,2011:
  3: --- !u!1001 &7088088575083348349
  4: PrefabInstance:
  5:   m_ObjectHideFlags: 0
  6:   serializedVersion: 2
  7:   m_Modification:
  8:     serializedVersion: 3
  9:     m_TransformParent: {fileID: 0}
 10:     m_Modifications:
 11:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
 12:       propertyPath: m_LocalPosition.x
 13:       value: -4.109
 14:       objectReference: {fileID: 0}
 15:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
 16:       propertyPath: m_LocalPosition.y
 17:       value: 0
 18:       objectReference: {fileID: 0}
 19:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
 20:       propertyPath: m_LocalPosition.z
 21:       value: 53.447
 22:       objectReference: {fileID: 0}
 23:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
 24:       propertyPath: m_LocalRotation.w
 25:       value: 1
 26:       objectReference: {fileID: 0}
 27:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
 28:       propertyPath: m_LocalRotation.x
 29:       value: -0
 30:       objectReference: {fileID: 0}
 31:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
 32:       propertyPath: m_LocalRotation.y
 33:       value: -0
 34:       objectReference: {fileID: 0}
 35:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
 36:       propertyPath: m_LocalRotation.z
 37:       value: -0
 38:       objectReference: {fileID: 0}
 39:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
 40:       propertyPath: m_LocalEulerAnglesHint.x
 41:       value: 0
 42:       objectReference: {fileID: 0}
 43:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
 44:       propertyPath: m_LocalEulerAnglesHint.y
 45:       value: 0
 46:       objectReference: {fileID: 0}
 47:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
 48:       propertyPath: m_LocalEulerAnglesHint.z
 49:       value: 0
 50:       objectReference: {fileID: 0}
 51:     - target: {fileID: 919132149155446097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
 52:       propertyPath: m_Name
 53:       value: Enemy
 54:       objectReference: {fileID: 0}
 55:     - target: {fileID: 919132149155446097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
 56:       propertyPath: m_IsActive
 57:       value: 1
 58:       objectReference: {fileID: 0}
 59:     - target: {fileID: 919132149155446097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
 60:       propertyPath: m_TagString
 61:       value: Enemy
 62:       objectReference: {fileID: 0}
 63:     m_RemovedComponents: []
 64:     m_RemovedGameObjects: []
 65:     m_AddedGameObjects: []
 66:     m_AddedComponents:
 67:     - targetCorrespondingSourceObject: {fileID: 919132149155446097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
 68:       insertIndex: -1
 69:       addedObject: {fileID: 2615043736948651687}
 70:     - targetCorrespondingSourceObject: {fileID: 919132149155446097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
 71:       insertIndex: -1
 72:       addedObject: {fileID: 2612415832202737399}
 73:     - targetCorrespondingSourceObject: {fileID: 919132149155446097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
 74:       insertIndex: -1
 75:       addedObject: {fileID: 4914915909814060501}
 76:     - targetCorrespondingSourceObject: {fileID: 919132149155446097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
 77:       insertIndex: -1
 78:       addedObject: {fileID: 7231933622615544930}
 79:   m_SourcePrefab: {fileID: 100100000, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
 80: --- !u!1 &7970415662211546156 stripped
 81: GameObject:
 82:   m_CorrespondingSourceObject: {fileID: 919132149155446097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
 83:   m_PrefabInstance: {fileID: 7088088575083348349}
 84:   m_PrefabAsset: {fileID: 0}
 85: --- !u!65 &2615043736948651687
 86: BoxCollider:
 87:   m_ObjectHideFlags: 0
 88:   m_CorrespondingSourceObject: {fileID: 0}
 89:   m_PrefabInstance: {fileID: 0}
 90:   m_PrefabAsset: {fileID: 0}
 91:   m_GameObject: {fileID: 7970415662211546156}
 92:   m_Material: {fileID: 0}
 93:   m_IncludeLayers:
 94:     serializedVersion: 2
 95:     m_Bits: 0
 96:   m_ExcludeLayers:
 97:     serializedVersion: 2
 98:     m_Bits: 0
 99:   m_LayerOverridePriority: 0
100:   m_IsTrigger: 0
101:   m_ProvidesContacts: 0
102:   m_Enabled: 1
103:   serializedVersion: 3
104:   m_Size: {x: 0.5488589, y: 2.299346, z: 0.4077034}
105:   m_Center: {x: -0.007159114, y: 0.64967275, z: 0.061998367}
106: --- !u!195 &2612415832202737399
107: NavMeshAgent:
108:   m_ObjectHideFlags: 0
109:   m_CorrespondingSourceObject: {fileID: 0}
110:   m_PrefabInstance: {fileID: 0}
111:   m_PrefabAsset: {fileID: 0}
112:   m_GameObject: {fileID: 7970415662211546156}
113:   m_Enabled: 1
114:   m_AgentTypeID: 0
115:   m_Radius: 0.5
116:   m_Speed: 3.5
117:   m_Acceleration: 100
118:   avoidancePriority: 50
119:   m_AngularSpeed: 1000
120:   m_StoppingDistance: 0
121:   m_AutoTraverseOffMeshLink: 1
122:   m_AutoBraking: 1
123:   m_AutoRepath: 1
124:   m_Height: 2
125:   m_BaseOffset: 0
126:   m_WalkableMask: 4294967295
127:   m_ObstacleAvoidanceType: 4
128: --- !u!95 &4914915909814060501
129: Animator:
130:   serializedVersion: 5
131:   m_ObjectHideFlags: 0
132:   m_CorrespondingSourceObject: {fileID: 0}
133:   m_PrefabInstance: {fileID: 0}
134:   m_PrefabAsset: {fileID: 0}
135:   m_GameObject: {fileID: 7970415662211546156}
136:   m_Enabled: 1
137:   m_Avatar: {fileID: 0}
138:   m_Controller: {fileID: 9100000, guid: 3dd4fcdb2d2f0b14e982a89f9a63de82, type: 2}
139:   m_CullingMode: 0
140:   m_UpdateMode: 0
141:   m_ApplyRootMotion: 0
142:   m_LinearVelocityBlending: 0
143:   m_StabilizeFeet: 0
144:   m_WarningMessage: 
145:   m_HasTransformHierarchy: 1
146:   m_AllowConstantClipSamplingOptimization: 1
147:   m_KeepAnimatorStateOnDisable: 0
148:   m_WriteDefaultValuesOnDisable: 0
149: --- !u!114 &7231933622615544930
150: MonoBehaviour:
151:   m_ObjectHideFlags: 0
152:   m_CorrespondingSourceObject: {fileID: 0}
153:   m_PrefabInstance: {fileID: 0}
154:   m_PrefabAsset: {fileID: 0}
155:   m_GameObject: {fileID: 7970415662211546156}
156:   m_Enabled: 1
157:   m_EditorHideFlags: 0
158:   m_Script: {fileID: 11500000, guid: ebfe7a3033684df43958dfe6f0af4a44, type: 3}
159:   m_Name: 
160:   m_EditorClassIdentifier: 
161:   radioDeVision: 10
162:   radioDeambulacion: 15
163:   tiempoDeEspera: 3
164:   run: 3
165:   walk: 1.5
166:   jugador: {fileID: 0}
167:   walkUp: 0
```

## File: Assets/_Prefabs/FrendlyIA.prefab
```
  1: %YAML 1.1
  2: %TAG !u! tag:unity3d.com,2011:
  3: --- !u!1 &7341014215371503948
  4: GameObject:
  5:   m_ObjectHideFlags: 0
  6:   m_CorrespondingSourceObject: {fileID: 0}
  7:   m_PrefabInstance: {fileID: 0}
  8:   m_PrefabAsset: {fileID: 0}
  9:   serializedVersion: 6
 10:   m_Component:
 11:   - component: {fileID: 2064921176888031817}
 12:   - component: {fileID: 6069345651069871012}
 13:   - component: {fileID: 2591311939023639487}
 14:   - component: {fileID: 3075259717581036377}
 15:   - component: {fileID: 6925340559930982747}
 16:   - component: {fileID: 5837457887524617967}
 17:   m_Layer: 0
 18:   m_Name: FrendlyIA
 19:   m_TagString: Untagged
 20:   m_Icon: {fileID: 0}
 21:   m_NavMeshLayer: 0
 22:   m_StaticEditorFlags: 0
 23:   m_IsActive: 1
 24: --- !u!4 &2064921176888031817
 25: Transform:
 26:   m_ObjectHideFlags: 0
 27:   m_CorrespondingSourceObject: {fileID: 0}
 28:   m_PrefabInstance: {fileID: 0}
 29:   m_PrefabAsset: {fileID: 0}
 30:   m_GameObject: {fileID: 7341014215371503948}
 31:   serializedVersion: 2
 32:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
 33:   m_LocalPosition: {x: -0.16, y: 0.5, z: 8.69}
 34:   m_LocalScale: {x: 1, y: 1, z: 1}
 35:   m_ConstrainProportionsScale: 0
 36:   m_Children: []
 37:   m_Father: {fileID: 0}
 38:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 39: --- !u!33 &6069345651069871012
 40: MeshFilter:
 41:   m_ObjectHideFlags: 0
 42:   m_CorrespondingSourceObject: {fileID: 0}
 43:   m_PrefabInstance: {fileID: 0}
 44:   m_PrefabAsset: {fileID: 0}
 45:   m_GameObject: {fileID: 7341014215371503948}
 46:   m_Mesh: {fileID: 10207, guid: 0000000000000000e000000000000000, type: 0}
 47: --- !u!23 &2591311939023639487
 48: MeshRenderer:
 49:   m_ObjectHideFlags: 0
 50:   m_CorrespondingSourceObject: {fileID: 0}
 51:   m_PrefabInstance: {fileID: 0}
 52:   m_PrefabAsset: {fileID: 0}
 53:   m_GameObject: {fileID: 7341014215371503948}
 54:   m_Enabled: 1
 55:   m_CastShadows: 1
 56:   m_ReceiveShadows: 1
 57:   m_DynamicOccludee: 1
 58:   m_StaticShadowCaster: 0
 59:   m_MotionVectors: 1
 60:   m_LightProbeUsage: 1
 61:   m_ReflectionProbeUsage: 1
 62:   m_RayTracingMode: 2
 63:   m_RayTraceProcedural: 0
 64:   m_RenderingLayerMask: 1
 65:   m_RendererPriority: 0
 66:   m_Materials:
 67:   - {fileID: 10303, guid: 0000000000000000f000000000000000, type: 0}
 68:   m_StaticBatchInfo:
 69:     firstSubMesh: 0
 70:     subMeshCount: 0
 71:   m_StaticBatchRoot: {fileID: 0}
 72:   m_ProbeAnchor: {fileID: 0}
 73:   m_LightProbeVolumeOverride: {fileID: 0}
 74:   m_ScaleInLightmap: 1
 75:   m_ReceiveGI: 1
 76:   m_PreserveUVs: 0
 77:   m_IgnoreNormalsForChartDetection: 0
 78:   m_ImportantGI: 0
 79:   m_StitchLightmapSeams: 1
 80:   m_SelectedEditorRenderState: 3
 81:   m_MinimumChartSize: 4
 82:   m_AutoUVMaxDistance: 0.5
 83:   m_AutoUVMaxAngle: 89
 84:   m_LightmapParameters: {fileID: 0}
 85:   m_SortingLayerID: 0
 86:   m_SortingLayer: 0
 87:   m_SortingOrder: 0
 88:   m_AdditionalVertexStreams: {fileID: 0}
 89: --- !u!135 &3075259717581036377
 90: SphereCollider:
 91:   m_ObjectHideFlags: 0
 92:   m_CorrespondingSourceObject: {fileID: 0}
 93:   m_PrefabInstance: {fileID: 0}
 94:   m_PrefabAsset: {fileID: 0}
 95:   m_GameObject: {fileID: 7341014215371503948}
 96:   m_Material: {fileID: 0}
 97:   m_IncludeLayers:
 98:     serializedVersion: 2
 99:     m_Bits: 0
100:   m_ExcludeLayers:
101:     serializedVersion: 2
102:     m_Bits: 0
103:   m_LayerOverridePriority: 0
104:   m_IsTrigger: 0
105:   m_ProvidesContacts: 0
106:   m_Enabled: 1
107:   serializedVersion: 3
108:   m_Radius: 0.5
109:   m_Center: {x: 0, y: 0, z: 0}
110: --- !u!114 &6925340559930982747
111: MonoBehaviour:
112:   m_ObjectHideFlags: 0
113:   m_CorrespondingSourceObject: {fileID: 0}
114:   m_PrefabInstance: {fileID: 0}
115:   m_PrefabAsset: {fileID: 0}
116:   m_GameObject: {fileID: 7341014215371503948}
117:   m_Enabled: 1
118:   m_EditorHideFlags: 0
119:   m_Script: {fileID: 11500000, guid: b775f636f25d26a42b2a2c4237d2f522, type: 3}
120:   m_Name: 
121:   m_EditorClassIdentifier: 
122:   tiempodeEspera: 60
123:   timer: 0
124:   speed: 3.5
125:   visionRate: 0
126:   wayPoints:
127:   - {x: 0.352, y: 0.5, z: 29.93}
128:   - {x: 21.54, y: 0.5, z: 58.18}
129:   - {x: -12.95, y: 0.5, z: 2.028}
130:   arrayVector: 0
131:   advance: 0
132:   tipPlayer: 1
133:   hitCount: 0
134: --- !u!195 &5837457887524617967
135: NavMeshAgent:
136:   m_ObjectHideFlags: 0
137:   m_CorrespondingSourceObject: {fileID: 0}
138:   m_PrefabInstance: {fileID: 0}
139:   m_PrefabAsset: {fileID: 0}
140:   m_GameObject: {fileID: 7341014215371503948}
141:   m_Enabled: 1
142:   m_AgentTypeID: 0
143:   m_Radius: 0.5
144:   m_Speed: 3.5
145:   m_Acceleration: 8
146:   avoidancePriority: 50
147:   m_AngularSpeed: 120
148:   m_StoppingDistance: 0
149:   m_AutoTraverseOffMeshLink: 1
150:   m_AutoBraking: 1
151:   m_AutoRepath: 1
152:   m_Height: 1
153:   m_BaseOffset: 0.5
154:   m_WalkableMask: 4294967295
155:   m_ObstacleAvoidanceType: 4
```

## File: Assets/_Prefabs/Player.prefab
```
  1: %YAML 1.1
  2: %TAG !u! tag:unity3d.com,2011:
  3: --- !u!1 &8260136191585198760
  4: GameObject:
  5:   m_ObjectHideFlags: 0
  6:   m_CorrespondingSourceObject: {fileID: 0}
  7:   m_PrefabInstance: {fileID: 0}
  8:   m_PrefabAsset: {fileID: 0}
  9:   serializedVersion: 6
 10:   m_Component:
 11:   - component: {fileID: 5253399263103901075}
 12:   - component: {fileID: 3564567411758254664}
 13:   - component: {fileID: 2688415263458499983}
 14:   - component: {fileID: 4417598326044713262}
 15:   - component: {fileID: 8361438473689559574}
 16:   - component: {fileID: 9024728203277959396}
 17:   - component: {fileID: 7221942978824191027}
 18:   m_Layer: 0
 19:   m_Name: Player
 20:   m_TagString: Player
 21:   m_Icon: {fileID: 0}
 22:   m_NavMeshLayer: 0
 23:   m_StaticEditorFlags: 0
 24:   m_IsActive: 1
 25: --- !u!4 &5253399263103901075
 26: Transform:
 27:   m_ObjectHideFlags: 0
 28:   m_CorrespondingSourceObject: {fileID: 0}
 29:   m_PrefabInstance: {fileID: 0}
 30:   m_PrefabAsset: {fileID: 0}
 31:   m_GameObject: {fileID: 8260136191585198760}
 32:   serializedVersion: 2
 33:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
 34:   m_LocalPosition: {x: 0, y: 1, z: 1.92}
 35:   m_LocalScale: {x: 1, y: 1, z: 1}
 36:   m_ConstrainProportionsScale: 0
 37:   m_Children: []
 38:   m_Father: {fileID: 0}
 39:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 40: --- !u!33 &3564567411758254664
 41: MeshFilter:
 42:   m_ObjectHideFlags: 0
 43:   m_CorrespondingSourceObject: {fileID: 0}
 44:   m_PrefabInstance: {fileID: 0}
 45:   m_PrefabAsset: {fileID: 0}
 46:   m_GameObject: {fileID: 8260136191585198760}
 47:   m_Mesh: {fileID: 10208, guid: 0000000000000000e000000000000000, type: 0}
 48: --- !u!23 &2688415263458499983
 49: MeshRenderer:
 50:   m_ObjectHideFlags: 0
 51:   m_CorrespondingSourceObject: {fileID: 0}
 52:   m_PrefabInstance: {fileID: 0}
 53:   m_PrefabAsset: {fileID: 0}
 54:   m_GameObject: {fileID: 8260136191585198760}
 55:   m_Enabled: 1
 56:   m_CastShadows: 1
 57:   m_ReceiveShadows: 1
 58:   m_DynamicOccludee: 1
 59:   m_StaticShadowCaster: 0
 60:   m_MotionVectors: 1
 61:   m_LightProbeUsage: 1
 62:   m_ReflectionProbeUsage: 1
 63:   m_RayTracingMode: 2
 64:   m_RayTraceProcedural: 0
 65:   m_RenderingLayerMask: 1
 66:   m_RendererPriority: 0
 67:   m_Materials:
 68:   - {fileID: 10303, guid: 0000000000000000f000000000000000, type: 0}
 69:   m_StaticBatchInfo:
 70:     firstSubMesh: 0
 71:     subMeshCount: 0
 72:   m_StaticBatchRoot: {fileID: 0}
 73:   m_ProbeAnchor: {fileID: 0}
 74:   m_LightProbeVolumeOverride: {fileID: 0}
 75:   m_ScaleInLightmap: 1
 76:   m_ReceiveGI: 1
 77:   m_PreserveUVs: 0
 78:   m_IgnoreNormalsForChartDetection: 0
 79:   m_ImportantGI: 0
 80:   m_StitchLightmapSeams: 1
 81:   m_SelectedEditorRenderState: 3
 82:   m_MinimumChartSize: 4
 83:   m_AutoUVMaxDistance: 0.5
 84:   m_AutoUVMaxAngle: 89
 85:   m_LightmapParameters: {fileID: 0}
 86:   m_SortingLayerID: 0
 87:   m_SortingLayer: 0
 88:   m_SortingOrder: 0
 89:   m_AdditionalVertexStreams: {fileID: 0}
 90: --- !u!136 &4417598326044713262
 91: CapsuleCollider:
 92:   m_ObjectHideFlags: 0
 93:   m_CorrespondingSourceObject: {fileID: 0}
 94:   m_PrefabInstance: {fileID: 0}
 95:   m_PrefabAsset: {fileID: 0}
 96:   m_GameObject: {fileID: 8260136191585198760}
 97:   m_Material: {fileID: 13400000, guid: a5f6016dd69f60e49b7414ff9467d5b0, type: 2}
 98:   m_IncludeLayers:
 99:     serializedVersion: 2
100:     m_Bits: 0
101:   m_ExcludeLayers:
102:     serializedVersion: 2
103:     m_Bits: 0
104:   m_LayerOverridePriority: 0
105:   m_IsTrigger: 0
106:   m_ProvidesContacts: 0
107:   m_Enabled: 1
108:   serializedVersion: 2
109:   m_Radius: 0.5
110:   m_Height: 2
111:   m_Direction: 1
112:   m_Center: {x: 0, y: 0, z: 0}
113: --- !u!54 &8361438473689559574
114: Rigidbody:
115:   m_ObjectHideFlags: 0
116:   m_CorrespondingSourceObject: {fileID: 0}
117:   m_PrefabInstance: {fileID: 0}
118:   m_PrefabAsset: {fileID: 0}
119:   m_GameObject: {fileID: 8260136191585198760}
120:   serializedVersion: 4
121:   m_Mass: 1
122:   m_Drag: 0
123:   m_AngularDrag: 0.05
124:   m_CenterOfMass: {x: 0, y: 0, z: 0}
125:   m_InertiaTensor: {x: 1, y: 1, z: 1}
126:   m_InertiaRotation: {x: 0, y: 0, z: 0, w: 1}
127:   m_IncludeLayers:
128:     serializedVersion: 2
129:     m_Bits: 0
130:   m_ExcludeLayers:
131:     serializedVersion: 2
132:     m_Bits: 0
133:   m_ImplicitCom: 1
134:   m_ImplicitTensor: 1
135:   m_UseGravity: 1
136:   m_IsKinematic: 0
137:   m_Interpolate: 0
138:   m_Constraints: 116
139:   m_CollisionDetection: 0
140: --- !u!114 &9024728203277959396
141: MonoBehaviour:
142:   m_ObjectHideFlags: 0
143:   m_CorrespondingSourceObject: {fileID: 0}
144:   m_PrefabInstance: {fileID: 0}
145:   m_PrefabAsset: {fileID: 0}
146:   m_GameObject: {fileID: 8260136191585198760}
147:   m_Enabled: 1
148:   m_EditorHideFlags: 0
149:   m_Script: {fileID: 11500000, guid: 5488aaca5d5887e4b8fa44a5684df54d, type: 3}
150:   m_Name: 
151:   m_EditorClassIdentifier: 
152:   suavizadoAnimacion: 0.1
153:   speed: 5
154:   velocidad: 0
155:   GameOver: 0
156:   safeZone: 0
157:   gameManager: {fileID: 0}
158: --- !u!114 &7221942978824191027
159: MonoBehaviour:
160:   m_ObjectHideFlags: 0
161:   m_CorrespondingSourceObject: {fileID: 0}
162:   m_PrefabInstance: {fileID: 0}
163:   m_PrefabAsset: {fileID: 0}
164:   m_GameObject: {fileID: 8260136191585198760}
165:   m_Enabled: 1
166:   m_EditorHideFlags: 0
167:   m_Script: {fileID: 11500000, guid: 62899f850307741f2a39c98a8b639597, type: 3}
168:   m_Name: 
169:   m_EditorClassIdentifier: 
170:   m_Actions: {fileID: -944628639613478452, guid: 61918e08ac444e14cbca19e224d7d22e, type: 3}
171:   m_NotificationBehavior: 0
172:   m_UIInputModule: {fileID: 0}
173:   m_DeviceLostEvent:
174:     m_PersistentCalls:
175:       m_Calls: []
176:   m_DeviceRegainedEvent:
177:     m_PersistentCalls:
178:       m_Calls: []
179:   m_ControlsChangedEvent:
180:     m_PersistentCalls:
181:       m_Calls: []
182:   m_ActionEvents: []
183:   m_NeverAutoSwitchControlSchemes: 0
184:   m_DefaultControlScheme: 
185:   m_DefaultActionMap: Player
186:   m_SplitScreenIndex: -1
187:   m_Camera: {fileID: 0}
```

## File: Assets/_Prefabs/rust_key.prefab
```
  1: %YAML 1.1
  2: %TAG !u! tag:unity3d.com,2011:
  3: --- !u!1 &374289202576707483
  4: GameObject:
  5:   m_ObjectHideFlags: 0
  6:   m_CorrespondingSourceObject: {fileID: 0}
  7:   m_PrefabInstance: {fileID: 0}
  8:   m_PrefabAsset: {fileID: 0}
  9:   serializedVersion: 6
 10:   m_Component:
 11:   - component: {fileID: 3705028537381535112}
 12:   - component: {fileID: 5634532462982891454}
 13:   - component: {fileID: 2093443782267337543}
 14:   - component: {fileID: 6631988124095103977}
 15:   - component: {fileID: -642851322603558153}
 16:   - component: {fileID: -1949477286263078370}
 17:   m_Layer: 0
 18:   m_Name: rust_key
 19:   m_TagString: score
 20:   m_Icon: {fileID: 0}
 21:   m_NavMeshLayer: 0
 22:   m_StaticEditorFlags: 0
 23:   m_IsActive: 1
 24: --- !u!4 &3705028537381535112
 25: Transform:
 26:   m_ObjectHideFlags: 0
 27:   m_CorrespondingSourceObject: {fileID: 0}
 28:   m_PrefabInstance: {fileID: 0}
 29:   m_PrefabAsset: {fileID: 0}
 30:   m_GameObject: {fileID: 374289202576707483}
 31:   serializedVersion: 2
 32:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
 33:   m_LocalPosition: {x: 0, y: 0, z: 0}
 34:   m_LocalScale: {x: 5, y: 5, z: 5}
 35:   m_ConstrainProportionsScale: 1
 36:   m_Children: []
 37:   m_Father: {fileID: 0}
 38:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 39: --- !u!33 &5634532462982891454
 40: MeshFilter:
 41:   m_ObjectHideFlags: 0
 42:   m_CorrespondingSourceObject: {fileID: 0}
 43:   m_PrefabInstance: {fileID: 0}
 44:   m_PrefabAsset: {fileID: 0}
 45:   m_GameObject: {fileID: 374289202576707483}
 46:   m_Mesh: {fileID: -1215533875317036940, guid: 0669f3d8f4b119f418a4bbe061cc198f, type: 3}
 47: --- !u!23 &2093443782267337543
 48: MeshRenderer:
 49:   m_ObjectHideFlags: 0
 50:   m_CorrespondingSourceObject: {fileID: 0}
 51:   m_PrefabInstance: {fileID: 0}
 52:   m_PrefabAsset: {fileID: 0}
 53:   m_GameObject: {fileID: 374289202576707483}
 54:   m_Enabled: 1
 55:   m_CastShadows: 1
 56:   m_ReceiveShadows: 1
 57:   m_DynamicOccludee: 1
 58:   m_StaticShadowCaster: 0
 59:   m_MotionVectors: 1
 60:   m_LightProbeUsage: 1
 61:   m_ReflectionProbeUsage: 1
 62:   m_RayTracingMode: 2
 63:   m_RayTraceProcedural: 0
 64:   m_RenderingLayerMask: 1
 65:   m_RendererPriority: 0
 66:   m_Materials:
 67:   - {fileID: 2100000, guid: 1a7c6b13b8983fa4bbfb1dbfbb5fef57, type: 2}
 68:   m_StaticBatchInfo:
 69:     firstSubMesh: 0
 70:     subMeshCount: 0
 71:   m_StaticBatchRoot: {fileID: 0}
 72:   m_ProbeAnchor: {fileID: 0}
 73:   m_LightProbeVolumeOverride: {fileID: 0}
 74:   m_ScaleInLightmap: 1
 75:   m_ReceiveGI: 1
 76:   m_PreserveUVs: 0
 77:   m_IgnoreNormalsForChartDetection: 0
 78:   m_ImportantGI: 0
 79:   m_StitchLightmapSeams: 1
 80:   m_SelectedEditorRenderState: 3
 81:   m_MinimumChartSize: 4
 82:   m_AutoUVMaxDistance: 0.5
 83:   m_AutoUVMaxAngle: 89
 84:   m_LightmapParameters: {fileID: 0}
 85:   m_SortingLayerID: 0
 86:   m_SortingLayer: 0
 87:   m_SortingOrder: 0
 88:   m_AdditionalVertexStreams: {fileID: 0}
 89: --- !u!65 &6631988124095103977
 90: BoxCollider:
 91:   m_ObjectHideFlags: 0
 92:   m_CorrespondingSourceObject: {fileID: 0}
 93:   m_PrefabInstance: {fileID: 0}
 94:   m_PrefabAsset: {fileID: 0}
 95:   m_GameObject: {fileID: 374289202576707483}
 96:   m_Material: {fileID: 0}
 97:   m_IncludeLayers:
 98:     serializedVersion: 2
 99:     m_Bits: 0
100:   m_ExcludeLayers:
101:     serializedVersion: 2
102:     m_Bits: 0
103:   m_LayerOverridePriority: 0
104:   m_IsTrigger: 0
105:   m_ProvidesContacts: 0
106:   m_Enabled: 1
107:   serializedVersion: 3
108:   m_Size: {x: 0.12193201, y: 0.039105866, z: 0.23262411}
109:   m_Center: {x: 0, y: -9.313228e-10, z: 0.000000003725291}
110: --- !u!54 &-642851322603558153
111: Rigidbody:
112:   m_ObjectHideFlags: 0
113:   m_CorrespondingSourceObject: {fileID: 0}
114:   m_PrefabInstance: {fileID: 0}
115:   m_PrefabAsset: {fileID: 0}
116:   m_GameObject: {fileID: 374289202576707483}
117:   serializedVersion: 4
118:   m_Mass: 10
119:   m_Drag: 0
120:   m_AngularDrag: 0.05
121:   m_CenterOfMass: {x: 0, y: 0, z: 0}
122:   m_InertiaTensor: {x: 1, y: 1, z: 1}
123:   m_InertiaRotation: {x: 0, y: 0, z: 0, w: 1}
124:   m_IncludeLayers:
125:     serializedVersion: 2
126:     m_Bits: 0
127:   m_ExcludeLayers:
128:     serializedVersion: 2
129:     m_Bits: 0
130:   m_ImplicitCom: 1
131:   m_ImplicitTensor: 1
132:   m_UseGravity: 1
133:   m_IsKinematic: 0
134:   m_Interpolate: 0
135:   m_Constraints: 58
136:   m_CollisionDetection: 0
137: --- !u!114 &-1949477286263078370
138: MonoBehaviour:
139:   m_ObjectHideFlags: 0
140:   m_CorrespondingSourceObject: {fileID: 0}
141:   m_PrefabInstance: {fileID: 0}
142:   m_PrefabAsset: {fileID: 0}
143:   m_GameObject: {fileID: 374289202576707483}
144:   m_Enabled: 1
145:   m_EditorHideFlags: 0
146:   m_Script: {fileID: 11500000, guid: 301479c94ebc9b94b83d3737cc30dfc6, type: 3}
147:   m_Name: 
148:   m_EditorClassIdentifier:
```

## File: Assets/_Scripts/CameraController.cs
```csharp
 1: using System.Collections;
 2: using System.Collections.Generic;
 3: using UnityEngine;
 4: using UnityEngine.InputSystem;
 5: 
 6: public class CameraController : MonoBehaviour
 7: {   public PlayerController playerController; // Referencia al PlayerController para verificar el estado del juego
 8:     private Vector2 inputMove; // Variable para almacenar la entrada del mouse
 9:     public Transform player; // Referencia al transform del jugador para rotarlo horizontalmente
10:     public float sensibylity; // Variable para ajustar la sensibilidad del mouse, configurable desde el inspector
11:     private float rotationVertical = 0;
12:     void Start()
13:     {
14:         // Obtiene la referencia al PlayerController buscando el objeto con el nombre "Player" en la escena y accediendo a su componente PlayerController
15:         playerController = GameObject.Find("Player").GetComponent<PlayerController>();
16:         Cursor.lockState = CursorLockMode.Locked; // Bloqueamos el cursor para que no se vea ni se mueva fuera de la ventana del juego
17:         Cursor.visible = false; // Hacemos invisible el cursor para que no distraiga durante el juego
18:     }
19:     void Update()
20:     {
21:         // Solo permite mover la cámara si el juego no ha terminado, evitando que el jugador pueda seguir moviendo la cámara después de ganar o perder
22:         if (playerController.GameOver == false) 
23:             MoveMouse(); // Llama al método para mover la cámara basado en la entrada del mouse
24:     }
25:     // Método para recibir la entrada del mouse, se llama automáticamente al mover el mouse según lo configurado en el Input System
26:     public void OnCamera(InputValue value) 
27:     {
28:         inputMove = value.Get<Vector2>(); // Almacena la entrada del mouse en la variable inputMove, que se utilizará para mover la cámara en el método MoveMouse
29:     }
30:     // Método para mover la cámara basado en la entrada del mouse, ajustando la sensibilidad y el tiempo para que el movimiento sea suave y consistente
31:     void MoveMouse()
32:     {
33:         // Calcula el movimiento horizontal y vertical multiplicando la entrada del mouse por la sensibilidad y el tiempo delta para que el movimiento sea suave y consistente
34:         float MoveX = inputMove.x * sensibylity * Time.deltaTime;
35:         float MoveY = inputMove.y * sensibylity * Time.deltaTime;
36:         // Rota la cámara verticalmente restando el movimiento vertical al ángulo de rotación vertical, y luego clampa ese ángulo para evitar que la cámara gire demasiado hacia arriba o hacia abajo
37:         rotationVertical -= MoveY;
38:         // Clampa el ángulo de rotación vertical entre -60 y 60 grados para evitar que la cámara gire demasiado hacia arriba o hacia abajo, lo que podría resultar incómodo para el jugador
39:         rotationVertical = Mathf.Clamp(rotationVertical, -60, 60);
40:         // Aplica la rotación vertical a la cámara utilizando un quaternion que representa una rotación en el eje X, lo que permite que la cámara gire hacia arriba y hacia abajo sin afectar la rotación horizontal del jugador
41:         transform.localRotation = Quaternion.Euler(rotationVertical, 0f, 0f);
42:         // Rota el jugador horizontalmente multiplicando el movimiento horizontal por un vector que representa la rotación en el eje Y, lo que permite que el jugador gire hacia los lados sin afectar la rotación vertical de la cámara
43:         player.Rotate(Vector3.up * MoveX);
44:         
45:             
46:         
47:     }
48: }
```

## File: Assets/_Scripts/IntermitentL.cs
```csharp
 1: using System.Collections;
 2: using System.Collections.Generic;
 3: using UnityEngine;
 4: 
 5: public class IntermitentL : MonoBehaviour
 6: {
 7:     private Light luz; // Variable para almacenar la referencia al componente Light de la luz que se va a parpadear
 8:     public float esperaMinima = 0.05f; // Tiempo mínimo apagada/encendida
 9:     public float esperaMaxima = 0.2f;  // Tiempo máximo apagada/encendida
10: 
11:     void Start()
12:     {
13:         // Obtiene la referencia al componente Light de la luz utilizando el método GetComponent, lo que permite controlar su estado (encendida o apagada) para crear el efecto de parpadeo
14:         luz = GetComponent<Light>();
15:         // Inicia la corrutina que controla el ciclo de parpadeo de la luz, lo que permite que la luz cambie de estado (encendida o apagada) de manera aleatoria para crear un efecto de parpadeo más natural y menos predecible
16:         StartCoroutine(CicloParpadeo());
17:     }
18:     // Corrutina que controla el ciclo de parpadeo de la luz, alternando su estado (encendida o apagada) y esperando un tiempo aleatorio entre cada cambio de estado para crear un efecto de parpadeo más natural y menos predecible
19:     IEnumerator CicloParpadeo()
20:     {
21:         while (true) // Bucle infinito
22:         {
23:             // Cambia el estado (si está encendida, la apaga; si está apagada, la enciende)
24:             luz.enabled = !luz.enabled;
25:             
26:             // Espera un tiempo aleatorio para que el parpadeo no sea rítmico
27:             float tiempoAleatorio = Random.Range(esperaMinima, esperaMaxima);
28:             yield return new WaitForSeconds(tiempoAleatorio);
29:         }
30:     }
31: }
```

## File: Assets/_Scripts/Objects.cs
```csharp
 1: using System.Collections;
 2: using System.Collections.Generic;
 3: using UnityEngine;
 4: 
 5: public class Objects : MonoBehaviour
 6: {
 7:     Rigidbody rb; // Variable para almacenar la referencia al componente Rigidbody del objeto, que se utilizará para aplicar fuerzas y detectar colisiones
 8:     private GameManager gameManager; // Variable para almacenar la referencia al GameManager, que se utilizará para actualizar el puntaje del jugador al recoger el objeto
 9:     void Start()
10:     {
11:         // Obtiene la referencia al componente Rigidbody del objeto utilizando el método GetComponent, lo que permite aplicar fuerzas y detectar colisiones con otros objetos en la escena
12:         rb = GetComponent<Rigidbody>();
13:         // Obtiene la referencia al GameManager buscando el objeto con el nombre "Game Manager" en la escena y accediendo a su componente GameManager, lo que permite actualizar el puntaje del jugador al recoger el objeto
14:         gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>(); 
15:     }
16:     void Update()
17:     {
18:         // Rota el objeto constantemente alrededor del eje Z (Vector3.forward) a una velocidad de 40 grados por segundo multiplicada por el tiempo delta para que la rotación sea suave y consistente, lo que hace que el objeto sea más visible y atractivo para el jugador
19:         transform.Rotate(Vector3.forward * 40f * Time.deltaTime);
20:     }
21:     public void OnCollisionEnter(Collision collision)
22:     {
23:         // Si el objeto colisiona con el jugador, se actualiza el puntaje del jugador sumando 1 al contador de objetos recogidos en el GameManager y se destruye el objeto para simular que ha sido recogido
24:         if (collision.collider.CompareTag("Player"))
25:         {
26:             // Llama al método UpdateScore del GameManager para sumar 1 al contador de objetos recogidos, lo que permite llevar la cuenta de cuántos objetos ha recogido el jugador
27:             gameManager.UpdateScore(1);
28:             Destroy(gameObject);
29:         }
30:         // Si el objeto colisiona con el suelo, se aplica una fuerza hacia arriba utilizando el método AddForce del Rigidbody para simular un rebote, lo que hace que el objeto sea más dinámico y atractivo para el jugador
31:         if (collision.collider.CompareTag("Floor"))
32:         {
33:             // Aplica una fuerza hacia arriba multiplicando el vector Vector3.up por un valor de 40f para determinar la intensidad del rebote, y utilizando el modo de fuerza ForceMode.Impulse para aplicar la fuerza de manera instantánea, lo que hace que el objeto rebote de manera realista al colisionar con el suelo
34:             rb.AddForce(Vector3.up * 40f, ForceMode.Impulse);
35:         }
36:     }
37: }
```

## File: Assets/PlayerControllerInput.inputactions
```
  1: {
  2:     "version": 1,
  3:     "name": "PlayerControllerInput",
  4:     "maps": [
  5:         {
  6:             "name": "Player",
  7:             "id": "b1c30160-170c-4ce4-beea-82a6956b8f96",
  8:             "actions": [
  9:                 {
 10:                     "name": "move",
 11:                     "type": "Value",
 12:                     "id": "3556ade6-3575-4c57-8d1d-b160839c913f",
 13:                     "expectedControlType": "Vector2",
 14:                     "processors": "",
 15:                     "interactions": "",
 16:                     "initialStateCheck": true
 17:                 },
 18:                 {
 19:                     "name": "sprint",
 20:                     "type": "Value",
 21:                     "id": "75ccc69c-1bf6-43db-9f55-87e77bc43f3b",
 22:                     "expectedControlType": "Vector2",
 23:                     "processors": "",
 24:                     "interactions": "",
 25:                     "initialStateCheck": true
 26:                 },
 27:                 {
 28:                     "name": "camera",
 29:                     "type": "Value",
 30:                     "id": "be68993c-9671-480c-bb85-8137a41ba8d9",
 31:                     "expectedControlType": "Vector2",
 32:                     "processors": "",
 33:                     "interactions": "",
 34:                     "initialStateCheck": true
 35:                 },
 36:                 {
 37:                     "name": "light",
 38:                     "type": "Value",
 39:                     "id": "c38b8394-7483-4dc5-b1fb-96a98f63fd3b",
 40:                     "expectedControlType": "Vector2",
 41:                     "processors": "",
 42:                     "interactions": "",
 43:                     "initialStateCheck": true
 44:                 }
 45:             ],
 46:             "bindings": [
 47:                 {
 48:                     "name": "2D Vector",
 49:                     "id": "e729ab74-31a5-41b1-bda3-8426eb0f53b5",
 50:                     "path": "2DVector",
 51:                     "interactions": "",
 52:                     "processors": "",
 53:                     "groups": "",
 54:                     "action": "move",
 55:                     "isComposite": true,
 56:                     "isPartOfComposite": false
 57:                 },
 58:                 {
 59:                     "name": "up",
 60:                     "id": "e77ccca4-846a-4a98-bb05-470d3f98b97a",
 61:                     "path": "<Keyboard>/w",
 62:                     "interactions": "",
 63:                     "processors": "",
 64:                     "groups": "",
 65:                     "action": "move",
 66:                     "isComposite": false,
 67:                     "isPartOfComposite": true
 68:                 },
 69:                 {
 70:                     "name": "down",
 71:                     "id": "5d547117-917b-4a37-b829-bee66b3d56ad",
 72:                     "path": "<Keyboard>/s",
 73:                     "interactions": "",
 74:                     "processors": "",
 75:                     "groups": "",
 76:                     "action": "move",
 77:                     "isComposite": false,
 78:                     "isPartOfComposite": true
 79:                 },
 80:                 {
 81:                     "name": "left",
 82:                     "id": "29c2ea6d-aaa8-4b73-9f16-7b8c500b93a9",
 83:                     "path": "<Keyboard>/a",
 84:                     "interactions": "",
 85:                     "processors": "",
 86:                     "groups": "",
 87:                     "action": "move",
 88:                     "isComposite": false,
 89:                     "isPartOfComposite": true
 90:                 },
 91:                 {
 92:                     "name": "right",
 93:                     "id": "7c8e916c-07c6-4682-a97c-549dae4ce10a",
 94:                     "path": "<Keyboard>/d",
 95:                     "interactions": "",
 96:                     "processors": "",
 97:                     "groups": "",
 98:                     "action": "move",
 99:                     "isComposite": false,
100:                     "isPartOfComposite": true
101:                 },
102:                 {
103:                     "name": "",
104:                     "id": "cf209b74-27a8-4b55-bb81-fcfb014c43f0",
105:                     "path": "<Mouse>/delta",
106:                     "interactions": "",
107:                     "processors": "",
108:                     "groups": "",
109:                     "action": "camera",
110:                     "isComposite": false,
111:                     "isPartOfComposite": false
112:                 },
113:                 {
114:                     "name": "",
115:                     "id": "674763b2-8582-43ba-b63a-0046031c8373",
116:                     "path": "<Keyboard>/f",
117:                     "interactions": "",
118:                     "processors": "",
119:                     "groups": "",
120:                     "action": "light",
121:                     "isComposite": false,
122:                     "isPartOfComposite": false
123:                 },
124:                 {
125:                     "name": "",
126:                     "id": "f326312f-edef-4713-8936-946be95532e6",
127:                     "path": "<Keyboard>/shift",
128:                     "interactions": "",
129:                     "processors": "",
130:                     "groups": "",
131:                     "action": "sprint",
132:                     "isComposite": false,
133:                     "isPartOfComposite": false
134:                 }
135:             ]
136:         }
137:     ],
138:     "controlSchemes": []
139: }
```

## File: ProjectSettings/TagManager.asset
```
 1: %YAML 1.1
 2: %TAG !u! tag:unity3d.com,2011:
 3: --- !u!78 &1
 4: TagManager:
 5:   serializedVersion: 2
 6:   tags: []
 7:   layers:
 8:   - Default
 9:   - TransparentFX
10:   - Ignore Raycast
11:   - 
12:   - Water
13:   - UI
14:   - 
15:   - 
16:   - 
17:   - 
18:   - 
19:   - 
20:   - 
21:   - 
22:   - 
23:   - 
24:   - 
25:   - 
26:   - 
27:   - 
28:   - 
29:   - 
30:   - 
31:   - 
32:   - 
33:   - 
34:   - 
35:   - 
36:   - 
37:   - 
38:   - 
39:   - 
40:   m_SortingLayers:
41:   - name: Default
42:     uniqueID: 0
43:     locked: 0
```

## File: Assets/_Scenes/Lvl 1.unity
```
   1: %YAML 1.1
   2: %TAG !u! tag:unity3d.com,2011:
   3: --- !u!29 &1
   4: OcclusionCullingSettings:
   5:   m_ObjectHideFlags: 0
   6:   serializedVersion: 2
   7:   m_OcclusionBakeSettings:
   8:     smallestOccluder: 5
   9:     smallestHole: 0.25
  10:     backfaceThreshold: 100
  11:   m_SceneGUID: 00000000000000000000000000000000
  12:   m_OcclusionCullingData: {fileID: 0}
  13: --- !u!104 &2
  14: RenderSettings:
  15:   m_ObjectHideFlags: 0
  16:   serializedVersion: 9
  17:   m_Fog: 0
  18:   m_FogColor: {r: 0.5, g: 0.5, b: 0.5, a: 1}
  19:   m_FogMode: 3
  20:   m_FogDensity: 0.01
  21:   m_LinearFogStart: 0
  22:   m_LinearFogEnd: 300
  23:   m_AmbientSkyColor: {r: 0, g: 0, b: 0, a: 1}
  24:   m_AmbientEquatorColor: {r: 0.114, g: 0.125, b: 0.133, a: 1}
  25:   m_AmbientGroundColor: {r: 0.047, g: 0.043, b: 0.035, a: 1}
  26:   m_AmbientIntensity: 1.742
  27:   m_AmbientMode: 0
  28:   m_SubtractiveShadowColor: {r: 0, g: 0, b: 0, a: 1}
  29:   m_SkyboxMaterial: {fileID: 2100000, guid: cdbb40e11399e4a17882ada20a1b896a, type: 2}
  30:   m_HaloStrength: 0.5
  31:   m_FlareStrength: 1
  32:   m_FlareFadeSpeed: 3
  33:   m_HaloTexture: {fileID: 0}
  34:   m_SpotCookie: {fileID: 10001, guid: 0000000000000000e000000000000000, type: 0}
  35:   m_DefaultReflectionMode: 0
  36:   m_DefaultReflectionResolution: 128
  37:   m_ReflectionBounces: 1
  38:   m_ReflectionIntensity: 0
  39:   m_CustomReflection: {fileID: 0}
  40:   m_Sun: {fileID: 0}
  41:   m_UseRadianceAmbientProbe: 0
  42: --- !u!157 &3
  43: LightmapSettings:
  44:   m_ObjectHideFlags: 0
  45:   serializedVersion: 12
  46:   m_GIWorkflowMode: 1
  47:   m_GISettings:
  48:     serializedVersion: 2
  49:     m_BounceScale: 1
  50:     m_IndirectOutputScale: 1
  51:     m_AlbedoBoost: 1
  52:     m_EnvironmentLightingMode: 0
  53:     m_EnableBakedLightmaps: 1
  54:     m_EnableRealtimeLightmaps: 0
  55:   m_LightmapEditorSettings:
  56:     serializedVersion: 12
  57:     m_Resolution: 2
  58:     m_BakeResolution: 40
  59:     m_AtlasSize: 1024
  60:     m_AO: 0
  61:     m_AOMaxDistance: 1
  62:     m_CompAOExponent: 1
  63:     m_CompAOExponentDirect: 0
  64:     m_ExtractAmbientOcclusion: 0
  65:     m_Padding: 2
  66:     m_LightmapParameters: {fileID: 0}
  67:     m_LightmapsBakeMode: 1
  68:     m_TextureCompression: 1
  69:     m_FinalGather: 0
  70:     m_FinalGatherFiltering: 1
  71:     m_FinalGatherRayCount: 256
  72:     m_ReflectionCompression: 2
  73:     m_MixedBakeMode: 2
  74:     m_BakeBackend: 1
  75:     m_PVRSampling: 1
  76:     m_PVRDirectSampleCount: 32
  77:     m_PVRSampleCount: 512
  78:     m_PVRBounces: 2
  79:     m_PVREnvironmentSampleCount: 256
  80:     m_PVREnvironmentReferencePointCount: 2048
  81:     m_PVRFilteringMode: 1
  82:     m_PVRDenoiserTypeDirect: 1
  83:     m_PVRDenoiserTypeIndirect: 1
  84:     m_PVRDenoiserTypeAO: 1
  85:     m_PVRFilterTypeDirect: 0
  86:     m_PVRFilterTypeIndirect: 0
  87:     m_PVRFilterTypeAO: 0
  88:     m_PVREnvironmentMIS: 1
  89:     m_PVRCulling: 1
  90:     m_PVRFilteringGaussRadiusDirect: 1
  91:     m_PVRFilteringGaussRadiusIndirect: 5
  92:     m_PVRFilteringGaussRadiusAO: 2
  93:     m_PVRFilteringAtrousPositionSigmaDirect: 0.5
  94:     m_PVRFilteringAtrousPositionSigmaIndirect: 2
  95:     m_PVRFilteringAtrousPositionSigmaAO: 1
  96:     m_ExportTrainingData: 0
  97:     m_TrainingDataDestination: TrainingData
  98:     m_LightProbeSampleCountMultiplier: 4
  99:   m_LightingDataAsset: {fileID: 20201, guid: 0000000000000000f000000000000000, type: 0}
 100:   m_LightingSettings: {fileID: 0}
 101: --- !u!196 &4
 102: NavMeshSettings:
 103:   serializedVersion: 2
 104:   m_ObjectHideFlags: 0
 105:   m_BuildSettings:
 106:     serializedVersion: 3
 107:     agentTypeID: 0
 108:     agentRadius: 0.5
 109:     agentHeight: 2
 110:     agentSlope: 45
 111:     agentClimb: 0.4
 112:     ledgeDropHeight: 0
 113:     maxJumpAcrossDistance: 0
 114:     minRegionArea: 2
 115:     manualCellSize: 0
 116:     cellSize: 0.16666667
 117:     manualTileSize: 0
 118:     tileSize: 256
 119:     buildHeightMesh: 0
 120:     maxJobWorkers: 0
 121:     preserveTilesOutsideBounds: 0
 122:     debug:
 123:       m_Flags: 0
 124:   m_NavMeshData: {fileID: 0}
 125: --- !u!1 &1338458
 126: GameObject:
 127:   m_ObjectHideFlags: 0
 128:   m_CorrespondingSourceObject: {fileID: 0}
 129:   m_PrefabInstance: {fileID: 0}
 130:   m_PrefabAsset: {fileID: 0}
 131:   serializedVersion: 6
 132:   m_Component:
 133:   - component: {fileID: 1338460}
 134:   - component: {fileID: 1338461}
 135:   - component: {fileID: 1338462}
 136:   m_Layer: 0
 137:   m_Name: Game Manager
 138:   m_TagString: Untagged
 139:   m_Icon: {fileID: 0}
 140:   m_NavMeshLayer: 0
 141:   m_StaticEditorFlags: 0
 142:   m_IsActive: 1
 143: --- !u!4 &1338460
 144: Transform:
 145:   m_ObjectHideFlags: 0
 146:   m_CorrespondingSourceObject: {fileID: 0}
 147:   m_PrefabInstance: {fileID: 0}
 148:   m_PrefabAsset: {fileID: 0}
 149:   m_GameObject: {fileID: 1338458}
 150:   serializedVersion: 2
 151:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
 152:   m_LocalPosition: {x: 0, y: 0, z: 0}
 153:   m_LocalScale: {x: 1, y: 1, z: 1}
 154:   m_ConstrainProportionsScale: 0
 155:   m_Children: []
 156:   m_Father: {fileID: 0}
 157:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 158: --- !u!114 &1338461
 159: MonoBehaviour:
 160:   m_ObjectHideFlags: 0
 161:   m_CorrespondingSourceObject: {fileID: 0}
 162:   m_PrefabInstance: {fileID: 0}
 163:   m_PrefabAsset: {fileID: 0}
 164:   m_GameObject: {fileID: 1338458}
 165:   m_Enabled: 1
 166:   m_EditorHideFlags: 0
 167:   m_Script: {fileID: 11500000, guid: 09771279f7ea7e54e961eb14f635a122, type: 3}
 168:   m_Name: 
 169:   m_EditorClassIdentifier: 
 170:   sceneChange: 0
 171:   menuOff: 0
 172:   prefab1: 0
 173:   prefab2: 0
 174:   count: {fileID: 177176875}
 175:   countOut: {fileID: 874196380}
 176:   pause: {fileID: 61253945}
 177:   next: {fileID: 0}
 178:   options: {fileID: 753868968}
 179:   menu: {fileID: 61253945}
 180:   score: {fileID: 374289202576707483, guid: 78df1db2fbc8ec64f949fac0c05bf693, type: 3}
 181:   enemy: {fileID: 7970415662211546156, guid: ab6d23f67d07a614a9ea0762ddb78260, type: 3}
 182:   vectors3: []
 183:   lightF: {fileID: 2067996071}
 184:   objectScore: 0
 185: --- !u!114 &1338462
 186: MonoBehaviour:
 187:   m_ObjectHideFlags: 0
 188:   m_CorrespondingSourceObject: {fileID: 0}
 189:   m_PrefabInstance: {fileID: 0}
 190:   m_PrefabAsset: {fileID: 0}
 191:   m_GameObject: {fileID: 1338458}
 192:   m_Enabled: 1
 193:   m_EditorHideFlags: 0
 194:   m_Script: {fileID: 11500000, guid: 62899f850307741f2a39c98a8b639597, type: 3}
 195:   m_Name: 
 196:   m_EditorClassIdentifier: 
 197:   m_Actions: {fileID: -944628639613478452, guid: 61918e08ac444e14cbca19e224d7d22e, type: 3}
 198:   m_NotificationBehavior: 0
 199:   m_UIInputModule: {fileID: 0}
 200:   m_DeviceLostEvent:
 201:     m_PersistentCalls:
 202:       m_Calls: []
 203:   m_DeviceRegainedEvent:
 204:     m_PersistentCalls:
 205:       m_Calls: []
 206:   m_ControlsChangedEvent:
 207:     m_PersistentCalls:
 208:       m_Calls: []
 209:   m_ActionEvents: []
 210:   m_NeverAutoSwitchControlSchemes: 0
 211:   m_DefaultControlScheme: 
 212:   m_DefaultActionMap: Player
 213:   m_SplitScreenIndex: -1
 214:   m_Camera: {fileID: 0}
 215: --- !u!1 &17670198
 216: GameObject:
 217:   m_ObjectHideFlags: 0
 218:   m_CorrespondingSourceObject: {fileID: 0}
 219:   m_PrefabInstance: {fileID: 0}
 220:   m_PrefabAsset: {fileID: 0}
 221:   serializedVersion: 6
 222:   m_Component:
 223:   - component: {fileID: 17670199}
 224:   - component: {fileID: 17670201}
 225:   - component: {fileID: 17670200}
 226:   m_Layer: 5
 227:   m_Name: RawImage
 228:   m_TagString: Untagged
 229:   m_Icon: {fileID: 0}
 230:   m_NavMeshLayer: 0
 231:   m_StaticEditorFlags: 0
 232:   m_IsActive: 1
 233: --- !u!224 &17670199
 234: RectTransform:
 235:   m_ObjectHideFlags: 0
 236:   m_CorrespondingSourceObject: {fileID: 0}
 237:   m_PrefabInstance: {fileID: 0}
 238:   m_PrefabAsset: {fileID: 0}
 239:   m_GameObject: {fileID: 17670198}
 240:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
 241:   m_LocalPosition: {x: 0, y: 0, z: 0}
 242:   m_LocalScale: {x: 1, y: 1, z: 1}
 243:   m_ConstrainProportionsScale: 0
 244:   m_Children: []
 245:   m_Father: {fileID: 753868972}
 246:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 247:   m_AnchorMin: {x: 0.5, y: 0.5}
 248:   m_AnchorMax: {x: 0.5, y: 0.5}
 249:   m_AnchoredPosition: {x: 40.034714, y: 46.45597}
 250:   m_SizeDelta: {x: 1118.8356, y: 619.7322}
 251:   m_Pivot: {x: 0.5, y: 0.5}
 252: --- !u!114 &17670200
 253: MonoBehaviour:
 254:   m_ObjectHideFlags: 0
 255:   m_CorrespondingSourceObject: {fileID: 0}
 256:   m_PrefabInstance: {fileID: 0}
 257:   m_PrefabAsset: {fileID: 0}
 258:   m_GameObject: {fileID: 17670198}
 259:   m_Enabled: 1
 260:   m_EditorHideFlags: 0
 261:   m_Script: {fileID: 11500000, guid: 1344c3c82d62a2a41a3576d8abb8e3ea, type: 3}
 262:   m_Name: 
 263:   m_EditorClassIdentifier: 
 264:   m_Material: {fileID: 0}
 265:   m_Color: {r: 1, g: 1, b: 1, a: 1}
 266:   m_RaycastTarget: 1
 267:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
 268:   m_Maskable: 1
 269:   m_OnCullStateChanged:
 270:     m_PersistentCalls:
 271:       m_Calls: []
 272:   m_Texture: {fileID: 2800000, guid: c50cf53deda4a444791ad8c26d6f135b, type: 3}
 273:   m_UVRect:
 274:     serializedVersion: 2
 275:     x: 0
 276:     y: 0
 277:     width: 1
 278:     height: 1
 279: --- !u!222 &17670201
 280: CanvasRenderer:
 281:   m_ObjectHideFlags: 0
 282:   m_CorrespondingSourceObject: {fileID: 0}
 283:   m_PrefabInstance: {fileID: 0}
 284:   m_PrefabAsset: {fileID: 0}
 285:   m_GameObject: {fileID: 17670198}
 286:   m_CullTransparentMesh: 1
 287: --- !u!1 &45582772
 288: GameObject:
 289:   m_ObjectHideFlags: 0
 290:   m_CorrespondingSourceObject: {fileID: 0}
 291:   m_PrefabInstance: {fileID: 0}
 292:   m_PrefabAsset: {fileID: 0}
 293:   serializedVersion: 6
 294:   m_Component:
 295:   - component: {fileID: 45582773}
 296:   - component: {fileID: 45582775}
 297:   - component: {fileID: 45582774}
 298:   m_Layer: 5
 299:   m_Name: Background
 300:   m_TagString: Untagged
 301:   m_Icon: {fileID: 0}
 302:   m_NavMeshLayer: 0
 303:   m_StaticEditorFlags: 0
 304:   m_IsActive: 1
 305: --- !u!224 &45582773
 306: RectTransform:
 307:   m_ObjectHideFlags: 0
 308:   m_CorrespondingSourceObject: {fileID: 0}
 309:   m_PrefabInstance: {fileID: 0}
 310:   m_PrefabAsset: {fileID: 0}
 311:   m_GameObject: {fileID: 45582772}
 312:   m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
 313:   m_LocalPosition: {x: 0, y: 0, z: 0}
 314:   m_LocalScale: {x: 1, y: 1, z: 1}
 315:   m_ConstrainProportionsScale: 0
 316:   m_Children: []
 317:   m_Father: {fileID: 1091955426}
 318:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 319:   m_AnchorMin: {x: 0, y: 0.25}
 320:   m_AnchorMax: {x: 1, y: 0.75}
 321:   m_AnchoredPosition: {x: 0, y: 0}
 322:   m_SizeDelta: {x: 0, y: 0}
 323:   m_Pivot: {x: 0.5, y: 0.5}
 324: --- !u!114 &45582774
 325: MonoBehaviour:
 326:   m_ObjectHideFlags: 0
 327:   m_CorrespondingSourceObject: {fileID: 0}
 328:   m_PrefabInstance: {fileID: 0}
 329:   m_PrefabAsset: {fileID: 0}
 330:   m_GameObject: {fileID: 45582772}
 331:   m_Enabled: 1
 332:   m_EditorHideFlags: 0
 333:   m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
 334:   m_Name: 
 335:   m_EditorClassIdentifier: 
 336:   m_Material: {fileID: 0}
 337:   m_Color: {r: 1, g: 1, b: 1, a: 1}
 338:   m_RaycastTarget: 1
 339:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
 340:   m_Maskable: 1
 341:   m_OnCullStateChanged:
 342:     m_PersistentCalls:
 343:       m_Calls: []
 344:   m_Sprite: {fileID: 10907, guid: 0000000000000000f000000000000000, type: 0}
 345:   m_Type: 1
 346:   m_PreserveAspect: 0
 347:   m_FillCenter: 1
 348:   m_FillMethod: 4
 349:   m_FillAmount: 1
 350:   m_FillClockwise: 1
 351:   m_FillOrigin: 0
 352:   m_UseSpriteMesh: 0
 353:   m_PixelsPerUnitMultiplier: 1
 354: --- !u!222 &45582775
 355: CanvasRenderer:
 356:   m_ObjectHideFlags: 0
 357:   m_CorrespondingSourceObject: {fileID: 0}
 358:   m_PrefabInstance: {fileID: 0}
 359:   m_PrefabAsset: {fileID: 0}
 360:   m_GameObject: {fileID: 45582772}
 361:   m_CullTransparentMesh: 1
 362: --- !u!1 &47567039
 363: GameObject:
 364:   m_ObjectHideFlags: 0
 365:   m_CorrespondingSourceObject: {fileID: 0}
 366:   m_PrefabInstance: {fileID: 0}
 367:   m_PrefabAsset: {fileID: 0}
 368:   serializedVersion: 6
 369:   m_Component:
 370:   - component: {fileID: 47567040}
 371:   - component: {fileID: 47567042}
 372:   - component: {fileID: 47567041}
 373:   m_Layer: 5
 374:   m_Name: Fill
 375:   m_TagString: Untagged
 376:   m_Icon: {fileID: 0}
 377:   m_NavMeshLayer: 0
 378:   m_StaticEditorFlags: 0
 379:   m_IsActive: 1
 380: --- !u!224 &47567040
 381: RectTransform:
 382:   m_ObjectHideFlags: 0
 383:   m_CorrespondingSourceObject: {fileID: 0}
 384:   m_PrefabInstance: {fileID: 0}
 385:   m_PrefabAsset: {fileID: 0}
 386:   m_GameObject: {fileID: 47567039}
 387:   m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
 388:   m_LocalPosition: {x: 0, y: 0, z: 0}
 389:   m_LocalScale: {x: 1, y: 1, z: 1}
 390:   m_ConstrainProportionsScale: 0
 391:   m_Children: []
 392:   m_Father: {fileID: 1466587694}
 393:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 394:   m_AnchorMin: {x: 0, y: 0}
 395:   m_AnchorMax: {x: 0, y: 1}
 396:   m_AnchoredPosition: {x: 0, y: 0}
 397:   m_SizeDelta: {x: 10, y: 0}
 398:   m_Pivot: {x: 0.5, y: 0.5}
 399: --- !u!114 &47567041
 400: MonoBehaviour:
 401:   m_ObjectHideFlags: 0
 402:   m_CorrespondingSourceObject: {fileID: 0}
 403:   m_PrefabInstance: {fileID: 0}
 404:   m_PrefabAsset: {fileID: 0}
 405:   m_GameObject: {fileID: 47567039}
 406:   m_Enabled: 1
 407:   m_EditorHideFlags: 0
 408:   m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
 409:   m_Name: 
 410:   m_EditorClassIdentifier: 
 411:   m_Material: {fileID: 0}
 412:   m_Color: {r: 1, g: 1, b: 1, a: 1}
 413:   m_RaycastTarget: 1
 414:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
 415:   m_Maskable: 1
 416:   m_OnCullStateChanged:
 417:     m_PersistentCalls:
 418:       m_Calls: []
 419:   m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
 420:   m_Type: 1
 421:   m_PreserveAspect: 0
 422:   m_FillCenter: 1
 423:   m_FillMethod: 4
 424:   m_FillAmount: 1
 425:   m_FillClockwise: 1
 426:   m_FillOrigin: 0
 427:   m_UseSpriteMesh: 0
 428:   m_PixelsPerUnitMultiplier: 1
 429: --- !u!222 &47567042
 430: CanvasRenderer:
 431:   m_ObjectHideFlags: 0
 432:   m_CorrespondingSourceObject: {fileID: 0}
 433:   m_PrefabInstance: {fileID: 0}
 434:   m_PrefabAsset: {fileID: 0}
 435:   m_GameObject: {fileID: 47567039}
 436:   m_CullTransparentMesh: 1
 437: --- !u!1 &61253945
 438: GameObject:
 439:   m_ObjectHideFlags: 0
 440:   m_CorrespondingSourceObject: {fileID: 0}
 441:   m_PrefabInstance: {fileID: 0}
 442:   m_PrefabAsset: {fileID: 0}
 443:   serializedVersion: 6
 444:   m_Component:
 445:   - component: {fileID: 61253949}
 446:   - component: {fileID: 61253948}
 447:   - component: {fileID: 61253947}
 448:   - component: {fileID: 61253946}
 449:   m_Layer: 5
 450:   m_Name: Canvas
 451:   m_TagString: Untagged
 452:   m_Icon: {fileID: 0}
 453:   m_NavMeshLayer: 0
 454:   m_StaticEditorFlags: 0
 455:   m_IsActive: 0
 456: --- !u!114 &61253946
 457: MonoBehaviour:
 458:   m_ObjectHideFlags: 0
 459:   m_CorrespondingSourceObject: {fileID: 0}
 460:   m_PrefabInstance: {fileID: 0}
 461:   m_PrefabAsset: {fileID: 0}
 462:   m_GameObject: {fileID: 61253945}
 463:   m_Enabled: 1
 464:   m_EditorHideFlags: 0
 465:   m_Script: {fileID: 11500000, guid: dc42784cf147c0c48a680349fa168899, type: 3}
 466:   m_Name: 
 467:   m_EditorClassIdentifier: 
 468:   m_IgnoreReversedGraphics: 1
 469:   m_BlockingObjects: 0
 470:   m_BlockingMask:
 471:     serializedVersion: 2
 472:     m_Bits: 4294967295
 473: --- !u!114 &61253947
 474: MonoBehaviour:
 475:   m_ObjectHideFlags: 0
 476:   m_CorrespondingSourceObject: {fileID: 0}
 477:   m_PrefabInstance: {fileID: 0}
 478:   m_PrefabAsset: {fileID: 0}
 479:   m_GameObject: {fileID: 61253945}
 480:   m_Enabled: 1
 481:   m_EditorHideFlags: 0
 482:   m_Script: {fileID: 11500000, guid: 0cd44c1031e13a943bb63640046fad76, type: 3}
 483:   m_Name: 
 484:   m_EditorClassIdentifier: 
 485:   m_UiScaleMode: 1
 486:   m_ReferencePixelsPerUnit: 100
 487:   m_ScaleFactor: 1
 488:   m_ReferenceResolution: {x: 800, y: 600}
 489:   m_ScreenMatchMode: 0
 490:   m_MatchWidthOrHeight: 0
 491:   m_PhysicalUnit: 3
 492:   m_FallbackScreenDPI: 96
 493:   m_DefaultSpriteDPI: 96
 494:   m_DynamicPixelsPerUnit: 1
 495:   m_PresetInfoIsWorld: 0
 496: --- !u!223 &61253948
 497: Canvas:
 498:   m_ObjectHideFlags: 0
 499:   m_CorrespondingSourceObject: {fileID: 0}
 500:   m_PrefabInstance: {fileID: 0}
 501:   m_PrefabAsset: {fileID: 0}
 502:   m_GameObject: {fileID: 61253945}
 503:   m_Enabled: 1
 504:   serializedVersion: 3
 505:   m_RenderMode: 0
 506:   m_Camera: {fileID: 330585545}
 507:   m_PlaneDistance: 100
 508:   m_PixelPerfect: 1
 509:   m_ReceivesEvents: 1
 510:   m_OverrideSorting: 0
 511:   m_OverridePixelPerfect: 0
 512:   m_SortingBucketNormalizedSize: 0
 513:   m_VertexColorAlwaysGammaSpace: 0
 514:   m_AdditionalShaderChannelsFlag: 25
 515:   m_UpdateRectTransformForStandalone: 0
 516:   m_SortingLayerID: 0
 517:   m_SortingOrder: 0
 518:   m_TargetDisplay: 0
 519: --- !u!224 &61253949
 520: RectTransform:
 521:   m_ObjectHideFlags: 0
 522:   m_CorrespondingSourceObject: {fileID: 0}
 523:   m_PrefabInstance: {fileID: 0}
 524:   m_PrefabAsset: {fileID: 0}
 525:   m_GameObject: {fileID: 61253945}
 526:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
 527:   m_LocalPosition: {x: 0, y: 0, z: 0}
 528:   m_LocalScale: {x: 0, y: 0, z: 0}
 529:   m_ConstrainProportionsScale: 0
 530:   m_Children:
 531:   - {fileID: 2043724654}
 532:   - {fileID: 556929966}
 533:   - {fileID: 454505834}
 534:   - {fileID: 409258866}
 535:   m_Father: {fileID: 0}
 536:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 537:   m_AnchorMin: {x: 0, y: 0}
 538:   m_AnchorMax: {x: 0, y: 0}
 539:   m_AnchoredPosition: {x: 0, y: 0}
 540:   m_SizeDelta: {x: 0, y: 0}
 541:   m_Pivot: {x: 0, y: 0}
 542: --- !u!1 &99629576
 543: GameObject:
 544:   m_ObjectHideFlags: 0
 545:   m_CorrespondingSourceObject: {fileID: 0}
 546:   m_PrefabInstance: {fileID: 0}
 547:   m_PrefabAsset: {fileID: 0}
 548:   serializedVersion: 6
 549:   m_Component:
 550:   - component: {fileID: 99629577}
 551:   - component: {fileID: 99629579}
 552:   - component: {fileID: 99629578}
 553:   m_Layer: 5
 554:   m_Name: Text (TMP)
 555:   m_TagString: Untagged
 556:   m_Icon: {fileID: 0}
 557:   m_NavMeshLayer: 0
 558:   m_StaticEditorFlags: 0
 559:   m_IsActive: 1
 560: --- !u!224 &99629577
 561: RectTransform:
 562:   m_ObjectHideFlags: 0
 563:   m_CorrespondingSourceObject: {fileID: 0}
 564:   m_PrefabInstance: {fileID: 0}
 565:   m_PrefabAsset: {fileID: 0}
 566:   m_GameObject: {fileID: 99629576}
 567:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
 568:   m_LocalPosition: {x: 0, y: 0, z: 0}
 569:   m_LocalScale: {x: 1, y: 1, z: 1}
 570:   m_ConstrainProportionsScale: 0
 571:   m_Children: []
 572:   m_Father: {fileID: 409258866}
 573:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 574:   m_AnchorMin: {x: 0, y: 0}
 575:   m_AnchorMax: {x: 1, y: 1}
 576:   m_AnchoredPosition: {x: 0, y: 0}
 577:   m_SizeDelta: {x: 0, y: 0}
 578:   m_Pivot: {x: 0.5, y: 0.5}
 579: --- !u!114 &99629578
 580: MonoBehaviour:
 581:   m_ObjectHideFlags: 0
 582:   m_CorrespondingSourceObject: {fileID: 0}
 583:   m_PrefabInstance: {fileID: 0}
 584:   m_PrefabAsset: {fileID: 0}
 585:   m_GameObject: {fileID: 99629576}
 586:   m_Enabled: 1
 587:   m_EditorHideFlags: 0
 588:   m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
 589:   m_Name: 
 590:   m_EditorClassIdentifier: 
 591:   m_Material: {fileID: 0}
 592:   m_Color: {r: 1, g: 1, b: 1, a: 1}
 593:   m_RaycastTarget: 1
 594:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
 595:   m_Maskable: 1
 596:   m_OnCullStateChanged:
 597:     m_PersistentCalls:
 598:       m_Calls: []
 599:   m_text: Menu
 600:   m_isRightToLeft: 0
 601:   m_fontAsset: {fileID: 11400000, guid: 125cb55b44b24c4393181402bc6200e6, type: 2}
 602:   m_sharedMaterial: {fileID: 2100000, guid: d75b8f41e959450c84ac6e967084d3e1, type: 2}
 603:   m_fontSharedMaterials: []
 604:   m_fontMaterial: {fileID: 0}
 605:   m_fontMaterials: []
 606:   m_fontColor32:
 607:     serializedVersion: 2
 608:     rgba: 4281216654
 609:   m_fontColor: {r: 0.5566038, g: 0.18115878, b: 0.18115878, a: 1}
 610:   m_enableVertexGradient: 0
 611:   m_colorMode: 3
 612:   m_fontColorGradient:
 613:     topLeft: {r: 1, g: 1, b: 1, a: 1}
 614:     topRight: {r: 1, g: 1, b: 1, a: 1}
 615:     bottomLeft: {r: 1, g: 1, b: 1, a: 1}
 616:     bottomRight: {r: 1, g: 1, b: 1, a: 1}
 617:   m_fontColorGradientPreset: {fileID: 0}
 618:   m_spriteAsset: {fileID: 0}
 619:   m_tintAllSprites: 0
 620:   m_StyleSheet: {fileID: 0}
 621:   m_TextStyleHashCode: -1183493901
 622:   m_overrideHtmlColors: 0
 623:   m_faceColor:
 624:     serializedVersion: 2
 625:     rgba: 4294967295
 626:   m_fontSize: 50
 627:   m_fontSizeBase: 50
 628:   m_fontWeight: 400
 629:   m_enableAutoSizing: 0
 630:   m_fontSizeMin: 0
 631:   m_fontSizeMax: 0
 632:   m_fontStyle: 0
 633:   m_HorizontalAlignment: 2
 634:   m_VerticalAlignment: 512
 635:   m_textAlignment: 65535
 636:   m_characterSpacing: 0
 637:   m_wordSpacing: 0
 638:   m_lineSpacing: 0
 639:   m_lineSpacingMax: 0
 640:   m_paragraphSpacing: 0
 641:   m_charWidthMaxAdj: 0
 642:   m_enableWordWrapping: 0
 643:   m_wordWrappingRatios: 0.4
 644:   m_overflowMode: 0
 645:   m_linkedTextComponent: {fileID: 0}
 646:   parentLinkedComponent: {fileID: 0}
 647:   m_enableKerning: 0
 648:   m_enableExtraPadding: 0
 649:   checkPaddingRequired: 0
 650:   m_isRichText: 1
 651:   m_parseCtrlCharacters: 1
 652:   m_isOrthographic: 1
 653:   m_isCullingEnabled: 0
 654:   m_horizontalMapping: 0
 655:   m_verticalMapping: 0
 656:   m_uvLineOffset: 0
 657:   m_geometrySortingOrder: 0
 658:   m_IsTextObjectScaleStatic: 0
 659:   m_VertexBufferAutoSizeReduction: 0
 660:   m_useMaxVisibleDescender: 1
 661:   m_pageToDisplay: 1
 662:   m_margin: {x: 0, y: 0, z: 0, w: 0}
 663:   m_isUsingLegacyAnimationComponent: 0
 664:   m_isVolumetricText: 0
 665:   m_hasFontAssetChanged: 0
 666:   m_baseMaterial: {fileID: 0}
 667:   m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
 668: --- !u!222 &99629579
 669: CanvasRenderer:
 670:   m_ObjectHideFlags: 0
 671:   m_CorrespondingSourceObject: {fileID: 0}
 672:   m_PrefabInstance: {fileID: 0}
 673:   m_PrefabAsset: {fileID: 0}
 674:   m_GameObject: {fileID: 99629576}
 675:   m_CullTransparentMesh: 1
 676: --- !u!1 &177176873
 677: GameObject:
 678:   m_ObjectHideFlags: 0
 679:   m_CorrespondingSourceObject: {fileID: 0}
 680:   m_PrefabInstance: {fileID: 0}
 681:   m_PrefabAsset: {fileID: 0}
 682:   serializedVersion: 6
 683:   m_Component:
 684:   - component: {fileID: 177176874}
 685:   - component: {fileID: 177176876}
 686:   - component: {fileID: 177176875}
 687:   m_Layer: 5
 688:   m_Name: Text (TMP)
 689:   m_TagString: Untagged
 690:   m_Icon: {fileID: 0}
 691:   m_NavMeshLayer: 0
 692:   m_StaticEditorFlags: 0
 693:   m_IsActive: 1
 694: --- !u!224 &177176874
 695: RectTransform:
 696:   m_ObjectHideFlags: 0
 697:   m_CorrespondingSourceObject: {fileID: 0}
 698:   m_PrefabInstance: {fileID: 0}
 699:   m_PrefabAsset: {fileID: 0}
 700:   m_GameObject: {fileID: 177176873}
 701:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
 702:   m_LocalPosition: {x: 0, y: 0, z: 0}
 703:   m_LocalScale: {x: 1, y: 1, z: 1}
 704:   m_ConstrainProportionsScale: 0
 705:   m_Children: []
 706:   m_Father: {fileID: 874196384}
 707:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
 708:   m_AnchorMin: {x: 0, y: 1}
 709:   m_AnchorMax: {x: 0, y: 1}
 710:   m_AnchoredPosition: {x: 0, y: 0}
 711:   m_SizeDelta: {x: 200, y: 50}
 712:   m_Pivot: {x: 0, y: 1}
 713: --- !u!114 &177176875
 714: MonoBehaviour:
 715:   m_ObjectHideFlags: 0
 716:   m_CorrespondingSourceObject: {fileID: 0}
 717:   m_PrefabInstance: {fileID: 0}
 718:   m_PrefabAsset: {fileID: 0}
 719:   m_GameObject: {fileID: 177176873}
 720:   m_Enabled: 1
 721:   m_EditorHideFlags: 0
 722:   m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
 723:   m_Name: 
 724:   m_EditorClassIdentifier: 
 725:   m_Material: {fileID: 0}
 726:   m_Color: {r: 1, g: 1, b: 1, a: 1}
 727:   m_RaycastTarget: 1
 728:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
 729:   m_Maskable: 1
 730:   m_OnCullStateChanged:
 731:     m_PersistentCalls:
 732:       m_Calls: []
 733:   m_text: ss
 734:   m_isRightToLeft: 0
 735:   m_fontAsset: {fileID: 11400000, guid: 125cb55b44b24c4393181402bc6200e6, type: 2}
 736:   m_sharedMaterial: {fileID: 2100000, guid: d75b8f41e959450c84ac6e967084d3e1, type: 2}
 737:   m_fontSharedMaterials: []
 738:   m_fontMaterial: {fileID: 0}
 739:   m_fontMaterials: []
 740:   m_fontColor32:
 741:     serializedVersion: 2
 742:     rgba: 4294967295
 743:   m_fontColor: {r: 1, g: 1, b: 1, a: 1}
 744:   m_enableVertexGradient: 0
 745:   m_colorMode: 3
 746:   m_fontColorGradient:
 747:     topLeft: {r: 1, g: 1, b: 1, a: 1}
 748:     topRight: {r: 1, g: 1, b: 1, a: 1}
 749:     bottomLeft: {r: 1, g: 1, b: 1, a: 1}
 750:     bottomRight: {r: 1, g: 1, b: 1, a: 1}
 751:   m_fontColorGradientPreset: {fileID: 0}
 752:   m_spriteAsset: {fileID: 0}
 753:   m_tintAllSprites: 0
 754:   m_StyleSheet: {fileID: 0}
 755:   m_TextStyleHashCode: -1183493901
 756:   m_overrideHtmlColors: 0
 757:   m_faceColor:
 758:     serializedVersion: 2
 759:     rgba: 4294967295
 760:   m_fontSize: 36
 761:   m_fontSizeBase: 36
 762:   m_fontWeight: 400
 763:   m_enableAutoSizing: 0
 764:   m_fontSizeMin: 18
 765:   m_fontSizeMax: 72
 766:   m_fontStyle: 1
 767:   m_HorizontalAlignment: 1
 768:   m_VerticalAlignment: 256
 769:   m_textAlignment: 65535
 770:   m_characterSpacing: 0
 771:   m_wordSpacing: 0
 772:   m_lineSpacing: 0
 773:   m_lineSpacingMax: 0
 774:   m_paragraphSpacing: 0
 775:   m_charWidthMaxAdj: 0
 776:   m_enableWordWrapping: 1
 777:   m_wordWrappingRatios: 0.4
 778:   m_overflowMode: 0
 779:   m_linkedTextComponent: {fileID: 0}
 780:   parentLinkedComponent: {fileID: 0}
 781:   m_enableKerning: 1
 782:   m_enableExtraPadding: 0
 783:   checkPaddingRequired: 0
 784:   m_isRichText: 1
 785:   m_parseCtrlCharacters: 1
 786:   m_isOrthographic: 1
 787:   m_isCullingEnabled: 0
 788:   m_horizontalMapping: 0
 789:   m_verticalMapping: 0
 790:   m_uvLineOffset: 0
 791:   m_geometrySortingOrder: 0
 792:   m_IsTextObjectScaleStatic: 0
 793:   m_VertexBufferAutoSizeReduction: 0
 794:   m_useMaxVisibleDescender: 1
 795:   m_pageToDisplay: 1
 796:   m_margin: {x: 0, y: 0, z: 0, w: 0}
 797:   m_isUsingLegacyAnimationComponent: 0
 798:   m_isVolumetricText: 0
 799:   m_hasFontAssetChanged: 0
 800:   m_baseMaterial: {fileID: 0}
 801:   m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
 802: --- !u!222 &177176876
 803: CanvasRenderer:
 804:   m_ObjectHideFlags: 0
 805:   m_CorrespondingSourceObject: {fileID: 0}
 806:   m_PrefabInstance: {fileID: 0}
 807:   m_PrefabAsset: {fileID: 0}
 808:   m_GameObject: {fileID: 177176873}
 809:   m_CullTransparentMesh: 1
 810: --- !u!4 &220352548 stripped
 811: Transform:
 812:   m_CorrespondingSourceObject: {fileID: -8679921383154817045, guid: 941fa26d085342141a164aaaca9eadce, type: 3}
 813:   m_PrefabInstance: {fileID: 280667602}
 814:   m_PrefabAsset: {fileID: 0}
 815: --- !u!1001 &280667602
 816: PrefabInstance:
 817:   m_ObjectHideFlags: 0
 818:   serializedVersion: 2
 819:   m_Modification:
 820:     serializedVersion: 3
 821:     m_TransformParent: {fileID: 468900850}
 822:     m_Modifications:
 823:     - target: {fileID: -8679921383154817045, guid: 941fa26d085342141a164aaaca9eadce, type: 3}
 824:       propertyPath: m_LocalScale.x
 825:       value: 3
 826:       objectReference: {fileID: 0}
 827:     - target: {fileID: -8679921383154817045, guid: 941fa26d085342141a164aaaca9eadce, type: 3}
 828:       propertyPath: m_LocalScale.y
 829:       value: 3
 830:       objectReference: {fileID: 0}
 831:     - target: {fileID: -8679921383154817045, guid: 941fa26d085342141a164aaaca9eadce, type: 3}
 832:       propertyPath: m_LocalScale.z
 833:       value: 3
 834:       objectReference: {fileID: 0}
 835:     - target: {fileID: -8679921383154817045, guid: 941fa26d085342141a164aaaca9eadce, type: 3}
 836:       propertyPath: m_LocalPosition.x
 837:       value: 0.0182
 838:       objectReference: {fileID: 0}
 839:     - target: {fileID: -8679921383154817045, guid: 941fa26d085342141a164aaaca9eadce, type: 3}
 840:       propertyPath: m_LocalPosition.y
 841:       value: -0.0244
 842:       objectReference: {fileID: 0}
 843:     - target: {fileID: -8679921383154817045, guid: 941fa26d085342141a164aaaca9eadce, type: 3}
 844:       propertyPath: m_LocalPosition.z
 845:       value: 0.0624
 846:       objectReference: {fileID: 0}
 847:     - target: {fileID: -8679921383154817045, guid: 941fa26d085342141a164aaaca9eadce, type: 3}
 848:       propertyPath: m_LocalRotation.w
 849:       value: 0.6046632
 850:       objectReference: {fileID: 0}
 851:     - target: {fileID: -8679921383154817045, guid: 941fa26d085342141a164aaaca9eadce, type: 3}
 852:       propertyPath: m_LocalRotation.x
 853:       value: -0.73451793
 854:       objectReference: {fileID: 0}
 855:     - target: {fileID: -8679921383154817045, guid: 941fa26d085342141a164aaaca9eadce, type: 3}
 856:       propertyPath: m_LocalRotation.y
 857:       value: -0.27973297
 858:       objectReference: {fileID: 0}
 859:     - target: {fileID: -8679921383154817045, guid: 941fa26d085342141a164aaaca9eadce, type: 3}
 860:       propertyPath: m_LocalRotation.z
 861:       value: -0.12890045
 862:       objectReference: {fileID: 0}
 863:     - target: {fileID: -8679921383154817045, guid: 941fa26d085342141a164aaaca9eadce, type: 3}
 864:       propertyPath: m_LocalEulerAnglesHint.x
 865:       value: 0
 866:       objectReference: {fileID: 0}
 867:     - target: {fileID: -8679921383154817045, guid: 941fa26d085342141a164aaaca9eadce, type: 3}
 868:       propertyPath: m_LocalEulerAnglesHint.y
 869:       value: 0
 870:       objectReference: {fileID: 0}
 871:     - target: {fileID: -8679921383154817045, guid: 941fa26d085342141a164aaaca9eadce, type: 3}
 872:       propertyPath: m_LocalEulerAnglesHint.z
 873:       value: -170.38
 874:       objectReference: {fileID: 0}
 875:     - target: {fileID: -8679921383154817045, guid: 941fa26d085342141a164aaaca9eadce, type: 3}
 876:       propertyPath: m_ConstrainProportionsScale
 877:       value: 1
 878:       objectReference: {fileID: 0}
 879:     - target: {fileID: 919132149155446097, guid: 941fa26d085342141a164aaaca9eadce, type: 3}
 880:       propertyPath: m_Name
 881:       value: Linterna-Untitled
 882:       objectReference: {fileID: 0}
 883:     m_RemovedComponents: []
 884:     m_RemovedGameObjects: []
 885:     m_AddedGameObjects:
 886:     - targetCorrespondingSourceObject: {fileID: -8679921383154817045, guid: 941fa26d085342141a164aaaca9eadce, type: 3}
 887:       insertIndex: -1
 888:       addedObject: {fileID: 2067996070}
 889:     m_AddedComponents: []
 890:   m_SourcePrefab: {fileID: 100100000, guid: 941fa26d085342141a164aaaca9eadce, type: 3}
 891: --- !u!1001 &317525508
 892: PrefabInstance:
 893:   m_ObjectHideFlags: 0
 894:   serializedVersion: 2
 895:   m_Modification:
 896:     serializedVersion: 3
 897:     m_TransformParent: {fileID: 0}
 898:     m_Modifications:
 899:     - target: {fileID: -8679921383154817045, guid: 79d81dc0bb20d5a409d1160bf5b50b62, type: 3}
 900:       propertyPath: m_LocalPosition.x
 901:       value: 396.45557
 902:       objectReference: {fileID: 0}
 903:     - target: {fileID: -8679921383154817045, guid: 79d81dc0bb20d5a409d1160bf5b50b62, type: 3}
 904:       propertyPath: m_LocalPosition.y
 905:       value: 0.1
 906:       objectReference: {fileID: 0}
 907:     - target: {fileID: -8679921383154817045, guid: 79d81dc0bb20d5a409d1160bf5b50b62, type: 3}
 908:       propertyPath: m_LocalPosition.z
 909:       value: 566.8
 910:       objectReference: {fileID: 0}
 911:     - target: {fileID: -8679921383154817045, guid: 79d81dc0bb20d5a409d1160bf5b50b62, type: 3}
 912:       propertyPath: m_LocalRotation.w
 913:       value: 0.7071067
 914:       objectReference: {fileID: 0}
 915:     - target: {fileID: -8679921383154817045, guid: 79d81dc0bb20d5a409d1160bf5b50b62, type: 3}
 916:       propertyPath: m_LocalRotation.x
 917:       value: -0.7071068
 918:       objectReference: {fileID: 0}
 919:     - target: {fileID: -8679921383154817045, guid: 79d81dc0bb20d5a409d1160bf5b50b62, type: 3}
 920:       propertyPath: m_LocalRotation.y
 921:       value: 0
 922:       objectReference: {fileID: 0}
 923:     - target: {fileID: -8679921383154817045, guid: 79d81dc0bb20d5a409d1160bf5b50b62, type: 3}
 924:       propertyPath: m_LocalRotation.z
 925:       value: -0
 926:       objectReference: {fileID: 0}
 927:     - target: {fileID: -8679921383154817045, guid: 79d81dc0bb20d5a409d1160bf5b50b62, type: 3}
 928:       propertyPath: m_LocalEulerAnglesHint.x
 929:       value: 0
 930:       objectReference: {fileID: 0}
 931:     - target: {fileID: -8679921383154817045, guid: 79d81dc0bb20d5a409d1160bf5b50b62, type: 3}
 932:       propertyPath: m_LocalEulerAnglesHint.y
 933:       value: 0
 934:       objectReference: {fileID: 0}
 935:     - target: {fileID: -8679921383154817045, guid: 79d81dc0bb20d5a409d1160bf5b50b62, type: 3}
 936:       propertyPath: m_LocalEulerAnglesHint.z
 937:       value: 0
 938:       objectReference: {fileID: 0}
 939:     - target: {fileID: 919132149155446097, guid: 79d81dc0bb20d5a409d1160bf5b50b62, type: 3}
 940:       propertyPath: m_Name
 941:       value: Pyramid
 942:       objectReference: {fileID: 0}
 943:     m_RemovedComponents: []
 944:     m_RemovedGameObjects: []
 945:     m_AddedGameObjects: []
 946:     m_AddedComponents:
 947:     - targetCorrespondingSourceObject: {fileID: 919132149155446097, guid: 79d81dc0bb20d5a409d1160bf5b50b62, type: 3}
 948:       insertIndex: -1
 949:       addedObject: {fileID: 893096004}
 950:   m_SourcePrefab: {fileID: 100100000, guid: 79d81dc0bb20d5a409d1160bf5b50b62, type: 3}
 951: --- !u!1 &330585543
 952: GameObject:
 953:   m_ObjectHideFlags: 0
 954:   m_CorrespondingSourceObject: {fileID: 0}
 955:   m_PrefabInstance: {fileID: 0}
 956:   m_PrefabAsset: {fileID: 0}
 957:   serializedVersion: 6
 958:   m_Component:
 959:   - component: {fileID: 330585546}
 960:   - component: {fileID: 330585545}
 961:   - component: {fileID: 330585544}
 962:   - component: {fileID: 330585547}
 963:   - component: {fileID: 330585548}
 964:   m_Layer: 0
 965:   m_Name: Main Camera
 966:   m_TagString: MainCamera
 967:   m_Icon: {fileID: 0}
 968:   m_NavMeshLayer: 0
 969:   m_StaticEditorFlags: 0
 970:   m_IsActive: 1
 971: --- !u!81 &330585544
 972: AudioListener:
 973:   m_ObjectHideFlags: 0
 974:   m_CorrespondingSourceObject: {fileID: 0}
 975:   m_PrefabInstance: {fileID: 0}
 976:   m_PrefabAsset: {fileID: 0}
 977:   m_GameObject: {fileID: 330585543}
 978:   m_Enabled: 1
 979: --- !u!20 &330585545
 980: Camera:
 981:   m_ObjectHideFlags: 0
 982:   m_CorrespondingSourceObject: {fileID: 0}
 983:   m_PrefabInstance: {fileID: 0}
 984:   m_PrefabAsset: {fileID: 0}
 985:   m_GameObject: {fileID: 330585543}
 986:   m_Enabled: 1
 987:   serializedVersion: 2
 988:   m_ClearFlags: 1
 989:   m_BackGroundColor: {r: 0.19215687, g: 0.3019608, b: 0.4745098, a: 0}
 990:   m_projectionMatrixMode: 1
 991:   m_GateFitMode: 2
 992:   m_FOVAxisMode: 0
 993:   m_Iso: 200
 994:   m_ShutterSpeed: 0.005
 995:   m_Aperture: 16
 996:   m_FocusDistance: 10
 997:   m_FocalLength: 50
 998:   m_BladeCount: 5
 999:   m_Curvature: {x: 2, y: 11}
1000:   m_BarrelClipping: 0.25
1001:   m_Anamorphism: 0
1002:   m_SensorSize: {x: 36, y: 24}
1003:   m_LensShift: {x: 0, y: 0}
1004:   m_NormalizedViewPortRect:
1005:     serializedVersion: 2
1006:     x: 0
1007:     y: 0
1008:     width: 1
1009:     height: 1
1010:   near clip plane: 0.01
1011:   far clip plane: 1000
1012:   field of view: 70
1013:   orthographic: 0
1014:   orthographic size: 5
1015:   m_Depth: -1
1016:   m_CullingMask:
1017:     serializedVersion: 2
1018:     m_Bits: 4294967295
1019:   m_RenderingPath: -1
1020:   m_TargetTexture: {fileID: 0}
1021:   m_TargetDisplay: 0
1022:   m_TargetEye: 3
1023:   m_HDR: 1
1024:   m_AllowMSAA: 1
1025:   m_AllowDynamicResolution: 0
1026:   m_ForceIntoRT: 0
1027:   m_OcclusionCulling: 1
1028:   m_StereoConvergence: 10
1029:   m_StereoSeparation: 0.022
1030: --- !u!4 &330585546
1031: Transform:
1032:   m_ObjectHideFlags: 0
1033:   m_CorrespondingSourceObject: {fileID: 0}
1034:   m_PrefabInstance: {fileID: 0}
1035:   m_PrefabAsset: {fileID: 0}
1036:   m_GameObject: {fileID: 330585543}
1037:   serializedVersion: 2
1038:   m_LocalRotation: {x: -0.000000014901159, y: 0.0000000037252899, z: -0.000000002211891, w: 1}
1039:   m_LocalPosition: {x: 0, y: 1.54, z: 0.092999935}
1040:   m_LocalScale: {x: 1, y: 1, z: 1}
1041:   m_ConstrainProportionsScale: 0
1042:   m_Children:
1043:   - {fileID: 416958034}
1044:   m_Father: {fileID: 704732033}
1045:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
1046: --- !u!114 &330585547
1047: MonoBehaviour:
1048:   m_ObjectHideFlags: 0
1049:   m_CorrespondingSourceObject: {fileID: 0}
1050:   m_PrefabInstance: {fileID: 0}
1051:   m_PrefabAsset: {fileID: 0}
1052:   m_GameObject: {fileID: 330585543}
1053:   m_Enabled: 1
1054:   m_EditorHideFlags: 0
1055:   m_Script: {fileID: 11500000, guid: 84ac66361f224fe4eb0e39a5d051f951, type: 3}
1056:   m_Name: 
1057:   m_EditorClassIdentifier: 
1058:   playerController: {fileID: 704732036}
1059:   player: {fileID: 704732033}
1060:   sensibylity: 20
1061: --- !u!114 &330585548
1062: MonoBehaviour:
1063:   m_ObjectHideFlags: 0
1064:   m_CorrespondingSourceObject: {fileID: 0}
1065:   m_PrefabInstance: {fileID: 0}
1066:   m_PrefabAsset: {fileID: 0}
1067:   m_GameObject: {fileID: 330585543}
1068:   m_Enabled: 1
1069:   m_EditorHideFlags: 0
1070:   m_Script: {fileID: 11500000, guid: 62899f850307741f2a39c98a8b639597, type: 3}
1071:   m_Name: 
1072:   m_EditorClassIdentifier: 
1073:   m_Actions: {fileID: -944628639613478452, guid: 61918e08ac444e14cbca19e224d7d22e, type: 3}
1074:   m_NotificationBehavior: 0
1075:   m_UIInputModule: {fileID: 0}
1076:   m_DeviceLostEvent:
1077:     m_PersistentCalls:
1078:       m_Calls: []
1079:   m_DeviceRegainedEvent:
1080:     m_PersistentCalls:
1081:       m_Calls: []
1082:   m_ControlsChangedEvent:
1083:     m_PersistentCalls:
1084:       m_Calls: []
1085:   m_ActionEvents: []
1086:   m_NeverAutoSwitchControlSchemes: 0
1087:   m_DefaultControlScheme: 
1088:   m_DefaultActionMap: Player
1089:   m_SplitScreenIndex: -1
1090:   m_Camera: {fileID: 0}
1091: --- !u!1 &365391665
1092: GameObject:
1093:   m_ObjectHideFlags: 0
1094:   m_CorrespondingSourceObject: {fileID: 0}
1095:   m_PrefabInstance: {fileID: 0}
1096:   m_PrefabAsset: {fileID: 0}
1097:   serializedVersion: 6
1098:   m_Component:
1099:   - component: {fileID: 365391669}
1100:   - component: {fileID: 365391668}
1101:   - component: {fileID: 365391667}
1102:   - component: {fileID: 365391666}
1103:   m_Layer: 0
1104:   m_Name: p1 (7)
1105:   m_TagString: Floor
1106:   m_Icon: {fileID: 0}
1107:   m_NavMeshLayer: 0
1108:   m_StaticEditorFlags: 2147483647
1109:   m_IsActive: 0
1110: --- !u!64 &365391666
1111: MeshCollider:
1112:   m_ObjectHideFlags: 0
1113:   m_CorrespondingSourceObject: {fileID: 0}
1114:   m_PrefabInstance: {fileID: 0}
1115:   m_PrefabAsset: {fileID: 0}
1116:   m_GameObject: {fileID: 365391665}
1117:   m_Material: {fileID: 0}
1118:   m_IncludeLayers:
1119:     serializedVersion: 2
1120:     m_Bits: 0
1121:   m_ExcludeLayers:
1122:     serializedVersion: 2
1123:     m_Bits: 0
1124:   m_LayerOverridePriority: 0
1125:   m_IsTrigger: 0
1126:   m_ProvidesContacts: 0
1127:   m_Enabled: 1
1128:   serializedVersion: 5
1129:   m_Convex: 0
1130:   m_CookingOptions: 30
1131:   m_Mesh: {fileID: 10209, guid: 0000000000000000e000000000000000, type: 0}
1132: --- !u!23 &365391667
1133: MeshRenderer:
1134:   m_ObjectHideFlags: 0
1135:   m_CorrespondingSourceObject: {fileID: 0}
1136:   m_PrefabInstance: {fileID: 0}
1137:   m_PrefabAsset: {fileID: 0}
1138:   m_GameObject: {fileID: 365391665}
1139:   m_Enabled: 1
1140:   m_CastShadows: 1
1141:   m_ReceiveShadows: 1
1142:   m_DynamicOccludee: 1
1143:   m_StaticShadowCaster: 0
1144:   m_MotionVectors: 1
1145:   m_LightProbeUsage: 1
1146:   m_ReflectionProbeUsage: 1
1147:   m_RayTracingMode: 2
1148:   m_RayTraceProcedural: 0
1149:   m_RenderingLayerMask: 1
1150:   m_RendererPriority: 0
1151:   m_Materials:
1152:   - {fileID: 10303, guid: 0000000000000000f000000000000000, type: 0}
1153:   m_StaticBatchInfo:
1154:     firstSubMesh: 0
1155:     subMeshCount: 0
1156:   m_StaticBatchRoot: {fileID: 0}
1157:   m_ProbeAnchor: {fileID: 0}
1158:   m_LightProbeVolumeOverride: {fileID: 0}
1159:   m_ScaleInLightmap: 1
1160:   m_ReceiveGI: 1
1161:   m_PreserveUVs: 0
1162:   m_IgnoreNormalsForChartDetection: 0
1163:   m_ImportantGI: 0
1164:   m_StitchLightmapSeams: 1
1165:   m_SelectedEditorRenderState: 3
1166:   m_MinimumChartSize: 4
1167:   m_AutoUVMaxDistance: 0.5
1168:   m_AutoUVMaxAngle: 89
1169:   m_LightmapParameters: {fileID: 0}
1170:   m_SortingLayerID: 0
1171:   m_SortingLayer: 0
1172:   m_SortingOrder: 0
1173:   m_AdditionalVertexStreams: {fileID: 0}
1174: --- !u!33 &365391668
1175: MeshFilter:
1176:   m_ObjectHideFlags: 0
1177:   m_CorrespondingSourceObject: {fileID: 0}
1178:   m_PrefabInstance: {fileID: 0}
1179:   m_PrefabAsset: {fileID: 0}
1180:   m_GameObject: {fileID: 365391665}
1181:   m_Mesh: {fileID: 10209, guid: 0000000000000000e000000000000000, type: 0}
1182: --- !u!4 &365391669
1183: Transform:
1184:   m_ObjectHideFlags: 0
1185:   m_CorrespondingSourceObject: {fileID: 0}
1186:   m_PrefabInstance: {fileID: 0}
1187:   m_PrefabAsset: {fileID: 0}
1188:   m_GameObject: {fileID: 365391665}
1189:   serializedVersion: 2
1190:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
1191:   m_LocalPosition: {x: -0.37513876, y: 0, z: 26.940714}
1192:   m_LocalScale: {x: 5, y: 1, z: 5}
1193:   m_ConstrainProportionsScale: 0
1194:   m_Children: []
1195:   m_Father: {fileID: 0}
1196:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
1197: --- !u!1 &409258865
1198: GameObject:
1199:   m_ObjectHideFlags: 0
1200:   m_CorrespondingSourceObject: {fileID: 0}
1201:   m_PrefabInstance: {fileID: 0}
1202:   m_PrefabAsset: {fileID: 0}
1203:   serializedVersion: 6
1204:   m_Component:
1205:   - component: {fileID: 409258866}
1206:   - component: {fileID: 409258869}
1207:   - component: {fileID: 409258868}
1208:   - component: {fileID: 409258867}
1209:   m_Layer: 5
1210:   m_Name: Quit
1211:   m_TagString: Untagged
1212:   m_Icon: {fileID: 0}
1213:   m_NavMeshLayer: 0
1214:   m_StaticEditorFlags: 0
1215:   m_IsActive: 1
1216: --- !u!224 &409258866
1217: RectTransform:
1218:   m_ObjectHideFlags: 0
1219:   m_CorrespondingSourceObject: {fileID: 0}
1220:   m_PrefabInstance: {fileID: 0}
1221:   m_PrefabAsset: {fileID: 0}
1222:   m_GameObject: {fileID: 409258865}
1223:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
1224:   m_LocalPosition: {x: 0, y: 0, z: 0}
1225:   m_LocalScale: {x: 1, y: 1, z: 1}
1226:   m_ConstrainProportionsScale: 0
1227:   m_Children:
1228:   - {fileID: 99629577}
1229:   m_Father: {fileID: 61253949}
1230:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
1231:   m_AnchorMin: {x: 0.5, y: 0.5}
1232:   m_AnchorMax: {x: 0.5, y: 0.5}
1233:   m_AnchoredPosition: {x: 0, y: -149.2}
1234:   m_SizeDelta: {x: 169.1472, y: 69.4794}
1235:   m_Pivot: {x: 0.5, y: 0.5}
1236: --- !u!114 &409258867
1237: MonoBehaviour:
1238:   m_ObjectHideFlags: 0
1239:   m_CorrespondingSourceObject: {fileID: 0}
1240:   m_PrefabInstance: {fileID: 0}
1241:   m_PrefabAsset: {fileID: 0}
1242:   m_GameObject: {fileID: 409258865}
1243:   m_Enabled: 1
1244:   m_EditorHideFlags: 0
1245:   m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
1246:   m_Name: 
1247:   m_EditorClassIdentifier: 
1248:   m_Navigation:
1249:     m_Mode: 3
1250:     m_WrapAround: 0
1251:     m_SelectOnUp: {fileID: 0}
1252:     m_SelectOnDown: {fileID: 0}
1253:     m_SelectOnLeft: {fileID: 0}
1254:     m_SelectOnRight: {fileID: 0}
1255:   m_Transition: 1
1256:   m_Colors:
1257:     m_NormalColor: {r: 0.7075472, g: 0, b: 0, a: 0.14901961}
1258:     m_HighlightedColor: {r: 0.754717, g: 0.3025988, b: 0.3025988, a: 0.34117648}
1259:     m_PressedColor: {r: 0.7169812, g: 0.26041296, b: 0.26041296, a: 0.43137255}
1260:     m_SelectedColor: {r: 0.745283, g: 0.1511659, b: 0.1511659, a: 0.70980394}
1261:     m_DisabledColor: {r: 1, g: 0, b: 0, a: 1}
1262:     m_ColorMultiplier: 1
1263:     m_FadeDuration: 0.1
1264:   m_SpriteState:
1265:     m_HighlightedSprite: {fileID: 0}
1266:     m_PressedSprite: {fileID: 0}
1267:     m_SelectedSprite: {fileID: 0}
1268:     m_DisabledSprite: {fileID: 0}
1269:   m_AnimationTriggers:
1270:     m_NormalTrigger: Normal
1271:     m_HighlightedTrigger: Highlighted
1272:     m_PressedTrigger: Pressed
1273:     m_SelectedTrigger: Selected
1274:     m_DisabledTrigger: Disabled
1275:   m_Interactable: 1
1276:   m_TargetGraphic: {fileID: 409258868}
1277:   m_OnClick:
1278:     m_PersistentCalls:
1279:       m_Calls:
1280:       - m_Target: {fileID: 1338461}
1281:         m_TargetAssemblyTypeName: GameManager, Assembly-CSharp
1282:         m_MethodName: PlayGame
1283:         m_Mode: 1
1284:         m_Arguments:
1285:           m_ObjectArgument: {fileID: 0}
1286:           m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
1287:           m_IntArgument: 0
1288:           m_FloatArgument: 0
1289:           m_StringArgument: 
1290:           m_BoolArgument: 0
1291:         m_CallState: 2
1292: --- !u!114 &409258868
1293: MonoBehaviour:
1294:   m_ObjectHideFlags: 0
1295:   m_CorrespondingSourceObject: {fileID: 0}
1296:   m_PrefabInstance: {fileID: 0}
1297:   m_PrefabAsset: {fileID: 0}
1298:   m_GameObject: {fileID: 409258865}
1299:   m_Enabled: 1
1300:   m_EditorHideFlags: 0
1301:   m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
1302:   m_Name: 
1303:   m_EditorClassIdentifier: 
1304:   m_Material: {fileID: 0}
1305:   m_Color: {r: 1, g: 1, b: 1, a: 1}
1306:   m_RaycastTarget: 1
1307:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
1308:   m_Maskable: 1
1309:   m_OnCullStateChanged:
1310:     m_PersistentCalls:
1311:       m_Calls: []
1312:   m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
1313:   m_Type: 1
1314:   m_PreserveAspect: 0
1315:   m_FillCenter: 1
1316:   m_FillMethod: 4
1317:   m_FillAmount: 1
1318:   m_FillClockwise: 1
1319:   m_FillOrigin: 0
1320:   m_UseSpriteMesh: 0
1321:   m_PixelsPerUnitMultiplier: 1
1322: --- !u!222 &409258869
1323: CanvasRenderer:
1324:   m_ObjectHideFlags: 0
1325:   m_CorrespondingSourceObject: {fileID: 0}
1326:   m_PrefabInstance: {fileID: 0}
1327:   m_PrefabAsset: {fileID: 0}
1328:   m_GameObject: {fileID: 409258865}
1329:   m_CullTransparentMesh: 1
1330: --- !u!1 &416958033
1331: GameObject:
1332:   m_ObjectHideFlags: 0
1333:   m_CorrespondingSourceObject: {fileID: 0}
1334:   m_PrefabInstance: {fileID: 0}
1335:   m_PrefabAsset: {fileID: 0}
1336:   serializedVersion: 6
1337:   m_Component:
1338:   - component: {fileID: 416958034}
1339:   - component: {fileID: 416958035}
1340:   m_Layer: 0
1341:   m_Name: Point Light
1342:   m_TagString: Untagged
1343:   m_Icon: {fileID: 0}
1344:   m_NavMeshLayer: 0
1345:   m_StaticEditorFlags: 0
1346:   m_IsActive: 1
1347: --- !u!4 &416958034
1348: Transform:
1349:   m_ObjectHideFlags: 0
1350:   m_CorrespondingSourceObject: {fileID: 0}
1351:   m_PrefabInstance: {fileID: 0}
1352:   m_PrefabAsset: {fileID: 0}
1353:   m_GameObject: {fileID: 416958033}
1354:   serializedVersion: 2
1355:   m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
1356:   m_LocalPosition: {x: 0, y: 0, z: 0.084}
1357:   m_LocalScale: {x: 1, y: 1, z: 1}
1358:   m_ConstrainProportionsScale: 0
1359:   m_Children: []
1360:   m_Father: {fileID: 330585546}
1361:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
1362: --- !u!108 &416958035
1363: Light:
1364:   m_ObjectHideFlags: 0
1365:   m_CorrespondingSourceObject: {fileID: 0}
1366:   m_PrefabInstance: {fileID: 0}
1367:   m_PrefabAsset: {fileID: 0}
1368:   m_GameObject: {fileID: 416958033}
1369:   m_Enabled: 1
1370:   serializedVersion: 10
1371:   m_Type: 2
1372:   m_Shape: 0
1373:   m_Color: {r: 1, g: 1, b: 1, a: 1}
1374:   m_Intensity: 1
1375:   m_Range: 1.6173757
1376:   m_SpotAngle: 30
1377:   m_InnerSpotAngle: 21.80208
1378:   m_CookieSize: 10
1379:   m_Shadows:
1380:     m_Type: 1
1381:     m_Resolution: -1
1382:     m_CustomResolution: -1
1383:     m_Strength: 1
1384:     m_Bias: 0.05
1385:     m_NormalBias: 0.4
1386:     m_NearPlane: 0.2
1387:     m_CullingMatrixOverride:
1388:       e00: 1
1389:       e01: 0
1390:       e02: 0
1391:       e03: 0
1392:       e10: 0
1393:       e11: 1
1394:       e12: 0
1395:       e13: 0
1396:       e20: 0
1397:       e21: 0
1398:       e22: 1
1399:       e23: 0
1400:       e30: 0
1401:       e31: 0
1402:       e32: 0
1403:       e33: 1
1404:     m_UseCullingMatrixOverride: 0
1405:   m_Cookie: {fileID: 0}
1406:   m_DrawHalo: 0
1407:   m_Flare: {fileID: 0}
1408:   m_RenderMode: 0
1409:   m_CullingMask:
1410:     serializedVersion: 2
1411:     m_Bits: 4294967295
1412:   m_RenderingLayerMask: 1
1413:   m_Lightmapping: 4
1414:   m_LightShadowCasterMode: 0
1415:   m_AreaSize: {x: 1, y: 1}
1416:   m_BounceIntensity: 1
1417:   m_ColorTemperature: 6570
1418:   m_UseColorTemperature: 0
1419:   m_BoundingSphereOverride: {x: 0, y: 0, z: 0, w: 0}
1420:   m_UseBoundingSphereOverride: 0
1421:   m_UseViewFrustumForShadowCasterCull: 1
1422:   m_ShadowRadius: 0
1423:   m_ShadowAngle: 0
1424: --- !u!1 &421915865
1425: GameObject:
1426:   m_ObjectHideFlags: 0
1427:   m_CorrespondingSourceObject: {fileID: 0}
1428:   m_PrefabInstance: {fileID: 0}
1429:   m_PrefabAsset: {fileID: 0}
1430:   serializedVersion: 6
1431:   m_Component:
1432:   - component: {fileID: 421915866}
1433:   - component: {fileID: 421915868}
1434:   - component: {fileID: 421915867}
1435:   m_Layer: 5
1436:   m_Name: Text (TMP)
1437:   m_TagString: Untagged
1438:   m_Icon: {fileID: 0}
1439:   m_NavMeshLayer: 0
1440:   m_StaticEditorFlags: 0
1441:   m_IsActive: 1
1442: --- !u!224 &421915866
1443: RectTransform:
1444:   m_ObjectHideFlags: 0
1445:   m_CorrespondingSourceObject: {fileID: 0}
1446:   m_PrefabInstance: {fileID: 0}
1447:   m_PrefabAsset: {fileID: 0}
1448:   m_GameObject: {fileID: 421915865}
1449:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
1450:   m_LocalPosition: {x: 0, y: 0, z: 0}
1451:   m_LocalScale: {x: 1, y: 1, z: 1}
1452:   m_ConstrainProportionsScale: 0
1453:   m_Children: []
1454:   m_Father: {fileID: 1238725046}
1455:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
1456:   m_AnchorMin: {x: 0, y: 0}
1457:   m_AnchorMax: {x: 1, y: 1}
1458:   m_AnchoredPosition: {x: -180.5, y: 0}
1459:   m_SizeDelta: {x: 0, y: 0}
1460:   m_Pivot: {x: 0.5, y: 0.5}
1461: --- !u!114 &421915867
1462: MonoBehaviour:
1463:   m_ObjectHideFlags: 0
1464:   m_CorrespondingSourceObject: {fileID: 0}
1465:   m_PrefabInstance: {fileID: 0}
1466:   m_PrefabAsset: {fileID: 0}
1467:   m_GameObject: {fileID: 421915865}
1468:   m_Enabled: 1
1469:   m_EditorHideFlags: 0
1470:   m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
1471:   m_Name: 
1472:   m_EditorClassIdentifier: 
1473:   m_Material: {fileID: 0}
1474:   m_Color: {r: 1, g: 1, b: 1, a: 1}
1475:   m_RaycastTarget: 1
1476:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
1477:   m_Maskable: 1
1478:   m_OnCullStateChanged:
1479:     m_PersistentCalls:
1480:       m_Calls: []
1481:   m_text: Pantalla Completa
1482:   m_isRightToLeft: 0
1483:   m_fontAsset: {fileID: 11400000, guid: 125cb55b44b24c4393181402bc6200e6, type: 2}
1484:   m_sharedMaterial: {fileID: 2100000, guid: d75b8f41e959450c84ac6e967084d3e1, type: 2}
1485:   m_fontSharedMaterials: []
1486:   m_fontMaterial: {fileID: 0}
1487:   m_fontMaterials: []
1488:   m_fontColor32:
1489:     serializedVersion: 2
1490:     rgba: 4281216654
1491:   m_fontColor: {r: 0.5566038, g: 0.18115878, b: 0.18115878, a: 1}
1492:   m_enableVertexGradient: 0
1493:   m_colorMode: 3
1494:   m_fontColorGradient:
1495:     topLeft: {r: 1, g: 1, b: 1, a: 1}
1496:     topRight: {r: 1, g: 1, b: 1, a: 1}
1497:     bottomLeft: {r: 1, g: 1, b: 1, a: 1}
1498:     bottomRight: {r: 1, g: 1, b: 1, a: 1}
1499:   m_fontColorGradientPreset: {fileID: 0}
1500:   m_spriteAsset: {fileID: 0}
1501:   m_tintAllSprites: 0
1502:   m_StyleSheet: {fileID: 0}
1503:   m_TextStyleHashCode: -1183493901
1504:   m_overrideHtmlColors: 0
1505:   m_faceColor:
1506:     serializedVersion: 2
1507:     rgba: 4294967295
1508:   m_fontSize: 40
1509:   m_fontSizeBase: 40
1510:   m_fontWeight: 400
1511:   m_enableAutoSizing: 0
1512:   m_fontSizeMin: 0
1513:   m_fontSizeMax: 0
1514:   m_fontStyle: 0
1515:   m_HorizontalAlignment: 2
1516:   m_VerticalAlignment: 512
1517:   m_textAlignment: 65535
1518:   m_characterSpacing: 0
1519:   m_wordSpacing: 0
1520:   m_lineSpacing: 0
1521:   m_lineSpacingMax: 0
1522:   m_paragraphSpacing: 0
1523:   m_charWidthMaxAdj: 0
1524:   m_enableWordWrapping: 0
1525:   m_wordWrappingRatios: 0.4
1526:   m_overflowMode: 0
1527:   m_linkedTextComponent: {fileID: 0}
1528:   parentLinkedComponent: {fileID: 0}
1529:   m_enableKerning: 0
1530:   m_enableExtraPadding: 0
1531:   checkPaddingRequired: 0
1532:   m_isRichText: 1
1533:   m_parseCtrlCharacters: 1
1534:   m_isOrthographic: 1
1535:   m_isCullingEnabled: 0
1536:   m_horizontalMapping: 0
1537:   m_verticalMapping: 0
1538:   m_uvLineOffset: 0
1539:   m_geometrySortingOrder: 0
1540:   m_IsTextObjectScaleStatic: 0
1541:   m_VertexBufferAutoSizeReduction: 0
1542:   m_useMaxVisibleDescender: 1
1543:   m_pageToDisplay: 1
1544:   m_margin: {x: 0, y: 0, z: 0, w: 0}
1545:   m_isUsingLegacyAnimationComponent: 0
1546:   m_isVolumetricText: 0
1547:   m_hasFontAssetChanged: 0
1548:   m_baseMaterial: {fileID: 0}
1549:   m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
1550: --- !u!222 &421915868
1551: CanvasRenderer:
1552:   m_ObjectHideFlags: 0
1553:   m_CorrespondingSourceObject: {fileID: 0}
1554:   m_PrefabInstance: {fileID: 0}
1555:   m_PrefabAsset: {fileID: 0}
1556:   m_GameObject: {fileID: 421915865}
1557:   m_CullTransparentMesh: 1
1558: --- !u!1 &454505833
1559: GameObject:
1560:   m_ObjectHideFlags: 0
1561:   m_CorrespondingSourceObject: {fileID: 0}
1562:   m_PrefabInstance: {fileID: 0}
1563:   m_PrefabAsset: {fileID: 0}
1564:   serializedVersion: 6
1565:   m_Component:
1566:   - component: {fileID: 454505834}
1567:   - component: {fileID: 454505837}
1568:   - component: {fileID: 454505836}
1569:   - component: {fileID: 454505835}
1570:   m_Layer: 5
1571:   m_Name: options
1572:   m_TagString: Untagged
1573:   m_Icon: {fileID: 0}
1574:   m_NavMeshLayer: 0
1575:   m_StaticEditorFlags: 0
1576:   m_IsActive: 1
1577: --- !u!224 &454505834
1578: RectTransform:
1579:   m_ObjectHideFlags: 0
1580:   m_CorrespondingSourceObject: {fileID: 0}
1581:   m_PrefabInstance: {fileID: 0}
1582:   m_PrefabAsset: {fileID: 0}
1583:   m_GameObject: {fileID: 454505833}
1584:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
1585:   m_LocalPosition: {x: 0, y: 0, z: 0}
1586:   m_LocalScale: {x: 1, y: 1, z: 1}
1587:   m_ConstrainProportionsScale: 0
1588:   m_Children:
1589:   - {fileID: 760135321}
1590:   m_Father: {fileID: 61253949}
1591:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
1592:   m_AnchorMin: {x: 0.5, y: 0.5}
1593:   m_AnchorMax: {x: 0.5, y: 0.5}
1594:   m_AnchoredPosition: {x: 0, y: -39.1}
1595:   m_SizeDelta: {x: 169.1472, y: 69.4794}
1596:   m_Pivot: {x: 0.5, y: 0.5}
1597: --- !u!114 &454505835
1598: MonoBehaviour:
1599:   m_ObjectHideFlags: 0
1600:   m_CorrespondingSourceObject: {fileID: 0}
1601:   m_PrefabInstance: {fileID: 0}
1602:   m_PrefabAsset: {fileID: 0}
1603:   m_GameObject: {fileID: 454505833}
1604:   m_Enabled: 1
1605:   m_EditorHideFlags: 0
1606:   m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
1607:   m_Name: 
1608:   m_EditorClassIdentifier: 
1609:   m_Navigation:
1610:     m_Mode: 3
1611:     m_WrapAround: 0
1612:     m_SelectOnUp: {fileID: 0}
1613:     m_SelectOnDown: {fileID: 0}
1614:     m_SelectOnLeft: {fileID: 0}
1615:     m_SelectOnRight: {fileID: 0}
1616:   m_Transition: 1
1617:   m_Colors:
1618:     m_NormalColor: {r: 0.7075472, g: 0, b: 0, a: 0.14901961}
1619:     m_HighlightedColor: {r: 0.754717, g: 0.3025988, b: 0.3025988, a: 0.34117648}
1620:     m_PressedColor: {r: 0.7169812, g: 0.26041296, b: 0.26041296, a: 0.43137255}
1621:     m_SelectedColor: {r: 0.745283, g: 0.1511659, b: 0.1511659, a: 0.70980394}
1622:     m_DisabledColor: {r: 1, g: 0, b: 0, a: 1}
1623:     m_ColorMultiplier: 1
1624:     m_FadeDuration: 0.1
1625:   m_SpriteState:
1626:     m_HighlightedSprite: {fileID: 0}
1627:     m_PressedSprite: {fileID: 0}
1628:     m_SelectedSprite: {fileID: 0}
1629:     m_DisabledSprite: {fileID: 0}
1630:   m_AnimationTriggers:
1631:     m_NormalTrigger: Normal
1632:     m_HighlightedTrigger: Highlighted
1633:     m_PressedTrigger: Pressed
1634:     m_SelectedTrigger: Selected
1635:     m_DisabledTrigger: Disabled
1636:   m_Interactable: 1
1637:   m_TargetGraphic: {fileID: 454505836}
1638:   m_OnClick:
1639:     m_PersistentCalls:
1640:       m_Calls:
1641:       - m_Target: {fileID: 1338461}
1642:         m_TargetAssemblyTypeName: GameManager, Assembly-CSharp
1643:         m_MethodName: Options
1644:         m_Mode: 1
1645:         m_Arguments:
1646:           m_ObjectArgument: {fileID: 0}
1647:           m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
1648:           m_IntArgument: 0
1649:           m_FloatArgument: 0
1650:           m_StringArgument: 
1651:           m_BoolArgument: 0
1652:         m_CallState: 2
1653: --- !u!114 &454505836
1654: MonoBehaviour:
1655:   m_ObjectHideFlags: 0
1656:   m_CorrespondingSourceObject: {fileID: 0}
1657:   m_PrefabInstance: {fileID: 0}
1658:   m_PrefabAsset: {fileID: 0}
1659:   m_GameObject: {fileID: 454505833}
1660:   m_Enabled: 1
1661:   m_EditorHideFlags: 0
1662:   m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
1663:   m_Name: 
1664:   m_EditorClassIdentifier: 
1665:   m_Material: {fileID: 0}
1666:   m_Color: {r: 1, g: 1, b: 1, a: 1}
1667:   m_RaycastTarget: 1
1668:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
1669:   m_Maskable: 1
1670:   m_OnCullStateChanged:
1671:     m_PersistentCalls:
1672:       m_Calls: []
1673:   m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
1674:   m_Type: 1
1675:   m_PreserveAspect: 0
1676:   m_FillCenter: 1
1677:   m_FillMethod: 4
1678:   m_FillAmount: 1
1679:   m_FillClockwise: 1
1680:   m_FillOrigin: 0
1681:   m_UseSpriteMesh: 0
1682:   m_PixelsPerUnitMultiplier: 1
1683: --- !u!222 &454505837
1684: CanvasRenderer:
1685:   m_ObjectHideFlags: 0
1686:   m_CorrespondingSourceObject: {fileID: 0}
1687:   m_PrefabInstance: {fileID: 0}
1688:   m_PrefabAsset: {fileID: 0}
1689:   m_GameObject: {fileID: 454505833}
1690:   m_CullTransparentMesh: 1
1691: --- !u!4 &468900850 stripped
1692: Transform:
1693:   m_CorrespondingSourceObject: {fileID: 1852576806548013000, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
1694:   m_PrefabInstance: {fileID: 1614476352}
1695:   m_PrefabAsset: {fileID: 0}
1696: --- !u!1 &523467897
1697: GameObject:
1698:   m_ObjectHideFlags: 0
1699:   m_CorrespondingSourceObject: {fileID: 0}
1700:   m_PrefabInstance: {fileID: 0}
1701:   m_PrefabAsset: {fileID: 0}
1702:   serializedVersion: 6
1703:   m_Component:
1704:   - component: {fileID: 523467898}
1705:   - component: {fileID: 523467900}
1706:   - component: {fileID: 523467899}
1707:   m_Layer: 5
1708:   m_Name: Text (TMP)
1709:   m_TagString: Untagged
1710:   m_Icon: {fileID: 0}
1711:   m_NavMeshLayer: 0
1712:   m_StaticEditorFlags: 0
1713:   m_IsActive: 1
1714: --- !u!224 &523467898
1715: RectTransform:
1716:   m_ObjectHideFlags: 0
1717:   m_CorrespondingSourceObject: {fileID: 0}
1718:   m_PrefabInstance: {fileID: 0}
1719:   m_PrefabAsset: {fileID: 0}
1720:   m_GameObject: {fileID: 523467897}
1721:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
1722:   m_LocalPosition: {x: 0, y: 0, z: 0}
1723:   m_LocalScale: {x: 1, y: 1, z: 1}
1724:   m_ConstrainProportionsScale: 0
1725:   m_Children: []
1726:   m_Father: {fileID: 556929966}
1727:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
1728:   m_AnchorMin: {x: 0, y: 0}
1729:   m_AnchorMax: {x: 1, y: 1}
1730:   m_AnchoredPosition: {x: 0, y: 0}
1731:   m_SizeDelta: {x: 0, y: 0}
1732:   m_Pivot: {x: 0.5, y: 0.5}
1733: --- !u!114 &523467899
1734: MonoBehaviour:
1735:   m_ObjectHideFlags: 0
1736:   m_CorrespondingSourceObject: {fileID: 0}
1737:   m_PrefabInstance: {fileID: 0}
1738:   m_PrefabAsset: {fileID: 0}
1739:   m_GameObject: {fileID: 523467897}
1740:   m_Enabled: 1
1741:   m_EditorHideFlags: 0
1742:   m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
1743:   m_Name: 
1744:   m_EditorClassIdentifier: 
1745:   m_Material: {fileID: 0}
1746:   m_Color: {r: 1, g: 1, b: 1, a: 1}
1747:   m_RaycastTarget: 1
1748:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
1749:   m_Maskable: 1
1750:   m_OnCullStateChanged:
1751:     m_PersistentCalls:
1752:       m_Calls: []
1753:   m_text: Continue
1754:   m_isRightToLeft: 0
1755:   m_fontAsset: {fileID: 11400000, guid: 125cb55b44b24c4393181402bc6200e6, type: 2}
1756:   m_sharedMaterial: {fileID: 2100000, guid: d75b8f41e959450c84ac6e967084d3e1, type: 2}
1757:   m_fontSharedMaterials: []
1758:   m_fontMaterial: {fileID: 0}
1759:   m_fontMaterials: []
1760:   m_fontColor32:
1761:     serializedVersion: 2
1762:     rgba: 4281216654
1763:   m_fontColor: {r: 0.5566038, g: 0.18115878, b: 0.18115878, a: 1}
1764:   m_enableVertexGradient: 0
1765:   m_colorMode: 3
1766:   m_fontColorGradient:
1767:     topLeft: {r: 1, g: 1, b: 1, a: 1}
1768:     topRight: {r: 1, g: 1, b: 1, a: 1}
1769:     bottomLeft: {r: 1, g: 1, b: 1, a: 1}
1770:     bottomRight: {r: 1, g: 1, b: 1, a: 1}
1771:   m_fontColorGradientPreset: {fileID: 0}
1772:   m_spriteAsset: {fileID: 0}
1773:   m_tintAllSprites: 0
1774:   m_StyleSheet: {fileID: 0}
1775:   m_TextStyleHashCode: -1183493901
1776:   m_overrideHtmlColors: 0
1777:   m_faceColor:
1778:     serializedVersion: 2
1779:     rgba: 4294967295
1780:   m_fontSize: 50
1781:   m_fontSizeBase: 50
1782:   m_fontWeight: 400
1783:   m_enableAutoSizing: 0
1784:   m_fontSizeMin: 0
1785:   m_fontSizeMax: 0
1786:   m_fontStyle: 0
1787:   m_HorizontalAlignment: 2
1788:   m_VerticalAlignment: 512
1789:   m_textAlignment: 65535
1790:   m_characterSpacing: 0
1791:   m_wordSpacing: 0
1792:   m_lineSpacing: 0
1793:   m_lineSpacingMax: 0
1794:   m_paragraphSpacing: 0
1795:   m_charWidthMaxAdj: 0
1796:   m_enableWordWrapping: 0
1797:   m_wordWrappingRatios: 0.4
1798:   m_overflowMode: 0
1799:   m_linkedTextComponent: {fileID: 0}
1800:   parentLinkedComponent: {fileID: 0}
1801:   m_enableKerning: 0
1802:   m_enableExtraPadding: 0
1803:   checkPaddingRequired: 0
1804:   m_isRichText: 1
1805:   m_parseCtrlCharacters: 1
1806:   m_isOrthographic: 1
1807:   m_isCullingEnabled: 0
1808:   m_horizontalMapping: 0
1809:   m_verticalMapping: 0
1810:   m_uvLineOffset: 0
1811:   m_geometrySortingOrder: 0
1812:   m_IsTextObjectScaleStatic: 0
1813:   m_VertexBufferAutoSizeReduction: 0
1814:   m_useMaxVisibleDescender: 1
1815:   m_pageToDisplay: 1
1816:   m_margin: {x: 0, y: 0, z: 0, w: 0}
1817:   m_isUsingLegacyAnimationComponent: 0
1818:   m_isVolumetricText: 0
1819:   m_hasFontAssetChanged: 0
1820:   m_baseMaterial: {fileID: 0}
1821:   m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
1822: --- !u!222 &523467900
1823: CanvasRenderer:
1824:   m_ObjectHideFlags: 0
1825:   m_CorrespondingSourceObject: {fileID: 0}
1826:   m_PrefabInstance: {fileID: 0}
1827:   m_PrefabAsset: {fileID: 0}
1828:   m_GameObject: {fileID: 523467897}
1829:   m_CullTransparentMesh: 1
1830: --- !u!1 &556929965
1831: GameObject:
1832:   m_ObjectHideFlags: 0
1833:   m_CorrespondingSourceObject: {fileID: 0}
1834:   m_PrefabInstance: {fileID: 0}
1835:   m_PrefabAsset: {fileID: 0}
1836:   serializedVersion: 6
1837:   m_Component:
1838:   - component: {fileID: 556929966}
1839:   - component: {fileID: 556929969}
1840:   - component: {fileID: 556929968}
1841:   - component: {fileID: 556929967}
1842:   m_Layer: 5
1843:   m_Name: Continue
1844:   m_TagString: Untagged
1845:   m_Icon: {fileID: 0}
1846:   m_NavMeshLayer: 0
1847:   m_StaticEditorFlags: 0
1848:   m_IsActive: 1
1849: --- !u!224 &556929966
1850: RectTransform:
1851:   m_ObjectHideFlags: 0
1852:   m_CorrespondingSourceObject: {fileID: 0}
1853:   m_PrefabInstance: {fileID: 0}
1854:   m_PrefabAsset: {fileID: 0}
1855:   m_GameObject: {fileID: 556929965}
1856:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
1857:   m_LocalPosition: {x: 0, y: 0, z: 0}
1858:   m_LocalScale: {x: 1, y: 1, z: 1}
1859:   m_ConstrainProportionsScale: 0
1860:   m_Children:
1861:   - {fileID: 523467898}
1862:   m_Father: {fileID: 61253949}
1863:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
1864:   m_AnchorMin: {x: 0.5, y: 0.5}
1865:   m_AnchorMax: {x: 0.5, y: 0.5}
1866:   m_AnchoredPosition: {x: 0, y: 67.9055}
1867:   m_SizeDelta: {x: 183.2658, y: 68.0685}
1868:   m_Pivot: {x: 0.5, y: 0.5}
1869: --- !u!114 &556929967
1870: MonoBehaviour:
1871:   m_ObjectHideFlags: 0
1872:   m_CorrespondingSourceObject: {fileID: 0}
1873:   m_PrefabInstance: {fileID: 0}
1874:   m_PrefabAsset: {fileID: 0}
1875:   m_GameObject: {fileID: 556929965}
1876:   m_Enabled: 1
1877:   m_EditorHideFlags: 0
1878:   m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
1879:   m_Name: 
1880:   m_EditorClassIdentifier: 
1881:   m_Navigation:
1882:     m_Mode: 3
1883:     m_WrapAround: 0
1884:     m_SelectOnUp: {fileID: 0}
1885:     m_SelectOnDown: {fileID: 0}
1886:     m_SelectOnLeft: {fileID: 0}
1887:     m_SelectOnRight: {fileID: 0}
1888:   m_Transition: 1
1889:   m_Colors:
1890:     m_NormalColor: {r: 0.7075472, g: 0, b: 0, a: 0.14901961}
1891:     m_HighlightedColor: {r: 0.754717, g: 0.3025988, b: 0.3025988, a: 0.34117648}
1892:     m_PressedColor: {r: 0.7169812, g: 0.26041296, b: 0.26041296, a: 0.43137255}
1893:     m_SelectedColor: {r: 0.745283, g: 0.1511659, b: 0.1511659, a: 0.70980394}
1894:     m_DisabledColor: {r: 1, g: 0, b: 0, a: 1}
1895:     m_ColorMultiplier: 1
1896:     m_FadeDuration: 0.1
1897:   m_SpriteState:
1898:     m_HighlightedSprite: {fileID: 0}
1899:     m_PressedSprite: {fileID: 0}
1900:     m_SelectedSprite: {fileID: 0}
1901:     m_DisabledSprite: {fileID: 0}
1902:   m_AnimationTriggers:
1903:     m_NormalTrigger: Normal
1904:     m_HighlightedTrigger: Highlighted
1905:     m_PressedTrigger: Pressed
1906:     m_SelectedTrigger: Selected
1907:     m_DisabledTrigger: Disabled
1908:   m_Interactable: 1
1909:   m_TargetGraphic: {fileID: 556929968}
1910:   m_OnClick:
1911:     m_PersistentCalls:
1912:       m_Calls:
1913:       - m_Target: {fileID: 1338461}
1914:         m_TargetAssemblyTypeName: GameManager, Assembly-CSharp
1915:         m_MethodName: Continue
1916:         m_Mode: 1
1917:         m_Arguments:
1918:           m_ObjectArgument: {fileID: 0}
1919:           m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
1920:           m_IntArgument: 0
1921:           m_FloatArgument: 0
1922:           m_StringArgument: 
1923:           m_BoolArgument: 0
1924:         m_CallState: 2
1925: --- !u!114 &556929968
1926: MonoBehaviour:
1927:   m_ObjectHideFlags: 0
1928:   m_CorrespondingSourceObject: {fileID: 0}
1929:   m_PrefabInstance: {fileID: 0}
1930:   m_PrefabAsset: {fileID: 0}
1931:   m_GameObject: {fileID: 556929965}
1932:   m_Enabled: 1
1933:   m_EditorHideFlags: 0
1934:   m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
1935:   m_Name: 
1936:   m_EditorClassIdentifier: 
1937:   m_Material: {fileID: 0}
1938:   m_Color: {r: 1, g: 1, b: 1, a: 1}
1939:   m_RaycastTarget: 1
1940:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
1941:   m_Maskable: 1
1942:   m_OnCullStateChanged:
1943:     m_PersistentCalls:
1944:       m_Calls: []
1945:   m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
1946:   m_Type: 1
1947:   m_PreserveAspect: 0
1948:   m_FillCenter: 1
1949:   m_FillMethod: 4
1950:   m_FillAmount: 1
1951:   m_FillClockwise: 1
1952:   m_FillOrigin: 0
1953:   m_UseSpriteMesh: 0
1954:   m_PixelsPerUnitMultiplier: 1
1955: --- !u!222 &556929969
1956: CanvasRenderer:
1957:   m_ObjectHideFlags: 0
1958:   m_CorrespondingSourceObject: {fileID: 0}
1959:   m_PrefabInstance: {fileID: 0}
1960:   m_PrefabAsset: {fileID: 0}
1961:   m_GameObject: {fileID: 556929965}
1962:   m_CullTransparentMesh: 1
1963: --- !u!1001 &575162934
1964: PrefabInstance:
1965:   m_ObjectHideFlags: 0
1966:   serializedVersion: 2
1967:   m_Modification:
1968:     serializedVersion: 3
1969:     m_TransformParent: {fileID: 0}
1970:     m_Modifications:
1971:     - target: {fileID: 1275084491436936, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
1972:       propertyPath: m_Name
1973:       value: Reliquia_Nivel1
1974:       objectReference: {fileID: 0}
1975:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
1976:       propertyPath: m_LocalScale.x
1977:       value: 2.5
1978:       objectReference: {fileID: 0}
1979:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
1980:       propertyPath: m_LocalScale.y
1981:       value: 2.5
1982:       objectReference: {fileID: 0}
1983:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
1984:       propertyPath: m_LocalScale.z
1985:       value: 2.5
1986:       objectReference: {fileID: 0}
1987:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
1988:       propertyPath: m_LocalPosition.x
1989:       value: 396.4556
1990:       objectReference: {fileID: 0}
1991:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
1992:       propertyPath: m_LocalPosition.y
1993:       value: 23.65
1994:       objectReference: {fileID: 0}
1995:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
1996:       propertyPath: m_LocalPosition.z
1997:       value: 564.69
1998:       objectReference: {fileID: 0}
1999:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
2000:       propertyPath: m_LocalRotation.w
2001:       value: 1
2002:       objectReference: {fileID: 0}
2003:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
2004:       propertyPath: m_LocalRotation.x
2005:       value: 0
2006:       objectReference: {fileID: 0}
2007:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
2008:       propertyPath: m_LocalRotation.y
2009:       value: 0
2010:       objectReference: {fileID: 0}
2011:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
2012:       propertyPath: m_LocalRotation.z
2013:       value: 0
2014:       objectReference: {fileID: 0}
2015:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
2016:       propertyPath: m_LocalEulerAnglesHint.x
2017:       value: 0
2018:       objectReference: {fileID: 0}
2019:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
2020:       propertyPath: m_LocalEulerAnglesHint.y
2021:       value: 0
2022:       objectReference: {fileID: 0}
2023:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
2024:       propertyPath: m_LocalEulerAnglesHint.z
2025:       value: 0
2026:       objectReference: {fileID: 0}
2027:     - target: {fileID: 64324016407306108, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
2028:       propertyPath: m_Convex
2029:       value: 1
2030:       objectReference: {fileID: 0}
2031:     - target: {fileID: 64324016407306108, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
2032:       propertyPath: m_IsTrigger
2033:       value: 1
2034:       objectReference: {fileID: 0}
2035:     m_RemovedComponents: []
2036:     m_RemovedGameObjects: []
2037:     m_AddedGameObjects: []
2038:     m_AddedComponents:
2039:     - targetCorrespondingSourceObject: {fileID: 1275084491436936, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
2040:       insertIndex: -1
2041:       addedObject: {fileID: 575162938}
2042:     - targetCorrespondingSourceObject: {fileID: 1275084491436936, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
2043:       insertIndex: -1
2044:       addedObject: {fileID: 575162937}
2045:     - targetCorrespondingSourceObject: {fileID: 1275084491436936, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
2046:       insertIndex: -1
2047:       addedObject: {fileID: 575162936}
2048:   m_SourcePrefab: {fileID: 100100000, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
2049: --- !u!1 &575162935 stripped
2050: GameObject:
2051:   m_CorrespondingSourceObject: {fileID: 1275084491436936, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
2052:   m_PrefabInstance: {fileID: 575162934}
2053:   m_PrefabAsset: {fileID: 0}
2054: --- !u!114 &575162936
2055: MonoBehaviour:
2056:   m_ObjectHideFlags: 0
2057:   m_CorrespondingSourceObject: {fileID: 0}
2058:   m_PrefabInstance: {fileID: 0}
2059:   m_PrefabAsset: {fileID: 0}
2060:   m_GameObject: {fileID: 575162935}
2061:   m_Enabled: 1
2062:   m_EditorHideFlags: 0
2063:   m_Script: {fileID: 11500000, guid: 1043a062320783447be6cac70c851695, type: 3}
2064:   m_Name: 
2065:   m_EditorClassIdentifier: 
2066:   pyramidCollider: {fileID: 893096004}
2067:   trapDoor: {fileID: 0}
2068:   audioSource: {fileID: 0}
2069:   trapSound: {fileID: 8300000, guid: 744507fd7cd5e9f4b96f6dd05be8ce32, type: 3}
2070:   visualModel: {fileID: 0}
2071: --- !u!82 &575162937
2072: AudioSource:
2073:   m_ObjectHideFlags: 0
2074:   m_CorrespondingSourceObject: {fileID: 0}
2075:   m_PrefabInstance: {fileID: 0}
2076:   m_PrefabAsset: {fileID: 0}
2077:   m_GameObject: {fileID: 575162935}
2078:   m_Enabled: 1
2079:   serializedVersion: 4
2080:   OutputAudioMixerGroup: {fileID: 0}
2081:   m_audioClip: {fileID: 8300000, guid: 744507fd7cd5e9f4b96f6dd05be8ce32, type: 3}
2082:   m_PlayOnAwake: 0
2083:   m_Volume: 1
2084:   m_Pitch: 1
2085:   Loop: 0
2086:   Mute: 0
2087:   Spatialize: 0
2088:   SpatializePostEffects: 0
2089:   Priority: 128
2090:   DopplerLevel: 1
2091:   MinDistance: 1
2092:   MaxDistance: 500
2093:   Pan2D: 0
2094:   rolloffMode: 0
2095:   BypassEffects: 0
2096:   BypassListenerEffects: 0
2097:   BypassReverbZones: 0
2098:   rolloffCustomCurve:
2099:     serializedVersion: 2
2100:     m_Curve:
2101:     - serializedVersion: 3
2102:       time: 0
2103:       value: 1
2104:       inSlope: 0
2105:       outSlope: 0
2106:       tangentMode: 0
2107:       weightedMode: 0
2108:       inWeight: 0.33333334
2109:       outWeight: 0.33333334
2110:     - serializedVersion: 3
2111:       time: 1
2112:       value: 0
2113:       inSlope: 0
2114:       outSlope: 0
2115:       tangentMode: 0
2116:       weightedMode: 0
2117:       inWeight: 0.33333334
2118:       outWeight: 0.33333334
2119:     m_PreInfinity: 2
2120:     m_PostInfinity: 2
2121:     m_RotationOrder: 4
2122:   panLevelCustomCurve:
2123:     serializedVersion: 2
2124:     m_Curve:
2125:     - serializedVersion: 3
2126:       time: 0
2127:       value: 0
2128:       inSlope: 0
2129:       outSlope: 0
2130:       tangentMode: 0
2131:       weightedMode: 0
2132:       inWeight: 0.33333334
2133:       outWeight: 0.33333334
2134:     m_PreInfinity: 2
2135:     m_PostInfinity: 2
2136:     m_RotationOrder: 4
2137:   spreadCustomCurve:
2138:     serializedVersion: 2
2139:     m_Curve:
2140:     - serializedVersion: 3
2141:       time: 0
2142:       value: 0
2143:       inSlope: 0
2144:       outSlope: 0
2145:       tangentMode: 0
2146:       weightedMode: 0
2147:       inWeight: 0.33333334
2148:       outWeight: 0.33333334
2149:     m_PreInfinity: 2
2150:     m_PostInfinity: 2
2151:     m_RotationOrder: 4
2152:   reverbZoneMixCustomCurve:
2153:     serializedVersion: 2
2154:     m_Curve:
2155:     - serializedVersion: 3
2156:       time: 0
2157:       value: 1
2158:       inSlope: 0
2159:       outSlope: 0
2160:       tangentMode: 0
2161:       weightedMode: 0
2162:       inWeight: 0.33333334
2163:       outWeight: 0.33333334
2164:     m_PreInfinity: 2
2165:     m_PostInfinity: 2
2166:     m_RotationOrder: 4
2167: --- !u!135 &575162938
2168: SphereCollider:
2169:   m_ObjectHideFlags: 0
2170:   m_CorrespondingSourceObject: {fileID: 0}
2171:   m_PrefabInstance: {fileID: 0}
2172:   m_PrefabAsset: {fileID: 0}
2173:   m_GameObject: {fileID: 575162935}
2174:   m_Material: {fileID: 0}
2175:   m_IncludeLayers:
2176:     serializedVersion: 2
2177:     m_Bits: 0
2178:   m_ExcludeLayers:
2179:     serializedVersion: 2
2180:     m_Bits: 0
2181:   m_LayerOverridePriority: 0
2182:   m_IsTrigger: 1
2183:   m_ProvidesContacts: 0
2184:   m_Enabled: 1
2185:   serializedVersion: 3
2186:   m_Radius: 1.2
2187:   m_Center: {x: 0, y: 0, z: 0}
2188: --- !u!1 &704732031 stripped
2189: GameObject:
2190:   m_CorrespondingSourceObject: {fileID: 919132149155446097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
2191:   m_PrefabInstance: {fileID: 1614476352}
2192:   m_PrefabAsset: {fileID: 0}
2193: --- !u!114 &704732032
2194: MonoBehaviour:
2195:   m_ObjectHideFlags: 0
2196:   m_CorrespondingSourceObject: {fileID: 0}
2197:   m_PrefabInstance: {fileID: 0}
2198:   m_PrefabAsset: {fileID: 0}
2199:   m_GameObject: {fileID: 704732031}
2200:   m_Enabled: 1
2201:   m_EditorHideFlags: 0
2202:   m_Script: {fileID: 11500000, guid: 62899f850307741f2a39c98a8b639597, type: 3}
2203:   m_Name: 
2204:   m_EditorClassIdentifier: 
2205:   m_Actions: {fileID: -944628639613478452, guid: 61918e08ac444e14cbca19e224d7d22e, type: 3}
2206:   m_NotificationBehavior: 0
2207:   m_UIInputModule: {fileID: 0}
2208:   m_DeviceLostEvent:
2209:     m_PersistentCalls:
2210:       m_Calls: []
2211:   m_DeviceRegainedEvent:
2212:     m_PersistentCalls:
2213:       m_Calls: []
2214:   m_ControlsChangedEvent:
2215:     m_PersistentCalls:
2216:       m_Calls: []
2217:   m_ActionEvents:
2218:   - m_PersistentCalls:
2219:       m_Calls:
2220:       - m_Target: {fileID: 704732036}
2221:         m_TargetAssemblyTypeName: PlayerController, Assembly-CSharp
2222:         m_MethodName: OnMove
2223:         m_Mode: 0
2224:         m_Arguments:
2225:           m_ObjectArgument: {fileID: 0}
2226:           m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
2227:           m_IntArgument: 0
2228:           m_FloatArgument: 0
2229:           m_StringArgument: 
2230:           m_BoolArgument: 0
2231:         m_CallState: 2
2232:     m_ActionId: 3556ade6-3575-4c57-8d1d-b160839c913f
2233:     m_ActionName: Player/move[/Keyboard/w,/Keyboard/s,/Keyboard/a,/Keyboard/d]
2234:   - m_PersistentCalls:
2235:       m_Calls:
2236:       - m_Target: {fileID: 330585547}
2237:         m_TargetAssemblyTypeName: CameraController, Assembly-CSharp
2238:         m_MethodName: OnCamera
2239:         m_Mode: 0
2240:         m_Arguments:
2241:           m_ObjectArgument: {fileID: 0}
2242:           m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
2243:           m_IntArgument: 0
2244:           m_FloatArgument: 0
2245:           m_StringArgument: 
2246:           m_BoolArgument: 0
2247:         m_CallState: 2
2248:     m_ActionId: be68993c-9671-480c-bb85-8137a41ba8d9
2249:     m_ActionName: Player/camera[/Mouse/delta]
2250:   - m_PersistentCalls:
2251:       m_Calls:
2252:       - m_Target: {fileID: 1338461}
2253:         m_TargetAssemblyTypeName: GameManager, Assembly-CSharp
2254:         m_MethodName: OnLight
2255:         m_Mode: 0
2256:         m_Arguments:
2257:           m_ObjectArgument: {fileID: 0}
2258:           m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
2259:           m_IntArgument: 0
2260:           m_FloatArgument: 0
2261:           m_StringArgument: 
2262:           m_BoolArgument: 0
2263:         m_CallState: 2
2264:     m_ActionId: c38b8394-7483-4dc5-b1fb-96a98f63fd3b
2265:     m_ActionName: Player/light[/Keyboard/f]
2266:   - m_PersistentCalls:
2267:       m_Calls:
2268:       - m_Target: {fileID: 704732036}
2269:         m_TargetAssemblyTypeName: PlayerController, Assembly-CSharp
2270:         m_MethodName: OnSprint
2271:         m_Mode: 0
2272:         m_Arguments:
2273:           m_ObjectArgument: {fileID: 0}
2274:           m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
2275:           m_IntArgument: 0
2276:           m_FloatArgument: 0
2277:           m_StringArgument: 
2278:           m_BoolArgument: 0
2279:         m_CallState: 2
2280:     m_ActionId: 75ccc69c-1bf6-43db-9f55-87e77bc43f3b
2281:     m_ActionName: Player/sprint[/Keyboard/shift]
2282:   m_NeverAutoSwitchControlSchemes: 0
2283:   m_DefaultControlScheme: 
2284:   m_DefaultActionMap: Player
2285:   m_SplitScreenIndex: -1
2286:   m_Camera: {fileID: 0}
2287: --- !u!4 &704732033 stripped
2288: Transform:
2289:   m_CorrespondingSourceObject: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
2290:   m_PrefabInstance: {fileID: 1614476352}
2291:   m_PrefabAsset: {fileID: 0}
2292: --- !u!65 &704732034
2293: BoxCollider:
2294:   m_ObjectHideFlags: 0
2295:   m_CorrespondingSourceObject: {fileID: 0}
2296:   m_PrefabInstance: {fileID: 0}
2297:   m_PrefabAsset: {fileID: 0}
2298:   m_GameObject: {fileID: 704732031}
2299:   m_Material: {fileID: 13400000, guid: a5f6016dd69f60e49b7414ff9467d5b0, type: 2}
2300:   m_IncludeLayers:
2301:     serializedVersion: 2
2302:     m_Bits: 0
2303:   m_ExcludeLayers:
2304:     serializedVersion: 2
2305:     m_Bits: 0
2306:   m_LayerOverridePriority: 0
2307:   m_IsTrigger: 0
2308:   m_ProvidesContacts: 0
2309:   m_Enabled: 1
2310:   serializedVersion: 3
2311:   m_Size: {x: 0.48773956, y: 1.7981253, z: 0.29429126}
2312:   m_Center: {x: -0.021459758, y: 0.8943939, z: 0.0036092997}
2313: --- !u!54 &704732035
2314: Rigidbody:
2315:   m_ObjectHideFlags: 0
2316:   m_CorrespondingSourceObject: {fileID: 0}
2317:   m_PrefabInstance: {fileID: 0}
2318:   m_PrefabAsset: {fileID: 0}
2319:   m_GameObject: {fileID: 704732031}
2320:   serializedVersion: 4
2321:   m_Mass: 1
2322:   m_Drag: 0
2323:   m_AngularDrag: 0.05
2324:   m_CenterOfMass: {x: 0, y: 0, z: 0}
2325:   m_InertiaTensor: {x: 1, y: 1, z: 1}
2326:   m_InertiaRotation: {x: 0, y: 0, z: 0, w: 1}
2327:   m_IncludeLayers:
2328:     serializedVersion: 2
2329:     m_Bits: 0
2330:   m_ExcludeLayers:
2331:     serializedVersion: 2
2332:     m_Bits: 0
2333:   m_ImplicitCom: 1
2334:   m_ImplicitTensor: 1
2335:   m_UseGravity: 1
2336:   m_IsKinematic: 0
2337:   m_Interpolate: 0
2338:   m_Constraints: 112
2339:   m_CollisionDetection: 0
2340: --- !u!114 &704732036
2341: MonoBehaviour:
2342:   m_ObjectHideFlags: 0
2343:   m_CorrespondingSourceObject: {fileID: 0}
2344:   m_PrefabInstance: {fileID: 0}
2345:   m_PrefabAsset: {fileID: 0}
2346:   m_GameObject: {fileID: 704732031}
2347:   m_Enabled: 1
2348:   m_EditorHideFlags: 0
2349:   m_Script: {fileID: 11500000, guid: 5488aaca5d5887e4b8fa44a5684df54d, type: 3}
2350:   m_Name: 
2351:   m_EditorClassIdentifier: 
2352:   suavizadoAnimacion: 0.1
2353:   speed: 5
2354:   velocidad: 0
2355:   GameOver: 0
2356:   safeZone: 0
2357:   gameManager: {fileID: 1338461}
2358: --- !u!95 &704732037
2359: Animator:
2360:   serializedVersion: 5
2361:   m_ObjectHideFlags: 0
2362:   m_CorrespondingSourceObject: {fileID: 0}
2363:   m_PrefabInstance: {fileID: 0}
2364:   m_PrefabAsset: {fileID: 0}
2365:   m_GameObject: {fileID: 704732031}
2366:   m_Enabled: 1
2367:   m_Avatar: {fileID: 0}
2368:   m_Controller: {fileID: 9100000, guid: e915368617579174c845e19e507ea122, type: 2}
2369:   m_CullingMode: 0
2370:   m_UpdateMode: 0
2371:   m_ApplyRootMotion: 0
2372:   m_LinearVelocityBlending: 0
2373:   m_StabilizeFeet: 0
2374:   m_WarningMessage: 
2375:   m_HasTransformHierarchy: 1
2376:   m_AllowConstantClipSamplingOptimization: 1
2377:   m_KeepAnimatorStateOnDisable: 0
2378:   m_WriteDefaultValuesOnDisable: 0
2379: --- !u!1 &751834279
2380: GameObject:
2381:   m_ObjectHideFlags: 0
2382:   m_CorrespondingSourceObject: {fileID: 0}
2383:   m_PrefabInstance: {fileID: 0}
2384:   m_PrefabAsset: {fileID: 0}
2385:   serializedVersion: 6
2386:   m_Component:
2387:   - component: {fileID: 751834282}
2388:   - component: {fileID: 751834281}
2389:   - component: {fileID: 751834280}
2390:   m_Layer: 0
2391:   m_Name: Point Light (1)
2392:   m_TagString: Untagged
2393:   m_Icon: {fileID: 0}
2394:   m_NavMeshLayer: 0
2395:   m_StaticEditorFlags: 0
2396:   m_IsActive: 1
2397: --- !u!114 &751834280
2398: MonoBehaviour:
2399:   m_ObjectHideFlags: 0
2400:   m_CorrespondingSourceObject: {fileID: 0}
2401:   m_PrefabInstance: {fileID: 0}
2402:   m_PrefabAsset: {fileID: 0}
2403:   m_GameObject: {fileID: 751834279}
2404:   m_Enabled: 1
2405:   m_EditorHideFlags: 0
2406:   m_Script: {fileID: 11500000, guid: 03aed3bc14b98634ea1df5ec16d00ada, type: 3}
2407:   m_Name: 
2408:   m_EditorClassIdentifier: 
2409:   esperaMinima: 0.1
2410:   esperaMaxima: 2
2411: --- !u!108 &751834281
2412: Light:
2413:   m_ObjectHideFlags: 0
2414:   m_CorrespondingSourceObject: {fileID: 0}
2415:   m_PrefabInstance: {fileID: 0}
2416:   m_PrefabAsset: {fileID: 0}
2417:   m_GameObject: {fileID: 751834279}
2418:   m_Enabled: 1
2419:   serializedVersion: 10
2420:   m_Type: 2
2421:   m_Shape: 0
2422:   m_Color: {r: 1, g: 1, b: 1, a: 1}
2423:   m_Intensity: 0.5
2424:   m_Range: 10
2425:   m_SpotAngle: 30
2426:   m_InnerSpotAngle: 21.80208
2427:   m_CookieSize: 10
2428:   m_Shadows:
2429:     m_Type: 1
2430:     m_Resolution: -1
2431:     m_CustomResolution: -1
2432:     m_Strength: 1
2433:     m_Bias: 0.05
2434:     m_NormalBias: 0.4
2435:     m_NearPlane: 0.2
2436:     m_CullingMatrixOverride:
2437:       e00: 1
2438:       e01: 0
2439:       e02: 0
2440:       e03: 0
2441:       e10: 0
2442:       e11: 1
2443:       e12: 0
2444:       e13: 0
2445:       e20: 0
2446:       e21: 0
2447:       e22: 1
2448:       e23: 0
2449:       e30: 0
2450:       e31: 0
2451:       e32: 0
2452:       e33: 1
2453:     m_UseCullingMatrixOverride: 0
2454:   m_Cookie: {fileID: 0}
2455:   m_DrawHalo: 0
2456:   m_Flare: {fileID: 0}
2457:   m_RenderMode: 0
2458:   m_CullingMask:
2459:     serializedVersion: 2
2460:     m_Bits: 4294967295
2461:   m_RenderingLayerMask: 1
2462:   m_Lightmapping: 4
2463:   m_LightShadowCasterMode: 0
2464:   m_AreaSize: {x: 1, y: 1}
2465:   m_BounceIntensity: 1
2466:   m_ColorTemperature: 6570
2467:   m_UseColorTemperature: 0
2468:   m_BoundingSphereOverride: {x: 0, y: 0, z: 0, w: 0}
2469:   m_UseBoundingSphereOverride: 0
2470:   m_UseViewFrustumForShadowCasterCull: 1
2471:   m_ShadowRadius: 0
2472:   m_ShadowAngle: 0
2473: --- !u!4 &751834282
2474: Transform:
2475:   m_ObjectHideFlags: 0
2476:   m_CorrespondingSourceObject: {fileID: 0}
2477:   m_PrefabInstance: {fileID: 0}
2478:   m_PrefabAsset: {fileID: 0}
2479:   m_GameObject: {fileID: 751834279}
2480:   serializedVersion: 2
2481:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
2482:   m_LocalPosition: {x: 0, y: 2.905, z: 54.8}
2483:   m_LocalScale: {x: 1, y: 1, z: 1}
2484:   m_ConstrainProportionsScale: 0
2485:   m_Children: []
2486:   m_Father: {fileID: 0}
2487:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
2488: --- !u!1 &753868968
2489: GameObject:
2490:   m_ObjectHideFlags: 0
2491:   m_CorrespondingSourceObject: {fileID: 0}
2492:   m_PrefabInstance: {fileID: 0}
2493:   m_PrefabAsset: {fileID: 0}
2494:   serializedVersion: 6
2495:   m_Component:
2496:   - component: {fileID: 753868972}
2497:   - component: {fileID: 753868971}
2498:   - component: {fileID: 753868970}
2499:   - component: {fileID: 753868969}
2500:   m_Layer: 5
2501:   m_Name: Options
2502:   m_TagString: Untagged
2503:   m_Icon: {fileID: 0}
2504:   m_NavMeshLayer: 0
2505:   m_StaticEditorFlags: 0
2506:   m_IsActive: 0
2507: --- !u!114 &753868969
2508: MonoBehaviour:
2509:   m_ObjectHideFlags: 0
2510:   m_CorrespondingSourceObject: {fileID: 0}
2511:   m_PrefabInstance: {fileID: 0}
2512:   m_PrefabAsset: {fileID: 0}
2513:   m_GameObject: {fileID: 753868968}
2514:   m_Enabled: 1
2515:   m_EditorHideFlags: 0
2516:   m_Script: {fileID: 11500000, guid: dc42784cf147c0c48a680349fa168899, type: 3}
2517:   m_Name: 
2518:   m_EditorClassIdentifier: 
2519:   m_IgnoreReversedGraphics: 1
2520:   m_BlockingObjects: 0
2521:   m_BlockingMask:
2522:     serializedVersion: 2
2523:     m_Bits: 4294967295
2524: --- !u!114 &753868970
2525: MonoBehaviour:
2526:   m_ObjectHideFlags: 0
2527:   m_CorrespondingSourceObject: {fileID: 0}
2528:   m_PrefabInstance: {fileID: 0}
2529:   m_PrefabAsset: {fileID: 0}
2530:   m_GameObject: {fileID: 753868968}
2531:   m_Enabled: 1
2532:   m_EditorHideFlags: 0
2533:   m_Script: {fileID: 11500000, guid: 0cd44c1031e13a943bb63640046fad76, type: 3}
2534:   m_Name: 
2535:   m_EditorClassIdentifier: 
2536:   m_UiScaleMode: 1
2537:   m_ReferencePixelsPerUnit: 100
2538:   m_ScaleFactor: 1
2539:   m_ReferenceResolution: {x: 800, y: 600}
2540:   m_ScreenMatchMode: 0
2541:   m_MatchWidthOrHeight: 0
2542:   m_PhysicalUnit: 3
2543:   m_FallbackScreenDPI: 96
2544:   m_DefaultSpriteDPI: 96
2545:   m_DynamicPixelsPerUnit: 1
2546:   m_PresetInfoIsWorld: 0
2547: --- !u!223 &753868971
2548: Canvas:
2549:   m_ObjectHideFlags: 0
2550:   m_CorrespondingSourceObject: {fileID: 0}
2551:   m_PrefabInstance: {fileID: 0}
2552:   m_PrefabAsset: {fileID: 0}
2553:   m_GameObject: {fileID: 753868968}
2554:   m_Enabled: 1
2555:   serializedVersion: 3
2556:   m_RenderMode: 0
2557:   m_Camera: {fileID: 0}
2558:   m_PlaneDistance: 100
2559:   m_PixelPerfect: 0
2560:   m_ReceivesEvents: 1
2561:   m_OverrideSorting: 0
2562:   m_OverridePixelPerfect: 0
2563:   m_SortingBucketNormalizedSize: 0
2564:   m_VertexColorAlwaysGammaSpace: 0
2565:   m_AdditionalShaderChannelsFlag: 25
2566:   m_UpdateRectTransformForStandalone: 0
2567:   m_SortingLayerID: 0
2568:   m_SortingOrder: 0
2569:   m_TargetDisplay: 0
2570: --- !u!224 &753868972
2571: RectTransform:
2572:   m_ObjectHideFlags: 0
2573:   m_CorrespondingSourceObject: {fileID: 0}
2574:   m_PrefabInstance: {fileID: 0}
2575:   m_PrefabAsset: {fileID: 0}
2576:   m_GameObject: {fileID: 753868968}
2577:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
2578:   m_LocalPosition: {x: 0, y: 0, z: 0}
2579:   m_LocalScale: {x: 0, y: 0, z: 0}
2580:   m_ConstrainProportionsScale: 0
2581:   m_Children:
2582:   - {fileID: 17670199}
2583:   - {fileID: 1238725046}
2584:   - {fileID: 952072881}
2585:   - {fileID: 1750535927}
2586:   - {fileID: 1091955426}
2587:   m_Father: {fileID: 0}
2588:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
2589:   m_AnchorMin: {x: 0, y: 0}
2590:   m_AnchorMax: {x: 0, y: 0}
2591:   m_AnchoredPosition: {x: 0, y: 0}
2592:   m_SizeDelta: {x: 0, y: 0}
2593:   m_Pivot: {x: 0, y: 0}
2594: --- !u!1 &760135320
2595: GameObject:
2596:   m_ObjectHideFlags: 0
2597:   m_CorrespondingSourceObject: {fileID: 0}
2598:   m_PrefabInstance: {fileID: 0}
2599:   m_PrefabAsset: {fileID: 0}
2600:   serializedVersion: 6
2601:   m_Component:
2602:   - component: {fileID: 760135321}
2603:   - component: {fileID: 760135323}
2604:   - component: {fileID: 760135322}
2605:   m_Layer: 5
2606:   m_Name: Text (TMP)
2607:   m_TagString: Untagged
2608:   m_Icon: {fileID: 0}
2609:   m_NavMeshLayer: 0
2610:   m_StaticEditorFlags: 0
2611:   m_IsActive: 1
2612: --- !u!224 &760135321
2613: RectTransform:
2614:   m_ObjectHideFlags: 0
2615:   m_CorrespondingSourceObject: {fileID: 0}
2616:   m_PrefabInstance: {fileID: 0}
2617:   m_PrefabAsset: {fileID: 0}
2618:   m_GameObject: {fileID: 760135320}
2619:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
2620:   m_LocalPosition: {x: 0, y: 0, z: 0}
2621:   m_LocalScale: {x: 1, y: 1, z: 1}
2622:   m_ConstrainProportionsScale: 0
2623:   m_Children: []
2624:   m_Father: {fileID: 454505834}
2625:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
2626:   m_AnchorMin: {x: 0, y: 0}
2627:   m_AnchorMax: {x: 1, y: 1}
2628:   m_AnchoredPosition: {x: 0, y: 0}
2629:   m_SizeDelta: {x: 0, y: 0}
2630:   m_Pivot: {x: 0.5, y: 0.5}
2631: --- !u!114 &760135322
2632: MonoBehaviour:
2633:   m_ObjectHideFlags: 0
2634:   m_CorrespondingSourceObject: {fileID: 0}
2635:   m_PrefabInstance: {fileID: 0}
2636:   m_PrefabAsset: {fileID: 0}
2637:   m_GameObject: {fileID: 760135320}
2638:   m_Enabled: 1
2639:   m_EditorHideFlags: 0
2640:   m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
2641:   m_Name: 
2642:   m_EditorClassIdentifier: 
2643:   m_Material: {fileID: 0}
2644:   m_Color: {r: 1, g: 1, b: 1, a: 1}
2645:   m_RaycastTarget: 1
2646:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
2647:   m_Maskable: 1
2648:   m_OnCullStateChanged:
2649:     m_PersistentCalls:
2650:       m_Calls: []
2651:   m_text: Options
2652:   m_isRightToLeft: 0
2653:   m_fontAsset: {fileID: 11400000, guid: 125cb55b44b24c4393181402bc6200e6, type: 2}
2654:   m_sharedMaterial: {fileID: 2100000, guid: d75b8f41e959450c84ac6e967084d3e1, type: 2}
2655:   m_fontSharedMaterials: []
2656:   m_fontMaterial: {fileID: 0}
2657:   m_fontMaterials: []
2658:   m_fontColor32:
2659:     serializedVersion: 2
2660:     rgba: 4281216654
2661:   m_fontColor: {r: 0.5566038, g: 0.18115878, b: 0.18115878, a: 1}
2662:   m_enableVertexGradient: 0
2663:   m_colorMode: 3
2664:   m_fontColorGradient:
2665:     topLeft: {r: 1, g: 1, b: 1, a: 1}
2666:     topRight: {r: 1, g: 1, b: 1, a: 1}
2667:     bottomLeft: {r: 1, g: 1, b: 1, a: 1}
2668:     bottomRight: {r: 1, g: 1, b: 1, a: 1}
2669:   m_fontColorGradientPreset: {fileID: 0}
2670:   m_spriteAsset: {fileID: 0}
2671:   m_tintAllSprites: 0
2672:   m_StyleSheet: {fileID: 0}
2673:   m_TextStyleHashCode: -1183493901
2674:   m_overrideHtmlColors: 0
2675:   m_faceColor:
2676:     serializedVersion: 2
2677:     rgba: 4294967295
2678:   m_fontSize: 50
2679:   m_fontSizeBase: 50
2680:   m_fontWeight: 400
2681:   m_enableAutoSizing: 0
2682:   m_fontSizeMin: 0
2683:   m_fontSizeMax: 0
2684:   m_fontStyle: 0
2685:   m_HorizontalAlignment: 2
2686:   m_VerticalAlignment: 512
2687:   m_textAlignment: 65535
2688:   m_characterSpacing: 0
2689:   m_wordSpacing: 0
2690:   m_lineSpacing: 0
2691:   m_lineSpacingMax: 0
2692:   m_paragraphSpacing: 0
2693:   m_charWidthMaxAdj: 0
2694:   m_enableWordWrapping: 0
2695:   m_wordWrappingRatios: 0.4
2696:   m_overflowMode: 0
2697:   m_linkedTextComponent: {fileID: 0}
2698:   parentLinkedComponent: {fileID: 0}
2699:   m_enableKerning: 0
2700:   m_enableExtraPadding: 0
2701:   checkPaddingRequired: 0
2702:   m_isRichText: 1
2703:   m_parseCtrlCharacters: 1
2704:   m_isOrthographic: 1
2705:   m_isCullingEnabled: 0
2706:   m_horizontalMapping: 0
2707:   m_verticalMapping: 0
2708:   m_uvLineOffset: 0
2709:   m_geometrySortingOrder: 0
2710:   m_IsTextObjectScaleStatic: 0
2711:   m_VertexBufferAutoSizeReduction: 0
2712:   m_useMaxVisibleDescender: 1
2713:   m_pageToDisplay: 1
2714:   m_margin: {x: 0, y: 0, z: 0, w: 0}
2715:   m_isUsingLegacyAnimationComponent: 0
2716:   m_isVolumetricText: 0
2717:   m_hasFontAssetChanged: 0
2718:   m_baseMaterial: {fileID: 0}
2719:   m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
2720: --- !u!222 &760135323
2721: CanvasRenderer:
2722:   m_ObjectHideFlags: 0
2723:   m_CorrespondingSourceObject: {fileID: 0}
2724:   m_PrefabInstance: {fileID: 0}
2725:   m_PrefabAsset: {fileID: 0}
2726:   m_GameObject: {fileID: 760135320}
2727:   m_CullTransparentMesh: 1
2728: --- !u!1 &793788508
2729: GameObject:
2730:   m_ObjectHideFlags: 0
2731:   m_CorrespondingSourceObject: {fileID: 0}
2732:   m_PrefabInstance: {fileID: 0}
2733:   m_PrefabAsset: {fileID: 0}
2734:   serializedVersion: 6
2735:   m_Component:
2736:   - component: {fileID: 793788511}
2737:   - component: {fileID: 793788510}
2738:   - component: {fileID: 793788509}
2739:   m_Layer: 0
2740:   m_Name: Terrain
2741:   m_TagString: Untagged
2742:   m_Icon: {fileID: 0}
2743:   m_NavMeshLayer: 0
2744:   m_StaticEditorFlags: 2147483647
2745:   m_IsActive: 1
2746: --- !u!154 &793788509
2747: TerrainCollider:
2748:   m_ObjectHideFlags: 0
2749:   m_CorrespondingSourceObject: {fileID: 0}
2750:   m_PrefabInstance: {fileID: 0}
2751:   m_PrefabAsset: {fileID: 0}
2752:   m_GameObject: {fileID: 793788508}
2753:   m_Material: {fileID: 0}
2754:   m_IncludeLayers:
2755:     serializedVersion: 2
2756:     m_Bits: 0
2757:   m_ExcludeLayers:
2758:     serializedVersion: 2
2759:     m_Bits: 0
2760:   m_LayerOverridePriority: 0
2761:   m_ProvidesContacts: 0
2762:   m_Enabled: 1
2763:   serializedVersion: 2
2764:   m_TerrainData: {fileID: 15600000, guid: 411ed2f76ae86154e8758d1565379c70, type: 2}
2765:   m_EnableTreeColliders: 1
2766: --- !u!218 &793788510
2767: Terrain:
2768:   m_ObjectHideFlags: 0
2769:   m_CorrespondingSourceObject: {fileID: 0}
2770:   m_PrefabInstance: {fileID: 0}
2771:   m_PrefabAsset: {fileID: 0}
2772:   m_GameObject: {fileID: 793788508}
2773:   m_Enabled: 1
2774:   serializedVersion: 6
2775:   m_TerrainData: {fileID: 15600000, guid: 411ed2f76ae86154e8758d1565379c70, type: 2}
2776:   m_TreeDistance: 5000
2777:   m_TreeBillboardDistance: 50
2778:   m_TreeCrossFadeLength: 5
2779:   m_TreeMaximumFullLODCount: 50
2780:   m_DetailObjectDistance: 80
2781:   m_DetailObjectDensity: 1
2782:   m_HeightmapPixelError: 5
2783:   m_SplatMapDistance: 1000
2784:   m_HeightmapMinimumLODSimplification: 0
2785:   m_HeightmapMaximumLOD: 0
2786:   m_ShadowCastingMode: 2
2787:   m_DrawHeightmap: 1
2788:   m_DrawInstanced: 0
2789:   m_DrawTreesAndFoliage: 1
2790:   m_StaticShadowCaster: 0
2791:   m_IgnoreQualitySettings: 0
2792:   m_ReflectionProbeUsage: 1
2793:   m_MaterialTemplate: {fileID: 10652, guid: 0000000000000000f000000000000000, type: 0}
2794:   m_BakeLightProbesForTrees: 1
2795:   m_PreserveTreePrototypeLayers: 0
2796:   m_DeringLightProbesForTrees: 1
2797:   m_ReceiveGI: 1
2798:   m_ScaleInLightmap: 0.0256
2799:   m_LightmapParameters: {fileID: 15203, guid: 0000000000000000f000000000000000, type: 0}
2800:   m_GroupingID: 0
2801:   m_RenderingLayerMask: 1
2802:   m_AllowAutoConnect: 1
2803:   m_EnableHeightmapRayTracing: 1
2804:   m_EnableTreesAndDetailsRayTracing: 0
2805:   m_TreeMotionVectorModeOverride: 3
2806: --- !u!4 &793788511
2807: Transform:
2808:   m_ObjectHideFlags: 0
2809:   m_CorrespondingSourceObject: {fileID: 0}
2810:   m_PrefabInstance: {fileID: 0}
2811:   m_PrefabAsset: {fileID: 0}
2812:   m_GameObject: {fileID: 793788508}
2813:   serializedVersion: 2
2814:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
2815:   m_LocalPosition: {x: 0, y: 0, z: 0}
2816:   m_LocalScale: {x: 1, y: 1, z: 1}
2817:   m_ConstrainProportionsScale: 0
2818:   m_Children: []
2819:   m_Father: {fileID: 0}
2820:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
2821: --- !u!1 &874196380
2822: GameObject:
2823:   m_ObjectHideFlags: 0
2824:   m_CorrespondingSourceObject: {fileID: 0}
2825:   m_PrefabInstance: {fileID: 0}
2826:   m_PrefabAsset: {fileID: 0}
2827:   serializedVersion: 6
2828:   m_Component:
2829:   - component: {fileID: 874196384}
2830:   - component: {fileID: 874196383}
2831:   - component: {fileID: 874196382}
2832:   - component: {fileID: 874196381}
2833:   m_Layer: 5
2834:   m_Name: Canvas
2835:   m_TagString: Untagged
2836:   m_Icon: {fileID: 0}
2837:   m_NavMeshLayer: 0
2838:   m_StaticEditorFlags: 0
2839:   m_IsActive: 1
2840: --- !u!114 &874196381
2841: MonoBehaviour:
2842:   m_ObjectHideFlags: 0
2843:   m_CorrespondingSourceObject: {fileID: 0}
2844:   m_PrefabInstance: {fileID: 0}
2845:   m_PrefabAsset: {fileID: 0}
2846:   m_GameObject: {fileID: 874196380}
2847:   m_Enabled: 1
2848:   m_EditorHideFlags: 0
2849:   m_Script: {fileID: 11500000, guid: dc42784cf147c0c48a680349fa168899, type: 3}
2850:   m_Name: 
2851:   m_EditorClassIdentifier: 
2852:   m_IgnoreReversedGraphics: 1
2853:   m_BlockingObjects: 0
2854:   m_BlockingMask:
2855:     serializedVersion: 2
2856:     m_Bits: 4294967295
2857: --- !u!114 &874196382
2858: MonoBehaviour:
2859:   m_ObjectHideFlags: 0
2860:   m_CorrespondingSourceObject: {fileID: 0}
2861:   m_PrefabInstance: {fileID: 0}
2862:   m_PrefabAsset: {fileID: 0}
2863:   m_GameObject: {fileID: 874196380}
2864:   m_Enabled: 1
2865:   m_EditorHideFlags: 0
2866:   m_Script: {fileID: 11500000, guid: 0cd44c1031e13a943bb63640046fad76, type: 3}
2867:   m_Name: 
2868:   m_EditorClassIdentifier: 
2869:   m_UiScaleMode: 0
2870:   m_ReferencePixelsPerUnit: 100
2871:   m_ScaleFactor: 1
2872:   m_ReferenceResolution: {x: 800, y: 600}
2873:   m_ScreenMatchMode: 0
2874:   m_MatchWidthOrHeight: 0
2875:   m_PhysicalUnit: 3
2876:   m_FallbackScreenDPI: 96
2877:   m_DefaultSpriteDPI: 96
2878:   m_DynamicPixelsPerUnit: 1
2879:   m_PresetInfoIsWorld: 0
2880: --- !u!223 &874196383
2881: Canvas:
2882:   m_ObjectHideFlags: 0
2883:   m_CorrespondingSourceObject: {fileID: 0}
2884:   m_PrefabInstance: {fileID: 0}
2885:   m_PrefabAsset: {fileID: 0}
2886:   m_GameObject: {fileID: 874196380}
2887:   m_Enabled: 1
2888:   serializedVersion: 3
2889:   m_RenderMode: 0
2890:   m_Camera: {fileID: 0}
2891:   m_PlaneDistance: 100
2892:   m_PixelPerfect: 0
2893:   m_ReceivesEvents: 1
2894:   m_OverrideSorting: 0
2895:   m_OverridePixelPerfect: 0
2896:   m_SortingBucketNormalizedSize: 0
2897:   m_VertexColorAlwaysGammaSpace: 0
2898:   m_AdditionalShaderChannelsFlag: 25
2899:   m_UpdateRectTransformForStandalone: 0
2900:   m_SortingLayerID: 0
2901:   m_SortingOrder: 0
2902:   m_TargetDisplay: 0
2903: --- !u!224 &874196384
2904: RectTransform:
2905:   m_ObjectHideFlags: 0
2906:   m_CorrespondingSourceObject: {fileID: 0}
2907:   m_PrefabInstance: {fileID: 0}
2908:   m_PrefabAsset: {fileID: 0}
2909:   m_GameObject: {fileID: 874196380}
2910:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
2911:   m_LocalPosition: {x: 0, y: 0, z: 0}
2912:   m_LocalScale: {x: 0, y: 0, z: 0}
2913:   m_ConstrainProportionsScale: 0
2914:   m_Children:
2915:   - {fileID: 177176874}
2916:   m_Father: {fileID: 0}
2917:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
2918:   m_AnchorMin: {x: 0, y: 0}
2919:   m_AnchorMax: {x: 0, y: 0}
2920:   m_AnchoredPosition: {x: 0, y: 0}
2921:   m_SizeDelta: {x: 0, y: 0}
2922:   m_Pivot: {x: 0, y: 0}
2923: --- !u!1 &893096000 stripped
2924: GameObject:
2925:   m_CorrespondingSourceObject: {fileID: 919132149155446097, guid: 79d81dc0bb20d5a409d1160bf5b50b62, type: 3}
2926:   m_PrefabInstance: {fileID: 317525508}
2927:   m_PrefabAsset: {fileID: 0}
2928: --- !u!64 &893096004
2929: MeshCollider:
2930:   m_ObjectHideFlags: 0
2931:   m_CorrespondingSourceObject: {fileID: 0}
2932:   m_PrefabInstance: {fileID: 0}
2933:   m_PrefabAsset: {fileID: 0}
2934:   m_GameObject: {fileID: 893096000}
2935:   m_Material: {fileID: 0}
2936:   m_IncludeLayers:
2937:     serializedVersion: 2
2938:     m_Bits: 0
2939:   m_ExcludeLayers:
2940:     serializedVersion: 2
2941:     m_Bits: 0
2942:   m_LayerOverridePriority: 0
2943:   m_IsTrigger: 0
2944:   m_ProvidesContacts: 0
2945:   m_Enabled: 1
2946:   serializedVersion: 5
2947:   m_Convex: 0
2948:   m_CookingOptions: 30
2949:   m_Mesh: {fileID: 4493585093827132993, guid: 79d81dc0bb20d5a409d1160bf5b50b62, type: 3}
2950: --- !u!1 &917053884
2951: GameObject:
2952:   m_ObjectHideFlags: 0
2953:   m_CorrespondingSourceObject: {fileID: 0}
2954:   m_PrefabInstance: {fileID: 0}
2955:   m_PrefabAsset: {fileID: 0}
2956:   serializedVersion: 6
2957:   m_Component:
2958:   - component: {fileID: 917053888}
2959:   - component: {fileID: 917053887}
2960:   - component: {fileID: 917053886}
2961:   - component: {fileID: 917053885}
2962:   m_Layer: 0
2963:   m_Name: Cube
2964:   m_TagString: Untagged
2965:   m_Icon: {fileID: 0}
2966:   m_NavMeshLayer: 0
2967:   m_StaticEditorFlags: 0
2968:   m_IsActive: 0
2969: --- !u!65 &917053885
2970: BoxCollider:
2971:   m_ObjectHideFlags: 0
2972:   m_CorrespondingSourceObject: {fileID: 0}
2973:   m_PrefabInstance: {fileID: 0}
2974:   m_PrefabAsset: {fileID: 0}
2975:   m_GameObject: {fileID: 917053884}
2976:   m_Material: {fileID: 0}
2977:   m_IncludeLayers:
2978:     serializedVersion: 2
2979:     m_Bits: 0
2980:   m_ExcludeLayers:
2981:     serializedVersion: 2
2982:     m_Bits: 0
2983:   m_LayerOverridePriority: 0
2984:   m_IsTrigger: 0
2985:   m_ProvidesContacts: 0
2986:   m_Enabled: 1
2987:   serializedVersion: 3
2988:   m_Size: {x: 1, y: 1, z: 1}
2989:   m_Center: {x: 0, y: 0, z: 0}
2990: --- !u!23 &917053886
2991: MeshRenderer:
2992:   m_ObjectHideFlags: 0
2993:   m_CorrespondingSourceObject: {fileID: 0}
2994:   m_PrefabInstance: {fileID: 0}
2995:   m_PrefabAsset: {fileID: 0}
2996:   m_GameObject: {fileID: 917053884}
2997:   m_Enabled: 1
2998:   m_CastShadows: 1
2999:   m_ReceiveShadows: 1
3000:   m_DynamicOccludee: 1
3001:   m_StaticShadowCaster: 0
3002:   m_MotionVectors: 1
3003:   m_LightProbeUsage: 1
3004:   m_ReflectionProbeUsage: 1
3005:   m_RayTracingMode: 2
3006:   m_RayTraceProcedural: 0
3007:   m_RenderingLayerMask: 1
3008:   m_RendererPriority: 0
3009:   m_Materials:
3010:   - {fileID: 10303, guid: 0000000000000000f000000000000000, type: 0}
3011:   m_StaticBatchInfo:
3012:     firstSubMesh: 0
3013:     subMeshCount: 0
3014:   m_StaticBatchRoot: {fileID: 0}
3015:   m_ProbeAnchor: {fileID: 0}
3016:   m_LightProbeVolumeOverride: {fileID: 0}
3017:   m_ScaleInLightmap: 1
3018:   m_ReceiveGI: 1
3019:   m_PreserveUVs: 0
3020:   m_IgnoreNormalsForChartDetection: 0
3021:   m_ImportantGI: 0
3022:   m_StitchLightmapSeams: 1
3023:   m_SelectedEditorRenderState: 3
3024:   m_MinimumChartSize: 4
3025:   m_AutoUVMaxDistance: 0.5
3026:   m_AutoUVMaxAngle: 89
3027:   m_LightmapParameters: {fileID: 0}
3028:   m_SortingLayerID: 0
3029:   m_SortingLayer: 0
3030:   m_SortingOrder: 0
3031:   m_AdditionalVertexStreams: {fileID: 0}
3032: --- !u!33 &917053887
3033: MeshFilter:
3034:   m_ObjectHideFlags: 0
3035:   m_CorrespondingSourceObject: {fileID: 0}
3036:   m_PrefabInstance: {fileID: 0}
3037:   m_PrefabAsset: {fileID: 0}
3038:   m_GameObject: {fileID: 917053884}
3039:   m_Mesh: {fileID: 10202, guid: 0000000000000000e000000000000000, type: 0}
3040: --- !u!4 &917053888
3041: Transform:
3042:   m_ObjectHideFlags: 0
3043:   m_CorrespondingSourceObject: {fileID: 0}
3044:   m_PrefabInstance: {fileID: 0}
3045:   m_PrefabAsset: {fileID: 0}
3046:   m_GameObject: {fileID: 917053884}
3047:   serializedVersion: 2
3048:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
3049:   m_LocalPosition: {x: 17.88, y: 0.528, z: 35.22}
3050:   m_LocalScale: {x: 1, y: 1, z: 1}
3051:   m_ConstrainProportionsScale: 0
3052:   m_Children: []
3053:   m_Father: {fileID: 0}
3054:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
3055: --- !u!1 &940784575 stripped
3056: GameObject:
3057:   m_CorrespondingSourceObject: {fileID: 2715566404302941441, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
3058:   m_PrefabInstance: {fileID: 1614476352}
3059:   m_PrefabAsset: {fileID: 0}
3060: --- !u!65 &940784576
3061: BoxCollider:
3062:   m_ObjectHideFlags: 0
3063:   m_CorrespondingSourceObject: {fileID: 0}
3064:   m_PrefabInstance: {fileID: 0}
3065:   m_PrefabAsset: {fileID: 0}
3066:   m_GameObject: {fileID: 940784575}
3067:   m_Material: {fileID: 13400000, guid: a5f6016dd69f60e49b7414ff9467d5b0, type: 2}
3068:   m_IncludeLayers:
3069:     serializedVersion: 2
3070:     m_Bits: 0
3071:   m_ExcludeLayers:
3072:     serializedVersion: 2
3073:     m_Bits: 0
3074:   m_LayerOverridePriority: 0
3075:   m_IsTrigger: 0
3076:   m_ProvidesContacts: 0
3077:   m_Enabled: 1
3078:   serializedVersion: 3
3079:   m_Size: {x: 0.14113307, y: 0.35835788, z: 0.13771217}
3080:   m_Center: {x: -0.020216545, y: 0.058739036, z: 0.010801682}
3081: --- !u!1 &952072880
3082: GameObject:
3083:   m_ObjectHideFlags: 0
3084:   m_CorrespondingSourceObject: {fileID: 0}
3085:   m_PrefabInstance: {fileID: 0}
3086:   m_PrefabAsset: {fileID: 0}
3087:   serializedVersion: 6
3088:   m_Component:
3089:   - component: {fileID: 952072881}
3090:   - component: {fileID: 952072884}
3091:   - component: {fileID: 952072883}
3092:   - component: {fileID: 952072882}
3093:   m_Layer: 5
3094:   m_Name: Volumen
3095:   m_TagString: Untagged
3096:   m_Icon: {fileID: 0}
3097:   m_NavMeshLayer: 0
3098:   m_StaticEditorFlags: 0
3099:   m_IsActive: 1
3100: --- !u!224 &952072881
3101: RectTransform:
3102:   m_ObjectHideFlags: 0
3103:   m_CorrespondingSourceObject: {fileID: 0}
3104:   m_PrefabInstance: {fileID: 0}
3105:   m_PrefabAsset: {fileID: 0}
3106:   m_GameObject: {fileID: 952072880}
3107:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
3108:   m_LocalPosition: {x: 0, y: 0, z: 0}
3109:   m_LocalScale: {x: 1, y: 1, z: 1}
3110:   m_ConstrainProportionsScale: 0
3111:   m_Children:
3112:   - {fileID: 1452527714}
3113:   m_Father: {fileID: 753868972}
3114:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
3115:   m_AnchorMin: {x: 0.5, y: 0.5}
3116:   m_AnchorMax: {x: 0.5, y: 0.5}
3117:   m_AnchoredPosition: {x: -176.9, y: 17.9}
3118:   m_SizeDelta: {x: 274.1145, y: 41.8655}
3119:   m_Pivot: {x: 0.5, y: 0.5}
3120: --- !u!114 &952072882
3121: MonoBehaviour:
3122:   m_ObjectHideFlags: 0
3123:   m_CorrespondingSourceObject: {fileID: 0}
3124:   m_PrefabInstance: {fileID: 0}
3125:   m_PrefabAsset: {fileID: 0}
3126:   m_GameObject: {fileID: 952072880}
3127:   m_Enabled: 1
3128:   m_EditorHideFlags: 0
3129:   m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
3130:   m_Name: 
3131:   m_EditorClassIdentifier: 
3132:   m_Navigation:
3133:     m_Mode: 3
3134:     m_WrapAround: 0
3135:     m_SelectOnUp: {fileID: 0}
3136:     m_SelectOnDown: {fileID: 0}
3137:     m_SelectOnLeft: {fileID: 0}
3138:     m_SelectOnRight: {fileID: 0}
3139:   m_Transition: 1
3140:   m_Colors:
3141:     m_NormalColor: {r: 0.7075472, g: 0, b: 0, a: 0.14901961}
3142:     m_HighlightedColor: {r: 0.754717, g: 0.3025988, b: 0.3025988, a: 0.34117648}
3143:     m_PressedColor: {r: 0.7169812, g: 0.26041296, b: 0.26041296, a: 0.43137255}
3144:     m_SelectedColor: {r: 0.745283, g: 0.1511659, b: 0.1511659, a: 0.70980394}
3145:     m_DisabledColor: {r: 1, g: 0, b: 0, a: 1}
3146:     m_ColorMultiplier: 1
3147:     m_FadeDuration: 0.1
3148:   m_SpriteState:
3149:     m_HighlightedSprite: {fileID: 0}
3150:     m_PressedSprite: {fileID: 0}
3151:     m_SelectedSprite: {fileID: 0}
3152:     m_DisabledSprite: {fileID: 0}
3153:   m_AnimationTriggers:
3154:     m_NormalTrigger: Normal
3155:     m_HighlightedTrigger: Highlighted
3156:     m_PressedTrigger: Pressed
3157:     m_SelectedTrigger: Selected
3158:     m_DisabledTrigger: Disabled
3159:   m_Interactable: 1
3160:   m_TargetGraphic: {fileID: 952072883}
3161:   m_OnClick:
3162:     m_PersistentCalls:
3163:       m_Calls: []
3164: --- !u!114 &952072883
3165: MonoBehaviour:
3166:   m_ObjectHideFlags: 0
3167:   m_CorrespondingSourceObject: {fileID: 0}
3168:   m_PrefabInstance: {fileID: 0}
3169:   m_PrefabAsset: {fileID: 0}
3170:   m_GameObject: {fileID: 952072880}
3171:   m_Enabled: 1
3172:   m_EditorHideFlags: 0
3173:   m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
3174:   m_Name: 
3175:   m_EditorClassIdentifier: 
3176:   m_Material: {fileID: 0}
3177:   m_Color: {r: 1, g: 1, b: 1, a: 1}
3178:   m_RaycastTarget: 1
3179:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
3180:   m_Maskable: 1
3181:   m_OnCullStateChanged:
3182:     m_PersistentCalls:
3183:       m_Calls: []
3184:   m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
3185:   m_Type: 1
3186:   m_PreserveAspect: 0
3187:   m_FillCenter: 1
3188:   m_FillMethod: 4
3189:   m_FillAmount: 1
3190:   m_FillClockwise: 1
3191:   m_FillOrigin: 0
3192:   m_UseSpriteMesh: 0
3193:   m_PixelsPerUnitMultiplier: 1
3194: --- !u!222 &952072884
3195: CanvasRenderer:
3196:   m_ObjectHideFlags: 0
3197:   m_CorrespondingSourceObject: {fileID: 0}
3198:   m_PrefabInstance: {fileID: 0}
3199:   m_PrefabAsset: {fileID: 0}
3200:   m_GameObject: {fileID: 952072880}
3201:   m_CullTransparentMesh: 1
3202: --- !u!1 &978263882
3203: GameObject:
3204:   m_ObjectHideFlags: 0
3205:   m_CorrespondingSourceObject: {fileID: 0}
3206:   m_PrefabInstance: {fileID: 0}
3207:   m_PrefabAsset: {fileID: 0}
3208:   serializedVersion: 6
3209:   m_Component:
3210:   - component: {fileID: 978263885}
3211:   - component: {fileID: 978263884}
3212:   - component: {fileID: 978263883}
3213:   m_Layer: 0
3214:   m_Name: EventSystem
3215:   m_TagString: Untagged
3216:   m_Icon: {fileID: 0}
3217:   m_NavMeshLayer: 0
3218:   m_StaticEditorFlags: 0
3219:   m_IsActive: 1
3220: --- !u!114 &978263883
3221: MonoBehaviour:
3222:   m_ObjectHideFlags: 0
3223:   m_CorrespondingSourceObject: {fileID: 0}
3224:   m_PrefabInstance: {fileID: 0}
3225:   m_PrefabAsset: {fileID: 0}
3226:   m_GameObject: {fileID: 978263882}
3227:   m_Enabled: 1
3228:   m_EditorHideFlags: 0
3229:   m_Script: {fileID: 11500000, guid: 4f231c4fb786f3946a6b90b886c48677, type: 3}
3230:   m_Name: 
3231:   m_EditorClassIdentifier: 
3232:   m_SendPointerHoverToParent: 1
3233:   m_HorizontalAxis: Horizontal
3234:   m_VerticalAxis: Vertical
3235:   m_SubmitButton: Submit
3236:   m_CancelButton: Cancel
3237:   m_InputActionsPerSecond: 10
3238:   m_RepeatDelay: 0.5
3239:   m_ForceModuleActive: 0
3240: --- !u!114 &978263884
3241: MonoBehaviour:
3242:   m_ObjectHideFlags: 0
3243:   m_CorrespondingSourceObject: {fileID: 0}
3244:   m_PrefabInstance: {fileID: 0}
3245:   m_PrefabAsset: {fileID: 0}
3246:   m_GameObject: {fileID: 978263882}
3247:   m_Enabled: 1
3248:   m_EditorHideFlags: 0
3249:   m_Script: {fileID: 11500000, guid: 76c392e42b5098c458856cdf6ecaaaa1, type: 3}
3250:   m_Name: 
3251:   m_EditorClassIdentifier: 
3252:   m_FirstSelected: {fileID: 0}
3253:   m_sendNavigationEvents: 1
3254:   m_DragThreshold: 10
3255: --- !u!4 &978263885
3256: Transform:
3257:   m_ObjectHideFlags: 0
3258:   m_CorrespondingSourceObject: {fileID: 0}
3259:   m_PrefabInstance: {fileID: 0}
3260:   m_PrefabAsset: {fileID: 0}
3261:   m_GameObject: {fileID: 978263882}
3262:   serializedVersion: 2
3263:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
3264:   m_LocalPosition: {x: 0, y: 0, z: 0}
3265:   m_LocalScale: {x: 1, y: 1, z: 1}
3266:   m_ConstrainProportionsScale: 0
3267:   m_Children: []
3268:   m_Father: {fileID: 0}
3269:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
3270: --- !u!1 &984701940
3271: GameObject:
3272:   m_ObjectHideFlags: 0
3273:   m_CorrespondingSourceObject: {fileID: 0}
3274:   m_PrefabInstance: {fileID: 0}
3275:   m_PrefabAsset: {fileID: 0}
3276:   serializedVersion: 6
3277:   m_Component:
3278:   - component: {fileID: 984701942}
3279:   - component: {fileID: 984701941}
3280:   m_Layer: 0
3281:   m_Name: Directional Light
3282:   m_TagString: Untagged
3283:   m_Icon: {fileID: 0}
3284:   m_NavMeshLayer: 0
3285:   m_StaticEditorFlags: 0
3286:   m_IsActive: 1
3287: --- !u!108 &984701941
3288: Light:
3289:   m_ObjectHideFlags: 0
3290:   m_CorrespondingSourceObject: {fileID: 0}
3291:   m_PrefabInstance: {fileID: 0}
3292:   m_PrefabAsset: {fileID: 0}
3293:   m_GameObject: {fileID: 984701940}
3294:   m_Enabled: 1
3295:   serializedVersion: 10
3296:   m_Type: 1
3297:   m_Shape: 0
3298:   m_Color: {r: 1, g: 0.92530924, b: 0.7122642, a: 1}
3299:   m_Intensity: 1
3300:   m_Range: 10
3301:   m_SpotAngle: 30
3302:   m_InnerSpotAngle: 21.80208
3303:   m_CookieSize: 10
3304:   m_Shadows:
3305:     m_Type: 1
3306:     m_Resolution: -1
3307:     m_CustomResolution: -1
3308:     m_Strength: 1
3309:     m_Bias: 0.05
3310:     m_NormalBias: 0.4
3311:     m_NearPlane: 0.2
3312:     m_CullingMatrixOverride:
3313:       e00: 1
3314:       e01: 0
3315:       e02: 0
3316:       e03: 0
3317:       e10: 0
3318:       e11: 1
3319:       e12: 0
3320:       e13: 0
3321:       e20: 0
3322:       e21: 0
3323:       e22: 1
3324:       e23: 0
3325:       e30: 0
3326:       e31: 0
3327:       e32: 0
3328:       e33: 1
3329:     m_UseCullingMatrixOverride: 0
3330:   m_Cookie: {fileID: 0}
3331:   m_DrawHalo: 0
3332:   m_Flare: {fileID: 0}
3333:   m_RenderMode: 0
3334:   m_CullingMask:
3335:     serializedVersion: 2
3336:     m_Bits: 4294967295
3337:   m_RenderingLayerMask: 1
3338:   m_Lightmapping: 4
3339:   m_LightShadowCasterMode: 0
3340:   m_AreaSize: {x: 1, y: 1}
3341:   m_BounceIntensity: 1
3342:   m_ColorTemperature: 6570
3343:   m_UseColorTemperature: 0
3344:   m_BoundingSphereOverride: {x: 0, y: 0, z: 0, w: 0}
3345:   m_UseBoundingSphereOverride: 0
3346:   m_UseViewFrustumForShadowCasterCull: 1
3347:   m_ShadowRadius: 0
3348:   m_ShadowAngle: 0
3349: --- !u!4 &984701942
3350: Transform:
3351:   m_ObjectHideFlags: 0
3352:   m_CorrespondingSourceObject: {fileID: 0}
3353:   m_PrefabInstance: {fileID: 0}
3354:   m_PrefabAsset: {fileID: 0}
3355:   m_GameObject: {fileID: 984701940}
3356:   serializedVersion: 2
3357:   m_LocalRotation: {x: 0.9928826, y: 0, z: 0, w: 0.119097106}
3358:   m_LocalPosition: {x: 0, y: 16.3, z: 83.5}
3359:   m_LocalScale: {x: 1, y: 1, z: 1}
3360:   m_ConstrainProportionsScale: 0
3361:   m_Children: []
3362:   m_Father: {fileID: 0}
3363:   m_LocalEulerAnglesHint: {x: 166.32, y: 0, z: 0}
3364: --- !u!1 &1091955425
3365: GameObject:
3366:   m_ObjectHideFlags: 0
3367:   m_CorrespondingSourceObject: {fileID: 0}
3368:   m_PrefabInstance: {fileID: 0}
3369:   m_PrefabAsset: {fileID: 0}
3370:   serializedVersion: 6
3371:   m_Component:
3372:   - component: {fileID: 1091955426}
3373:   - component: {fileID: 1091955427}
3374:   m_Layer: 5
3375:   m_Name: Slider
3376:   m_TagString: Untagged
3377:   m_Icon: {fileID: 0}
3378:   m_NavMeshLayer: 0
3379:   m_StaticEditorFlags: 0
3380:   m_IsActive: 1
3381: --- !u!224 &1091955426
3382: RectTransform:
3383:   m_ObjectHideFlags: 0
3384:   m_CorrespondingSourceObject: {fileID: 0}
3385:   m_PrefabInstance: {fileID: 0}
3386:   m_PrefabAsset: {fileID: 0}
3387:   m_GameObject: {fileID: 1091955425}
3388:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
3389:   m_LocalPosition: {x: 0, y: 0, z: 0}
3390:   m_LocalScale: {x: 1, y: 1, z: 1}
3391:   m_ConstrainProportionsScale: 0
3392:   m_Children:
3393:   - {fileID: 45582773}
3394:   - {fileID: 1466587694}
3395:   - {fileID: 1798642322}
3396:   m_Father: {fileID: 753868972}
3397:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
3398:   m_AnchorMin: {x: 0.5, y: 0.5}
3399:   m_AnchorMax: {x: 0.5, y: 0.5}
3400:   m_AnchoredPosition: {x: -173.4, y: 17.8}
3401:   m_SizeDelta: {x: 250, y: 20}
3402:   m_Pivot: {x: 0.5, y: 0.5}
3403: --- !u!114 &1091955427
3404: MonoBehaviour:
3405:   m_ObjectHideFlags: 0
3406:   m_CorrespondingSourceObject: {fileID: 0}
3407:   m_PrefabInstance: {fileID: 0}
3408:   m_PrefabAsset: {fileID: 0}
3409:   m_GameObject: {fileID: 1091955425}
3410:   m_Enabled: 1
3411:   m_EditorHideFlags: 0
3412:   m_Script: {fileID: 11500000, guid: 67db9e8f0e2ae9c40bc1e2b64352a6b4, type: 3}
3413:   m_Name: 
3414:   m_EditorClassIdentifier: 
3415:   m_Navigation:
3416:     m_Mode: 3
3417:     m_WrapAround: 0
3418:     m_SelectOnUp: {fileID: 0}
3419:     m_SelectOnDown: {fileID: 0}
3420:     m_SelectOnLeft: {fileID: 0}
3421:     m_SelectOnRight: {fileID: 0}
3422:   m_Transition: 1
3423:   m_Colors:
3424:     m_NormalColor: {r: 1, g: 1, b: 1, a: 1}
3425:     m_HighlightedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
3426:     m_PressedColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 1}
3427:     m_SelectedColor: {r: 0.9607843, g: 0.9607843, b: 0.9607843, a: 1}
3428:     m_DisabledColor: {r: 0.78431374, g: 0.78431374, b: 0.78431374, a: 0.5019608}
3429:     m_ColorMultiplier: 1
3430:     m_FadeDuration: 0.1
3431:   m_SpriteState:
3432:     m_HighlightedSprite: {fileID: 0}
3433:     m_PressedSprite: {fileID: 0}
3434:     m_SelectedSprite: {fileID: 0}
3435:     m_DisabledSprite: {fileID: 0}
3436:   m_AnimationTriggers:
3437:     m_NormalTrigger: Normal
3438:     m_HighlightedTrigger: Highlighted
3439:     m_PressedTrigger: Pressed
3440:     m_SelectedTrigger: Selected
3441:     m_DisabledTrigger: Disabled
3442:   m_Interactable: 1
3443:   m_TargetGraphic: {fileID: 2059794855}
3444:   m_FillRect: {fileID: 47567040}
3445:   m_HandleRect: {fileID: 2059794854}
3446:   m_Direction: 0
3447:   m_MinValue: 0
3448:   m_MaxValue: 1
3449:   m_WholeNumbers: 0
3450:   m_Value: 0
3451:   m_OnValueChanged:
3452:     m_PersistentCalls:
3453:       m_Calls: []
3454: --- !u!1 &1186536023
3455: GameObject:
3456:   m_ObjectHideFlags: 0
3457:   m_CorrespondingSourceObject: {fileID: 0}
3458:   m_PrefabInstance: {fileID: 0}
3459:   m_PrefabAsset: {fileID: 0}
3460:   serializedVersion: 6
3461:   m_Component:
3462:   - component: {fileID: 1186536025}
3463:   - component: {fileID: 1186536024}
3464:   m_Layer: 0
3465:   m_Name: End
3466:   m_TagString: End
3467:   m_Icon: {fileID: 0}
3468:   m_NavMeshLayer: 0
3469:   m_StaticEditorFlags: 0
3470:   m_IsActive: 0
3471: --- !u!65 &1186536024
3472: BoxCollider:
3473:   m_ObjectHideFlags: 0
3474:   m_CorrespondingSourceObject: {fileID: 0}
3475:   m_PrefabInstance: {fileID: 0}
3476:   m_PrefabAsset: {fileID: 0}
3477:   m_GameObject: {fileID: 1186536023}
3478:   m_Material: {fileID: 0}
3479:   m_IncludeLayers:
3480:     serializedVersion: 2
3481:     m_Bits: 0
3482:   m_ExcludeLayers:
3483:     serializedVersion: 2
3484:     m_Bits: 0
3485:   m_LayerOverridePriority: 0
3486:   m_IsTrigger: 0
3487:   m_ProvidesContacts: 0
3488:   m_Enabled: 1
3489:   serializedVersion: 3
3490:   m_Size: {x: 4.893411, y: 3.0108056, z: 0.49935693}
3491:   m_Center: {x: 0.039706282, y: -0.01673007, z: 0.00038750173}
3492: --- !u!4 &1186536025
3493: Transform:
3494:   m_ObjectHideFlags: 0
3495:   m_CorrespondingSourceObject: {fileID: 0}
3496:   m_PrefabInstance: {fileID: 0}
3497:   m_PrefabAsset: {fileID: 0}
3498:   m_GameObject: {fileID: 1186536023}
3499:   serializedVersion: 2
3500:   m_LocalRotation: {x: -0, y: 0.7071068, z: -0, w: 0.7071068}
3501:   m_LocalPosition: {x: 0.23499726, y: 1.5, z: 60.750076}
3502:   m_LocalScale: {x: 0.10000005, y: 1, z: 10}
3503:   m_ConstrainProportionsScale: 0
3504:   m_Children: []
3505:   m_Father: {fileID: 0}
3506:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
3507: --- !u!1 &1206017635
3508: GameObject:
3509:   m_ObjectHideFlags: 0
3510:   m_CorrespondingSourceObject: {fileID: 0}
3511:   m_PrefabInstance: {fileID: 0}
3512:   m_PrefabAsset: {fileID: 0}
3513:   serializedVersion: 6
3514:   m_Component:
3515:   - component: {fileID: 1206017639}
3516:   - component: {fileID: 1206017638}
3517:   - component: {fileID: 1206017637}
3518:   - component: {fileID: 1206017636}
3519:   m_Layer: 0
3520:   m_Name: Cube (1)
3521:   m_TagString: Untagged
3522:   m_Icon: {fileID: 0}
3523:   m_NavMeshLayer: 0
3524:   m_StaticEditorFlags: 0
3525:   m_IsActive: 0
3526: --- !u!65 &1206017636
3527: BoxCollider:
3528:   m_ObjectHideFlags: 0
3529:   m_CorrespondingSourceObject: {fileID: 0}
3530:   m_PrefabInstance: {fileID: 0}
3531:   m_PrefabAsset: {fileID: 0}
3532:   m_GameObject: {fileID: 1206017635}
3533:   m_Material: {fileID: 0}
3534:   m_IncludeLayers:
3535:     serializedVersion: 2
3536:     m_Bits: 0
3537:   m_ExcludeLayers:
3538:     serializedVersion: 2
3539:     m_Bits: 0
3540:   m_LayerOverridePriority: 0
3541:   m_IsTrigger: 0
3542:   m_ProvidesContacts: 0
3543:   m_Enabled: 1
3544:   serializedVersion: 3
3545:   m_Size: {x: 1, y: 1, z: 1}
3546:   m_Center: {x: 0, y: 0, z: 0}
3547: --- !u!23 &1206017637
3548: MeshRenderer:
3549:   m_ObjectHideFlags: 0
3550:   m_CorrespondingSourceObject: {fileID: 0}
3551:   m_PrefabInstance: {fileID: 0}
3552:   m_PrefabAsset: {fileID: 0}
3553:   m_GameObject: {fileID: 1206017635}
3554:   m_Enabled: 1
3555:   m_CastShadows: 1
3556:   m_ReceiveShadows: 1
3557:   m_DynamicOccludee: 1
3558:   m_StaticShadowCaster: 0
3559:   m_MotionVectors: 1
3560:   m_LightProbeUsage: 1
3561:   m_ReflectionProbeUsage: 1
3562:   m_RayTracingMode: 2
3563:   m_RayTraceProcedural: 0
3564:   m_RenderingLayerMask: 1
3565:   m_RendererPriority: 0
3566:   m_Materials:
3567:   - {fileID: 10303, guid: 0000000000000000f000000000000000, type: 0}
3568:   m_StaticBatchInfo:
3569:     firstSubMesh: 0
3570:     subMeshCount: 0
3571:   m_StaticBatchRoot: {fileID: 0}
3572:   m_ProbeAnchor: {fileID: 0}
3573:   m_LightProbeVolumeOverride: {fileID: 0}
3574:   m_ScaleInLightmap: 1
3575:   m_ReceiveGI: 1
3576:   m_PreserveUVs: 0
3577:   m_IgnoreNormalsForChartDetection: 0
3578:   m_ImportantGI: 0
3579:   m_StitchLightmapSeams: 1
3580:   m_SelectedEditorRenderState: 3
3581:   m_MinimumChartSize: 4
3582:   m_AutoUVMaxDistance: 0.5
3583:   m_AutoUVMaxAngle: 89
3584:   m_LightmapParameters: {fileID: 0}
3585:   m_SortingLayerID: 0
3586:   m_SortingLayer: 0
3587:   m_SortingOrder: 0
3588:   m_AdditionalVertexStreams: {fileID: 0}
3589: --- !u!33 &1206017638
3590: MeshFilter:
3591:   m_ObjectHideFlags: 0
3592:   m_CorrespondingSourceObject: {fileID: 0}
3593:   m_PrefabInstance: {fileID: 0}
3594:   m_PrefabAsset: {fileID: 0}
3595:   m_GameObject: {fileID: 1206017635}
3596:   m_Mesh: {fileID: 10202, guid: 0000000000000000e000000000000000, type: 0}
3597: --- !u!4 &1206017639
3598: Transform:
3599:   m_ObjectHideFlags: 0
3600:   m_CorrespondingSourceObject: {fileID: 0}
3601:   m_PrefabInstance: {fileID: 0}
3602:   m_PrefabAsset: {fileID: 0}
3603:   m_GameObject: {fileID: 1206017635}
3604:   serializedVersion: 2
3605:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
3606:   m_LocalPosition: {x: 7.25, y: 3.5, z: 35.2}
3607:   m_LocalScale: {x: 60, y: 1, z: 80}
3608:   m_ConstrainProportionsScale: 0
3609:   m_Children: []
3610:   m_Father: {fileID: 0}
3611:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
3612: --- !u!1 &1238725045
3613: GameObject:
3614:   m_ObjectHideFlags: 0
3615:   m_CorrespondingSourceObject: {fileID: 0}
3616:   m_PrefabInstance: {fileID: 0}
3617:   m_PrefabAsset: {fileID: 0}
3618:   serializedVersion: 6
3619:   m_Component:
3620:   - component: {fileID: 1238725046}
3621:   - component: {fileID: 1238725049}
3622:   - component: {fileID: 1238725048}
3623:   - component: {fileID: 1238725047}
3624:   m_Layer: 5
3625:   m_Name: Pantalla
3626:   m_TagString: Untagged
3627:   m_Icon: {fileID: 0}
3628:   m_NavMeshLayer: 0
3629:   m_StaticEditorFlags: 0
3630:   m_IsActive: 1
3631: --- !u!224 &1238725046
3632: RectTransform:
3633:   m_ObjectHideFlags: 0
3634:   m_CorrespondingSourceObject: {fileID: 0}
3635:   m_PrefabInstance: {fileID: 0}
3636:   m_PrefabAsset: {fileID: 0}
3637:   m_GameObject: {fileID: 1238725045}
3638:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
3639:   m_LocalPosition: {x: 0, y: 0, z: 0}
3640:   m_LocalScale: {x: 1, y: 1, z: 1}
3641:   m_ConstrainProportionsScale: 0
3642:   m_Children:
3643:   - {fileID: 421915866}
3644:   m_Father: {fileID: 753868972}
3645:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
3646:   m_AnchorMin: {x: 0.5, y: 0.5}
3647:   m_AnchorMax: {x: 0.5, y: 0.5}
3648:   m_AnchoredPosition: {x: -12.9, y: 133.76202}
3649:   m_SizeDelta: {x: 43.3052, y: 41.8655}
3650:   m_Pivot: {x: 0.5, y: 0.5}
3651: --- !u!114 &1238725047
3652: MonoBehaviour:
3653:   m_ObjectHideFlags: 0
3654:   m_CorrespondingSourceObject: {fileID: 0}
3655:   m_PrefabInstance: {fileID: 0}
3656:   m_PrefabAsset: {fileID: 0}
3657:   m_GameObject: {fileID: 1238725045}
3658:   m_Enabled: 1
3659:   m_EditorHideFlags: 0
3660:   m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
3661:   m_Name: 
3662:   m_EditorClassIdentifier: 
3663:   m_Navigation:
3664:     m_Mode: 3
3665:     m_WrapAround: 0
3666:     m_SelectOnUp: {fileID: 0}
3667:     m_SelectOnDown: {fileID: 0}
3668:     m_SelectOnLeft: {fileID: 0}
3669:     m_SelectOnRight: {fileID: 0}
3670:   m_Transition: 1
3671:   m_Colors:
3672:     m_NormalColor: {r: 0.7075472, g: 0, b: 0, a: 0.14901961}
3673:     m_HighlightedColor: {r: 0.754717, g: 0.3025988, b: 0.3025988, a: 0.34117648}
3674:     m_PressedColor: {r: 0.7169812, g: 0.26041296, b: 0.26041296, a: 0.43137255}
3675:     m_SelectedColor: {r: 0.745283, g: 0.1511659, b: 0.1511659, a: 0.70980394}
3676:     m_DisabledColor: {r: 1, g: 0, b: 0, a: 1}
3677:     m_ColorMultiplier: 1
3678:     m_FadeDuration: 0.1
3679:   m_SpriteState:
3680:     m_HighlightedSprite: {fileID: 0}
3681:     m_PressedSprite: {fileID: 0}
3682:     m_SelectedSprite: {fileID: 0}
3683:     m_DisabledSprite: {fileID: 0}
3684:   m_AnimationTriggers:
3685:     m_NormalTrigger: Normal
3686:     m_HighlightedTrigger: Highlighted
3687:     m_PressedTrigger: Pressed
3688:     m_SelectedTrigger: Selected
3689:     m_DisabledTrigger: Disabled
3690:   m_Interactable: 1
3691:   m_TargetGraphic: {fileID: 1238725048}
3692:   m_OnClick:
3693:     m_PersistentCalls:
3694:       m_Calls: []
3695: --- !u!114 &1238725048
3696: MonoBehaviour:
3697:   m_ObjectHideFlags: 0
3698:   m_CorrespondingSourceObject: {fileID: 0}
3699:   m_PrefabInstance: {fileID: 0}
3700:   m_PrefabAsset: {fileID: 0}
3701:   m_GameObject: {fileID: 1238725045}
3702:   m_Enabled: 1
3703:   m_EditorHideFlags: 0
3704:   m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
3705:   m_Name: 
3706:   m_EditorClassIdentifier: 
3707:   m_Material: {fileID: 0}
3708:   m_Color: {r: 1, g: 1, b: 1, a: 1}
3709:   m_RaycastTarget: 1
3710:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
3711:   m_Maskable: 1
3712:   m_OnCullStateChanged:
3713:     m_PersistentCalls:
3714:       m_Calls: []
3715:   m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
3716:   m_Type: 1
3717:   m_PreserveAspect: 0
3718:   m_FillCenter: 1
3719:   m_FillMethod: 4
3720:   m_FillAmount: 1
3721:   m_FillClockwise: 1
3722:   m_FillOrigin: 0
3723:   m_UseSpriteMesh: 0
3724:   m_PixelsPerUnitMultiplier: 1
3725: --- !u!222 &1238725049
3726: CanvasRenderer:
3727:   m_ObjectHideFlags: 0
3728:   m_CorrespondingSourceObject: {fileID: 0}
3729:   m_PrefabInstance: {fileID: 0}
3730:   m_PrefabAsset: {fileID: 0}
3731:   m_GameObject: {fileID: 1238725045}
3732:   m_CullTransparentMesh: 1
3733: --- !u!1 &1322213178
3734: GameObject:
3735:   m_ObjectHideFlags: 0
3736:   m_CorrespondingSourceObject: {fileID: 0}
3737:   m_PrefabInstance: {fileID: 0}
3738:   m_PrefabAsset: {fileID: 0}
3739:   serializedVersion: 6
3740:   m_Component:
3741:   - component: {fileID: 1322213181}
3742:   - component: {fileID: 1322213180}
3743:   - component: {fileID: 1322213179}
3744:   m_Layer: 0
3745:   m_Name: Terrain
3746:   m_TagString: Untagged
3747:   m_Icon: {fileID: 0}
3748:   m_NavMeshLayer: 0
3749:   m_StaticEditorFlags: 2147483647
3750:   m_IsActive: 1
3751: --- !u!154 &1322213179
3752: TerrainCollider:
3753:   m_ObjectHideFlags: 0
3754:   m_CorrespondingSourceObject: {fileID: 0}
3755:   m_PrefabInstance: {fileID: 0}
3756:   m_PrefabAsset: {fileID: 0}
3757:   m_GameObject: {fileID: 1322213178}
3758:   m_Material: {fileID: 0}
3759:   m_IncludeLayers:
3760:     serializedVersion: 2
3761:     m_Bits: 0
3762:   m_ExcludeLayers:
3763:     serializedVersion: 2
3764:     m_Bits: 0
3765:   m_LayerOverridePriority: 0
3766:   m_ProvidesContacts: 0
3767:   m_Enabled: 1
3768:   serializedVersion: 2
3769:   m_TerrainData: {fileID: 15600000, guid: 02bc0e2176f6a4e4ea3faf0c622664cf, type: 2}
3770:   m_EnableTreeColliders: 1
3771: --- !u!218 &1322213180
3772: Terrain:
3773:   m_ObjectHideFlags: 0
3774:   m_CorrespondingSourceObject: {fileID: 0}
3775:   m_PrefabInstance: {fileID: 0}
3776:   m_PrefabAsset: {fileID: 0}
3777:   m_GameObject: {fileID: 1322213178}
3778:   m_Enabled: 1
3779:   serializedVersion: 6
3780:   m_TerrainData: {fileID: 15600000, guid: 02bc0e2176f6a4e4ea3faf0c622664cf, type: 2}
3781:   m_TreeDistance: 5000
3782:   m_TreeBillboardDistance: 50
3783:   m_TreeCrossFadeLength: 5
3784:   m_TreeMaximumFullLODCount: 50
3785:   m_DetailObjectDistance: 80
3786:   m_DetailObjectDensity: 1
3787:   m_HeightmapPixelError: 5
3788:   m_SplatMapDistance: 1000
3789:   m_HeightmapMinimumLODSimplification: 0
3790:   m_HeightmapMaximumLOD: 0
3791:   m_ShadowCastingMode: 2
3792:   m_DrawHeightmap: 1
3793:   m_DrawInstanced: 0
3794:   m_DrawTreesAndFoliage: 1
3795:   m_StaticShadowCaster: 0
3796:   m_IgnoreQualitySettings: 0
3797:   m_ReflectionProbeUsage: 1
3798:   m_MaterialTemplate: {fileID: 10652, guid: 0000000000000000f000000000000000, type: 0}
3799:   m_BakeLightProbesForTrees: 1
3800:   m_PreserveTreePrototypeLayers: 0
3801:   m_DeringLightProbesForTrees: 1
3802:   m_ReceiveGI: 1
3803:   m_ScaleInLightmap: 0.42666668
3804:   m_LightmapParameters: {fileID: 15203, guid: 0000000000000000f000000000000000, type: 0}
3805:   m_GroupingID: 0
3806:   m_RenderingLayerMask: 1
3807:   m_AllowAutoConnect: 1
3808:   m_EnableHeightmapRayTracing: 1
3809:   m_EnableTreesAndDetailsRayTracing: 0
3810:   m_TreeMotionVectorModeOverride: 3
3811: --- !u!4 &1322213181
3812: Transform:
3813:   m_ObjectHideFlags: 0
3814:   m_CorrespondingSourceObject: {fileID: 0}
3815:   m_PrefabInstance: {fileID: 0}
3816:   m_PrefabAsset: {fileID: 0}
3817:   m_GameObject: {fileID: 1322213178}
3818:   serializedVersion: 2
3819:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
3820:   m_LocalPosition: {x: -113, y: 0, z: 0}
3821:   m_LocalScale: {x: 1, y: 1, z: 1}
3822:   m_ConstrainProportionsScale: 0
3823:   m_Children: []
3824:   m_Father: {fileID: 0}
3825:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
3826: --- !u!1 &1452527713
3827: GameObject:
3828:   m_ObjectHideFlags: 0
3829:   m_CorrespondingSourceObject: {fileID: 0}
3830:   m_PrefabInstance: {fileID: 0}
3831:   m_PrefabAsset: {fileID: 0}
3832:   serializedVersion: 6
3833:   m_Component:
3834:   - component: {fileID: 1452527714}
3835:   - component: {fileID: 1452527716}
3836:   - component: {fileID: 1452527715}
3837:   m_Layer: 5
3838:   m_Name: Text (TMP)
3839:   m_TagString: Untagged
3840:   m_Icon: {fileID: 0}
3841:   m_NavMeshLayer: 0
3842:   m_StaticEditorFlags: 0
3843:   m_IsActive: 1
3844: --- !u!224 &1452527714
3845: RectTransform:
3846:   m_ObjectHideFlags: 0
3847:   m_CorrespondingSourceObject: {fileID: 0}
3848:   m_PrefabInstance: {fileID: 0}
3849:   m_PrefabAsset: {fileID: 0}
3850:   m_GameObject: {fileID: 1452527713}
3851:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
3852:   m_LocalPosition: {x: 0, y: 0, z: 0}
3853:   m_LocalScale: {x: 1, y: 1, z: 1}
3854:   m_ConstrainProportionsScale: 0
3855:   m_Children: []
3856:   m_Father: {fileID: 952072881}
3857:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
3858:   m_AnchorMin: {x: 0, y: 0}
3859:   m_AnchorMax: {x: 1, y: 1}
3860:   m_AnchoredPosition: {x: -8, y: 41.4}
3861:   m_SizeDelta: {x: 0, y: 0}
3862:   m_Pivot: {x: 0.5, y: 0.5}
3863: --- !u!114 &1452527715
3864: MonoBehaviour:
3865:   m_ObjectHideFlags: 0
3866:   m_CorrespondingSourceObject: {fileID: 0}
3867:   m_PrefabInstance: {fileID: 0}
3868:   m_PrefabAsset: {fileID: 0}
3869:   m_GameObject: {fileID: 1452527713}
3870:   m_Enabled: 1
3871:   m_EditorHideFlags: 0
3872:   m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
3873:   m_Name: 
3874:   m_EditorClassIdentifier: 
3875:   m_Material: {fileID: 0}
3876:   m_Color: {r: 1, g: 1, b: 1, a: 1}
3877:   m_RaycastTarget: 1
3878:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
3879:   m_Maskable: 1
3880:   m_OnCullStateChanged:
3881:     m_PersistentCalls:
3882:       m_Calls: []
3883:   m_text: Volumen
3884:   m_isRightToLeft: 0
3885:   m_fontAsset: {fileID: 11400000, guid: 125cb55b44b24c4393181402bc6200e6, type: 2}
3886:   m_sharedMaterial: {fileID: 2100000, guid: d75b8f41e959450c84ac6e967084d3e1, type: 2}
3887:   m_fontSharedMaterials: []
3888:   m_fontMaterial: {fileID: 0}
3889:   m_fontMaterials: []
3890:   m_fontColor32:
3891:     serializedVersion: 2
3892:     rgba: 4281216654
3893:   m_fontColor: {r: 0.5566038, g: 0.18115878, b: 0.18115878, a: 1}
3894:   m_enableVertexGradient: 0
3895:   m_colorMode: 3
3896:   m_fontColorGradient:
3897:     topLeft: {r: 1, g: 1, b: 1, a: 1}
3898:     topRight: {r: 1, g: 1, b: 1, a: 1}
3899:     bottomLeft: {r: 1, g: 1, b: 1, a: 1}
3900:     bottomRight: {r: 1, g: 1, b: 1, a: 1}
3901:   m_fontColorGradientPreset: {fileID: 0}
3902:   m_spriteAsset: {fileID: 0}
3903:   m_tintAllSprites: 0
3904:   m_StyleSheet: {fileID: 0}
3905:   m_TextStyleHashCode: -1183493901
3906:   m_overrideHtmlColors: 0
3907:   m_faceColor:
3908:     serializedVersion: 2
3909:     rgba: 4294967295
3910:   m_fontSize: 40
3911:   m_fontSizeBase: 40
3912:   m_fontWeight: 400
3913:   m_enableAutoSizing: 0
3914:   m_fontSizeMin: 0
3915:   m_fontSizeMax: 0
3916:   m_fontStyle: 0
3917:   m_HorizontalAlignment: 2
3918:   m_VerticalAlignment: 512
3919:   m_textAlignment: 65535
3920:   m_characterSpacing: 0
3921:   m_wordSpacing: 0
3922:   m_lineSpacing: 0
3923:   m_lineSpacingMax: 0
3924:   m_paragraphSpacing: 0
3925:   m_charWidthMaxAdj: 0
3926:   m_enableWordWrapping: 0
3927:   m_wordWrappingRatios: 0.4
3928:   m_overflowMode: 0
3929:   m_linkedTextComponent: {fileID: 0}
3930:   parentLinkedComponent: {fileID: 0}
3931:   m_enableKerning: 0
3932:   m_enableExtraPadding: 0
3933:   checkPaddingRequired: 0
3934:   m_isRichText: 1
3935:   m_parseCtrlCharacters: 1
3936:   m_isOrthographic: 1
3937:   m_isCullingEnabled: 0
3938:   m_horizontalMapping: 0
3939:   m_verticalMapping: 0
3940:   m_uvLineOffset: 0
3941:   m_geometrySortingOrder: 0
3942:   m_IsTextObjectScaleStatic: 0
3943:   m_VertexBufferAutoSizeReduction: 0
3944:   m_useMaxVisibleDescender: 1
3945:   m_pageToDisplay: 1
3946:   m_margin: {x: 0, y: 0, z: 0, w: 0}
3947:   m_isUsingLegacyAnimationComponent: 0
3948:   m_isVolumetricText: 0
3949:   m_hasFontAssetChanged: 0
3950:   m_baseMaterial: {fileID: 0}
3951:   m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
3952: --- !u!222 &1452527716
3953: CanvasRenderer:
3954:   m_ObjectHideFlags: 0
3955:   m_CorrespondingSourceObject: {fileID: 0}
3956:   m_PrefabInstance: {fileID: 0}
3957:   m_PrefabAsset: {fileID: 0}
3958:   m_GameObject: {fileID: 1452527713}
3959:   m_CullTransparentMesh: 1
3960: --- !u!1 &1465907514 stripped
3961: GameObject:
3962:   m_CorrespondingSourceObject: {fileID: 1275084491436936, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
3963:   m_PrefabInstance: {fileID: 2018635965}
3964:   m_PrefabAsset: {fileID: 0}
3965: --- !u!114 &1465907515
3966: MonoBehaviour:
3967:   m_ObjectHideFlags: 0
3968:   m_CorrespondingSourceObject: {fileID: 0}
3969:   m_PrefabInstance: {fileID: 0}
3970:   m_PrefabAsset: {fileID: 0}
3971:   m_GameObject: {fileID: 1465907514}
3972:   m_Enabled: 1
3973:   m_EditorHideFlags: 0
3974:   m_Script: {fileID: 11500000, guid: 1043a062320783447be6cac70c851695, type: 3}
3975:   m_Name: 
3976:   m_EditorClassIdentifier: 
3977:   pyramidCollider: {fileID: 893096004}
3978:   trapDoor: {fileID: 0}
3979:   audioSource: {fileID: 0}
3980:   trapSound: {fileID: 8300000, guid: 744507fd7cd5e9f4b96f6dd05be8ce32, type: 3}
3981:   visualModel: {fileID: 0}
3982: --- !u!82 &1465907516
3983: AudioSource:
3984:   m_ObjectHideFlags: 0
3985:   m_CorrespondingSourceObject: {fileID: 0}
3986:   m_PrefabInstance: {fileID: 0}
3987:   m_PrefabAsset: {fileID: 0}
3988:   m_GameObject: {fileID: 1465907514}
3989:   m_Enabled: 1
3990:   serializedVersion: 4
3991:   OutputAudioMixerGroup: {fileID: 0}
3992:   m_audioClip: {fileID: 8300000, guid: 744507fd7cd5e9f4b96f6dd05be8ce32, type: 3}
3993:   m_PlayOnAwake: 0
3994:   m_Volume: 1
3995:   m_Pitch: 1
3996:   Loop: 0
3997:   Mute: 0
3998:   Spatialize: 0
3999:   SpatializePostEffects: 0
4000:   Priority: 128
4001:   DopplerLevel: 1
4002:   MinDistance: 1
4003:   MaxDistance: 500
4004:   Pan2D: 0
4005:   rolloffMode: 0
4006:   BypassEffects: 0
4007:   BypassListenerEffects: 0
4008:   BypassReverbZones: 0
4009:   rolloffCustomCurve:
4010:     serializedVersion: 2
4011:     m_Curve:
4012:     - serializedVersion: 3
4013:       time: 0
4014:       value: 1
4015:       inSlope: 0
4016:       outSlope: 0
4017:       tangentMode: 0
4018:       weightedMode: 0
4019:       inWeight: 0.33333334
4020:       outWeight: 0.33333334
4021:     - serializedVersion: 3
4022:       time: 1
4023:       value: 0
4024:       inSlope: 0
4025:       outSlope: 0
4026:       tangentMode: 0
4027:       weightedMode: 0
4028:       inWeight: 0.33333334
4029:       outWeight: 0.33333334
4030:     m_PreInfinity: 2
4031:     m_PostInfinity: 2
4032:     m_RotationOrder: 4
4033:   panLevelCustomCurve:
4034:     serializedVersion: 2
4035:     m_Curve:
4036:     - serializedVersion: 3
4037:       time: 0
4038:       value: 0
4039:       inSlope: 0
4040:       outSlope: 0
4041:       tangentMode: 0
4042:       weightedMode: 0
4043:       inWeight: 0.33333334
4044:       outWeight: 0.33333334
4045:     m_PreInfinity: 2
4046:     m_PostInfinity: 2
4047:     m_RotationOrder: 4
4048:   spreadCustomCurve:
4049:     serializedVersion: 2
4050:     m_Curve:
4051:     - serializedVersion: 3
4052:       time: 0
4053:       value: 0
4054:       inSlope: 0
4055:       outSlope: 0
4056:       tangentMode: 0
4057:       weightedMode: 0
4058:       inWeight: 0.33333334
4059:       outWeight: 0.33333334
4060:     m_PreInfinity: 2
4061:     m_PostInfinity: 2
4062:     m_RotationOrder: 4
4063:   reverbZoneMixCustomCurve:
4064:     serializedVersion: 2
4065:     m_Curve:
4066:     - serializedVersion: 3
4067:       time: 0
4068:       value: 1
4069:       inSlope: 0
4070:       outSlope: 0
4071:       tangentMode: 0
4072:       weightedMode: 0
4073:       inWeight: 0.33333334
4074:       outWeight: 0.33333334
4075:     m_PreInfinity: 2
4076:     m_PostInfinity: 2
4077:     m_RotationOrder: 4
4078: --- !u!135 &1465907517
4079: SphereCollider:
4080:   m_ObjectHideFlags: 0
4081:   m_CorrespondingSourceObject: {fileID: 0}
4082:   m_PrefabInstance: {fileID: 0}
4083:   m_PrefabAsset: {fileID: 0}
4084:   m_GameObject: {fileID: 1465907514}
4085:   m_Material: {fileID: 0}
4086:   m_IncludeLayers:
4087:     serializedVersion: 2
4088:     m_Bits: 0
4089:   m_ExcludeLayers:
4090:     serializedVersion: 2
4091:     m_Bits: 0
4092:   m_LayerOverridePriority: 0
4093:   m_IsTrigger: 1
4094:   m_ProvidesContacts: 0
4095:   m_Enabled: 1
4096:   serializedVersion: 3
4097:   m_Radius: 1.2
4098:   m_Center: {x: 0, y: 0, z: 0}
4099: --- !u!1 &1466587693
4100: GameObject:
4101:   m_ObjectHideFlags: 0
4102:   m_CorrespondingSourceObject: {fileID: 0}
4103:   m_PrefabInstance: {fileID: 0}
4104:   m_PrefabAsset: {fileID: 0}
4105:   serializedVersion: 6
4106:   m_Component:
4107:   - component: {fileID: 1466587694}
4108:   m_Layer: 5
4109:   m_Name: Fill Area
4110:   m_TagString: Untagged
4111:   m_Icon: {fileID: 0}
4112:   m_NavMeshLayer: 0
4113:   m_StaticEditorFlags: 0
4114:   m_IsActive: 1
4115: --- !u!224 &1466587694
4116: RectTransform:
4117:   m_ObjectHideFlags: 0
4118:   m_CorrespondingSourceObject: {fileID: 0}
4119:   m_PrefabInstance: {fileID: 0}
4120:   m_PrefabAsset: {fileID: 0}
4121:   m_GameObject: {fileID: 1466587693}
4122:   m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
4123:   m_LocalPosition: {x: 0, y: 0, z: 0}
4124:   m_LocalScale: {x: 1, y: 1, z: 1}
4125:   m_ConstrainProportionsScale: 0
4126:   m_Children:
4127:   - {fileID: 47567040}
4128:   m_Father: {fileID: 1091955426}
4129:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
4130:   m_AnchorMin: {x: 0, y: 0.25}
4131:   m_AnchorMax: {x: 1, y: 0.75}
4132:   m_AnchoredPosition: {x: -5, y: 0}
4133:   m_SizeDelta: {x: -20, y: 0}
4134:   m_Pivot: {x: 0.5, y: 0.5}
4135: --- !u!1001 &1614476352
4136: PrefabInstance:
4137:   m_ObjectHideFlags: 0
4138:   serializedVersion: 2
4139:   m_Modification:
4140:     serializedVersion: 3
4141:     m_TransformParent: {fileID: 0}
4142:     m_Modifications:
4143:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4144:       propertyPath: m_LocalPosition.x
4145:       value: 396.4556
4146:       objectReference: {fileID: 0}
4147:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4148:       propertyPath: m_LocalPosition.y
4149:       value: 2.55
4150:       objectReference: {fileID: 0}
4151:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4152:       propertyPath: m_LocalPosition.z
4153:       value: 533.36
4154:       objectReference: {fileID: 0}
4155:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4156:       propertyPath: m_LocalRotation.w
4157:       value: 1
4158:       objectReference: {fileID: 0}
4159:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4160:       propertyPath: m_LocalRotation.x
4161:       value: 0
4162:       objectReference: {fileID: 0}
4163:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4164:       propertyPath: m_LocalRotation.y
4165:       value: 0
4166:       objectReference: {fileID: 0}
4167:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4168:       propertyPath: m_LocalRotation.z
4169:       value: 0
4170:       objectReference: {fileID: 0}
4171:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4172:       propertyPath: m_LocalEulerAnglesHint.x
4173:       value: 0
4174:       objectReference: {fileID: 0}
4175:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4176:       propertyPath: m_LocalEulerAnglesHint.y
4177:       value: 0
4178:       objectReference: {fileID: 0}
4179:     - target: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4180:       propertyPath: m_LocalEulerAnglesHint.z
4181:       value: 0
4182:       objectReference: {fileID: 0}
4183:     - target: {fileID: -8191740002585371210, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4184:       propertyPath: m_LocalEulerAnglesHint.x
4185:       value: -13.650669
4186:       objectReference: {fileID: 0}
4187:     - target: {fileID: -8191740002585371210, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4188:       propertyPath: m_LocalEulerAnglesHint.y
4189:       value: 9.108155
4190:       objectReference: {fileID: 0}
4191:     - target: {fileID: -8191740002585371210, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4192:       propertyPath: m_LocalEulerAnglesHint.z
4193:       value: -3.8588629
4194:       objectReference: {fileID: 0}
4195:     - target: {fileID: -8068027186691560116, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4196:       propertyPath: m_LocalEulerAnglesHint.x
4197:       value: 16.498726
4198:       objectReference: {fileID: 0}
4199:     - target: {fileID: -8068027186691560116, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4200:       propertyPath: m_LocalEulerAnglesHint.y
4201:       value: 0.2522065
4202:       objectReference: {fileID: 0}
4203:     - target: {fileID: -8068027186691560116, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4204:       propertyPath: m_LocalEulerAnglesHint.z
4205:       value: 1.7393273
4206:       objectReference: {fileID: 0}
4207:     - target: {fileID: -8021001004253913084, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4208:       propertyPath: m_LocalEulerAnglesHint.x
4209:       value: 1.1550033
4210:       objectReference: {fileID: 0}
4211:     - target: {fileID: -8021001004253913084, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4212:       propertyPath: m_LocalEulerAnglesHint.y
4213:       value: -0.10751064
4214:       objectReference: {fileID: 0}
4215:     - target: {fileID: -8021001004253913084, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4216:       propertyPath: m_LocalEulerAnglesHint.z
4217:       value: -1.5879899
4218:       objectReference: {fileID: 0}
4219:     - target: {fileID: -7219772299731422950, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4220:       propertyPath: m_LocalEulerAnglesHint.x
4221:       value: -17.573479
4222:       objectReference: {fileID: 0}
4223:     - target: {fileID: -7219772299731422950, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4224:       propertyPath: m_LocalEulerAnglesHint.y
4225:       value: -9.267929
4226:       objectReference: {fileID: 0}
4227:     - target: {fileID: -7219772299731422950, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4228:       propertyPath: m_LocalEulerAnglesHint.z
4229:       value: 4.4402795
4230:       objectReference: {fileID: 0}
4231:     - target: {fileID: -6874584590210671055, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4232:       propertyPath: m_LocalEulerAnglesHint.x
4233:       value: 52.896046
4234:       objectReference: {fileID: 0}
4235:     - target: {fileID: -6874584590210671055, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4236:       propertyPath: m_LocalEulerAnglesHint.y
4237:       value: 9.699841
4238:       objectReference: {fileID: 0}
4239:     - target: {fileID: -6874584590210671055, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4240:       propertyPath: m_LocalEulerAnglesHint.z
4241:       value: 11.870057
4242:       objectReference: {fileID: 0}
4243:     - target: {fileID: -6857788192064577062, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4244:       propertyPath: m_LocalEulerAnglesHint.x
4245:       value: -13.354542
4246:       objectReference: {fileID: 0}
4247:     - target: {fileID: -6857788192064577062, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4248:       propertyPath: m_LocalEulerAnglesHint.y
4249:       value: -14.0486765
4250:       objectReference: {fileID: 0}
4251:     - target: {fileID: -6857788192064577062, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4252:       propertyPath: m_LocalEulerAnglesHint.z
4253:       value: 29.888725
4254:       objectReference: {fileID: 0}
4255:     - target: {fileID: -6803169544883306252, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4256:       propertyPath: m_LocalEulerAnglesHint.x
4257:       value: 70.87769
4258:       objectReference: {fileID: 0}
4259:     - target: {fileID: -6803169544883306252, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4260:       propertyPath: m_LocalEulerAnglesHint.y
4261:       value: 130.41704
4262:       objectReference: {fileID: 0}
4263:     - target: {fileID: -6803169544883306252, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4264:       propertyPath: m_LocalEulerAnglesHint.z
4265:       value: -144.11609
4266:       objectReference: {fileID: 0}
4267:     - target: {fileID: -6768225281626788248, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4268:       propertyPath: m_LocalEulerAnglesHint.x
4269:       value: 16.531242
4270:       objectReference: {fileID: 0}
4271:     - target: {fileID: -6768225281626788248, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4272:       propertyPath: m_LocalEulerAnglesHint.y
4273:       value: -0.20128621
4274:       objectReference: {fileID: 0}
4275:     - target: {fileID: -6768225281626788248, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4276:       propertyPath: m_LocalEulerAnglesHint.z
4277:       value: -1.3855314
4278:       objectReference: {fileID: 0}
4279:     - target: {fileID: -6024149945523619558, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4280:       propertyPath: m_LocalPosition.x
4281:       value: 0.0000004916219
4282:       objectReference: {fileID: 0}
4283:     - target: {fileID: -6024149945523619558, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4284:       propertyPath: m_LocalPosition.y
4285:       value: 0.029500317
4286:       objectReference: {fileID: 0}
4287:     - target: {fileID: -6024149945523619558, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4288:       propertyPath: m_LocalPosition.z
4289:       value: 0.0000003958121
4290:       objectReference: {fileID: 0}
4291:     - target: {fileID: -6024149945523619558, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4292:       propertyPath: m_LocalRotation.w
4293:       value: 0.88932097
4294:       objectReference: {fileID: 0}
4295:     - target: {fileID: -6024149945523619558, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4296:       propertyPath: m_LocalRotation.x
4297:       value: 0.45709717
4298:       objectReference: {fileID: 0}
4299:     - target: {fileID: -6024149945523619558, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4300:       propertyPath: m_LocalRotation.y
4301:       value: -0.004029744
4302:       objectReference: {fileID: 0}
4303:     - target: {fileID: -6024149945523619558, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4304:       propertyPath: m_LocalRotation.z
4305:       value: -0.01241717
4306:       objectReference: {fileID: 0}
4307:     - target: {fileID: -6024149945523619558, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4308:       propertyPath: m_LocalEulerAnglesHint.x
4309:       value: 54.381
4310:       objectReference: {fileID: 0}
4311:     - target: {fileID: -6024149945523619558, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4312:       propertyPath: m_LocalEulerAnglesHint.y
4313:       value: -1.822
4314:       objectReference: {fileID: 0}
4315:     - target: {fileID: -6024149945523619558, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4316:       propertyPath: m_LocalEulerAnglesHint.z
4317:       value: -2.536
4318:       objectReference: {fileID: 0}
4319:     - target: {fileID: -5665043316445423941, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4320:       propertyPath: m_LocalEulerAnglesHint.x
4321:       value: 17.855896
4322:       objectReference: {fileID: 0}
4323:     - target: {fileID: -5665043316445423941, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4324:       propertyPath: m_LocalEulerAnglesHint.y
4325:       value: 0.29724735
4326:       objectReference: {fileID: 0}
4327:     - target: {fileID: -5665043316445423941, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4328:       propertyPath: m_LocalEulerAnglesHint.z
4329:       value: 1.8918043
4330:       objectReference: {fileID: 0}
4331:     - target: {fileID: -5480977901411583989, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4332:       propertyPath: m_LocalEulerAnglesHint.x
4333:       value: 17.4017
4334:       objectReference: {fileID: 0}
4335:     - target: {fileID: -5480977901411583989, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4336:       propertyPath: m_LocalEulerAnglesHint.y
4337:       value: -0.22392635
4338:       objectReference: {fileID: 0}
4339:     - target: {fileID: -5480977901411583989, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4340:       propertyPath: m_LocalEulerAnglesHint.z
4341:       value: -1.4631081
4342:       objectReference: {fileID: 0}
4343:     - target: {fileID: -3746190272939815206, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4344:       propertyPath: m_LocalEulerAnglesHint.x
4345:       value: -11.653284
4346:       objectReference: {fileID: 0}
4347:     - target: {fileID: -3746190272939815206, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4348:       propertyPath: m_LocalEulerAnglesHint.y
4349:       value: -10.154549
4350:       objectReference: {fileID: 0}
4351:     - target: {fileID: -3746190272939815206, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4352:       propertyPath: m_LocalEulerAnglesHint.z
4353:       value: 4.6693482
4354:       objectReference: {fileID: 0}
4355:     - target: {fileID: -3480699329000672020, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4356:       propertyPath: m_LocalEulerAnglesHint.x
4357:       value: -5.8889747
4358:       objectReference: {fileID: 0}
4359:     - target: {fileID: -3480699329000672020, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4360:       propertyPath: m_LocalEulerAnglesHint.y
4361:       value: -1.1304619
4362:       objectReference: {fileID: 0}
4363:     - target: {fileID: -3480699329000672020, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4364:       propertyPath: m_LocalEulerAnglesHint.z
4365:       value: -2.814667
4366:       objectReference: {fileID: 0}
4367:     - target: {fileID: -3432401550182100168, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4368:       propertyPath: m_LocalEulerAnglesHint.x
4369:       value: 50.839878
4370:       objectReference: {fileID: 0}
4371:     - target: {fileID: -3432401550182100168, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4372:       propertyPath: m_LocalEulerAnglesHint.y
4373:       value: -54.537148
4374:       objectReference: {fileID: 0}
4375:     - target: {fileID: -3432401550182100168, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4376:       propertyPath: m_LocalEulerAnglesHint.z
4377:       value: -56.092342
4378:       objectReference: {fileID: 0}
4379:     - target: {fileID: -3321919801592875672, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4380:       propertyPath: m_LocalEulerAnglesHint.x
4381:       value: -7.563167
4382:       objectReference: {fileID: 0}
4383:     - target: {fileID: -3321919801592875672, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4384:       propertyPath: m_LocalEulerAnglesHint.y
4385:       value: -1.3873898
4386:       objectReference: {fileID: 0}
4387:     - target: {fileID: -3321919801592875672, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4388:       propertyPath: m_LocalEulerAnglesHint.z
4389:       value: 0.09543715
4390:       objectReference: {fileID: 0}
4391:     - target: {fileID: -2899422035419094908, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4392:       propertyPath: m_LocalPosition.x
4393:       value: -0.000000023283064
4394:       objectReference: {fileID: 0}
4395:     - target: {fileID: -2899422035419094908, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4396:       propertyPath: m_LocalPosition.y
4397:       value: 0.03379282
4398:       objectReference: {fileID: 0}
4399:     - target: {fileID: -2899422035419094908, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4400:       propertyPath: m_LocalPosition.z
4401:       value: -0.0000001937151
4402:       objectReference: {fileID: 0}
4403:     - target: {fileID: -2899422035419094908, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4404:       propertyPath: m_LocalRotation.w
4405:       value: 0.8702079
4406:       objectReference: {fileID: 0}
4407:     - target: {fileID: -2899422035419094908, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4408:       propertyPath: m_LocalRotation.x
4409:       value: 0.34187195
4410:       objectReference: {fileID: 0}
4411:     - target: {fileID: -2899422035419094908, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4412:       propertyPath: m_LocalRotation.y
4413:       value: -0.32511216
4414:       objectReference: {fileID: 0}
4415:     - target: {fileID: -2899422035419094908, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4416:       propertyPath: m_LocalRotation.z
4417:       value: -0.1419997
4418:       objectReference: {fileID: 0}
4419:     - target: {fileID: -2899422035419094908, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4420:       propertyPath: m_LocalEulerAnglesHint.x
4421:       value: 30.177
4422:       objectReference: {fileID: 0}
4423:     - target: {fileID: -2899422035419094908, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4424:       propertyPath: m_LocalEulerAnglesHint.y
4425:       value: -50.071
4426:       objectReference: {fileID: 0}
4427:     - target: {fileID: -2899422035419094908, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4428:       propertyPath: m_LocalEulerAnglesHint.z
4429:       value: -32.89
4430:       objectReference: {fileID: 0}
4431:     - target: {fileID: -2770666803903516498, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4432:       propertyPath: m_LocalEulerAnglesHint.x
4433:       value: 44.10298
4434:       objectReference: {fileID: 0}
4435:     - target: {fileID: -2770666803903516498, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4436:       propertyPath: m_LocalEulerAnglesHint.y
4437:       value: 0.000007603342
4438:       objectReference: {fileID: 0}
4439:     - target: {fileID: -2770666803903516498, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4440:       propertyPath: m_LocalEulerAnglesHint.z
4441:       value: 0.000007257986
4442:       objectReference: {fileID: 0}
4443:     - target: {fileID: -2594260964506120097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4444:       propertyPath: m_LocalEulerAnglesHint.x
4445:       value: 21.088776
4446:       objectReference: {fileID: 0}
4447:     - target: {fileID: -2594260964506120097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4448:       propertyPath: m_LocalEulerAnglesHint.y
4449:       value: 1.2695739
4450:       objectReference: {fileID: 0}
4451:     - target: {fileID: -2594260964506120097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4452:       propertyPath: m_LocalEulerAnglesHint.z
4453:       value: 3.903562
4454:       objectReference: {fileID: 0}
4455:     - target: {fileID: -2389525917609993686, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4456:       propertyPath: m_LocalEulerAnglesHint.x
4457:       value: 17.397049
4458:       objectReference: {fileID: 0}
4459:     - target: {fileID: -2389525917609993686, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4460:       propertyPath: m_LocalEulerAnglesHint.y
4461:       value: 0.28156283
4462:       objectReference: {fileID: 0}
4463:     - target: {fileID: -2389525917609993686, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4464:       propertyPath: m_LocalEulerAnglesHint.z
4465:       value: 1.8399715
4466:       objectReference: {fileID: 0}
4467:     - target: {fileID: -2072040086291044643, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4468:       propertyPath: m_LocalEulerAnglesHint.x
4469:       value: -16.515965
4470:       objectReference: {fileID: 0}
4471:     - target: {fileID: -2072040086291044643, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4472:       propertyPath: m_LocalEulerAnglesHint.y
4473:       value: 2.4127448
4474:       objectReference: {fileID: 0}
4475:     - target: {fileID: -2072040086291044643, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4476:       propertyPath: m_LocalEulerAnglesHint.z
4477:       value: -4.706827
4478:       objectReference: {fileID: 0}
4479:     - target: {fileID: -1864740628597940677, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4480:       propertyPath: m_LocalEulerAnglesHint.x
4481:       value: 8.037221
4482:       objectReference: {fileID: 0}
4483:     - target: {fileID: -1864740628597940677, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4484:       propertyPath: m_LocalEulerAnglesHint.y
4485:       value: 0.058263052
4486:       objectReference: {fileID: 0}
4487:     - target: {fileID: -1864740628597940677, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4488:       propertyPath: m_LocalEulerAnglesHint.z
4489:       value: 0.82908714
4490:       objectReference: {fileID: 0}
4491:     - target: {fileID: -1812909498023395591, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4492:       propertyPath: m_LocalEulerAnglesHint.x
4493:       value: -0.00000007063144
4494:       objectReference: {fileID: 0}
4495:     - target: {fileID: -1812909498023395591, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4496:       propertyPath: m_LocalEulerAnglesHint.y
4497:       value: 0.000013688952
4498:       objectReference: {fileID: 0}
4499:     - target: {fileID: -1812909498023395591, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4500:       propertyPath: m_LocalEulerAnglesHint.z
4501:       value: -1.4593569
4502:       objectReference: {fileID: 0}
4503:     - target: {fileID: -1070350730909333850, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4504:       propertyPath: m_LocalPosition.x
4505:       value: -0.022000004
4506:       objectReference: {fileID: 0}
4507:     - target: {fileID: -1070350730909333850, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4508:       propertyPath: m_LocalPosition.y
4509:       value: 0.07800015
4510:       objectReference: {fileID: 0}
4511:     - target: {fileID: -1070350730909333850, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4512:       propertyPath: m_LocalPosition.z
4513:       value: 0.003999917
4514:       objectReference: {fileID: 0}
4515:     - target: {fileID: -1070350730909333850, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4516:       propertyPath: m_LocalRotation.w
4517:       value: 0.98676896
4518:       objectReference: {fileID: 0}
4519:     - target: {fileID: -1070350730909333850, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4520:       propertyPath: m_LocalRotation.x
4521:       value: -0.1262359
4522:       objectReference: {fileID: 0}
4523:     - target: {fileID: -1070350730909333850, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4524:       propertyPath: m_LocalRotation.y
4525:       value: 0.081746966
4526:       objectReference: {fileID: 0}
4527:     - target: {fileID: -1070350730909333850, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4528:       propertyPath: m_LocalRotation.z
4529:       value: 0.060572296
4530:       objectReference: {fileID: 0}
4531:     - target: {fileID: -1070350730909333850, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4532:       propertyPath: m_LocalEulerAnglesHint.x
4533:       value: -15.013
4534:       objectReference: {fileID: 0}
4535:     - target: {fileID: -1070350730909333850, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4536:       propertyPath: m_LocalEulerAnglesHint.y
4537:       value: 8.696
4538:       objectReference: {fileID: 0}
4539:     - target: {fileID: -1070350730909333850, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4540:       propertyPath: m_LocalEulerAnglesHint.z
4541:       value: 5.877
4542:       objectReference: {fileID: 0}
4543:     - target: {fileID: -870823317777057635, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4544:       propertyPath: m_LocalEulerAnglesHint.x
4545:       value: -13.316864
4546:       objectReference: {fileID: 0}
4547:     - target: {fileID: -870823317777057635, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4548:       propertyPath: m_LocalEulerAnglesHint.y
4549:       value: 13.446756
4550:       objectReference: {fileID: 0}
4551:     - target: {fileID: -870823317777057635, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4552:       propertyPath: m_LocalEulerAnglesHint.z
4553:       value: -34.206287
4554:       objectReference: {fileID: 0}
4555:     - target: {fileID: -104578136787704052, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4556:       propertyPath: m_LocalPosition.x
4557:       value: 0.018651608
4558:       objectReference: {fileID: 0}
4559:     - target: {fileID: -104578136787704052, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4560:       propertyPath: m_LocalPosition.y
4561:       value: 0.09103581
4562:       objectReference: {fileID: 0}
4563:     - target: {fileID: -104578136787704052, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4564:       propertyPath: m_LocalPosition.z
4565:       value: 0.0004311446
4566:       objectReference: {fileID: 0}
4567:     - target: {fileID: -104578136787704052, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4568:       propertyPath: m_LocalRotation.w
4569:       value: 0.8854811
4570:       objectReference: {fileID: 0}
4571:     - target: {fileID: -104578136787704052, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4572:       propertyPath: m_LocalRotation.x
4573:       value: 0.42638606
4574:       objectReference: {fileID: 0}
4575:     - target: {fileID: -104578136787704052, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4576:       propertyPath: m_LocalRotation.y
4577:       value: -0.045190472
4578:       objectReference: {fileID: 0}
4579:     - target: {fileID: -104578136787704052, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4580:       propertyPath: m_LocalRotation.z
4581:       value: -0.17909743
4582:       objectReference: {fileID: 0}
4583:     - target: {fileID: -104578136787704052, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4584:       propertyPath: m_LocalEulerAnglesHint.x
4585:       value: 47.64
4586:       objectReference: {fileID: 0}
4587:     - target: {fileID: -104578136787704052, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4588:       propertyPath: m_LocalEulerAnglesHint.y
4589:       value: -20.209
4590:       objectReference: {fileID: 0}
4591:     - target: {fileID: -104578136787704052, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4592:       propertyPath: m_LocalEulerAnglesHint.z
4593:       value: -31.866
4594:       objectReference: {fileID: 0}
4595:     - target: {fileID: 366175167995203695, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4596:       propertyPath: m_LocalEulerAnglesHint.x
4597:       value: 2.6051795
4598:       objectReference: {fileID: 0}
4599:     - target: {fileID: 366175167995203695, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4600:       propertyPath: m_LocalEulerAnglesHint.y
4601:       value: -0.17003492
4602:       objectReference: {fileID: 0}
4603:     - target: {fileID: 366175167995203695, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4604:       propertyPath: m_LocalEulerAnglesHint.z
4605:       value: -1.5959994
4606:       objectReference: {fileID: 0}
4607:     - target: {fileID: 608321761475470972, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4608:       propertyPath: m_LocalEulerAnglesHint.x
4609:       value: 58.280308
4610:       objectReference: {fileID: 0}
4611:     - target: {fileID: 608321761475470972, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4612:       propertyPath: m_LocalEulerAnglesHint.y
4613:       value: -6.7254415
4614:       objectReference: {fileID: 0}
4615:     - target: {fileID: 608321761475470972, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4616:       propertyPath: m_LocalEulerAnglesHint.z
4617:       value: -6.474811
4618:       objectReference: {fileID: 0}
4619:     - target: {fileID: 751176136059791188, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4620:       propertyPath: m_LocalPosition.z
4621:       value: -0.002
4622:       objectReference: {fileID: 0}
4623:     - target: {fileID: 919132149155446097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4624:       propertyPath: m_Name
4625:       value: Player
4626:       objectReference: {fileID: 0}
4627:     - target: {fileID: 919132149155446097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4628:       propertyPath: m_IsActive
4629:       value: 1
4630:       objectReference: {fileID: 0}
4631:     - target: {fileID: 919132149155446097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4632:       propertyPath: m_TagString
4633:       value: Player
4634:       objectReference: {fileID: 0}
4635:     - target: {fileID: 1092408308860062549, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4636:       propertyPath: m_LocalEulerAnglesHint.x
4637:       value: 17.891272
4638:       objectReference: {fileID: 0}
4639:     - target: {fileID: 1092408308860062549, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4640:       propertyPath: m_LocalEulerAnglesHint.y
4641:       value: -0.2372381
4642:       objectReference: {fileID: 0}
4643:     - target: {fileID: 1092408308860062549, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4644:       propertyPath: m_LocalEulerAnglesHint.z
4645:       value: -1.5070229
4646:       objectReference: {fileID: 0}
4647:     - target: {fileID: 1189529853000058984, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4648:       propertyPath: m_LocalPosition.x
4649:       value: 0.03806279
4650:       objectReference: {fileID: 0}
4651:     - target: {fileID: 1189529853000058984, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4652:       propertyPath: m_LocalPosition.y
4653:       value: 0.08076659
4654:       objectReference: {fileID: 0}
4655:     - target: {fileID: 1189529853000058984, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4656:       propertyPath: m_LocalPosition.z
4657:       value: 0.00486717
4658:       objectReference: {fileID: 0}
4659:     - target: {fileID: 1189529853000058984, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4660:       propertyPath: m_LocalRotation.w
4661:       value: 0.6576216
4662:       objectReference: {fileID: 0}
4663:     - target: {fileID: 1189529853000058984, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4664:       propertyPath: m_LocalRotation.x
4665:       value: 0.62124527
4666:       objectReference: {fileID: 0}
4667:     - target: {fileID: 1189529853000058984, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4668:       propertyPath: m_LocalRotation.y
4669:       value: -0.3111657
4670:       objectReference: {fileID: 0}
4671:     - target: {fileID: 1189529853000058984, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4672:       propertyPath: m_LocalRotation.z
4673:       value: -0.29114282
4674:       objectReference: {fileID: 0}
4675:     - target: {fileID: 1189529853000058984, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4676:       propertyPath: m_LocalEulerAnglesHint.x
4677:       value: 39.487
4678:       objectReference: {fileID: 0}
4679:     - target: {fileID: 1189529853000058984, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4680:       propertyPath: m_LocalEulerAnglesHint.y
4681:       value: -87.441
4682:       objectReference: {fileID: 0}
4683:     - target: {fileID: 1189529853000058984, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4684:       propertyPath: m_LocalEulerAnglesHint.z
4685:       value: -85.647
4686:       objectReference: {fileID: 0}
4687:     - target: {fileID: 1330755669629619180, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4688:       propertyPath: m_LocalEulerAnglesHint.x
4689:       value: 7.5924215
4690:       objectReference: {fileID: 0}
4691:     - target: {fileID: 1330755669629619180, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4692:       propertyPath: m_LocalEulerAnglesHint.y
4693:       value: -0.1491201
4694:       objectReference: {fileID: 0}
4695:     - target: {fileID: 1330755669629619180, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4696:       propertyPath: m_LocalEulerAnglesHint.z
4697:       value: -0.9782077
4698:       objectReference: {fileID: 0}
4699:     - target: {fileID: 1564860333797465651, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4700:       propertyPath: m_LocalEulerAnglesHint.x
4701:       value: 20.897293
4702:       objectReference: {fileID: 0}
4703:     - target: {fileID: 1564860333797465651, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4704:       propertyPath: m_LocalEulerAnglesHint.y
4705:       value: 0.41359332
4706:       objectReference: {fileID: 0}
4707:     - target: {fileID: 1564860333797465651, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4708:       propertyPath: m_LocalEulerAnglesHint.z
4709:       value: 2.2423637
4710:       objectReference: {fileID: 0}
4711:     - target: {fileID: 1852576806548013000, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4712:       propertyPath: m_LocalPosition.x
4713:       value: -0.00000020861626
4714:       objectReference: {fileID: 0}
4715:     - target: {fileID: 1852576806548013000, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4716:       propertyPath: m_LocalPosition.y
4717:       value: 0.28328842
4718:       objectReference: {fileID: 0}
4719:     - target: {fileID: 1852576806548013000, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4720:       propertyPath: m_LocalPosition.z
4721:       value: 0.000000035390258
4722:       objectReference: {fileID: 0}
4723:     - target: {fileID: 1852576806548013000, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4724:       propertyPath: m_LocalRotation.w
4725:       value: 0.7569781
4726:       objectReference: {fileID: 0}
4727:     - target: {fileID: 1852576806548013000, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4728:       propertyPath: m_LocalRotation.x
4729:       value: 0.053845633
4730:       objectReference: {fileID: 0}
4731:     - target: {fileID: 1852576806548013000, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4732:       propertyPath: m_LocalRotation.y
4733:       value: -0.65074164
4734:       objectReference: {fileID: 0}
4735:     - target: {fileID: 1852576806548013000, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4736:       propertyPath: m_LocalRotation.z
4737:       value: -0.024902465
4738:       objectReference: {fileID: 0}
4739:     - target: {fileID: 1852576806548013000, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4740:       propertyPath: m_LocalEulerAnglesHint.x
4741:       value: 2.815
4742:       objectReference: {fileID: 0}
4743:     - target: {fileID: 1852576806548013000, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4744:       propertyPath: m_LocalEulerAnglesHint.y
4745:       value: -81.521
4746:       objectReference: {fileID: 0}
4747:     - target: {fileID: 1852576806548013000, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4748:       propertyPath: m_LocalEulerAnglesHint.z
4749:       value: -6.195
4750:       objectReference: {fileID: 0}
4751:     - target: {fileID: 2559285840627121667, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4752:       propertyPath: m_LocalEulerAnglesHint.x
4753:       value: -11.589967
4754:       objectReference: {fileID: 0}
4755:     - target: {fileID: 2559285840627121667, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4756:       propertyPath: m_LocalEulerAnglesHint.y
4757:       value: -14.968474
4758:       objectReference: {fileID: 0}
4759:     - target: {fileID: 2559285840627121667, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4760:       propertyPath: m_LocalEulerAnglesHint.z
4761:       value: 172.61952
4762:       objectReference: {fileID: 0}
4763:     - target: {fileID: 2563496969622287784, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4764:       propertyPath: m_LocalPosition.x
4765:       value: 0.000000007450581
4766:       objectReference: {fileID: 0}
4767:     - target: {fileID: 2563496969622287784, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4768:       propertyPath: m_LocalPosition.y
4769:       value: 0.27841517
4770:       objectReference: {fileID: 0}
4771:     - target: {fileID: 2563496969622287784, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4772:       propertyPath: m_LocalPosition.z
4773:       value: 0.00000012072269
4774:       objectReference: {fileID: 0}
4775:     - target: {fileID: 2563496969622287784, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4776:       propertyPath: m_LocalRotation.w
4777:       value: 0.7082384
4778:       objectReference: {fileID: 0}
4779:     - target: {fileID: 2563496969622287784, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4780:       propertyPath: m_LocalRotation.x
4781:       value: -0.04817603
4782:       objectReference: {fileID: 0}
4783:     - target: {fileID: 2563496969622287784, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4784:       propertyPath: m_LocalRotation.y
4785:       value: -0.34683022
4786:       objectReference: {fileID: 0}
4787:     - target: {fileID: 2563496969622287784, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4788:       propertyPath: m_LocalRotation.z
4789:       value: 0.6130141
4790:       objectReference: {fileID: 0}
4791:     - target: {fileID: 2563496969622287784, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4792:       propertyPath: m_LocalEulerAnglesHint.x
4793:       value: 20.915
4794:       objectReference: {fileID: 0}
4795:     - target: {fileID: 2563496969622287784, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4796:       propertyPath: m_LocalEulerAnglesHint.y
4797:       value: -36.098
4798:       objectReference: {fileID: 0}
4799:     - target: {fileID: 2563496969622287784, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4800:       propertyPath: m_LocalEulerAnglesHint.z
4801:       value: 74.872
4802:       objectReference: {fileID: 0}
4803:     - target: {fileID: 2916570863362053800, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4804:       propertyPath: m_LocalEulerAnglesHint.x
4805:       value: 46.457325
4806:       objectReference: {fileID: 0}
4807:     - target: {fileID: 2916570863362053800, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4808:       propertyPath: m_LocalEulerAnglesHint.y
4809:       value: 0.00000601432
4810:       objectReference: {fileID: 0}
4811:     - target: {fileID: 2916570863362053800, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4812:       propertyPath: m_LocalEulerAnglesHint.z
4813:       value: 0.000009782246
4814:       objectReference: {fileID: 0}
4815:     - target: {fileID: 3183749884578473501, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4816:       propertyPath: m_LocalEulerAnglesHint.x
4817:       value: 18.403303
4818:       objectReference: {fileID: 0}
4819:     - target: {fileID: 3183749884578473501, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4820:       propertyPath: m_LocalEulerAnglesHint.y
4821:       value: 0.31659517
4822:       objectReference: {fileID: 0}
4823:     - target: {fileID: 3183749884578473501, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4824:       propertyPath: m_LocalEulerAnglesHint.z
4825:       value: 1.9539808
4826:       objectReference: {fileID: 0}
4827:     - target: {fileID: 3667946887678727147, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4828:       propertyPath: m_LocalPosition.x
4829:       value: 0.00000063702464
4830:       objectReference: {fileID: 0}
4831:     - target: {fileID: 3667946887678727147, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4832:       propertyPath: m_LocalPosition.y
4833:       value: 0.09532537
4834:       objectReference: {fileID: 0}
4835:     - target: {fileID: 3667946887678727147, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4836:       propertyPath: m_LocalPosition.z
4837:       value: 0.0000009806827
4838:       objectReference: {fileID: 0}
4839:     - target: {fileID: 3667946887678727147, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4840:       propertyPath: m_LocalRotation.w
4841:       value: 0.9196478
4842:       objectReference: {fileID: 0}
4843:     - target: {fileID: 3667946887678727147, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4844:       propertyPath: m_LocalRotation.x
4845:       value: 0.066468455
4846:       objectReference: {fileID: 0}
4847:     - target: {fileID: 3667946887678727147, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4848:       propertyPath: m_LocalRotation.y
4849:       value: -0.26837796
4850:       objectReference: {fileID: 0}
4851:     - target: {fileID: 3667946887678727147, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4852:       propertyPath: m_LocalRotation.z
4853:       value: -0.2789322
4854:       objectReference: {fileID: 0}
4855:     - target: {fileID: 3667946887678727147, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4856:       propertyPath: m_LocalEulerAnglesHint.x
4857:       value: -1.574
4858:       objectReference: {fileID: 0}
4859:     - target: {fileID: 3667946887678727147, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4860:       propertyPath: m_LocalEulerAnglesHint.y
4861:       value: -32.067
4862:       objectReference: {fileID: 0}
4863:     - target: {fileID: 3667946887678727147, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4864:       propertyPath: m_LocalEulerAnglesHint.z
4865:       value: -33.293
4866:       objectReference: {fileID: 0}
4867:     - target: {fileID: 4747904710347621765, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4868:       propertyPath: m_LocalEulerAnglesHint.x
4869:       value: 26.990257
4870:       objectReference: {fileID: 0}
4871:     - target: {fileID: 4747904710347621765, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4872:       propertyPath: m_LocalEulerAnglesHint.y
4873:       value: 1.9120526
4874:       objectReference: {fileID: 0}
4875:     - target: {fileID: 4747904710347621765, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4876:       propertyPath: m_LocalEulerAnglesHint.z
4877:       value: 6.2375484
4878:       objectReference: {fileID: 0}
4879:     - target: {fileID: 5048025441337412694, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4880:       propertyPath: m_LocalEulerAnglesHint.x
4881:       value: 25.1835
4882:       objectReference: {fileID: 0}
4883:     - target: {fileID: 5048025441337412694, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4884:       propertyPath: m_LocalEulerAnglesHint.y
4885:       value: 1.7643449
4886:       objectReference: {fileID: 0}
4887:     - target: {fileID: 5048025441337412694, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4888:       propertyPath: m_LocalEulerAnglesHint.z
4889:       value: -24.141476
4890:       objectReference: {fileID: 0}
4891:     - target: {fileID: 5097370190579632962, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4892:       propertyPath: m_LocalEulerAnglesHint.x
4893:       value: 8.052697
4894:       objectReference: {fileID: 0}
4895:     - target: {fileID: 5097370190579632962, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4896:       propertyPath: m_LocalEulerAnglesHint.y
4897:       value: -0.04648379
4898:       objectReference: {fileID: 0}
4899:     - target: {fileID: 5097370190579632962, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4900:       propertyPath: m_LocalEulerAnglesHint.z
4901:       value: -0.66043156
4902:       objectReference: {fileID: 0}
4903:     - target: {fileID: 5372056943023685468, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4904:       propertyPath: m_LocalEulerAnglesHint.x
4905:       value: 17.43188
4906:       objectReference: {fileID: 0}
4907:     - target: {fileID: 5372056943023685468, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4908:       propertyPath: m_LocalEulerAnglesHint.y
4909:       value: -0.22471726
4910:       objectReference: {fileID: 0}
4911:     - target: {fileID: 5372056943023685468, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4912:       propertyPath: m_LocalEulerAnglesHint.z
4913:       value: -1.4658015
4914:       objectReference: {fileID: 0}
4915:     - target: {fileID: 5465940246521907071, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4916:       propertyPath: m_LocalEulerAnglesHint.x
4917:       value: -2.9986892
4918:       objectReference: {fileID: 0}
4919:     - target: {fileID: 5465940246521907071, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4920:       propertyPath: m_LocalEulerAnglesHint.y
4921:       value: 5.2738767
4922:       objectReference: {fileID: 0}
4923:     - target: {fileID: 5465940246521907071, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4924:       propertyPath: m_LocalEulerAnglesHint.z
4925:       value: 3.4165618
4926:       objectReference: {fileID: 0}
4927:     - target: {fileID: 6000407479487422213, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4928:       propertyPath: m_LocalPosition.x
4929:       value: 0.000000038649887
4930:       objectReference: {fileID: 0}
4931:     - target: {fileID: 6000407479487422213, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4932:       propertyPath: m_LocalPosition.y
4933:       value: 0.10838175
4934:       objectReference: {fileID: 0}
4935:     - target: {fileID: 6000407479487422213, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4936:       propertyPath: m_LocalPosition.z
4937:       value: -0.000000014901161
4938:       objectReference: {fileID: 0}
4939:     - target: {fileID: 6000407479487422213, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4940:       propertyPath: m_LocalRotation.w
4941:       value: 0.9499283
4942:       objectReference: {fileID: 0}
4943:     - target: {fileID: 6000407479487422213, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4944:       propertyPath: m_LocalRotation.x
4945:       value: 0.04314202
4946:       objectReference: {fileID: 0}
4947:     - target: {fileID: 6000407479487422213, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4948:       propertyPath: m_LocalRotation.y
4949:       value: 0.17687148
4950:       objectReference: {fileID: 0}
4951:     - target: {fileID: 6000407479487422213, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4952:       propertyPath: m_LocalRotation.z
4953:       value: 0.25395203
4954:       objectReference: {fileID: 0}
4955:     - target: {fileID: 6000407479487422213, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4956:       propertyPath: m_LocalEulerAnglesHint.x
4957:       value: -0.451
4958:       objectReference: {fileID: 0}
4959:     - target: {fileID: 6000407479487422213, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4960:       propertyPath: m_LocalEulerAnglesHint.y
4961:       value: 20.975
4962:       objectReference: {fileID: 0}
4963:     - target: {fileID: 6000407479487422213, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4964:       propertyPath: m_LocalEulerAnglesHint.z
4965:       value: 29.851
4966:       objectReference: {fileID: 0}
4967:     - target: {fileID: 6341119541397085964, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4968:       propertyPath: m_LocalPosition.x
4969:       value: -0.00000022724271
4970:       objectReference: {fileID: 0}
4971:     - target: {fileID: 6341119541397085964, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4972:       propertyPath: m_LocalPosition.y
4973:       value: 0.0370002
4974:       objectReference: {fileID: 0}
4975:     - target: {fileID: 6341119541397085964, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4976:       propertyPath: m_LocalPosition.z
4977:       value: 0.0000000050640665
4978:       objectReference: {fileID: 0}
4979:     - target: {fileID: 6341119541397085964, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4980:       propertyPath: m_LocalRotation.w
4981:       value: 0.9765231
4982:       objectReference: {fileID: 0}
4983:     - target: {fileID: 6341119541397085964, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4984:       propertyPath: m_LocalRotation.x
4985:       value: 0.21505843
4986:       objectReference: {fileID: 0}
4987:     - target: {fileID: 6341119541397085964, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4988:       propertyPath: m_LocalRotation.y
4989:       value: -0.00079747994
4990:       objectReference: {fileID: 0}
4991:     - target: {fileID: 6341119541397085964, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4992:       propertyPath: m_LocalRotation.z
4993:       value: -0.012320258
4994:       objectReference: {fileID: 0}
4995:     - target: {fileID: 6341119541397085964, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
4996:       propertyPath: m_LocalEulerAnglesHint.x
4997:       value: 24.835
4998:       objectReference: {fileID: 0}
4999:     - target: {fileID: 6341119541397085964, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5000:       propertyPath: m_LocalEulerAnglesHint.y
5001:       value: -0.433
5002:       objectReference: {fileID: 0}
5003:     - target: {fileID: 6341119541397085964, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5004:       propertyPath: m_LocalEulerAnglesHint.z
5005:       value: -1.541
5006:       objectReference: {fileID: 0}
5007:     - target: {fileID: 6502182839619065283, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5008:       propertyPath: m_LocalEulerAnglesHint.x
5009:       value: 6.184846
5010:       objectReference: {fileID: 0}
5011:     - target: {fileID: 6502182839619065283, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5012:       propertyPath: m_LocalEulerAnglesHint.y
5013:       value: 33.08249
5014:       objectReference: {fileID: 0}
5015:     - target: {fileID: 6502182839619065283, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5016:       propertyPath: m_LocalEulerAnglesHint.z
5017:       value: -1.3729043
5018:       objectReference: {fileID: 0}
5019:     - target: {fileID: 6515712193588681746, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5020:       propertyPath: m_LocalRotation.w
5021:       value: 0.9407147
5022:       objectReference: {fileID: 0}
5023:     - target: {fileID: 6515712193588681746, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5024:       propertyPath: m_LocalRotation.x
5025:       value: -0.3377968
5026:       objectReference: {fileID: 0}
5027:     - target: {fileID: 6515712193588681746, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5028:       propertyPath: m_LocalRotation.y
5029:       value: -0.015654111
5030:       objectReference: {fileID: 0}
5031:     - target: {fileID: 6515712193588681746, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5032:       propertyPath: m_LocalRotation.z
5033:       value: -0.02653587
5034:       objectReference: {fileID: 0}
5035:     - target: {fileID: 6515712193588681746, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5036:       propertyPath: m_LocalEulerAnglesHint.x
5037:       value: 5.6264944
5038:       objectReference: {fileID: 0}
5039:     - target: {fileID: 6515712193588681746, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5040:       propertyPath: m_LocalEulerAnglesHint.y
5041:       value: 0.13426463
5042:       objectReference: {fileID: 0}
5043:     - target: {fileID: 6515712193588681746, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5044:       propertyPath: m_LocalEulerAnglesHint.z
5045:       value: -0.42855775
5046:       objectReference: {fileID: 0}
5047:     - target: {fileID: 6655383506977046455, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5048:       propertyPath: m_LocalEulerAnglesHint.x
5049:       value: 17.397429
5050:       objectReference: {fileID: 0}
5051:     - target: {fileID: 6655383506977046455, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5052:       propertyPath: m_LocalEulerAnglesHint.y
5053:       value: 0.28159237
5054:       objectReference: {fileID: 0}
5055:     - target: {fileID: 6655383506977046455, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5056:       propertyPath: m_LocalEulerAnglesHint.z
5057:       value: 1.840089
5058:       objectReference: {fileID: 0}
5059:     - target: {fileID: 7021014693780275094, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5060:       propertyPath: m_LocalPosition.z
5061:       value: 0.012
5062:       objectReference: {fileID: 0}
5063:     - target: {fileID: 7078722787440015773, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5064:       propertyPath: m_LocalEulerAnglesHint.x
5065:       value: 68.81846
5066:       objectReference: {fileID: 0}
5067:     - target: {fileID: 7078722787440015773, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5068:       propertyPath: m_LocalEulerAnglesHint.y
5069:       value: -126.44302
5070:       objectReference: {fileID: 0}
5071:     - target: {fileID: 7078722787440015773, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5072:       propertyPath: m_LocalEulerAnglesHint.z
5073:       value: 145.79271
5074:       objectReference: {fileID: 0}
5075:     - target: {fileID: 7666680083751660616, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5076:       propertyPath: m_LocalEulerAnglesHint.x
5077:       value: 17.367344
5078:       objectReference: {fileID: 0}
5079:     - target: {fileID: 7666680083751660616, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5080:       propertyPath: m_LocalEulerAnglesHint.y
5081:       value: 0.28054634
5082:       objectReference: {fileID: 0}
5083:     - target: {fileID: 7666680083751660616, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5084:       propertyPath: m_LocalEulerAnglesHint.z
5085:       value: 1.8366115
5086:       objectReference: {fileID: 0}
5087:     - target: {fileID: 8169382868667117632, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5088:       propertyPath: m_LocalEulerAnglesHint.x
5089:       value: -0.5796389
5090:       objectReference: {fileID: 0}
5091:     - target: {fileID: 8169382868667117632, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5092:       propertyPath: m_LocalEulerAnglesHint.y
5093:       value: 10.418542
5094:       objectReference: {fileID: 0}
5095:     - target: {fileID: 8169382868667117632, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5096:       propertyPath: m_LocalEulerAnglesHint.z
5097:       value: 176.47742
5098:       objectReference: {fileID: 0}
5099:     - target: {fileID: 8255111157037086696, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5100:       propertyPath: m_LocalEulerAnglesHint.x
5101:       value: 15.679467
5102:       objectReference: {fileID: 0}
5103:     - target: {fileID: 8255111157037086696, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5104:       propertyPath: m_LocalEulerAnglesHint.y
5105:       value: 0.82517374
5106:       objectReference: {fileID: 0}
5107:     - target: {fileID: 8255111157037086696, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5108:       propertyPath: m_LocalEulerAnglesHint.z
5109:       value: 2.7689166
5110:       objectReference: {fileID: 0}
5111:     - target: {fileID: 8447082967072642302, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5112:       propertyPath: m_LocalPosition.x
5113:       value: -0.026818585
5114:       objectReference: {fileID: 0}
5115:     - target: {fileID: 8447082967072642302, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5116:       propertyPath: m_LocalPosition.y
5117:       value: 0.024648303
5118:       objectReference: {fileID: 0}
5119:     - target: {fileID: 8447082967072642302, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5120:       propertyPath: m_LocalPosition.z
5121:       value: 0.015739832
5122:       objectReference: {fileID: 0}
5123:     - target: {fileID: 8447082967072642302, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5124:       propertyPath: m_LocalRotation.w
5125:       value: 0.8561542
5126:       objectReference: {fileID: 0}
5127:     - target: {fileID: 8447082967072642302, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5128:       propertyPath: m_LocalRotation.x
5129:       value: 0.36601996
5130:       objectReference: {fileID: 0}
5131:     - target: {fileID: 8447082967072642302, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5132:       propertyPath: m_LocalRotation.y
5133:       value: -0.36117524
5134:       objectReference: {fileID: 0}
5135:     - target: {fileID: 8447082967072642302, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5136:       propertyPath: m_LocalRotation.z
5137:       value: -0.050813172
5138:       objectReference: {fileID: 0}
5139:     - target: {fileID: 8447082967072642302, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5140:       propertyPath: m_LocalEulerAnglesHint.x
5141:       value: 36.159
5142:       objectReference: {fileID: 0}
5143:     - target: {fileID: 8447082967072642302, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5144:       propertyPath: m_LocalEulerAnglesHint.y
5145:       value: -54.298
5146:       objectReference: {fileID: 0}
5147:     - target: {fileID: 8447082967072642302, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5148:       propertyPath: m_LocalEulerAnglesHint.z
5149:       value: -25.8
5150:       objectReference: {fileID: 0}
5151:     m_RemovedComponents: []
5152:     m_RemovedGameObjects: []
5153:     m_AddedGameObjects:
5154:     - targetCorrespondingSourceObject: {fileID: -8679921383154817045, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5155:       insertIndex: -1
5156:       addedObject: {fileID: 330585546}
5157:     - targetCorrespondingSourceObject: {fileID: 1852576806548013000, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5158:       insertIndex: -1
5159:       addedObject: {fileID: 220352548}
5160:     m_AddedComponents:
5161:     - targetCorrespondingSourceObject: {fileID: 919132149155446097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5162:       insertIndex: -1
5163:       addedObject: {fileID: 704732032}
5164:     - targetCorrespondingSourceObject: {fileID: 919132149155446097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5165:       insertIndex: -1
5166:       addedObject: {fileID: 704732035}
5167:     - targetCorrespondingSourceObject: {fileID: 919132149155446097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5168:       insertIndex: -1
5169:       addedObject: {fileID: 704732034}
5170:     - targetCorrespondingSourceObject: {fileID: 919132149155446097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5171:       insertIndex: -1
5172:       addedObject: {fileID: 704732036}
5173:     - targetCorrespondingSourceObject: {fileID: 919132149155446097, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5174:       insertIndex: -1
5175:       addedObject: {fileID: 704732037}
5176:     - targetCorrespondingSourceObject: {fileID: 2715566404302941441, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5177:       insertIndex: -1
5178:       addedObject: {fileID: 940784576}
5179:   m_SourcePrefab: {fileID: 100100000, guid: 7878dd613adeed04c82667f222dd10a0, type: 3}
5180: --- !u!1 &1683486571
5181: GameObject:
5182:   m_ObjectHideFlags: 0
5183:   m_CorrespondingSourceObject: {fileID: 0}
5184:   m_PrefabInstance: {fileID: 0}
5185:   m_PrefabAsset: {fileID: 0}
5186:   serializedVersion: 6
5187:   m_Component:
5188:   - component: {fileID: 1683486574}
5189:   - component: {fileID: 1683486573}
5190:   - component: {fileID: 1683486572}
5191:   m_Layer: 0
5192:   m_Name: Trigger_Caida_Catacumbas
5193:   m_TagString: Untagged
5194:   m_Icon: {fileID: 0}
5195:   m_NavMeshLayer: 0
5196:   m_StaticEditorFlags: 0
5197:   m_IsActive: 1
5198: --- !u!114 &1683486572
5199: MonoBehaviour:
5200:   m_ObjectHideFlags: 0
5201:   m_CorrespondingSourceObject: {fileID: 0}
5202:   m_PrefabInstance: {fileID: 0}
5203:   m_PrefabAsset: {fileID: 0}
5204:   m_GameObject: {fileID: 1683486571}
5205:   m_Enabled: 1
5206:   m_EditorHideFlags: 0
5207:   m_Script: {fileID: 11500000, guid: 9dfcba5786bae9c49863ae747ce4fb3f, type: 3}
5208:   m_Name: 
5209:   m_EditorClassIdentifier: 
5210:   targetSceneName: Lvl 2
5211: --- !u!65 &1683486573
5212: BoxCollider:
5213:   m_ObjectHideFlags: 0
5214:   m_CorrespondingSourceObject: {fileID: 0}
5215:   m_PrefabInstance: {fileID: 0}
5216:   m_PrefabAsset: {fileID: 0}
5217:   m_GameObject: {fileID: 1683486571}
5218:   m_Material: {fileID: 0}
5219:   m_IncludeLayers:
5220:     serializedVersion: 2
5221:     m_Bits: 0
5222:   m_ExcludeLayers:
5223:     serializedVersion: 2
5224:     m_Bits: 0
5225:   m_LayerOverridePriority: 0
5226:   m_IsTrigger: 1
5227:   m_ProvidesContacts: 0
5228:   m_Enabled: 1
5229:   serializedVersion: 3
5230:   m_Size: {x: 9.482422, y: 7.3833904, z: 9.778564}
5231:   m_Center: {x: 0.9029236, y: 10.216094, z: 0.67248535}
5232: --- !u!4 &1683486574
5233: Transform:
5234:   m_ObjectHideFlags: 0
5235:   m_CorrespondingSourceObject: {fileID: 0}
5236:   m_PrefabInstance: {fileID: 0}
5237:   m_PrefabAsset: {fileID: 0}
5238:   m_GameObject: {fileID: 1683486571}
5239:   serializedVersion: 2
5240:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
5241:   m_LocalPosition: {x: 396.4556, y: 5, z: 566.8}
5242:   m_LocalScale: {x: 1, y: 1, z: 1}
5243:   m_ConstrainProportionsScale: 0
5244:   m_Children: []
5245:   m_Father: {fileID: 0}
5246:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
5247: --- !u!1 &1750535926
5248: GameObject:
5249:   m_ObjectHideFlags: 0
5250:   m_CorrespondingSourceObject: {fileID: 0}
5251:   m_PrefabInstance: {fileID: 0}
5252:   m_PrefabAsset: {fileID: 0}
5253:   serializedVersion: 6
5254:   m_Component:
5255:   - component: {fileID: 1750535927}
5256:   - component: {fileID: 1750535930}
5257:   - component: {fileID: 1750535929}
5258:   - component: {fileID: 1750535928}
5259:   m_Layer: 5
5260:   m_Name: Regresar
5261:   m_TagString: Untagged
5262:   m_Icon: {fileID: 0}
5263:   m_NavMeshLayer: 0
5264:   m_StaticEditorFlags: 0
5265:   m_IsActive: 1
5266: --- !u!224 &1750535927
5267: RectTransform:
5268:   m_ObjectHideFlags: 0
5269:   m_CorrespondingSourceObject: {fileID: 0}
5270:   m_PrefabInstance: {fileID: 0}
5271:   m_PrefabAsset: {fileID: 0}
5272:   m_GameObject: {fileID: 1750535926}
5273:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
5274:   m_LocalPosition: {x: 0, y: 0, z: 0}
5275:   m_LocalScale: {x: 1, y: 1, z: 1}
5276:   m_ConstrainProportionsScale: 0
5277:   m_Children:
5278:   - {fileID: 1844021845}
5279:   m_Father: {fileID: 753868972}
5280:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
5281:   m_AnchorMin: {x: 0.5, y: 0.5}
5282:   m_AnchorMax: {x: 0.5, y: 0.5}
5283:   m_AnchoredPosition: {x: -180.8, y: -69.7}
5284:   m_SizeDelta: {x: 169.9877, y: 48.0902}
5285:   m_Pivot: {x: 0.5, y: 0.5}
5286: --- !u!114 &1750535928
5287: MonoBehaviour:
5288:   m_ObjectHideFlags: 0
5289:   m_CorrespondingSourceObject: {fileID: 0}
5290:   m_PrefabInstance: {fileID: 0}
5291:   m_PrefabAsset: {fileID: 0}
5292:   m_GameObject: {fileID: 1750535926}
5293:   m_Enabled: 1
5294:   m_EditorHideFlags: 0
5295:   m_Script: {fileID: 11500000, guid: 4e29b1a8efbd4b44bb3f3716e73f07ff, type: 3}
5296:   m_Name: 
5297:   m_EditorClassIdentifier: 
5298:   m_Navigation:
5299:     m_Mode: 3
5300:     m_WrapAround: 0
5301:     m_SelectOnUp: {fileID: 0}
5302:     m_SelectOnDown: {fileID: 0}
5303:     m_SelectOnLeft: {fileID: 0}
5304:     m_SelectOnRight: {fileID: 0}
5305:   m_Transition: 1
5306:   m_Colors:
5307:     m_NormalColor: {r: 0.7075472, g: 0, b: 0, a: 0.14901961}
5308:     m_HighlightedColor: {r: 0.754717, g: 0.3025988, b: 0.3025988, a: 0.34117648}
5309:     m_PressedColor: {r: 0.7169812, g: 0.26041296, b: 0.26041296, a: 0.43137255}
5310:     m_SelectedColor: {r: 0.745283, g: 0.1511659, b: 0.1511659, a: 0.70980394}
5311:     m_DisabledColor: {r: 1, g: 0, b: 0, a: 1}
5312:     m_ColorMultiplier: 1
5313:     m_FadeDuration: 0.1
5314:   m_SpriteState:
5315:     m_HighlightedSprite: {fileID: 0}
5316:     m_PressedSprite: {fileID: 0}
5317:     m_SelectedSprite: {fileID: 0}
5318:     m_DisabledSprite: {fileID: 0}
5319:   m_AnimationTriggers:
5320:     m_NormalTrigger: Normal
5321:     m_HighlightedTrigger: Highlighted
5322:     m_PressedTrigger: Pressed
5323:     m_SelectedTrigger: Selected
5324:     m_DisabledTrigger: Disabled
5325:   m_Interactable: 1
5326:   m_TargetGraphic: {fileID: 1750535929}
5327:   m_OnClick:
5328:     m_PersistentCalls:
5329:       m_Calls:
5330:       - m_Target: {fileID: 1338461}
5331:         m_TargetAssemblyTypeName: GameManager, Assembly-CSharp
5332:         m_MethodName: Back
5333:         m_Mode: 1
5334:         m_Arguments:
5335:           m_ObjectArgument: {fileID: 0}
5336:           m_ObjectArgumentAssemblyTypeName: UnityEngine.Object, UnityEngine
5337:           m_IntArgument: 0
5338:           m_FloatArgument: 0
5339:           m_StringArgument: 
5340:           m_BoolArgument: 0
5341:         m_CallState: 2
5342: --- !u!114 &1750535929
5343: MonoBehaviour:
5344:   m_ObjectHideFlags: 0
5345:   m_CorrespondingSourceObject: {fileID: 0}
5346:   m_PrefabInstance: {fileID: 0}
5347:   m_PrefabAsset: {fileID: 0}
5348:   m_GameObject: {fileID: 1750535926}
5349:   m_Enabled: 1
5350:   m_EditorHideFlags: 0
5351:   m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
5352:   m_Name: 
5353:   m_EditorClassIdentifier: 
5354:   m_Material: {fileID: 0}
5355:   m_Color: {r: 1, g: 1, b: 1, a: 1}
5356:   m_RaycastTarget: 1
5357:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
5358:   m_Maskable: 1
5359:   m_OnCullStateChanged:
5360:     m_PersistentCalls:
5361:       m_Calls: []
5362:   m_Sprite: {fileID: 10905, guid: 0000000000000000f000000000000000, type: 0}
5363:   m_Type: 1
5364:   m_PreserveAspect: 0
5365:   m_FillCenter: 1
5366:   m_FillMethod: 4
5367:   m_FillAmount: 1
5368:   m_FillClockwise: 1
5369:   m_FillOrigin: 0
5370:   m_UseSpriteMesh: 0
5371:   m_PixelsPerUnitMultiplier: 1
5372: --- !u!222 &1750535930
5373: CanvasRenderer:
5374:   m_ObjectHideFlags: 0
5375:   m_CorrespondingSourceObject: {fileID: 0}
5376:   m_PrefabInstance: {fileID: 0}
5377:   m_PrefabAsset: {fileID: 0}
5378:   m_GameObject: {fileID: 1750535926}
5379:   m_CullTransparentMesh: 1
5380: --- !u!1 &1798642321
5381: GameObject:
5382:   m_ObjectHideFlags: 0
5383:   m_CorrespondingSourceObject: {fileID: 0}
5384:   m_PrefabInstance: {fileID: 0}
5385:   m_PrefabAsset: {fileID: 0}
5386:   serializedVersion: 6
5387:   m_Component:
5388:   - component: {fileID: 1798642322}
5389:   m_Layer: 5
5390:   m_Name: Handle Slide Area
5391:   m_TagString: Untagged
5392:   m_Icon: {fileID: 0}
5393:   m_NavMeshLayer: 0
5394:   m_StaticEditorFlags: 0
5395:   m_IsActive: 1
5396: --- !u!224 &1798642322
5397: RectTransform:
5398:   m_ObjectHideFlags: 0
5399:   m_CorrespondingSourceObject: {fileID: 0}
5400:   m_PrefabInstance: {fileID: 0}
5401:   m_PrefabAsset: {fileID: 0}
5402:   m_GameObject: {fileID: 1798642321}
5403:   m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
5404:   m_LocalPosition: {x: 0, y: 0, z: 0}
5405:   m_LocalScale: {x: 1, y: 1, z: 1}
5406:   m_ConstrainProportionsScale: 0
5407:   m_Children:
5408:   - {fileID: 2059794854}
5409:   m_Father: {fileID: 1091955426}
5410:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
5411:   m_AnchorMin: {x: 0, y: 0}
5412:   m_AnchorMax: {x: 1, y: 1}
5413:   m_AnchoredPosition: {x: 0, y: 0}
5414:   m_SizeDelta: {x: -20, y: 0}
5415:   m_Pivot: {x: 0.5, y: 0.5}
5416: --- !u!1 &1804490200
5417: GameObject:
5418:   m_ObjectHideFlags: 0
5419:   m_CorrespondingSourceObject: {fileID: 0}
5420:   m_PrefabInstance: {fileID: 0}
5421:   m_PrefabAsset: {fileID: 0}
5422:   serializedVersion: 6
5423:   m_Component:
5424:   - component: {fileID: 1804490203}
5425:   - component: {fileID: 1804490202}
5426:   - component: {fileID: 1804490201}
5427:   m_Layer: 0
5428:   m_Name: Point Light
5429:   m_TagString: Untagged
5430:   m_Icon: {fileID: 0}
5431:   m_NavMeshLayer: 0
5432:   m_StaticEditorFlags: 0
5433:   m_IsActive: 1
5434: --- !u!114 &1804490201
5435: MonoBehaviour:
5436:   m_ObjectHideFlags: 0
5437:   m_CorrespondingSourceObject: {fileID: 0}
5438:   m_PrefabInstance: {fileID: 0}
5439:   m_PrefabAsset: {fileID: 0}
5440:   m_GameObject: {fileID: 1804490200}
5441:   m_Enabled: 1
5442:   m_EditorHideFlags: 0
5443:   m_Script: {fileID: 11500000, guid: 03aed3bc14b98634ea1df5ec16d00ada, type: 3}
5444:   m_Name: 
5445:   m_EditorClassIdentifier: 
5446:   esperaMinima: 0.1
5447:   esperaMaxima: 2
5448: --- !u!108 &1804490202
5449: Light:
5450:   m_ObjectHideFlags: 0
5451:   m_CorrespondingSourceObject: {fileID: 0}
5452:   m_PrefabInstance: {fileID: 0}
5453:   m_PrefabAsset: {fileID: 0}
5454:   m_GameObject: {fileID: 1804490200}
5455:   m_Enabled: 1
5456:   serializedVersion: 10
5457:   m_Type: 2
5458:   m_Shape: 0
5459:   m_Color: {r: 1, g: 1, b: 1, a: 1}
5460:   m_Intensity: 0.5
5461:   m_Range: 10
5462:   m_SpotAngle: 30
5463:   m_InnerSpotAngle: 21.80208
5464:   m_CookieSize: 10
5465:   m_Shadows:
5466:     m_Type: 1
5467:     m_Resolution: -1
5468:     m_CustomResolution: -1
5469:     m_Strength: 1
5470:     m_Bias: 0.05
5471:     m_NormalBias: 0.4
5472:     m_NearPlane: 0.2
5473:     m_CullingMatrixOverride:
5474:       e00: 1
5475:       e01: 0
5476:       e02: 0
5477:       e03: 0
5478:       e10: 0
5479:       e11: 1
5480:       e12: 0
5481:       e13: 0
5482:       e20: 0
5483:       e21: 0
5484:       e22: 1
5485:       e23: 0
5486:       e30: 0
5487:       e31: 0
5488:       e32: 0
5489:       e33: 1
5490:     m_UseCullingMatrixOverride: 0
5491:   m_Cookie: {fileID: 0}
5492:   m_DrawHalo: 0
5493:   m_Flare: {fileID: 0}
5494:   m_RenderMode: 0
5495:   m_CullingMask:
5496:     serializedVersion: 2
5497:     m_Bits: 4294967295
5498:   m_RenderingLayerMask: 1
5499:   m_Lightmapping: 4
5500:   m_LightShadowCasterMode: 0
5501:   m_AreaSize: {x: 1, y: 1}
5502:   m_BounceIntensity: 1
5503:   m_ColorTemperature: 6570
5504:   m_UseColorTemperature: 0
5505:   m_BoundingSphereOverride: {x: 0, y: 0, z: 0, w: 0}
5506:   m_UseBoundingSphereOverride: 0
5507:   m_UseViewFrustumForShadowCasterCull: 1
5508:   m_ShadowRadius: 0
5509:   m_ShadowAngle: 0
5510: --- !u!4 &1804490203
5511: Transform:
5512:   m_ObjectHideFlags: 0
5513:   m_CorrespondingSourceObject: {fileID: 0}
5514:   m_PrefabInstance: {fileID: 0}
5515:   m_PrefabAsset: {fileID: 0}
5516:   m_GameObject: {fileID: 1804490200}
5517:   serializedVersion: 2
5518:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
5519:   m_LocalPosition: {x: 0, y: 2.905, z: 10.534}
5520:   m_LocalScale: {x: 1, y: 1, z: 1}
5521:   m_ConstrainProportionsScale: 0
5522:   m_Children: []
5523:   m_Father: {fileID: 0}
5524:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
5525: --- !u!1 &1844021844
5526: GameObject:
5527:   m_ObjectHideFlags: 0
5528:   m_CorrespondingSourceObject: {fileID: 0}
5529:   m_PrefabInstance: {fileID: 0}
5530:   m_PrefabAsset: {fileID: 0}
5531:   serializedVersion: 6
5532:   m_Component:
5533:   - component: {fileID: 1844021845}
5534:   - component: {fileID: 1844021847}
5535:   - component: {fileID: 1844021846}
5536:   m_Layer: 5
5537:   m_Name: Text (TMP)
5538:   m_TagString: Untagged
5539:   m_Icon: {fileID: 0}
5540:   m_NavMeshLayer: 0
5541:   m_StaticEditorFlags: 0
5542:   m_IsActive: 1
5543: --- !u!224 &1844021845
5544: RectTransform:
5545:   m_ObjectHideFlags: 0
5546:   m_CorrespondingSourceObject: {fileID: 0}
5547:   m_PrefabInstance: {fileID: 0}
5548:   m_PrefabAsset: {fileID: 0}
5549:   m_GameObject: {fileID: 1844021844}
5550:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
5551:   m_LocalPosition: {x: 0, y: 0, z: 0}
5552:   m_LocalScale: {x: 1, y: 1, z: 1}
5553:   m_ConstrainProportionsScale: 0
5554:   m_Children: []
5555:   m_Father: {fileID: 1750535927}
5556:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
5557:   m_AnchorMin: {x: 0, y: 0}
5558:   m_AnchorMax: {x: 1, y: 1}
5559:   m_AnchoredPosition: {x: 0, y: 0}
5560:   m_SizeDelta: {x: 0, y: 0}
5561:   m_Pivot: {x: 0.5, y: 0.5}
5562: --- !u!114 &1844021846
5563: MonoBehaviour:
5564:   m_ObjectHideFlags: 0
5565:   m_CorrespondingSourceObject: {fileID: 0}
5566:   m_PrefabInstance: {fileID: 0}
5567:   m_PrefabAsset: {fileID: 0}
5568:   m_GameObject: {fileID: 1844021844}
5569:   m_Enabled: 1
5570:   m_EditorHideFlags: 0
5571:   m_Script: {fileID: 11500000, guid: f4688fdb7df04437aeb418b961361dc5, type: 3}
5572:   m_Name: 
5573:   m_EditorClassIdentifier: 
5574:   m_Material: {fileID: 0}
5575:   m_Color: {r: 1, g: 1, b: 1, a: 1}
5576:   m_RaycastTarget: 1
5577:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
5578:   m_Maskable: 1
5579:   m_OnCullStateChanged:
5580:     m_PersistentCalls:
5581:       m_Calls: []
5582:   m_text: Volver
5583:   m_isRightToLeft: 0
5584:   m_fontAsset: {fileID: 11400000, guid: 125cb55b44b24c4393181402bc6200e6, type: 2}
5585:   m_sharedMaterial: {fileID: 2100000, guid: d75b8f41e959450c84ac6e967084d3e1, type: 2}
5586:   m_fontSharedMaterials: []
5587:   m_fontMaterial: {fileID: 0}
5588:   m_fontMaterials: []
5589:   m_fontColor32:
5590:     serializedVersion: 2
5591:     rgba: 4281216654
5592:   m_fontColor: {r: 0.5566038, g: 0.18115878, b: 0.18115878, a: 1}
5593:   m_enableVertexGradient: 0
5594:   m_colorMode: 3
5595:   m_fontColorGradient:
5596:     topLeft: {r: 1, g: 1, b: 1, a: 1}
5597:     topRight: {r: 1, g: 1, b: 1, a: 1}
5598:     bottomLeft: {r: 1, g: 1, b: 1, a: 1}
5599:     bottomRight: {r: 1, g: 1, b: 1, a: 1}
5600:   m_fontColorGradientPreset: {fileID: 0}
5601:   m_spriteAsset: {fileID: 0}
5602:   m_tintAllSprites: 0
5603:   m_StyleSheet: {fileID: 0}
5604:   m_TextStyleHashCode: -1183493901
5605:   m_overrideHtmlColors: 0
5606:   m_faceColor:
5607:     serializedVersion: 2
5608:     rgba: 4294967295
5609:   m_fontSize: 40
5610:   m_fontSizeBase: 40
5611:   m_fontWeight: 400
5612:   m_enableAutoSizing: 0
5613:   m_fontSizeMin: 0
5614:   m_fontSizeMax: 0
5615:   m_fontStyle: 0
5616:   m_HorizontalAlignment: 2
5617:   m_VerticalAlignment: 512
5618:   m_textAlignment: 65535
5619:   m_characterSpacing: 0
5620:   m_wordSpacing: 0
5621:   m_lineSpacing: 0
5622:   m_lineSpacingMax: 0
5623:   m_paragraphSpacing: 0
5624:   m_charWidthMaxAdj: 0
5625:   m_enableWordWrapping: 0
5626:   m_wordWrappingRatios: 0.4
5627:   m_overflowMode: 0
5628:   m_linkedTextComponent: {fileID: 0}
5629:   parentLinkedComponent: {fileID: 0}
5630:   m_enableKerning: 0
5631:   m_enableExtraPadding: 0
5632:   checkPaddingRequired: 0
5633:   m_isRichText: 1
5634:   m_parseCtrlCharacters: 1
5635:   m_isOrthographic: 1
5636:   m_isCullingEnabled: 0
5637:   m_horizontalMapping: 0
5638:   m_verticalMapping: 0
5639:   m_uvLineOffset: 0
5640:   m_geometrySortingOrder: 0
5641:   m_IsTextObjectScaleStatic: 0
5642:   m_VertexBufferAutoSizeReduction: 0
5643:   m_useMaxVisibleDescender: 1
5644:   m_pageToDisplay: 1
5645:   m_margin: {x: 0, y: 0, z: 0, w: 0}
5646:   m_isUsingLegacyAnimationComponent: 0
5647:   m_isVolumetricText: 0
5648:   m_hasFontAssetChanged: 0
5649:   m_baseMaterial: {fileID: 0}
5650:   m_maskOffset: {x: 0, y: 0, z: 0, w: 0}
5651: --- !u!222 &1844021847
5652: CanvasRenderer:
5653:   m_ObjectHideFlags: 0
5654:   m_CorrespondingSourceObject: {fileID: 0}
5655:   m_PrefabInstance: {fileID: 0}
5656:   m_PrefabAsset: {fileID: 0}
5657:   m_GameObject: {fileID: 1844021844}
5658:   m_CullTransparentMesh: 1
5659: --- !u!1001 &2018635965
5660: PrefabInstance:
5661:   m_ObjectHideFlags: 0
5662:   serializedVersion: 2
5663:   m_Modification:
5664:     serializedVersion: 3
5665:     m_TransformParent: {fileID: 0}
5666:     m_Modifications:
5667:     - target: {fileID: 1275084491436936, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5668:       propertyPath: m_Name
5669:       value: Reliquia_Nivel1 (1)
5670:       objectReference: {fileID: 0}
5671:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5672:       propertyPath: m_LocalScale.x
5673:       value: 2.5
5674:       objectReference: {fileID: 0}
5675:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5676:       propertyPath: m_LocalScale.y
5677:       value: 2.5
5678:       objectReference: {fileID: 0}
5679:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5680:       propertyPath: m_LocalScale.z
5681:       value: 2.5
5682:       objectReference: {fileID: 0}
5683:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5684:       propertyPath: m_LocalPosition.x
5685:       value: 395.55
5686:       objectReference: {fileID: 0}
5687:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5688:       propertyPath: m_LocalPosition.y
5689:       value: 23.65
5690:       objectReference: {fileID: 0}
5691:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5692:       propertyPath: m_LocalPosition.z
5693:       value: 565.04
5694:       objectReference: {fileID: 0}
5695:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5696:       propertyPath: m_LocalRotation.w
5697:       value: -0.06599268
5698:       objectReference: {fileID: 0}
5699:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5700:       propertyPath: m_LocalRotation.x
5701:       value: -0
5702:       objectReference: {fileID: 0}
5703:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5704:       propertyPath: m_LocalRotation.y
5705:       value: -0.99782014
5706:       objectReference: {fileID: 0}
5707:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5708:       propertyPath: m_LocalRotation.z
5709:       value: -0
5710:       objectReference: {fileID: 0}
5711:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5712:       propertyPath: m_LocalEulerAnglesHint.x
5713:       value: 0
5714:       objectReference: {fileID: 0}
5715:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5716:       propertyPath: m_LocalEulerAnglesHint.y
5717:       value: -187.568
5718:       objectReference: {fileID: 0}
5719:     - target: {fileID: 4344557194693220, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5720:       propertyPath: m_LocalEulerAnglesHint.z
5721:       value: 0
5722:       objectReference: {fileID: 0}
5723:     - target: {fileID: 64324016407306108, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5724:       propertyPath: m_Convex
5725:       value: 1
5726:       objectReference: {fileID: 0}
5727:     - target: {fileID: 64324016407306108, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5728:       propertyPath: m_IsTrigger
5729:       value: 1
5730:       objectReference: {fileID: 0}
5731:     m_RemovedComponents: []
5732:     m_RemovedGameObjects: []
5733:     m_AddedGameObjects: []
5734:     m_AddedComponents:
5735:     - targetCorrespondingSourceObject: {fileID: 1275084491436936, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5736:       insertIndex: -1
5737:       addedObject: {fileID: 1465907517}
5738:     - targetCorrespondingSourceObject: {fileID: 1275084491436936, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5739:       insertIndex: -1
5740:       addedObject: {fileID: 1465907516}
5741:     - targetCorrespondingSourceObject: {fileID: 1275084491436936, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5742:       insertIndex: -1
5743:       addedObject: {fileID: 1465907515}
5744:   m_SourcePrefab: {fileID: 100100000, guid: a957dc986069ca3409a5fb1599a3cad8, type: 3}
5745: --- !u!1 &2043724653
5746: GameObject:
5747:   m_ObjectHideFlags: 0
5748:   m_CorrespondingSourceObject: {fileID: 0}
5749:   m_PrefabInstance: {fileID: 0}
5750:   m_PrefabAsset: {fileID: 0}
5751:   serializedVersion: 6
5752:   m_Component:
5753:   - component: {fileID: 2043724654}
5754:   - component: {fileID: 2043724656}
5755:   - component: {fileID: 2043724655}
5756:   m_Layer: 5
5757:   m_Name: RawImage
5758:   m_TagString: Untagged
5759:   m_Icon: {fileID: 0}
5760:   m_NavMeshLayer: 0
5761:   m_StaticEditorFlags: 0
5762:   m_IsActive: 1
5763: --- !u!224 &2043724654
5764: RectTransform:
5765:   m_ObjectHideFlags: 0
5766:   m_CorrespondingSourceObject: {fileID: 0}
5767:   m_PrefabInstance: {fileID: 0}
5768:   m_PrefabAsset: {fileID: 0}
5769:   m_GameObject: {fileID: 2043724653}
5770:   m_LocalRotation: {x: 0, y: 0, z: 0, w: 1}
5771:   m_LocalPosition: {x: 0, y: 0, z: 0}
5772:   m_LocalScale: {x: 1, y: 1, z: 1}
5773:   m_ConstrainProportionsScale: 0
5774:   m_Children: []
5775:   m_Father: {fileID: 61253949}
5776:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
5777:   m_AnchorMin: {x: 0.5, y: 0.5}
5778:   m_AnchorMax: {x: 0.5, y: 0.5}
5779:   m_AnchoredPosition: {x: 0, y: 0.0007915497}
5780:   m_SizeDelta: {x: 800, y: 450.16}
5781:   m_Pivot: {x: 0.5, y: 0.5}
5782: --- !u!114 &2043724655
5783: MonoBehaviour:
5784:   m_ObjectHideFlags: 0
5785:   m_CorrespondingSourceObject: {fileID: 0}
5786:   m_PrefabInstance: {fileID: 0}
5787:   m_PrefabAsset: {fileID: 0}
5788:   m_GameObject: {fileID: 2043724653}
5789:   m_Enabled: 1
5790:   m_EditorHideFlags: 0
5791:   m_Script: {fileID: 11500000, guid: 1344c3c82d62a2a41a3576d8abb8e3ea, type: 3}
5792:   m_Name: 
5793:   m_EditorClassIdentifier: 
5794:   m_Material: {fileID: 0}
5795:   m_Color: {r: 1, g: 1, b: 1, a: 1}
5796:   m_RaycastTarget: 1
5797:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
5798:   m_Maskable: 1
5799:   m_OnCullStateChanged:
5800:     m_PersistentCalls:
5801:       m_Calls: []
5802:   m_Texture: {fileID: 2800000, guid: c50cf53deda4a444791ad8c26d6f135b, type: 3}
5803:   m_UVRect:
5804:     serializedVersion: 2
5805:     x: 0
5806:     y: 0
5807:     width: 1
5808:     height: 1
5809: --- !u!222 &2043724656
5810: CanvasRenderer:
5811:   m_ObjectHideFlags: 0
5812:   m_CorrespondingSourceObject: {fileID: 0}
5813:   m_PrefabInstance: {fileID: 0}
5814:   m_PrefabAsset: {fileID: 0}
5815:   m_GameObject: {fileID: 2043724653}
5816:   m_CullTransparentMesh: 1
5817: --- !u!1 &2059794853
5818: GameObject:
5819:   m_ObjectHideFlags: 0
5820:   m_CorrespondingSourceObject: {fileID: 0}
5821:   m_PrefabInstance: {fileID: 0}
5822:   m_PrefabAsset: {fileID: 0}
5823:   serializedVersion: 6
5824:   m_Component:
5825:   - component: {fileID: 2059794854}
5826:   - component: {fileID: 2059794856}
5827:   - component: {fileID: 2059794855}
5828:   m_Layer: 5
5829:   m_Name: Handle
5830:   m_TagString: Untagged
5831:   m_Icon: {fileID: 0}
5832:   m_NavMeshLayer: 0
5833:   m_StaticEditorFlags: 0
5834:   m_IsActive: 1
5835: --- !u!224 &2059794854
5836: RectTransform:
5837:   m_ObjectHideFlags: 0
5838:   m_CorrespondingSourceObject: {fileID: 0}
5839:   m_PrefabInstance: {fileID: 0}
5840:   m_PrefabAsset: {fileID: 0}
5841:   m_GameObject: {fileID: 2059794853}
5842:   m_LocalRotation: {x: -0, y: -0, z: -0, w: 1}
5843:   m_LocalPosition: {x: 0, y: 0, z: 0}
5844:   m_LocalScale: {x: 1, y: 1, z: 1}
5845:   m_ConstrainProportionsScale: 0
5846:   m_Children: []
5847:   m_Father: {fileID: 1798642322}
5848:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
5849:   m_AnchorMin: {x: 0, y: 0}
5850:   m_AnchorMax: {x: 0, y: 1}
5851:   m_AnchoredPosition: {x: 0, y: 0}
5852:   m_SizeDelta: {x: 20, y: 0}
5853:   m_Pivot: {x: 0.5, y: 0.5}
5854: --- !u!114 &2059794855
5855: MonoBehaviour:
5856:   m_ObjectHideFlags: 0
5857:   m_CorrespondingSourceObject: {fileID: 0}
5858:   m_PrefabInstance: {fileID: 0}
5859:   m_PrefabAsset: {fileID: 0}
5860:   m_GameObject: {fileID: 2059794853}
5861:   m_Enabled: 1
5862:   m_EditorHideFlags: 0
5863:   m_Script: {fileID: 11500000, guid: fe87c0e1cc204ed48ad3b37840f39efc, type: 3}
5864:   m_Name: 
5865:   m_EditorClassIdentifier: 
5866:   m_Material: {fileID: 0}
5867:   m_Color: {r: 1, g: 1, b: 1, a: 1}
5868:   m_RaycastTarget: 1
5869:   m_RaycastPadding: {x: 0, y: 0, z: 0, w: 0}
5870:   m_Maskable: 1
5871:   m_OnCullStateChanged:
5872:     m_PersistentCalls:
5873:       m_Calls: []
5874:   m_Sprite: {fileID: 10913, guid: 0000000000000000f000000000000000, type: 0}
5875:   m_Type: 0
5876:   m_PreserveAspect: 0
5877:   m_FillCenter: 1
5878:   m_FillMethod: 4
5879:   m_FillAmount: 1
5880:   m_FillClockwise: 1
5881:   m_FillOrigin: 0
5882:   m_UseSpriteMesh: 0
5883:   m_PixelsPerUnitMultiplier: 1
5884: --- !u!222 &2059794856
5885: CanvasRenderer:
5886:   m_ObjectHideFlags: 0
5887:   m_CorrespondingSourceObject: {fileID: 0}
5888:   m_PrefabInstance: {fileID: 0}
5889:   m_PrefabAsset: {fileID: 0}
5890:   m_GameObject: {fileID: 2059794853}
5891:   m_CullTransparentMesh: 1
5892: --- !u!1 &2067996069
5893: GameObject:
5894:   m_ObjectHideFlags: 0
5895:   m_CorrespondingSourceObject: {fileID: 0}
5896:   m_PrefabInstance: {fileID: 0}
5897:   m_PrefabAsset: {fileID: 0}
5898:   serializedVersion: 6
5899:   m_Component:
5900:   - component: {fileID: 2067996070}
5901:   - component: {fileID: 2067996071}
5902:   - component: {fileID: 2067996072}
5903:   m_Layer: 0
5904:   m_Name: Spot Light
5905:   m_TagString: Untagged
5906:   m_Icon: {fileID: 0}
5907:   m_NavMeshLayer: 0
5908:   m_StaticEditorFlags: 0
5909:   m_IsActive: 1
5910: --- !u!4 &2067996070
5911: Transform:
5912:   m_ObjectHideFlags: 0
5913:   m_CorrespondingSourceObject: {fileID: 0}
5914:   m_PrefabInstance: {fileID: 0}
5915:   m_PrefabAsset: {fileID: 0}
5916:   m_GameObject: {fileID: 2067996069}
5917:   serializedVersion: 2
5918:   m_LocalRotation: {x: -0, y: -0, z: 0.99647826, w: 0.08385185}
5919:   m_LocalPosition: {x: 0, y: 0, z: 0.0483}
5920:   m_LocalScale: {x: 0.33333328, y: 0.33333328, z: 0.33333334}
5921:   m_ConstrainProportionsScale: 0
5922:   m_Children: []
5923:   m_Father: {fileID: 220352548}
5924:   m_LocalEulerAnglesHint: {x: 0, y: 0, z: 0}
5925: --- !u!108 &2067996071
5926: Light:
5927:   m_ObjectHideFlags: 0
5928:   m_CorrespondingSourceObject: {fileID: 0}
5929:   m_PrefabInstance: {fileID: 0}
5930:   m_PrefabAsset: {fileID: 0}
5931:   m_GameObject: {fileID: 2067996069}
5932:   m_Enabled: 1
5933:   serializedVersion: 10
5934:   m_Type: 0
5935:   m_Shape: 0
5936:   m_Color: {r: 1, g: 1, b: 1, a: 1}
5937:   m_Intensity: 1
5938:   m_Range: 12.460467
5939:   m_SpotAngle: 55.714314
5940:   m_InnerSpotAngle: 1.1933588
5941:   m_CookieSize: 10
5942:   m_Shadows:
5943:     m_Type: 0
5944:     m_Resolution: -1
5945:     m_CustomResolution: -1
5946:     m_Strength: 1
5947:     m_Bias: 0.05
5948:     m_NormalBias: 0.4
5949:     m_NearPlane: 0.2
5950:     m_CullingMatrixOverride:
5951:       e00: 1
5952:       e01: 0
5953:       e02: 0
5954:       e03: 0
5955:       e10: 0
5956:       e11: 1
5957:       e12: 0
5958:       e13: 0
5959:       e20: 0
5960:       e21: 0
5961:       e22: 1
5962:       e23: 0
5963:       e30: 0
5964:       e31: 0
5965:       e32: 0
5966:       e33: 1
5967:     m_UseCullingMatrixOverride: 0
5968:   m_Cookie: {fileID: 0}
5969:   m_DrawHalo: 0
5970:   m_Flare: {fileID: 0}
5971:   m_RenderMode: 0
5972:   m_CullingMask:
5973:     serializedVersion: 2
5974:     m_Bits: 4294967295
5975:   m_RenderingLayerMask: 1
5976:   m_Lightmapping: 4
5977:   m_LightShadowCasterMode: 0
5978:   m_AreaSize: {x: 1, y: 1}
5979:   m_BounceIntensity: 1
5980:   m_ColorTemperature: 6570
5981:   m_UseColorTemperature: 0
5982:   m_BoundingSphereOverride: {x: 0, y: 0, z: 0, w: 0}
5983:   m_UseBoundingSphereOverride: 0
5984:   m_UseViewFrustumForShadowCasterCull: 1
5985:   m_ShadowRadius: 0
5986:   m_ShadowAngle: 0
5987: --- !u!114 &2067996072
5988: MonoBehaviour:
5989:   m_ObjectHideFlags: 0
5990:   m_CorrespondingSourceObject: {fileID: 0}
5991:   m_PrefabInstance: {fileID: 0}
5992:   m_PrefabAsset: {fileID: 0}
5993:   m_GameObject: {fileID: 2067996069}
5994:   m_Enabled: 1
5995:   m_EditorHideFlags: 0
5996:   m_Script: {fileID: 11500000, guid: 62899f850307741f2a39c98a8b639597, type: 3}
5997:   m_Name: 
5998:   m_EditorClassIdentifier: 
5999:   m_Actions: {fileID: -944628639613478452, guid: 61918e08ac444e14cbca19e224d7d22e, type: 3}
6000:   m_NotificationBehavior: 0
6001:   m_UIInputModule: {fileID: 0}
6002:   m_DeviceLostEvent:
6003:     m_PersistentCalls:
6004:       m_Calls: []
6005:   m_DeviceRegainedEvent:
6006:     m_PersistentCalls:
6007:       m_Calls: []
6008:   m_ControlsChangedEvent:
6009:     m_PersistentCalls:
6010:       m_Calls: []
6011:   m_ActionEvents: []
6012:   m_NeverAutoSwitchControlSchemes: 0
6013:   m_DefaultControlScheme: 
6014:   m_DefaultActionMap: Player
6015:   m_SplitScreenIndex: -1
6016:   m_Camera: {fileID: 0}
6017: --- !u!1660057539 &9223372036854775807
6018: SceneRoots:
6019:   m_ObjectHideFlags: 0
6020:   m_Roots:
6021:   - {fileID: 365391669}
6022:   - {fileID: 1338460}
6023:   - {fileID: 1206017639}
6024:   - {fileID: 1804490203}
6025:   - {fileID: 751834282}
6026:   - {fileID: 978263885}
6027:   - {fileID: 61253949}
6028:   - {fileID: 753868972}
6029:   - {fileID: 1614476352}
6030:   - {fileID: 1186536025}
6031:   - {fileID: 874196384}
6032:   - {fileID: 984701942}
6033:   - {fileID: 917053888}
6034:   - {fileID: 793788511}
6035:   - {fileID: 1322213181}
6036:   - {fileID: 317525508}
6037:   - {fileID: 575162934}
6038:   - {fileID: 2018635965}
6039:   - {fileID: 1683486574}
```

## File: Assets/_Scripts/ElementsMove.cs
```csharp
 1: using System.Collections;
 2: using System.Collections.Generic;
 3: using Unity.VisualScripting;
 4: using UnityEngine;
 5: 
 6: public class ElementsMove : MonoBehaviour
 7: {
 8:     private GameManager gameManager; // Referencia al GameManager para verificar el puntaje y la posición del objeto next
 9:     private Vector3 startPosition; // Variable para almacenar la posición inicial del objeto
10:     void Start()
11:     {// Obtiene la referencia al GameManager buscando el objeto con el nombre "Game Manager" en la escena y accediendo a su componente GameManager
12:         gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>(); 
13:     }
14: 
15:     void Update()
16:     {
17:         startPosition = transform.position; //Guarda la posición inicial del objeto
18: 
19:         if (transform.position.x <= 4.69f && gameManager.objectScore == 3) //Si el objeto está en la posición de la puerta y se han recogido los 3 objetos, se mueve hacia adelante
20:         {
21:             transform.Translate(Vector3.forward * 0.5f * Time.deltaTime); // Mueve el objeto hacia adelante a una velocidad de 0.5 unidades por segundo
22:         }
23:         else transform.position = startPosition; // Si el objeto no está en la posición de la puerta o no se han recogido los 6 objetos, se mantiene en su posición inicial
24: 
25:     }
26: }
```

## File: Assets/_Scripts/EnemyIA.cs
```csharp
  1: using System.Collections;
  2: using System.Collections.Generic;
  3: using UnityEngine;
  4: using UnityEngine.AI;
  5: using UnityEngine.SceneManagement;
  6: 
  7: public class EnemyIA : MonoBehaviour
  8: {
  9:     // Variables configurables
 10:     
 11:     public float visionRate = 10f; // Distancia a la que te ve
 12:     public float roadRate = 30f; // Qué tan lejos puede ir al deambular
 13:     public float tiempoDeEspera = 3f;  // Tiempo que espera en cada punto al deambular
 14:     public float run = 3f; // Velocidad al perseguir
 15:     public float walk = 1.5f; // Velocidad al deambular
 16:     private float cronometro; // Para contar el tiempo de espera al deambular
 17:     private GameManager gameManager; // Referencia al GameManager para verificar el puntaje
 18:     public Transform jugador; // Arrastra aquí al Player
 19:     Animator anim; // Referencia al Animator para controlar las animaciones
 20:     private NavMeshAgent agente; // Componentes y estado interno
 21:     private PlayerController playerController; // Referencia al PlayerController para verificar si el jugador está en la zona segura
 22:     private bool jugadorEnVista; // Si el jugador está dentro del radio de visión
 23:     public bool walkUp = false; // Si el enemigo está caminando erguido (después de recoger 3 objetos)
 24:     bool GameOver = false; // Si el juego ha terminado (para evitar que la IA siga actuando después de ganar o perder)
 25:     private bool transformado = false; // Bandera para que la transformación de score 3 solo se ejecute una única vez
 26:     void Start()
 27:     {
 28:         // Obtener referencias a componentes y objetos necesarios
 29:         playerController = GameObject.Find("Player").GetComponent<PlayerController>();
 30:         anim = GetComponent<Animator>();
 31:         gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
 32:         agente = GetComponent<NavMeshAgent>();
 33:         jugador = GameObject.Find("Player").transform;
 34:         // Empezamos deambulando a un punto aleatorio
 35:         SetNuevoPuntoAleatorio();
 36:         // Iniciar la corrutina para cambiar a caminar erguido después de 30 segundos
 37:         StartCoroutine(StateAnim());
 38:     }
 39: 
 40:     void Update()
 41:     {
 42:         // Detección: ¿El jugador está cerca?
 43:         float distanciaAlJugador = Vector3.Distance(transform.position, jugador.position);
 44:         // El jugador está en vista si está dentro del radio de visión y el juego no ha terminado
 45:         if (distanciaAlJugador <= visionRate && GameOver == false)
 46:         {
 47:             jugadorEnVista = true; // El jugador está dentro del radio de visión
 48:         }
 49:         else
 50:         {
 51:             jugadorEnVista = false; // El jugador está fuera del radio de visión o el juego ha terminado
 52:         }
 53:         // Comportamiento: Si el jugador está en vista y no está en la zona segura, perseguirlo. Si no, deambular.
 54:         if (jugadorEnVista && PuedoVerAlJugador() && !playerController.safeZone && GameOver == false)
 55:         {
 56:             PerseguirJugador();
 57:         }
 58:         else
 59:         {
 60:             DeambularAletorio();// Si el jugador no está en vista o está en la zona segura, deambular
 61:         }
 62:         // Cambios de estado basados en el puntaje del jugador
 63:         if (gameManager != null && gameManager.objectScore == 3 && GameOver == false && !transformado)
 64:         {
 65:             transformado = true;
 66:             walkUp = true; // El enemigo empieza a caminar erguido después de recoger 3 objetos
 67:             anim.SetBool("Up", true); // Activa la animación de caminar erguido
 68:             anim.SetBool("Walk", true); // Activa la animación de caminar
 69:             run = 5f; // Aumenta la velocidad al perseguir después de recoger 3 objetos
 70:             walk = 3f; // Aumenta la velocidad al deambular después de recoger 3 objetos
 71:             roadRate = 15f; // Aumenta el radio de deambulación después de recoger 3 objetos
 72:             visionRate = 20f; // Aumenta el radio de visión después de recoger 3 objetos
 73:             StartCoroutine(StateStop()); // Inicia la corrutina para volver a caminar normal después de 7.5 segundos
 74:         }
 75:         // Si el jugador ha recogido 3 objetos, el enemigo se vuelve aún más rápido y agresivo
 76:         if (gameManager.objectScore == 3)
 77:         {
 78:             run = 6f; // Velocidad máxima al perseguir después de recoger 6 objetos
 79:             walk = 5f; // Velocidad máxima al deambular después de recoger 6 objetos
 80:             roadRate = 30f; // Radio de deambulación máximo después de recoger 6 objetos
 81:             visionRate = 40f; // Radio de visión máximo después de recoger 6 objetos
 82:         }
 83:         if (walkUp == true)
 84:         {
 85:             agente.isStopped = true;
 86:             agente.ResetPath();
 87:         }
 88:     }
 89:     // Función para perseguir al jugador
 90:     void PerseguirJugador() 
 91:     {
 92:         // Si el jugador está en vista y el juego no ha terminado, perseguirlo
 93:         if (walkUp == false && GameOver == false)
 94:         {
 95:             // El NavMesh Agent se encarga de ir hacia el jugador sin chocarse
 96:             agente.SetDestination(jugador.position);
 97:             agente.speed = run; // Opcional: Aumentar velocidad al perseguir
 98:             anim.SetFloat("Runing", 1); // Activa la animación de correr estableciendo el parámetro "Runing" en el Animator a 1
 99:         }
100:     }
101:     // Si el jugador no está en vista o está en la zona segura, deambular
102:     void DeambularAletorio() 
103:     {
104:         agente.speed = walk; // Volver a velocidad normal
105:         anim.SetFloat("Runing", 0); // Desactiva la animación de correr estableciendo el parámetro "Runing" en el Animator a 0
106: 
107:         // Si el agente no tiene un camino pendiente y ha llegado a su destino, elegir un nuevo punto aleatorio para deambular
108:         if (!agente.pathPending && agente.remainingDistance <= agente.stoppingDistance && walkUp == false)
109:         {
110:             // Si el agente no tiene un camino pendiente y ha llegado a su destino, esperar un poco antes de elegir un nuevo punto aleatorio para deambular
111:             cronometro += Time.deltaTime;
112:             // Esperamos un poco antes de ir al siguiente punto
113:             if (cronometro >= tiempoDeEspera && !GameOver)
114:             {
115:                 // Elegir un nuevo punto aleatorio para deambular
116:                 SetNuevoPuntoAleatorio();
117:                 // Reiniciar el cronómetro para la próxima espera
118:                 cronometro = 0;
119:             }
120:         }
121:     }
122: 
123:     // Función auxiliar para calcular un punto aleatorio en el NavMesh
124:     void SetNuevoPuntoAleatorio()
125:     {
126:         // Creamos un círculo imaginario alrededor de la IA
127:         Vector3 puntoAleatorio = Random.insideUnitSphere * roadRate;
128:         // Lo movemos a la posición de la IA para que el círculo esté centrado en ella
129:         puntoAleatorio += transform.position;
130:         // Creamos una variable para almacenar la información del punto más cercano en el NavMesh
131:         NavMeshHit hit;
132:         // Si encontramos un punto válido en el NavMesh dentro del radio de deambulación y el juego no ha terminado, establecemos ese punto como destino para el agente
133:         if (NavMesh.SamplePosition(puntoAleatorio, out hit, roadRate, 1) && !GameOver) 
134:         {
135:             // El NavMesh Agent se encarga de ir hacia el punto aleatorio sin chocarse
136:             agente.SetDestination(hit.position);
137:         }
138:         
139:     }
140:     bool PuedoVerAlJugador()
141:     {
142:         // 1. Calcular dirección y distancia hacia el jugador
143:         Vector3 direccionAlJugador = (jugador.position - transform.position).normalized;
144:         float distanciaAlJugador = Vector3.Distance(transform.position, jugador.position);
145: 
146:         // 2. Verificar si está dentro del rango de visión
147:         if (distanciaAlJugador <= visionRate)
148:         {
149:             // 3. Lanzar un Raycast desde el enemigo hacia el jugador
150:             // Ajustamos la altura de origen (p. ej. transform.position + Vector3.up * 1.5f) para simular los ojos
151:             Vector3 origenOjos = transform.position + Vector3.up * 1.5f;
152:             RaycastHit hit;
153: 
154:             if (Physics.Raycast(origenOjos, direccionAlJugador, out hit, visionRate))
155:             {
156:                 // Comprobar si lo primero que impacta el Raycast es el jugador
157:                 if (hit.transform == jugador || hit.transform.CompareTag("Player"))
158:                 {
159:                     return true; // El enemigo ve al jugador sin obstáculos
160:                 }
161:             }
162:         }
163: 
164:         return false; // El jugador está fuera de rango o cubierto tras un obstáculo
165:     }
166:     // Para ver el radio de visión en escena
167:     void OnDrawGizmosSelected()
168:     {
169:         // Dibujamos un círculo rojo para el radio de visión y un círculo azul para el radio de deambulación
170:         Gizmos.color = Color.red;
171:         Gizmos.DrawWireSphere(transform.position, visionRate);
172: 
173:         Gizmos.color = Color.blue;
174:         Gizmos.DrawWireSphere(transform.position, roadRate);
175: 
176:         // Dibujar línea del Raycast hacia el jugador en tiempo de ejecución (si existe)
177:         if (jugador != null)
178:         {
179:             Vector3 origenOjos = transform.position + Vector3.up * 30f;
180:             Gizmos.color = PuedoVerAlJugador() ? Color.green : Color.red;
181:             Gizmos.DrawLine(origenOjos, jugador.position);
182:         }
183: 
184:     }  
185:     IEnumerator StateAnim() // Cambia a caminar erguido después de 30 segundos
186:     {
187:         yield return new WaitForSeconds(30f); // Espera 30 segundos antes de cambiar a caminar erguido
188:         anim.SetBool("Up", true); // Activa la animación de caminar erguido
189:         anim.SetBool("Walk", true); // Activa la animación de caminar
190:         walkUp = true; // El enemigo empieza a caminar erguido después de 30 segundos
191:         StartCoroutine(StateStop()); // Inicia la corrutina para volver a caminar normal después de 7.5 segundos
192:     }
193:     // Vuelve a caminar normal después de 7.5 segundos
194:     IEnumerator StateStop() 
195:     {
196:         yield return new WaitForSeconds(7.5f); // Espera 7.5 segundos antes de volver a caminar normal
197:         walkUp = false; // El enemigo deja de caminar erguido después de 7.5 segundos
198:     }
199:     // Detecta colisiones con el jugador para activar la animación de muerte y la secuencia de Game Over
200:     public void OnCollisionEnter(Collision collision) 
201:     {
202:         // Si colisiona con el jugador y el juego no ha terminado, se activa la animación de muerte y se inicia la secuencia de Game Over
203:         if (collision.gameObject.CompareTag("Player") && GameOver == false) 
204:         {
205:             anim.SetBool("Dead", true); // Activa la animación de muerte estableciendo el parámetro "Dead" en el Animator a true
206:             GameOver = true; // El juego ha terminado, así que establecemos GameOver a true para evitar que la IA siga actuando
207:             StartCoroutine(DeadTime()); // Inicia la corrutina para esperar 10 segundos antes de cargar la escena de Game Over
208:         }
209:     }
210:     // Espera 10 segundos después de la muerte para cargar la escena de Game Over
211:     IEnumerator DeadTime() 
212:     {
213:         yield return new WaitForSeconds(10f);
214:         SceneManager.LoadScene(1); // Carga la escena de Game Over (asegúrate de que la escena de Game Over esté en el índice 1 en la configuración de escenas)
215:     }
216: }
```

## File: Assets/_Scripts/FriendlyIA.cs
```csharp
 1: using System.Collections;
 2: using System.Collections.Generic;
 3: using UnityEngine;
 4: using UnityEngine.AI;
 5: 
 6: public class FriendlyIA : MonoBehaviour
 7: {
 8:     private NavMeshAgent agent;
 9:     public float tiempodeEspera = 60f; // Tiempo que el NPC esperar� en cada punto de inter�s antes de moverse al siguiente
10:     public float timer = 0f; 
11:     public float speed = 10f;
12:     public float visionRate;
13:     public float wanderRate;
14:     public Vector3[] wayPoints; // Array de puntos de inter�s para que el NPC se mueva entre ellos
15:     public int arrayVector = 0; // Variable para llevar la cuenta del �ndice actual en el array de puntos de inter�s
16:     public bool advance = false; // Variable para controlar si el NPC debe avanzar hacia el siguiente punto de inter�s
17:     public bool tipPlayer = false; // Variable para controlar si el NPC ha dado la pista al jugador
18:     public int hitCount;
19:     void Start()
20:     {
21:         agent = GetComponent<NavMeshAgent>();
22:         HitCountPlayer(0);
23:     }
24: 
25:     void Update()
26:     {
27:         agent.speed = speed;
28:         if(advance == true)
29:         {
30:             timer += Time.deltaTime; // Si el agente ha llegado a su destino, puedes realizar alguna acci�n adicional aqu� si lo deseas
31:             MoveToPoint();
32:         }else advance = false;
33: 
34:         if (hitCount == 3)
35:         {
36:             StartCoroutine(DestroyGuide());
37:         }
38:     }
39:     private void OnCollisionEnter(Collision collision)
40:     {
41:         if (collision.gameObject.CompareTag("Player"))
42:         {
43:             advance = true; // Si el NPC colisiona con el jugador, se activa la variable advance para que el NPC comience a avanzar hacia el siguiente punto de inter�s
44:             if (tipPlayer == false)
45:             {
46:                 arrayVector++; // Incrementa el �ndice del array de puntos de inter�s para que el NPC se dirija al siguiente punto en la pr�xima actualizaci�n
47:                 tipPlayer = true; // Reinicia la variable tipPlayer para que el NPC no d� la pista nuevamente hasta que vuelva a colisionar con el jugador
48:                 timer = 0f;
49:                 HitCountPlayer(1); // Incrementa el contador de colisiones con el jugador para llevar la cuenta de cu�ntas veces el NPC ha dado la pista al jugador
50:             }
51:             else if(tipPlayer == true)
52:             {
53:                 StartCoroutine(WaitsecondsToken()); // Si el NPC ya ha dado la pista al jugador, se inicia una corrutina para esperar un tiempo antes de permitir que el NPC d� la pista nuevamente
54:             }
55:         }
56:     }
57:     public void MoveToPoint()
58:     {
59:         if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
60:         {
61:             if (advance == false) return;
62:             
63:             agent.SetDestination(wayPoints[arrayVector]);
64:             if (timer >= tiempodeEspera)
65:             {
66:                 agent.SetDestination(wayPoints[0]);
67:                 arrayVector = 0;
68:                 timer = 0f;
69:             }
70:         }
71:     }
72:     public void HitCountPlayer(int add)
73:     {
74:         hitCount += add;
75:     }
76:     IEnumerator WaitsecondsToken()
77:     {
78:         yield return new WaitForSeconds(10f);
79:         tipPlayer = false;
80:     }
81:     IEnumerator DestroyGuide()
82:     {
83:         yield return new WaitForSeconds(10f);
84:         Destroy(gameObject);
85:     }
86:     void OnDrawGizmosSelected()
87:     {
88:         Gizmos.color = Color.yellow;
89:         Gizmos.DrawWireSphere(transform.position, visionRate);
90: 
91:         Gizmos.color = Color.red;
92:         Gizmos.DrawWireSphere(transform.position, wanderRate);
93:     }
94: }
```

## File: Assets/_Scripts/GameManager.cs
```csharp
  1: using System.Collections;
  2: using System.Collections.Generic;
  3: using TMPro;
  4: using UnityEngine;
  5: using UnityEngine.InputSystem;
  6: using UnityEngine.SceneManagement;
  7: 
  8: public class GameManager : MonoBehaviour
  9: {
 10:     public int sceneChange; // Variable para cambiar la escena del juego desde el inspector
 11:     public bool menuOff = false; // Variable para controlar el estado del menú de pausa
 12:     public bool prefab1; // Variable para controlar si el prefab del enemigo se ha instanciado al recoger 3 objetos
 13:     public bool prefab2;
 14:     public TextMeshProUGUI count; // Referencia al texto que muestra el contador de objetos recogidos
 15:     public GameObject countOut; // Referencia al objeto que contiene el texto del contador para activarlo o desactivarlo
 16:     public GameObject pause; // Referencia al menú de pausa
 17:     public GameObject next; // Referencia al objeto que se desactivará al recoger los 6 objetos
 18:     public GameObject options; // Referencia al menú de opciones 
 19:     public GameObject menu; // Referencia al menú principal para desactivarlo al entrar en opciones
 20:     public GameObject score; // Referencia al prefab del objeto que se recogerá para sumar puntos
 21:     public GameObject enemy; // Referencia al prefab del enemigo para instanciarlo en la escena
 22:     public Vector3[] vectors3; // Array de posiciones para instanciar los objetos de puntuación
 23:     public Light lightF; // Referencia a la luz que se encenderá y apagará con la tecla L
 24:     public int objectScore; // Variable para llevar la cuenta de los objetos recogidos
 25:     void Start()
 26:     {
 27:         UpdateScore(0); // Inicializamos el contador de objetos recogidos a 0
 28:         if (vectors3.Length >= 3) // Verificamos que hay al menos 6 posiciones disponibles para instanciar los objetos
 29:         {
 30:             InstansObjects(); // Llamamos al método para instanciar los objetos de puntuación en posiciones aleatorias
 31:         }
 32:     }
 33: 
 34:     // Update is called once per frame
 35:     void Update()
 36:     {
 37:         if (count != null)
 38:         {
 39:             count.text = "Score: " + objectScore.ToString("0"); // Actualizamos el texto del contador de objetos recogidos con el valor actual del contador
 40:         }
 41:         if (next != null)
 42:         {
 43:             if (objectScore == 3 && next.transform.rotation.x == 4.69f) // Si se han recogido los 6 objetos y el objeto next está en la posición de la puerta, se desactiva el objeto next para permitir el paso
 44:             {
 45:                 next.SetActive(false); // Desactivamos el objeto next para permitir el paso
 46:             }
 47:         }
 48:         if (objectScore == 3 && prefab1 == false)
 49:         {
 50:             Instantiate(enemy, new Vector3(25.727f, 0f, 14.237f), Quaternion.Euler(0, 0, 0)); // Instanciamos el prefab del enemigo en la posición del prefab con una rotación sin cambios
 51:             prefab1 = true;
 52:         }
 53:         if (objectScore == 3 && prefab2 == false)
 54:         {
 55:             Instantiate(enemy, new Vector3(-13.76f, 0f, 2.045f), Quaternion.Euler(0, 0, 0)); // Instanciamos el prefab del enemigo en la posición del prefab con una rotación sin cambios
 56:             prefab2 = true;
 57:         }
 58:         MenuPause(); // Llamamos al método para controlar el menú de pausa
 59:     }
 60:     public void UpdateScore(int add) // Método para actualizar el contador de objetos recogidos, se le pasa un valor que se suma al contador actual
 61:     {
 62:         objectScore += add; // Sumamos el valor pasado al contador de objetos recogidos
 63:     }
 64:     public void OnLight(InputValue value) // Método para controlar la luz con la tecla L, se llama automáticamente al presionar la tecla asignada en el Input System
 65:     {
 66:         if (value.isPressed) // Si la tecla está presionada, se cambia el estado de la luz (encendida o apagada)
 67:             lightF.enabled = !lightF.enabled; // Cambiamos el estado de la luz utilizando el operador lógico NOT para alternar entre encendida y apagada
 68:     }
 69:     void InstansObjects()
 70:     {
 71: 
 72:         List<Vector3> listaTemporal = new List<Vector3>(vectors3); // Creamos una lista temporal a partir del array de posiciones para poder barajarla
 73: 
 74: 
 75:         for (int i = 0; i < listaTemporal.Count; i++) // Recorremos la lista temporal para barajarla utilizando el algoritmo de Fisher-Yates
 76:         {
 77:             Vector3 temp = listaTemporal[i]; // Guardamos el elemento actual en una variable temporal
 78:             int randomIndex = Random.Range(i, listaTemporal.Count); // Generamos un índice aleatorio entre el índice actual y el final de la lista
 79:             listaTemporal[i] = listaTemporal[randomIndex]; // Asignamos el elemento del índice aleatorio al índice actual
 80:             listaTemporal[randomIndex] = temp; // Asignamos el elemento guardado en la variable temporal al índice aleatorio, completando el intercambio de elementos
 81:         }
 82: 
 83:         for (int i = 0; i < 3; i++) // Recorremos las primeras 3 posiciones de la lista temporal (que ahora está barajada) para instanciar los objetos de puntuación en esas posiciones
 84:         {
 85:             Instantiate(score, listaTemporal[i], Quaternion.Euler(90, 0, 0)); // Instanciamos el prefab del objeto de puntuación en la posición correspondiente de la lista temporal, con una rotación de 90 grados en el eje X para que quede orientado hacia arriba
 86:         }
 87:     }
 88:     public void MenuPause() //Metodo menu de pausa
 89:     {
 90:         if (Input.GetKeyDown(KeyCode.P) && !menuOff) //Condición tecla menu de apusa
 91:         {
 92:             Cursor.lockState = CursorLockMode.None; // desbloqueamos el cursor
 93:             Cursor.visible = true; // hacemos visible el cursor
 94:             Time.timeScale = 0; // pausamos el tiempo del juego
 95:             pause.SetActive(true); // activamos el menú de pausa
 96:         }
 97:         if (Input.GetKeyDown(KeyCode.Escape))
 98:         {
 99:             Cursor.lockState = CursorLockMode.Locked; // bloqueamos el cursor
100:             Cursor.visible = false; // hacemos invisible el cursor
101:             Time.timeScale = 1; // reanudamos el tiempo del juego
102:             pause.SetActive(false); // desactivamos el menú de pausa
103:         }
104:     }
105:     public void Continue() // Metodo para continuar el juego
106:     {
107:         Cursor.lockState = CursorLockMode.Locked; // bloqueamos el cursor
108:         Cursor.visible = false; // hacemos invisible el cursor
109:         Time.timeScale = 1; // reanudamos el tiempo del juego
110:         pause.SetActive(false); // desactivamos el menú de pausa
111:     }
112:     public void PlayGame() // Metodo para iniciar el juego
113:     {
114:         SceneManager.LoadScene(sceneChange); // Cargamos la escena del juego con una variable para cambiarla desde el inspector
115:     }
116:     public void Options() // Metodo para ir a las opciones
117:     {
118:         options.SetActive(true); // activamos el menú de opciones
119:         menu.SetActive(false); // desactivamos el menú principal
120:     }
121:     public void Back() // Metodo para volver al menu de pausa o principal dependiendo la escena
122:     {
123:         options.SetActive(false); // desactivamos el menú de opciones
124:         menu.SetActive(true); // activamos el menú principal
125:     }
126:     public void ExitGame() // Metodo para salir del juego
127:     {
128:         Application.Quit(); // Salimos del juego
129:     }
130: }
```

## File: Assets/_Scripts/PlayerController.cs
```csharp
  1: using System.Collections;
  2: using System.Collections.Generic;
  3: using UnityEngine;
  4: using UnityEngine.InputSystem;
  5: using UnityEngine.SceneManagement;
  6: 
  7: public class PlayerController : MonoBehaviour
  8: {
  9:     public float suavizadoAnimacion = 0.1f; // Variable para controlar la suavización de las animaciones,
 10:     public float speed = 3.5f; // Variable para controlar la velocidad de movimiento del jugador, que se puede ajustar en el Inspector de Unity para encontrar la velocidad que mejor se adapte al juego
 11:     public float velocidad = 0.0f; // Variable para almacenar la velocidad actual del jugador, que se actualizará en función del input de movimiento y se utilizará para controlar las animaciones de movimiento (caminando o corriendo) en el Animator
 12:     private float velocidadSmooth;// Variable para almacenar la velocidad suavizada del jugador, que se calculará utilizando Mathf.MoveTowards para crear transiciones suaves entre las animaciones de movimiento en el Animator
 13:     public bool GameOver = false;// Variable para indicar si el juego ha terminado, lo que puede afectar la lógica del movimiento, las animaciones y las interacciones del jugador con el entorno, como desactivar el movimiento o mostrar una pantalla de Game Over
 14:     public bool safeZone = false;// Variable para indicar si el jugador está en una zona segura, lo que puede afectar la lógica del juego relacionada con la seguridad del jugador y la interacción con enemigos o eventos peligrosos
 15:     public GameManager gameManager;// Variable para almacenar una referencia al GameManager en la escena, lo que nos permitirá acceder a la puntuación del jugador y otras variables relacionadas con la lógica del juego para controlar el flujo del juego en función de la puntuación y el estado del juego
 16:     private Vector2 inputMove; //Variable para almacenar el input de movimiento del jugador, que se actualizará en función de las entradas del jugador (como WASD o el joystick) y se utilizará para calcular la dirección y la velocidad del movimiento del jugador en el método Move
 17:     Rigidbody rb; // Variable para almacenar una referencia al componente Rigidbody del jugador, lo que nos permitirá controlar el movimiento del jugador aplicando fuerzas o estableciendo la velocidad del Rigidbody en el método Move
 18:     Animator anim;// Variable para almacenar una referencia al componente Animator del jugador, lo que nos permitirá controlar las animaciones del jugador estableciendo parámetros en el Animator en el método Animations y otras partes del código para activar animaciones específicas como caminar, correr, atacar o morir
 19:     void Awake()
 20:     {
 21:         // En el método Awake, obtenemos referencias a los componentes Animator y Rigidbody del jugador, así como al GameManager en la escena, lo que nos permitirá controlar las animaciones, el movimiento y la lógica del juego en función de la puntuación y el estado del juego
 22:         anim = GetComponent<Animator>();
 23:         rb = GetComponent<Rigidbody>();
 24:         gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
 25:     }
 26:     void Update()
 27:     {
 28:         // Llamamos al método Move para controlar el movimiento del jugador y al método Animations para controlar las animaciones del jugador en cada frame, siempre y cuando el juego no haya terminado
 29:         Move();
 30:         // Llamamos al método Animations para controlar las animaciones del jugador en cada frame, verificando si se presiona la tecla de ataque y actualizando los parámetros del Animator en función del input de movimiento y la velocidad actual del jugador, siempre y cuando el juego no haya terminado
 31:         Animations();
 32:     }
 33:     // Método que se llama cuando se recibe una entrada de movimiento, actualizando el vector de inputMove con el valor del input de movimiento recibido
 34:     public void OnMove(InputValue value) 
 35:     {
 36:         // Actualizamos el vector de inputMove con el valor del input de movimiento recibido, que es un Vector2 que representa la dirección del movimiento en los ejes horizontal (x) y vertical (y)
 37:         inputMove = value.Get<Vector2>(); 
 38:     }
 39:     // Método que se llama cuando se recibe una entrada de sprint, actualizando la velocidad del jugador en función de si el botón de sprint está presionado o no
 40:     public void OnSprint(InputValue value) 
 41:     {
 42:         // Si el botón de sprint está presionado y el juego no ha terminado, aumentamos la velocidad del jugador a 7f para permitir que corra
 43:         if (value.isPressed && GameOver == false) 
 44:             speed = 7f; // Aumentamos la velocidad del jugador a 7f para permitir que corra
 45:         // Si el botón de sprint no está presionado, restablecemos la velocidad del jugador a 3.5f para que camine a una velocidad normal
 46:         else speed = 3.5f;  
 47:     }
 48:     // Método que se llama para mover al jugador, calculando la dirección deseada en función del input de movimiento y estableciendo la velocidad del Rigidbody en consecuencia, siempre y cuando el juego no haya terminado
 49:     public void Move()
 50:     {
 51:         // Si el juego no ha terminado, calculamos la dirección deseada en función del input de movimiento y establecemos la velocidad del Rigidbody para mover al jugador en consecuencia, manteniendo la componente vertical de la velocidad para permitir el salto o la gravedad
 52:         if (GameOver == false)
 53:         {
 54:             // Calculamos la dirección deseada en función del input de movimiento, utilizando el eje forward para el movimiento hacia adelante/atrás y el eje right para el movimiento lateral
 55:             Vector3 direccionDeseada = (transform.forward * inputMove.y) + (transform.right * inputMove.x);
 56:             // Si la magnitud de la dirección deseada es mayor que 1, normalizamos el vector para evitar que el jugador se mueva más rápido en diagonal
 57:             if (direccionDeseada.magnitude > 1)
 58:             {
 59:                 // Normalizamos el vector de dirección deseada para mantener una velocidad constante en todas las direcciones, evitando que el jugador se mueva más rápido en diagonal
 60:                 direccionDeseada.Normalize();
 61:             }
 62:             // Establecemos la velocidad del Rigidbody en función de la dirección deseada multiplicada por la velocidad actual, manteniendo la componente vertical de la velocidad para permitir el salto o la gravedad
 63:             rb.velocity = new Vector3(direccionDeseada.x * speed, rb.velocity.y, direccionDeseada.z * speed);
 64:         }
 65:     }
 66:     // Método que se llama para controlar las animaciones del jugador, verificando si se presiona la tecla de ataque y actualizando los parámetros del Animator en función del input de movimiento y la velocidad actual del jugador, siempre y cuando el juego no haya terminado
 67:     public void Animations()
 68:     {
 69:         // Si se presiona la tecla F y el juego no ha terminado
 70:         if (Input.GetKeyDown(KeyCode.F) && GameOver == false)
 71:         {
 72:             // Activamos la animación de linterna estableciendo el parámetro "Light" en el Animator a true
 73:             anim.SetBool("Light", true);
 74:         }
 75:         // Si la tecla F no está presionada, desactivamos la animación de linterna estableciendo el parámetro "Light" en el Animator a false
 76:         else anim.SetBool("Light", false);
 77:         // Calculamos el objetivo de velocidad para la animación en función de la magnitud del input de movimiento y la relación entre la velocidad actual y la velocidad máxima (7f es la velocidad máxima de sprint)
 78:         float objetivo = inputMove.magnitude * (speed / 7f);
 79:         // Suavizamos la transición de la velocidad de la animación utilizando Mathf.MoveTowards
 80:         velocidadSmooth = Mathf.MoveTowards(velocidadSmooth, objetivo, Time.deltaTime * 3f);
 81:         // Establecemos el parámetro "Velocidad" en el Animator con la velocidad suavizada para controlar las animaciones de movimiento (caminando o corriendo) en función de la velocidad actual del jugador
 82:         anim.SetFloat("Velocidad", velocidadSmooth);
 83:     }
 84:     // Método que se llama cuando el jugador colisiona con otro objeto, verificando si el objeto colisionado es una zona segura, un enemigo o el final del nivel, y actuando en consecuencia
 85:     private void OnCollisionEnter(Collision collision)
 86:     {
 87:         // Si el jugador colisiona con una zona segura y el juego no ha terminado, se establece safeZone en true para indicar que el jugador está en una zona segura
 88:         if (collision.collider.CompareTag("SafeZone") && GameOver == false)
 89:             safeZone = true;
 90:         // Si el jugador colisiona con un enemigo y el juego no ha terminado, se activa la animación de muerte y se establece GameOver en true para indicar que el juego ha terminado
 91:         if (collision.collider.CompareTag("Enemy") && GameOver == false)
 92:         {
 93:             // Activa la animación de muerte estableciendo el parámetro "Dead" en el Animator a true, lo que hará que el jugador muera visualmente en el juego
 94:             anim.SetBool("Dead", true);
 95:             // Establece GameOver en true para indicar que el juego ha terminado, lo que puede desactivar otras funcionalidades del jugador y mostrar una pantalla de Game Over o reiniciar el nivel
 96:             GameOver = true;
 97:         }
 98: 
 99:         // Si el jugador colisiona con el objeto final del nivel y el juego no ha terminado, se verifica si el jugador ha alcanzado la puntuación necesaria para completar el nivel (en este caso, 3 objetos recogidos), y si es así, se carga la escena principal (índice 0) y se desbloquea el cursor para permitir que el jugador interactúe con el menú o la interfaz de usuario después de completar el nivel
100:         if (collision.collider.CompareTag("End") && GameOver == false)
101:         {
102:             // Verificamos si el jugador ha alcanzado la puntuación necesaria para completar el nivel (3 objetos o más recogidos)
103:             if (gameManager.objectScore >= 3)
104:             {
105:                 Time.timeScale = 1f;
106:                 // Desbloqueamos el cursor para permitir que el jugador interactúe con el menú o la interfaz de usuario después de completar el nivel
107:                 Cursor.lockState = CursorLockMode.None;
108:                 Cursor.visible = true;
109:                 // Cargamos la escena principal (índice 0) después de completar el nivel
110:                 SceneManager.LoadScene(0);
111:             }
112:         }
113:     }
114: 
115:     // Respaldo de seguridad para cuando el objeto final del nivel es un Trigger
116:     private void OnTriggerEnter(Collider other)
117:     {
118:         if (other.CompareTag("End") && GameOver == false && gameManager.objectScore >= 3)
119:         {
120:             Time.timeScale = 1f;
121:             Cursor.lockState = CursorLockMode.None;
122:             Cursor.visible = true;
123:         }
124:     }
125:     // Método que se llama cuando el jugador deja de colisionar con otro objeto, verificando si el objeto dejado de colisionar es una zona segura, y si es así, se establece safeZone en false para indicar que el jugador ya no está en una zona segura
126:     private void OnCollisionExit(Collision collision) 
127:     {
128:         // Si el jugador deja de colisionar con una zona segura y el juego no ha terminado, se establece safeZone en false para indicar que el jugador ya no está en una zona segura, lo que puede afectar la lógica del juego relacionada con la seguridad del jugador y la interacción con enemigos o eventos peligrosos
129:         if (collision.collider.CompareTag("SafeZone") && GameOver == false) 
130:             safeZone = false;
131:     }
132: }
```

## File: Packages/manifest.json
```json
 1: {
 2:   "dependencies": {
 3:     "com.gamebooom.unity.mcp": "https://github.com/FunplayAI/funplay-unity-mcp.git#v0.7.6",
 4:     "com.unity.ai.navigation": "1.1.7",
 5:     "com.unity.collab-proxy": "2.12.4",
 6:     "com.unity.feature.development": "1.0.1",
 7:     "com.unity.inputsystem": "1.14.2",
 8:     "com.unity.terrain-tools": "5.0.6",
 9:     "com.unity.textmeshpro": "3.0.7",
10:     "com.unity.timeline": "1.7.7",
11:     "com.unity.ugui": "1.0.0",
12:     "com.unity.visualscripting": "1.9.4",
13:     "com.unity.modules.ai": "1.0.0",
14:     "com.unity.modules.androidjni": "1.0.0",
15:     "com.unity.modules.animation": "1.0.0",
16:     "com.unity.modules.assetbundle": "1.0.0",
17:     "com.unity.modules.audio": "1.0.0",
18:     "com.unity.modules.cloth": "1.0.0",
19:     "com.unity.modules.director": "1.0.0",
20:     "com.unity.modules.imageconversion": "1.0.0",
21:     "com.unity.modules.imgui": "1.0.0",
22:     "com.unity.modules.jsonserialize": "1.0.0",
23:     "com.unity.modules.particlesystem": "1.0.0",
24:     "com.unity.modules.physics": "1.0.0",
25:     "com.unity.modules.physics2d": "1.0.0",
26:     "com.unity.modules.screencapture": "1.0.0",
27:     "com.unity.modules.terrain": "1.0.0",
28:     "com.unity.modules.terrainphysics": "1.0.0",
29:     "com.unity.modules.tilemap": "1.0.0",
30:     "com.unity.modules.ui": "1.0.0",
31:     "com.unity.modules.uielements": "1.0.0",
32:     "com.unity.modules.umbra": "1.0.0",
33:     "com.unity.modules.unityanalytics": "1.0.0",
34:     "com.unity.modules.unitywebrequest": "1.0.0",
35:     "com.unity.modules.unitywebrequestassetbundle": "1.0.0",
36:     "com.unity.modules.unitywebrequestaudio": "1.0.0",
37:     "com.unity.modules.unitywebrequesttexture": "1.0.0",
38:     "com.unity.modules.unitywebrequestwww": "1.0.0",
39:     "com.unity.modules.vehicles": "1.0.0",
40:     "com.unity.modules.video": "1.0.0",
41:     "com.unity.modules.vr": "1.0.0",
42:     "com.unity.modules.wind": "1.0.0",
43:     "com.unity.modules.xr": "1.0.0"
44:   }
45: }
```

## File: ProjectSettings/EditorBuildSettings.asset
```
 1: %YAML 1.1
 2: %TAG !u! tag:unity3d.com,2011:
 3: --- !u!1045 &1
 4: EditorBuildSettings:
 5:   m_ObjectHideFlags: 0
 6:   serializedVersion: 2
 7:   m_Scenes:
 8:   - enabled: 1
 9:     path: "Assets/_Scenes/MainMen\xFA.unity"
10:     guid: c627cea114de3d44dbc3bd74b84ba447
11:   - enabled: 1
12:     path: Assets/_Scenes/Lvl 1.unity
13:     guid: c4bcf0bff750de541af0dd86b086c932
14:   - enabled: 1
15:     path: Assets/_Scenes/Lvl 2.unity
16:     guid: 8004bc85b3cebc44e9fa67c6306332ae
17:   m_configObjects: {}
```
