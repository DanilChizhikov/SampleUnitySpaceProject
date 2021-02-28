using Data.Script.Core.Paterns.Singletone;
using System.Collections;
using UnityEngine;

namespace Data.Script.Core.Scenes
{
    public class SceneBuilder : Singleton<SceneBuilder>, ISceneBuilder
    {
        public bool IsReady { get; set; } = false;

        public void BuildScenes(ScenesBuilderDataPath builderDataPath)
        {
            StartCoroutine(Build(builderDataPath));
        }

        private IEnumerator Build(ScenesBuilderDataPath builderDataPath)
        {
            yield return new WaitForEndOfFrame();

            GameObject[] instantObject = null;
            ObjectModel orguments;

            foreach(var path in builderDataPath.GetObjectsPath)
            {
                instantObject = Resources.LoadAll<GameObject>(path);

                foreach(var obj in instantObject)
                {
                    orguments = new ObjectModel(obj, null,
                        new ObjectOptionsModel(
                            obj.transform.position, 
                            obj.transform.rotation, 
                            obj.transform.localScale),
                        obj.name);

                    SceneManager.instance.getObjectPool.SpawnObjectInObjectPool(orguments);
                }
            }

            IsReady = true;
        }

        public void DestroyBuilder() => Destroy(gameObject);
    }
}
