using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *Clase para controlar el flash del dispositivo 
 * @author Duvan Ignacio Giraldo Montoya
*/
public class FlashCamera : MonoBehaviour
{
    public GameObject btnON;
    public GameObject btnOFF;

    void Start()
    {
        Vuforia.CameraDevice.Instance.SetFlashTorchMode(false);
        FlashOff();
    }

    public void FlashOn()
    {
        Vuforia.CameraDevice.Instance.SetFlashTorchMode(true);
        btnOFF.SetActive(true);
        btnON.SetActive(false);
        Debug.Log("Flash on");

    }

    public void FlashOff()
    {
        Vuforia.CameraDevice.Instance.SetFlashTorchMode(false);
        btnOFF.SetActive(false);
        btnON.SetActive(true);
        Debug.Log("Flash off");
    }

}
