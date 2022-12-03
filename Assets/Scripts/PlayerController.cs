using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 2.0f;

    // define player health
    public int health = 3;

    public Camera cam;
    private Rigidbody2D playerRb;
    Vector2 movement;
    Vector2 mousePos;

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        // Movement
        playerRb.MovePosition(playerRb.position + movement * moveSpeed * Time.fixedDeltaTime);

        // Rotate player to look at the mouse cursor
        Vector2 lookDir = mousePos - playerRb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        playerRb.rotation = angle;


    }

    public void Damage()
    {
        health--;
        if (health <= 0)
        {
            Destroy(gameObject);


        }
    }


}
