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
        int index = Random.Range(0, drops.Length);
        Instantiate(drops[index], transform.position, transform.rotation);
        
    }
    
}
