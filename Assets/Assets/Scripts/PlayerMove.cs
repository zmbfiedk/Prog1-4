using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float speed = 15f;
    [SerializeField] private Scoremanager SM;

    void Start()
    {
        if (SM == null)
        {
            Debug.Log("missing script");
        }
        else
        {
            Debug.Log("script is there");
        }
    }

    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * input * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Coin")
        {    
            SM.AddScore(10);
            Debug.Log("u touched a coin");
            Destroy(other.gameObject);
        }
    }
}
