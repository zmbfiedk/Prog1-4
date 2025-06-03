using System.Collections;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private float movespeed = 20f;
    [SerializeField] private float boostSpeed = 30f;
    private float speed;
    public float Speed    
    {
        get { return speed; }          
        set { speed = value; }         
    }

    void Start()
    {
       speed = movespeed;
    }

    void Update()
    {

            float moxeX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            float moxeZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            Vector3 move = new Vector3(moxeX, 0f, moxeZ);
            transform.Translate(move);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            Destroy(other.gameObject);
            StartCoroutine(MyCoroutine());
        }
    }

    IEnumerator MyCoroutine()
    {
        speed = boostSpeed;
        yield return new WaitForSeconds(5);
        speed = movespeed;
    }
}
