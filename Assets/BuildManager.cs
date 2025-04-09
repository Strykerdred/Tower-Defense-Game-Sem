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
    // list of turrents
    public GameObject standardTurret;
    public GameObject anotherTurret;
    public GameObject thirdTurret;
    public GameObject fourthTurret;
    public GameObject fifthTurret;

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }

    public void ClearTurretToBuild()
    {
        turretToBuild = null;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && turretToBuild != null)
        {
            // place tower system
            PlaceTurret();
            ClearTurretToBuild();
        }
    }

    void PlaceTurret()
    {
        // check if it worked
        Debug.Log("Turret placed");
    }
}
