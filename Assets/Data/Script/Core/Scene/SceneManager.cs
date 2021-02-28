using Data.Script.Core.Paterns.Singletone;
using Data.Script.Core.Scene;
using System.Collections;
using UnityEngine;

namespace Data.Script.Core.Scenes
{
    public class SceneManager : Singleton<SceneManager>
    {
        [SerializeField] private TypeLoad type;
        private ObjectPool objectPool;
        private bool isSceneWasLoaded = false;
        [SerializeField] private ScenesBuilderDataPath builderDataPath;
        private IEnumerator initCorutine;

        public ObjectPool getObjectPool => objectPool;

        private void Start()
        {
            initCorutine = Initilization();

            StartCoroutine(initCorutine);
        }

        private void Update()
        {
            if (isSceneWasLoaded)
            {
                foreach(var update in objectPool.getUpdates)
                {
                    if (update.IsActive) update.BaseUpdate();
                }
            }
        }

        private IEnumerator Initilization()
        {
            instance = this;

            objectPool = new ObjectPool(this);

            switch (type)
            {
                case TypeLoad.Find:
                    {
                        IBaseUpdater[] baseUpdaters = FindObjectsOfType<BaseObject>();

                        objectPool.SetBaseUpdaters(baseUpdaters);

                        foreach (var obj in objectPool.getUpdates)
                            obj.BaseAwake();
                    }
                    break;
                case TypeLoad.Build:
                default:
                    {
                        SceneBuilder.instance.BuildScenes(builderDataPath);

                        yield return new WaitUntil(() => SceneBuilder.instance.IsReady);

                        SceneBuilder.instance.DestroyBuilder();
                    }
                    break;
            }

            foreach (var obj in objectPool.getUpdates)
                obj.SetActive(obj.IsActive);

            GamePause.instance.IsPaused = false;
            isSceneWasLoaded = true;

            StopCoroutine(initCorutine);
        }
    }
}
