using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   [SerializeField] private float speed;
   private GameObject player;
   private bool isAlive = true;

   private void Start()
   {
      player = GameObject.FindGameObjectWithTag("Player");
   }

   private void Update()
   {
      if (player != null && isAlive)
      {
         transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
      }
   }

   private void OnTriggerEnter2D(Collider2D col)
   {
      if (col.CompareTag("Bullet"))
      {
         isAlive = false;
         Destroy(gameObject,0.05f);
      }
      
   }

   
}
