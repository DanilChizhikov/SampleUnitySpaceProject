using UnityEngine;

namespace Data.Script.Preview
{
    public class Rotate : MonoBehaviour
    {
        [SerializeField] private Vector3 rotationVector;
        [SerializeField] private float multiplaySpeed;

        private void Update()
        {
            var euler = rotationVector * multiplaySpeed * Time.deltaTime;
            transform.Rotate(euler);
        }
    }
}