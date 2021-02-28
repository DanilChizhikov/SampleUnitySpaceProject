using UnityEngine;

namespace Data.Script.Core.Paterns.Singletone
{
    public class Singleton<T> : SingletoneBase where T : SingletoneBase
    {
        protected static T _instance;
        public static T instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<T>();
                    if (_instance == null)
                    {
                        Debug.LogError("Can't find " + typeof(T) + "!");
                    }
                }
                return _instance;
            }
            set => _instance = value;
        }
    }
}
