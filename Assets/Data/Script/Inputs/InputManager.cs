using Data.Script.Core.Inputs;
using Data.Script.Core.Paterns.Singletone;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Data.Script.Inputs
{
    public class InputManager : Singleton<InputManager>
    {
        private PlayerControl inputs;

        public Vector2 getMoveDirection => inputs.Player.Move.ReadValue<Vector2>();
        public float getMoveYDirection => inputs.Player.MoveY.ReadValue<float>();
        public float getRollDirection => inputs.Player.Roll.ReadValue<float>();

        public override void SingletoneAwake()
        {
            instance = this;
            inputs = new PlayerControl();
            inputs.Enable();
        }

        public bool GetEscape() => InputSystem.GetDevice<Keyboard>().escapeKey.wasPressedThisFrame;

        public void SetActiveInputs(bool isFlag)
        {
            if (isFlag) inputs.Enable();
            else inputs.Disable();
        }
    }
}
