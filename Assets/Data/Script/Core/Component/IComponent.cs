namespace Data.Script.Core.Components
{
    public interface IComponent
    {
        string Name { get; set; }
        float MaxHealth { get; set; }
        float CurrentHealth { get; set; }
        SizeComponent ComponentSize { get; set; }

        void InitializationComponent();
    }
}
