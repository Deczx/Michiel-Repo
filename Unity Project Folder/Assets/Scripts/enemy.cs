using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

    public float health = 50f; 

    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Object.Destroy(this.gameObject);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
