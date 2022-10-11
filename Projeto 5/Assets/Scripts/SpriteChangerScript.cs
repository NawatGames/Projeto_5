using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChangerScript : MonoBehaviour
{
    public Sprite sp1, sp2, sp3;
    public PlayerGearInfo PlayerGear;

    void Update()
    {
        if(PlayerGear.Weapon1ID == 1 || PlayerGear.Weapon2ID == 1)
        {
            GetComponent<SpriteRenderer>().sprite = sp1;
        }

        if(PlayerGear.Weapon1ID == 2 || PlayerGear.Weapon2ID == 2)
        {
            GetComponent<SpriteRenderer>().sprite = sp2;
        }

        if(PlayerGear.Weapon1ID == 3 || PlayerGear.Weapon2ID == 3)
        {
            GetComponent<SpriteRenderer>().sprite = sp3;
        }
    }
}
