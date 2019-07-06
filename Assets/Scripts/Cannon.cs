using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    [SerializeField]
    private Rigidbody cannonballInstance;

    [SerializeField]
    [Range(10f, 80f)]
    private float angle = 45f;



    private void Update()
    {
        //Touch touch = Input.GetTouch(0); touch.position;

        if (Input.GetMouseButtonDown(0))
        {
           FireCannonAtPoint(target.transform.position);
        }
    }

    private void FireCannonAtPoint(Vector3 point)
    {
        Vector3 velocity = BallisticVelocity(point, angle);
        Debug.Log("Disparando a" + point + " con Velocidad " + velocity);
        cannonballInstance.transform.position = transform.position;
        cannonballInstance.velocity = velocity;
    }

    private Vector3 BallisticVelocity(Vector3 destination, float angle)
    {
        Vector3 dir = destination - transform.position; // Obtener la Direccion del Target
        float height = dir.y; // Obtener la altura (Diferencia de altura)
        dir.y = 0; // retain only the horizontal difference
        float dist = dir.magnitude; // get Direccion horizontal
        float a = angle * Mathf.Deg2Rad; // Convierte el angulo en radianes
        dir.y = dist * Mathf.Tan(a); // establecer dir en el ángulo de elevación.
        dist += height / Mathf.Tan(a); // Corrección por pequeñas diferencias de altura.

        // Calculate the velocity magnitude
        float velocity = Mathf.Sqrt(dist * Physics.gravity.magnitude / Mathf.Sin(2 * a));
        return velocity * dir.normalized; // Return a normalized vector.
    }

}