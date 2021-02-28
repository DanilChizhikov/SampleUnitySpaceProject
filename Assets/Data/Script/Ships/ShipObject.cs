using Data.Script.Core.Ships;

namespace Data.Script.Ships
{
    public class ShipObject : Ship
    {
        public override void BaseAwake()
        {
            InitializationShip();
        }
    }
}
