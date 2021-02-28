using Data.Script.Core.Paterns.Singletone;
using Data.Script.Inputs;
using UnityEngine;

namespace Data.Script.Core.Scene
{
    public class GamePause : Singleton<GamePause>, IPause
    {
        public override void SingletoneAwake()
        {
            instance = this;
        }

        public bool IsPaused { get; set; }

        private void LateUpdate()
        {
            if (InputManager.instance.GetEscape()) Pause();
        }

        public void Pause()
        {
            IsPaused = !IsPaused;
            if (!IsPaused) Time.timeScale = 1f;
            else Time.timeScale = 0f;
        }
    }
}
