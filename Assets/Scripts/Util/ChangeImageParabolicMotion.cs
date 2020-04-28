using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Class for image change in the Motion Information of Parabolic Motion
 **/
public class ChangeImageParabolicMotion : MonoBehaviour
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
        if (col.gameObject.name == "Cannonball(Clone)")
        {
            UIImage.sprite = Resources.Load<Sprite>(route);
            UIImage.gameObject.SetActive(true);
        }
    }
}