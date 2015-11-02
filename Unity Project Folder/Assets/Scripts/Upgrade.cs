using UnityEngine;
using System.Collections;

public abstract class Upgrade
{
	protected float timer = 0f;
	protected float cooldown = 0f;

	public bool CanActivate
	{
		get { return timer >= cooldown; }
	}

	public virtual void Start() { }

	public virtual void Activate(GameObject owner)
	{
		timer = 0f;
	}

	public virtual void Update()
	{
		if (timer < cooldown)
			timer += Time.deltaTime;
	}
}