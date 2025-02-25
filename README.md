# VitDeck パラレルマーケットカスタムバージョン

本ツールは、フォーク元である VitDeck-for-vket を、[パラレルマーケット](https://www.paraket.jp/)向けに改変したものです。

改変部分のライセンスについては MIT を継承しています。

以下は、フォーム元のREADMEです。

--------------------------------------------------------------------------------

# VitDeckについて
VitDeckは多人数で特定のルールに沿ったUnityのアセットを同時に制作するプロジェクトを支援するツールです。
![about](/images/about_vitdeck.png)

以下の機能を持っています。
- テンプレートから作成：
  - 管理者が事前に準備したテンプレート（フォルダ構成やモデル、シーンファイル等）を複製し、提出用アセットの作成を開始する
- ルールチェック：
  - シーン内のオブジェクトが管理者が構成したルールに沿っているかチェックする
- 提出パッケージ作成：
  - 提出用のUnitypackageを作成する
- ツールアップデート：
  - テンプレートやルールの最新版を管理者のサーバーからダウンロードして更新する

作業管理者が事前にテンプレートおよびチェック用のルールを構成した上で作業者に配布することを前提にしています。
# インストール方法
[最新のリリース](https://github.com/vitdeck/VitDeck/releases/latest)のunitypackageをダウンロードし、VitDeckを使用したいUnityプロジェクトにインポートしてください。
正しくインポートされるとUnityのメニューバーに`VitDeck`が表示されます。

# 各機能の使い方
## テンプレートから作成 (Load template)
テンプレートを選んで必要事項を入力し、`Load`ボタンを押すとプロジェクトのAssetsフォルダ直下にテンプレートの複製が作成されます。
![TemplateLoader](/images/TemplateLoader.gif)

## ルールチェック (Check rule)
検証用のルールセットとベースフォルダ（提出用のルートフォルダ）を指定して`Check`ボタンを押すとベースフォルダ内のシーンファイルがチェックされます。（※複数シーンファイルには対応していません）
![Validator](/images/Validator.gif)

## 提出パッケージ作成 (Export Booth)
提出用のベースフォルダを指定して`Export`ボタンを押すと運営が設定したルールに沿っているか検証した後、フォルダ以下のアセットを全て含むunitypackageが作成されます。
![Expoter](/images/Expoter.gif)

## ツールアップデート
管理者がアップデートを構成している場合、Unityメニューバーの`VitDeck＞Info`からアップデートがあるか確認できます。
![Updater](/images/Updater.png)

# ツール構成方法
VitDeckを配布する前に管理者が各機能を構成する方法は以下を参照してください。
- [テンプレートの作成方法](https://github.com/vitdeck/VitDeck/wiki/MakingTemplate)
- [ルールセットの作成方法](https://github.com/vitdeck/VitDeck/wiki/MakingRuleSet)
- [エクスポート設定の作成方法](https://github.com/vitdeck/VitDeck/wiki/MakingExportSetting)
- [アップデート通知の構成](https://github.com/vitdeck/VitDeck/wiki/ConfiguringUpdateNortification)

# 検証可能なルール
VitDeckでは検証したいルールの組み合わせとその設定をルールセットと呼ばれる単位で管理します。
管理者は最初に[ルールセットを構成](https://github.com/vitdeck/VitDeck/wiki/MakingRuleSet)してください。

```csharp
namespace VitDeck.Validator
{
    public class SampleRuleSet : BaseRuleSet
    {
        public override string RuleSetName
        {
            get { return "サンプルルールセット"; }
        }
        [Validation]
        public IRule unityVersionRule = new UnityVersionRule("[U01]Unityバージョンルール", "2017.4.28f1");
        [Validation]
        public IRule assetNamingRule = new AssetNamingRule("[A01]アセット名の使用禁止文字ルール", @"[a-zA-Z0-9 _\.\-]+");
        [Validation]
        public IRule assetGuidBlacklistRule = new AssetGuidBlacklistRule("[A02]特定のGUIDを持つアセットの検出ルール",
            new string[] { "740112f6e77ca914d9c26eef5d68accd", "ae68339621fb41b4f9905188526120ea" });
        ...
```

以下のルールが最初から利用でき、独自ルール（C#で記述）も定義可能です。
- 指定のUnityバージョンで動作しているか検証
- アセット名の使用禁止文字の検出
- 特定のGUIDを持つアセットの検出
- アセットの長すぎるパスの検出
- 特定の拡張子を持つアセットの検出
- ブースがBounds内に収まっているかの検証
- コンポーネントのホワイトリスト検証
- コンポーネントのブラックリスト検証
- エラーシェーダーの検出
- Noneになっているメッシュの検出
- missingになっている参照の検出

# アンインストール方法
プロジェクトの`Assets`フォルダ内の`VitDeck`フォルダをまるごと削除してください。

# 動作環境
以下の環境でテストしています。
- Windows 10
- Unity 2017.4.28f1

# License
Copyright (c) 2019 VitDeck

Released under the MIT license.
