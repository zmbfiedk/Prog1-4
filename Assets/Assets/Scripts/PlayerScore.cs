
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    private int Score;
    private List<int> Coins = new List<int>();
    
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("Game Start" + (i + 1));
        }
    }


    void Update()
    {
        if (Score >= 50) 
        {
            Debug.Log("winnner");
        }

        if (Input.GetKeyUp(KeyCode.H)) 
        {   int Coinvaulue = Random.Range(10, 12);
            AddCoin(Coinvaulue);
        }
    }

    void AddCoin(int coinValue)
    {
        Coins.Add(coinValue);
        Score += coinValue;
        Debug.Log("you got a coin" + Score);    
    }
}
