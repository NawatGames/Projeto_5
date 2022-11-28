using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator mAnimator;
    
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if(mAnimator != null)
        {
            if(Input.GetKeyDown(KeyCode.W))
            {
                mAnimator.SetTrigger("WalkUp");
            }

            if(Input.GetKeyDown(KeyCode.A))
            {
                mAnimator.SetTrigger("WalkLeft");
            }

            if(Input.GetKeyDown(KeyCode.S))
            {
                mAnimator.SetTrigger("WalkDown");
            }

            if(Input.GetKeyDown(KeyCode.D))
            {
                mAnimator.SetTrigger("WalkRight");
            }
        }
    }
}
