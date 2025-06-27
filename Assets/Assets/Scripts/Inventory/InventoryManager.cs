using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    public Dictionary<string, int> itemCounts = new Dictionary<string, int>();

    private void Awake()
    {
        // Singleton setup
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CollectItem(string itemName)
    {
        if (itemCounts.ContainsKey(itemName))
        {
            itemCounts[itemName]++;
        }
        else
        {
            itemCounts[itemName] = 1;
        }

        Debug.Log($"Gevonden: {itemName}, Totaal: {itemCounts[itemName]}");
        UIManager.Instance.UpdateUI(itemCounts);
    }
}
