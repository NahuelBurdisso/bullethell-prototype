using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;

    public float bulletForce = 20f;


    // Update is called once per frame
    void Update()
    {
        // Check if the game is paused
        if (PauseMenu.GameIsPaused == false)
        {
            // Check if the left mouse button is pressed
            if (Input.GetButtonDown("Fire1"))
            {
                // Spawn bullet at firePoint
                Shoot();
            }
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

        // Destroy bullet after 2 seconds

        Destroy(bullet, 2f);
    }
}
