using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 5f;
    private int currentWaypointIndex = 0;
    public float MobHealth = 10f;
    private float countdown = 100f;
    public WaveSpawner waveSpawner; // WaveSpawner reference
    public int moneyValue = 10;
    public MainBase mainBase;
    private float originalSpeed; // Store the original speed
    private bool dead = false;

    // Start is called before the first frame update
    void Start()
    {
        originalSpeed = speed; // Initialize original speed

        if (waveSpawner == null)
        {
            Debug.LogWarning($"{gameObject.name} has no WaveSpawner assigned!");
        }
        if (mainBase == null)
        {
            mainBase = FindObjectOfType<MainBase>();
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
        if (MobHealth <= 0 && !dead)
        {
            dead = true;
            Die();
        }
    }

    public void ApplySlow(float slowAmount, float duration)
    {
        StartCoroutine(SlowCoroutine(slowAmount, duration));
    }

    private IEnumerator SlowCoroutine(float slowAmount, float duration)
    {
        speed *= slowAmount;
        yield return new WaitForSeconds(duration);
        speed = originalSpeed;
    }

    public void Die()
    {
        print("enemy died");
        waveSpawner.waves[waveSpawner.currentWaveIndex].enemiesLeft--;
        mainBase.money += moneyValue;
        Destroy(gameObject);
    }
}
