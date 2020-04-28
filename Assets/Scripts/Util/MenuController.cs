using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/**
 *Clase para el control de las scenes 
 * @author Duvan Ignacio Giraldo Montoya
*/
public class MenuController : MonoBehaviour
{
    public GameObject infoShotComponent;
    public GameObject buttonInit;
    public GameObject loadingScreen;
    public Slider slider;
    public Text textProgress;

    void Start()
    {
        StartCoroutine(ActivationInfoLevelInit());
    }

    public void changeScene(string nameScene)
    {
        StartCoroutine(LoadAsynchronously(nameScene));
    }

    IEnumerator LoadAsynchronously(string nameScene)
    {
        AsyncOperation operation =  SceneManager.LoadSceneAsync(nameScene);
        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            textProgress.text = System.Math.Round(progress, 2) * 100f + "%";
            yield return null;
        }
    }

    public void ShowShotInfo(bool showInfoShot){
        if (showInfoShot){
            infoShotComponent.SetActive(true);
        }
        else{
            infoShotComponent.SetActive(false);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private IEnumerator ActivationInfoLevelInit()
    {
        buttonInit.SetActive(true);
        yield return new WaitForSeconds(3);
        buttonInit.SetActive(false);
    }
}
