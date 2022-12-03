using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Spawn enemy prefab
    public GameObject enemyPrefab;

    // Spawn rate
    public float spawnRate = 2f;

    // Start is called before the first frame update
    void Start()
    {
        // Invoke repeating calls to SpawnEnemy() method
        InvokeRepeating("SpawnEnemy", 1f, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        // Instantiate enemy at random x position at top of screen
        Instantiate(enemyPrefab, new Vector2(Random.Range(-8f, 8f), 7), Quaternion.identity);
    }

    
}
