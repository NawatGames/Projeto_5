using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) // Caso o botao esquerdo do mouse seja clickado, a função Shoot() será chamada
        {
            Shoot(); // Chama a função Shoot
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); // Instanciar um objeto (bullet) do tipo GameObject
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>(); // Instanciar um objeto (rb) do tipo RigidBody2D que recebe o componente RigidBody2D do objeto bullet
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse); // Adiciona força ao rb (rigid body) do objeto bullet
    }
}

// Comentarios:
// Testar com script com movimento do player
// firePointer não rotaciona com o mouse
