using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Class for image change in the Motion Information of URM and UAM
 **/
public class ChangeImage : MonoBehaviour
{
    public Image UIImage;
    public string route;

    void Start()
    {
        UIImage = GameObject.Find("ChangedImage").GetComponent<Image>();
        UIImage.gameObject.SetActive(false);
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            UIImage.sprite = Resources.Load<Sprite>(route);
            UIImage.gameObject.SetActive(true);
        }
    }

}