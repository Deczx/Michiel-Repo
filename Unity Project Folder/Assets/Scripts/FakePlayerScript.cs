using UnityEngine;
using System.Collections;

public class FakePlayerScript : MonoBehaviour
{
	UpgradeDeployClone deployBarrier;

	void Start()
	{
		deployBarrier = new UpgradeDeployClone ();
		deployBarrier.Start ();
	}

	void Update()
	{
		deployBarrier.Update ();

		if (Input.GetKey (KeyCode.Space)) {
			deployBarrier.Activate(gameObject);
		}
	}
}