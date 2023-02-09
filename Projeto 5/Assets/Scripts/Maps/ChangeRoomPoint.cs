using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoomPoint : MonoBehaviour
{
    [SerializeField] private Transform endPoint;
    [SerializeField] private int direction;
    
    // 1 -> top
    // 2 -> bottom
    // 3 -> right
    // 4 -> left

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            col.transform.position = endPoint.transform.position;
            StartCoroutine(move());
            
            
        }
    }

    private IEnumerator move()
    {
        if (direction == 4)
        {
            for (int i = 0; i < 56 ; i++)
            {
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f , Camera.main.transform.position.y,
                    Camera.main.transform.position.z);
                yield return new WaitForSeconds(0.0005f);
            
            }
            Debug.Log("Lado Esquerdo");
        } 
        else if (direction == 3)
        {
            for (int i = 0; i < 56 ; i++)
            {
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f , Camera.main.transform.position.y,
                    Camera.main.transform.position.z);
                yield return new WaitForSeconds(0.0005f);
            
            }
                
            Debug.Log("Lado Direito");
        }
        else if (direction == 2)
        {
            for (int i = 0; i < 32 ; i++)
            {
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x , Camera.main.transform.position.y - 0.5f,
                    Camera.main.transform.position.z);
                yield return new WaitForSeconds(0.000875f);
            
            }
            Debug.Log("Lado Inferior");
        }
        else if (direction == 1)
        {
            for (int i = 0; i < 32; i++)
            {
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x,
                    Camera.main.transform.position.y + 0.5f,
                    Camera.main.transform.position.z);
                yield return new WaitForSeconds(0.000875f);
                Debug.Log("Lado Superior");
            }
        }

    } 
}
