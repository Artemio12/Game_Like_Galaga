using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineMovement : ITypeMovement
{
    private Transform transform;

    private TimeCounter timeCounter = new TimeCounter();

    private float frequency;
    public float Speed
    {
        set
        {
            this.frequency = value;
        }
    }

    private float width;

    private bool isHorizontaled;

    public SineMovement(Transform transform, float width, bool isHorizontaled)
    {
        this.transform = transform;
        this.width = width;
        this.isHorizontaled = isHorizontaled;
    }

    public void Move(Vector3 direction)
    {
        
        
        float angle =  2 * Mathf.PI * timeCounter.Timer() / frequency;

        if (isHorizontaled)
        {
            direction.y += width * Mathf.Sin(angle);
        }
        else direction.x += width * Mathf.Sin(angle);

        //transform.rotation = Quaternion.Euler(direction.x, direction.y,0);
        transform.position += direction;
    }
}
