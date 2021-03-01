using Data.Script.Core.Scene;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace Data.Script.Core.Ships
{
    public class Ship : BaseObject, IShip, IFly, IDamageShipAndComponent
    {
        [SerializeField] private string nameShip;
        [SerializeField] private float maxHealth;
        [SerializeField] private float currentHealth;
        [SerializeField] private float maxSpeed;
        [SerializeField] private float currentSpeed;
        [SerializeField] private float accelerationForce;
        [SerializeField] private float brakingForce;
        [SerializeField] private float yawPitchSpeed;
        [SerializeField] private ClassShip classShip;
        [SerializeField] private UnityEvent OnDestroed;
        [SerializeField] private UnityEvent OnTakeDamage;
        private bool isInverse;

        public string Name { get => nameShip; set => nameShip = value; }
        public float MaxHealth { get => maxHealth; set => maxHealth = value; }
        public float CurrentHealth { get => currentHealth; set => currentHealth = value; }
        public ClassShip ShipClass { get => classShip; set => classShip = value; }
        public float MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
        public float CurrentSpeed { get => currentSpeed; set => currentSpeed = value; }
        public float YawPitchSpeed { get => yawPitchSpeed; set => yawPitchSpeed = value; }
        public float AccelerationForce { get => accelerationForce; set => accelerationForce = value; }
        public float BrakingForce { get => brakingForce; set => brakingForce = value; }
        public UnityEvent OnDestroedEvent { get => OnDestroed; set => OnDestroed = value; }
        public UnityEvent OnTakeDamageEvent { get => OnTakeDamage; set => OnTakeDamage = value; }
        public float SpeedLimmited { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void BaseAwake()
        {
            InitializationShip();
        }

        #region IShip
        public virtual void InitializationShip()
        {
            currentHealth = maxHealth;
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
        #endregion

        #region IFly
        public void FlyXZ(Vector2 direction)
        {
            if (direction.sqrMagnitude > 0.1f)
            {
                float scaleMoveSpeed = currentSpeed * Time.deltaTime;
                Vector3 move = Quaternion.Euler(0, transform.eulerAngles.y, 0) * new Vector3(direction.x, 0, direction.y);
                transform.position += move * scaleMoveSpeed;
            }
        }

        public void FlyY(float direction)
        {
            float scaleMoveSpeed = currentSpeed * Time.deltaTime;
            var translate = (Vector3.up * direction) * scaleMoveSpeed;

            transform.Translate(translate);
        }

        public void Roll(float direction)
        {
            transform.Rotate(0, 0, direction, Space.Self);
        }

        public void YawPitch(Vector2 delta)
        {
            if (delta.sqrMagnitude > 0.1f)
            {
                var scaledRotateSpeed = yawPitchSpeed * Time.deltaTime * delta;
                scaledRotateSpeed.y = isInverse ? scaledRotateSpeed.y : scaledRotateSpeed.y * -1;
                var euler = new Vector3(scaledRotateSpeed.y, scaledRotateSpeed.x, 0);
                transform.Rotate(euler);
            }
        }

        public void SpeedControll(Vector2 xzDirection, float yDirection)
        {
            if (!GamePause.instance.IsPaused)
            {
                if (xzDirection.sqrMagnitude > 0.1f || yDirection != 0)
                {
                    currentSpeed = (currentSpeed < maxSpeed) ? currentSpeed + accelerationForce : maxSpeed;
                }
                else
                {
                    currentSpeed = (currentSpeed > 0) ? currentSpeed - brakingForce : 0;
                }
            }
        }
        #endregion
    }
}