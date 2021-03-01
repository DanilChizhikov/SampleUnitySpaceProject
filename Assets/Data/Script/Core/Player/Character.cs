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
            var xzDirection = InputManager.instance.getMoveDirection;
            var yDirection = InputManager.instance.getMoveYDirection;
            var rollDirection = InputManager.instance.getRollDirection;
            var delta = InputManager.instance.getDeltaDirection;
            currentShip.FlyXZ(xzDirection);
            currentShip.FlyY(yDirection);
            currentShip.Roll(rollDirection);
            currentShip.Rotation(delta);
        }
    }
}
