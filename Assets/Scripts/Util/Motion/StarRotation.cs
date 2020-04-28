using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRotation : MonoBehaviour
{
    private Vector3 rotation;

    void Start()
    {
        rotation = new Vector3(0, 0, -1);
    }

    void Update()
    {
        transform.Rotate(rotation);
    }
}
