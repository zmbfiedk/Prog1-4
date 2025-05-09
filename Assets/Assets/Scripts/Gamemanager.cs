using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public float speed = 5f;          
    public float remainingTime = 60f;  
    private int score = 0;             

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveX, 0, moveZ) * speed * Time.deltaTime;
        transform.Translate(movement);

        remainingTime -= Time.deltaTime;

        if (remainingTime <= 0f)
        {
            Debug.Log("Game Over! Eindscore: " + score);
            enabled = false; 
            return;
        }

        Debug.Log("Tijd over: " + Mathf.CeilToInt(remainingTime) + " seconden | Score: " + score);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Money"))
        {
            score += 10;
            Debug.Log("+ 2 dolla dolla");

            Destroy(other.gameObject); 
        }
    }
}
