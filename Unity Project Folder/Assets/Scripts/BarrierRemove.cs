using UnityEngine;
using System.Collections;

public class BarrierRemove : MonoBehaviour
{
	float timer, delay;
	SpriteRenderer spriteRenderer;

	void Start()
	{
		timer = 0f;
		delay = 3f;

		spriteRenderer = GetComponent<SpriteRenderer> ();
	}

	void Update()
	{
		if (timer < delay)
			timer += Time.deltaTime;
		else
		{
			spriteRenderer.material.color *= 0.98f;
			if (spriteRenderer.material.color.a < 0.3)
				Destroy (gameObject);
		}
	}
}