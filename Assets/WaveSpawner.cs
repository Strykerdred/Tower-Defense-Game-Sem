using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] private float countdown = 10f; // countdown for the first wave
    [SerializeField] private GameObject spawnPoint; // the position where enemies spawn
    [SerializeField] private Transform[] waypoints; // assign this in the inspector

    public Wave[] waves;
    public int currentWaveIndex = 0;
    private bool readyToCountDown = true;

    private void Start()
    {
        for (int i = 0; i < waves.Length; i++)
        {
            waves[i].enemiesLeft = waves[i].enemies.Length;
        }
    }

    private void Update()
    {
        print(waves[currentWaveIndex].enemiesLeft);
        if (currentWaveIndex >= waves.Length)
        {
            Debug.Log("You survived every wave!");
            return;
        }

        if (readyToCountDown)
        {
            countdown -= Time.deltaTime;
        }

        if (countdown <= 0)
        {
            readyToCountDown = false;
            countdown = waves[currentWaveIndex].timeToNextWave;
            StartCoroutine(SpawnWave());
        }

        if (waves[currentWaveIndex].enemiesLeft == 0 && !readyToCountDown)
        {
            readyToCountDown = true;
            currentWaveIndex++;
        }
    }

    private IEnumerator SpawnWave()
    {
        if (currentWaveIndex < waves.Length)
        {
            for (int i = 0; i < waves[currentWaveIndex].enemies.Length; i++)
            {
                Enemy enemy = Instantiate(waves[currentWaveIndex].enemies[i], spawnPoint.transform.position, spawnPoint.transform.rotation);
                
                // Assign waypoint & wavespawner
                enemy.waypoints = waypoints; 
                enemy.waveSpawner = this; 

                yield return new WaitForSeconds(waves[currentWaveIndex].timeToNextEnemy);
            }
        }
    }
}

[System.Serializable]
public class Wave
{
    public Enemy[] enemies;
    public float timeToNextEnemy;  // time between each enemy
    public float timeToNextWave;   // time until next wave
    [HideInInspector] public int enemiesLeft;
}
