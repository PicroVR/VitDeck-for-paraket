// 当ファイルは Assets/VitDeck/Validator/Rules/Vket/VketRuleSetBase.cs、および ConceptWorldRuleSet.cs をコピーして改変したもの

using System;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using VitDeck.Language;

#if VRC_SDK_VRCSDK3
using VRC.SDKBase;
#elif VRC_SDK_VRCSDK2
using VRCSDK2;
#endif

namespace VitDeck.Validator
{
    /// <summary>
    /// パラレルマーケットのルールセット。
    /// </summary>
    public class ParaketRuleSet : IRuleSet
    {
        public string RuleSetName => "パラレルマーケット";

        private readonly VketTargetFinder targetFinder = new VketTargetFinder();
        public IValidationTargetFinder TargetFinder => targetFinder;

        public IRule[] GetRules()
        {
            // デフォルトで使っていたAttribute式は宣言時にconst以外のメンバーが利用できない。
            // 継承したプロパティを参照して挙動を変えることが出来ない為、直接リストを返す方式に変更した。
            return new IRule[]
            {
#if VRC_SDK_VRCSDK2
                ////////////////////////////////////////////////////////////////
                ////                         A.環境                         ////
                ////////////////////////////////////////////////////////////////
                // A-1 バージョン制限
                new UnityVersionRule(LocalizedMessage.Get("VketRuleSetBase.UnityVersionRule.Title", "2018.4.20f1"), "2018.4.20f1"),
                // A-2 SDKバージョン制限
                new VRCSDKVersionRule(
                    LocalizedMessage.Get("VketRuleSetBase.VRCSDKVersionRule.Title"),
                    new VRCSDKVersion("2021.06.03.14.57"),
                    "https://vrchat.com/home/download"
                ),
                // A-3 VitDeckバージョン制限
                new VitDeckVersionRule("VitDeckバージョンルール"),
                
                ////////////////////////////////////////////////////////////////
                ////                      B.入稿データ                      ////
                ////////////////////////////////////////////////////////////////
                // B-1 入稿データチェック
                new BaseFolderPathRule(
                    "ベースフォルダパスルール",
                    new Regex("^Assets/[1-9][0-9]{2}$"),
                    "Base Folderは、入稿ツールによってAssets直下へ作成された、半角数字3桁のサークルIDのフォルダです。なお、サークルIDは、右のHelpボタンから飛べるスプレッドシートで確認できます。",
                    "https://docs.google.com/spreadsheets/d/1mFXJrAYP7mjRsacWKFE9j7ROtOYfPWMIP98rzsyIX7E/htmlview"
                ),
                // (公式プレハブ等を除き、入稿フォルダ外を参照していないことの確認)
                new ExistInSubmitFolderRule(LocalizedMessage.Get("VketRuleSetBase.ExistInSubmitFolderRule.Title"), ParaketOfficialAssetData.GUIDs, targetFinder),
                // (公式プレハブ等を入稿データに入れない)
                new AssetGuidBlacklistRule(LocalizedMessage.Get("VketRuleSetBase.OfficialAssetDontContainRule.Title"), ParaketOfficialAssetData.GUIDs),
                // B-2 Unitypackageの容量制限
                new FolderSizeRule(LocalizedMessage.Get("VketRuleSetBase.FolderSizeRule.Title"), (long)(50 * Math.Pow(2, 20))), // 50MiB
                // B-3 命名規則
                new AssetNamingRule(LocalizedMessage.Get("VketRuleSetBase.NameOfFileAndFolderRule.Title"), @"[a-zA-Z0-9 _.()-]+"),
                // B-4 拡張子制限
                new AllowedExtensionsForExportRule(
                    LocalizedMessage.Get("AllowedExtensionsForExportRule.Title"),
                    Exporter.Exporter.GetExportSettings().First(setting => setting.name == "ParaketExportSetting")
                ),
                // B-5 MaterialとTextureの検証
                new ContainMatOrTexInAssetRule(LocalizedMessage.Get("VketRuleSetBase.ContainMatOrTexInAssetRule.Title")),
                
                ////////////////////////////////////////////////////////////////
                ////                      C.ブース形状                      ////
                ////////////////////////////////////////////////////////////////
                // C-1 ブースの大きさ
                new BoothBoundsRule(
                    LocalizedMessage.Get("VketRuleSetBase.BoothBoundsRule.Title"),
                    size: new Vector3(4, 5, 4),
                    margin: 0.01f
                ),
                
                ////////////////////////////////////////////////////////////////
                ////                    D.パフォーマンス                    ////
                ////////////////////////////////////////////////////////////////
                // D-1 Material数制限
                new AssetTypeLimitRule(
                    LocalizedMessage.Get("VketRuleSetBase.MaterialLimitRule.Title", 20),
                    typeof(Material),
                    limit: 20,
                    ParaketOfficialAssetData.GUIDs
                ),
                // D-5 ライトマップ制限
                new LightmapSizeLimitRule(
                    LocalizedMessage.Get("VketRuleSetBase.LightMapsLimitRule.Title", 1, 512),
                    lightmapCountLimit: 1,
                    lightmapResolutionLimit: 512
                ),
                
                ////////////////////////////////////////////////////////////////
                ////                      E.シェーダー                      ////
                ////////////////////////////////////////////////////////////////
                // E-1 StandardシェーダでEmissionを使用する場合、Global IlluminationはBakedを設定しない
                new GlobalIlluminationBakedRule(LocalizedMessage.Get("VketRuleSetBase.GlobalIlluminationBakedRule.Title")),
                
                ////////////////////////////////////////////////////////////////
                ////                      F.Scene階層                       ////
                ////////////////////////////////////////////////////////////////
                // 階層
                new ExhibitStructureRule(LocalizedMessage.Get("VketRuleSetBase.ExhibitStructureRule.Title")),
                // サークルID、Reference Object以外のオブジェクトをルートに置かない
                new SceneStructureRule("シーン構造ルール"),
                // Staticフラグの管理
                new StaticFlagRule(LocalizedMessage.Get("VketRuleSetBase.StaticFlagsRule.Title")),
                
                ////////////////////////////////////////////////////////////////
                ////                        G.ライト                        ////
                ////////////////////////////////////////////////////////////////
                // Directionalライトの禁止
                new LightCountLimitRule(LocalizedMessage.Get("VketRuleSetBase.DirectionalLightLimitRule.Title"), LightType.Directional, limit: 0),
                // Point
                new LightConfigRule(
                    LocalizedMessage.Get("VketRuleSetBase.PointLightConfigRule.Title"),
                    LightType.Point,
                    new LightConfigRule.LightConfig(
                        new[] { LightmapBakeType.Baked },
                        new[] { LightShadows.Hard, LightShadows.Soft },
                        0, 7,
                        0, 10,
                        0, 15
                    )
                ),
                // Spot
                new LightConfigRule(
                    LocalizedMessage.Get("VketRuleSetBase.SpotLightConfigRule.Title"),
                    LightType.Spot,
                    new LightConfigRule.LightConfig(
                        new[] { LightmapBakeType.Baked },
                        new[] { LightShadows.Hard, LightShadows.Soft },
                        0, 7,
                        0, 10,
                        0, 15
                    )
                ),
                // Area
                new LightConfigRule(
                    LocalizedMessage.Get("VketRuleSetBase.AreaLightConfigRule.Title"),
                    LightType.Area, new LightConfigRule.LightConfig(
                        new[] { LightmapBakeType.Baked },
                        null,
                        0, 30,
                        0, 10,
                        0, 15
                    )
                ),
                // Area 個数制限
                new LightCountLimitRule(
                    LocalizedMessage.Get("VketRuleSetBase.AreaLightLimitRule.Title", 3),
                    LightType.Area,
                    limit: 3
                ),
                // ReflectionProbeの設定
                new ReflectionProbeRule(LocalizedMessage.Get("VketRuleSetBase.ReflectionProbeRule.Title")),
                
                ////////////////////////////////////////////////////////////////
                ////                   H.使用可能Component                  ////
                ////////////////////////////////////////////////////////////////
                // 使用可能Component 後述
                new UsableComponentListRule(
                    LocalizedMessage.Get("VketRuleSetBase.UsableComponentListRule.Title"),
                    GetComponentReferences(),
                    ignorePrefabGUIDs: ParaketOfficialAssetData.OfficialPrefabs,
                    unregisteredComponent: ValidationLevel.DISALLOW
                ),
                // AvatarPedestal - 制限
                new AvatarPedestalPrefabRule(LocalizedMessage.Get("VketRuleSetBase.AvatarPedestalPrefabRule.Title"), ParaketOfficialAssetData.AvatarPedestalPrefabGUIDs),
                // VRC_Pickup - 個数制限
                new PrefabLimitRule(
                    LocalizedMessage.Get("VketRuleSetBase.PickupObjectSyncPrefabLimitRule.Title", 5),
                    ParaketOfficialAssetData.PickupObjectSyncPrefabGUIDs,
                    limit: 5
                ),
                // VRC_Pickup - PickupObjectSyncRuleの制限
                new PickupObjectSyncPrefabRule(LocalizedMessage.Get("VketRuleSetBase.PickupObjectSyncRule.Title"), ParaketOfficialAssetData.PickupObjectSyncPrefabGUIDs),
                // VRC_Trigger - 個数制限
                new VRCTriggerCountLimitRule(LocalizedMessage.Get("VketRuleSetBase.VRCTriggerCountLimitRule.Title", 25), 25),
                // VRC_Trigger - 制限
                new VRCTriggerConfigRule(
                    LocalizedMessage.Get("VketRuleSetBase.VRCTriggerConfigRule.Title"),
                    new[]
                    {
                        VRC_EventHandler.VrcBroadcastType.Local,
                    },
                    new[]
                    {
                        VRC_Trigger.TriggerType.Custom,
                        VRC_Trigger.TriggerType.OnInteract,
                        VRC_Trigger.TriggerType.OnEnterTrigger,
                        VRC_Trigger.TriggerType.OnExitTrigger,
                        VRC_Trigger.TriggerType.OnPickup,
                        VRC_Trigger.TriggerType.OnDrop,
                        VRC_Trigger.TriggerType.OnPickupUseDown,
                        VRC_Trigger.TriggerType.OnPickupUseUp,
                    },
                    new[]
                    {
                        VRC_EventHandler.VrcEventType.AnimationBool,
                        VRC_EventHandler.VrcEventType.AnimationFloat,
                        VRC_EventHandler.VrcEventType.AnimationInt,
                        VRC_EventHandler.VrcEventType.AnimationIntAdd,
                        VRC_EventHandler.VrcEventType.AnimationIntDivide,
                        VRC_EventHandler.VrcEventType.AnimationIntMultiply,
                        VRC_EventHandler.VrcEventType.AnimationIntSubtract,
                        VRC_EventHandler.VrcEventType.AnimationTrigger,
                        VRC_EventHandler.VrcEventType.ActivateCustomTrigger,
                        VRC_EventHandler.VrcEventType.AudioTrigger,
                        VRC_EventHandler.VrcEventType.PlayAnimation,
                        VRC_EventHandler.VrcEventType.SetComponentActive,
                        VRC_EventHandler.VrcEventType.SetGameObjectActive,
                        VRC_EventHandler.VrcEventType.SetParticlePlaying,
                    },
                    excludedAssetGUIDs: ParaketOfficialAssetData.OfficialPrefabs
                ),
                // Animator / Animation - 個数制限
                new AnimatorComponentMaxCountRule(LocalizedMessage.Get("VketRuleSetBase.AnimatorComponentMaxCountRule.Title"), limit: 50),
                // Animator Animation - Material変更制限 Path制限
                new AnimationClipRule(LocalizedMessage.Get("VketRuleSetBase.AnimationClipRule.Title")),
                // Animator / Animation - Alwaysの禁止
                new AnimationComponentRule(
                    LocalizedMessage.Get("VketRuleSetBase.AnimationComponentRule.Title"),
                    ignoredPrefabDetector: new PrefabPartsDetector(ParaketOfficialAssetData.OfficialPrefabs)
                ),
                // Animator / Animation - コライダーを動かす場合はRigidbodyを付加する
                new AnimationMakesMoveCollidersRule(LocalizedMessage.Get("VketRuleSetBase.AnimationMakesMoveCollidersRule.Title")),
                // Animator / Animation - VRC_Pickup、VRC_ObjectSyncとAnimatorの併用は禁止
                new AnimatorComponentRule(LocalizedMessage.Get("VketRuleSetBase.AnimatorComponentRule.Title"),
                    mustUseSeparatelyComponents: new[]
                    {
                        typeof(VRC_Pickup),
                        typeof(VRC_ObjectSync),
                    },
                    ignoredPrefabDetector: new PrefabPartsDetector(ParaketOfficialAssetData.OfficialPrefabs)
                ),
                // SkinnedMeshRenderer - Update When Offscreenはオフ
                new SkinnedMeshRendererRule(LocalizedMessage.Get("VketRuleSetBase.SkinnedMeshRendererRule.Title")),
                // SkinnedMeshRenderer / MeshRenderer - マテリアル1以上
                new SkinnedMeshRendererRule(LocalizedMessage.Get("VketRuleSetBase.RendererRule.Title")),
                // Rigidbody
                new RigidbodyRule(LocalizedMessage.Get("VketRuleSetBase.RigidbodyRule.Title")),
                // Canvas - RenderModeはWorldSpaceのみ
                new CanvasRenderModeRule(LocalizedMessage.Get("VketRuleSetBase.CanvasRenderModeRule.Title")),
                // VRC_Chair - 個数制限
                new PrefabLimitRule(
                    LocalizedMessage.Get("VketRuleSetBase.ChairPrefabLimitRule.Title", 1),
                    ParaketOfficialAssetData.ChairPrefabGUIDs,
                    limit: 1
                ),
                // AudioSource - 制限
                new AudioSourcePrefabRule(LocalizedMessage.Get("VketRuleSetBase.AudioSourcePrefabRule.Title"), ParaketOfficialAssetData.AudioSourcePrefabGUIDs),
#endif
            };
        }

        //使用可能Component
        private ComponentReference[] GetComponentReferences()
        {
            return new[] {
                new ComponentReference("Light", new string[]{"UnityEngine.Light"}, ValidationLevel.ALLOW),
                new ComponentReference("LightProbeGroup", new string[]{"UnityEngine.LightProbeGroup"}, ValidationLevel.ALLOW),
                new ComponentReference("ReflectionProbe", new string[]{"UnityEngine.ReflectionProbe"}, ValidationLevel.ALLOW),
                new ComponentReference("VRC_Trigger", new string[]{"VRCSDK2.VRC_Trigger", "VRCSDK2.VRC_EventHandler"}, ValidationLevel.ALLOW),
                new ComponentReference("Animator", new string[]{"UnityEngine.Animator"}, ValidationLevel.ALLOW),
                new ComponentReference("Animation", new string[]{"UnityEngine.Animation"}, ValidationLevel.ALLOW),
                new ComponentReference("Skinned Mesh Renderer", new string[]{"UnityEngine.SkinnedMeshRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("Mesh Renderer ", new string[]{"UnityEngine.MeshRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("Mesh Filter", new string[]{"UnityEngine.MeshFilter"}, ValidationLevel.ALLOW),
                new ComponentReference("Collider", new string[]{"UnityEngine.SphereCollider", "UnityEngine.BoxCollider", "UnityEngine.SphereCollider", "UnityEngine.CapsuleCollider", "UnityEngine.WheelCollider"}, ValidationLevel.ALLOW),
                new ComponentReference("Rigidbody", new string[]{"UnityEngine.Rigidbody"}, ValidationLevel.ALLOW),
                new ComponentReference("Canvas", new string[]{"UnityEngine.Canvas", "UnityEngine.CanvasGroup", "UnityEngine.RectTransform", "UnityEngine.UI.CanvasScaler", "UnityEngine.UI.GraphicRaycaster", "UnityEngine.UI.AspectRatioFitter", "UnityEngine.UI.LayoutElement", "UnityEngine.UI.ContentSizeFitter", "UnityEngine.UI.HorizontalLayoutGroup", "UnityEngine.UI.VerticalLayoutGroup", "UnityEngine.UI.GridLayoutGroup", "UnityEngine.UI.Text", "UnityEngine.UI.Image", "UnityEngine.UI.RawImage", "UnityEngine.UI.Mask", "UnityEngine.UI.RectMask2D", "UnityEngine.UI.Button", "UnityEngine.UI.InputField", "UnityEngine.UI.Toggle", "UnityEngine.UI.ToggleGroup", "UnityEngine.UI.Slider", "UnityEngine.UI.Scrollbar", "UnityEngine.UI.Dropdown", "UnityEngine.UI.ScrollRect", "UnityEngine.UI.Selectable", "UnityEngine.UI.Shadow", "UnityEngine.UI.Outline", "UnityEngine.UI.PositionAsUV1", "UnityEngine.RectTransform", "UnityEngine.CanvasRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("VRC_Ui Shape", new string[]{"VRCSDK2.VRC_UiShape"}, ValidationLevel.ALLOW),
                new ComponentReference("Particle System", new string[]{"UnityEngine.ParticleSystem", "UnityEngine.ParticleSystemRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("Trail Renderer", new string[]{"UnityEngine.TrailRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("Line Renderer", new string[]{"UnityEngine.LineRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("Dynamic Bone", new string[]{"DynamicBone"}, ValidationLevel.ALLOW),
                new ComponentReference("Dynamic Bone Collider", new string[]{"DynamicBoneCollider"}, ValidationLevel.ALLOW),
                new ComponentReference("TextMesh Pro", new string[]{"TMPro.TMP_Dropdown", "TMPro.TMP_InputField", "TMPro.TMP_ScrollbarEventHandler", "TMPro.TMP_SelectionCaret", "TMPro.TMP_SpriteAnimator", "TMPro.TMP_SubMesh", "TMPro.TMP_SubMeshUI", "TMPro.TMP_Text", "TMPro.TextMeshPro", "TMPro.TextMeshProUGUI", "TMPro.TextContainer", "TMPro.TMP_Dropdown+DropdownItem"}, ValidationLevel.ALLOW),
            };
        }
    }
}
