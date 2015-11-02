using UnityEngine;
using System.Collections;

public class ice_floor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D>();

			rb.angularDrag = 0.01f;

		}

	}
}
