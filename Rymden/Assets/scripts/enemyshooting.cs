using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {

	public GameObject shotPrefab;
	public float shootingRate;
	public float shootColdown;

	void Start() {
		shootColdown = 0f;
	}

	void Update () {
		
	}
}
