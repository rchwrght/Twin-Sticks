using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public bool recording = true;
    
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1")) {
            recording = false;
        }
        else {
            recording = true;
        }
	}
}
