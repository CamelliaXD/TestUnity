using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{

    public BoxCollider2D collider;
    public Rigidbody2D rb;
    private float Width;
    private float Speed = -2f;
    
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        Width = collider.size.x;
        collider.enabled = false;

        rb.velocity = new Vector2(Speed, 0);
    }


    void Update()
    {
        if (transform.position.x < -Width )
        {
            Vector2 resetPosition = new Vector2(Width * 2f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
        }

       
    }
   
}
