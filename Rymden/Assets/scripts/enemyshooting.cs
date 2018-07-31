using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {

	public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);

	public GameObject bullet;
	int bulletLayer;

	public float fireDelay = 0.50f;
	float cooldownTimer = 0;

	void Start () {
		bulletLayer = gameObject.layer;
	}
	void Update () {
		cooldownTimer -= Time.deltaTime;
	
		if (cooldownTimer <= 0) {
			cooldownTimer = fireDelay;

			Vector3 offset = transform.rotation * bulletOffset;

			GameObject bulletGO = (GameObject)Instantiate (bullet, transform.position + offset, transform.rotation);
			bulletGO.layer = bulletLayer;	
		}
	}
}