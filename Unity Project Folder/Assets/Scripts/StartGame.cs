﻿using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
		if(Input.anyKeyDown){
			Application.LoadLevel(1);
		}
	}
}
