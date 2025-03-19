using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; // For sorting enemies by distance

public class TowerBehavior : MonoBehaviour
{
    public float range = 10f;
    public float fireRate = 1f;
    private float fireCooldown = 0f;
    
    public GameObject projectilePrefab;
    public Transform shootingPoint;

    void Update()
    {
        fireCooldown -= Time.deltaTime;

        // Find the closest enemy
        Transform targetEnemy = FindClosestEnemy();

        if (targetEnemy != null && fireCooldown <= 0f)
        {
            Fire(targetEnemy);
            fireCooldown = fireRate; // reset cooldown
        }
    }

    Transform FindClosestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        // no shoot if no enemies
        if (enemies.Length == 0) return null;

        // looks for close target within range
        return enemies
            .Where(e => Vector3.Distance(transform.position, e.transform.position) <= range)
            .OrderBy(e => Vector3.Distance(transform.position, e.transform.position))
            .FirstOrDefault()?.transform;
    }

    void Fire(Transform targetEnemy)
    {
        if (projectilePrefab != null && shootingPoint != null)
        {
            GameObject projectileObj = Instantiate(projectilePrefab, shootingPoint.position, Quaternion.identity);
            Projectile projectile = projectileObj.GetComponent<Projectile>();

            if (projectile != null)
            {
                projectile.SetTarget(targetEnemy);
            }
        }
    }
}
