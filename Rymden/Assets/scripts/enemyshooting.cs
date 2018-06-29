using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshooting : MonoBehaviour {

	public GameObject shotPrefab;
	public float shootingRate = 0.25f;
	public float shootColdown;

	void Start() {
		shootColdown = 0f;
	}

	void Update () {
		
	}
}
