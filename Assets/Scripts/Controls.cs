using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{

    public Rigidbody2D rb;
    public float movespeed = 1.0f;
    public float jumpSpeed = 3.0f;
    public float prevYVelocity;
    public bool jumping = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.Space) && (jumping == false))
        {
            jumping = true;
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }

        


        //Prevent double jumps. This checks "on the ground"
        if ((rb.velocity.y == 0) && ((rb.velocity.y - prevYVelocity) == 0))
        {
            jumping = false;
        }

        prevYVelocity = rb.velocity.y;
    }
}
