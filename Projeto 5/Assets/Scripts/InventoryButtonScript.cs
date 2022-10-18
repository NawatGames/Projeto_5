using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryButtonScript : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("InventoryTestScene");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
        SceneManager.LoadScene("InventoryTestScene");
        }
    }
}
