﻿using Data.Script.Components;
using UnityEngine;

namespace Data.Script.Core.Ships
{
    public interface IShip
    {
        string Name { get; set; }
        float MaxHealth { get; set; }
        float CurrentHealth { get; set; }
        ClassShip ShipClass { get; set; }

        void InitializationShip();
    }
}
