using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyHealth : MonoBehaviour
{
    private float health = 0f;
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private GameObject[] drops;
    private int rand;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }


    public void UpdateHealth(float mod)
    {
        health += mod;

        if (health <= 0)
        {
            this.health = 0;
            RandomDrop();
            Destroy(gameObject,0.1f);
            //Instantiate(coinPrefab, transform.position, Quaternion.identity);

        }
    }
    

    void RandomDrop()
    {
        rand = UnityEngine.Random.Range(0, 100);
        if (rand < 40)
        {
            Instantiate(drops[0], transform.position, transform.rotation);
        }
        else
        {
            Instantiate(drops[1], transform.position, transform.rotation);
        }

        
    }
    
}
