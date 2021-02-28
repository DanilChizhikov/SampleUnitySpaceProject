using Data.Script.Core.Ships;
using Data.Script.Inputs;
using UnityEngine;

namespace Data.Script.Core.Player
{
    public class Character : BaseObject, ICharacter
    {
        [SerializeField] private string namePlayer;
        [SerializeField] private Ship currentShip;
        public string Name { get => namePlayer; set => namePlayer = value; }
        public Ship CurrentShip { get => currentShip; set => currentShip = value; }

        public override void BaseUpdate()
        {
            var moveDirection = InputManager.instance.GetMoveDirection();
            var upDirection = InputManager.instance.GetUpDown();
            var rollDirection = InputManager.instance.GetRoll();

            Move(moveDirection);
            MoveUpDown(upDirection);
            Roll(rollDirection);
        }

        public void Move(Vector2 direction)
        {
            if (direction.sqrMagnitude < 0.1f) return;

            float scaleMoveSpeed = CurrentShip.CurrentSpeed * Time.deltaTime;
            Vector3 move = Quaternion.Euler(0, currentShip.gameObject.transform.eulerAngles.y, 0) * new Vector3(direction.x, 0, direction.y);
            currentShip.gameObject.transform.position += move * scaleMoveSpeed;
        }

        public void MoveUpDown(Axies axies)
        {
            switch (axies)
            {
                case Axies.Up:
                    {
                        float scaleMoveSpeed = CurrentShip.CurrentSpeed * Time.deltaTime;
                        Vector3 move = Quaternion.Euler(0, currentShip.gameObject.transform.eulerAngles.y, 0) * new Vector3(0, 1, 0);
                        currentShip.gameObject.transform.position += move * scaleMoveSpeed;
                        Debug.Log("up");
                    }
                    break;
                case Axies.Down:
                    {

                    }
                    break;
            }
        }

        public void Roll(Axies axies)
        {
            switch (axies)
            {
                case Axies.Left:
                    {

                    }
                    break;
                case Axies.Right:
                    {

                    }
                    break;
            }
        }
    }
}
