using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TMeter : MonoBehaviour
{
    public int currentTimerFill = 0;
    public Sprite[] timerCircles;
    public float fillSpeed = 2.0f;
    GameObject meter;


    // Start is called before the first frame update
    void Start()
    {
        meter = GameObject.Find("Meter");
        meter.GetComponent<Image>().sprite = timerCircles[currentTimerFill];


        InvokeRepeating("RefillMeter", 0.0f, fillSpeed);
    }

    void RefillMeter()
    {
        meter.GetComponent<Image>().sprite = timerCircles[currentTimerFill];
        
        
        //this part's working!
        if (currentTimerFill < timerCircles.Length -1)
        {
            currentTimerFill++;
        }
        else
        {
            //call event here
            currentTimerFill = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
