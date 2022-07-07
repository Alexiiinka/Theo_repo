using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public int speed = 1;
    private bool leftMove = true;
    public Rigidbody2D rb;

    public void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    protected void Move()
    {
        if (transform.position.x < -8 && leftMove)
        {
            speed = -speed;
            leftMove = false;
        }
        else if (transform.position.x > 8 && !leftMove)
        {
            speed = -speed;
            leftMove = true;
        }
        rb.velocity = Vector2.left * speed;
        
    }

    public void Update()
    {
        Move();
    }
}
