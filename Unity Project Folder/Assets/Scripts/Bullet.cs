using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    int b_type = 0;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SetType(int bt)
    {
        b_type = bt;
    }

    void OnCollisionEnter2D(Collision2D coll) 
    {
        if (coll.gameObject.tag == "Enemy")
        {
            coll.gameObject.SendMessage("TakeDamage", b_type);
        }

        Object.Destroy(this.gameObject);
    }
}
