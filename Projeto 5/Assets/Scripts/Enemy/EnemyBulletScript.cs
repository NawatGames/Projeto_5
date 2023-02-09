using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    [SerializeField] private ParticleSystem effect;
    [SerializeField] private float speed;
    private Transform player;
    private Vector2 direction;
    private Vector2 target;
    [SerializeField] private float attackDamage;
    public static bool isDashing = false;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        direction = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        target = new Vector2(transform.position.x + direction.x * 1000, transform.position.y + direction.y * 1000);

    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // if (transform.position.x == target.x && transform.position.y == target.y)
        // {
        //     DestroyBullet();
        // }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        { 
            if (!isDashing)
            {
                col.gameObject.GetComponent<PlayerHealth>().UpdateHealth(-attackDamage);
                Instantiate(effect, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }

        if (col.CompareTag("Wall"))
        {
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
