using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 *Clase para el control de las scenes 
 * @author Duvan Ignacio Giraldo Montoya
*/
public class MenuController : MonoBehaviour
{
    public void changeScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

    /**
    public void OnGUI(string message)
    {
        Rect rect = new Rect();
        rect.Set(0, 0, Screen.width / 2, Screen.height / 2);
        GUI.Box(rect, message);
    }
    **/
}
