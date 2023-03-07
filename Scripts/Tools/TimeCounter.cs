using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCounter 
{
    private float timeCounter;
    public float Counter
    {
        get { return timeCounter; }
        set { timeCounter = value; }
    }
    public float Timer()
    {
        this.timeCounter += Time.deltaTime;
        return this.timeCounter;
    }
}
