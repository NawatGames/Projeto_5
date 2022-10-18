using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopNPCScript : MonoBehaviour
{
    //https://www.youtube.com/watch?v=1nFNOyCalzo adaptado
    
    public bool PlayerClose;
    public GameObject DialoguePanel;
    public Text DialogueText;
    public string[] dialogue;



    void Update()
    {
        if(PlayerClose == false)
        {
            DialogueText.text = "";
            DialoguePanel.SetActive(false);
        }

        if(PlayerClose == true)
        {
            DialogueText.text = "Aperte F para abrir a loja";
            DialoguePanel.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.F) && PlayerClose.Equals(true))
        {
            SceneManager.LoadScene("ShopTestScene");
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
