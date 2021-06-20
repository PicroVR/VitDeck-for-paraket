// Author: 100の人
// Distribution URL: https://gist.github.com/esperecyan/996e0b2af62f4ac6e0a336597836750e
// SPDX-License-Identifier: CC0-1.0
using UnityEditor;

namespace Esperecyan.Unity
{
    public class NeverCompressAssetsOnImport
    {
        [InitializeOnLoadMethod]
        private static void Run()
        {
            Unsupported.SetApplicationSettingCompressAssetsOnImport(false);
        }
    }
}
