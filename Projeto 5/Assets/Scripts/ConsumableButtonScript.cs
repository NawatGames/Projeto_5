using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsumableButtonScript : MonoBehaviour
{
    public Text ItemQTTXT;

    public void Heal()
    {
        if(StateNameController.sncconsumableqt > 0)
        {
            StateNameController.snchp += 50;
            StateNameController.sncconsumableqt -= 1;
        }
    }

    private void Start()
    {
        ItemQTTXT.text = StateNameController.sncconsumableqt.ToString();
    }

    private void Update()
    {
        ItemQTTXT.text = StateNameController.sncconsumableqt.ToString();
    }
}
