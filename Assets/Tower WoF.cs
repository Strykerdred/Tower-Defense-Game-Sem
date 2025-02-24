using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerWoF : MonoBehaviour
{
    public float attackRange = 5f;
    public float attackRate = 1f;
    public string enemyTag = "Enemy";
    private float nextAttackTime = 0f;

    void Start()
    {
        // Initialization if needed
    }

    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            Attack();
            nextAttackTime = Time.time + 1f / attackRate;
        }
    }

    void Attack()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, attackRange);
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.CompareTag(enemyTag))
            {
                // Implement your attack logic here
                Debug.Log("Attacking enemy: " + hitCollider.name);
                // Example: hitCollider.GetComponent<Enemy>().TakeDamage(damage);
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
