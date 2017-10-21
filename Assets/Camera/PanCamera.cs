using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


    private GameObject player;
    private float yTransform;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void LateUpdate() {
        float playerPos = player.transform.position.z;
        transform.position = new Vector3(transform.position.x, transform.position.y, playerPos);
    }
}
