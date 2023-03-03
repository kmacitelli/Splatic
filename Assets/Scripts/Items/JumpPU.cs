using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPU : Item
{
    GameObject player;
    Controls cScript;

    void Start()
    {
        player = GameObject.Find("Player");
        cScript = player.GetComponent<Controls>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        cScript.jumpSpeed = 12.0f;
    }
   
}
