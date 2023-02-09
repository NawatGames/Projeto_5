using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshotgun : MonoBehaviour
{
   [Header("Stats")]
   private float speed = 5f;
   [SerializeField] private float stoppingDistance;
   [SerializeField] private float startTimeBtwShots;
   private float timeBtwShots;
   [SerializeField] private float retreatDistance;
   
   
   [Header("References")]
   private Transform player;
   public GameObject bullet;
   //[SerializeField] private Transform firePoint;
   public Transform firepoint;
   public Transform firepoint2;
   public Transform firepoint3;
   
   private void Start()
   {
      player = GameObject.FindGameObjectWithTag("Player").transform;
      timeBtwShots = startTimeBtwShots;

   }

   private void Update()
   {
      if (Vector2.Distance(transform.position,player.position) > stoppingDistance)
      {
         transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
      }

      else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
      {
        transform.position = this.transform.position;
      }

      else if (Vector2.Distance(transform.position, player.position) < retreatDistance)
      {
         transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
      }
      
      if (Vector2.Distance(transform.position, player.position) >= 10)
      {
         this.speed = 0;
      }
      else
      {
         speed = 5f;
      }
      
      if (timeBtwShots <= 0 && Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
      {
         Instantiate(bullet, firepoint.position,Quaternion.identity);
         Instantiate(bullet, firepoint2.position,Quaternion.identity);
         Instantiate(bullet, firepoint3.position,Quaternion.identity);
         timeBtwShots = startTimeBtwShots;
      }else
      {
         timeBtwShots -= Time.deltaTime;
      }
   }
   
   
}