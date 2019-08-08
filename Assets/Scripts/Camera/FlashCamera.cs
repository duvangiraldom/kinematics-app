using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *Clase para controlar el flash del dispositivo 
 * @author Duvan Ignacio Giraldo Montoya
*/
public class FlashCamera : MonoBehaviour
{
    private GameObject CanvasFlash;
    private GameObject btnON;
    private GameObject btnOFF;

    void Start()
    {
        Vuforia.CameraDevice.Instance.SetFlashTorchMode(false);
        CanvasFlash = GameObject.Find("flashLight");
        CanvasFlash.SetActive(true);
        btnON = GameObject.Find("btnOn");
        btnON.SetActive(false);
        btnOFF = GameObject.Find("btnOff");
        btnON.SetActive(true);
    }

    public void FlashOn()
    {
        Vuforia.CameraDevice.Instance.SetFlashTorchMode(true);
        btnOFF.SetActive(true);
        btnON.SetActive(false);
    }

    public void FlashOff()
    {
        Vuforia.CameraDevice.Instance.SetFlashTorchMode(false);
        btnOFF.SetActive(false);
        btnON.SetActive(true);
    }

}
