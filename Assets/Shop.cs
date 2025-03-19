using System.Data.SqlTypes;
using UnityEngine;

public class Shop : MonoBehaviour {

    BuildManager buildManager;
    public WaveSpawner waveSpawner; // WaveSpawner reference
    public MainBase mainBase; // reference to the MainBase script

    void Start ()
    {
        buildManager = BuildManager.instance;
    }
    public void PurchaseWall()
    {
        Debug.Log("Wall Purchased");
        buildManager.SetTurretToBuild(buildManager.standardTurret);
    }
    public void PurchasePyro()
    {
        Debug.Log("Pyro Purchased");
        buildManager.SetTurretToBuild(buildManager.anotherTurret);
    }
    public void PurchaseClod()
    {
        Debug.Log("Clodsire Purchased");
        buildManager.SetTurretToBuild(buildManager.thirdTurret);
    }
    public void PurchaseChief()
    {
        Debug.Log("THE Master Chief Purchased");
        buildManager.SetTurretToBuild(buildManager.fourthTurret);
    }
    public void PurchaseFrozone()
    {
        Debug.Log("Frozone Purchased");
        buildManager.SetTurretToBuild(buildManager.fifthTurret);
    }


}
