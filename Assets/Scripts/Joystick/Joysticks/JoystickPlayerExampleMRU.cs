using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExampleMRU : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        //rb.velocity = direction * speed;
    }

    public void SetSpeed(string Speed)
    {
        if (Speed != null && !0.Equals(Speed.Length))
        {
            speed = Convert.ToSingle(Speed);
        }
    }
}