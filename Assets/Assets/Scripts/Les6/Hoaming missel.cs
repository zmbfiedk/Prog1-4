using UnityEngine;

public class HomingMissel : MonoBehaviour
{
    [SerializeField] public Transform target;
    [SerializeField] private float speed = 5f;

    void Update()
    {
        if (target == null) return;

        Vector3 direction = (target.position - transform.position).normalized;

        transform.position += direction * speed * Time.deltaTime;

        if (Vector3.Distance(transform.position, target.position) < 0.2f)
        {
            Destroy(gameObject); 
        }
    }
}