using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfoScript : MonoBehaviour
{

    public int ItemID;
    public Text PriceTXT;
    public Text QuantityTXT;
    public Text BoughtTXT;
    public GameObject ShopManager;

    void Update()
    {
       if(ShopManager.GetComponent<ShopManagerScript>().shopItems[4, ItemID] == 1)
        {
            PriceTXT.text = "Preço: " + ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString();
            QuantityTXT.text = StateNameController.sncconsumableqt.ToString();
            BoughtTXT.text = "";
        }

        if(ShopManager.GetComponent<ShopManagerScript>().shopItems[4, ItemID] >= 2 && ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID] <= 0)
        {
            PriceTXT.text = "Preço: " + ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString();
            QuantityTXT.text = ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID].ToString();
            BoughtTXT.text = "";
        }

        if(ShopManager.GetComponent<ShopManagerScript>().shopItems[4, ItemID] >= 2 && ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID] >= 1)
        {
            PriceTXT.text = "";
            QuantityTXT.text = "";
            BoughtTXT.text = "Comprado";
        }
    }
}
