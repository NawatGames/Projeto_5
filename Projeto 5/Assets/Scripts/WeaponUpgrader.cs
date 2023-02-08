using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponUpgrader : MonoBehaviour
{
    public int randomizer;

    void Start()
    {
        StateNameController.sncfirerate = 1.00f;
        StateNameController.sncdamage = 1;
        StateNameController.sncfirepoint = 1;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "FireRateUpgrade")
        {
            StateNameController.sncfirerate += 0.5f;
            Debug.Log("Firerate");
        }

        if(collision.gameObject.tag == "DamageUpgrade")
        {
            StateNameController.sncdamage++;
            Debug.Log("DMG");
        }

        if(collision.gameObject.tag == "FirePoint" && StateNameController.sncfirepoint < 2)
        {
            StateNameController.sncfirepoint++;
            Debug.Log("Firepoint");
        }

        //if(collision.gameObject.tag == "FirePoint" && StateNameController.sncfirepoint >= 2)
        //{
        //    randomizer = Random.Range(1,2);
        //    if(randomizer == 1)
        //    {
        //          StateNameController.sncdamage++;
        //          Debug.Log("DMG");
        //    }
        //    if(randomizer == 2)
        //    {
        //          StateNameController.sncfirerate++;
        //          Debug.Log("Firerate");
        //    }
        //}
    }
}
