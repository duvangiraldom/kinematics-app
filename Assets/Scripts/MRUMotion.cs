using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MRUMotion : MonoBehaviour
{
    private bool useVelocity, useDistance, useTime;
    private float velocity;
    private float distance;
    private float time;

    void Start()
    {
        velocity = 0f;
        distance = 0f;
        time = 0f;
    }

    void Update(){
        FindValues();
    }

    private void FindValues()
    {
        if (useVelocity && useDistance)
        {
            time = distance / velocity;
        }
        else if (useVelocity && useTime)
        {
            distance = velocity * time;
        }
        else if (useDistance && useTime)
        {
            velocity = distance / time;
        }
        else
        {
            Debug.Log("Missing values for find result");
        }
    }

    public void SetVelocity(string VelocityInput)
    {
        velocity = Convert.ToSingle(VelocityInput);
    }

    public void SetDistance(string DistanceInput)
    {
        distance = Convert.ToSingle(DistanceInput);
    }

    public void SetTime(string TimeInput)
    {
        time = Convert.ToSingle(TimeInput);
    }

    public void OnClickUseVelocity()
    {
        useVelocity = true;
    }

    public void OnClickUseDistance()
    {
        useDistance = true;
    }

    public void OnClickUseTime()
    {
        useTime = true;
    }

}
