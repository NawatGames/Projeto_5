using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject[] guns;
    [SerializeField] int balance = 0;

    [SerializeField] private GameObject rifle;
    private bool getRifle = true;
    private bool getShotgun = true;
    private bool withRifle = false;
    private bool withShotgun = false;
    private Collider2D col;

    [SerializeField] private GameObject shotgun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
    
    
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Coin"))
        {
            balance = balance + 5;
        }

        if (col.CompareTag("Rifle")) { 
            if (getRifle == true) {
                
                col.gameObject.GetComponent<RifleDrop>().destroyObject();
                rifle.transform.parent = gameObject.transform;
                rifle.transform.position = gameObject.transform.position;
                getRifle = false;
                withRifle = true;
            }else if (getRifle == false)
            {
                Debug.Log("Ja tem essa arma"); // Adicionar munição
            }
            
            
        }else if (col.CompareTag("Shotgun"))
        {
            if (getShotgun == true)
            {
                col.gameObject.GetComponent<ShotgunDrop>().destroyObject();
                shotgun.transform.parent = gameObject.transform;
                shotgun.transform.position = gameObject.transform.position;
                getShotgun = false;
                withRifle = true;
            }else if (getShotgun == false)
            {
                Debug.Log("Ja tem essa arma (shotgun)"); // Adicionar munição
            }
            
        }
      
    }
    
}
