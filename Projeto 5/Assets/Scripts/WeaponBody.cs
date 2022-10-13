using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WeaponBody : MonoBehaviour
{
    //https://www.youtube.com/watch?v=1nFNOyCalzo adaptado
    
    public bool PlayerClose;
    public GameObject DialoguePanel2;
    public Text DialogueText2;
    public string[] dialogue;
    public int WeaponTypeID;



    void Update()
    {
        if(PlayerClose == false)
        {
            DialogueText2.text = "";
            DialoguePanel2.SetActive(false);
        }

        if(PlayerClose == true)
        {
            DialogueText2.text = "Aperte 1 ou 2 para pegar a arma";
            DialoguePanel2.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.Alpha1) && PlayerClose.Equals(true))
        {
            if(WeaponTypeID.Equals(1))
            {
                //Debug.Log("Pistola");
                StateNameController.sncweapon1ID = 1;
                Destroy(gameObject);
                DialoguePanel2.SetActive(false);
            }

            if(WeaponTypeID.Equals(2))
            {
                //Debug.Log("Shotgun");
                StateNameController.sncweapon1ID = 2;
                Destroy(gameObject);
                DialoguePanel2.SetActive(false);
            }

            if(WeaponTypeID.Equals(3))
            {
                //Debug.Log("Rifle");
                StateNameController.sncweapon1ID = 3;
                Destroy(gameObject);
                DialoguePanel2.SetActive(false);
            }
        }

        if(Input.GetKeyDown(KeyCode.Alpha2) && PlayerClose.Equals(true))
        {
            if(WeaponTypeID.Equals(1))
            {
                //Debug.Log("Pistola");
                StateNameController.sncweapon2ID = 1;
                Destroy(gameObject);
                DialoguePanel2.SetActive(false);
            }

            if(WeaponTypeID.Equals(2))
            {
                //Debug.Log("Shotgun");
                StateNameController.sncweapon2ID = 2;
                Destroy(gameObject);
                DialoguePanel2.SetActive(false);
            }

            if(WeaponTypeID.Equals(3))
            {
                //Debug.Log("Rifle");
                StateNameController.sncweapon2ID = 3;
                Destroy(gameObject);
                DialoguePanel2.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerClose = false;
        }
    }
}
