using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fist_medium : Fish
{
    public float repeatOfSize = 1.5f;
    public float maxChangableSize = 0.2f;
    private bool smaller = true;
    public override void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        InvokeRepeating("ChangeSize", 2.0f, repeatOfSize);
    }

    private void ChangeSize()
    {
        if (smaller)
        {
            transform.localScale += new Vector3(maxChangableSize, maxChangableSize, 1);
            smaller = false;
        }
        else
        {
            transform.localScale -= new Vector3(maxChangableSize, maxChangableSize, 1);
            smaller = true;
        }
    }

}
