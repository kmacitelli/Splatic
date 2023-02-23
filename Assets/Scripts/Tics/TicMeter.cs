using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Reflection;

public class TicMeter : MonoBehaviour
{
    //TODO other tic types probably need audio, animations
    //TODO: stomp (noise), noise, press button, 
    public string[] ticList = { "Jump", "SideShuffle" };

    public int currentTimerFill = 0;
    public Sprite[] timerCircles;
    public float fillSpeed = 2.0f;
    GameObject meter;
    GameObject player;
    Controls cScript;

    // Start is called before the first frame update
    void Start()
    {
        meter = GameObject.Find("Meter");
        player = GameObject.Find("Player");
        cScript = player.GetComponent<Controls>();

        meter.GetComponent<Image>().sprite = timerCircles[currentTimerFill];

        InvokeRepeating("RefillMeter", 0.0f, fillSpeed);
    }

    void RefillMeter()
    {
        //TODO supress button logic here will allow skipping this method for some time

        meter.GetComponent<Image>().sprite = timerCircles[currentTimerFill];
      
        //Fill tic meter or, if its full, make a tic & reset it
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
        //Create tic object out of random item from ticList
        int randomIndex = UnityEngine.Random.Range(0, ticList.Length);
        string randomTicFromList = ticList[randomIndex];

        var type = Type.GetType(randomTicFromList);
        var currentTic = (Tic)Activator.CreateInstance(type);

        currentTic.Execute(player, cScript);
    }
}
