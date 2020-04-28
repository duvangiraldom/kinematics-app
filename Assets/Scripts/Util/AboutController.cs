using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class AboutController : MonoBehaviour
{
    public GameObject textInfo;
    public GameObject textControls;


    void Start()
    {
        setTextInfoToAbout();
    }

    public void setTextInfoToAbout()
    {
        textInfo.SetActive(true);
        textControls.SetActive(false);
    }

    public void setTextInfoToMoreInfo()
    {
        textInfo.SetActive(false);
        textControls.SetActive(true);
    }

    public void OpenUrlDownloadIconKinematicsApp()
    {
        Application.OpenURL("https://i.ibb.co/Pz416gP/icon-Kinematcs-App.png");
    }
}