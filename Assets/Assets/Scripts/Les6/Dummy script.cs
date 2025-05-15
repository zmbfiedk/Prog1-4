using UnityEngine;

public class DummyMovement : MonoBehaviour
{
    [SerializeField] private Vector3 pointA;
    [SerializeField] private Vector3 pointB;
    [SerializeField] private float speed = 2f;
    private Vector3 target;

    void Start()
    {
        target = pointB;
        transform.position = pointA;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, target) < 0.1f)
        {
            target = target == pointA ? pointB : pointA;
            Debug.Log("i am moving");
        }
    }
}