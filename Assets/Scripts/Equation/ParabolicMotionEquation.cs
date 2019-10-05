using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParabolicMotionEquation : MonoBehaviour
{

    [SerializeField]
    Text initialVelocityText;

    [SerializeField]
    Text finalVelocityText;

    [SerializeField]
    Text aceelerationText;

    [SerializeField]
    Text distanceText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetInitialVelocityText()
    {
        //initialVelocityText.text = cannon.getSpeedCurrent().ToString();
    }

    public void SetFinalVelocityText()
    {
      //  finalVelocityText.text = cannon.getSpeedCurrent().ToString();
    }

    public void SetAccelerationText()
    {

    }

    public void SetDistanceText()
    {
     //  distanceText.text = Mathf.Abs(cannon.transform.position.x - targetCursor.transform.position.x).ToString();
    }
}
