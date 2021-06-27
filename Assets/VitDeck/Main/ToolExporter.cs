using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using UnityEngine;
using UnityEditor;
using VitDeck.Utilities;

namespace VitDeck.Main
{
    /// <summary>
    /// VitDeck自体のunitypackageを作成し、デスクトップへ出力します。
    /// </summary>
    internal class ToolExporter
    {
        private static readonly string DestinationFolderPath
            = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

        private static readonly Regex IgnorePattern = new Regex(@"^Assets/VitDeck/(
            Main/ToolExporter\.cs
            |Utilities/GUIDEnumerator\.cs
            |Placement(/.+)?
            |Temporary(/.+)?
            |.+/Tests/.+
            |TestUtilities(/.+)?
            |Templates/(Sample_template|0.+)(/.+)?
            |Validator/Rules/Sample(/.+)?
            |Config/(UserSettings|DefaultExportSetting.*|PlacementSettings|Vket.+)\.asset
        )$", RegexOptions.ExplicitCapture | RegexOptions.IgnorePatternWhitespace);

        private static readonly IEnumerable<string> OtherResourceRootPaths = new[]
        {
            "Assets/ParaketAssets",
        };

        private static string GetPackageName()
        {
            return $"{ProductInfoUtility.GetDeveloperLinkTitle().Replace(" ", "-")}-{ProductInfoUtility.GetVersion()}.unitypackage";
        }

        [MenuItem("VitDeck/Export VitDeck", false, 201)]
        private static void Export()
        {
            ToolExporter.SaveReleaseInfo();
            AssetDatabase.ExportPackage(
                AssetDatabase.GetAllAssetPaths().Where(path => path == JsonReleaseInfo.VitDeckRootPath
                    || path.StartsWith(JsonReleaseInfo.VitDeckRootPath + "/") && !ToolExporter.IgnorePattern.IsMatch(path)
                    || ToolExporter.OtherResourceRootPaths.Any(otherResourceRootPath => path.StartsWith(otherResourceRootPath)))
                    .ToArray(),
                Path.Combine(ToolExporter.DestinationFolderPath, ToolExporter.GetPackageName())
            );
        }

        private static void SaveReleaseInfo()
        {
            File.WriteAllText(Path.Combine(
                Path.GetDirectoryName(Application.dataPath),
                JsonReleaseInfo.VitDeckRootPath,
                JsonReleaseInfo.JsonReleaseInfoPath
            ), JsonUtility.ToJson(new JsonReleaseInfo.ReleaseInfo()
            {
                version = ProductInfoUtility.GetVersion(),
                package_name = ProductInfoUtility.GetDeveloperLinkTitle(),
                download_url = $"{ProductInfoUtility.GetDeveloperLinkURL()}/releases/download/v{ProductInfoUtility.GetVersion()}/{ToolExporter.GetPackageName()}",
            }, true));
            AssetDatabase.Refresh();
        }
    }
}
