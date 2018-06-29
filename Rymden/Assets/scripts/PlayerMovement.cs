using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    float maxSpeed = 9f;

    float shipBoundaryRadius = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Move the ship

        Vector3 pos = transform.position;

        pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
        pos.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;

        //restict player to camera boundarys

        if (pos.y + shipBoundaryRadius > Camera.main.orthographicSize) {
             pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
        }
        if (pos.y - shipBoundaryRadius < -Camera.main.orthographicSize) {
             pos.y = -Camera.main.orthographicSize + shipBoundaryRadius;
        }

        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;

        if (pos.x + shipBoundaryRadius > widthOrtho)
        {
            pos.x = widthOrtho - shipBoundaryRadius;
        }
        if (pos.x - shipBoundaryRadius < -widthOrtho)
        {
            pos.x = -widthOrtho + shipBoundaryRadius;
        }

        transform.position = pos;
	}
}
