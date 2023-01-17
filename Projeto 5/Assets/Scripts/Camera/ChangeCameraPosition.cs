using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraPosition : MonoBehaviour
{
    private Vector3 pos = Camera.main.transform.position;
    private void Start()
    {
         
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.CompareTag("Player"))
        {
            Debug.Log(pos);
            Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 28, Camera.main.transform.position.y,
                Camera.main.transform.position.z);

        }
    }
}

