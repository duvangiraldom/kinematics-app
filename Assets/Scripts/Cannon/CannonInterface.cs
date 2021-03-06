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
        {
            cannon.SetTargetWithAngle(targetCursor.transform.position, initialFireAngle);
        }
        else
        {
            cannon.SetTargetWithSpeed(targetCursor.transform.position, initialFireSpeed, useLowAngle);
        }

    }

    public void Shot()
    {
        cannon.Fire();
    }

    public void SetInitialFireAngle(string angle)
    {
        initialFireAngle = Convert.ToSingle(angle) % 90;
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

}
