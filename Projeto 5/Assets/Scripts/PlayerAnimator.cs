using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public bool MovingUp;

    void Start()
    {
        MovingUp = false;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            MovingUp = true;
        }

        else
        {
            MovingUp = false;
        }
    }
}
