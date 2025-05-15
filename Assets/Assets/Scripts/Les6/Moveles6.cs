using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private float speed = 20f;


    void Start()
    {
        
    }

    void Update()
    {

            float moxeX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            float moxeZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            Vector3 move = new Vector3(moxeX, 0f, moxeZ);
            transform.Translate(move);
    }
}
