﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAfter;

	void Start () {
		if (autoLoadNextLevelAfter <= 0) {
			Debug.Log ("Level auto load disabled, use a postive number is seconds");
		} else {
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
		}
	}

	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}
	
	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
        PlayerPrefsManager.UnlockLevel(Application.loadedLevel + 1);
	}

    public void LoadSelectedLevel(int level) {
        if (PlayerPrefsManager.IsLevelUnlocked(level)) {
            Application.LoadLevel(level);
        } else {
            Debug.Log("Level " + level + " is not unlocked");
        }
    }
}
