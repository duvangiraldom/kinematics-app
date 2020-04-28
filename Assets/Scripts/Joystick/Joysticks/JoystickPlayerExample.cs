using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoystickPlayerExample : MonoBehaviour
{
    private int totalStars = 13;
    private int Score;

    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;
    public Text speedText;
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
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);

        speedText.text = rb.velocity.magnitude.ToString("F");

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
        if (col.gameObject.name == "Star")
        {
            Destroy(col.gameObject);
        }

        if (col.gameObject.name == "Coin")
        {
            Destroy(col.gameObject);
            Score++;
            ChangeValueScore();
        }

        if (col.gameObject.name == "Door")
        {
            Destroy(col.gameObject);
            menuController.changeScene("ParabolicMotionScene");
        }
    }

    private void ChangeValueScore()
    {
        ScoreValue.text = Score.ToString();
    }
}