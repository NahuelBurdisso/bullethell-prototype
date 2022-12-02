using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   [SerializeField] private float bulletSpeed = 5.0f;

   void Update() {
        BulletMovement();
   }

    void BulletMovement() {
        Vector3 bulletVelocity = Vector3.right * bulletSpeed;
        transform.Translate(bulletVelocity * Time.deltaTime);
    }
}
