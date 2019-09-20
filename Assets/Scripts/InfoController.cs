using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoController : MonoBehaviour
{
    private GameObject textInfoDownload;
    private GameObject textInfoAbout;
    void Start()
    {
        textInfoAbout = GameObject.Find("TextInfoAbout");
        textInfoAbout.SetActive(true);
        textInfoDownload = GameObject.Find("TextInfoDownloadIcon");
        textInfoDownload.SetActive(false);
    }

    public void ShowTextInfoDownloadIcon()
    {
        textInfoAbout.SetActive(false);
        textInfoDownload.SetActive(true);
    }

    public void ShowTextInfoAbout()
    {
        textInfoAbout.SetActive(true);
        textInfoDownload.SetActive(false);
    }

    public void OpenUrlDownloadIconKinematicsApp()
    {
        Application.OpenURL("https://i.ibb.co/Pz416gP/icon-Kinematcs-App.png");
    }
}
