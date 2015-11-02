using UnityEngine;
using System.Collections;

public class enemyShot : MonoBehaviour {

	public float speed;
	int timer = 200;

	public bool homing;
	public Transform target;

	Vector3 direction;

	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		target = GameObject.Find ("player").transform;
		rb = GetComponent<Rigidbody2D>();

		direction = ((Vector2)(target.position - transform.position)).normalized * 30;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (homing == false){
			transform.Translate (0, speed, 0);
		}

		timer -= 1;

		if (timer < 0) {
			Destroy (gameObject);
		}

		if (homing) {
			rb.AddForce(direction);
			transform.eulerAngles = Vector3.forward;
		}
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		Debug.Log (other);

		if (other.gameObject.tag == "target") {
			Destroy (gameObject);
		}
	}

}
