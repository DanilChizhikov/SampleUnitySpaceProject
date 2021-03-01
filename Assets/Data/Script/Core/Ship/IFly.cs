using UnityEngine;

namespace Data.Script.Core.Ships
{
    public interface IFly
    {
        float MaxSpeed { get; set; }
        float CurrentSpeed { get; set; }
        float SpeedLimmited { get; set; }

        void FlyXZ(Vector2 direction);
        void FlyY(float direction);
        void Roll(float direction);
        void Rotation(Vector2 delta);
    }
}
