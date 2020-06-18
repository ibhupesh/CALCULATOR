using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TestScript : MonoBehaviour
{
    public string name;
    public Text messg;

    /* public Text time;    //for stopwatch
    public float Countdown;
    void Start()
    {
        messg.text = name; //for passing name to text
        time.text = Countdown.ToString("#.00"); // for countdown time
    }
    
      void Update()
    {
        DateTime currentTime = DateTime.Now;
        if (Countdown >= 0)
        {
            Debug.Log("Welcome Mr. " + name);  //for printing name after each frame
            Countdown -= Time.deltaTime;
            time.text = Countdown.ToString("#.00");
        }
        else
            time.text = "0.0";
    }*/

    //for digital clock
    public Text clock;
    public string hour;
    public string minute;
    public string second;
    public bool toggle;
    public Camera cam;
    public Slider fovSlider;
    public InputField username;
    void Start()
    {
        toggle = false;
        cam.fieldOfView = fovSlider.value;
    }

    void Update()
    {

        if (toggle)
            CreateClock();
    }

    public void CreateClock()
    {
        DateTime currentTime = DateTime.Now;
        hour = currentTime.Hour.ToString();
        minute = currentTime.Minute.ToString();
        second = currentTime.Second.ToString();
        messg.text = "Hey! ," + username.text;
        clock.text = hour + " : " + minute + " : " + second;
    }

    public void OnToggle()
    {
        if (toggle)
            toggle = false;
        else
            toggle = true;
    }
    public void FOVslider()
    {
        cam.fieldOfView = fovSlider.value;
    }

    public void InputField()
    {
        messg.text = username.text;
    }
   

   
}
