using System.Data.SqlTypes;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;
    public WaveSpawner waveSpawner; // WaveSpawner reference
    public MainBase mainBase; // reference to the MainBase script

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseWall()
    {

        if (mainBase.money >= 75)
        {
            mainBase.money -= 75;
            Debug.Log("Wall Purchased");
            buildManager.SetTurretToBuild(buildManager.standardTurret);
        }
        else
        {
            Debug.Log("Not enough money to purchase Wall");
        }
    }

    public void PurchasePyro()
    {
        if (mainBase.money >= 100)
        {
            mainBase.money -= 100;
            Debug.Log("Pyro Purchased");
            buildManager.SetTurretToBuild(buildManager.anotherTurret);
        }
        else
        {
            Debug.Log("Not enough money to purchase Pyro");
        }
    }

    public void PurchaseClod()
    {
        if (mainBase.money >= 125)
        {
            mainBase.money -= 125;
            Debug.Log("Clod Purchased");
            buildManager.SetTurretToBuild(buildManager.thirdTurret);
        }
        else
        {
            Debug.Log("Not enough money to purchase Clod");
        }
    }

    public void PurchaseChief()
    {
        if (mainBase.money >= 125)
        {
            mainBase.money -= 125;
            Debug.Log("THE Master Chief Purchased");
            buildManager.SetTurretToBuild(buildManager.fourthTurret);
        }
        else
        {
            Debug.Log("Not enough money to purchase THE Master Chief");
        }

    }

    public void PurchaseFrozone()
    {
        if (mainBase.money >= 175)
        {
            mainBase.money -= 175;
            Debug.Log("Frozone Purchased");
            buildManager.SetTurretToBuild(buildManager.fifthTurret);
        }
        else
        {
            Debug.Log("Not enough money to purchase Frozone");
        }
    }
}
