using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public float jumpforce;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Speler klaar!");
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(move * speed,rb.velocity.y,0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }

    }
}
