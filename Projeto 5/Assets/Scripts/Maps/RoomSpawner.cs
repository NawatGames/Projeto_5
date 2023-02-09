using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = Unity.Mathematics.Random;

public class RoomSpawner: MonoBehaviour
{
    public int openingDirection;
    // 1 --> need bottom door
    // 2 --> need top door
    // 3 --> need left door
    // 4 --> need right door

    static int roomCount = 0;
    private RoomTemplates templates;
    private int rand;
    private bool spawned = false;
    public float waitTime = 4f;

    private int testchance;
    static int test4 = 0;

    

    private void Start()
    {
        Destroy(gameObject,waitTime);
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn",0.3f);
    }

    private void Spawn()
    {
        Debug.Log(roomCount);
        if (!spawned)
        {
            if (roomCount <= 16)
            {
                if (openingDirection == 1)
                {
                    Instantiate(templates.bottomRooms[1], transform.position, templates.bottomRooms[1].transform.rotation);
                }
                else if (openingDirection == 2)
                {
                    Instantiate(templates.topRooms[1], transform.position, templates.topRooms[1].transform.rotation);

                }
                else if (openingDirection == 3)
                {
                    Instantiate(templates.leftRooms[1], transform.position, templates.leftRooms[1].transform.rotation);

                }
                else if (openingDirection == 4)
                {
                    Instantiate(templates.rightRooms[1], transform.position, templates.rightRooms[1].transform.rotation);
                }
                roomCount++;
                spawned = true;
            }
            Debug.Log(test4);
            if (test4 < 4 && !spawned)
            {
                if (openingDirection == 1)
                {
                    Instantiate(templates.bottomRooms[4], transform.position, templates.bottomRooms[4].transform.rotation);
                }
                else if (openingDirection == 2)
                {
                    // Need to spawn a room with a TOP door.
                    Instantiate(templates.topRooms[4], transform.position, templates.topRooms[4].transform.rotation);

                }
                else if (openingDirection == 3)
                {
                    // Need to spawn a room with a LEFT door.
                    Instantiate(templates.leftRooms[4], transform.position, templates.leftRooms[4].transform.rotation);

                }
                else if (openingDirection == 4)
                {
                    // Need to spawn a room with a RIGHT door.
                    Instantiate(templates.rightRooms[4], transform.position, templates.rightRooms[4].transform.rotation);
                }
                roomCount++;
                spawned = true;
                test4++;
            }

            if (roomCount <= 70 && !spawned)
            {
                testchance = UnityEngine.Random.Range(1,10000) % 100;
                if (testchance < 20)
                {
                    if (openingDirection == 1)
                    {
                        Instantiate(templates.bottomRooms[1], transform.position, templates.bottomRooms[1].transform.rotation);
                    }
                    else if (openingDirection == 2)
                    {
                        Instantiate(templates.topRooms[1], transform.position, templates.topRooms[1].transform.rotation);

                    }
                    else if (openingDirection == 3)
                    {
                        Instantiate(templates.leftRooms[1], transform.position, templates.leftRooms[1].transform.rotation);

                    }
                    else if (openingDirection == 4)
                    {
                        Instantiate(templates.rightRooms[1], transform.position, templates.rightRooms[1].transform.rotation);
                    }
                    roomCount++;
                    spawned = true;
                }
                else
                {
                    if (openingDirection == 1)
                    {
                        rand = (UnityEngine.Random.Range(0, 100) % 3) + 1;
                        Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
                    }
                    else if (openingDirection == 2)
                    {
                        // Need to spawn a room with a TOP door.
                        rand = (UnityEngine.Random.Range(0, 100) % 3) + 1;
                        Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);

                    }
                    else if (openingDirection == 3)
                    {
                        // Need to spawn a room with a LEFT door.
                        rand = (UnityEngine.Random.Range(0, 100) % 3) + 1;
                        Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);

                    }
                    else if (openingDirection == 4)
                    {
                        // Need to spawn a room with a RIGHT door.
                        rand = (UnityEngine.Random.Range(0, 100) % 3) + 1;
                        Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
                    }
                    roomCount++;
                    spawned = true;
                }
            }

            if (roomCount < 200 && !spawned)
            {
                if (openingDirection == 1)
                {
                    rand = (UnityEngine.Random.Range(0, 100) % 3) + 1;
                    Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
                }
                else if (openingDirection == 2)
                {
                    // Need to spawn a room with a TOP door.
                    rand = (UnityEngine.Random.Range(0, 100) % 3) + 1;
                    Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);

                }
                else if (openingDirection == 3)
                {
                    // Need to spawn a room with a LEFT door.
                    rand = (UnityEngine.Random.Range(0, 100) % 3) + 1;
                    Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);

                }
                else if (openingDirection == 4)
                {
                    // Need to spawn a room with a RIGHT door.
                    rand = (UnityEngine.Random.Range(0, 100) % 3) + 1;
                    Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
                }
                roomCount++;
                spawned = true;
            }

            if (!spawned) // closes all openings
            {
                if (openingDirection == 1)
                {
                    Instantiate(templates.bottomRooms[0], transform.position, templates.bottomRooms[0].transform.rotation);
                }
                else if (openingDirection == 2)
                {
                    Instantiate(templates.topRooms[0], transform.position, templates.topRooms[0].transform.rotation);

                }
                else if (openingDirection == 3)
                {
                    Instantiate(templates.leftRooms[0], transform.position, templates.leftRooms[0].transform.rotation);

                }
                else if (openingDirection == 4)
                {
                    Instantiate(templates.rightRooms[0], transform.position, templates.rightRooms[0].transform.rotation);
                }
                spawned = true;
            }
            spawned = true;
        }

        
    }
    public void Restart()
    {
        roomCount = 0;
        test4 = 0;
    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("SpawnPoint"))
    //    {
    //        if (other.GetComponent<RoomSpawner>().spawned == false && spawned == false)
    //        {
    //            Instantiate(templates.closedRoom, transform.position, Quaternion.identity);
    //            Destroy(gameObject);
    //        }

    //        spawned = true;
    //    }  
    //}
}
/*
if (roomCount <= 100)
{
    Debug.Log("<=100");
    if (openingDirection == 1)
    {
        // Need to spawn a room with a BOTTOM door.
        rand = UnityEngine.Random.Range(1, templates.bottomRooms.Length);
        Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
    }
    else if (openingDirection == 2)
    {
        // Need to spawn a room with a TOP door.
        rand = UnityEngine.Random.Range(1, templates.topRooms.Length);
        Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);

    }
    else if (openingDirection == 3)
    {
        // Need to spawn a room with a LEFT door.
        rand = UnityEngine.Random.Range(1, templates.leftRooms.Length);
        Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);

    }
    else if (openingDirection == 4)
    {
        // Need to spawn a room with a RIGHT door.
        rand = UnityEngine.Random.Range(1, templates.rightRooms.Length);
        Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
    }
    roomCount++;
}
else
{
    if (openingDirection == 1)
    {
        Instantiate(templates.bottomRooms[0], transform.position, templates.bottomRooms[0].transform.rotation);
    }
    else if (openingDirection == 2)
    {
        Instantiate(templates.topRooms[0], transform.position, templates.topRooms[0].transform.rotation);

    }
    else if (openingDirection == 3)
    {
        Instantiate(templates.leftRooms[0], transform.position, templates.leftRooms[0].transform.rotation);

    }
    else if (openingDirection == 4)
    {
        Instantiate(templates.rightRooms[0], transform.position, templates.rightRooms[0].transform.rotation);

    }
}

spawned = true;
*/
