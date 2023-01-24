using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSpread : MonoBehaviour
{
    public Transform bulletPrefab;
    public int bulletCount = 10;
    public float spreadAngle = 10f;
    public float bulletSpeed = 10f;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            for(int i = 0; i < bulletCount; i++)
            {
                float angle = Random.Range(-spreadAngle, spreadAngle);
                Quaternion rotation = Quaternion.Euler(0, 0, angle);
                Transform bullet = Instantiate(bulletPrefab, transform.position, rotation);
                bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.right * bulletSpeed;
            }
        }
    }
}
