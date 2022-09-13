using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=LNLVOjbrQj4
//https://www.youtube.com/watch?v=LNLVOjbrQj4
//https://www.youtube.com/watch?v=Kvd4Fnb9EPo

public class ShootingScript : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce =  20f;
    private float fireRate = 0.1f; //valor do firerate muda de arma p arma
    private float nextFire = 0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet  = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up*bulletForce, ForceMode2D.Impulse);
    }
}
