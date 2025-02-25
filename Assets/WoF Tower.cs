using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBehavior : MonoBehaviour
{
    public float range = 5f;
    public float fireRate = 1f;
    private float fireCooldown = 0f;

    public GameObject Bullet; 
    public Transform shootingPoint;

    private void Update()
    {
        fireCooldown -= Time.deltaTime;

        if (fireCooldown <= 0f)
        {
            Fire();
            fireCooldown = fireRate;
        }
    }

    void Fire()
    {
        if (Bullet != null && shootingPoint != null)
        {
            Instantiate(Bullet, shootingPoint.position, Quaternion.identity);
        }
    }
}
