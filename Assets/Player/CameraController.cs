using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


    public GameObject player;

    private float yTransform;

	
	void Update () {
        float playerPos = player.transform.position.z;
        transform.position = new Vector3(transform.position.x, transform.position.y, playerPos);
    }
}
