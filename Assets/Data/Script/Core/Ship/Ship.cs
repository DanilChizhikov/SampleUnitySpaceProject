using Data.Script.Components;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Data.Script.Core.Ships
{
    public class Ship : BaseObject, IShip, IFly, IDamageShipAndComponent
    {
        [SerializeField] protected string nameShip;
        [SerializeField] protected float maxHealth;
        [SerializeField] protected float currentHealth;
        [SerializeField] protected float maxSpeed;
        [SerializeField] protected float currentSpeed;
        [SerializeField] protected float rotationSpeed;
        [SerializeField] protected ClassShip classShip;
        [SerializeField] protected ShieldComponent[] shields;
        [SerializeField] protected UnityEvent OnDestroed;
        [SerializeField] protected UnityEvent OnTakeDamage;
        private Vector2 _rotation;
        [SerializeField] protected bool isInvertion;

        public string Name { get => nameShip; set => nameShip = value; }
        public float MaxHealth { get => maxHealth; set => maxHealth = value; }
        public float CurrentHealth { get => currentHealth; set => currentHealth = value; }
        public ClassShip ShipClass { get => classShip; set => classShip = value; }
        public float MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
        public float CurrentSpeed { get => currentSpeed; set => currentSpeed = value; }
        public ShieldComponent[] Shields { get => shields; set => shields = value; }
        public UnityEvent OnDestroedEvent { get => OnDestroed; set => OnDestroed = value; }
        public UnityEvent OnTakeDamageEvent { get => OnTakeDamage; set => OnTakeDamage = value; }
        public float SpeedLimmited { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual void InitializationShip()
        {
            currentHealth = maxHealth;
            foreach (var shield in shields)
            {
                if(shield.SizeComponent == classShip)
                {
                    shield.InitializationComponent();
                }
            }
        }

        public void Destroed()
        {
            var health = Math.Round(currentHealth, 1);
            if (health <= 0.1f)
            {
                OnDestroed?.Invoke();
            }
        }

        public void SetDamage(float damage)
        {
            currentHealth -= damage;
            OnTakeDamage?.Invoke();
            Destroed();
        }

        public void FlyXZ(Vector2 direction)
        {
            if (direction.sqrMagnitude > 0.1f)
            {
                float scaleMoveSpeed = currentSpeed * Time.deltaTime;
                Vector3 move = Quaternion.Euler(0, transform.eulerAngles.y, 0) * new Vector3(direction.x, 0, direction.y);
                transform.position += move * scaleMoveSpeed;
            }
        }

        public void Roll(float direction)
        {
            transform.Rotate(0, 0, direction, Space.Self);
        }

        public void FlyY(float direction)
        {
            float scaleMoveSpeed = currentSpeed * Time.deltaTime;
            var translate = (Vector3.up * direction) * scaleMoveSpeed;

            transform.Translate(translate);
        }

        public void Rotation(Vector2 delta)
        {
            if(delta.sqrMagnitude > 0.1f)
            {
                var scaledRotateSpeed = rotationSpeed * Time.deltaTime * delta;
                scaledRotateSpeed.y = isInvertion ? scaledRotateSpeed.y : scaledRotateSpeed.y * -1;
                var euler = new Vector3(scaledRotateSpeed.y, scaledRotateSpeed.x, 0);
                transform.Rotate(euler);
            }
        }
    }
}