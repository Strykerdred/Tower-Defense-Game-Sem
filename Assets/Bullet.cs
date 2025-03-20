using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public float damage = 1f;
    public bool applySlowingEffect = false; // New property to enable/disable slowing effect
    public float slowAmount = 0.5f; // Amount to slow the enemy
    public float slowDuration = 2f; // Duration of the slowing effect

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

                if (applySlowingEffect)
                {
                    enemy.ApplySlow(slowAmount, slowDuration); // Apply slowing effect
                }
            }

            Destroy(gameObject); // Destroy the projectile when it touches enemy
        }
    }
}
