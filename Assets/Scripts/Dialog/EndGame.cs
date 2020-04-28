using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    private static int TOTAL_COINTS_LEVEL_3 = 26;
    private int cointsDestroid;
    private bool showFinishBox;
    public GameObject boxFinishText;

    void Start()
    {
        boxFinishText.SetActive(false);
        cointsDestroid = 0;
        showFinishBox = false;
    }

    void Update()
    {
        if (TOTAL_COINTS_LEVEL_3.Equals(cointsDestroid))
        {
            showFinishBox = true;
            boxFinishText.SetActive(true);
        }
    }

    public void AddCointsDestroid()
    {
        cointsDestroid++;
    }

}
