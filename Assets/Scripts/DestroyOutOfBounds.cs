using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Destroy out of bounds objects
    private float topBound = 30;
    private float lowerBound = -30;

    private float leftBound = -30;

    private float rightBound = 30;

    // Update is called once per frame
    void Update()
    {
        // Destroy out of bounds objects
        if (transform.position.y > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y < lowerBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
    }
}
