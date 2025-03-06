using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 5f;
    private int currentWaypointIndex = 0;
    public float MobHealth = 10f;
    private float countdown = 10f;
    public WaveSpawner waveSpawner; // WaveSpawner reference

    // Start is called before the first frame update
    void Start()
    {
        if (waveSpawner == null)
        {
            Debug.LogWarning($"{gameObject.name} has no WaveSpawner assigned!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (waypoints == null || waypoints.Length == 0)
        {
            Debug.LogWarning($"{gameObject.name} has no waypoints assigned!");
            return; // wont move if it doesnt have waypoint
        }

        countdown -= Time.deltaTime;

        if (countdown <= 0)
        {
            Destroy(gameObject);
            waveSpawner.waves[waveSpawner.currentWaveIndex].enemiesLeft--;
        }

        Transform targetWaypoint = waypoints[currentWaypointIndex];
        transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.2f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }

    public void TakeDamage(float damage)
    {
        MobHealth -= damage;
        if (MobHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        waveSpawner.waves[waveSpawner.currentWaveIndex].enemiesLeft--;
        Destroy(gameObject);
    }
}
