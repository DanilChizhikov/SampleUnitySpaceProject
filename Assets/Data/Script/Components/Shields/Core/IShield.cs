using Data.Script.Core.Components;

namespace Data.Script.Components.Shields.Core
{
    interface IShield
    {
        float CoolDown { get; set; }
        float OverClock { get; set; }
        float EnergyEequir { get; set; }
        GradeComponent ComponentGrade { get; set; }
        ClassComponent ComponentClass { get; set; }
    }
}
