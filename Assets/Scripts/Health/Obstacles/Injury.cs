using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Injury : MonoBehaviour
{

    GameObject playerHealth;
    public Health hScript;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.Find("HealthFill");
        hScript = playerHealth.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
