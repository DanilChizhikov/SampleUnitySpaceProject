using Data.Script.Core.Ships;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace Data.Script.Core.Components
{
    public class Component : BaseObject, IComponent, IDamageShipAndComponent
    {
        [SerializeField] protected string nameComponent;
        [SerializeField] protected float maxHealth;
        [SerializeField] protected float currentHealth;
        [SerializeField] protected ClassShip size;
        [SerializeField] protected UnityEvent OnDestroed;
        [SerializeField] protected UnityEvent OnTakeDamage;

        public string Name { get => nameComponent; set => nameComponent = value; }
        public float MaxHealth { get => maxHealth; set => maxHealth = value; }
        public float CurrentHealth { get => currentHealth; set => currentHealth = value; }
        public ClassShip SizeComponent { get => size; set => size = value; }
        public UnityEvent OnDestroedEvent { get => OnDestroed; set => OnDestroed = value; }
        public UnityEvent OnTakeDamageEvent { get => OnTakeDamage; set => OnTakeDamage = value; }

        public void Destroed()
        {
            var health = Math.Round(currentHealth, 1);
            if (health <= 0.1f)
                OnDestroed?.Invoke();
        }

        public virtual void InitializationComponent()
        {
            currentHealth = maxHealth;
        }

        public void SetDamage(float damage)
        {
            currentHealth -= damage;
            OnTakeDamage?.Invoke();
            Destroed();
        }
    }
}