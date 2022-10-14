using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject[] guns;
    [SerializeField] int balance = 0;

    [SerializeField] private GameObject rifle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Coin"))
        {
            balance = balance + 5;
        }

        if (col.CompareTag("Rifle"))
        {
            rifle.transform.parent = gameObject.transform;
            rifle.transform.position = gameObject.transform.position;

        }
      
    }
}
