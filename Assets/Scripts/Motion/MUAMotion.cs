using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 *Clase para el control del movimiento Rectilineo Uniforme 
 * @author Duvan Ignacio Giraldo Montoya
*/
public class MUAMotion : MonoBehaviour
{
    public GameObject target;
    private float speed;

    void Start()
    {
        speed = 10f;
    }

    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
    }
    public void SetSpeed(string Speed)
    {
        if(Speed != null)
        {
            speed = Convert.ToSingle(Speed);
        }
    }  

}
