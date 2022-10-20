using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private float time;
    [SerializeField] private float repeatRate;
    

    [SerializeField] GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies",time,repeatRate);
    }

    void SpawnEnemies()
    {
        int index = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[index].position, Quaternion.identity);
    }
}
