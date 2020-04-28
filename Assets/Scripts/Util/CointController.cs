using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CointController : MonoBehaviour
{
    public EndGame endGame;
    private Vector3 rotation;

    void Start()
    {
        rotation = new Vector3(1, 0, -1);
    }

    void Update()
    {
        transform.Rotate(rotation);
    }

    void OnCollisionEnter(Collision col)
    {
        if ("Cannonball(Clone)".Equals(col.gameObject.name))
        {
            Destroy(this.gameObject);
            this.endGame.AddCointsDestroid();
        }
    }
}
