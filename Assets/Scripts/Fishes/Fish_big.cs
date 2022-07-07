using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_big : Fish
{
    private Vector2 rightMove = new Vector2(1,1), upMove = new Vector2(1,1); 
    private Vector2 diagonalVector = new Vector2(0.5f, 0.5f); //diagonal move
    private bool leftMoving = false, upMoving = true;

    protected override void Move()
    {
         if (transform.position.y < -4 && !upMoving) // goes down, we want up
        {
            if(leftMoving)
            {
                transform.Rotate(0, 0, -90);
            }
            else{
                transform.Rotate(0, 0, 90);
            }
            
            upMoving = true;
            upMove = new Vector2(1, 1);
        }
        else if (transform.position.y > -1 && upMoving) // goes up, we want down
        {
            if(leftMoving)
            {
                transform.Rotate(0, 0, 90);
            }
            else{
                transform.Rotate(0, 0, -90);
            }
            upMoving = false;
            upMove = new Vector2(1, -1);
            
        }
        if (transform.position.x < -8 && leftMoving) //goes left, we want right
        {
            rightMove = new Vector2(1,1);
            leftMoving = false;
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y *-1, transform.localScale.z);
            if(upMoving){transform.Rotate(0, 0, -180);}
        }
        else if (transform.position.x > 8 && !leftMoving) // goes right, we want left
        {
            rightMove = new Vector2(-1,1);
            leftMoving = true;
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y *-1, transform.localScale.z);
        }

       
        // movement
        rb.velocity = diagonalVector * speed * upMove * rightMove;
    }
}
