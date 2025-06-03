using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIscript : MonoBehaviour
{
    [SerializeField] NewMonoBehaviourScript move;
    private float previouspeed;
    private TMP_Text textfield;

    void Start()
    {
        textfield = GetComponent<TMP_Text>();
        previouspeed = move.Speed;
        updatespeed();
    }


    void Update()
    {
        if (move.Speed != previouspeed) 
        {
            updatespeed();
        }
    }

    private void updatespeed()
    {
        previouspeed = move.Speed;
        textfield.text = move.Speed.ToString("F0");
    }

}
