using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 move;
    public float horizontalInput, verticalInput;
    [SerializeField]
    private int speed = 3;
    // Start is called before the first frame update
    void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        move = new Vector2(horizontalInput, verticalInput) * speed;
        rb.velocity = move;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fishes"))
        {
            Destroy(other.gameObject);
            GameMaster.Instance.GameOver();
        }
        else if(other.CompareTag("Garbage"))
        {
            Destroy(other.gameObject);
            GameMaster.Instance.score += 1;
        }
        
    }
}
