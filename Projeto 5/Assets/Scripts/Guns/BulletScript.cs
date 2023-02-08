using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private ParticleSystem effect;
    [SerializeField] float attackDamage = 20f;
    [SerializeField] private float maxDistance = 10f;
    private Transform player;
    
    

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Colisão");
        if (col.CompareTag("Enemy"))
        { 
            Debug.Log("Teste");
            col.gameObject.GetComponent<EnemyHealth>().UpdateHealth(-attackDamage);
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        if (col.CompareTag("Wall"))
        {
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
