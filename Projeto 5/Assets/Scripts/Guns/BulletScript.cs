using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private ParticleSystem effect;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        {
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    
    }
    }
