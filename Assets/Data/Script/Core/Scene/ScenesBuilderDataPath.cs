using UnityEngine;

namespace Data.Script.Core.Scenes
{
    [CreateAssetMenu(menuName = "Builder/DataPath", fileName = "Builder DataPath", order = 51)]
    public class ScenesBuilderDataPath : ScriptableObject
    {
        [SerializeField] private string[] objectsPath;

        public string[] GetObjectsPath => objectsPath;
    }
}