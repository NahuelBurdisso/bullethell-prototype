using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Spawn enemy prefab
    public GameObject[] enemiesPrefabs;

    // Spawn rate
    public float spawnRate = 2f;

    // Spawn range
    public float spawnRange = 9f;

    public float minTopSpawn = 4f;

    // Start is called before the first frame update
    void Start()
    {
        // Invoke repeating calls to SpawnEnemy() method
        InvokeRepeating("SpawnEnemy", 1f, spawnRate);
    }



    void SpawnEnemy()
    {
        // Randomly pick an enemy prefab
        int enemyIndex = Random.Range(0, enemiesPrefabs.Length);

        // Randomly pick a spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), minTopSpawn, spawnRange);

        // Spawn enemy at the spawn position
        Instantiate(enemiesPrefabs[enemyIndex], spawnPos, enemiesPrefabs[enemyIndex].transform.rotation);
    }

    
}
