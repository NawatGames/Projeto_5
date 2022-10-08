using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
