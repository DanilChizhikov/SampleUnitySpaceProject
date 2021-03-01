using Data.Script.Components.Shields.Core;
using Data.Script.Core.Components;

namespace Data.Script.Components.Shields
{
    public class AllStopShield : Shield
    {
        public override void InitializationComponent()
        {
            Name = "AllStop";
            MaxHealth = 3000;
            ComponentSize = SizeComponent.One;
            ComponentGrade = GradeComponent.B;
            ComponentClass = ClassComponent.Citizen;
            CoolDown = 5f;
            OverClock = 500;
            EnergyEequir = 100;
            base.InitializationComponent();
        }
    }
}
