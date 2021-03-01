using Data.Script.Core.Ships;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace Data.Script.Core.Components
{
    public class Component : BaseObject, IComponent, IDamageShipAndComponent
    {
        [SerializeField] private string nameComponent;
        [SerializeField] private float maxHealth;
        [SerializeField] private float currentHealth;
        [SerializeField] private SizeComponent size;
        [SerializeField] private UnityEvent OnDestroed;
        [SerializeField] private UnityEvent OnTakeDamage;

        public string Name { get => nameComponent; set => nameComponent = value; }
        public float MaxHealth { get => maxHealth; set => maxHealth = value; }
        public float CurrentHealth { get => currentHealth; set => currentHealth = value; }
        public UnityEvent OnDestroedEvent { get => OnDestroed; set => OnDestroed = value; }
        public UnityEvent OnTakeDamageEvent { get => OnTakeDamage; set => OnTakeDamage = value; }
        public SizeComponent ComponentSize { get => size; set => size = value; }

        public override void BaseAwake()
        {
            InitializationComponent();
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

        public void Destroed()
        {
            var health = Math.Round(currentHealth, 1);
            if (health <= 0.1f)
            {
                OnDestroed?.Invoke();
            }
        }
    }
}