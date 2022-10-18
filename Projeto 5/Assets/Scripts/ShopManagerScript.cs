using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{
    //https://www.youtube.com/watch?v=Oie-G5xuQNA

    public int[,] shopItems = new int[5,5];
    public float coins;
    public Text CoinsTXT;

    // Start is called before the first frame update
    void Start()
    {
        CoinsTXT.text = "Moedas: " + StateNameController.snccoinqt.ToString();

        //ID
        shopItems[1,1] = 1;
        shopItems[1,2] = 2;
        shopItems[1,3] = 3;
        shopItems[1,4] = 4;
        
        //Preço
        shopItems[2,1] = 1;
        shopItems[2,2] = 20;
        shopItems[2,3] = 30;
        shopItems[2,4] = 40;
        
        //Quantidade
        shopItems[3,1] = 0;
        shopItems[3,2] = 0;
        shopItems[3,3] = 0;
        shopItems[3,4] = 0;

        //Tipo
        shopItems[4,1] = 1; //consumivel
        shopItems[4,2] = 2; //arma
        shopItems[4,3] = 3; //3 e 4 sao placeholders
        shopItems[4,4] = 4;


    }

    public void Buy()
    {
        GameObject ButtonRef =  GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        if (StateNameController.snccoinqt >= shopItems[2, ButtonRef.GetComponent<ButtonInfoScript>().ItemID] && shopItems[4, ButtonRef.GetComponent<ButtonInfoScript>().ItemID] == 1)
        {
            StateNameController.snccoinqt -= shopItems[2, ButtonRef.GetComponent<ButtonInfoScript>().ItemID];
            shopItems[3, ButtonRef.GetComponent<ButtonInfoScript>().ItemID]++;
            ButtonRef.GetComponent<ButtonInfoScript>().QuantityTXT.text = shopItems[3, ButtonRef.GetComponent<ButtonInfoScript>().ItemID].ToString();
            CoinsTXT.text = "Moedas: " + StateNameController.snccoinqt.ToString();
            StateNameController.sncconsumableqt += shopItems[3, ButtonRef.GetComponent<ButtonInfoScript>().ItemID];

        }

        if (StateNameController.snccoinqt >= shopItems[2, ButtonRef.GetComponent<ButtonInfoScript>().ItemID] && shopItems[4, ButtonRef.GetComponent<ButtonInfoScript>().ItemID] >= 2 && shopItems[3, ButtonRef.GetComponent<ButtonInfoScript>().ItemID] <= 0)
        {
            StateNameController.snccoinqt -= shopItems[2, ButtonRef.GetComponent<ButtonInfoScript>().ItemID];
            shopItems[3, ButtonRef.GetComponent<ButtonInfoScript>().ItemID]++;
            ButtonRef.GetComponent<ButtonInfoScript>().QuantityTXT.text = shopItems[3, ButtonRef.GetComponent<ButtonInfoScript>().ItemID].ToString();
            CoinsTXT.text = "Moedas: " + StateNameController.snccoinqt.ToString();

        }
    }
}
