using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll) 
    {
        Debug.Log(coll.gameObject);
        if (coll.gameObject.tag == "Enemy")
        {
            coll.gameObject.SendMessage("TakeDamage", 20.0f);
        }

        Object.Destroy(this.gameObject);
    }
}
