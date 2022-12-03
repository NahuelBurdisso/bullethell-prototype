using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Script on the enemy prefab that tracks the player and moves towards them in a 2d game

    // Player object
    private GameObject player;

    // Speed of enemy
    public float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Find the player object
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // If the player exists
        if (player != null)
        {
            // Move towards the player
            Vector2 direction = player.transform.position - transform.position;
            transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Destroy enemy when it collides with a bullet
        if (collision.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }

        // Reduce player health if it collides with the enemy
        if (collision.CompareTag("Player"))
        {
            PlayerController playerController = collision.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.Damage();
            }
        }
    }
}
