using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 *Clase para el control del movimiento Rectilineo Uniforme 
 * @author Duvan Giraldo
*/
public class MRUMotion : MonoBehaviour
{

    [SerializeField]
    Transform target;

    [SerializeField]
    Text timeText;

    [SerializeField]
    Text distanceText;

    private float speed;

    void Start()
    {
        speed = 10f;
    }

    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);

        GetDistance();
        GetTime();
    }

    public void SetSpeed(string Speed)
    {
        if(Speed != null)
        {
            speed = Convert.ToSingle(Speed);
        }
    }

    public void GetTime()
    {
       timeText.text = (Convert.ToSingle(distanceText.text) / speed).ToString("F");
        
    }

    public void GetDistance()
    {
        distanceText.text = Mathf.Sqrt(((transform.position.x - target.transform.position.x) * (transform.position.x - target.transform.position.x))
                                           + ((transform.position.z - target.transform.position.z) * (transform.position.z - target.transform.position.z))).
                                           ToString("F");
    }
}

