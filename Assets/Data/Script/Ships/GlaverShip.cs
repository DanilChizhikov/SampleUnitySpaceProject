using Data.Script.Components.Shields.Core;
using Data.Script.Core.Components;
using Data.Script.Core.Ships;
using UnityEngine;

namespace Data.Script.Ships
{
    public class GlaverShip : Ship
    {
        [SerializeField] Shield[] shields;
        [SerializeField] private SizeComponent maxSizeComponent;

        public override void InitializationShip()
        {
            Name = "Glaver";
            MaxHealth = 1000;
            MaxSpeed = 1000;
            YawPitchSpeed = 50f;
            AccelerationForce = 1f;
            BrakingForce = 0.1f;
            ShipClass = ClassShip.LightFly;
            base.InitializationShip();

            foreach(var shield in shields)
            {
                if(shield.ComponentSize == maxSizeComponent)
                {
                    shield.InitializationComponent();
                }
            }
        }
    }
}