using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthUI : MonoBehaviour
{
    public MainBase mainBase; // Reference to the MainBase script
    public TextMeshProUGUI healthText; // Reference to the UI Text

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (mainBase != null && healthText != null)
        {
            healthText.text = ": " + mainBase.health;
        }
    }
}
