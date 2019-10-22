using UnityEngine;

/**
 * Clase para el control del cursor
 * Tomado de https://github.com/IronWarrior/ProjectileShooting
 * @author https://roystan.net/
*/
public class Cursor : MonoBehaviour 
{
    void Update()
    {
        //Debug.Log(Input.mousePosition.y + "/n");
        if (Input.mousePosition.y < 530)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, float.MaxValue, 1 << LayerMask.NameToLayer("Ground")))
            {
                transform.position = hit.point;
            }
        }
	}
}
