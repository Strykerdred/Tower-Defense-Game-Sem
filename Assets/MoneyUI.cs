using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyUI : MonoBehaviour
{
    public MainBase mainBase; // reference to the MainBase script
    public TextMeshProUGUI Moneytext; // reference to the ui text

    // Start is called before the first frame update
    void Start()
    {
       UpdateMoneyUI();
    }

    void Update()
    {
        UpdateMoneyUI();
    }
    void UpdateMoneyUI()
    {
        Moneytext.text = ": " + mainBase.money.ToString();
    }
}
