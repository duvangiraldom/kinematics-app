using UnityEngine;

/**
 * Clase para controlar la bola del canion en el tiro parabolico
 * Tomado de https://github.com/IronWarrior/ProjectileShooting
 * @author https://roystan.net/
*/
public class CannonBall : MonoBehaviour 
{
    [SerializeField]
    GameObject deathEffect;

    void OnCollisionEnter(Collision collision)
    {
        Instantiate(deathEffect, transform.position, Quaternion.LookRotation(collision.contacts[0].normal));

        Destroy(gameObject);
    }
}
