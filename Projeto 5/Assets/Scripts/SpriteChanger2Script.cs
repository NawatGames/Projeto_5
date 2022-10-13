using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger2Script : MonoBehaviour
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
        if(Weapon2ID == 1)
        {
            GetComponent<SpriteRenderer>().sprite = sp1;
        }

        if(Weapon2ID == 2)
        {
            GetComponent<SpriteRenderer>().sprite = sp2;
        }

        if(Weapon2ID == 3)
        {
            GetComponent<SpriteRenderer>().sprite = sp3;
        }
    }
}