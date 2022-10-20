using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButtonScript : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("PauseMenu");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
        SceneManager.LoadScene("PauseMenu");
        }
    }
}