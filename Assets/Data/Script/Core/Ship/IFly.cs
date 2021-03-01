using UnityEngine;

namespace Data.Script.Core.Ships
{
    public interface IFly
    {
        float MaxSpeed { get; set; }
        float CurrentSpeed { get; set; }
        float SpeedLimmited { get; set; }
        float YawPitchSpeed { get; set; }
        float AccelerationForce { get; set; }
        float BrakingForce { get; set; }

        void FlyXZ(Vector2 direction);
        void FlyY(float direction);
        void Roll(float direction);
        void YawPitch(Vector2 delta);
        void SpeedControll(Vector2 xzDirection, float yDirection);
    }
}
