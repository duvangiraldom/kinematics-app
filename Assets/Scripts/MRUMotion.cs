using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 *Clase para el control del movimiento Rectilineo Uniforme 
 * @author Duvan Ignacio Giraldo Montoya
*/
public class MRUMotion : MonoBehaviour
{
    //public GameObject buttonStart;
    //public GameObject buttonStop;

    private float speed;

    void Start()
    {
        speed = 50.0f;
        //stopBall();
    }

    void Update()
    {
        // if (buttonStart)
        // {
            transform.Rotate(Vector3.right * speed * Time.deltaTime);
        // }
    }

    public void SetSpeed(string Speed)
    {
        if(Speed != null)
        {
            speed = Convert.ToSingle(Speed);
        }
    }  

    // void moveBall()
    // {
    //     buttonStop.SetActive(true);
    //     buttonStart.SetActive(false);
    // }

    // void stopBall()
    // {
    //     buttonStart.SetActive(true);
    //     buttonStop.SetActive(false);
    // }
}
