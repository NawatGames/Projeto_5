using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   public float speed = 3f;
   private Transform target;

   private void Update()
   {
      if (target != null)
      {
         float step = speed * Time.deltaTime;
         transform.position = Vector2.MoveTowards(transform.position, target.position, step);
         
      }
   }

   private void OnTriggerEnter2D(Collider2D col)
   {
      if (col.gameObject.tag == "Player")
      {
         target = col.transform;
         Debug.Log("Target!");
      }
   }

   private void OnTriggerExit2D(Collider2D other)
   {
      if (other.gameObject.tag == "Player")
      {
         target = null;
      }
   }
}
