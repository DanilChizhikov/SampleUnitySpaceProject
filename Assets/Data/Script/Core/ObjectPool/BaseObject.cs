using UnityEngine;

namespace Data.Script.Core
{
    public class BaseObject : MonoBehaviour, IBaseUpdater
    {
        public bool IsActive { get; set; } = true;

        private ObjectPool objectPool;

        public void SetObjectPool(ObjectPool pool) => objectPool = pool;

        public virtual void BaseAwake()
        {}

        public virtual void BaseUpdate()
        {}

        public void SetActive(bool isFlag)
        {
            IsActive = isFlag;
            gameObject.SetActive(IsActive);
        }
    }
}
