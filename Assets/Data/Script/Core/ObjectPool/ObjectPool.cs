using System;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Script.Core
{
    [Serializable]
    public class ObjectPool
    {
        private List<IBaseUpdater> baseUpdaters;

        public List<IBaseUpdater> getUpdates => baseUpdaters;

        public ObjectPool(object obj)
        {
            baseUpdaters = new List<IBaseUpdater>();
        }

        #region Setter
        public void SetBaseUpdater(IBaseUpdater updater)
        {
            if (!baseUpdaters.Contains(updater))
            {
                baseUpdaters.Add(updater);
            }
        }

        public void SetBaseUpdaters(IBaseUpdater[] updaters)
        {
            foreach (var updater in updaters)
            {
                SetBaseUpdater(updater);
            }
        }
        #endregion

        #region Remove
        public void RemoveUpdater(IBaseUpdater updater)
        {
            if (baseUpdaters.Contains(updater))
            {
                baseUpdaters.Remove(updater);
            }
        }

        public void RemoveUpdaters(IBaseUpdater[] updaters)
        {
            foreach (var updater in updaters)
            {
                RemoveUpdater(updater);
            }
        }
        #endregion

        public T InstantiateBaseObject<T>(ObjectModel objectModel) where T : BaseObject
        {
            GameObject tempObject = (objectModel.Origin != null) ? objectModel.Origin : new GameObject();

            var instant = GameObject.Instantiate(tempObject).AddComponent<T>();

            if (objectModel.Parent)
            {
                instant.transform.SetParent(objectModel.Parent);
            }

            instant.transform.position = objectModel.OptionsModel.Position;
            instant.transform.rotation = objectModel.OptionsModel.Rotation;
            instant.transform.localScale = objectModel.OptionsModel.Scale;
            instant.name = objectModel.ObjectName;

            BaseObject[] objects = instant.GetComponents<BaseObject>();

            SetObjectPool(objects);

            GameObject.Destroy(tempObject);

            return instant;
        }

        public GameObject SpawnObjectInObjectPool(ObjectModel objectModel)
        {
            var newObject = GameObject.Instantiate(objectModel.Origin);

            if (objectModel.Parent)
            {
                newObject.transform.SetParent(objectModel.Parent);
            }

            newObject.transform.position = objectModel.OptionsModel.Position;
            newObject.transform.rotation = objectModel.OptionsModel.Rotation;
            newObject.transform.localScale = objectModel.OptionsModel.Scale;
            newObject.name = objectModel.ObjectName;

            BaseObject[] baseObjects = newObject.GetComponentsInChildren<BaseObject>();

            SetObjectPool(baseObjects);

            return newObject;
        }

        private void SetObjectPool(BaseObject[] objects)
        {
            foreach (var obj in objects)
            {
                obj.SetObjectPool(this);
                obj.BaseAwake();
            }
        }
    }
}