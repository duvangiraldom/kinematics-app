using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonShootEnable : MonoBehaviour
{
    public GameObject iconKinematics;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (iconKinematics.gameObject.activeSelf)
        {
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }

}
