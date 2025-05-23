using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] private Scoremanager SC;
    private TMP_Text textfield;
    private int previousScore;

    void Start()
    {
        textfield = GetComponent<TMP_Text>();
        previousScore = SC.Score;
        UpdateScoreDisplay();
    }

    void Update()
    {
        if (SC.Score != previousScore)
        {
            UpdateScoreDisplay();
        }
    }

    private void UpdateScoreDisplay()
    {
        previousScore = SC.Score;
        textfield.text = SC.Score.ToString();
    }
}
