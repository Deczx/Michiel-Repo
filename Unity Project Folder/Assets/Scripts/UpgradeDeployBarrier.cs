using UnityEngine;
using System.Collections;

public class UpgradeDeployBarrier : Upgrade
{
	GameObject barrierPrafab;

	public override void Start ()
	{
		cooldown = 3f;
		barrierPrafab = Resources.Load<GameObject> ("Prefabs/Barrier") as GameObject;
	}

	public override void Activate(GameObject owner)
	{
		// if its still on cooldown
		if (!CanActivate)
			return;

		// will reset the timer, just call it
		base.Activate (owner);

		// mathsi stuff
		Vector3 difference = Camera.main.ScreenToWorldPoint (Input.mousePosition) - owner.transform.position;
		float angleToMouse = Mathf.Atan2 (difference.y, difference.x);

		Vector3 barrierPosition = new Vector3 (Mathf.Cos (angleToMouse), Mathf.Sin (angleToMouse), 0f);

		GameObject barrier = GameObject.Instantiate (barrierPrafab);
		barrier.transform.position = owner.transform.position + barrierPosition;
		barrier.transform.eulerAngles = new Vector3 (0f, 0f, angleToMouse * Mathf.Rad2Deg);
	}
}