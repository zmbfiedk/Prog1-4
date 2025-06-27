using UnityEngine;

public class Collectible : MonoBehaviour
{
    public string itemName; // bijv. "Coin", "Gem", "Key"

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InventoryManager.Instance.CollectItem(itemName);
            Destroy(gameObject);
        }
    }
}
