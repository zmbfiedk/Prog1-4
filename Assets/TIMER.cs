using UnityEngine;

public class TIMER : MonoBehaviour
{
    [SerializeField] private float TimeLeft;
    [SerializeField] private int Difficulty = 1; // 1 = Easy, 2 = Medium, 3 = Hard
    [SerializeField] private bool gamedone = false;

    private bool timerStarted = false;

    public float Ttime
    {
        get { return TimeLeft; }
    }

    void Start()
    {
        // Set the initial time based on difficulty
        switch (Difficulty)
        {
            case 1:
                TimeLeft = 10f;
                break;
            case 2:
                TimeLeft = 5f;
                break;
            case 3:
                TimeLeft = 2.5f;
                break;
            default:
                TimeLeft = 10f; // fallback
                break;
        }

        timerStarted = true;
    }

    void Update()
    {
        if (timerStarted && !gamedone)
        {
            TimeLeft -= Time.deltaTime;

            if (TimeLeft <= 0f)
            {
                gamedone = true;
                Time.timeScale = 0f; // pause the game
            }
        }
    }
}
