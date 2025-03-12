using UnityEngine;

public class Shop : MonoBehaviour {

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseWoF ()
    {
        Debug.Log("Wall of Flesh summoned");
        buildManager.SetTurretToBuild(buildManager.TowerWoF);
    }
    public void PurchasePyro ()
    {
        Debug.Log("The Pyro has spawned in");
        buildManager.SetTurretToBuild(buildManager.TowerPyro);
    }
    public void PurchaseClodsire()
    {
        Debug.Log("Trainer sent out Clodsire");
        buildManager.SetTurretToBuild(buildManager.TowerClodsire);
    }
    public void PurchaseMasterChief()
    {
        Debug.Log("THE Master Chief himself has arrived");
        buildManager.SetTurretToBuild(buildManager.TowerChief);
    }
    public void PurchaseFrozone()
    {
        Debug.Log("Frozone slides into battle");
        buildManager.SetTurretToBuild(buildManager.TowerFrozone);
    }

}
