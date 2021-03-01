using Data.Script.Core.Components;
using UnityEngine;

namespace Data.Script.Components.Shields.Core
{
    public class Shield : Script.Core.Components.Component, IShield
    {
        [SerializeField] private float coolDown;
        [SerializeField] private float overClock;
        [SerializeField] private float energyEequir;
        [SerializeField] private GradeComponent grade;
        [SerializeField] private ClassComponent classComponent;

        public GradeComponent ComponentGrade { get => grade; set => grade = value; }
        public ClassComponent ComponentClass { get => classComponent; set => classComponent = value; }
        public float CoolDown { get => coolDown; set => coolDown = value; }
        public float OverClock { get => overClock; set => overClock = value; }
        public float EnergyEequir { get => energyEequir; set => energyEequir = value; }
    }
}
