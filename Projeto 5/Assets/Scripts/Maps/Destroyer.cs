using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.CompareTag("Player") && !col.CompareTag("Enemy") && !col.CompareTag("EnemyBullet") && !col.CompareTag("Bullet"))
        {
            Destroy(col.gameObject);
        }
    }
}
