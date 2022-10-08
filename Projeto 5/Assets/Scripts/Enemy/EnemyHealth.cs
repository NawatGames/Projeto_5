using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private float health = 0f;
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] GameObject coinPrefab;
    

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
            Destroy(gameObject,0.1f);
            
        }
    }


    public void updateHealth(float mod)
    {
        health += mod;

        if (health <= 0)
        {
            this.health = 0;
            Instantiate(coinPrefab, transform.position, Quaternion.identity);

        }
    }
}
