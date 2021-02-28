using UnityEngine.Events;

namespace Data.Script.Core.Ships
{
    public interface IDamageShipAndComponent
    {
        UnityEvent OnDestroedEvent { get; set; }
        UnityEvent OnTakeDamageEvent { get; set; }
        void SetDamage(float damage);
        void Destroed();
    }
}
