using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 *Clase para el control del movimiento Rectilineo Uniforme 
 * @author Duvan Giraldo
*/
public class MUAMotion : MonoBehaviour
{
    public float turnSpeed = 50f;

    [SerializeField]
    GameObject buttonContinue;

    [SerializeField]
    GameObject buttonStop;

    private bool moveToUp, moveToDown = false;
    private float moveSpeed;
    private float height;

    private Rigidbody rb;

    public void Awake()
    {
        height = transform.position.y;
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
        moveSpeed = 10f;
        ActiveButtonContinue();
    }

    void Update()
    {
        if (moveToUp && buttonStop.activeSelf)
        {
            Vector3 movement = new Vector3(0, 0, 10);
            rb.AddForce(movement * moveSpeed);
        }
        if (moveToDown && buttonStop.activeSelf)
        {
            Vector3 movement = new Vector3(0, 0, -10);
            rb.AddForce(movement * moveSpeed);
        }
    }

    public void MoveToUp()
    {
        moveToDown = false;
        moveToUp = true;
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    public void MoveToDown()
    {
        moveToUp = false;
        moveToDown = true;
        //transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
    }

    public void RotateToRigth()
    {
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }

    public void RotateToLeft()
    {
        transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
    }

    public void ActiveButtonContinue()
    {
        buttonContinue.SetActive(true);
        buttonStop.SetActive(false);
    }

    public void ActiveButtonStop()
    {
        buttonStop.SetActive(true);
        buttonContinue.SetActive(false);
    }

    public void SetSpeed(string Speed)
    {
        if (Speed != null || 0.Equals(Speed.Length))
        {
            float speedField = Convert.ToSingle(Speed);
            if (!(speedField > 100 || speedField < 0))
            {
                moveSpeed = speedField;
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cube")
        {
            //Destroy(col.gameObject);
            ActiveButtonContinue();
        }
    }

}

