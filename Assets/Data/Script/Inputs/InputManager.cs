using Data.Script.Core.Inputs;
using Data.Script.Core.Paterns.Singletone;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Data.Script.Inputs
{
    public class InputManager : Singleton<InputManager>
    {
        private PlayerControl inputs;

        public override void SingletoneAwake()
        {
            instance = this;
            inputs = new PlayerControl();
            inputs.Enable();
        }

        public Vector2 GetMoveDirection() => inputs.Player.Move.ReadValue<Vector2>();

        public Axies GetUpDown()
        {
            var result = Axies.Non;

            bool up = inputs.Player.Upping.triggered;
            bool down = inputs.Player.Down.triggered;

            if (up && !down) result = Axies.Up;
            else if (!up && down) result = Axies.Down;
            else if (!up && !down) result = Axies.Non;
            else if (up && down) result = Axies.Non;
            
            return result;
        }

        public Axies GetRoll()
        {
            var result = Axies.Non;

            bool left = inputs.Player.RollLeft.triggered;
            bool right = inputs.Player.RollRight.triggered;

            if (left && !right) result = Axies.Left;
            else if (!left && right) result = Axies.Right;
            else if (!left && !right) result = Axies.Non;
            else if (left && right) result = Axies.Non;

            return result;
        }

        public bool GetEscape()
        {
            var result = false;
            Keyboard keyboard = InputSystem.GetDevice<Keyboard>();

            result = keyboard.escapeKey.wasPressedThisFrame;

            return result;
        }

        public void SetActiveInputs(bool isFlag)
        {
            if (isFlag) inputs.Enable();
            else inputs.Disable();
        }
    }
}
