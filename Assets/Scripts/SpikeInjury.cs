using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeInjury : MonoBehaviour
{

    GameObject playerHealth;
    Health hScript;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.Find("HealthFill");
        hScript = playerHealth.GetComponent<Health>();
        Debug.Log("Got spike health");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("DAMAGE");
        hScript.Damage();
    }
}
