using Data.Script.Core.Ships;

namespace Data.Script.Core.Components
{
    public interface IComponent
    {
        string Name { get; set; }
        float MaxHealth { get; set; }
        float CurrentHealth { get; set; }
        ClassShip SizeComponent { get; set; }

        void InitializationComponent();
    }
}
