using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *Clase para controlar el flash del dispositivo 
 * @author Duvan Ignacio Giraldo Montoya
*/
public class InitialVelocity : MonoBehaviour
{
    public GameObject useInitialVelocity;
    public GameObject useInitialAngle;
    public GameObject inputInitialVelocity;
    public GameObject inputInitialAngle;

    void Start()
    {
        useInitialVelocity.SetActive(true);
        inputInitialVelocity.SetActive(false);
        useInitialAngle.SetActive(false);
        inputInitialAngle.SetActive(true);

    }

    public void useInitialVelocityController()
    {
        useInitialVelocity.SetActive(false);
        inputInitialVelocity.SetActive(true);
        useInitialAngle.SetActive(true);
        inputInitialAngle.SetActive(false);
    }

    public void useInitialAngleController()
    {
        useInitialVelocity.SetActive(true);
        inputInitialVelocity.SetActive(false);
        useInitialAngle.SetActive(false);
        inputInitialAngle.SetActive(true);
    }

}
