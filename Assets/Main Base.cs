using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBase : MonoBehaviour
{
    public int health = 200;

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
        Debug.Log("bababooey");

        // Get the Enemypathing component from the enemy object
        Enemypathing enemyScript = enemy.GetComponent<Enemypathing>();

        if (enemyScript != null)  // Ensure the exists
        {
            TakeDamage((int)enemyScript.MobHealth); //Convert float to int
        }

        Destroy(enemy);
    }

    public void TakeDamage(int Damage)
    {
        health -= Damage;
    }
}
