using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumablePickupScript : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            StateNameController.sncconsumableqt ++;
            Destroy(gameObject);
        }
    }
}
