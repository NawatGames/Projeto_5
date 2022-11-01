using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
     
  {
        Personagem = GetComponent<Rigidbody2D>();
    }
        Rigidbody2D Personagem;
    }
    public float speed;
    public float dashSpeed;


void Update(Rigidbody2D);
{
   Rigidbody2D velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.DownArrow))
        {
       Rigidbody2D velocity = new Vector2(body.velocity.x, body.velocity.y - speed * Time.deltaTime);
        }
    if (Input.GetKey(KeyCode.UpArrow))
    {
        Rigidbody2D velocity = new Vector2   Rigidbody2D velocity.x,.  Rigidbody2D velocity.y + speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
        Rigidbody2D velocity = new Vector2(body.velocity.x - speed * Time.deltaTime, body.velocity.y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
        Rigidbody2D velocity = new Vector2(body.velocity.x + speed * Time.deltaTime, body.velocity.y);
        }

    }
}

{
    enum DashDirection
{
    Left,
    Right,
    Up,
    Down,
    NoDirection
}
dash = DashDirection.NoDirection;
Rigidbody2D body;
public float speed;
public float dashSpeed;
private DashDirection dashDirection;
public float dashDuration;
public float dashTimer;


void Start()
{
    
}

void Update()
{
    body.velocity = Vector2.zero;
    if (Input.GetKey(KeyCode.DownArrow))
    {
        dashDirection = DashDirection.Down;
    }
    if (Input.GetKey(KeyCode.UpArrow))
    {
        dashDirection = DashDirection.Up;
    }
    if (Input.GetKey(KeyCode.LeftArrow))
    {
        dashDirection = DashDirection.Left;
    }
    if (Input.GetKey(KeyCode.RightArrow))
    {
        dashDirection = DashDirection.Right;
    }
    if (dashDirection != DashDirection.NoDirection)
    {
        if (dashTimer >= dashDuration)
        {
            dashDirection = DashDirection.NoDirection;
            dashTimer = 0;
            body.velocity = Vector2.zero;
        }
        else
        {
            dashTimer += Time.deltaTime;
            if (dashDirection == DashDirection.Left)
            {
                body.velocity = Vector2.left * dashSpeed;
            }

            if (dashDirection == DashDirection.Right)
            {
                body.velocity = Vector2.right * dashSpeed;
            }

            if (dashDirection == DashDirection.Up)
            {
                body.velocity = Vector2.up * dashSpeed;
            }
            if (dashDirection == DashDirection.Down)
            {
                body.velocity = Vector2.down * dashSpeed;
            }



        }

    }

}
}
// Update is called once per frame
void Update()
    {
        
    }
}
