using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject enemy;
    public float auxvely;
    public float auxvelx;
    public float xVelocity;
    public float yVelocity;

    void Start()
    {
        Vector2 vel = rb.velocity;
        vel.x = xVelocity;
        vel.y = yVelocity;
        auxvely = yVelocity*(-1);
        auxvelx = xVelocity*(-1);
    }

    void Update()
    {
        if(rb.velocity.x > rb.velocity.y)
        {
            enemy.GetComponent<Animator>().Play("EnemyD_Walk_Right");
        }

        if(rb.velocity.x < rb.velocity.y)
        {
            enemy.GetComponent<Animator>().Play("EnemyD_Walk_Up");
        }

        if(auxvelx > auxvely)
        {
            enemy.GetComponent<Animator>().Play("EnemyD_Walk_Left");
        }

        if(auxvelx < auxvely)
        {
            enemy.GetComponent<Animator>().Play("EnemyD_Walk_Down");
        }
    }
}
