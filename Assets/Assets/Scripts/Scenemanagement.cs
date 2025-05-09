using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanagement : MonoBehaviour
{
    private void Update()
    {
        sceneswitch();
    }
    void sceneswitch()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            SceneManager.LoadScene("Gamescene");
            Debug.Log("Switchh");
        }
    }
}
