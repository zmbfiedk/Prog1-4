using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed = 5f;
    public float driveSpeed = 8f;
    public float turnSpeed = 100f;

    private bool isDriving = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            isDriving = !isDriving;
            Debug.Log("Modus: " + (isDriving ? "Rijden" : "Lopen"));
        }

        if (isDriving)
        {
            DriveMovement();
        }
        else
        {
            WalkMovement();
        }
    }

    void WalkMovement()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h, 0f, v).normalized * walkSpeed * Time.deltaTime;
        transform.Translate(move, Space.World);

        if (move != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(move, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, turnSpeed * Time.deltaTime);
        }
    }

    void DriveMovement()
    {
        float move = Input.GetAxis("Vertical") * driveSpeed * Time.deltaTime;
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * move);
        transform.Rotate(Vector3.up * turn);
    }
}
