
using UnityEngine;

public class BuildManager : MonoBehaviour
{

    public static BuildManager instance;

    void awake()
    {
        if (instance != null)
        {
            Debug.LogError("Nope");
            return;
        }
        instance = this;
    }

    public GameObject TowerWoF;
    public GameObject TowerPyro;
    public GameObject TowerClodsire;
    public GameObject TowerChief;
    public GameObject TowerFrozone;

    private GameObject turretToBuild;
    public GameObject GetTurretToBuild ()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild (GameObject turret)
    {
        turretToBuild = turret;
    }
}

