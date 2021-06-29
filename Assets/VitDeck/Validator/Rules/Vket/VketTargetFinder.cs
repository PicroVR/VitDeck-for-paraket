using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using VitDeck.Language;
using VitDeck.Main;
using Object = UnityEngine.Object;

namespace VitDeck.Validator
{
    public class VketTargetFinder : IValidationTargetFinder
    {
        bool finded = false;

        string[] assetGUIDs;
        Object[] assetObjects;
        string[] assetPaths;
        GameObject[] rootObjects;
        GameObject[] allObjects;
        Scene[] scenes;
        ValidationTarget target;
        
        public IReadonlyReferenceDictionary ReferenceDictionary { get; private set; }

        private void FindInternal(string baseFolder, bool forceOpenScene = false)
        {
            if (!Directory.Exists(baseFolder))
            {
                throw new FatalValidationErrorException(LocalizedMessage.Get("VketTargetFinder.PackageFolderNotFound"));
            }

            var exhibitorID = Path.GetFileName(baseFolder);

            var targetScene = GUIUtilities.OpenPackageScene(exhibitorID);

            scenes = new Scene[] { targetScene };
            var exhibitRootObject = GetExhibitRootObject(exhibitorID, targetScene);

            rootObjects = new GameObject[] { exhibitRootObject };

            allObjects = exhibitRootObject
                .GetComponentsInChildren<Transform>(true)
                .Select(tf => tf.gameObject)
                .ToArray();

            ReferenceDictionary = GetContainsAndReferredAssets(baseFolder, allObjects);
            assetObjects = ReferenceDictionary.Reverse.Keys
                .Where(asset => AssetDatabase.GetAssetPath(asset).StartsWith("Assets/"))
                .ToArray();

            assetPaths = assetObjects
                .Select(asset => AssetDatabase.GetAssetPath(asset))
                .ToArray();

            assetGUIDs = assetPaths
                .Select(path => AssetDatabase.AssetPathToGUID(path))
                .ToArray();

            target = new ValidationTarget(
                baseFolder,
                assetGUIDs,
                assetPaths,
                assetObjects,
                scenes,
                rootObjects,
                allObjects);

            finded = true;
        }

        private static GameObject GetExhibitRootObject(string exhibitorID, Scene targetScene)
        {
            var exhibitRootObjects = targetScene
                .GetRootGameObjects()
                .Where(obj => obj.name == exhibitorID)
                .ToArray();

            if (exhibitRootObjects.Length == 0)
            {
                throw new FatalValidationErrorException(LocalizedMessage.Get("VketTargetFinder.ExhibitNotFound"));

            }
            else if (exhibitRootObjects.Length > 1)
            {
                throw new FatalValidationErrorException(LocalizedMessage.Get("VketTargetFinder.ManyExhibits"));
            }
            else
            {
                return exhibitRootObjects[0];
            }
        }

        private static IReadonlyReferenceDictionary GetContainsAndReferredAssets(string baseFolder, GameObject[] gameObjects)
        {
            var referenceChain = UnityObjectReferenceChain
                .ExploreFrom(
                    Enumerable.Concat(
                        VitDeck.Utilities.AssetUtility.EnumerateAssets(baseFolder),
                        gameObjects
                    ));

            return referenceChain.Result;
        }


        #region Interface Imprements

        public ValidationTarget Find(string baseFolder, bool forceOpenScene = false)
        {
            FindInternal(baseFolder, forceOpenScene);

            return target;
        }

        public GameObject[] FindAllObjects(string baseFolderPath, bool forceOpenScene = false)
        {
            if (!finded)
            {
                FindInternal(baseFolderPath, forceOpenScene);
            }

            return allObjects;
        }

        public string[] FindAssetGuids(string baseFolderPath)
        {
            if (!finded)
            {
                FindInternal(baseFolderPath);
            }

            return assetGUIDs;
        }

        public Object[] FindAssetObjects(string baseFolderPath)
        {
            if (!finded)
            {
                FindInternal(baseFolderPath);
            }

            return assetObjects;
        }

        public string[] FindAssetPaths(string baseFolderPath)
        {
            if (!finded)
            {
                FindInternal(baseFolderPath);
            }

            return assetPaths;
        }

        public GameObject[] FindRootObjects(string baseFolderPath, bool forceOpenScene = false)
        {
            if (!finded)
            {
                FindInternal(baseFolderPath, forceOpenScene);
            }

            return rootObjects;
        }

        public Scene[] FindScenes(string baseFolderPath, bool forceOpenScene = false)
        {
            if (!finded)
            {
                FindInternal(baseFolderPath);
            }

            return scenes;
        }

        #endregion
    }
}