using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{
    public RoomSpawner roomspawner;
    // Start is called before the first frame update
    void Awake()
    {
        roomspawner.Restart();
    }

    
}
