using UnityEngine;

public class Scoremanager : MonoBehaviour
{
    public int score = 0;
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
