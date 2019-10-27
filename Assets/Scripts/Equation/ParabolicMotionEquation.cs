using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Class to controle the shot information that user's show in the moment shooter
 * @autor Duvan Giraldo
 **/
public class ParabolicMotionEquation : MonoBehaviour
{
    [SerializeField]
    CannonController cannon;

    [SerializeField]
    Transform target;

    [SerializeField]
    Text initialVelocityText;

    [SerializeField]
    Text distanceText;

    [SerializeField]
    Text timeOfFlightText;

    [SerializeField]
    Text heightText;

    [SerializeField]
    Text angleText;

    void Update()
    {
        SetInitialVelocityText();
        SetDistanceText();
        SetTimeOfFligthText();
        SetHeightText();
        SetAngleText();
    }

    public void SetInitialVelocityText()
    {
        initialVelocityText.text = cannon.GetCurrentSpeed().ToString("F");
    }

    public void SetDistanceText()
    {
        distanceText.text = Mathf.Sqrt(((cannon.gameObject.transform.position.x - target.gameObject.transform.position.x) *
                                        (cannon.gameObject.transform.position.x - target.position.x))
                                    + ((cannon.gameObject.transform.position.z - target.position.z) *
                                    (cannon.gameObject.transform.position.z - target.position.z))).
                                    ToString("F");
    }

    public void SetTimeOfFligthText()
    {
        timeOfFlightText.text = cannon.GetCurrentTimeOfFlight().ToString("F");
    }

    public void SetHeightText()
    {
        heightText.text = (4.895f * cannon.GetCurrentTimeOfFlight() * cannon.GetCurrentTimeOfFlight() ).ToString("F");
    }

    public void SetAngleText()
    {
        if (cannon.GetUseAngle())
        {
            angleText.text = cannon.GetCurrentAngle().ToString("F");
        }
        else
        {
            angleText.text = (cannon.GetCurrentAngle() * 57.295779f).ToString("F");
        }
    }
}
