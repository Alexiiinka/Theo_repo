using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public int speed = 1;
    private bool leftMove = true;
    private Rigidbody2D rb;

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
            transform.Rotate(0,180,0);
        }
        else if (transform.position.x > 8 && !leftMove)
        {
            speed = -speed;
            leftMove = true;
            transform.Rotate(0,180,0);
        }
        rb.velocity = Vector2.left * speed;
        
    }

    public void Update()
    {
        Move();
    }
}
