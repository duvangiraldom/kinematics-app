using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

/**
 * Clase para controlar la interfaz GUI del usuario en la pantalla de tiro parabolico 
 * Tomado de https://github.com/IronWarrior/ProjectileShooting
 * @author https://roystan.net/
*/
public class CannonInterface : MonoBehaviour 
{
    [SerializeField]
    Cursor targetCursor;

    [SerializeField]
    CannonController cannon;

    [SerializeField]
    Text timeOfFlightText;

    [SerializeField]
    Text initialVelocityText;

    [SerializeField]
    Text finalVelocityText;

    [SerializeField]
    Text aceelerationText;

    [SerializeField]
    Text distanceText;

    [SerializeField]
    float defaultFireSpeed = 35;

    [SerializeField]
    float defaultFireAngle = 45;

    private float initialFireAngle;
    private float initialFireSpeed;
    private bool useLowAngle;

    private bool useInitialAngle;

    void Awake()
    {
        useLowAngle = true;

        initialFireAngle = defaultFireAngle;
        initialFireSpeed = defaultFireSpeed;

        useInitialAngle = true;
    }

    void Update()
    {
        if (useInitialAngle)
            cannon.SetTargetWithAngle(targetCursor.transform.position, initialFireAngle);
        else
            cannon.SetTargetWithSpeed(targetCursor.transform.position, initialFireSpeed, useLowAngle);

        //if (Input.GetButtonDown("Fire1") && !EventSystem.current.IsPointerOverGameObject())
        //{
            //cannon.Fire();
        //}

    }

    public void Shot()
    {
        cannon.Fire();
        SetInitialVelocityText();
        SetFinalVelocityText();
        SetAccelerationText();
        SetTimeOfFligthText();
        SetDistanceText();

    }

    public void SetInitialFireAngle(string angle)
    {
        initialFireAngle = Convert.ToSingle(angle);
    }

    public void SetInitialFireSpeed(string speed)
    {
        initialFireSpeed = Convert.ToSingle(speed);
    }

    public void SetLowAngle(bool useLowAngle)
    {
        this.useLowAngle = useLowAngle;
    }

    public void UseInitialAngle(bool value)
    {
        useInitialAngle = value;
    }


    public void SetTimeOfFligthText()
    {
        timeOfFlightText.text = Mathf.Clamp(cannon.lastShotTimeOfFlight - (Time.time - cannon.lastShotTime), 0, float.MaxValue).ToString("F");
    }

    public void SetInitialVelocityText()
    {
        initialVelocityText.text = cannon.getSpeedCurrent().ToString();
    }

    public void SetFinalVelocityText()
    {
        initialVelocityText.text = initialFireSpeed.ToString();
    }

    public void SetAccelerationText()
    {

    }

    public void SetDistanceText()
    {

    }
}
