using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public TextMeshProUGUI itemCounterText;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateUI(Dictionary<string, int> itemCounts)
    {
        string displayText = "Items:\n";

        foreach (KeyValuePair<string, int> pair in itemCounts)
        {
            displayText += $"{pair.Key}: {pair.Value}\n";
        }

        itemCounterText.text = displayText;
    }
}
