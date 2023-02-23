using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : Tic
{

    public void Execute(GameObject player, Controls cScript)
    {
        Debug.Log("Executing jump tic");
        cScript.Jump();
    }
}
