using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveButtonScript : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("ShopNPCTestScene");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("ShopNPCTestScene");
        }
    }
}
