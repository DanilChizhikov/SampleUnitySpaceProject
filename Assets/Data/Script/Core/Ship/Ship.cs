using Data.Script.Components;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Data.Script.Core.Ships
{
    public class Ship : BaseObject, IShip, IDamageShipAndComponent
    {
        [SerializeField] protected string nameShip;
        [SerializeField] protected float maxHealth;
        [SerializeField] protected float currentHealth;
        [SerializeField] protected float maxSpeed;
        [SerializeField] protected float currentSpeed;
        [SerializeField] protected ClassShip classShip;
        [SerializeField] protected ShieldComponent[] shields;
        [SerializeField] protected UnityEvent OnDestroed;
        [SerializeField] protected UnityEvent OnTakeDamage;

        public string Name { get => nameShip; set => nameShip = value; }
        public float MaxHealth { get => maxHealth; set => maxHealth = value; }
        public float CurrentHealth { get => currentHealth; set => currentHealth = value; }
        public ClassShip ShipClass { get => classShip; set => classShip = value; }
        public float MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
        public float CurrentSpeed { get => currentSpeed; set => currentSpeed = value; }
        public ShieldComponent[] Shields { get => shields; set => shields = value; }
        public UnityEvent OnDestroedEvent { get => OnDestroed; set => OnDestroed = value; }
        public UnityEvent OnTakeDamageEvent { get => OnTakeDamage; set => OnTakeDamage = value; }

        public virtual void InitializationShip()
        {
            currentHealth = maxHealth;
            foreach (var shield in shields)
            {
                if(shield.SizeComponent == classShip)
                    shield.InitializationComponent();
            }
        }

        public void Destroed()
        {
            var health = Math.Round(currentHealth, 1);
            if (health <= 0.1f)
                OnDestroed?.Invoke();
        }

        public void SetDamage(float damage)
        {
            currentHealth -= damage;
            OnTakeDamage?.Invoke();
            Destroed();
        }
    }
}