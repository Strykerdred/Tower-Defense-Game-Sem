<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
=======
using UnityEngine;

public class Shop : MonoBehaviour {

    BuildManager buildManager;

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


>>>>>>> Test-Area
}
