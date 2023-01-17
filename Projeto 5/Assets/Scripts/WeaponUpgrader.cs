using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponUpgrader : MonoBehaviour
{
    public int randomizer;

    void Start()
    {
        StateNameController.sncfirerate = 1;
        StateNameController.sncdamage = 1;
        StateNameController.sncfirepoint = 1;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "FireRateUpgrade")
        {
            StateNameController.sncfirerate++;
        }

        if(collision.gameObject.tag == "DamageUpgrade")
        {
            StateNameController.sncdamage++;
        }

        if(collision.gameObject.tag == "FirePoint") //&& StateNameController.sncfirepoint < 2)
        {
            StateNameController.sncfirepoint++;
        }

        //if(collision.gameObject.tag == "FirePoint" && StateNameController.sncfirepoint > 1)
        //{
        //    randomizer = Random.Range(1,2);
        //    if(randomizer == 1)
        //    {
        //          StateNameController.sncdamage++
        //    }
        //    if(randomizer == 2)
        //    {
        //          StateNameController.sncfirerate++
        //    }
        //}
    }
}
