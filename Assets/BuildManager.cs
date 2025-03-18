
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    
    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("blablabla");
            return;
        }
        instance = this;
    }

    public GameObject standardTurret;
    public GameObject anotherTurret;
    public GameObject thirdTurret;
    public GameObject fourthTurret;
    public GameObject fifthTurret;

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild ()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }

}

