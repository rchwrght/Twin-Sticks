using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public bool recording = true;

    private float fixedDeltaTime;

    void Start() {
        fixedDeltaTime = Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButton("Fire1")) {
            recording = false;
        }
        else {
            recording = true;
        }

        if (Input.GetKeyDown(KeyCode.P)) {
            PauseGame();
        }

        if (Input.GetKeyUp(KeyCode.R)) {
            UnpauseGame();
        }
	}

    void PauseGame() {
        Time.timeScale = 0;
        Time.fixedDeltaTime = 0;
    }

    void UnpauseGame() {
        Time.timeScale = 1;
        Time.fixedDeltaTime = fixedDeltaTime;
    }
}
