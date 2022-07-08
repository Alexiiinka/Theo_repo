using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private int speed = 5;
    void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down.normalized * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Fishes"))
        {
            Destroy(other.gameObject);
            GameMaster.Instance.GameOver();
        }
    }



}
