using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParabolicMotionEquation : MonoBehaviour
{
    [SerializeField]
    Transform cannon;

    [SerializeField]
    Transform target;

    [SerializeField]
    Text HeightText;

    [SerializeField]
    Text initialVelocityText;

    [SerializeField]
    Text finalVelocityText;

    [SerializeField]
    Text aceelerationText;

    [SerializeField]
    Text distanceText;

    void Start()
    {
        
    }

    void Update()
    {
        SetDistanceText();
        SetInitialVelocityText();
        SetFinalVelocityText();
        SetHeightText();

    }

    public void SetInitialVelocityText()
    {
        //initialVelocityText.text = cannon.GetCurrentSpeed().ToString("F");
    }

    public void SetFinalVelocityText()
    {
       //finalVelocityText.text = cannon.GetCurrentSpeed().ToString("F");
    }

    public void SetAccelerationText()
    {

    }

    public void SetDistanceText()
    {
        //distanceText.text = Mathf.Sqrt(((cannon.position.x - target.position.x) * (cannon.position.x - target.position.x))
         //                            + ((cannon.position.z - target.position.z) * (cannon.position.z - target.position.z))).
         //                            ToString("F");
    }

    public void SetHeightText()
    {
        //HeightText.text = target.position.y.ToString("F");
    }
}
