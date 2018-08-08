using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstWave : MonoBehaviour {

	public GameObject wave;

	void OnTriggerEnter2D(){
		Instantiate (wave);
	}
}
