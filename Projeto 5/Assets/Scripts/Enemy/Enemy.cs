using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   [Header("Stats")]
   [SerializeField] private float speed;
   [SerializeField] private float stoppingDistance;
   [SerializeField] private float startTimeBtwShots;
   private float timeBtwShots;
   [SerializeField] private float retreatDistance;
   
   
   [Header("References")]
   private Transform player;
   public GameObject bullet;
   //[SerializeField] private Transform firePoint;
   
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
      }else if (Vector2.Distance(transform.position, player.position) < stoppingDistance &&
                Vector2.Distance(transform.position, player.position) > retreatDistance)
      {
         transform.position = this.transform.position;
      } else if (Vector2.Distance(transform.position, player.position) < retreatDistance)
      {
         transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
      }
      
      if (timeBtwShots <= 0)
      {
         Instantiate(bullet, transform.position,Quaternion.identity);
         timeBtwShots = startTimeBtwShots;
      }else
      {
         timeBtwShots -= Time.deltaTime;
      }
   }
   
   
}
