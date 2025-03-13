
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    
    public static BuildManager instance;

    void awake()
    {
        if (instance != null)
        {
            Debug.LogError("blablabla");
            return;
        }
        instance = this;
    }

    public GameObject standardTurret;

    void Start()
    {
        turretToBuild = standardTurret;
    }

    private GameObject turretToBuild;
    public GameObject GetTurretToBuild ()
    {
        return turretToBuild;
    }

}

