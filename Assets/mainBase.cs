using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MainBase : MonoBehaviour
{
    public int health = 200;
    public int money = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            KillUnit(collision.gameObject);
        }
    }
    void KillUnit(GameObject enemy)
    {
        Debug.Log("Damage Taken");

        // Get the Enemypathing component from the enemy object
        Enemy enemyScript = enemy.GetComponent<Enemy>();

        if (enemyScript != null)  // Ensure the exists
        {
            TakeDamage((int)enemyScript.MobHealth); //Convert float to int
        }

        enemyScript.Die();
    }

    public void TakeDamage(int Damage)
    {
        health -= Damage;
    }
}
