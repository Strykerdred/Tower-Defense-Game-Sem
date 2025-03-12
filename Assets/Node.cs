
using UnityEngine;

public class Node : MonoBehaviour
{
    private GameObject turret;

    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    void onMouseDown()
    {
        if (buildManager.getTurretToBuild() == null)
            return;

        if (turret!= null)
        {
            Debug.Log("Hell no");
            return;
        }

        GameObject turretToBuild = buildManager.getTurretToBuild();
        turret = (GameObject) Instantiate(turretToBuild);
    }
}
