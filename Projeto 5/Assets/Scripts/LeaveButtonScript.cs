using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveButtonScript : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene(StateNameController.snc_scene);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(StateNameController.snc_scene);
        }
    }
}
