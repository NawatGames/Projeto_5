using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using Random = System.Random;

public class EnemyHealth : MonoBehaviour
{
    private float health = 0f;
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] GameObject coinPrefab;
    [SerializeField] private GameObject[] drops;
    private Random random = new Random();
    

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    private void Update()
    {
        if (this.health == 0)
        {
            Invoke("randomDrop",1f);
            Destroy(gameObject,0.1f);
            
        }
    }


    public void updateHealth(float mod)
    {
        health += mod;

        if (health <= 0)
        {
            this.health = 0;
            //Instantiate(coinPrefab, transform.position, Quaternion.identity);

        }
    }
    

    void randomDrop()
    {
        int index = random.Next(0, drops.Length);
        Instantiate(drops[index], transform.position, transform.rotation);

        
    }
}
