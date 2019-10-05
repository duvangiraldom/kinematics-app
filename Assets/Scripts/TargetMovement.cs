using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public float movementSpeed;

    void Update(){
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved){
            Vector3 touchPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(touchPosition.x * movementSpeed * Time.deltaTime, 0, 0);
            //transform.Translate(0, touchPosition.y * movementSpeed * Time.deltaTime, 0);
            transform.Translate(0, 0, touchPosition.z * movementSpeed * Time.deltaTime);
        }
    }
}
