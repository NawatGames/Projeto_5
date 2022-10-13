using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public Text CoinTXT;
    public Text ConsumableTXT;
    
    void Start()
    {
        CoinTXT.text = "Moedas: " + StateNameController.snccoinqt.ToString();
        ConsumableTXT.text = StateNameController.sncconsumableqt.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
