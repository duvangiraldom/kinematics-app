using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MRUMotion : MonoBehaviour
{
    private int totalStars = 13;
    private int Score;

    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;
    public GameObject Door;
    public Text ScoreValue;
    public MenuController menuController;

    void Start()
    {
        Score = 0;
        Door.SetActive(false);
    }

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        rb.AddForce(direction * Time.fixedDeltaTime, ForceMode.VelocityChange);
        rb.velocity = direction * speed;

        if (Score == totalStars)
        {
            Door.SetActive(true);
        }
    }

    public void SetSpeed(string Speed)
    {
        if (Speed != null || 0.Equals(Speed.Length))
        {
            float speedField = Convert.ToSingle(Speed);
            if (!(speedField > 100 || speedField < 0))
            {
                speed = speedField;
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Coin")
        {
            Destroy(col.gameObject);
            Score++;
            ChangeValueScore();
        }

        if (col.gameObject.name == "Door")
        {
            Destroy(col.gameObject);
            menuController.changeScene("MUAScene");
        }
    }

    private void ChangeValueScore()
    {
        ScoreValue.text = Score.ToString();
    }
}