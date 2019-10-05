using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AboutController : MonoBehaviour
{
    public Text textInfo;

    // Start is called before the first frame update
    void Start()
    {
        setTextInfoToAbout();
    }

    public void setTextInfoToAbout()
    {
        textInfo.text = "Kinematic app is developed for people start in the world of physics, in the subjects of Uniform Rectilinear Movement, Uniform Accelerated Movement and Kinematics app's main theme the Parabolic Movement.";
    }

    public void setTextInfoToInfoDownload()
    {
        textInfo.text = "To download the Kinematics App logo you must enter here, download the image (Marker) and print it; so you can scan it with the app";
    }

    public void setTextInfoToMoreInfo()
    {
        textInfo.text = "Hablar de la navegabilidad";
    }
}
