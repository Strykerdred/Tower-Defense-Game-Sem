using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public GameObject[] towerPrefabs;  // Array of available towers
    public Transform spawnPoint;       // The point where the tower will be spawned
    public Button[] shopButtons;       // UI buttons for each tower

    void Start()
    {
        // Attach listeners to the shop buttons
        for (int i = 0; i < shopButtons.Length; i++)
        {
            int index = i; // Local copy of the index for the lambda
            shopButtons[i].onClick.AddListener(() => BuyTower(index));
        }
    }

    // Method to buy and spawn a tower
    void BuyTower(int index)
    {
        // Spawn the tower
        Instantiate(towerPrefabs[index], spawnPoint.position, Quaternion.identity);

        // Optionally, you can add a log or visual feedback here
        Debug.Log("Tower Purchased!");
    }
}
