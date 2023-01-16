using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoomPoint : MonoBehaviour
{
    [SerializeField] private Transform endPoint;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            col.transform.position = endPoint.transform.position;
        }
    }
}
