using UnityEngine;

public class Scoremanager : MonoBehaviour
{
    private int score = 0;

    public int Score
    {
        get { return score; }  
        set { score = value; }  
    }

    public void AddScore(int points)
    {
        score += points;
        Debug.Log("you got a coin");
    }
    private void Update()
    {
        Debug.Log("you score is" + score);
    }
}
