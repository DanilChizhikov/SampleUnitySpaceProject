using Data.Script.Core.Ships;

namespace Data.Script.Ships
{
    public class GlaverShip : Ship
    {
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
        }
    }
}