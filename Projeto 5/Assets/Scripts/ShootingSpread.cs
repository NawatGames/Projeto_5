using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSpread : MonoBehaviour
{
    public Transform bulletPrefab;
    public Transform firepoint;
    public int bulletCount = 10;
    public float spreadAngle = 10f;
    public float bulletSpeed = 10f;
    public Camera mainCamera;
    public float fireangle;

    void Update()
    {
        Vector3 cursorPos = Input.mousePosition;
        cursorPos = mainCamera.ScreenToWorldPoint(cursorPos);

        Vector3 direction = cursorPos -transform.position;
        fireangle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if(Input.GetButtonDown("Fire1"))
        {
            for(int i = 0; i < bulletCount; i++)
            {
                float spread = Random.Range(-spreadAngle, spreadAngle);
                Quaternion rotation = Quaternion.Euler(0, 0, fireangle + spread);
                Transform bullet = Instantiate(bulletPrefab, firepoint.position, rotation);
                bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.right * bulletSpeed;
            }
        }
    }
}
