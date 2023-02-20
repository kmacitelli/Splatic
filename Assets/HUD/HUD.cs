using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public int currentTimerFill;
    public Sprite[] timerCircles;
    GameObject meter;


    // Start is called before the first frame update
    void Start()
    {
        meter = GameObject.Find("Meter");


        currentTimerFill = 0;

        InvokeRepeating("RefillMeter", 2.0f, 2.0f);

        //hide other circles
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
