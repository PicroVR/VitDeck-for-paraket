using System.Linq;

namespace VitDeck.Validator
{
    public static class ParaketOfficialAssetData
    {
        public static readonly string[] GUIDs = new[]
        {
            #region VRMShaders
            "503ae90aee4d0224db69e4e74762223b", // Assets/VRMShaders
            "8020a337ceab108438d088a3482a4b90", // Assets/VRMShaders/CHANGELOG.md
            "00999fd020bde754ab4ae5f8a5205844", // Assets/VRMShaders/LICENSE.md
            "0905ad83e0b774444bcc48ac9a191d51", // Assets/VRMShaders/package.json
            "4918a8517e721c5429d0f8033ae065c7", // Assets/VRMShaders/README.md
            "3dd33230757d1984894152dbacf595a6", // Assets/VRMShaders/Documentation
            "21fb6bf38127a35498543f81ba8cc2e2", // Assets/VRMShaders/Documentation/VRMShaders.md
            "ad4e8fc4ac2f50a4d82dc71d012a3596", // Assets/VRMShaders/MToon
            "2a5e8a5d481e3574b8274fa7ce4bdc2d", // Assets/VRMShaders/MToon/LICENSE
            "1021e7e6d453b9f4fb2f46a130425deb", // Assets/VRMShaders/MToon/README.md
            "029f110c597b25547ab35b6ed3fc049d", // Assets/VRMShaders/MToon/MToon
            "a9bc101fb0471f94a8f99fd242fdd934", // Assets/VRMShaders/MToon/MToon/MToon.asmdef
            "1b669562c8ecaee4c98c808d3971271b", // Assets/VRMShaders/MToon/MToon/Editor
            "24156f9da0724eb5a159f36c69a7d90a", // Assets/VRMShaders/MToon/MToon/Editor/EditorEnums.cs
            "531922bb16b74a00b81445116c49b09c", // Assets/VRMShaders/MToon/MToon/Editor/EditorUtils.cs
            "dddf8398e965f254cae2d7519d7f67d2", // Assets/VRMShaders/MToon/MToon/Editor/MToon.Editor.asmdef
            "8b43baa9f62f04748bb167ad186f1b1a", // Assets/VRMShaders/MToon/MToon/Editor/MToonInspector.cs
            "9491ac346386a2b4e9f3c801c6786818", // Assets/VRMShaders/MToon/MToon/Resources
            "221dcd8025c13ab42a51e886d7a7a92e", // Assets/VRMShaders/MToon/MToon/Resources/Shaders
            "1a97144e4ad27a04aafd70f7b915cedb", // Assets/VRMShaders/MToon/MToon/Resources/Shaders/MToon.shader
            "ef6682d138947ed4fbc8fbecfe75cd28", // Assets/VRMShaders/MToon/MToon/Resources/Shaders/MToonCore.cginc
            "084281ffd8b1b8e4a8605725d3b0760b", // Assets/VRMShaders/MToon/MToon/Resources/Shaders/MToonSM3.cginc
            "17d4e0f990fbc794ab41e4fcc196d559", // Assets/VRMShaders/MToon/MToon/Resources/Shaders/MToonSM4.cginc
            "9e9b6e0377a19e54d9d9ff78f925aec6", // Assets/VRMShaders/MToon/MToon/Samples
            "8b731264e8acd0f4b8f56986e5eb2531", // Assets/VRMShaders/MToon/MToon/Samples/OutlineWidthModes.unity
            "a028698465d209d4e91f4935e23b138e", // Assets/VRMShaders/MToon/MToon/Samples/Materials
            "4f42a26097c877b40a7616aa60580c43", // Assets/VRMShaders/MToon/MToon/Samples/Materials/Ex_OutlineWidth_Screen.mat
            "e40a129e14e378c4db040df3fd4a6077", // Assets/VRMShaders/MToon/MToon/Samples/Materials/Ex_OutlineWidth_World.mat
            "54da18ba3126f1343924588562df72e0", // Assets/VRMShaders/MToon/MToon/Samples/Materials/Ground.mat
            "9639e17dffc656345a70282f7f216672", // Assets/VRMShaders/MToon/MToon/Samples/Materials/Toon.mat
            "88551f898b0043c41b202eeb79752973", // Assets/VRMShaders/MToon/MToon/Scripts
            "9a3fb070d7eb4114b5cf387e2cd60391", // Assets/VRMShaders/MToon/MToon/Scripts/Enums.cs
            "2849b99d94074fcf9e10c5ca3eab15a8", // Assets/VRMShaders/MToon/MToon/Scripts/MToonDefinition.cs
            "9d2012c170a74b3db0002f7ecda53622", // Assets/VRMShaders/MToon/MToon/Scripts/Utils.cs
            "6724aa45c8c349fabd5954a531301aa8", // Assets/VRMShaders/MToon/MToon/Scripts/UtilsGetter.cs
            "b24a672e82874c9fbfef9c2b2dfdab42", // Assets/VRMShaders/MToon/MToon/Scripts/UtilsSetter.cs
            "4702d4b2c1414cc08b4382c3762eebab", // Assets/VRMShaders/MToon/MToon/Scripts/UtilsVersion.cs
            "f877649750df3814aa5272250b22678c", // Assets/VRMShaders/ShaderProperty
            "36a5a07493511bd49b1ad9dbad2683d2", // Assets/VRMShaders/ShaderProperty/Editor
            "bc66ece0f33b52446a0830c05781d4db", // Assets/VRMShaders/ShaderProperty/Editor/ShaderProperty.Editor.asmdef
            "5eb12c186c6337e4db278b5f01d47cae", // Assets/VRMShaders/ShaderProperty/Editor/ShaderPropMenu.cs
            "dd900b6f302c9404b99d77a1ae3d00be", // Assets/VRMShaders/ShaderProperty/Runtime
            "50935dd2f9f3fa445a687f30d4dd663b", // Assets/VRMShaders/ShaderProperty/Runtime/PreShaderPropExporter.cs
            "301b251fd9834274c9228e0532f444f7", // Assets/VRMShaders/ShaderProperty/Runtime/ShaderProperty.Runtime.asmdef
            "279964035c950b24cb745511298855dd", // Assets/VRMShaders/ShaderProperty/Runtime/ShaderProps.cs
            "d9c97ad7f5bbcac489a47a2f34dfff00", // Assets/VRMShaders/ShaderProperty/Runtime/GLTF
            "90dcef1978c51e74386b76d77689dc82", // Assets/VRMShaders/ShaderProperty/Runtime/GLTF/PreExportShaders_GLTF.cs
            "54043e349b047bf4b8f127cd919a757d", // Assets/VRMShaders/ShaderProperty/Runtime/GLTF/Standard.cs
            "ad4b6b115b83ecd48a513f697afc95f0", // Assets/VRMShaders/ShaderProperty/Runtime/GLTF/UniGLTF_UniUnlit.cs
            "4f91421c5846d5d48933d2ee4ffeeceb", // Assets/VRMShaders/ShaderProperty/Runtime/GLTF/Unlit_Color.cs
            "8273e1e61ad8e914baae94d06836f2ad", // Assets/VRMShaders/ShaderProperty/Runtime/GLTF/Unlit_Texture.cs
            "b98a8ee8ca13abb43809305cc4e5571a", // Assets/VRMShaders/ShaderProperty/Runtime/GLTF/Unlit_Transparent.cs
            "844490f13976543478d82efe28251941", // Assets/VRMShaders/ShaderProperty/Runtime/GLTF/Unlit_Transparent_Cutout.cs
            "eb31f565eeca6164694b06ccfe3bc251", // Assets/VRMShaders/ShaderProperty/Runtime/VRM
            "625b5ee8b5811dc4a915a2fbb2cb319d", // Assets/VRMShaders/ShaderProperty/Runtime/VRM/PreExportShaders_VRM.cs
            "4629d794c8969c141a4724e182af082e", // Assets/VRMShaders/ShaderProperty/Runtime/VRM/VRM_MToon.cs
            "611b546ea471ad34cb7d94740c63b558", // Assets/VRMShaders/ShaderProperty/Runtime/VRM/VRM_UnlitCutout.cs
            "22a8083880389b3498f421e6a5c340d5", // Assets/VRMShaders/ShaderProperty/Runtime/VRM/VRM_UnlitTexture.cs
            "140d6538826e0eb448929d3e4bb2f1cd", // Assets/VRMShaders/ShaderProperty/Runtime/VRM/VRM_UnlitTransparent.cs
            "165ec79b7aac1564a850fb3d3d19396e", // Assets/VRMShaders/ShaderProperty/Runtime/VRM/VRM_UnlitTransparentZWrite.cs
            "efc9c56620a6dea44a8cd83c5897e058", // Assets/VRMShaders/UniUnlit
            "60c8346e00a8ddd4cafc5a02eceeec57", // Assets/VRMShaders/UniUnlit/UniUnlit.asmdef
            "c1ce4da7404d095459d80006a8609a1c", // Assets/VRMShaders/UniUnlit/Editor
            "529ce3a240c1a7a4bbbb220bbd59686b", // Assets/VRMShaders/UniUnlit/Editor/UniUnlit.Editor.asmdef
            "4c70714358bb2fb4fa96ef08640763fd", // Assets/VRMShaders/UniUnlit/Editor/UniUnlitEditor.cs
            "9e133c6453ae1c54c931227ff64edd52", // Assets/VRMShaders/UniUnlit/Resources
            "8c17b56f4bf084c47872edcb95237e4a", // Assets/VRMShaders/UniUnlit/Resources/UniUnlit.shader
            "b19f3d26eec098d46a33d8d35ba2eab5", // Assets/VRMShaders/UniUnlit/Scripts
            "e96cbbd810384352a6799dd731533178", // Assets/VRMShaders/UniUnlit/Scripts/Utils.cs
            #endregion
            #region VitDeck
            "0b9cd90d6c2ac9545a9c918d21b032fa", // Assets/VitDeck
            "f96676051e7fb7645893f98d2f6adc4c", // Assets/VitDeck/LICENSE.txt
            "ce9eb8d4dc599db45abf775e3bfb3f1a", // Assets/VitDeck/README.URL
            "01b4f7650f20c9247b98fca03fd29872", // Assets/VitDeck/ReleaseInfo.json
            "c40ec3ded49245d4b9a7f085aafb004e", // Assets/VitDeck/AssetGuardian
            "778a64800f39491489e705a5adaeea67", // Assets/VitDeck/AssetGuardian/AssetRestorer.cs
            "71fbe6dac15ea684b9a83ce971b0af33", // Assets/VitDeck/AssetGuardian/AssetTypeIdentifier.cs
            "5e1d12467f0db4d48ae613857933399e", // Assets/VitDeck/AssetGuardian/IAssetProtectionMarker.cs
            "469367ec720a31844b03fa249685dc53", // Assets/VitDeck/AssetGuardian/LabelAndHideFlagProtectionMarker.cs
            "93b8b1e7819b6a1439f21bb3ac20c818", // Assets/VitDeck/AssetGuardian/LinqExtensions.cs
            "98903bbc5876ac1469a1f939882ebdd7", // Assets/VitDeck/AssetGuardian/Protector.cs
            "97abb040e822c024ba086eef0ae1b1c9", // Assets/VitDeck/AssetGuardian/VitDeck.AssetGuardian.asmdef
            "99ed9d14aebd27940b72ab15c2aa6c39", // Assets/VitDeck/AssetGuardian/EditorEventHooks
            "80b52708fc4f5434b9ef312c1b79c23d", // Assets/VitDeck/AssetGuardian/EditorEventHooks/EditorDelayedAction.cs
            "d99c652b31b252a479f708431fb5c6b4", // Assets/VitDeck/AssetGuardian/EditorEventHooks/UnityAssetDuplicationEvent.cs
            "ed11a5d849deb5f4f862c81f7f0ae1e3", // Assets/VitDeck/AssetGuardian/EditorEventHooks/UnityAssetModificationEvent.cs
            "edcba6ca642891b4baec5157e7ab3b45", // Assets/VitDeck/AssetGuardian/EditorEventHooks/UnityAssetPostProcessEvent.cs
            "f37802c861f567d459e5a74e38e24f17", // Assets/VitDeck/AssetGuardian/GUI
            "79fecabf72064e44aaf9fefdf052a175", // Assets/VitDeck/AssetGuardian/GUI/Notificator.cs
            "7ddb48e98d1dfd94f9e3d9207a36086d", // Assets/VitDeck/AssetGuardian/GUI/VitDeck.AssetGuardian.GUI.asmdef
            "b6c5fd1a2d346a84995f2c1ed01b4d25", // Assets/VitDeck/AssetGuardian/Tests
            "96a64ddaefdcd4141909bf0f88d9ccaa", // Assets/VitDeck/AssetGuardian/Tests/LabelAndHideFlagProtectionMarkerTest.cs
            "2486a3bdea7683c4bb528e240ffaee4f", // Assets/VitDeck/AssetGuardian/Tests/VitDeck.AssetGuardian.Tests.asmdef
            "38fb3fbb44cf8b8479bec2205625fc38", // Assets/VitDeck/BuildSizeCalculator
            "c3913186859529c4f8d4586bbe46cabd", // Assets/VitDeck/BuildSizeCalculator/Calculator.cs
            "c58a66b07cf8d1d4ebba375a78e2b548", // Assets/VitDeck/BuildSizeCalculator/VitDeck.BuildSizeCalculator.asmdef
            "0542459f81ba6664293c9e952399c6cd", // Assets/VitDeck/BuildSizeCalculator/Wizard.cs
            "942c41123f54e2f40b017e2d4dbd4589", // Assets/VitDeck/Config
            "f9a7c21573dad094eb21d501e052c252", // Assets/VitDeck/Config/DefaultExportSetting.asset
            "815e007e9647f9c43bd6d83cc643b17d", // Assets/VitDeck/Config/DefaultExportSetting_SHA-1.asset
            "05887c067171d2442ab6bdcfd8635fd9", // Assets/VitDeck/Config/LanguageSettings.asset
            "2591e6882a6ef694abeb5571447ea8c5", // Assets/VitDeck/Config/ParaketExportSetting.asset
            "41eb112bcd2557d42b154d25f2151073", // Assets/VitDeck/Config/PlacementSettings.asset
            "bac4bb3ff22830b418a8dea9a67747ce", // Assets/VitDeck/Config/ProductInfo.asset
            "e8707db2d86746c48b8da6e88e4b8c40", // Assets/VitDeck/Config/UserSettings.asset
            "ca54095fad0f4a444a61ce43fe14c040", // Assets/VitDeck/Config/VketExportSetting.asset
            "0a789ec007276dd43948da4cb0604e78", // Assets/VitDeck/Config/VketExportSettingAvatarShowcase.asset
            "46b99d8be34463c48b5bf0a096c193d1", // Assets/VitDeck/Config/VketExportSettingDefaultCube.asset
            "3dd623ad914a2c149ab08b5f49c3816c", // Assets/VitDeck/Config/VketExportSettingUdonCube.asset
            "d6fe484e224f75c42bd3de7f3cd1afab", // Assets/VitDeck/Exporter
            "ada806fc6a0622743af8c574ae1ffbf3", // Assets/VitDeck/Exporter/Exporter.cs
            "a6b2979b491f8eb44a5433e8f81d5797", // Assets/VitDeck/Exporter/ExportResult.cs
            "a780f2801beb823448f3c902970fc314", // Assets/VitDeck/Exporter/ExportSetting.cs
            "405d78d1bd498cc44a0f9b3ef728e864", // Assets/VitDeck/Exporter/VitDeck.Exporter.asmdef
            "edd0f477503a44688ca7867cc9412994", // Assets/VitDeck/Exporter/Addons
            "f6a16544606147cf923c67edce5f0099", // Assets/VitDeck/Exporter/Addons/VRCSDK3
            "6880bee9ebd0403da08a2fdac12ef3e9", // Assets/VitDeck/Exporter/Addons/VRCSDK3/LinkedUdonManager.cs
            "4cba632eb5391c948a9e1304f830f7d0", // Assets/VitDeck/Exporter/Addons/VRCSDK3/VitDeck.Exporter.Addons.VRCSDK3.asmdef
            "35641dffc97e7ee44b7dfb2bdc26ae53", // Assets/VitDeck/Exporter/GUI
            "f3effe4cefc767e4b8799c43570fd0d7", // Assets/VitDeck/Exporter/GUI/VitDeck.Exporter.GUI.asmdef
            "4404337c3a675c641b659464a83500fb", // Assets/VitDeck/Exporter/Tests
            "849c42cfeeacf3941b0dab05c168516d", // Assets/VitDeck/Exporter/Tests/TestExporter.cs
            "a683a56f7bea26945980e741c7efdf4a", // Assets/VitDeck/Exporter/Tests/VitDeck.Exporter.Tests.asmdef
            "1c4796fed81af554a9724b57e2c9699b", // Assets/VitDeck/Exporter/Tests/TestBaseFolder
            "17d9b222f4a94634f80586f188a8076d", // Assets/VitDeck/Exporter/Tests/TestBaseFolder/New Scene.unity
            "b8cd476a60aeaec4c844abe1719ccecb", // Assets/VitDeck/Images
            "3c50f3debb140d1439e5efbc9a548cec", // Assets/VitDeck/Images/Link_icon.png
            "b7a2c91387057f142b6275a253bfdd21", // Assets/VitDeck/Language
            "9c6ce664473c5364f97e0062f8d16c90", // Assets/VitDeck/Language/English.asset
            "bca05b8223e02d446a2f3bd3dea0ee44", // Assets/VitDeck/Language/Japanese.asset
            "ba6412c28ce82684d9553dad6c745558", // Assets/VitDeck/Language/LanguageDictionary.cs
            "cb4c74c810fa79b4db8d542117083535", // Assets/VitDeck/Language/LanguageDictionaryEditor.cs
            "2a7860285c43bb74cbe4d8eb1e05921d", // Assets/VitDeck/Language/LanguageDictionaryTreeView.cs
            "21b4d60488418324cb62d9f97d7e2dc8", // Assets/VitDeck/Language/LanguageLoader.cs
            "ab0d45b8031d3ac4ab6b6d02bf952880", // Assets/VitDeck/Language/LanguageSettings.cs
            "a5c11e2ab3cccc3409c9373801dc1c05", // Assets/VitDeck/Language/LanguageSettingsEditor.cs
            "25f8548ca89617c4086b757641b7a9ab", // Assets/VitDeck/Language/LocalizedMessage.cs
            "8fa017693f1a60d42bfda3f16ed1671c", // Assets/VitDeck/Language/VitDeck.Language.asmdef
            "490421528ab45194e92a733291d0d547", // Assets/VitDeck/Main
            "e31b8477cd483d64ca4b77c94be6416a", // Assets/VitDeck/Main/GUIUtilities.cs
            "5451a9ed39306a24ca083676ed65ca6b", // Assets/VitDeck/Main/JsonReleaseInfo.cs
            "b656777d1a503bd4a9c65f224e4e8366", // Assets/VitDeck/Main/PackageDownloader.cs
            "ddd0ba93ba14eb442ab0da17ca0cf659", // Assets/VitDeck/Main/ToolExporter.cs
            "d49736b0978fd0b47b050a54c6444d04", // Assets/VitDeck/Main/UpdateCheck.cs
            "6b39b323d17ae6d42b017381059952a8", // Assets/VitDeck/Main/VitDeck.cs
            "0dc8fcc8b4dfa104299bab414b7a16e1", // Assets/VitDeck/Main/VitDeck.Main.asmdef
            "2e3d92c6f83ccd5459fbc51679060f70", // Assets/VitDeck/Main/GUI
            "815972ddc3bd70948a1263d5cd3e044b", // Assets/VitDeck/Main/GUI/InfoWindow.cs
            "31fa395ce9620854b817e24bfb235518", // Assets/VitDeck/Main/GUI/MainMenu.cs
            "4ea7f69acf660a348b794c099782a226", // Assets/VitDeck/Main/GUI/VitDeck.Main.GUI.asmdef
            "cafaae8912f70a64095c9ec7f7664a2d", // Assets/VitDeck/Main/Tests
            "7ac43e68ccba1be4185dd9df071d899a", // Assets/VitDeck/Main/Tests/JsonReleaseInfoTest.cs
            "564e9f93bb66a1c4b8e8ffabba860b7d", // Assets/VitDeck/Main/Tests/UpdateCheckTest.cs
            "91c21136ec0404449bb34ac1fbb2eb05", // Assets/VitDeck/Main/Tests/VitDeck.Main.Tests.asmdef
            "c1b619ecf4a140b41b3fbfd69b97eb94", // Assets/VitDeck/Main/Tests/VitDeckTest.cs
            "faf572692550bca469293203381159d1", // Assets/VitDeck/Main/ValidatedExporter
            "61574dd23174335418a4dae8d6829cb0", // Assets/VitDeck/Main/ValidatedExporter/ValidatedExporter.cs
            "15cca052d0905214db528d1b77ac4f17", // Assets/VitDeck/Main/ValidatedExporter/ValidatedExportResult.cs
            "44193d7aa1118c747b02befe32cf1e82", // Assets/VitDeck/Main/ValidatedExporter/VitDeck.Main.ValidatedExporter.asmdef
            "31f38ce8a2e9c8941b35dfd551e1396a", // Assets/VitDeck/Main/ValidatedExporter/GUI
            "1d0d176ac469c1e48ba749ce18b65301", // Assets/VitDeck/Main/ValidatedExporter/GUI/ValidatedExporterGUI.cs
            "0cbaba0ed0b1bc34da09cd89cf16c757", // Assets/VitDeck/Main/ValidatedExporter/GUI/VitDeck.Main.ValidatedExporter.GUI.asmdef
            "6796a4ff7d7ceed4aa0c5be0dbc5e30c", // Assets/VitDeck/Main/ValidatedExporter/Tests
            "40579a3e451274743a5e5746dd096b29", // Assets/VitDeck/Main/ValidatedExporter/Tests/TestValidatedExporter.cs
            "685f374eff40df845b511bb62493f6f9", // Assets/VitDeck/Main/ValidatedExporter/Tests/VitDeck.Main.ValidatedExporter.Tests.asmdef
            "b838f827962d8c04eb7d5a915ebc3f40", // Assets/VitDeck/Organizer
            "50078d4d055c34645a3c4e0b683b9b19", // Assets/VitDeck/Organizer/AssetGuardian
            "3dc81285b602f7f4da1d60c9e894c8cb", // Assets/VitDeck/Organizer/AssetGuardian/AssetGuardianContextMenu.cs
            "9018f4748dfe14f479da519849c0716c", // Assets/VitDeck/Organizer/AssetGuardian/VitDeck.Organizer.AssetGuardian.asmdef
            "8684969e4f0d18c4f8cfe272819ffb1e", // Assets/VitDeck/Organizer/Exporter
            "f7c8c6c89ea9f5748be371dbd2d6fabc", // Assets/VitDeck/Organizer/Exporter/ExportSettingCreateAssetMenu.cs
            "c20158785255dcc40adb48cc73f0424a", // Assets/VitDeck/Organizer/Exporter/VitDeck.Organizer.Exporter.asmdef
            "8192879c102b56a4e87870c86ec0e90d", // Assets/VitDeck/Organizer/TemplateLoader
            "603d26fd65a8b224483153c5326da95e", // Assets/VitDeck/Organizer/TemplateLoader/TemplatePropertyCreateAssetMenu.cs
            "bd0238473fd9ac94fab1f3ce279c734a", // Assets/VitDeck/Organizer/TemplateLoader/VitDeck.Organizer.TemplateLoader.asmdef
            "f9bb28f6b0e4a6e459ffe881bf410463", // Assets/VitDeck/Organizer/TemplateLoader/VitDeckDummyCreateAssetMenu.cs
            "b45f94ececf61f04291372731094a5b9", // Assets/VitDeck/PerformanceCalculator
            "fbbaf050a5319ce48bfac6e106dce564", // Assets/VitDeck/PerformanceCalculator/Calculator.cs
            "aa3cc31b4bdcaf243a6b680b164345d9", // Assets/VitDeck/PerformanceCalculator/VitDeck.PerformanceCalculator.asmdef
            "fc23a67d2a767b641a6ada27685496ae", // Assets/VitDeck/PerformanceCalculator/Wizard.cs
            "7157a0221c7a9224b93d3d08a2637071", // Assets/VitDeck/Placement
            "8c0aa2970575d2748932c00f2682bcb3", // Assets/VitDeck/Placement/PackageImporter.cs
            "a8b51ece47d3d714786e4edbf711164b", // Assets/VitDeck/Placement/Placement.cs
            "c31d7e6aa8fc4f14fb44d698a0247b49", // Assets/VitDeck/Placement/PlacementSettings.cs
            "68ddd9f9938ef4f478ced637da479925", // Assets/VitDeck/Placement/PlacementWizard.cs
            "9ccdca935d2f6a948bfa1911132a8ad6", // Assets/VitDeck/Placement/VitDeck.Placement.asmdef
            "074e0a3d72306924a98db20576b4e497", // Assets/VitDeck/Placement/BoothPlacementSample
            "abf09d9bebc6bae41b20a14d7abdbe0c", // Assets/VitDeck/Placement/BoothPlacementSample/Arrangement.prefab
            "094132571c9c3f24aa79c2b575719b85", // Assets/VitDeck/Placement/BoothPlacementSample/MIT_BoothPlacementSample.unity
            "0ac3f1420d86c8949bb4353aa35bd002", // Assets/VitDeck/Placement/BoothPlacementSample/Exhibitors
            "02572413452277f43a59eed7c949d8d3", // Assets/VitDeck/Placement/BoothPlacementSample/Exhibitors/001
            "3905683dbbbcdf2498643fc4a5cc11ed", // Assets/VitDeck/Placement/BoothPlacementSample/Exhibitors/001/SB_CC.prefab
            "9efd8629bf8d3f84f9f26361913dc375", // Assets/VitDeck/Placement/BoothPlacementSample/Exhibitors/002
            "83330751a4f2d14448277b43e6bf1716", // Assets/VitDeck/Placement/BoothPlacementSample/Exhibitors/002/SB_CC.prefab
            "2ab3d46ede929d54682b3f90313e110f", // Assets/VitDeck/Placement/BoothPlacementSample/Exhibitors/015
            "e75d935e546329f4f8592d199503f8e2", // Assets/VitDeck/Placement/BoothPlacementSample/Exhibitors/015/SB_CC.prefab
            "f80a1f7fa84a8a84eb71dbed0194a917", // Assets/VitDeck/Placement/Components
            "e0ca4389b47ea324badbbe1efc494b13", // Assets/VitDeck/Placement/Components/PlacementAnchor.cs
            "c1126dc8b33870c4981f9a4563337557", // Assets/VitDeck/Placement/Components/VitDeck.Placement.Components.asmdef
            "e437174bb84b6b34fb945dd02bf4e6da", // Assets/VitDeck/TemplateLoader
            "bf5c2a145ae2e9348ba59adc09545fe8", // Assets/VitDeck/TemplateLoader/AnimationClipReferenceModifier.cs
            "2c1921fc4f5b51f499782babe619b1cd", // Assets/VitDeck/TemplateLoader/FbxReferenceModifier.cs
            "e9a3f6655dcd5044e95a94b8370dc7d7", // Assets/VitDeck/TemplateLoader/GuidReferenceModifier.cs
            "822225f7629266746989bba44bc61ddb", // Assets/VitDeck/TemplateLoader/IReferenceModifier.cs
            "db507e0454c38da45b4dd6892a6753a6", // Assets/VitDeck/TemplateLoader/ReplacementDefinition.cs
            "c2a17aad758a2ed4e81dd4b45df6db6f", // Assets/VitDeck/TemplateLoader/TemplateLoader.cs
            "8791441c2e8fe6e4dac55f7b669808d5", // Assets/VitDeck/TemplateLoader/TemplateProperty.cs
            "1e102de2e25c8d94e9eaba75e2768891", // Assets/VitDeck/TemplateLoader/VitDeck.TemplateLoader.asmdef
            "84a3024049742bf4e8af449d015248a6", // Assets/VitDeck/TemplateLoader/VitDeckDummy.cs
            "ac08373d20c5e3a4c8c80f7090896c9f", // Assets/VitDeck/TemplateLoader/GUI
            "5cf8de0402ca62b4fb6775dc166e03b0", // Assets/VitDeck/TemplateLoader/GUI/TemplateLoaderGUI.cs
            "1acea4bf85bbbe341874a0a30637798b", // Assets/VitDeck/TemplateLoader/GUI/VitDeck.TemplateLoader.GUI.asmdef
            "1fa721b22cf47de47a87f2e08e08f01b", // Assets/VitDeck/TemplateLoader/Tests
            "8aa4c8faeffb7314e84e88619c07447d", // Assets/VitDeck/TemplateLoader/Tests/TemplateLoaderTest.cs
            "c7494ea063971b142a44302cd86f6e17", // Assets/VitDeck/TemplateLoader/Tests/VitDeck.TemplateLoader.Tests.asmdef
            "9cc74956ce0789345b947a4210714572", // Assets/VitDeck/Templates
            "9d2484e43fb410f43a21d4bd0eeb8b8c", // Assets/VitDeck/Templates/LICENSE.txt
            "aa88e8f07a65bf547a5b35fbe52bce62", // Assets/VitDeck/Templates/01_VS
            "e3f6aa877a920434385bffc654514086", // Assets/VitDeck/Templates/01_VS/Property.asset
            "5c85bddb1851ade40ad14b3867a0f4a6", // Assets/VitDeck/Templates/01_VS/SharedAssets
            "8f01ebd0a771cf24abbf23570b7b96a5", // Assets/VitDeck/Templates/01_VS/SharedAssets/AS BGI TMP (02_VS).png
            "a941215c879906a43be415b6ceb99c5b", // Assets/VitDeck/Templates/01_VS/SharedAssets/AS_Plane (02_VS).fbx
            "ce62de801b8ad824bbf9ea504e021a28", // Assets/VitDeck/Templates/01_VS/SharedAssets/BoothSample (02_VS).mat
            "28665c8163c3e3242b2c624b2720dba9", // Assets/VitDeck/Templates/01_VS/SharedAssets/CeilLight (02_VS).mat
            "c77c6e6cbadab3348a75105899144a65", // Assets/VitDeck/Templates/01_VS/SharedAssets/CustomReflectionProbe (02_VS).exr
            "4ccf1e1c54baf6949b269a56237c2ed6", // Assets/VitDeck/Templates/01_VS/SharedAssets/glass_showcase (02_VS).mat
            "6e8480f180eeecb4f93831e65e8829d2", // Assets/VitDeck/Templates/01_VS/SharedAssets/SampleFrame (02_VS).mat
            "6362e0045a29f474b9ac2460240b31ba", // Assets/VitDeck/Templates/01_VS/SharedAssets/SampleModel (02_VS).fbx
            "984957791b55ca1409105158ce1549ef", // Assets/VitDeck/Templates/01_VS/SharedAssets/Sample_Floor (02_VS).mat
            "34f647db51590d441893ea8404e89373", // Assets/VitDeck/Templates/01_VS/SharedAssets/Sample_wall (02_VS).mat
            "03fab23da6462d94ca16cc0611239f5c", // Assets/VitDeck/Templates/01_VS/SharedAssets/SkyboxSample (02_VS).exr
            "4ec194e5b24afa54da5dd9c5d7175de4", // Assets/VitDeck/Templates/01_VS/SharedAssets/SkyboxSample (02_VS).mat
            "b08150d4547f81346934f58a3495dc6e", // Assets/VitDeck/Templates/01_VS/SharedAssets/WallSamole_A (02_VS).png
            "795bea94f6231034e942895c3c6933df", // Assets/VitDeck/Templates/01_VS/SharedAssets/WallSample_M (02_VS).png
            "679c4713582cd3f4ea04ca25639f7c1d", // Assets/VitDeck/Templates/01_VS/SharedAssets/WallSample_N (02_VS).bmp
            "58054a33580c5914b927cc0864bee682", // Assets/VitDeck/Templates/01_VS/SharedAssets/WallSample_O (02_VS).bmp
            "ae0b2ed169910924ab1ba2cde82b0ecd", // Assets/VitDeck/Templates/01_VS/TemplateAssets
            "54b1cf7064cc80f4b8ac535f0ae84f16", // Assets/VitDeck/Templates/01_VS/TemplateAssets/{CIRCLEID}
            "671d1ab505feb7746b44557bb7e9238a", // Assets/VitDeck/Templates/01_VS/TemplateAssets/{CIRCLEID}/{CIRCLEID}.unity
            "53516105a51684c46b4549ad68bd3296", // Assets/VitDeck/Templates/02_DC
            "0459309bd71c07744a54e3d8f41b5d29", // Assets/VitDeck/Templates/02_DC/Property.asset
            "d585e9e59405fbb439fd92255ac38490", // Assets/VitDeck/Templates/02_DC/SharedAssets
            "baa07946b2911b943a4f9688a8995d86", // Assets/VitDeck/Templates/02_DC/SharedAssets/CustomReflection(01_DC).exr
            "a0efe09907032094987226e4a7643dd9", // Assets/VitDeck/Templates/02_DC/SharedAssets/Floor(01_DC).fbx
            "e9f6c94a57cb3d34b97ffa4a817cb27c", // Assets/VitDeck/Templates/02_DC/SharedAssets/FloorGrid(01_DC).mat
            "9bcf26be531084042ac70d6fd3d34f94", // Assets/VitDeck/Templates/02_DC/SharedAssets/FloorGrid(01_DC).png
            "5f0e67c6777bae1469b30d582b61a079", // Assets/VitDeck/Templates/02_DC/SharedAssets/SampleBooth(01_DC).mat
            "56e53070b76714742acb864c1f5d6f82", // Assets/VitDeck/Templates/02_DC/SharedAssets/Skybox(01_DC).mat
            "5cd230cf05c935b4a96b4b1681b76bb9", // Assets/VitDeck/Templates/02_DC/TemplateAssets
            "d0da6fc29d8033d459dfd6a7cbf5f0ca", // Assets/VitDeck/Templates/02_DC/TemplateAssets/{CIRCLEID}
            "0d1bae87d95dec84b9796c11335a60e9", // Assets/VitDeck/Templates/02_DC/TemplateAssets/{CIRCLEID}/{CIRCLEID}.unity
            "b5409ce28483e294ab634ee037983282", // Assets/VitDeck/Templates/03_IM
            "47d1a8428c22f564aa4dcd754d0cf96a", // Assets/VitDeck/Templates/03_IM/Property.asset
            "c1006c81aded87e41b305a5c468d33f3", // Assets/VitDeck/Templates/03_IM/SharedAssets
            "a6c3cd1c7ef50594fa27103517bff748", // Assets/VitDeck/Templates/03_IM/SharedAssets/Materials
            "85179ed64a940f74183ab9f6b416f891", // Assets/VitDeck/Templates/03_IM/SharedAssets/Materials/Floor1(03_IM).mat
            "d5735935554de2845bac75c8610fd197", // Assets/VitDeck/Templates/03_IM/SharedAssets/Materials/Floor2(03_IM).mat
            "72bd005bb1db0264580508c4083b574e", // Assets/VitDeck/Templates/03_IM/SharedAssets/Materials/SampleBooth (03_IM).mat
            "ed193d297ae3b65489770c7c89e0ffd7", // Assets/VitDeck/Templates/03_IM/SharedAssets/Materials/SkyBoxSample (03_IM).mat
            "7b681403c1490a14b9d5e4ff5ebf8eb9", // Assets/VitDeck/Templates/03_IM/SharedAssets/Mesh
            "609e92c4c6388e74899893276724fcbb", // Assets/VitDeck/Templates/03_IM/SharedAssets/Mesh/IM (03_IM).fbx
            "a523c7cfa97842b4fbfdd50a96f1b956", // Assets/VitDeck/Templates/03_IM/SharedAssets/Profile
            "edb1841ea65138146b6d09f47776e090", // Assets/VitDeck/Templates/03_IM/SharedAssets/Texture
            "a1edce20bab4b2340bc7154ba1b05baf", // Assets/VitDeck/Templates/03_IM/SharedAssets/Texture/Floor1 (03_IM).png
            "f9e6ad362e9ad8a4eb98dfb1934fb4e6", // Assets/VitDeck/Templates/03_IM/SharedAssets/Texture/Floor2 (03_IM).png
            "28ab090e1809727429a0bda837d9f158", // Assets/VitDeck/Templates/03_IM/SharedAssets/Texture/ReflectionProbeSample (03_IM).exr
            "572cd78c2f40ce547a824366ecf68f46", // Assets/VitDeck/Templates/03_IM/SharedAssets/Texture/SkyboxSample (03_IM).exr
            "da9c3e5c161368146afec3df4bb69beb", // Assets/VitDeck/Templates/03_IM/TemplateAssets
            "dd49288bdf2bca54ba96fa9e4d55a466", // Assets/VitDeck/Templates/03_IM/TemplateAssets/{CIRCLEID}
            "dfebe4504e9a249428b6fa93bb14c01a", // Assets/VitDeck/Templates/03_IM/TemplateAssets/{CIRCLEID}/{CIRCLEID}.unity
            "a40dcde4ba8b91647bbfc5d1db302c4e", // Assets/VitDeck/Templates/04_ME
            "62940f8829893874f9a3e9f49fb098c9", // Assets/VitDeck/Templates/04_ME/Property.asset
            "932ca64ef9cec414e909e40c33365dd5", // Assets/VitDeck/Templates/04_ME/SharedAssets
            "adb84bd990d9a864688f044e074acd3b", // Assets/VitDeck/Templates/04_ME/SharedAssets/Materials
            "8a5b638db9a658a48815943ad957d38a", // Assets/VitDeck/Templates/04_ME/SharedAssets/Materials/Ceiling_BaseColor (04_ME).mat
            "34d19c459260cc242ac92068a802e42f", // Assets/VitDeck/Templates/04_ME/SharedAssets/Materials/Floor_BaseColor (04_ME).mat
            "185343539a9757846bdfedcbc60a231c", // Assets/VitDeck/Templates/04_ME/SharedAssets/Materials/Frame (04_ME).mat
            "ff097617bb0fea842ad2a9503de2d49b", // Assets/VitDeck/Templates/04_ME/SharedAssets/Materials/Lamp (04_ME).mat
            "493764fe384da7b4e994a089d6cdd5fa", // Assets/VitDeck/Templates/04_ME/SharedAssets/Materials/Light_baseColor (04_ME).mat
            "67a326afbc5c7b54db7fdfc50bcf8ad2", // Assets/VitDeck/Templates/04_ME/SharedAssets/Materials/SkyBoxSample (04_ME).mat
            "6d2a8c77e089ed048813eb42cc154d7a", // Assets/VitDeck/Templates/04_ME/SharedAssets/Materials/Tree_BaseColor (04_ME).mat
            "8b5a459333c6c7e41910ede7ddc43b23", // Assets/VitDeck/Templates/04_ME/SharedAssets/Materials/Wall_BaseColor (04_ME).mat
            "92397cfe3ca9b83439ae2dff22512ab1", // Assets/VitDeck/Templates/04_ME/SharedAssets/Mesh
            "cb098b195a2abaf42bd856aaa69cceb5", // Assets/VitDeck/Templates/04_ME/SharedAssets/Mesh/SampleBooth (04_ME).fbx
            "2bdbdb55f6606d54c8436c421cc16d5a", // Assets/VitDeck/Templates/04_ME/SharedAssets/Mesh/SampleModel (04_ME).fbx
            "5d9825f412f39604d84c7e8a430d3322", // Assets/VitDeck/Templates/04_ME/SharedAssets/Profile
            "384c2dd19b5a58741998e1d069f045e0", // Assets/VitDeck/Templates/04_ME/SharedAssets/Texture
            "2e41b2dfec7658d44894d1874b567f4b", // Assets/VitDeck/Templates/04_ME/SharedAssets/Texture/Ceiling_BaseColor (04_ME).png
            "0b39808291ce3894da0efb88ddd0848e", // Assets/VitDeck/Templates/04_ME/SharedAssets/Texture/Ceiling_Normal (04_ME).png
            "6705db9bb42b5b24b9cddef4fca139a4", // Assets/VitDeck/Templates/04_ME/SharedAssets/Texture/Ceiling_Roughness (04_ME).png
            "8e188bfda2326e44abfd47af3f150416", // Assets/VitDeck/Templates/04_ME/SharedAssets/Texture/Floor_BaseColor (04_ME).png
            "ae88b6d12b5b06c45957402b481d3fec", // Assets/VitDeck/Templates/04_ME/SharedAssets/Texture/Floor_Normal (04_ME).png
            "1051439a0abf39b439eb252b9d8de683", // Assets/VitDeck/Templates/04_ME/SharedAssets/Texture/Lamp (04_ME).png
            "45ab47286e7a27f4ea6679fa30fe88ac", // Assets/VitDeck/Templates/04_ME/SharedAssets/Texture/Lamp_Emission (04_ME).png
            "386652ca5e0153546a485cf155fb9d85", // Assets/VitDeck/Templates/04_ME/SharedAssets/Texture/Light_baseColor (04_ME).png
            "e1c8c598ae9fd8940be820154a046aed", // Assets/VitDeck/Templates/04_ME/SharedAssets/Texture/ReflectionProbeSample (04_ME).exr
            "748be41452e741941b4fc0f14a9c0475", // Assets/VitDeck/Templates/04_ME/SharedAssets/Texture/SkyboxSample (04_ME).exr
            "33609a6b48c33c44daf43c84b34484e4", // Assets/VitDeck/Templates/04_ME/SharedAssets/Texture/Tree_BaseColor (04_ME).png
            "a97f287f0c9a4ef40bfd1e2ab5e5af0d", // Assets/VitDeck/Templates/04_ME/SharedAssets/Texture/Tree_Normal (04_ME).png
            "3796ad3324409824dbdcc90def540411", // Assets/VitDeck/Templates/04_ME/SharedAssets/Texture/Wall_BaseColor (04_ME).png
            "450ddeffdf52fac4a800add6e0500aa7", // Assets/VitDeck/Templates/04_ME/TemplateAssets
            "e087cf5fc44b65a48b46e07cadceeedb", // Assets/VitDeck/Templates/04_ME/TemplateAssets/{CIRCLEID}
            "fcf23977c3c773145b48db22064d89dc", // Assets/VitDeck/Templates/04_ME/TemplateAssets/{CIRCLEID}/{CIRCLEID}.unity
            "d3f4aa29c52dcaf4f88d3c86f5c7dd01", // Assets/VitDeck/Templates/05_OB
            "d453bd71f3f59804db6b67c21be8f23b", // Assets/VitDeck/Templates/05_OB/Property.asset
            "b29872f1e0cdfc74fbec8cff49e788c6", // Assets/VitDeck/Templates/05_OB/SharedAssets
            "f2f3d3c8f2799b94ca6b03f6ad9104fc", // Assets/VitDeck/Templates/05_OB/SharedAssets/Materials
            "45108dd241ba6754881ac7ef66d45379", // Assets/VitDeck/Templates/05_OB/SharedAssets/Materials/Floor_OB (05_OB).mat
            "a518a938850bae54390821006b7245d6", // Assets/VitDeck/Templates/05_OB/SharedAssets/Materials/Props_OB (05_OB).mat
            "4c49cc935284f5c4d86c38efc7fb64be", // Assets/VitDeck/Templates/05_OB/SharedAssets/Materials/SampleBooth (05_OB).mat
            "ce679e911e834b041965ea34c1e0ecb1", // Assets/VitDeck/Templates/05_OB/SharedAssets/Materials/SkyBoxSample_OB (05_OB).mat
            "903ea4f978d1f974e8b545c7b80bcc77", // Assets/VitDeck/Templates/05_OB/SharedAssets/Materials/Window_OB (05_OB).mat
            "f31453fa703f03e4a903aa6853a0abc1", // Assets/VitDeck/Templates/05_OB/SharedAssets/Mesh
            "493238036e3bc6e45a74ec734d2684b0", // Assets/VitDeck/Templates/05_OB/SharedAssets/Mesh/BoothMesh (05_OB).fbx
            "0264cac4e18e11545b3980a16111f08e", // Assets/VitDeck/Templates/05_OB/SharedAssets/Mesh/SampleBooth (05_OB).fbx
            "3c96c0f6f1baae545aa6f5bfec1f2c2d", // Assets/VitDeck/Templates/05_OB/SharedAssets/Mesh/Vket5_OB_Sample (05_OB).fbx
            "4cc81df53e307da4f9fbf1ca3dad475c", // Assets/VitDeck/Templates/05_OB/SharedAssets/Profile
            "24db8e73d47efab41a6df9d822645bc9", // Assets/VitDeck/Templates/05_OB/SharedAssets/Textures
            "e3ba5a7fe87cc1c42944ce24eaab25a4", // Assets/VitDeck/Templates/05_OB/SharedAssets/Textures/FloorRefrection_OB (05_OB).exr
            "81fb4b3bab10b6644b0cd7089946a716", // Assets/VitDeck/Templates/05_OB/SharedAssets/Textures/Floor_Alb_OB (05_OB).png
            "347422d995ca9464f8be496b7b74578e", // Assets/VitDeck/Templates/05_OB/SharedAssets/Textures/Props_Alb_OB (05_OB).png
            "3ee1f642275069548a495b955a37d65c", // Assets/VitDeck/Templates/05_OB/SharedAssets/Textures/Props_Emi_OB (05_OB).png
            "bbcc3d88b77008e4eb2a48a4bff17504", // Assets/VitDeck/Templates/05_OB/SharedAssets/Textures/SkyBoxSample_OB (05_OB).exr
            "64a168db545e0e04996869f82146bed9", // Assets/VitDeck/Templates/05_OB/SharedAssets/Textures/Window_OB (05_OB).png
            "f4ed4145b1ecf4a46b86232357ef86e0", // Assets/VitDeck/Templates/05_OB/TemplateAssets
            "d42dcf0a986610c45bd70d31666badd1", // Assets/VitDeck/Templates/05_OB/TemplateAssets/{CIRCLEID}
            "d6d88d62f99e9824ab840ab9a37438a1", // Assets/VitDeck/Templates/05_OB/TemplateAssets/{CIRCLEID}/{CIRCLEID}.unity
            "e4397653007c8e04a9b1d2cef9fc2569", // Assets/VitDeck/Templates/06_CU
            "697e40182b23ec5438df19d99968880b", // Assets/VitDeck/Templates/06_CU/Property.asset
            "b5a3959fd0d42b441a3ec599fd80fe6b", // Assets/VitDeck/Templates/06_CU/SharedAssets
            "cdcfe54e9d836c5419f171e6e96cef1e", // Assets/VitDeck/Templates/06_CU/SharedAssets/Materials
            "c27995d2ec1d91c4fad8c606fd58062e", // Assets/VitDeck/Templates/06_CU/SharedAssets/Materials/Base (06_CU).mat
            "c7c4884ea07d1944ca9058d4abada62d", // Assets/VitDeck/Templates/06_CU/SharedAssets/Materials/House (06_CU).mat
            "fc1f9d78588b30240824855f51bb778f", // Assets/VitDeck/Templates/06_CU/SharedAssets/Materials/SampleBooth (06_CU).mat
            "d13e59c34e69ea1468bb6335f189dde6", // Assets/VitDeck/Templates/06_CU/SharedAssets/Materials/SkyBoxSample (06_CU).mat
            "614897018a50a21419ec6251e5622b2c", // Assets/VitDeck/Templates/06_CU/SharedAssets/Mesh
            "f03c7486f3d9ae6498c6157b922e868c", // Assets/VitDeck/Templates/06_CU/SharedAssets/Mesh/BoothMesh (06_CU).fbx
            "d2d337f2c4766bc4d872554158fcdce5", // Assets/VitDeck/Templates/06_CU/SharedAssets/Mesh/sample_culio (06_CU).fbx
            "668cbd1a8caaee34fb9ae7d03773a3d1", // Assets/VitDeck/Templates/06_CU/SharedAssets/Profile
            "6789f0c6811968b4db63c13735da1ab0", // Assets/VitDeck/Templates/06_CU/SharedAssets/Texture
            "b00e29d1cf467cb4ea802b600ff3949c", // Assets/VitDeck/Templates/06_CU/SharedAssets/Texture/Base (06_CU).png
            "134df50fb1dfe024f9f4d5ec21511ffb", // Assets/VitDeck/Templates/06_CU/SharedAssets/Texture/Base_n (06_CU).png
            "f87ef27d4c9be594aba7e4ef052e0c77", // Assets/VitDeck/Templates/06_CU/SharedAssets/Texture/Custom Reflection Probe (06_CU).exr
            "8b2cdb8037063674787f54fddfbbc2cd", // Assets/VitDeck/Templates/06_CU/SharedAssets/Texture/House (06_CU).png
            "e9121dfb8e5877e4cb0967576eb323c4", // Assets/VitDeck/Templates/06_CU/SharedAssets/Texture/House_e (06_CU).png
            "f630aa1bdf22f034192e15405bd66e88", // Assets/VitDeck/Templates/06_CU/SharedAssets/Texture/House_n (06_CU).png
            "6d66e2ca0c3ed82478a5299e1ccf8f13", // Assets/VitDeck/Templates/06_CU/SharedAssets/Texture/Skybox (06_CU).exr
            "e5e764909bfe04d46b524d0cbd41119a", // Assets/VitDeck/Templates/06_CU/TemplateAssets
            "e057b2818c426e54285f6b5c424011dc", // Assets/VitDeck/Templates/06_CU/TemplateAssets/{CIRCLEID}
            "e7552b4b3886ab04fa4204a60df17984", // Assets/VitDeck/Templates/06_CU/TemplateAssets/{CIRCLEID}/{CIRCLEID}.unity
            "0067e6b8b471c7149918be32ba542a52", // Assets/VitDeck/Templates/Paraket
            "c1cd65a3e050bcf468d51cca0de403eb", // Assets/VitDeck/Templates/Paraket/LICENSE.txt
            "258e405717667324d99644d3790fb537", // Assets/VitDeck/Templates/Paraket/Property.asset
            "7bd44c624c86dc841b36b92f3483ad4a", // Assets/VitDeck/Templates/Paraket/SharedAssets
            "a417d86c26c012d4390939b06dbca1a1", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource
            "a8a3b6b3b3cc4ba48933236c5be92e63", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/BoothTemplate
            "254334caffc0f4b45b12bc9aecb0d6e7", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/BoothTemplate/ArealGarden_Template.fbx
            "6ad23e3e4cd4d454083689964a4fbbbf", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material
            "f9e4309dc270cb44abb3dc842792212e", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/M_Emit_Yellow.mat
            "ed430a3ff3d5b8141add7489c9856c1a", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/M_Flat_Gray.mat
            "ee5aca6f67462084a8d2bc404db35a4f", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Skybox.mat
            "a0fd554ead96c1b48810de4d18577194", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Base_Ground
            "11c51bff8e1cf26479454d32fabf9da9", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Base_Ground/1K-sidewalk road-ao.jpg
            "0ad02f63cf9c96b4583f62e2b74df999", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Base_Ground/1K-sidewalk road-diffuse.jpg
            "26fe7a82340a3a64dba50e3e85287c4c", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Base_Ground/1K-sidewalk road-displacement.jpg
            "967684d50e8850f49aeffcda84bc5116", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Base_Ground/1K-sidewalk road-normal.jpg
            "89be481720b2372469d8a9612701a78a", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Base_Ground/1K-sidewalk road-specular.jpg
            "a3bb7f7e97154a54187b95dddaa9794f", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Base_Ground/M_Base_Ground.mat
            "344ba188c06d61747b302b00e02ab8e7", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Garden_Frame
            "36de9bc591b817d418893b0c75b14c92", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Garden_Frame/1K-metal_5-ao.jpg
            "c4e95532b710d8345a14ac9256614ec0", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Garden_Frame/1K-metal_5-diffuse.jpg
            "7dc8786d11b591c4a819225120e9c873", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Garden_Frame/1K-metal_5-displacement.jpg
            "453e2c713726ec5408bf0fce9e988c22", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Garden_Frame/1K-metal_5-normal.jpg
            "1745cd7cf30783f41a9a0dafb771f823", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Garden_Frame/1K-metal_5-specular.jpg
            "0d21d3e1ffb04e14391843f89a4b8bc5", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Garden_Frame/M_Garden_Frame.mat
            "bd4e49c2f4cccd146bfb28359e0a084a", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Port
            "632f2afdc8243c243a4b29c9b0dea0f7", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Port/1K-concrete_48_Base Color.jpg
            "54649a4e6f722b2498918ac9bd931e08", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Port/1K-concrete_48_Height.jpg
            "9bada19a6071d434cae981d79b8dd16e", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Port/1K-concrete_48_Metallic.jpg
            "3a41faea3cfdca94f8a6d821d736f5dd", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Port/1K-concrete_48_Normal.jpg
            "cc642ac4f79d9c44282b296404dbb006", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Port/1K-concrete_48_Roughness.jpg
            "de768dca4ae6ffa42a63313da4794c7a", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Material/Port/M_Port.mat
            "1ec9887ff0aa29b4ba068d7d38075222", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Texture
            "cb3a15c0314bc5e4d9929296742e2e42", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Texture/paraketskybox.png
            "6530bc19ecac1fe4e99d913465bbedbf", // Assets/VitDeck/Templates/Paraket/SharedAssets/Resource/Texture/Reflection Probe-reflectionHDR.exr
            "31521b4f017c81e40bfb37ca4e74c2bd", // Assets/VitDeck/Templates/Paraket/SharedAssets/SampleScene
            "1f2c039fa5a33c2428493d53221d50ea", // Assets/VitDeck/Templates/Paraket/SharedAssets/SampleScene/LightingData.asset
            "c1a3a97d87c16f74c9a2794c19b0700d", // Assets/VitDeck/Templates/Paraket/SharedAssets/SampleScene/Lightmap-0_comp_light.exr
            "aa944fbb5685eff4bb2566e792986da5", // Assets/VitDeck/Templates/Paraket/SharedAssets/SampleScene/ReflectionProbe-0.exr
            "3be49e662e32bfc4eac7523efc64e5c9", // Assets/VitDeck/Templates/Paraket/TemplateAssets
            "d6546d4c74cb5fa418eabbbc8fec2881", // Assets/VitDeck/Templates/Paraket/TemplateAssets/{CIRCLEID}
            "d05fc0b4c3bb69d4db7d153759c1201d", // Assets/VitDeck/Templates/Paraket/TemplateAssets/{CIRCLEID}/{CIRCLEID}.unity
            "d242a4f92aeef4c429139ddb80dcc19f", // Assets/VitDeck/Templates/Sample_template
            "2c5e4f38eb7e35447b696a1c5229aaff", // Assets/VitDeck/Templates/Sample_template/LICENSE.txt
            "7dd89a7a0282f5f47a7993cef0a7e413", // Assets/VitDeck/Templates/Sample_template/Property.asset
            "9c89912967f635245a18d69866287f6e", // Assets/VitDeck/Templates/Sample_template/SharedAssets
            "4046b15c4d594c145b559bddc1257413", // Assets/VitDeck/Templates/Sample_template/SharedAssets/NewSurfaceShader.shader
            "90823c296c5c82b47ae62f2bd463f4e7", // Assets/VitDeck/Templates/Sample_template/SharedAssets/Shared_asset_A.prefab
            "547616f7261fb4445bfb8af8686d6ccf", // Assets/VitDeck/Templates/Sample_template/SharedAssets/Shared_asset_A
            "1a82553471d99534ea32ddbbeecd1044", // Assets/VitDeck/Templates/Sample_template/SharedAssets/Shared_asset_A/Shared_asset.fbx
            "3c010df6cb2c96b4aaad25516d628e3b", // Assets/VitDeck/Templates/Sample_template/SharedAssets/Shared_asset_A/Shared_asset_material.mat
            "575fc205f75ed7849bacac6ff656c1dc", // Assets/VitDeck/Templates/Sample_template/SharedAssets/Shared_asset_A/Shared_asset_texture.png
            "548e4aa360685764e90ffccf7b4f56e0", // Assets/VitDeck/Templates/Sample_template/SharedAssets/Support_object
            "8b892c6f104b2c24c98896d5cec9aef9", // Assets/VitDeck/Templates/Sample_template/SharedAssets/Support_object/NotEditableComponent.cs
            "414c1e5eb90f7f143a52b2cdfda76d32", // Assets/VitDeck/Templates/Sample_template/SharedAssets/Support_object/ScaleLimitVisualizer.cs
            "a876d881254ac0e41abaff8a85963cc4", // Assets/VitDeck/Templates/Sample_template/SharedAssets/Support_object/Support_objects.prefab
            "9c3c47c1f0d34104caafe92b6bd9c70c", // Assets/VitDeck/Templates/Sample_template/TemplateAssets
            "54f6f1d6188943f4698ac936ce8f8920", // Assets/VitDeck/Templates/Sample_template/TemplateAssets/{BOOTHID}_{NAME}
            "e9ae1b5bb4d3c0241a5316d100606fc8", // Assets/VitDeck/Templates/Sample_template/TemplateAssets/{BOOTHID}_{NAME}/Sample_object_prefab.prefab
            "a88be259af1904b4f8d10d8ef441623c", // Assets/VitDeck/Templates/Sample_template/TemplateAssets/{BOOTHID}_{NAME}/Scene_{BOOTHID}_{NAME}.unity
            "f193afbf7be798246aa0c0bd2a3f6058", // Assets/VitDeck/Templates/Sample_template/TemplateAssets/{BOOTHID}_{NAME}/Animations
            "bc8fd7c341a098b4a9e852b9b5d61fb1", // Assets/VitDeck/Templates/Sample_template/TemplateAssets/{BOOTHID}_{NAME}/Animations/New Animation override.anim
            "e0a7817fcc107ef4d833feb56961d8de", // Assets/VitDeck/Templates/Sample_template/TemplateAssets/{BOOTHID}_{NAME}/Animations/New Animation.anim
            "00e7bd765877c1a4db82f3f66bb130b4", // Assets/VitDeck/Templates/Sample_template/TemplateAssets/{BOOTHID}_{NAME}/Animations/New Animator Controller.controller
            "64c00848704531c4392be4826faa4f75", // Assets/VitDeck/Templates/Sample_template/TemplateAssets/{BOOTHID}_{NAME}/Animations/New Animator Override Controller.overrideController
            "21ce9940c41d71a48b5ccbc1e0c88c50", // Assets/VitDeck/Templates/Sample_template/TemplateAssets/{BOOTHID}_{NAME}/EmptyFolder
            "6fc67e5f6016fb641b63de0e93340915", // Assets/VitDeck/Templates/Sample_template/TemplateAssets/{BOOTHID}_{NAME}/EmptyFolder/Dummy.asset
            "8c890c90df061854a8646387a7504468", // Assets/VitDeck/Templates/Sample_template/TemplateAssets/{BOOTHID}_{NAME}/Materials
            "e9115a14465af3541a37d00fd436469b", // Assets/VitDeck/Templates/Sample_template/TemplateAssets/{BOOTHID}_{NAME}/Materials/Sample Material.mat
            "3bcc760afcb0523468eed4f6f9a1a7e1", // Assets/VitDeck/Templates/Sample_template/TemplateAssets/{BOOTHID}_{NAME}/Materials/Sample Texture.png
            "a6d9197ffc5e9e646a00b969d5ffb83f", // Assets/VitDeck/Templates/Sample_template/TemplateAssets/{BOOTHID}_{NAME}/Models
            "bcb0f116dd2863a44a4c098e70c44d52", // Assets/VitDeck/Templates/Sample_template/TemplateAssets/{BOOTHID}_{NAME}/Models/Sample_object.fbx
            "35a7063c429f77944ae538a227584150", // Assets/VitDeck/Temporary
            "6e2c1cbdc697fc34ab3689dba6b276bb", // Assets/VitDeck/TestUtilities
            "b7fc1a9a2e9bb5e4c96c36f953f3c167", // Assets/VitDeck/TestUtilities/TestAssets.cs
            "6e3cad17f0949f6478dde55f7b37ff8d", // Assets/VitDeck/TestUtilities/TestDataBinary.cs
            "321485694770a1e47afefcccb0016cf8", // Assets/VitDeck/TestUtilities/TestScriptableObject.cs
            "dff7b6902afdf3e42bf5e9e0c8429a63", // Assets/VitDeck/TestUtilities/VitDeck.TestUtilities.asmdef
            "594ad1edb507a424894fe8f68b0be8c6", // Assets/VitDeck/TestUtilities/Data
            "574d9f0da0ccfb24e971d8ae0632fa97", // Assets/VitDeck/TestUtilities/Data/Test AnimatorController.controller
            "f71da37437cb3564ab53c58fa950cddb", // Assets/VitDeck/TestUtilities/Data/Test Audio Mixer.mixer
            "d43eb4f798e4e94438249508b66b8599", // Assets/VitDeck/TestUtilities/Data/Test Audio.mp3
            "810d5b20305b9864c8d5167e6485e982", // Assets/VitDeck/TestUtilities/Data/Test AvatarMask.mask
            "c526bc5389b918e4680160cad61ca7fe", // Assets/VitDeck/TestUtilities/Data/Test ComputeShader.compute
            "692c60c32108e5849a3c2d2eb526950f", // Assets/VitDeck/TestUtilities/Data/Test Mesh.obj
            "a849df7577b026b4f91b20374cfb7af2", // Assets/VitDeck/TestUtilities/Data/Test Model.fbx
            "7e4a0173054431443bf66723bbc5dd86", // Assets/VitDeck/TestUtilities/Data/Test Movie.mp4
            "51600e88e661910449e9fdd6a8360200", // Assets/VitDeck/TestUtilities/Data/Test Red Mat.mat
            "3067020020284954e8c7bad8122d1d81", // Assets/VitDeck/TestUtilities/Data/Test Scene.unity
            "3981485c20638df418ea7d513c88bf50", // Assets/VitDeck/TestUtilities/Data/Test Sprite.png
            "b25adebe5dc746a419b115e1297c0207", // Assets/VitDeck/TestUtilities/Data/Test Text.txt
            "7cc37885cb4f02544bccc6a0012ed79a", // Assets/VitDeck/TestUtilities/Data/Test Texture.png
            "c4457ffd16f525c4ea4058e4915638e2", // Assets/VitDeck/TestUtilities/Data/Test Scene
            "0b51ba421c514a04db430ad7fb6c18d6", // Assets/VitDeck/TestUtilities/Data/Test Scene/LightingData.asset
            "0903a27fd1df65942a1a6e82c2288414", // Assets/VitDeck/TestUtilities/Data/Test Scene/Lightmap-0_comp_dir.png
            "7089e85d965cb5149a83f9fd15e52c59", // Assets/VitDeck/TestUtilities/Data/Test Scene/Lightmap-0_comp_light.exr
            "fb925b90dc0819342b868080dc34ad5a", // Assets/VitDeck/TestUtilities/Data/Test Scene/ReflectionProbe-0.exr
            "d83b0a62cba4afa49aa9f0f3f7d6bdb3", // Assets/VitDeck/TestUtilities/Data/Test Scene/ReflectionProbe-1.exr
            "97499241808a5034b9aede7af3a85ea9", // Assets/VitDeck/Utilities
            "0ecd76fc15c7d9e4a9cb914c3df5f3d9", // Assets/VitDeck/Utilities/AssetUtility.cs
            "6c47ed5ff11a99843a75040c7c71c167", // Assets/VitDeck/Utilities/CSVParser.cs
            "560bfb9a9792128439419aa00cbb1caf", // Assets/VitDeck/Utilities/CustomGUILayout.cs
            "c4550f07ff52422468421d773560bbc5", // Assets/VitDeck/Utilities/Deconstruction.cs
            "fdbc493497aafae4889950c933ab3f06", // Assets/VitDeck/Utilities/GUIDEnumerator.cs
            "41437640cbfab4a40b9a3cd78700bd06", // Assets/VitDeck/Utilities/IOUtility.cs
            "10fcf6b061271b34095fa1524c694d51", // Assets/VitDeck/Utilities/MathUtility.cs
            "a424079e73ca2ce4e91c6c9f0d62cf81", // Assets/VitDeck/Utilities/ProductInfo.cs
            "09871b0cfb14d49458f96dcf00e77cc5", // Assets/VitDeck/Utilities/ProductInfoUtility.cs
            "390665e461163974884788f39f541380", // Assets/VitDeck/Utilities/ProductSettings.cs
            "9457a8d05da373b4b96b87e1f3d97b84", // Assets/VitDeck/Utilities/ProjectSettings.cs
            "71f92a35df2e4af478028e7848da0bbc", // Assets/VitDeck/Utilities/SettingUtility.cs
            "40e62f79653477c44a449d2b3c4684ab", // Assets/VitDeck/Utilities/SIReadableNumberText.cs
            "b6ab8f4c212fee343a1a37f2c1e606fa", // Assets/VitDeck/Utilities/UnityEditorUtility.cs
            "3e443a2628bb2e843a1f67be9a15f633", // Assets/VitDeck/Utilities/URLUtility.cs
            "83709077c9abd5041ae517cd48be1c9f", // Assets/VitDeck/Utilities/UserSettings.cs
            "b921f40c1e696ff43b28e8fed5801326", // Assets/VitDeck/Utilities/VitDeck.Utilities.asmdef
            "730d358ee3e0ab84ba699fd5698f93da", // Assets/VitDeck/Utilities/Tests
            "5e0b37ab062e20d4fb6549901641de32", // Assets/VitDeck/Utilities/Tests/AssetUtilityTest.cs
            "62a63686928cfc54e9c05e9d5b8ee21f", // Assets/VitDeck/Utilities/Tests/ProductInfoUtilityTest.cs
            "4eb6b8e2c175d884fb8a46cc5af8a5ae", // Assets/VitDeck/Utilities/Tests/SIReadableNumberTextTest.cs
            "75fa601c99592104eb5ea69f641b73a7", // Assets/VitDeck/Utilities/Tests/URLUtilityTest.cs
            "8570a80239f7781498e53307ce86ef89", // Assets/VitDeck/Utilities/Tests/VitDeck.Utilities.Tests.asmdef
            "6ff10c0aea9b42d4abd7568d07bf81d6", // Assets/VitDeck/Validator
            "219765037bac0fb4aa007ae5ef25331b", // Assets/VitDeck/Validator/Validator.cs
            "578ed3dd1675a3a418654c5ead6a7f73", // Assets/VitDeck/Validator/VitDeck.Validator.asmdef
            "eeadae5ea53f7d74fa7eb0be94c5fac6", // Assets/VitDeck/Validator/Components
            "b966bc02a75c0d6479f73aeb4a1d8c66", // Assets/VitDeck/Validator/Components/FatalValidationErrorException.cs
            "8f5823958f6133544bc6f71c7af052f0", // Assets/VitDeck/Validator/Components/IRule.cs
            "64fc0343f10cbb041951352bfdaf6cf3", // Assets/VitDeck/Validator/Components/IRuleSet.cs
            "4127ad6201a6a1646bd785812f20ef26", // Assets/VitDeck/Validator/Components/Issue.cs
            "2b17812c96b317b4084724312e0142b0", // Assets/VitDeck/Validator/Components/IValidationTargetFinder.cs
            "2ba2b14496da0404cb6dcf6033563b0b", // Assets/VitDeck/Validator/Components/ValidationAttribute.cs
            "4b476ce0d21797146b922db1475ec37a", // Assets/VitDeck/Validator/Components/ValidationResult.cs
            "ca42b8add57cb6e40bc46b51d84a6837", // Assets/VitDeck/Validator/Components/ValidationTarget.cs
            "8724b5dbe1aee464e916f6cee37b0c18", // Assets/VitDeck/Validator/Components/ValidationTargetFinder.cs
            "681f9e21762d829448c510a8e57609f7", // Assets/VitDeck/Validator/Components/VitDeck.Validator.Components.asmdef
            "cdf087e77a5746a4cb34d06c80f95568", // Assets/VitDeck/Validator/GUI
            "761cabe19276fb34c92436b7e04e676f", // Assets/VitDeck/Validator/GUI/ValidatorGUI.cs
            "15668d47acad7384c803b48459e4a57d", // Assets/VitDeck/Validator/GUI/VitDeck.Validator.GUI.asmdef
            "b29213cc72fdad34792aaa2c1f321d82", // Assets/VitDeck/Validator/Rules
            "3b9e6c0bdd2c8f84eab2eb79011c00e2", // Assets/VitDeck/Validator/Rules/BaseRule.cs
            "6f5950649e8749c44a52b8dfd28ce066", // Assets/VitDeck/Validator/Rules/BaseRuleSet.cs
            "c65a8d4e037a1ea4f86eef76259f3452", // Assets/VitDeck/Validator/Rules/VitDeck.Validator.Rules.asmdef
            "0db1f38415f631b4a9bd367700a9dec8", // Assets/VitDeck/Validator/Rules/Asset
            "4a05d02567178f14b94303c14c55fe62", // Assets/VitDeck/Validator/Rules/Asset/AllowedExtensionsForExportRule.cs
            "891a8db77a1dddb45b5c832b3293ea56", // Assets/VitDeck/Validator/Rules/Asset/AssetExtentionBlacklistRule.cs
            "ff86afac766b83d4bab9fb6b283591f0", // Assets/VitDeck/Validator/Rules/Asset/AssetGuidBlacklistRule.cs
            "188214825eecdca4ba7e90f5a45c03df", // Assets/VitDeck/Validator/Rules/Asset/AssetNamingRule.cs
            "6445fd215e724814f9f5dc9bf8a629e6", // Assets/VitDeck/Validator/Rules/Asset/AssetPathLengthRule.cs
            "61dfa0be434bf8e428d1e1b4ef3f789f", // Assets/VitDeck/Validator/Rules/Asset/AssetTypeLimitRule.cs
            "006f7e26b0f88804d88a3c519025154f", // Assets/VitDeck/Validator/Rules/Asset/BaseFolderPathRule.cs
            "b9cf22191a5440a419f5f1407be105ee", // Assets/VitDeck/Validator/Rules/Asset/ContainMatOrTexInAssetRule.cs
            "7b059b458ac1200459c5f829f72322c1", // Assets/VitDeck/Validator/Rules/Asset/ExistInSubmitFolderRule.cs
            "3d1ca934284caf445874eb58787f05b5", // Assets/VitDeck/Validator/Rules/Asset/FolderSizeRule.cs
            "2f7a81ff01d9eca46ba21a85cd343f18", // Assets/VitDeck/Validator/Rules/Booth
            "4d9a9bffa9b484445834900967460471", // Assets/VitDeck/Validator/Rules/Booth/BoothBoundsRule.cs
            "1c619dd56904f004393087b28abf8105", // Assets/VitDeck/Validator/Rules/Booth/ComponentBlacklistRule.cs
            "ebc4c5559e7406e4e9d8a497f5bffd71", // Assets/VitDeck/Validator/Rules/Booth/ComponentReference.cs
            "6471c5681864ba645ab340a9e388acc9", // Assets/VitDeck/Validator/Rules/Booth/ComponentWhitelistRule.cs
            "09d992155ae59f542b1dbdce2feb3fc2", // Assets/VitDeck/Validator/Rules/Booth/ErrorShaderRule.cs
            "495dd6c08e9c0c34ba2ea92acba875eb", // Assets/VitDeck/Validator/Rules/Booth/ExhibitStructureRule.cs
            "5d7e72fd3e23e44448b38a1896eca225", // Assets/VitDeck/Validator/Rules/Booth/MissingFinder.cs
            "b3ff40593d0d3b8419a7d5c1b73c6a9c", // Assets/VitDeck/Validator/Rules/Booth/MissingReferenceRule.cs
            "5ded8acf6e7b1024f833d87a201534bd", // Assets/VitDeck/Validator/Rules/Booth/NoneMeshRule.cs
            "d728d5b0fac5a2b42a1f9dc46d18a059", // Assets/VitDeck/Validator/Rules/Booth/SceneStructureRule.cs
            "f22011e3f22fdff48b0bd1fa6fd95ae5", // Assets/VitDeck/Validator/Rules/Booth/ShaderWhitelistRule.cs
            "e8c5d01e9f62d5d4aa8e37f9b7229035", // Assets/VitDeck/Validator/Rules/Booth/StaticFlagRule.cs
            "42addbabc5cf2b94ca8eb0ff9bbad30e", // Assets/VitDeck/Validator/Rules/Component
            "b1c518b4eba6b47438c658288291bc80", // Assets/VitDeck/Validator/Rules/Component/AnimationClipRule.cs
            "63c9bae9bc2202245a6fb85648906279", // Assets/VitDeck/Validator/Rules/Component/AnimationComponentRule.cs
            "555a89d1049c32d4e99a7cc439d77142", // Assets/VitDeck/Validator/Rules/Component/AnimationMakesMoveCollidersRule.cs
            "deb1cb8e483e5b2469941a64a1225e06", // Assets/VitDeck/Validator/Rules/Component/AnimatorComponentMaxCountRule.cs
            "2f0eae6aca675624ba896c5e1a21a5d2", // Assets/VitDeck/Validator/Rules/Component/AnimatorComponentRule.cs
            "2b329f5343f5f9e4faf25d816cfb461a", // Assets/VitDeck/Validator/Rules/Component/AudioSourcePrefabRule.cs
            "c22157519f5a8c64b885018a4c89e181", // Assets/VitDeck/Validator/Rules/Component/AvatarPedestalPrefabRule.cs
            "6cf9e5e0d34fff04fb6df64c269f0f9a", // Assets/VitDeck/Validator/Rules/Component/BasePrefabRule.cs
            "c7523e0435583dd48ac91e395128f6b7", // Assets/VitDeck/Validator/Rules/Component/CameraComponentMaxCountRule.cs
            "4927e9e69ff44d043bc590f4b3eeab84", // Assets/VitDeck/Validator/Rules/Component/CameraComponentRule.cs
            "1a42bf85dc6c2454cb15bf1a51116054", // Assets/VitDeck/Validator/Rules/Component/CanvasRenderModeRule.cs
            "ff1972c63cab7d849b4381bbda7a5aab", // Assets/VitDeck/Validator/Rules/Component/ComponentBaseRule.cs
            "cff8dcf4c1366c14ab61206c43e1de50", // Assets/VitDeck/Validator/Rules/Component/GlobalIlluminationBakedRule.cs
            "58a5a58d7c8f18843a97e38cbbec5369", // Assets/VitDeck/Validator/Rules/Component/LightConfigRule.cs
            "a0c3248093d4a3147ad12afde5250f0d", // Assets/VitDeck/Validator/Rules/Component/LightCountLimitRule.cs
            "094177ff85b5ab8429f6b6e983d67c3a", // Assets/VitDeck/Validator/Rules/Component/LightmapSizeLimitRule.cs
            "49beb0703f1f7844892e5c34b1c1464e", // Assets/VitDeck/Validator/Rules/Component/MeshRendererRule.cs
            "c285d56b32134ef4a97f90a754c31dce", // Assets/VitDeck/Validator/Rules/Component/ObjectDetector.cs
            "2b1bdea6c7a995242b1fb171828d11f0", // Assets/VitDeck/Validator/Rules/Component/PrefabLimitRule.cs
            "1666752c5442c4b45bf640eaeabdc581", // Assets/VitDeck/Validator/Rules/Component/ProjectorComponentMaxCountRule.cs
            "d2b8ec6aeff404948942303c4783db66", // Assets/VitDeck/Validator/Rules/Component/ProjectorComponentRule.cs
            "0a0ecebe6f64fa7499bf3ba4d58d02cc", // Assets/VitDeck/Validator/Rules/Component/ReflectionProbeRule.cs
            "2beefec2b283b1146983dbbb7da37ccf", // Assets/VitDeck/Validator/Rules/Component/RigidbodyRule.cs
            "cac76c129e0448b428d23a6bb81aa967", // Assets/VitDeck/Validator/Rules/Component/SkinnedMeshRendererRule.cs
            "acf31a000d7db1f48a61275e3f8c8607", // Assets/VitDeck/Validator/Rules/Component/UsableComponentListRule.cs
            "4dcfe8c348e72f941b20c7aac1a078e7", // Assets/VitDeck/Validator/Rules/Component/UseLightModeRule.cs
            "81e7d14723c59354b98c027e3284ebd8", // Assets/VitDeck/Validator/Rules/Component/UseMeshColliderRule.cs
            "c81fb46a5f77aa64bbd4b21643ee13a7", // Assets/VitDeck/Validator/Rules/Component/VideoPlayerComponentMaxCountRule.cs
            "6365aa4cc0200dc4aa08307b44770749", // Assets/VitDeck/Validator/Rules/Component/VideoPlayerComponentRule.cs
            "d3cd5c6d3cbd4cf4ab3c6a15fe77b68e", // Assets/VitDeck/Validator/Rules/Debug
            "080a790812c18a143ab6afab73eced33", // Assets/VitDeck/Validator/Rules/Debug/DebugTargetEnumerationRule.cs
            "2504dfdaf58446e4c9a1a1fa9de0535f", // Assets/VitDeck/Validator/Rules/Paraket
            "a42cd86d0e2bd654c947d054081bf52c", // Assets/VitDeck/Validator/Rules/Paraket/ParaketOfficialAssetData.cs
            "77c9345983fbcb84cab24469d4575d1a", // Assets/VitDeck/Validator/Rules/Paraket/ParaketRuleSet.cs
            "e6bb049eaa11f9548b32c371ebacae45", // Assets/VitDeck/Validator/Rules/Sample
            "6f7defc41e40a9744ab5fd7a9bc16675", // Assets/VitDeck/Validator/Rules/Sample/SampleRule.cs
            "f331eff3d9a13494484ef0725f5cdf00", // Assets/VitDeck/Validator/Rules/Sample/SampleRuleSet.cs
            "92816084f3504e839162afcb8cbaa55d", // Assets/VitDeck/Validator/Rules/UdonSharp
            "9fedbe60792c44758cabd3b76533d136", // Assets/VitDeck/Validator/Rules/UdonSharp/UdonSharpScriptNamespaceRule.cs
            "c56dee10e7abe484cbed29882c4f8f74", // Assets/VitDeck/Validator/Rules/Unity
            "ca4f2238e8cb7634f881d8fc5dcd7a03", // Assets/VitDeck/Validator/Rules/Unity/PostProcessingExistsRule.cs
            "af0f91ea9bdc6b14c97b76abc958695b", // Assets/VitDeck/Validator/Rules/Unity/UnityVersionRule.cs
            "bb5c957373c5d4f43b11962fced12a6d", // Assets/VitDeck/Validator/Rules/VitDeck
            "8765948164b962941a4835409069c6aa", // Assets/VitDeck/Validator/Rules/VitDeck/VitDeckVersionRule.cs
            "5ef6a0bf04447fa49bca2ca6adc59ceb", // Assets/VitDeck/Validator/Rules/Vket
            "4cb1943811dc0c1468fead24fdf41019", // Assets/VitDeck/Validator/Rules/Vket/AvatarShowcaseRuleSet.cs
            "0c0d4f2ece739f146a25ce531c12b78c", // Assets/VitDeck/Validator/Rules/Vket/ConceptWorldRuleSet.cs
            "05276471239681045b512fe71c93ba90", // Assets/VitDeck/Validator/Rules/Vket/DefaultCubeRuleSet.cs
            "3a220028667e4156947cb96f09fc3a4b", // Assets/VitDeck/Validator/Rules/Vket/ReadonlyReferenceDictionary.cs
            "77c17b30dba105b4e92add1bbcec30f6", // Assets/VitDeck/Validator/Rules/Vket/UnityObjectReferenceChain.cs
            "7c7132dd8bab8c0468d12324fc7f8e5c", // Assets/VitDeck/Validator/Rules/Vket/VketOfficialAssetData.cs
            "56df3a949ea4da34b8c77cf994c7632e", // Assets/VitDeck/Validator/Rules/Vket/VketRuleSetBase.cs
            "9c8540c05516e204592021a50fa43766", // Assets/VitDeck/Validator/Rules/Vket/VketTargetFinder.cs
            "c3bd1912061d6184ab90c8831bb9dfb1", // Assets/VitDeck/Validator/Rules/VketUdon
            "05fa89d79a3f6b44d9a1636ed42f7008", // Assets/VitDeck/Validator/Rules/VketUdon/UdonCubeRuleSet.cs
            "e6389f6b387f48bbb09ff23cbb4def2b", // Assets/VitDeck/Validator/Rules/VketUdon/VketUdonOfficialAssetData.cs
            "dd39a380e32846cbb558d352d97ee7ca", // Assets/VitDeck/Validator/Rules/VketUdon/VketUdonRuleSetBase.cs
            "362ba3a27cdf7fd4bad64d1fdccd6b0e", // Assets/VitDeck/Validator/Rules/VRCSDK
            "0bfd00815bb17f7418e7f02732e581f9", // Assets/VitDeck/Validator/Rules/VRCSDK/InvalidVersionFormatException.cs
            "a02f7d0a5d835ac448f720fa25175f1f", // Assets/VitDeck/Validator/Rules/VRCSDK/IVersion.cs
            "bf5c2b78a0d45a04198949d30f082a3b", // Assets/VitDeck/Validator/Rules/VRCSDK/VRCSDKVersion.cs
            "fcf7f744612cca14e91b6f4d920e8795", // Assets/VitDeck/Validator/Rules/VRCSDK/VRCSDKVersionRule.cs
            "948694066692a1747ba11772a634bdd1", // Assets/VitDeck/Validator/Rules/VRCSDK2
            "9a116c38207b294418b15fec79425f01", // Assets/VitDeck/Validator/Rules/VRCSDK2/PickupObjectSyncPrefabRule.cs
            "e8821923114072c4190431c9f2a65a98", // Assets/VitDeck/Validator/Rules/VRCSDK2/VRCTriggerConfigRule.cs
            "b887b44702ca4464faf9e165ecc2dd3f", // Assets/VitDeck/Validator/Rules/VRCSDK2/VRCTriggerCountLimitRule.cs
            "88c2ec8a741842158308f27c6870a3c4", // Assets/VitDeck/Validator/Rules/VRCSDK3
            "c7cf65dd71864cb5adf2e902487573fc", // Assets/VitDeck/Validator/Rules/VRCSDK3/BaseUdonBehaviourRule.cs
            "91a4ed5c8aaf432b91b315473c3bb32b", // Assets/VitDeck/Validator/Rules/VRCSDK3/UdonAsesemblyFunctionEssentialArgumentReference.cs
            "625764a8e2f54a30a4dd8a28f6801d70", // Assets/VitDeck/Validator/Rules/VRCSDK3/UdonAsesemblyReference.cs
            "768a3779e2264158b71a775d3a65b19e", // Assets/VitDeck/Validator/Rules/VRCSDK3/UdonAssemblyPhysicsCastFunctionRule.cs
            "9a3a99a7cafb47928043d71e1aa6d32c", // Assets/VitDeck/Validator/Rules/VRCSDK3/UdonBehaviourAllowOwnershipTransferOnCollisionIsFalseRule.cs
            "4eedad98e3774286ab6267245162894d", // Assets/VitDeck/Validator/Rules/VRCSDK3/UdonBehaviourLayerConstraintRule.cs
            "3b7d397fcab946deb948b0896fa15bc1", // Assets/VitDeck/Validator/Rules/VRCSDK3/UdonBehaviourSyncedVariablesRule.cs
            "b399693fd69c4f0d98f3d2afc7decdb7", // Assets/VitDeck/Validator/Rules/VRCSDK3/UdonBehaviourSynchronizePositionCountLimitRule.cs
            "ead32a66f2284f5aae4a833cad0d2cf3", // Assets/VitDeck/Validator/Rules/VRCSDK3/UdonDynamicObjectInactiveRule.cs
            "e10ae07ae3d44fbc8d230a6bf381a26d", // Assets/VitDeck/Validator/Rules/VRCSDK3/UdonDynamicObjectParentRule.cs
            "ecf6c825151641b981cb88a51c725dcc", // Assets/VitDeck/Validator/Rules/VRCSDK3/UsableUdonAssemblyListRule.cs
            "e8c608e58fed480ab846b84850ede268", // Assets/VitDeck/Validator/Rules/VRCSDK3/VRCPickupUdonBehaviourRule.cs
            "410fdc4dd87240ec845667aac3a68fb6", // Assets/VitDeck/Validator/Rules/VRCSDK3/VRCSpatialAudioSourceDynamicObjectParentRule.cs
            "c2595fa206fe432bb21565aeb5a99d45", // Assets/VitDeck/Validator/Rules/VRCSDK3/VRCStationCountLimitRule.cs
            "c3409bd7c506c5b429419c6736050d13", // Assets/VitDeck/Validator/Runtime
            "302dedb10dfafbc4890a8bb3a14666c6", // Assets/VitDeck/Validator/Runtime/VitDeck.Validator.Runtime.asmdef
            "8436687e4350b9548af4bf98829a922e", // Assets/VitDeck/Validator/Runtime/BoundsIndicators
            "6ca6388f2eb7b124c9822f0ec18507ee", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/BoothRangeIndicator.cs
            "61a91fd6b14a4c74d8def021d6ac569b", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/BoundsRangeOutIndicator.cs
            "087a446a9975ddb46a8258b730da5b4a", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/ColliderBoundsSource.cs
            "ff83b2b8a00549b44917c8d655d8d986", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/IBoothBoundsProvider.cs
            "fd2ce3eee33700a41882b61a9f0ab570", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/IBoundsSource.cs
            "0f7ad65a7e2041b2bb8c4f9c33a5f87b", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/IMeshLocalBoundsProvider.cs
            "d94df5fc33543984b847883374ecd8f6", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/LightProbeBoundsSource.cs
            "6bd3fe856f374b3b9eb59192b0cadf0f", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/MeshFilterLocalBoundProvider.cs
            "934a5f28e95c42347b819e98e4da1030", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/RectTransformRangeOutIndicator.cs
            "98a472ef355204d4bb8ea4843d56ca71", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/RendererBoundsSource.cs
            "ed421118c3b307d45a120e16c922b98a", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/ResetToken.cs
            "1aa83c466a8ea1e4ba2e7f307c221a3f", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/ResetTokenSource.cs
            "53967ee69b2a4ebb8ac928d4e5c65337", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/SkinnedMeshRendererLocalBoundsProvider.cs
            "4919afe7ffcff8544bc0a71dc7451fc5", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/TransformMemory.cs
            "af1597e2617a95e4a9d30a3020a864ee", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/TransformRangeOutIndicator.cs
            "bd1301153fbb80c438fa49a43a95def8", // Assets/VitDeck/Validator/Tests
            "65fe3754a2cb7e84bb4665d593848911", // Assets/VitDeck/Validator/Tests/TestAnimationClipRule.cs
            "e6e8521fc8864b1438adc216488f2e46", // Assets/VitDeck/Validator/Tests/TestAnimationComponentRule.cs
            "bc0c87df8f690da4aa0955d7f87d13d2", // Assets/VitDeck/Validator/Tests/TestAnimationMakesMoveCollidersRule.cs
            "d76117ef2ce100c4e92bb5424fb49539", // Assets/VitDeck/Validator/Tests/TestAnimatorComponentMaxCountRule.cs
            "b504a07392b5284419b83ebac3eb75bb", // Assets/VitDeck/Validator/Tests/TestAnimatorComponentRule.cs
            "3311924d4ab762442a4ae21e9de96ccd", // Assets/VitDeck/Validator/Tests/TestAssetExtentionBlacklistRule.cs
            "d5066a4ee1ccb5e489995bb9fa44c581", // Assets/VitDeck/Validator/Tests/TestAssetGuidBlacklistRule.cs
            "8ded05da957f20d49a043f16e0e81b10", // Assets/VitDeck/Validator/Tests/TestAssetNamingRule.cs
            "74a7d7b161582c14ba1bb47812aae182", // Assets/VitDeck/Validator/Tests/TestAssetPathLengthRule.cs
            "9e3f6b8a9c6f92c43b4ba6ba76918e18", // Assets/VitDeck/Validator/Tests/TestAudioSourceRule.cs
            "d7c23913ea8a08441a2d71c1b7554771", // Assets/VitDeck/Validator/Tests/TestBoothBoundsRule.cs
            "fad83b70978112c40a43a496ee012576", // Assets/VitDeck/Validator/Tests/TestCanvasRenderModeRule.cs
            "61c59e181f521054fb52653d8142f392", // Assets/VitDeck/Validator/Tests/TestComponentBlacklistRule.cs
            "11734a6098a2eec42994b832f2252d09", // Assets/VitDeck/Validator/Tests/TestComponentWhitelistRule.cs
            "33f6621c35667714197c1d0f607cc674", // Assets/VitDeck/Validator/Tests/TestContainMatOrTexInAssetRule.cs
            "e4429aa77a810ae4b8355e8032ece5b3", // Assets/VitDeck/Validator/Tests/TestErrorShaderRule.cs
            "d5cd2335c326eee4fb5d2a1143974ff3", // Assets/VitDeck/Validator/Tests/TestFolderSizeRule.cs
            "0fae7748fab5e6a4582fa850014390f3", // Assets/VitDeck/Validator/Tests/TestGlobalIlluminationBakedRule.cs
            "f3322dee51158f04cbbea9b84ac770d3", // Assets/VitDeck/Validator/Tests/TestLightConfigRule.cs
            "eff6bd60eafc7014f981c52bf3ba621a", // Assets/VitDeck/Validator/Tests/TestLightCountLimitRule.cs
            "0041c54f09589624194b22e7575881d0", // Assets/VitDeck/Validator/Tests/TestMissingReferenceRule.cs
            "a6f13721c2dc9fe4098aeb90c650d7fc", // Assets/VitDeck/Validator/Tests/TestNoneMeshRule.cs
            "308a806c88627cd46bb8b989c12589d4", // Assets/VitDeck/Validator/Tests/TestPrefabLimitRule.cs
            "e35d79d4276c8af4bbd2c4e69226ad6e", // Assets/VitDeck/Validator/Tests/TestPrefabPartsDetector.cs
            "8c9bbcfa20246cf4dbdaa75f0735457d", // Assets/VitDeck/Validator/Tests/TestResetTokenSource.cs
            "d3039e3fb5efb4f4aa91293da77c369b", // Assets/VitDeck/Validator/Tests/TestTransformMemory.cs
            "e024028b83118f747b8746bd7f1e8f88", // Assets/VitDeck/Validator/Tests/TestUnityVersionRule.cs
            "c678cd2b4d001564e92efbc25823c3da", // Assets/VitDeck/Validator/Tests/TestUsableComponentListRule.cs
            "3aa63f31f937b1e45b6c046736a0ab0f", // Assets/VitDeck/Validator/Tests/TestUseLightModeRule.cs
            "42200c20e1dfce54aa4aebfd4098704a", // Assets/VitDeck/Validator/Tests/TestUseMeshColliderRule.cs
            "06f685732685ac34abd881ea51000010", // Assets/VitDeck/Validator/Tests/TestValidationTargetFinder.cs
            "36f9ca46998fbfc408390f5aa93b9874", // Assets/VitDeck/Validator/Tests/TestValidator.cs
            "76e56327b16d52c4aaf2ff1997f36e5d", // Assets/VitDeck/Validator/Tests/TestVRCTriggerConfigRule.cs
            "f69da9668e76c91469be5257316e50aa", // Assets/VitDeck/Validator/Tests/TestVRCTriggerCountLimitRule.cs
            "c21e7b5a18120374bb35be6707b61d64", // Assets/VitDeck/Validator/Tests/VitDeck.Validator.Tests.asmdef
            "9757dc5ff3ca11a43971985765278089", // Assets/VitDeck/Validator/Tests/VRCSDKVersionTest.cs
            "52ceae726485ef84c95fddf9d8b2dea8", // Assets/VitDeck/Validator/Tests/Data
            "90861ee8eb227f344b1414ebfc893ec3", // Assets/VitDeck/Validator/Tests/Data/AnimationClipRule
            "9d1e640a1508494459090fb0159f5d60", // Assets/VitDeck/Validator/Tests/Data/AnimationClipRule/AnimationClipRule.unity
            "4e7445534a7a79d48a48ec25084d94cb", // Assets/VitDeck/Validator/Tests/Data/AnimationClipRule/TestAnimatorController.controller
            "4141d91b93082d44f83d3fe8c78a00b6", // Assets/VitDeck/Validator/Tests/Data/AnimationClipRule/TestMateralChangeAnimation.anim
            "413b5b42977f82948a7ba510fef67214", // Assets/VitDeck/Validator/Tests/Data/AnimationClipRule/TestParentItemAnimation.anim
            "f7b30f229c70d594889c1258a7ed6dbf", // Assets/VitDeck/Validator/Tests/Data/AnimationComponentRule
            "69a1e04beac6f234da941ab826cf1d86", // Assets/VitDeck/Validator/Tests/Data/AnimationComponentRule/DisableAlwaysAnimate
            "05f39ca7791fd1f47ac2f37fd5d32263", // Assets/VitDeck/Validator/Tests/Data/AnimationComponentRule/DisableAlwaysAnimate/DisableAlwaysAnimate.unity
            "4546419e9c1dcaf4f98789a633ead806", // Assets/VitDeck/Validator/Tests/Data/AnimationComponentRule/EnableAlwaysAnimate
            "db08d3ae86efa1c4cba3c46c31514400", // Assets/VitDeck/Validator/Tests/Data/AnimationComponentRule/EnableAlwaysAnimate/EnableAlwaysAnimate.unity
            "bb79bad826c33f24fa505f2558ddc10a", // Assets/VitDeck/Validator/Tests/Data/AnimationMakesMoveCollidersRule
            "215729aa792d83e4697a0b09efd4db2a", // Assets/VitDeck/Validator/Tests/Data/AnimationMakesMoveCollidersRule/AnimationMakesMoveCollidersRule.unity
            "91f21ab3f5ef2b940b31c56cda1b11f2", // Assets/VitDeck/Validator/Tests/Data/AnimationMakesMoveCollidersRule/TestAnimationController.controller
            "89c8d3af2eed78c438f66a9d39b0bed1", // Assets/VitDeck/Validator/Tests/Data/AnimationMakesMoveCollidersRule/TestAnimationOverrideController.overrideController
            "067331d82ccdd7148ad52c843daaa523", // Assets/VitDeck/Validator/Tests/Data/AnimationMakesMoveCollidersRule/TestBlendingAnimationController.controller
            "1855ef145e1deab45af4507deb6a9c17", // Assets/VitDeck/Validator/Tests/Data/AnimationMakesMoveCollidersRule/TestLayeredAnimationController.controller
            "56b807cc336170947997b75668cb8716", // Assets/VitDeck/Validator/Tests/Data/AnimationMakesMoveCollidersRule/TestMoveClip.anim
            "d93cf4b3b45a2f048b5790bf439ef46a", // Assets/VitDeck/Validator/Tests/Data/AnimationMakesMoveCollidersRule/TestMoveClipForOverride.anim
            "737aefe902f7ed4488004f66a1a4cb08", // Assets/VitDeck/Validator/Tests/Data/AnimationMakesMoveCollidersRule/TestNoConnectedAnimationController.controller
            "e72fe887a508b9547bf2490cd1a0e943", // Assets/VitDeck/Validator/Tests/Data/AnimationMakesMoveCollidersRule/TestSubStateAnimationController.controller
            "551cf5559b9f5a04097a28f37dbbead1", // Assets/VitDeck/Validator/Tests/Data/AnimatorComponentMaxCountRule
            "68247ddd2a0e37643913d5373be8a60b", // Assets/VitDeck/Validator/Tests/Data/AnimatorComponentMaxCountRule/AnimatorComponentMaxCountRule.unity
            "40269264adbf9884f89a0436a8468333", // Assets/VitDeck/Validator/Tests/Data/AnimatorComponentRule
            "fa7f86288dc41364e8f31c854930c4b7", // Assets/VitDeck/Validator/Tests/Data/AnimatorComponentRule/ApplyRootMotion
            "d40c30ae520ccda4ba5b103072689e5c", // Assets/VitDeck/Validator/Tests/Data/AnimatorComponentRule/ApplyRootMotion/ApplyRootMotion.unity
            "d5f3109751c676e438346517c0e47e82", // Assets/VitDeck/Validator/Tests/Data/AnimatorComponentRule/SetAlwaysAnimate
            "4a8d8e45544afd740b5de81693a22e6a", // Assets/VitDeck/Validator/Tests/Data/AnimatorComponentRule/SetAlwaysAnimate/SetAlwaysAnimate.unity
            "783180687166bdc4ebe4f61e867bd3ed", // Assets/VitDeck/Validator/Tests/Data/AnimatorComponentRule/WithBoxColliderComponent
            "e0357e963736121439351b13831d5dbd", // Assets/VitDeck/Validator/Tests/Data/AnimatorComponentRule/WithBoxColliderComponent/WithBoxColliderComponent.unity
            "66a013e59a48e6148b93eead39287525", // Assets/VitDeck/Validator/Tests/Data/AssetExtentionBlacklistRule
            "22912df88ceaf494996f0e6ab9348b6b", // Assets/VitDeck/Validator/Tests/Data/AssetExtentionBlacklistRule/TestData.txt
            "bb5396989e4f7724580db4d47a17532f", // Assets/VitDeck/Validator/Tests/Data/AssetExtentionBlacklistRule/test.txt
            "e1faac7ae5375174eb95c35eb5520046", // Assets/VitDeck/Validator/Tests/Data/AssetGuidBlacklistRule
            "027bdc8dee9529e498d3199c30746ae4", // Assets/VitDeck/Validator/Tests/Data/AssetGuidBlacklistRule/New Scene.unity
            "740112f6e77ca914d9c26eef5d68accd", // Assets/VitDeck/Validator/Tests/Data/AssetGuidBlacklistRule/Prohibited material.mat
            "fc787a34466d54a46bafcf9b8d6e6651", // Assets/VitDeck/Validator/Tests/Data/AssetGuidBlacklistRule/Sub Folder
            "ae68339621fb41b4f9905188526120ea", // Assets/VitDeck/Validator/Tests/Data/AssetGuidBlacklistRule/Sub Folder/Prohibited fbx.fbx
            "6e4211e09c4956c46a637f0bbf827e83", // Assets/VitDeck/Validator/Tests/Data/AssetNamingRule
            "649253b2ec2aa364da658e2c27fc9104", // Assets/VitDeck/Validator/Tests/Data/AssetNamingRule/CorrectName_!#$%&'()+,;=@{}~.prefab
            "7adcee5076d4ae34eb3fb64b99b18869", // Assets/VitDeck/Validator/Tests/Data/AssetNamingRule/FailName_あああ.prefab
            "a467a1d7b46931a4fbedb3a0bfa0dd56", // Assets/VitDeck/Validator/Tests/Data/AssetNamingRule/FailFolderName_あああ
            "e09755e2cade2d942a3721a9af2a8cf5", // Assets/VitDeck/Validator/Tests/Data/AudioSourcePrefabRule
            "d344ce3487630db479f48e9056a28428", // Assets/VitDeck/Validator/Tests/Data/AudioSourcePrefabRule/AudioSourcePrefabRule.unity
            "2c35633d053ef674585838bd4b707194", // Assets/VitDeck/Validator/Tests/Data/AudioSourcePrefabRule/ForLoopValidation.prefab
            "bdcc27c50e54964439df83bbcbd4d360", // Assets/VitDeck/Validator/Tests/Data/AudioSourcePrefabRule/ForMaxDistanceValidation.prefab
            "f4b40bf4b6f23f445bccecf36c3298dc", // Assets/VitDeck/Validator/Tests/Data/CanvasRenderModeRule
            "fa4428ba1e9f249449a9648cda618f52", // Assets/VitDeck/Validator/Tests/Data/CanvasRenderModeRule/CanvasRenderModerRule.unity
            "e0c82b5da1ead7b4fa67cb4084f405c8", // Assets/VitDeck/Validator/Tests/Data/ComponentBlacklistRule
            "0397c0bed99360848b907823339bb80b", // Assets/VitDeck/Validator/Tests/Data/ComponentBlacklistRule/ComponentBlacklistRule.unity
            "ba71b63bde1aa0f4983af8032215c032", // Assets/VitDeck/Validator/Tests/Data/ComponentWhitelistRule
            "5b2078339731bbe43accf3f38e51012c", // Assets/VitDeck/Validator/Tests/Data/ComponentWhitelistRule/ComponentWhitelistRule.unity
            "a77ffbac1e038a849a0f864a0c0dff8f", // Assets/VitDeck/Validator/Tests/Data/ContainMatOrTexInAssetRule
            "d2e6f5aa83d0b8e42a4a7046bd5b42ac", // Assets/VitDeck/Validator/Tests/Data/ContainMatOrTexInAssetRule/NG
            "605995f36f6da584c9e06a45c188b002", // Assets/VitDeck/Validator/Tests/Data/ContainMatOrTexInAssetRule/NG/New Scene.unity
            "4961fc7862e9f104e9edec110133d3fa", // Assets/VitDeck/Validator/Tests/Data/ContainMatOrTexInAssetRule/NG/testcube.fbx
            "0b8dcc6c879711549ae7cc3a38e58204", // Assets/VitDeck/Validator/Tests/Data/ContainMatOrTexInAssetRule/OK
            "f9e96e7fd861e64499376bb8c9da60a7", // Assets/VitDeck/Validator/Tests/Data/ContainMatOrTexInAssetRule/OK/Material.mat
            "a889fb8e59baf12459ce4d7febf1c628", // Assets/VitDeck/Validator/Tests/Data/ContainMatOrTexInAssetRule/OK/New Scene.unity
            "905599bbcd2add44a96f6f37cf7fb590", // Assets/VitDeck/Validator/Tests/Data/ContainMatOrTexInAssetRule/OK/sample.png
            "94d7c9448e2d29c42a31fa522e0a2aff", // Assets/VitDeck/Validator/Tests/Data/ContainMatOrTexInAssetRule/OK/testcube.fbx
            "c10deae356eb575449879b0b007e9733", // Assets/VitDeck/Validator/Tests/Data/ErrorShaderRule
            "4b51a43c4c2543c45becc3a479cddd8c", // Assets/VitDeck/Validator/Tests/Data/ErrorShaderRule/Error Shader Material.mat
            "42fc4c9d6a6b1ac4fb66e6f7b678da25", // Assets/VitDeck/Validator/Tests/Data/ErrorShaderRule/ErrorShader.shader
            "dded8c5e20167ab4c8294c1327737e88", // Assets/VitDeck/Validator/Tests/Data/ErrorShaderRule/ErrorShaderRule.unity
            "2de171b9b5b1fcb4dae3847f5ac9cde2", // Assets/VitDeck/Validator/Tests/Data/ErrorShaderRule/Null Reference Material.mat
            "72daf4f2ef6448340b78647d3aea3405", // Assets/VitDeck/Validator/Tests/Data/ExistInSubmitFolderRule
            "5ac49cbf899312e408480ca7d134c51b", // Assets/VitDeck/Validator/Tests/Data/ExistInSubmitFolderRule/0001
            "7248599b183feb54cb90c2ab97ea4192", // Assets/VitDeck/Validator/Tests/Data/ExistInSubmitFolderRule/0001/0001.unity
            "0a1eb974a89f0004abacb113730b2dfd", // Assets/VitDeck/Validator/Tests/Data/ExistInSubmitFolderRule/0001/CubePrefabInCorrectFolder.prefab
            "969e0caba8b35f843aea50fe55659769", // Assets/VitDeck/Validator/Tests/Data/ExistInSubmitFolderRule/0001_Sub
            "c136f212e201030488a81d434ffe24f2", // Assets/VitDeck/Validator/Tests/Data/ExistInSubmitFolderRule/0001_Sub/CubePrefabInWrongFolder.prefab
            "289926955106d864d9eb93b78f9d15a4", // Assets/VitDeck/Validator/Tests/Data/ExistInSubmitFolderRule/0001_Sub/MaterialInWrongFolder.mat
            "e0684be1a553b9444b955cfa9bca2afe", // Assets/VitDeck/Validator/Tests/Data/FolderSizeRule
            "0fc099fb5b136bb408d018f75489171f", // Assets/VitDeck/Validator/Tests/Data/FolderSizeRule/New Material.mat
            "83b41447b82f70b4491b1559e101cac2", // Assets/VitDeck/Validator/Tests/Data/GlobalIlluminationBakedRule
            "e40643077d4e7a34e8f54255986cf88d", // Assets/VitDeck/Validator/Tests/Data/GlobalIlluminationBakedRule/GlobalIlluminationBakedMaterial.mat
            "4b29edabcd1ae9a4387c4fb9783c430d", // Assets/VitDeck/Validator/Tests/Data/GlobalIlluminationBakedRule/GlobalIlluminationBakedRule.unity
            "6acc7ec54c29a0f49b4d222315de2412", // Assets/VitDeck/Validator/Tests/Data/GlobalIlluminationBakedRule/NotGlobalIlluminationBakedMaterial.mat
            "61fde8499cbde5c4f92a53bd97bf709a", // Assets/VitDeck/Validator/Tests/Data/GlobalIlluminationBakedRule/NotStandardShaderMaterial.mat
            "4c4f9b3f4bc973043a2647715867b851", // Assets/VitDeck/Validator/Tests/Data/LightConfigRule
            "56b8f039b74f23341b1d474459d7cb23", // Assets/VitDeck/Validator/Tests/Data/LightConfigRule/New Scene.unity
            "a30314933744de84fa8474813e0fdff7", // Assets/VitDeck/Validator/Tests/Data/LightCountLimitRule
            "efde201ace9988c42b4057e8645234c4", // Assets/VitDeck/Validator/Tests/Data/LightCountLimitRule/New Scene.unity
            "b0de1648c7736894e9476976950a894b", // Assets/VitDeck/Validator/Tests/Data/MissingReferenceRule
            "3197fa3965320484e87f19f1ed5adf47", // Assets/VitDeck/Validator/Tests/Data/MissingReferenceRule/MissingReferenceRule.unity
            "279678fa7ebbba045a5158f012d9e424", // Assets/VitDeck/Validator/Tests/Data/MissingReferenceRule/MissingTestMaterial.mat
            "e41cae2d580b3704e9ebf621371f83b0", // Assets/VitDeck/Validator/Tests/Data/MissingReferenceRule/MissingTestPrefab.prefab
            "9a229ae7e49eb184abe1d6f7a83d809a", // Assets/VitDeck/Validator/Tests/Data/MissingReferenceRule/RecursiveMissingTestPrefab.prefab
            "04b9b050cd5b97a43884ae9479947b74", // Assets/VitDeck/Validator/Tests/Data/MissingReferenceRule/RecursiveMissingTestPrefabChild.prefab
            "23083f267ba60d94dbdfbfaa9ca75292", // Assets/VitDeck/Validator/Tests/Data/NoneMeshRule
            "0cdb2a7b784a9974c8cdc68f77b1cde1", // Assets/VitDeck/Validator/Tests/Data/NoneMeshRule/NoneMeshRule.unity
            "15e2a4b6aa231e044a3fc973e8c0e4c3", // Assets/VitDeck/Validator/Tests/Data/PrefabLimitRule
            "0c8358abaf9a46540883e817b3a43485", // Assets/VitDeck/Validator/Tests/Data/PrefabLimitRule/PrefabLimitRule.unity
            "c4bb7970c870834499aba4a950dd3d73", // Assets/VitDeck/Validator/Tests/Data/PrefabLimitRule/TargetPrefab.prefab
            "09ee243ecf20d6d46840b736ae63db0a", // Assets/VitDeck/Validator/Tests/Data/PrefabPartsDetector
            "1f27576d34c470f4887efe97aa4def84", // Assets/VitDeck/Validator/Tests/Data/PrefabPartsDetector/PrefabPartsDetector.unity
            "b5ab45d81f5eabd44a8b70b334ee27a0", // Assets/VitDeck/Validator/Tests/Data/PrefabPartsDetector/TestObject1.prefab
            "b67633f45ea1d1e4c88c5fe128b025bc", // Assets/VitDeck/Validator/Tests/Data/PrefabPartsDetector/TestObject2.prefab
            "26d947a260858ed44aabf2a9754329bf", // Assets/VitDeck/Validator/Tests/Data/UsableComponentListRule
            "1658fe8eda88b1e45905a16858d4b6a4", // Assets/VitDeck/Validator/Tests/Data/UsableComponentListRule/Directional Light Prefab.prefab
            "05ef3d85c295cda4d8cfdb269e010775", // Assets/VitDeck/Validator/Tests/Data/UsableComponentListRule/UsableComponentListRule.unity
            "f714df8a572cc8b42b4f50cea48785e9", // Assets/VitDeck/Validator/Tests/Data/UseLightModeRule
            "6715db7e06dc5524cb31ab839472277c", // Assets/VitDeck/Validator/Tests/Data/UseLightModeRule/New Scene.unity
            "3d158eda398103a4ba2fff824f54a9b4", // Assets/VitDeck/Validator/Tests/Data/UseMeshColliderRule
            "ecb46c57def17634982413743ac8d002", // Assets/VitDeck/Validator/Tests/Data/UseMeshColliderRule/New Scene.unity
            "ea1d0dcd344cee342a5d8918aa200c9b", // Assets/VitDeck/Validator/Tests/Data/VRCTriggerConfigRule
            "0f0f1424d69ba1f4bb125329dde4d15f", // Assets/VitDeck/Validator/Tests/Data/VRCTriggerConfigRule/Cube (18).prefab
            "6584b33cb63ec934495c6115c2686f2a", // Assets/VitDeck/Validator/Tests/Data/VRCTriggerConfigRule/GameObject.prefab
            "6e765df8fd18cd54f97e357ea8168256", // Assets/VitDeck/Validator/Tests/Data/VRCTriggerConfigRule/New Scene.unity
            "cf729ed3b6fb322428641e500b110157", // Assets/VitDeck/Validator/Tests/Data/VRCTriggerCountLimitRule
            "157eb2b42b44de64a91d5de5a1ba57fb", // Assets/VitDeck/Validator/Tests/Data/VRCTriggerCountLimitRule/New Scene.unity
            "1476855601c248a4ca59991e45d58f60", // Assets/VitDeck/Validator/Tests/Exception
            "1f145ee644fb7f34191766d102498576", // Assets/VitDeck/Validator/Tests/Exception/ExceptionRule.cs
            "d05f84a968b29f243a93596ec0dca278", // Assets/VitDeck/Validator/Tests/Exception/ExceptionRuleSet.cs
            "1e39b6afc2068884b8916e4ba5710137", // Assets/VitDeck/Validator/Tests/MultiScenes
            "71487af0fa5f70e44b7a58e032e1e2db", // Assets/VitDeck/Validator/Tests/MultiScenes/New Scene.unity
            "de218765854f6bf4ba69502dfe9b1e86", // Assets/VitDeck/Validator/Tests/MultiScenes/Sub Folder
            "068dc3056368a43488efe92a2c772309", // Assets/VitDeck/Validator/Tests/MultiScenes/Sub Folder/Scene in sub folder.unity
            "ca23ddb765f502c4b926715dc44b3b16", // Assets/VitDeck/Validator/Tests/SampleRule
            "13c5126bb1fb1394392dcc778382f7d4", // Assets/VitDeck/Validator/Tests/SampleRule/PassRuleSet.cs
            "ac59eab5bea340b4c984a5b4f73b7ee0", // Assets/VitDeck/Validator/Tests/SampleRule/TestSampleRule.cs
            "a95c299452f7efc45896e5880769a7dc", // Assets/VitDeck/Validator/Tests/Validate
            "fbabebf65f2ed3342843a41b896a38bc", // Assets/VitDeck/Validator/Tests/Validate/New Scene.unity
            "00b620bc0483bf045a4e7cbf4c051f27", // Assets/VitDeck/Validator/Tests/ValidationTargetFinder
            "f1f69f0382468de4284c5b19f5d367e5", // Assets/VitDeck/Validator/Tests/ValidationTargetFinder/New Scene.unity
            "a4b03051a833cca449d86b3821e3079f", // Assets/VitDeck/Validator/Tests/ValidationTargetFinder/Sample_object.fbx
            "b71fe49e9d4fb154dad657ed2f1022d4", // Assets/VitDeck/Validator/Tests/ValidationTargetFinder/Sub Folder
            "bc38aa664d9d7aa4a947a00a8777c5b9", // Assets/VitDeck/Validator/Tests/ValidationTargetFinder/Sub Folder/New Prefab in sub folder.prefab
            "d64400e17066a634c99fa872d4856a75", // Assets/VitDeck/Validator/Tests/ValidationTargetFinderNoObject
            "08491ecf6a282ab4d83d9156bbb8712b", // Assets/VitDeck/Validator/Tests/ValidationTargetFinderNoObject/No Object.unity
            #endregion
            #region VRChat Examples
            "e4078d93dda895f46b43a289c9958be9", // Assets/VRChat Examples
            "6d8386fc54e9d1246ad3c4678526831c", // Assets/VRChat Examples/Examples2
            "fbfb38f6c8ca4f64c9417b46da4feb15", // Assets/VRChat Examples/Examples2/Animation
            "e62f7e53f2f31664aa088ce9478b207f", // Assets/VRChat Examples/Examples2/Animation/AvatarControllerTPose.controller
            "53078c1a7cbf6fc428d032ffd0821f16", // Assets/VRChat Examples/Examples2/Animation/Idle.fbx
            "7e5debf235ac2d54397a268de3328672", // Assets/VRChat Examples/Examples2/Animation/Male_Standing_Pose.fbx
            "833bf0d070870a34e8147b8118a7c18f", // Assets/VRChat Examples/Examples2/Animation/Rotate - Legacy.anim
            "d8689a3093d706844912c4296b7931d0", // Assets/VRChat Examples/Examples2/Animation/Rotate.anim
            "d8efb47c3ec9a844c8641e77eb394974", // Assets/VRChat Examples/Examples2/Animation/Rotater.controller
            "0bfc2af7d952f9d40b8f938c3e7d6d91", // Assets/VRChat Examples/Examples2/Animation/tpose-new.fbx
            "6f14dae4bd76bcd42bb026397e8d572e", // Assets/VRChat Examples/Examples2/Animation/Walk.fbx
            "9ac40ca95d73fee499008e30c5787a64", // Assets/VRChat Examples/Examples2/Animation/SDK2
            "596fbaf43def8a54999157a5089972da", // Assets/VRChat Examples/Examples2/Animation/SDK2/AvatarControllerTemplate.controller
            "4bd8fbaef3c3de041a22200917ae98b8", // Assets/VRChat Examples/Examples2/Animation/SDK2/CustomOverrideEmpty.overrideController
            "dbd24704686facc41b725f017c845bf9", // Assets/VRChat Examples/Examples2/Animation/SDK2/SimpleAvatarController.controller
            "963449dd17fe70b42aac0c7504b0d949", // Assets/VRChat Examples/Examples2/Audio
            "940bf11939c44bc4f8038163c4e7d5d4", // Assets/VRChat Examples/Examples2/Audio/ow.ogg
            "8704a24b8fe9c6b40b17092da0276d51", // Assets/VRChat Examples/Examples2/Scenes
            "e331ff414ab2e7548ba4a7df0d93ec00", // Assets/VRChat Examples/Examples2/Scenes/Example-Actions.unity
            "48f08c32d637f484996cd3ffb6f20ad3", // Assets/VRChat Examples/Examples2/Scenes/Example-Avatar.unity
            "ec6baab2674b46a439f56392ba882866", // Assets/VRChat Examples/Examples2/Scenes/Example-PlayerAudioOverride.unity
            "d4093f0e316444342a370bc3c528892f", // Assets/VRChat Examples/Examples2/Scenes/Example-Prefabs.unity
            "c14013523bc17ec43be2524a06ffcc21", // Assets/VRChat Examples/Examples2/Scenes/Example-Triggers.unity
            "9fccfe4147c06af49a3a24fac58acee3", // Assets/VRChat Examples/Examples2/Scenes/Example-VideoPlayerSync.unity
            "e54d29cf1311b0d40b0d21cb9b053924", // Assets/VRChat Examples/Examples2/TutorialAvatar
            "9e5c42c5ad3198248a4b747d38b13421", // Assets/VRChat Examples/Examples2/TutorialAvatar/Vrchat_Tutorial_Avatar.fbx
            "3e8592ff022952746aefce0b46541a87", // Assets/VRChat Examples/Examples2/TutorialAvatar/Materials
            "a2c893843cec26b41b94130ec77a0ca8", // Assets/VRChat Examples/Examples2/TutorialAvatar/Materials/phong2.mat
            "7271de6c0efe03f42af964ce3073456a", // Assets/VRChat Examples/Examples2/TutorialAvatar/Materials/phong5.mat
            "d6327473f08dde54dada700bf88812c3", // Assets/VRChat Examples/Examples2/TutorialAvatar/Materials/Vrchatman_Black.mat
            "bbeadce146b7c1c41bea63eceabbae31", // Assets/VRChat Examples/Examples2/TutorialAvatar/Materials/Vrchatman_Blue.mat
            "d675dc4b793d5ec4bbe0c56a70bee55e", // Assets/VRChat Examples/Examples2/TutorialAvatar/Materials/Vrchatman_Green.mat
            "3e400cf5dce017245bd117c8438837c7", // Assets/VRChat Examples/Examples2/TutorialAvatar/Materials/Vrchatman_Grey.mat
            "d943b283c535741428aba133ba785ccf", // Assets/VRChat Examples/Examples2/TutorialAvatar/Materials/Vrchatman_White.mat
            "37e3fc81c9e5ea1459bb64e0f3b3d6c4", // Assets/VRChat Examples/Prefabs2
            "98173f743947d38499a6573aafa81f02", // Assets/VRChat Examples/Prefabs2/VRCAvatarPedestal.prefab
            "3c381b53d760c4286af1030278412a6c", // Assets/VRChat Examples/Prefabs2/VRCChair.prefab
            "c69cd4a2c56f32148888dab01592a615", // Assets/VRChat Examples/Prefabs2/VRCMirror.prefab
            "7dbf6d2eb6a2ce14a8d11b4e2cd1c0f3", // Assets/VRChat Examples/Prefabs2/VRCPanorama.prefab
            "e8e780ff40c6a484294bfec8711ced23", // Assets/VRChat Examples/Prefabs2/VRCPlayerVisualDamage.prefab
            "bab118b2f449fef458e2cb9d7d7dfbd6", // Assets/VRChat Examples/Prefabs2/VRCPortalMarker.prefab
            "1f6e5fea7e3764b4684edf284ad9b5ed", // Assets/VRChat Examples/Prefabs2/VRCVideoSync.prefab
            "9cb1e183d39ba432db5c583c4548819c", // Assets/VRChat Examples/Prefabs2/VRCWorld.prefab
            "5f3166efede7b7e479e24ff71225220f", // Assets/VRChat Examples/Prefabs2/VRC_PlayerVisualDamage.prefab
            #endregion
            #region VRCSDK
            "f2463179e33af374ba95e1987ab73d87", // Assets/VRCSDK
            "869af56c430f8e64db9912f417580e47", // Assets/VRCSDK/license.txt
            "2cdbe2e71e2c46e48951c13df254e5b1", // Assets/VRCSDK/version.txt
            "b31d48a4694a12e4bb4601ade7288735", // Assets/VRCSDK/Dependencies
            "5298eececcf9ec346b9565755f4d354f", // Assets/VRCSDK/Dependencies/AWSSDK
            "820ee6e459999be418b410c7af108bc3", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.CognitoIdentity.dll
            "378ce7362db1e424aa18decc8035d52f", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.CognitoIdentity.dll.mdb
            "aecaffc7454b52e448fc0ea1aef2dd1d", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.Core.dll
            "7aff903b705db4a4ca954521620a3e83", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.Core.dll.mdb
            "d4055bfc0cd67d642a7eceaf547c4901", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.S3.dll
            "27a1b37fcab46604bbfcdceca8b1ba0b", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.S3.dll.mdb
            "625a50dd0dd525a49a41cb3e3117fa15", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.SecurityToken.dll
            "7e9c75132ea9a6f49b0544e68db48e74", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.SecurityToken.dll.mdb
            "98a1730254acd1d4197b7153a1cfc5f8", // Assets/VRCSDK/Dependencies/DotZLib
            "34b0990e1522a284b9666d6821cd601c", // Assets/VRCSDK/Dependencies/DotZLib/DotZLib.dll
            "c03b8d4559ba6d643bfca2497c41437f", // Assets/VRCSDK/Dependencies/DotZLib/Plugins
            "3dcb6ef92894b9145b58a8c1b0457a6c", // Assets/VRCSDK/Dependencies/DotZLib/Plugins/x86
            "b609c54f9d3581e4fa22b3e389fd8d33", // Assets/VRCSDK/Dependencies/DotZLib/Plugins/x86/zlibwapi.dll
            "adf2284a8cae8554595b6bb7a5e40cd4", // Assets/VRCSDK/Dependencies/DotZLib/Plugins/x86_64
            "54f59547b5261e64f8256d6daaa01b17", // Assets/VRCSDK/Dependencies/DotZLib/Plugins/x86_64/zlibwapi.dll
            "534170db555e49649bc58c2fc11532ef", // Assets/VRCSDK/Dependencies/librsync
            "a2e4b2ce02fa7914895069e5fdbf112d", // Assets/VRCSDK/Dependencies/librsync/Blake2Sharp.dll
            "912b2ac597cb1ad4c9bdc1a98ec15459", // Assets/VRCSDK/Dependencies/librsync/librsync.net.dll
            "27608e807ee4b3348a1832582daca97e", // Assets/VRCSDK/Dependencies/Managed
            "db74213609a3d444c8bc111a3e373878", // Assets/VRCSDK/Dependencies/Managed/Collections.Pooled.dll
            "9787e75870c1dc347a0943055c585c64", // Assets/VRCSDK/Dependencies/Managed/System.Buffers.dll
            "03440596fa1da9c4f9796a20de292254", // Assets/VRCSDK/Dependencies/Managed/System.Collections.Immutable.dll
            "c30a499f804ba2e4281452f42b3ce52d", // Assets/VRCSDK/Dependencies/Managed/System.Memory.dll
            "9b6143470b1a740428cde7079e2c7555", // Assets/VRCSDK/Dependencies/Managed/System.Numerics.Vectors.dll
            "8b3b4a8bdfbaf344686d420abd25de73", // Assets/VRCSDK/Dependencies/Managed/System.Runtime.CompilerServices.Unsafe.dll
            "76cb7415e0f14dc4495a23030c99004f", // Assets/VRCSDK/Dependencies/Oculus
            "1a487bb1803f1d6439b4efa668961fb9", // Assets/VRCSDK/Dependencies/Oculus/Spatializer
            "e9391842c1e436f408e42ab829d4d7aa", // Assets/VRCSDK/Dependencies/Oculus/Spatializer/Editor
            "cb850b86de9091d4db4595959c56f954", // Assets/VRCSDK/Dependencies/Oculus/Spatializer/Editor/ONSPAudioSourceEditor.cs
            "aa48ca1ff6990e74eb28cb9a06ab5a0c", // Assets/VRCSDK/Dependencies/Oculus/Spatializer/Scripts
            "e503ea6418d27594caa33b93cac1b06a", // Assets/VRCSDK/Dependencies/Oculus/Spatializer/Scripts/ONSPAudioSource.cs
            "ad074644ff568a14187a3690cfbd7534", // Assets/VRCSDK/Dependencies/Oculus/Spatializer/Scripts/ONSPSettings.cs
            "069a99f750a0c6c4799088b847c41010", // Assets/VRCSDK/Dependencies/SharpZipLib
            "5a8cc42eaba7a2a41b6ca3be3c40b315", // Assets/VRCSDK/Dependencies/SharpZipLib/ICSharpCode.SharpZipLib.dll
            "c480955cdda001047991de5d0db91442", // Assets/VRCSDK/Dependencies/VRChat
            "f6d21b08a8b8d224686687417e2535d0", // Assets/VRCSDK/Dependencies/VRChat/Editor
            "10d9f721d76e07a47bc9e5f61e2fae72", // Assets/VRCSDK/Dependencies/VRChat/Editor/EnvConfig.cs
            "c3399613f583f3e46b2df27ae87dd5d6", // Assets/VRCSDK/Dependencies/VRChat/Editor/HDRColorFixerUtility.cs
            "7b8bb626428d0f341b9ed6a68cb5c9cc", // Assets/VRCSDK/Dependencies/VRChat/Editor/SDKUpdater.cs
            "679ba0056bf110c4db8b550082e73a5f", // Assets/VRCSDK/Dependencies/VRChat/Editor/ShaderKeywordsUtility.cs
            "0d2c09d149d213846ac4bdab38be0385", // Assets/VRCSDK/Dependencies/VRChat/Editor/VRCCachedWebRequest.cs
            "cb5d1f9882b08564cae97b2b14ad4e8f", // Assets/VRCSDK/Dependencies/VRChat/Editor/VRC_EditorTools.cs
            "f4cf5dd705ab67149afaba40b4a8fa7e", // Assets/VRCSDK/Dependencies/VRChat/Editor/VRC_SdkSplashScreen.cs
            "f8c0aa9a1c15bb844a3a070964a28cf5", // Assets/VRCSDK/Dependencies/VRChat/Editor/AWS
            "3d6a1d7b0624f414ba6fb922687a06da", // Assets/VRCSDK/Dependencies/VRChat/Editor/AWS/S3Manager.cs
            "8644799d125c3574e940eea432b4c2dc", // Assets/VRCSDK/Dependencies/VRChat/Editor/BuildPipeline
            "21332e1f0d937794d916d2402ba1943a", // Assets/VRCSDK/Dependencies/VRChat/Editor/BuildPipeline/VRC.SDKBase.Editor.BuildPipeline.asmdef
            "305e89f9eaccc7b438da1540c3661ad3", // Assets/VRCSDK/Dependencies/VRChat/Editor/BuildPipeline/Samples
            "0a1d20f4241085e46bdddc71b691465b", // Assets/VRCSDK/Dependencies/VRChat/Editor/BuildPipeline/Samples/VRCSDKBuildRequestedCallbackSample.cs
            "aecfd4a727b7a4b4baff756d44e83215", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components
            "39cdf3092ab81be4b9e623cb5a8819d8", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/ApiCacheEditor.cs
            "0a364ece829b6234888c59987a305a00", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/AutoAddSpatialAudioComponents.cs
            "89005ebc9543e0a4284893c09ca19b1d", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/EditorCoroutine.cs
            "3d6c2e367eaa9564ebf6267ec163cfbd", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/EditorHandling.cs
            "4810e652e8242384c834320970702290", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/EventHandlerEditor.cs
            "482185bf29f12074dada194ffef6a682", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/OldTriggerEditors.cs
            "5e83254bb97e84795ac882692ae124ba", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCAvatarDescriptorEditor.cs
            "26a75599848adb449b7aceed5090e35c", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCObjectSpawnEditor.cs
            "ed4aad2698d3b62408e69b57c7748791", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCObjectSyncEditor.cs
            "8986a640e24a0754ea0aded12234b808", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCPlayerModEditorWindow.cs
            "792e7964a56e51f4188e1221751642e9", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCPlayerModsEditor.cs
            "5262a02c32e41e047bdfdfc3b63db8ff", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCPlayerStationEditor.cs
            "e9cbc493bbbc443fb92898aa84d221ec", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCSceneDescriptorEditor.cs
            "eeda995d0ceac6443a54716996eab52e", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_AvatarVariationsEditor.cs
            "0ac7998a36f085844847acbc046d4e27", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_DataStorageEditor.cs
            "3b63b118c0591b548ba1797e6be4292e", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_DestructibleStandardEditor.cs
            "e19a7147a2386554a8e4d6e414f190a2", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_ObjectSyncEditor.cs
            "4aff4e5c0d600c845b29d7b8b7965d68", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_PickupEditor.cs
            "5c545625e0bf93045ac1c5864141c5c1", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_PlayerAudioOverrideEditor.cs
            "0d2d4cba733f5eb4ba170368e67710d2", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_SpatialAudioSourceEditor.cs
            "ae0e74693b7899f47bd98864f94b9311", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_SyncVideoPlayerEditor.cs
            "3f9dccfed0b072f49a307b3f20a7e768", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_SyncVideoStreamEditor.cs
            "3aecd666943878944a811acb9db2ace7", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_TriggerEditor.cs
            "d09b36020f697be4d9a0f5a6a48cfa83", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_WebPanelEditor.cs
            "764e26c1ca28e2e45a30c778c1955a47", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_YouTubeSyncEditor.cs
            "5556a9d00849f5040829e62503095d80", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel
            "310a760e312f2984e85eece367bab19a", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/IVRCSdkControlPanelBuilder.cs
            "20b4cdbdda9655947aab6f8f2c90690f", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanel.cs
            "5066cd5c1cc208143a1253cac821714a", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelAccount.cs
            "d90918c7fdc97d04f918868742746f67", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelAvatarBuilder.cs
            "4c73e735ee0380241b186a8993fa56bf", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelBuilder.cs
            "c768b42ca9a2f2b48afeb1fa03d5e1bf", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelBuilderAttribute.cs
            "c7333cdb3df19724b84b4a1b05093fe0", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelContent.cs
            "f3507a74e4b8cfd469afac127fa5f4e5", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelHelp.cs
            "8357b9b7ef2416946ae86f465a64c0e0", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelSettings.cs
            "f2a720a30f1043247af7742fdfd0b8e5", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelWorldBuilder.cs
            "dc1532ba0099eb54a93968795612af27", // Assets/VRCSDK/Dependencies/VRChat/Editor/SDK3Compatibility
            "93710d221addc0243ba90dd20369844b", // Assets/VRCSDK/Dependencies/VRChat/Editor/SDK3Compatibility/VRCSdk3Analysis.cs
            "bef603f06be5621479a4321a022cf1b2", // Assets/VRCSDK/Dependencies/VRChat/Editor/ShaderStripping
            "3f05fc74d61cc0c448411f8b55c918ca", // Assets/VRCSDK/Dependencies/VRChat/Editor/ShaderStripping/StripAndroidAvatars.cs
            "06d01ef00e2795244aa8b5cbe879b16e", // Assets/VRCSDK/Dependencies/VRChat/Editor/ShaderStripping/StripPostProcessing.cs
            "09158b5a87ea9554daafaef906ae927e", // Assets/VRCSDK/Dependencies/VRChat/Editor/ShaderStripping/VRC.SDKBase.Editor.ShaderStripping.asmdef
            "f36f7d4fa24207046a5566ebce63b38f", // Assets/VRCSDK/Dependencies/VRChat/Editor/Validation
            "574072146d0817444a05b6574386bb19", // Assets/VRCSDK/Dependencies/VRChat/Editor/Validation/Performance
            "62d40cc4e8f8494695f0102c58b3ea60", // Assets/VRCSDK/Dependencies/VRChat/Editor/Validation/Performance/SDKPerformanceDisplay.cs
            "87a107cc5d8b80e47b20158b15f62425", // Assets/VRCSDK/Dependencies/VRChat/Materials
            "da07ab9b78cb0432e95e11e2cb619ea7", // Assets/VRCSDK/Dependencies/VRChat/Materials/BlueprintCam.mat
            "94b649c2bd1ac4cac95049605dc5333d", // Assets/VRCSDK/Dependencies/VRChat/Materials/BlueprintCam.renderTexture
            "2166f6bbfce69594fad494087eca58e8", // Assets/VRCSDK/Dependencies/VRChat/Materials/damageGrey.mat
            "6e2f91f446fe77f4d954e98527ceb6c6", // Assets/VRCSDK/Dependencies/VRChat/Models
            "e13e96301b7c8214dac6883be5b82bfa", // Assets/VRCSDK/Dependencies/VRChat/Models/damageSphere.fbx
            "eefb8e506a572ed45af304b02319702b", // Assets/VRCSDK/Dependencies/VRChat/Models/Materials
            "841c3ce718e8b61408005c1cfce6b7de", // Assets/VRCSDK/Dependencies/VRChat/Models/Materials/lambert2.mat
            "e55d3783ca6a7234a8db0dc08cb2c89a", // Assets/VRCSDK/Dependencies/VRChat/Resources
            "4acdf7b3eb426480bb5acf58638bd493", // Assets/VRCSDK/Dependencies/VRChat/Resources/awsconfig.xml
            "dd5614b710e774040ab715161f7dfaca", // Assets/VRCSDK/Dependencies/VRChat/Resources/endpoints.customizations.json
            "37b4abef7420c4c7ea71dbe76757498a", // Assets/VRCSDK/Dependencies/VRChat/Resources/endpoints.json
            "be98467dc5d3c4eb1aeef22952913b0e", // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCCam.prefab
            "dce0dda226bd1f147a34f9b4660f5992", // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCProjectSettings.prefab
            "b14e1b78a061f8543b2f4120b5c369fa", // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCSDKAvatar.prefab
            "248f850c58993ed43bcaad6b934b7c92", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkBottomHeader.png
            "551946bfd2b165f419f297805d1e1256", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkBottomHeader_Oculus_Quest.png
            "d2244637721b4f3458280ffc1f9dd7cc", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkClDialogNewIcon.png
            "38956f4b67ba0984587b1a913d05beea", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkHeader.png
            "ff7f4f4963793a340bde459bc9975c07", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkHeaderWithCommunityLabs.png
            "1d151b29d1d1c704daa27e4921e39129", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkSplashUdon1.png
            "8458230047d35d4498b2de453f2cabda", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkSplashUdon2.png
            "fc887d4eeb5a941ed86bca0135b05e2b", // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCSDKWorld.prefab
            "4fc8b1a1e72638c4683fc00daeafc029", // Assets/VRCSDK/Dependencies/VRChat/Resources/2FAIcons
            "43066d8a73c579048891e3c123e252a0", // Assets/VRCSDK/Dependencies/VRChat/Resources/2FAIcons/SDK_Warning_Triangle_icon.png
            "c024856ea4241d940b29e5f6f16e4ec7", // Assets/VRCSDK/Dependencies/VRChat/Resources/CL_Icons
            "f310c3dbad3125d4e8fc2e00bdc2acb4", // Assets/VRCSDK/Dependencies/VRChat/Resources/CL_Icons/CL_Lab_Icon_256.png
            "36349feed06587e479724a1a09c0b267", // Assets/VRCSDK/Dependencies/VRChat/Resources/CL_Icons/Icon_New.png
            "3da2736743b25be46a20b790108804d3", // Assets/VRCSDK/Dependencies/VRChat/Resources/EditorUI_Icons
            "53f9c1f34eb97ec4196ff26de5e242f7", // Assets/VRCSDK/Dependencies/VRChat/Resources/EditorUI_Icons/EditorUI_Link.png
            "5aa75dcfcecb2c040818d5080404306f", // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons
            "4109d4977ddfb6548b458318e220ac70", // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Good_32.png
            "644caf5607820c7418cf0d248b12f33b", // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Great_32.png
            "2886eb1248200a94d9eaec82336fbbad", // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Horrible_32.png
            "9296abd40c7c1934cb668aae07b41c69", // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Medium_32.png
            "e561d0406779ab948b7f155498d101ee", // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Poor_32.png
            "fdcf7097751545c47835f9bb12caae18", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation
            "12d4462e7825d3646b2c720c5cc65d75", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance
            "e092399e9c2962e45a0cf707435a9aa7", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners
            "8ae6e7ea5b8982143aa8c2c4e2fe81c6", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/AnimatorPerformanceScanner.asset
            "c2ca835e9f95b464b8a2df5c181ba44e", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/AudioPerformanceScanner.asset
            "d162a2d08d890e644b79b605f1d1120e", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/ClothPerformanceScanner.asset
            "371dfb95b91b4684eb1ad68d37d81ac9", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/DynamicBonePerformanceScanner.asset
            "69c7115984bf82e46af96d6f144fe463", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/LightPerformanceScanner.asset
            "07199be0cf1b2a34f8dff60d486129ea", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/LineRendererPerformanceScanner.asset
            "e750aae2c41768e4485dfb9a6de00454", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/MeshPerformanceScanner.asset
            "f4004220746a95a4e84a3909a49d844b", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/ParticlePerformanceScanner.asset
            "18ec5f6f963b6774fa1b84c5bff0246f", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/PhysicsPerformanceScanner.asset
            "986c284df70b4c34dad7e5ef27a86156", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/TrailRendererPerformanceScanner.asset
            "f08ed36456ce2344a975ec6c0d7a528e", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/ScannerSets
            "bf50321b92d503d4a823939356ce856d", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/ScannerSets/PerformanceScannerSet_Quest.asset
            "b0d7b483809dd6441bb36507c9f64040", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/ScannerSets/PerformanceScannerSet_Windows.asset
            "85841253e7dc48d47aa658949ab52e54", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels
            "1cea90d04ede9d34fb0e8ef875706643", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest
            "f0f530dea3891c04e8ab37831627e702", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/AvatarPerformanceStatLevels_Quest.asset
            "e750436d0bab192489da0debe67ee879", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Excellent_Quest.asset
            "b25db21b17fba3d49a7248568fdb9870", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Good_Quest.asset
            "31feb7417182a80469408649071d10ac", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Medium_Quest.asset
            "171503e8193e15447967be1e3ca1e714", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Poor_Quest.asset
            "7180a5cac1c7d6748b8e6da4648cbaf4", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows
            "438f83f183e95f740877d4c22ed91af2", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/AvatarPerformanceStatLevels_Windows.asset
            "88c46902276e7624e8adda9020bef28b", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Excellent_Windows.asset
            "38957d57ab5a7f145b954d20fc24b1d4", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Good_Windows.asset
            "65edaefdc2f87414594559cb89383b5b", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Medium_Windows.asset
            "595049d4e162571489f2437524d98a31", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Poor_Windows.asset
            "e496bb8cc14c69b4094fbef2a1ca0712", // Assets/VRCSDK/Dependencies/VRChat/Scripts
            "36c0d886a26373c46be857f2fc441071", // Assets/VRCSDK/Dependencies/VRChat/Scripts/ApiFileHelper.cs
            "acadc6659c5ab3446ad0d5de2563f95f", // Assets/VRCSDK/Dependencies/VRChat/Scripts/AudioManagerSettings.cs
            "8d047eaa3325d654aa62ccad6f73eb93", // Assets/VRCSDK/Dependencies/VRChat/Scripts/CommunityLabsConstants.cs
            "e1c693656bf5d584b87df969efeb5536", // Assets/VRCSDK/Dependencies/VRChat/Scripts/ContentUploadedDialog.cs
            "a3132e0ab7e16494a9d492087a1ca447", // Assets/VRCSDK/Dependencies/VRChat/Scripts/RuntimeAPICreation.cs
            "1e5ebf65c5dceeb4c909aa7812bd2999", // Assets/VRCSDK/Dependencies/VRChat/Scripts/RuntimeBlueprintCreation.cs
            "2bd5ee5d69ee0f3449bf2f81fcb7f4e3", // Assets/VRCSDK/Dependencies/VRChat/Scripts/RuntimeWorldCreation.cs
            "0d49300ad532d4ae6b569b28de5b7dac", // Assets/VRCSDK/Dependencies/VRChat/Scripts/SceneSaver.cs
            "eeae64370c4dada4ea70c0c6d7e489ea", // Assets/VRCSDK/Dependencies/VRChat/Scripts/MaterialFallback
            "10121679f780956408f9a434a526f553", // Assets/VRCSDK/Dependencies/VRChat/Scripts/MaterialFallback/FallbackMaterialCache.cs
            "08651f5aaa1240f4d9dd516c4e46cbe3", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation
            "d497915ac8463e048aeb2c934a36c299", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/AvatarValidation.cs
            "bef0a8d1d2c547119a62b7d7a5c512ea", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/ShaderValidation.cs
            "8a90ec11b51863c4cb2d8a8cee31c2fb", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/ValidationUtils.cs
            "9b03724cd556cb047b2da80492ea28a5", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/WorldValidation.cs
            "833f69125626eb7469ec7cb17df7052e", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance
            "15ecac6f7fdc1bc4fb723fee6f4635dd", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/AvatarPerformance.cs
            "f1ce994297384ff1bc330196df61b7ca", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/AvatarPerformanceCategory.cs
            "f28c978154794266b38d686139c6b872", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/MeshUtils.cs
            "8cdca9d06d1b4732b9ccb82a38bb8d9c", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceFilterSet.cs
            "a5ed7498cb1a46c78eab031f5f32448c", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceInfoDisplayLevel.cs
            "5019a55ee9e2404c81bc61a39a010d8d", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceRating.cs
            "4afb61f36d144fc381114cd7f78d13e7", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceScannerSet.cs
            "89f96697d2bc78e44b6ad322047e3b81", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Filters
            "abda65e062e44213aa3e1f4c82b400a8", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Filters/AbstractPerformanceFilter.cs
            "d948e26548715ca45b4d635c51994002", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners
            "0bd0691a021844f49444a04a959d6328", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/AbstractPerformanceScanner.cs
            "08c8e931d0544866a0f626855d9c1841", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/AnimatorPerformanceScanner.cs
            "b3a8bba736414d1aaa9e766da27b56b5", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/AudioPerformanceScanner.cs
            "0cec88b5a46f459195f10a2f11fddb2f", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/ClothPerformanceScanner.cs
            "a226df494ef04404a9a47c714822ab9f", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/DynamicBonePerformanceScanner.cs
            "405778fdc32c44c1bb9fdd0476fb0007", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/LightPerformanceScanner.cs
            "ec87392b85844f7bb526a48ec866a8f0", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/LineRendererPerformanceScanner.cs
            "38bca10261df4ddfa10cff3b3bbb9428", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/MeshPerformanceScanner.cs
            "10723e354ff14f98a49ab797b3f005e6", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/ParticlePerformanceScanner.cs
            "6a94ecdeecd04f85824cc3244be5712a", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/PhysicsPerformanceScanner.cs
            "2efd714b564547b4be1ebd1f2700668b", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/TrailRendererPerformanceScanner.cs
            "e1015ade6c8e9f44ba3235596ad4daf1", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Stats
            "1bf4fb79a49d4b109c4dce6b38e5548e", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Stats/AvatarPerformanceStats.cs
            "f742c36dce5730f4d96e37d82c330584", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Stats/AvatarPerformanceStatsLevel.cs
            "468554b1bfc447f41a20a2f5bae65d16", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Stats/AvatarPerformanceStatsLevelSet.cs
            "2351a40d867f50047905317b273c0ae4", // Assets/VRCSDK/Dependencies/VRChat/SdkGraphics
            "9ae7399f0cf902a41a20f3487af8322a", // Assets/VRCSDK/Dependencies/VRChat/SdkGraphics/SDK_Panel_Banner.png
            "25ae8353aa2734c4ea65bda1512e4eb7", // Assets/VRCSDK/Dependencies/VRChat/Textures
            "13d3efffb839ced4c8426a88a0c3e98c", // Assets/VRCSDK/Dependencies/VRChat/Textures/damageGreyNoAlpha.png
            "8d95767408d35544c98f92ef7279b8db", // Assets/VRCSDK/Dependencies/VRChat/Textures/damageGRNoAlpha.png
            "861bc2dd35aa1534d89330ffa4434b61", // Assets/VRCSDK/Dependencies/VRChat/Textures/VRChatBanner.png
            "ac6dbe540cbe64744b7d70b91dcbd9f4", // Assets/VRCSDK/Plugins
            "4ecd63eff847044b68db9453ce219299", // Assets/VRCSDK/Plugins/VRCCore-Editor.dll
            "b0e1c0f72d838fe49bfe88b987a471bd", // Assets/VRCSDK/Plugins/VRCCore-Standalone.dll
            "f994bcaaf4690ab4e953545d40789022", // Assets/VRCSDK/Plugins/VRCSDK2-Editor.dll
            "f78c4655b33cb5741983dc02e08899cf", // Assets/VRCSDK/Plugins/VRCSDK2.dll
            "dc5cab6c932db3247aab9f50c5f3bd5f", // Assets/VRCSDK/Plugins/VRCSDKBase-Editor.dll
            "db48663b319a020429e3b1265f97aff1", // Assets/VRCSDK/Plugins/VRCSDKBase.dll
            "00cd683ac703bd043a42145faadcf5ee", // Assets/VRCSDK/Sample Assets
            "cf317e066b34b7442a6c7cf5143bb7e1", // Assets/VRCSDK/Sample Assets/Editor
            "bb15d88e30f9fae428df916379b289b2", // Assets/VRCSDK/Sample Assets/Editor/RealtimeEmissiveGammaGUI.cs
            "d6620905435729b43bbea398b292d300", // Assets/VRCSDK/Sample Assets/Materials
            "68be9f0f6e5adbd44a76bf6bf69fda7b", // Assets/VRCSDK/Sample Assets/Materials/BrightButton.mat
            "9414e644b0d9d4c4cb1d863093f0284c", // Assets/VRCSDK/Sample Assets/Materials/Chair.mat
            "b6099d83d6f02e34ea589e768df4173b", // Assets/VRCSDK/Sample Assets/Materials/Green.mat
            "34348aa1b91e32f48bda8333f82f6335", // Assets/VRCSDK/Sample Assets/Materials/GUI_Gradient_Ground.mat
            "4546b0ec54086e840800d63eb723acd2", // Assets/VRCSDK/Sample Assets/Materials/GUI_Zone_Holo.mat
            "c815f7613a04b724089c206857e57c6a", // Assets/VRCSDK/Sample Assets/Materials/MirrorReflection.mat
            "7a2568654af4bef4cad7a3dfa02c31b2", // Assets/VRCSDK/Sample Assets/Materials/Red.mat
            "4a04f8d3981104848915e66f7a02ec72", // Assets/VRCSDK/Sample Assets/Materials/Screen.mat
            "fca0fa2edcd76be40982254610beb63f", // Assets/VRCSDK/Sample Assets/PanoViewer
            "1278163a2a3ba2b4cad540a862292784", // Assets/VRCSDK/Sample Assets/PanoViewer/Panosphere.shader
            "26803b57669325843a97b0ae43031082", // Assets/VRCSDK/Sample Assets/PanoViewer/Sphere.mat
            "c44eff72030eea24184c6ad253cb7be8", // Assets/VRCSDK/Sample Assets/Prototyping
            "312ca6d702ca65e4ea717335d5e4b595", // Assets/VRCSDK/Sample Assets/Prototyping/Materials
            "4876fc9dc009bbe4493553020a561611", // Assets/VRCSDK/Sample Assets/Prototyping/Materials/prototype_black_grid.mat
            "eae9c11350249284e8400a100179e0b2", // Assets/VRCSDK/Sample Assets/Prototyping/Materials/prototype_blue_grid.mat
            "1ab66d94bde8cce46bb35638099bfd31", // Assets/VRCSDK/Sample Assets/Prototyping/Materials/prototype_grey_smooth.mat
            "76ff537c8e1a84345868e6aeee938ab3", // Assets/VRCSDK/Sample Assets/Prototyping/Materials/prototype_navy_grid.mat
            "1032d41f900276c40a9dd24f55b7d420", // Assets/VRCSDK/Sample Assets/Prototyping/Materials/prototype_navy_smooth.mat
            "8c19a618a0bd9844583b91dca0875a34", // Assets/VRCSDK/Sample Assets/Prototyping/Materials/prototype_pink_grid.mat
            "fed4e78bda2b3de45954637fee164b8c", // Assets/VRCSDK/Sample Assets/Prototyping/Materials/prototype_pink_smooth.mat
            "5aa95b3fa56e28f43a84e301c3d19e08", // Assets/VRCSDK/Sample Assets/Prototyping/Materials/prototype_white_grid.mat
            "799167b062f9e2944a302eea855166b4", // Assets/VRCSDK/Sample Assets/Prototyping/Materials/prototype_white_smooth.mat
            "82096aab38f01cb40a1cbf8629a810ba", // Assets/VRCSDK/Sample Assets/Prototyping/Materials/prototype_yellow_grid.mat
            "6e1d36c4bbd37d54f9ea183e4f5fd656", // Assets/VRCSDK/Sample Assets/Prototyping/Materials/prototype_yellow_smooth.mat
            "f61c6a55a3ccf794281c1385ec8c8f97", // Assets/VRCSDK/Sample Assets/Prototyping/Models
            "622a87b3379022740be7e2efea3ebd33", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_block_04x04x04.fbx
            "00718395eefb6084bb25555f962f25c0", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_coin_01x01x01.fbx
            "df4796b594b970842b69211cb0078c5d", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_cube_02x02x02.fbx
            "3f79402ff4ca9c54d96a09d1a77540d5", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_cube_04x04x04.fbx
            "c09052c9b19f0ea4987bc4f4f981252f", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_cube_08x08x08.fbx
            "16fb769c0394c36469ed40a4f35c1eec", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_floor_08x01x08.fbx
            "080bc076ed19adb4091adca05de83d66", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_floor_4x1x4.FBX
            "fadddc63520db414bbc9126cbf4743ad", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_floor_64x01x64.fbx
            "ce7348d724aa0fc44aaf53391b9bae9b", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_house_16x16x24.fbx
            "f45b6695d6226cd48abfc605723cc3ae", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_join_inner_01x06x01.fbx
            "40384240c1c82b94db82531689571ab0", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_join_mid_04x06x01.fbx
            "6386a10e23c45d040a22051e6ae3b70f", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_join_outer_02x06x02.fbx
            "25712b9d3dd0eb4439390fb8fea8043e", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_pillar_01x02x01.fbx
            "66a13889798137c498eae4b3acdafe19", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_pillar_02x08x02.fbx
            "38a9d3cc5c1e0aa4f92ff3445b73ed7f", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_platform_02x01x02.fbx
            "bc2ed85df3924a4458576f17e8b10057", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_platform_04x01x04.fbx
            "879dd62cbfd65314d812354e257fc5cc", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_platform_8x1x8.FBX
            "b9d7ac1a0f551404f8d32e1e02b64325", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_ramp_04x02x02.fbx
            "900e53dd850c9cc4281be6fa21bdfea5", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_steps_4x2x2.FBX
            "b5290684820a94548bedb95083785116", // Assets/VRCSDK/Sample Assets/Prototyping/Models/prototype_wall_8x8x1.FBX
            "932c8c4dc3478674c91e1949d16e710e", // Assets/VRCSDK/Sample Assets/Prototyping/Models/Materials
            "4cfb7ae289eb1e546b751d287bc1ee62", // Assets/VRCSDK/Sample Assets/Prototyping/Models/Materials/NavyGrid.mat
            "22a917a65630c404e8ebe2c26a9c7d5e", // Assets/VRCSDK/Sample Assets/Prototyping/Models/Materials/PinkSmooth.mat
            "77ce2ac1c5cfbbe4b882ca966906e41d", // Assets/VRCSDK/Sample Assets/Prototyping/Textures
            "a196fd6788131ec459bfb26012466fc1", // Assets/VRCSDK/Sample Assets/Prototyping/Textures/GridEmissive.png
            "efaaea7f6a25a4d4fafa9fce85bf947f", // Assets/VRCSDK/Sample Assets/Prototyping/Textures/prototype_black_dff.png
            "3cae02495b88d2d4fbf19382b7993691", // Assets/VRCSDK/Sample Assets/Prototyping/Textures/prototype_blue_dff.png
            "33a18574a1737ab42a75137c3b83c9be", // Assets/VRCSDK/Sample Assets/Prototyping/Textures/prototype_white_dff.png
            "c3edc74ae8207fd45a93c4ed8ee27567", // Assets/VRCSDK/Sample Assets/Prototyping/Textures/SwatchMauveAlbedo.png
            "86e4aa9207c9e2740b6ace599d659c05", // Assets/VRCSDK/Sample Assets/Prototyping/Textures/SwatchNavyAlbedo.png
            "a336ccf90791f9841b7e680c010d1e88", // Assets/VRCSDK/Sample Assets/Prototyping/Textures/SwatchNavyDarkAlbedo.png
            "8b939c5b46fae7e49af7d85f731ba4ec", // Assets/VRCSDK/Sample Assets/Prototyping/Textures/SwatchOrangeAlbedo.png
            "580615edf5e29d245af58fc5fe2b06ac", // Assets/VRCSDK/Sample Assets/Prototyping/Textures/SwatchPinkDAlbedo.png
            "590546bcbd472d94e874f6e0c76cc266", // Assets/VRCSDK/Sample Assets/Prototyping/Textures/SwatchTealAlbedo.png
            "9c4d7ee42c7d4f944b2ce9d370fa265c", // Assets/VRCSDK/Sample Assets/Prototyping/Textures/SwatchTurquoiseAlbedo.png
            "9d0b29cecf2678b41982d2173d3670ff", // Assets/VRCSDK/Sample Assets/Prototyping/Textures/SwatchWhiteAlbedo.png
            "b4646ae63b0bcca40b1bdde3b87e01bf", // Assets/VRCSDK/Sample Assets/Prototyping/Textures/SwatchYellowAlbedo.png
            "0ae67a77d929b7d4d89a8a08d0ae9877", // Assets/VRCSDK/Sample Assets/Shaders
            "693137b858e4dc64c83be531351f45e6", // Assets/VRCSDK/Sample Assets/Shaders/Mirror.shader
            "9788d723ed7eac946a9a599e4a6ba940", // Assets/VRCSDK/Sample Assets/Shaders/Video-RealtimeEmissiveGamma.shader
            "5f8fef09682fab74fb7a29d783391edb", // Assets/VRCSDK/Sample Assets/Shaders/VRChat-Sprites-Default.shader
            "9ae8ad653e1d98940bbc79866b9170f3", // Assets/VRCSDK/Sample Assets/Shaders/VRChat-Sprites-Diffuse.shader
            "f730bd01070374a48ad3a35f817eaae6", // Assets/VRCSDK/Sample Assets/Shaders/Mobile
            "f8c1f8ac363df824899534a0b30eef00", // Assets/VRCSDK/Sample Assets/Shaders/Mobile/VRChat-Mobile-BumpedDiffuse.shader
            "528d55c4e8adab14b974ca665ed1b996", // Assets/VRCSDK/Sample Assets/Shaders/Mobile/VRChat-Mobile-BumpedMappedSpecular.shader
            "584dc70fbb9834e48beb29e3206e3ca0", // Assets/VRCSDK/Sample Assets/Shaders/Mobile/VRChat-Mobile-BumpedSpecular.shader
            "2dcd9e0568e0a6f45b92c60ba2eb16a0", // Assets/VRCSDK/Sample Assets/Shaders/Mobile/VRChat-Mobile-Diffuse.shader
            "b1f7ecc80417c414b9d62ce541d5bcbf", // Assets/VRCSDK/Sample Assets/Shaders/Mobile/VRChat-Mobile-Lightmapped.shader
            "3ad043b7f9839cb48a75a9238d433dec", // Assets/VRCSDK/Sample Assets/Shaders/Mobile/VRChat-Mobile-MatCapLit.shader
            "9200bec112b65ec4fbbbd33fa89c20f4", // Assets/VRCSDK/Sample Assets/Shaders/Mobile/VRChat-Mobile-Particle-Add.shader
            "8b39b95ac85682040beff730e0cfc77a", // Assets/VRCSDK/Sample Assets/Shaders/Mobile/VRChat-Mobile-Particle-Alpha.shader
            "d5b89f0c74ccf5049ba803c14a090378", // Assets/VRCSDK/Sample Assets/Shaders/Mobile/VRChat-Mobile-Particle-Multiply.shader
            "c0d3cb006bb294142bef136f492f2568", // Assets/VRCSDK/Sample Assets/Shaders/Mobile/VRChat-Mobile-Skybox.shader
            "0b7113dea2069fc4e8943843eff19f70", // Assets/VRCSDK/Sample Assets/Shaders/Mobile/VRChat-Mobile-StandardLite.shader
            "affc81f3d164d734d8f13053effb1c5c", // Assets/VRCSDK/Sample Assets/Shaders/Mobile/VRChat-Mobile-ToonLit.shader
            "7043d5fe196329f4fae0afa4923306c4", // Assets/VRCSDK/SDK2
            "c66fea9659794824591642f26cfaeaa0", // Assets/VRCSDK/SDK2/Editor
            "47d2ad6f47b02ac40ab179a05abb85b1", // Assets/VRCSDK/SDK2/Editor/AvatarValidation.cs
            "6e80761c14a94580b4eb3674f56c8f06", // Assets/VRCSDK/SDK2/Editor/VRCSdkControlPanelAvatarBuilder2.cs
            "220b44a0ee4a30843b4cee370eb583c7", // Assets/VRCSDK/SDK2/Editor/VRCSdkControlPanelWorldBuilder2.cs

#endregion VRCSDK
            #region TMP Essential Resources
            "f54d1bd14bd3ca042bd867b519fee8cc", // Assets/TextMesh Pro
            "8e7e8f5a82a3a134e91c54efd2274ea9", // Assets/TextMesh Pro/Documentation
            "1b8d251f9af63b746bf2f7ffe00ebb9b", // Assets/TextMesh Pro/Documentation/TextMesh Pro User Guide 2016.pdf
            "6ab70aee4d56447429c680537fbf93ed", // Assets/TextMesh Pro/Fonts
            "6e59c59b81ab47f9b6ec5781fa725d2c", // Assets/TextMesh Pro/Fonts/LiberationSans - OFL.txt
            "e3265ab4bf004d28a9537516768c1c75", // Assets/TextMesh Pro/Fonts/LiberationSans.ttf
            "243e06394e614e5d99fab26083b707fa", // Assets/TextMesh Pro/Resources
            "fade42e8bc714b018fac513c043d323b", // Assets/TextMesh Pro/Resources/LineBreaking Following Characters.txt
            "d82c1b31c7e74239bff1220585707d2b", // Assets/TextMesh Pro/Resources/LineBreaking Leading Characters.txt
            "3f5b5dff67a942289a9defa416b206f3", // Assets/TextMesh Pro/Resources/TMP Settings.asset
            "731f1baa9d144a9897cb1d341c2092b8", // Assets/TextMesh Pro/Resources/Fonts & Materials
            "e73a58f6e2794ae7b1b7e50b7fb811b0", // Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF - Drop Shadow.mat
            "2e498d1c8094910479dc3e1b768306a4", // Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF - Fallback.asset
            "79459efec17a4d00a321bdcc27bbc385", // Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF - Outline.mat
            "8f586378b4e144a9851e7b34d9b748ee", // Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF.asset
            "99f836c9cb9345dba2e72c4a1f2d0695", // Assets/TextMesh Pro/Resources/Shaders
            "407bc68d299748449bbf7f48ee690f8d", // Assets/TextMesh Pro/Resources/Shaders/TMPro.cginc
            "3997e2241185407d80309a82f9148466", // Assets/TextMesh Pro/Resources/Shaders/TMPro_Properties.cginc
            "d930090c0cd643c7b55f19a38538c162", // Assets/TextMesh Pro/Resources/Shaders/TMPro_Surface.cginc
            "48bb5f55d8670e349b6e614913f9d910", // Assets/TextMesh Pro/Resources/Shaders/TMP_Bitmap-Custom-Atlas.shader
            "1e3b057af24249748ff873be7fafee47", // Assets/TextMesh Pro/Resources/Shaders/TMP_Bitmap-Mobile.shader
            "128e987d567d4e2c824d754223b3f3b0", // Assets/TextMesh Pro/Resources/Shaders/TMP_Bitmap.shader
            "dd89cf5b9246416f84610a006f916af7", // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF Overlay.shader
            "bc1ede39bf3643ee8e493720e4259791", // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF-Mobile Masking.shader
            "a02a7d8c237544f1962732b55a9aebf1", // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF-Mobile Overlay.shader
            "fe393ace9b354375a9cb14cdbbc28be4", // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF-Mobile.shader
            "85187c2149c549c5b33f0cdb02836b17", // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF-Surface-Mobile.shader
            "f7ada0af4f174f0694ca6a487b8f543d", // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF-Surface.shader
            "68e6db2ebdc24f95958faec2be5558d6", // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF.shader
            "cf81c85f95fe47e1a27f6ae460cf182c", // Assets/TextMesh Pro/Resources/Shaders/TMP_Sprite.shader
            "512a49d95c0c4332bdd98131869c23c9", // Assets/TextMesh Pro/Resources/Sprite Assets
            "c41005c129ba4d66911b75229fd70b45", // Assets/TextMesh Pro/Resources/Sprite Assets/EmojiOne.asset
            "4aecb92fff08436c8303b10eab8da368", // Assets/TextMesh Pro/Resources/Style Sheets
            "f952c082cb03451daed3ee968ac6c63e", // Assets/TextMesh Pro/Resources/Style Sheets/Default Style Sheet.asset
            "d0603b6d5186471b96c778c3949c7ce2", // Assets/TextMesh Pro/Sprites
            "381dcb09d5029d14897e55f98031fca5", // Assets/TextMesh Pro/Sprites/EmojiOne Attribution.txt
            "8f05276190cf498a8153f6cbe761d4e6", // Assets/TextMesh Pro/Sprites/EmojiOne.json
            "dffef66376be4fa480fb02b19edbe903", // Assets/TextMesh Pro/Sprites/EmojiOne.png
            #endregion
            #region ParaketAssets
            "f7565a76f74bb134ab7836e63746e930", // Assets/ParaketAssets
            "3d265ec0b5281274cbda127f6086f4c8", // Assets/ParaketAssets/Prefabs
            "727203c3dc70fb64ca97c25804554dd1", // Assets/ParaketAssets/Prefabs/Canvas.prefab
            "331165ef1ce1fc04d926554c5ca706e9", // Assets/ParaketAssets/Prefabs/Chair.prefab
            "4372354f0085d414fa16a355c8de244e", // Assets/ParaketAssets/Prefabs/LICENSE.txt
            "84a3dfcb7e1c0644c9618e91e2fe71d7", // Assets/ParaketAssets/Prefabs/PointLightProbe.prefab
            "dd4b2a2805fc06c4da1e2a1f59ea3aa1", // Assets/ParaketAssets/Prefabs/verision.txt
            "8a9e6b318bb28c34fb87abf265891f5a", // Assets/ParaketAssets/Prefabs/AudioSource
            "30766b1bee81dc84789f758f8ccafc3c", // Assets/ParaketAssets/Prefabs/AudioSource/2D_Sound_Fade.prefab
            "e4309533ddcc0af4d90979c8c9e4f4d4", // Assets/ParaketAssets/Prefabs/AudioSource/3D_Sound.prefab
            "8122627ebf7222c4082d986a54a14172", // Assets/ParaketAssets/Prefabs/AudioSource/Animations
            "a98a87e55100a8143af2c222a23d8181", // Assets/ParaketAssets/Prefabs/AudioSource/Animations/FadeController.controller
            "966be7ac16ceaa54cbcbc6afbec7c0b6", // Assets/ParaketAssets/Prefabs/AudioSource/Animations/FadeIn.anim
            "8927e72d40cb1eb4d86086e8503388db", // Assets/ParaketAssets/Prefabs/AudioSource/Animations/FadeOut.anim
            "edcb8b3ae428ca541be6d2431d58b3cd", // Assets/ParaketAssets/Prefabs/AudioSource/Animations/Press_Legacy-Vket.anim
            "b680381bbde7f6f4ba0e6f9236048b54", // Assets/ParaketAssets/Prefabs/AudioSource/Audio
            "052acfe968ab43148aa8eaa643f66821", // Assets/ParaketAssets/Prefabs/AudioSource/Audio/BGM Sample P=-3 RMS=-12.wav
            "7be99af741c44d144ae17ce2fbde34af", // Assets/ParaketAssets/Prefabs/AudioSource/Audio/SFX Sample P=-2 RMS=-13.wav
            "741a8f29ce7711b40ba9ff1ba3b2c725", // Assets/ParaketAssets/Prefabs/AvatarPedestal
            "2420262520fe2b143a9d3413b70574db", // Assets/ParaketAssets/Prefabs/AvatarPedestal/AvatarPedestal_2D_L.prefab
            "fbca34af6d486cb42ac14f5604789b7d", // Assets/ParaketAssets/Prefabs/AvatarPedestal/AvatarPedestal_2D_M.prefab
            "649adcdb08990e34fbc373863359df2b", // Assets/ParaketAssets/Prefabs/AvatarPedestal/AvatarPedestal_2D_S.prefab
            "e07be743236e7dc4596cfaeb69b0cec8", // Assets/ParaketAssets/Prefabs/AvatarPedestal/AvatarPedestal_3D_L.prefab
            "90a359274811fae47831f33279efad2d", // Assets/ParaketAssets/Prefabs/AvatarPedestal/AvatarPedestal_3D_M.prefab
            "fe945fa7fd2c9054c8cb2d4b81699e29", // Assets/ParaketAssets/Prefabs/AvatarPedestal/AvatarPedestal_3D_S.prefab
            "d1aad97f348bb4440a5edc6a3fa7fcf0", // Assets/ParaketAssets/Prefabs/AvatarPedestal/AvatarPedestal_Default_L.prefab
            "8f1ab25d540d48745985106efdf88b32", // Assets/ParaketAssets/Prefabs/AvatarPedestal/AvatarPedestal_Default_M.prefab
            "f53a92f1d91eefd48b170b20927d33f6", // Assets/ParaketAssets/Prefabs/AvatarPedestal/AvatarPedestal_Default_S.prefab
            "e8d6061628d7c7349b0576efe48a5646", // Assets/ParaketAssets/Prefabs/AvatarPedestal/Animation
            "823f04b7ea9337e44b5df0733f7a1a27", // Assets/ParaketAssets/Prefabs/AvatarPedestal/Animation/Active.anim
            "adaf73e6fe8633a4fb0696268d973d16", // Assets/ParaketAssets/Prefabs/AvatarPedestal/Animation/AvatarPedestal.controller
            "bc8e5f4af458d3d4abb6d944fe77eaec", // Assets/ParaketAssets/Prefabs/AvatarPedestal/Animation/Deactive.anim
            "64f4a41f4130972439f6e6038441c8ee", // Assets/ParaketAssets/Prefabs/AvatarPedestal/Animation/Idle.anim
            "3793765e4a0d9c14cbc8abd2818662da", // Assets/ParaketAssets/Prefabs/AvatarPedestal/Materials
            "0de3ccc1017c4a045a4fed5f810c2748", // Assets/ParaketAssets/Prefabs/AvatarPedestal/Materials/UI-Lookat.mat
            "ad49b296a90103b44a002f0c3f26d9c7", // Assets/ParaketAssets/Prefabs/AvatarPedestal/Shaders
            "d35acdd70bdcab445bbbd6deac832a3b", // Assets/ParaketAssets/Prefabs/AvatarPedestal/Shaders/UI-Lookat.shader
            "18dd2d647d5a5a547b251f806478d13b", // Assets/ParaketAssets/Prefabs/AvatarPedestal/Textures
            "834f21d704cafe3498f4d2ecc38dc5ea", // Assets/ParaketAssets/Prefabs/AvatarPedestal/Textures/Background.png
            "86487b9f4f81a774a9c49d53278c76cf", // Assets/ParaketAssets/Prefabs/AvatarPedestal/Textures/Button.png
            "62f7352a395147043809a2d315af37ae", // Assets/ParaketAssets/Prefabs/AvatarPedestal/Textures/Change Avatar.png
            "96c692c63aeba764081c1e04790fd3f1", // Assets/ParaketAssets/Prefabs/AvatarPedestal/Textures/Sample.png
            "ba87c46b28d7b5d4bbc08033534f4d73", // Assets/ParaketAssets/Prefabs/PickupObjectSync
            "f24f91ef4a3f5aa4dbba6114f22ff85a", // Assets/ParaketAssets/Prefabs/PickupObjectSync/AnimationPickupOverrideEmpty.overrideController
            "1c13412f710ee6f429cde5858575c225", // Assets/ParaketAssets/Prefabs/PickupObjectSync/AnimationPickup_Large.prefab
            "29904c5b13768154bb4056beab9fa3d1", // Assets/ParaketAssets/Prefabs/PickupObjectSync/AnimationPickup_Long.prefab
            "e92515ba689fb0b4f8d45b7f2e3e8f46", // Assets/ParaketAssets/Prefabs/PickupObjectSync/AnimationPickup_Small.prefab
            "d6df6cb557aadb34db36e3e1f504a4db", // Assets/ParaketAssets/Prefabs/PickupObjectSync/SimplePickup_Large.prefab
            "2ddf6495f088e214894068e967b329a6", // Assets/ParaketAssets/Prefabs/PickupObjectSync/SimplePickup_Long.prefab
            "bc67edeb6db9ffb438e33ad436221244", // Assets/ParaketAssets/Prefabs/PickupObjectSync/SimplePickup_Small.prefab
            "1e62f3e5a8e3e1b49ab3d6efed93c77c", // Assets/ParaketAssets/Prefabs/PickupObjectSync/Animations
            "6c18e32b6acd94b4d9fa8ee59255a862", // Assets/ParaketAssets/Prefabs/PickupObjectSync/Animations/ModeController.controller
            "c21fdaf2c6687f544b34ee847fcc7cdc", // Assets/ParaketAssets/Prefabs/PickupObjectSync/Animations/PickupAnimation.fbx
            "c38556d80f09fff4d9941877e40e862c", // Assets/ParaketAssets/Prefabs/PickupObjectSync/Animations/Press-Vket.anim
            "76d626a7ca5e88343b37af2593d78ca0", // Assets/ParaketAssets/Prefabs/PickupObjectSync/Animations/ResetPosition.controller
            #endregion
            #region Dynamic Bone
            "e6ba56ede2604dd4082ed2d0b4f435dd", // Assets/DynamicBone
            "bdbe6feeda2a62b45ad9a4e311031478", // Assets/DynamicBone/ReadMe.txt
            "21a42390d25252341a66bc19a8addaea", // Assets/DynamicBone/Demo
            "ba128457d0ea5e3439dbe4a53b9d1273", // Assets/DynamicBone/Demo/c1.fbx
            "902c84bf971339c459ce4b757e333a55", // Assets/DynamicBone/Demo/Demo1.unity
            "178320cedf292cb4f8d6c0b737b35953", // Assets/DynamicBone/Demo/DynamicBoneDemo1.cs
            "19015a5957bbaa745a61cba005220542", // Assets/DynamicBone/Demo/tail.FBX
            "993edbffbda2d3e4abd24f1bf074c5f2", // Assets/DynamicBone/Scripts
            "f9ac8d30c6a0d9642a11e5be4c440740", // Assets/DynamicBone/Scripts/DynamicBone.cs
            "baedd976e12657241bf7ff2d1c685342", // Assets/DynamicBone/Scripts/DynamicBoneCollider.cs
            "04878769c08021a41bc2d2375e23ec0b", // Assets/DynamicBone/Scripts/DynamicBoneColliderBase.cs
            "4e535bdf3689369408cc4d078260ef6a", // Assets/DynamicBone/Scripts/DynamicBonePlaneCollider.cs
            #endregion
        };

        public static string[] OfficialPrefabs => new[]
        {
            AvatarPedestalPrefabGUIDs,
            PickupObjectSyncPrefabGUIDs,
            ChairPrefabGUIDs,
            AudioSourcePrefabGUIDs,
        }.SelectMany(guids => guids).ToArray();

        public static readonly string[] AvatarPedestalPrefabGUIDs = new[]
        {
            "f53a92f1d91eefd48b170b20927d33f6", // Assets/ParaketAssets/Prefabs/AvatarPedestal/AvatarPedestal_Default_S.prefab
            "e07be743236e7dc4596cfaeb69b0cec8", // Assets/ParaketAssets/Prefabs/AvatarPedestal/AvatarPedestal_3D_L.prefab
            "2420262520fe2b143a9d3413b70574db", // Assets/ParaketAssets/Prefabs/AvatarPedestal/AvatarPedestal_2D_L.prefab
            "90a359274811fae47831f33279efad2d", // Assets/ParaketAssets/Prefabs/AvatarPedestal/AvatarPedestal_3D_M.prefab
            "fe945fa7fd2c9054c8cb2d4b81699e29", // Assets/ParaketAssets/Prefabs/AvatarPedestal/AvatarPedestal_3D_S.prefab
            "649adcdb08990e34fbc373863359df2b", // Assets/ParaketAssets/Prefabs/AvatarPedestal/AvatarPedestal_2D_S.prefab
            "8f1ab25d540d48745985106efdf88b32", // Assets/ParaketAssets/Prefabs/AvatarPedestal/AvatarPedestal_Default_M.prefab
            "d1aad97f348bb4440a5edc6a3fa7fcf0", // Assets/ParaketAssets/Prefabs/AvatarPedestal/AvatarPedestal_Default_L.prefab
            "fbca34af6d486cb42ac14f5604789b7d", // Assets/ParaketAssets/Prefabs/AvatarPedestal/AvatarPedestal_2D_M.prefab
        };

        public static readonly string[] PickupObjectSyncPrefabGUIDs = new[]
        {
            "2ddf6495f088e214894068e967b329a6", // Assets/ParaketAssets/Prefabs/PickupObjectSync/SimplePickup_Long.prefab
            "d6df6cb557aadb34db36e3e1f504a4db", // Assets/ParaketAssets/Prefabs/PickupObjectSync/SimplePickup_Large.prefab
            "e92515ba689fb0b4f8d45b7f2e3e8f46", // Assets/ParaketAssets/Prefabs/PickupObjectSync/AnimationPickup_Small.prefab
            "29904c5b13768154bb4056beab9fa3d1", // Assets/ParaketAssets/Prefabs/PickupObjectSync/AnimationPickup_Long.prefab
            "bc67edeb6db9ffb438e33ad436221244", // Assets/ParaketAssets/Prefabs/PickupObjectSync/SimplePickup_Small.prefab
            "1c13412f710ee6f429cde5858575c225", // Assets/ParaketAssets/Prefabs/PickupObjectSync/AnimationPickup_Large.prefab
        };

        public static readonly string[] ChairPrefabGUIDs = new[]
        {
            "331165ef1ce1fc04d926554c5ca706e9", // Assets/ParaketAssets/Prefabs/Chair.prefab
        };

        public static readonly string[] AudioSourcePrefabGUIDs = new[]
        {
            "e4309533ddcc0af4d90979c8c9e4f4d4", // Assets/ParaketAssets/Prefabs/AudioSource/3D_Sound.prefab
            "30766b1bee81dc84789f758f8ccafc3c", // Assets/ParaketAssets/Prefabs/AudioSource/2D_Sound_Fade.prefab
        };
    }
}
