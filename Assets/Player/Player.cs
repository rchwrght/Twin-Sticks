﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print(CrossPlatformInputManager.GetAxis("Vertical") + " pressing W/S");
        print(CrossPlatformInputManager.GetAxis("Horizontal") + " pressing A/D");
    }
}
