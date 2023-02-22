using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Reflection;

public class TicMeter : MonoBehaviour
{
    public string[] ticList = { "Jump", "SideShuffle" };

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
        //supress button logic will allow skipping this method for some time

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
            MakeATic();
        }
    }

    // Update is called once per frame
    void MakeATic()
    {
        Tic currentTic = new Jump();
        int randomIndex = UnityEngine.Random.Range(0, ticList.Length);

        Debug.Log("Index is " + randomIndex);
        string randomFromList = ticList[randomIndex];

        if (randomFromList.Equals(ticList[0]))
        {
            currentTic = new Jump();
        } else if (randomFromList.Equals(ticList[1])){
            currentTic = new SideShuffle();
        }
        
        Debug.Log("Current tic is " + currentTic);

        currentTic.Execute();
    }
}
