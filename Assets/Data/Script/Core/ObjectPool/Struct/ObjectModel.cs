using UnityEngine;

namespace Data.Script.Core
{
    public struct ObjectModel
    {
        private GameObject origin;
        private Transform parent;
        private ObjectOptionsModel optionsModel;
        private string objectName;

        public GameObject Origin { get => origin; }
        public Transform Parent { get => parent; }
        public ObjectOptionsModel OptionsModel { get => optionsModel; }
        public string ObjectName { get => objectName; }

        public ObjectModel(GameObject _origin, Transform _parent, ObjectOptionsModel _optionsModel, string _objectName)
        {
            origin = _origin;
            parent = _parent;
            optionsModel = _optionsModel;
            objectName = _objectName;
        }
    }
}
