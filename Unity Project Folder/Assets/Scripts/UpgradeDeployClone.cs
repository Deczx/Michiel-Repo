using UnityEngine;
using System.Collections;

public class UpgradeDeployClone : Upgrade
{
	GameObject clonePrefab;

	public override void Start ()
	{
		cooldown = 5f;
		clonePrefab = Resources.Load<GameObject> ("Prefabs/Clone") as GameObject;
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
		
		Vector3 clonePosition = new Vector3 (Mathf.Cos (angleToMouse) * 1.5f, Mathf.Sin (angleToMouse) * 1.5f, 0f);

		GameObject clone = GameObject.Instantiate (clonePrefab);
		clone.transform.eulerAngles = new Vector3 (0f, 0f, angleToMouse);
		clone.transform.position = owner.transform.position + clonePosition;
	}
}