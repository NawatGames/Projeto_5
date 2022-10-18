using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChangerScript : MonoBehaviour
{
    public Sprite sp1, sp2, sp3;
    public int Weapon1ID;
    public int Weapon2ID;
    public int ConsumableQuantity;

    private void Start()
    {
        Weapon1ID = StateNameController.sncweapon1ID;
        Weapon2ID = StateNameController.sncweapon2ID;
        
    }

    private void Update()
    {
        if(Weapon1ID == 1)
        {
            GetComponent<SpriteRenderer>().sprite = sp1;
        }

        if(Weapon1ID == 2)
        {
            GetComponent<SpriteRenderer>().sprite = sp2;
        }

        if(Weapon1ID == 3)
        {
            GetComponent<SpriteRenderer>().sprite = sp3;
        }
    }
}