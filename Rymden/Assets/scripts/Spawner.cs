using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public Vector3 position;

	public GameObject wave;

	void OnTriggerEnter2D(){
		Instantiate (wave, position, Quaternion.identity);
	}
}
