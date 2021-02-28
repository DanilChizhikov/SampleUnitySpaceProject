using Data.Script.Core.Ships;
using Data.Script.Inputs;
using UnityEngine;

namespace Data.Script.Core.Player
{
    public interface ICharacter
    {
        string Name { get; set; }
        Ship CurrentShip { get; set; }
    }
}
