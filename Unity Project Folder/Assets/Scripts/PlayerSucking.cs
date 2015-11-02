using UnityEngine;
using System.Collections;

public class PlayerSucking : MonoBehaviour {

    public float pullForce = 100;

    void OnTriggerStay2D(Collider2D other)
    {
        
        Vector2 direction = transform.parent.GetChild(0).transform.position - other.transform.position;
        direction.Normalize();

        other.gameObject.GetComponent<Rigidbody2D>().AddForce(direction * pullForce);

    }
}
