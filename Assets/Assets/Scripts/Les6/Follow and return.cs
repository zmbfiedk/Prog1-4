using System.Net;
using Unity.VisualScripting;
using UnityEngine;

public class Followandreturn : MonoBehaviour
{
    [SerializeField] private Transform PlayerTF;
    [SerializeField] private float Speed;
    private Vector3 StartPosition;
    private bool isResetting = true;
    void Start()
    {
        StartPosition = new Vector3(0f, 0f, 0f);
        transform.position = StartPosition;
    }
    void Update()
    {
        if (isResetting)
        {
            ReturnToStart();
        }
        else 
        {
            FollowTarget(); 
        }
       
    }
    private void FollowTarget()
    {
        transform.position = Vector3.Lerp(transform.position, PlayerTF.position, Speed * Time.deltaTime);

        float distanceTP = Vector3.Distance(transform.position, PlayerTF.position);

        if (distanceTP < 0.1f)
        {
            isResetting = true;
        }
    }
    private void ReturnToStart()
    {

        Vector3 directionStep = (StartPosition - transform.position).normalized;


        transform.Translate(directionStep * Speed * Time.deltaTime);

        float distToStart = Vector3.Distance(transform.position, StartPosition);
        
        if (distToStart < .1f)
        {
            isResetting = false;
        }
    }
}