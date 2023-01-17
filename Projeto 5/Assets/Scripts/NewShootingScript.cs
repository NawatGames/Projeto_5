using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewShootingScript : MonoBehaviour
{
    public Transform firePoint;
    public Transform firePoint2;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    private float fireRate = 0.5f;
    private float nextFire = 0f;

    void Update()
    {
        fireRate = fireRate/StateNameController.sncfirerate;

        if(Input.GetMouseButton(0) && Time.time > nextFire && StateNameController.sncfirepoint < 2)
        {
            nextFire = Time.time + fireRate;
            Shoot1();
        }

        if(Input.GetMouseButton(0) && Time.time > nextFire && StateNameController.sncfirepoint > 1)
        {
            nextFire = Time.time + fireRate;
            Shoot2();
        }
    }

    void Shoot1()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); // Instanciar um objeto (bullet) do tipo GameObject
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>(); // Instanciar um objeto (rb) do tipo RigidBody2D que recebe o componente RigidBody2D do objeto bullet
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse); // Adiciona força ao rb (rigid body) do objeto bullet
    }

    void Shoot2()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); // Instanciar um objeto (bullet) do tipo GameObject
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>(); // Instanciar um objeto (rb) do tipo RigidBody2D que recebe o componente RigidBody2D do objeto bullet
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse); // Adiciona força ao rb (rigid body) do objeto bullet
        GameObject bullet2 = Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
        Rigidbody2D rb2 = bullet2.GetComponent<Rigidbody2D>();
        rb2.AddForce(firePoint2.up * bulletForce, ForceMode2D.Impulse);
    }
}
