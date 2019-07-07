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
}
