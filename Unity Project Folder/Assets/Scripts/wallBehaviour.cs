using UnityEngine;
using System.Collections;

public class wallBehaviour : MonoBehaviour {

	Rigidbody2D rb;
	Collider2D coll;

	public GameObject shot;

	public float hsp;
	public int timer = 100;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		coll = GetComponent<CircleCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector2 (hsp, 0);
		timer -= 1;

		if (timer < 0) {
			shootBullet ();
			timer = 50;
		}

	}

	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.tag == "wallV") {
			hsp *= -1;
		}

		if (other.gameObject.tag == "enemy1") {
			hsp *= -1;
		}
	}

	void shootBullet(){
		Instantiate (shot, transform.position, transform.rotation);
	}

}
