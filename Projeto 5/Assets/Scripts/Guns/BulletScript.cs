using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private ParticleSystem effect;
    [SerializeField] float attackDamage = 20f;
    [SerializeField] private float maxDistance = 10f;
    private Transform player;

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        { 
            col.gameObject.GetComponent<EnemyHealth>().UpdateHealth(-attackDamage);
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    
    }
    
}
