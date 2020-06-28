using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{
    public GameObject initGame;

    public void ButtonClose()
    {
        initGame.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
