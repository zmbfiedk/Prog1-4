using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] private Scoremanager SC;
    private TMP_Text textfield;

    void Start()
    {
        textfield = GetComponent<TMP_Text>();
    }

    void Update()
    {
        textfield.text = SC.Score.ToString();
    }
}
