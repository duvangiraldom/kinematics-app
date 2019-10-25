using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MRUEquation : MonoBehaviour
{
    [SerializeField]
    Transform origin;

    [SerializeField]
    Transform target;

    [SerializeField]
    Text initialVelocityText;

    [SerializeField]
    Text finalVelocityText;

    [SerializeField]
    Text distanceText;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetDistanceText();
    }

    public void SetDistanceText()
    {
        distanceText.text = Mathf.Sqrt(((origin.position.x - target.position.x) * (origin.position.x - target.position.x))
                                    + ((origin.position.z - target.position.z) * (origin.position.z - target.position.z))).
                                    ToString("F");
    }
}
