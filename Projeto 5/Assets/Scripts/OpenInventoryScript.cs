using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenInventoryScript : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
        SceneManager.LoadScene("InventoryTestScene");
        }
    }
}
