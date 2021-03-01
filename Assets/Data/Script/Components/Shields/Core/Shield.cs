using Data.Script.Core.Components;
using UnityEngine;

namespace Data.Script.Components.Shields.Core
{
    public class Shield : Data.Script.Core.Components.Component, IShield
    {
        [SerializeField] private float coolDown;
        [SerializeField] private float overClock;
        [SerializeField] private float energyEequir;
        [SerializeField] private GradeComponent grade;
        [SerializeField] private ClassComponent classComponent;

        public GradeComponent ComponentGrade { get => grade; set => grade = value; }
        public ClassComponent ComponentClass { get => classComponent; set => classComponent = value; }
        public float CoolDown { get; set; }
        public float OverClock { get; set; }
        public float EnergyEequir { get; set; }
    }
}
