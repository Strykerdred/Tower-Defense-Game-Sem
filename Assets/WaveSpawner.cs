using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] private float countdown = 5f; // Countdown for the first wave
    [SerializeField] private GameObject spawnPoint; // The position where enemies spawn
    [SerializeField] private Transform[] waypoints; // Assign this in the inspector

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
                
                // Assign Waypoints and WaveSpawner
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
    public Enemy[] enemies;        // Array of enemy prefabs
    public float timeToNextEnemy;  // Time between enemy spawns
    public float timeToNextWave;   // Time until next wave starts
    [HideInInspector] public int enemiesLeft; // Hidden inspector variable to count enemies
}
