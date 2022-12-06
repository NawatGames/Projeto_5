using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator2 : MonoBehaviour
{
    public GameObject protag;
    
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            protag.GetComponent<Animator>().Play("Protag_Pistol_Walk_Up");
        }

        if(Input.GetKey(KeyCode.A))
        {
            protag.GetComponent<Animator>().Play("Protag_Pistol_Walk_Left");
        }

        if(Input.GetKey(KeyCode.S))
        {
            protag.GetComponent<Animator>().Play("Protag_Pistol_Walk_Down");
        }

        if(Input.GetKey(KeyCode.D))
        {
            protag.GetComponent<Animator>().Play("Protag_Pistol_Walk_Right");
        }

        //else
        //{
        //    protag.GetComponent<Animator>().Play("Protag_Idle_Down"); 
        //}
    }
}
