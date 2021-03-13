using UnityEngine;

public class ShieldHit : MonoBehaviour
{
    [SerializeField] private static int[] hitInfoId = new[] 
    { 
        Shader.PropertyToID("_WorldHitPoint0"), 
        Shader.PropertyToID("_WorldHitPoint1"), 
        Shader.PropertyToID("_WorldHitPoint2") 
    };
    [SerializeField] private static int[] hitTimeId = new[] { 
        Shader.PropertyToID("_HitTime0"), 
        Shader.PropertyToID("_HitTime1"), 
        Shader.PropertyToID("_HitTime2") 
    };
    [SerializeField] private ParticleSystem[] sparks;
    [SerializeField] private Material shieldMaterial;
    [SerializeField] private int lastIndex = 0;

    private void Start()
    {
        shieldMaterial = gameObject.GetComponent<MeshRenderer>().material;
    }

    public void OnHit(Vector3 point)
    {
        Debug.Log("Hit");
        shieldMaterial.SetVector(hitInfoId[lastIndex], point);
        shieldMaterial.SetFloat(hitTimeId[lastIndex], Time.timeSinceLevelLoad);
        sparks[lastIndex].gameObject.transform.position = point;
        sparks[lastIndex].gameObject.transform.rotation = Quaternion.LookRotation(point);
        sparks[lastIndex].Play();
        lastIndex = (++lastIndex >= hitInfoId.Length) ? 0 : lastIndex++;
    }
}