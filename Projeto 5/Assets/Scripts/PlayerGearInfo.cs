using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGearInfo : MonoBehaviour
{
    public int Weapon1ID;
    public int Weapon2ID;
    public int ConsumableQuantity;
    public int Coins;
    public Text HPTxt;

    private void Start()
    {
        StateNameController.sncweapon1ID += Weapon1ID;
        StateNameController.sncweapon2ID += Weapon2ID;
        StateNameController.sncconsumableqt += ConsumableQuantity;
        StateNameController.snccoinqt += Coins;

        HPTxt.text = "HP: " + StateNameController.snchp;
    }

    private void Update()
    {
        HPTxt.text = "HP: " + StateNameController.snchp;
    }
}
