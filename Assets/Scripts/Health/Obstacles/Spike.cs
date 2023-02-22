using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : Injury
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Spike damage");
        hScript.Damage(10);
    }
}
