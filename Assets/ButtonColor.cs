using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColor : MonoBehaviour {

    public int level;

    private Button button;
    private Image image;
    
    // Use this for initialization
	void Start () {
        button = GetComponent<Button>();
        image = GetComponent<Image>();
     }
	
	// Update is called once per frame
	void Update () {
        if (!PlayerPrefsManager.IsLevelUnlocked(level)) {
            image.color = Color.red;
            button.enabled = false;
        }
    }
}
