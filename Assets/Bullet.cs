using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public float damage = 1f;
    private Transform target; // The enemy to follow

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    private void Update()
    {
        if (target == null)
        {
            Destroy(gameObject); // Destroy if no target
            return;
        }

        // Move to enemy
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // Make the projectile point towards the enemy
        transform.LookAt(target);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();

            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            Destroy(gameObject); // Destroy bullet on hit
        }
    }
}
