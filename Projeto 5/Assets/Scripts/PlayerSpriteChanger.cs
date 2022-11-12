using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteChanger : MonoBehaviour
{
    public Sprite faceUp,faceDown,faceLeft,faceRight;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<SpriteRenderer>().sprite = faceUp;
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().sprite = faceLeft;
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<SpriteRenderer>().sprite = faceDown;
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<SpriteRenderer>().sprite = faceRight;
        }
    }
}
