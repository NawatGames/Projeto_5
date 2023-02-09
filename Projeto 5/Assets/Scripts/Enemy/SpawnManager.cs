using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    [SerializeField] private float time;
    [SerializeField] private float repeatRate;
    private bool run = false;
    private int rand;
    
    

    [SerializeField] GameObject[] enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies",time,repeatRate);
    }

    void SpawnEnemies()
    {
        if (!run)
        {
            rand = UnityEngine.Random.Range(1, 100);
            if (rand < 40)
            {
                int index_enemy = Random.Range(0, enemy.Length);
                Instantiate(enemy[index_enemy], transform.position, Quaternion.identity);
            }
            
            run = true;
        }
        
        
    }
}
