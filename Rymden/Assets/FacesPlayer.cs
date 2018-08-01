﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacesPlayer : MonoBehaviour {

	public float rotSpeed = 90f;

	Transform player;
	
	// Update is called once per frame
	void Update () {
		if (player == null) {
			//find the players ship
			GameObject go = GameObject.Find ("PlayerShip");

			if (go != null) {
				player = go.transform;
			}
		}

		if (player == null)
			return; //try again next frame

		Vector3 dir = player.position - transform.position;
		dir.Normalize ();

		float zAngle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg + 90;

		Quaternion desiredRot = Quaternion.Euler (0, 0, zAngle);

		transform.rotation = Quaternion.RotateTowards (transform.rotation, desiredRot, rotSpeed * Time.deltaTime);
	}
}
