using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float moveSpeed = 0f;
    public Rigidbody2D rb;
    public float dashSpeed = 10f;
    public float dashDuration = 0.3f;
    public float dashCoolDown = 1f;
    public EnemyBulletScript bulletScript;

    private Vector2 movement;
    private Vector2 mousePos;
    public Camera cam;
    private float dashTime;
    private float coolDownTime;



    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= coolDownTime)
        {
            StartCoroutine(Dash());
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        //Vector2 lookDir = mousePos - rb.position;
        //float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        //rb.rotation = angle;
    }

    IEnumerator Dash()
    {
        EnemyBulletScript.isDashing = true;
        moveSpeed = dashSpeed;
        dashTime = Time.time + dashDuration;
        while (Time.time < dashTime)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
            yield return null;
        }
        moveSpeed = 5f;
        coolDownTime = Time.time + dashCoolDown;
        EnemyBulletScript.isDashing = false;
    }
}