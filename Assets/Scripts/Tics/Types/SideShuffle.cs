using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideShuffle : Tic
{
    float moveSpeed = 2.0f;

    public void Execute(GameObject player, Controls cScript)
    {
        Debug.Log("Executing side shuffle tic");
        Rigidbody2D rb = cScript.rb;

        //Randomly move left or right
        int randomIndex = UnityEngine.Random.Range(0, 2);
        
        if (randomIndex == 0)
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        } else
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }

    }
}
