using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleDrop : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    // private void OnTriggerEnter2D(Collider2D col)
    // {
    //     if (col.CompareTag("Player"))
    //     {
    //         Destroy(gameObject);
    //     }
    // }

    public void destroyObject()
    {
        Destroy(gameObject);
    }
}
