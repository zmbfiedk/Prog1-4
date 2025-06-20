using UnityEngine;

public class Patrolling : MonoBehaviour
{
    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;
    [SerializeField] private Transform pointC;
    [SerializeField] private Transform player;
    [SerializeField] private float speed = 1f;

    private Vector3[] points;
    private int currentTargetIndex = 1; // Start going from A to B
    private int direction = 1; // +1 means forward, -1 means reverse

    private void Start()
    {
        points = new Vector3[] { pointA.position, pointB.position, pointC.position };
        player.position = pointA.position;
    }

    private void Update()
    {
        Vector3 target = points[currentTargetIndex];
        Vector3 moveDirection = (target - player.position).normalized;
        float distanceThisFrame = speed * Time.deltaTime;

        // Move towards the target
        player.position += moveDirection * distanceThisFrame;

        // If close enough to the target, switch to the next point
        if (Vector3.Distance(player.position, target) < 0.1f)
        {
            player.position = target; // Snap to target

            // Change direction at the ends
            if (currentTargetIndex == points.Length - 1)
                direction = -1;
            else if (currentTargetIndex == 0)
                direction = 1;

            currentTargetIndex += direction;
        }
    }
}
