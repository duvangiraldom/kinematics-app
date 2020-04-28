using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumenController : MonoBehaviour
{
    public GameObject buttonOn;
    public GameObject buttonOff;

    void Start()
    {
        if (!StateSound.SoundOff){
            volumenOff();
        } else
        {
            volumenOn();
        }
    }

    public void volumenOn()
    {
        StateSound.SoundOff = true;
        SoundConstant.Instance.sound.Pause();
        buttonOn.SetActive(false);
        buttonOff.SetActive(true);
    }

    public void volumenOff()
    {
        StateSound.SoundOff = false;
        SoundConstant.Instance.sound.UnPause();
        buttonOn.SetActive(true);
        buttonOff.SetActive(false);
    }
}
