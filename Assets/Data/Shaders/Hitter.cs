using UnityEngine;

public class Hitter : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float timerAttack;
    [SerializeField] private float tempTimer;

    private void Update()
    {
        transform.RotateAround(target.position, Vector3.up, (moveSpeed * 10) * Time.deltaTime);

        if(tempTimer <= 0)
        {
            Ray ray = new Ray(transform.localPosition, transform.position * -3f);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                ShieldHit shield = hit.collider.gameObject.GetComponent<ShieldHit>();
                if (shield != null)
                {
                    shield.OnHit(hit.point);
                }
            }
            tempTimer = timerAttack;
        }
        else
        {
            tempTimer -= Time.deltaTime;
        }

        Debug.DrawRay(transform.localPosition, transform.position * -3f, Color.red);
    }
}
