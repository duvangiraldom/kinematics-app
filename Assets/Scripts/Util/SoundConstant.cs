using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundConstant : MonoBehaviour {

    private static SoundConstant instance = null;

    public AudioSource sound;

    public static SoundConstant Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
