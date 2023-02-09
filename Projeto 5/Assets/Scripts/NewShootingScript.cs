using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewShootingScript : MonoBehaviour
{
    public Transform firePoint;
    public Transform bulletprefab;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    private float fireRate;
    private float fireRate0 = 0.5f;
    private float nextFire = 0f;
    public Camera mainCamera;
    public float fireangle;
    public int bulletCount = 2;
    public float spreadAngle = 2f;
    public float bulletSpeed = 10f;

    void Update()
    {
        fireRate = fireRate0/StateNameController.sncfirerate;

        Vector3 cursorPos = Input.mousePosition;
        cursorPos = mainCamera.ScreenToWorldPoint(cursorPos);

        Vector3 direction = cursorPos -transform.position;
        fireangle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

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
        for(int i = 0; i < bulletCount; i++)
            {
                float spread = Random.Range(-spreadAngle, spreadAngle);
                Quaternion rotation = Quaternion.Euler(0, 0, fireangle + spread);
                Transform bullet = Instantiate(bulletprefab, transform.position, rotation);
                bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.right * bulletSpeed;
            }
    }
    
    public void FirepointUpgrade()
    {
        bulletCount++;
        if (spreadAngle < 10)
        {
            spreadAngle+= 1.5f;
        }
    }
}
