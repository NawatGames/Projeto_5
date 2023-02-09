using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    float health = 0f;
    [SerializeField] float maxHealth = 200f;

    private void Start()
    {
        health = maxHealth;
    }

    public void UpdateHealth(float mod)
    {
        health += mod;

        if (health > maxHealth)
        {
            health = maxHealth;
        }else if (health <= 0)
        {
            health = 0f;
            
            SceneManager.LoadScene(10);
        }
    }
}
