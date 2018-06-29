using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingEngineFire : MonoBehaviour {

	// Use this for initialization

    //float FireOn = 0;
    // float BigFireOn = 0;

    public GameObject fireprefab;
  	public GameObject fireprefab1;
	public GameObject fireprefab2;
	private bool BigFire = false;
	private bool SmallFire = false;
	private bool NormalFire = false;

	// Update is called once per frame
	void Update () {

		if (Input.GetButton ("Horizontal")) {
			if (NormalFire == false) {
				
				GameObject Fire = Instantiate(fireprefab1, transform.position, transform.rotation) as GameObject;
				if (Fire == null)
					Debug.LogWarning("No prefab to instantiate! Assign in the Inspector.");
				else
					Fire.transform.parent = transform;
				NormalFire = true;
				BigFire = false;
				SmallFire = false;
				Destroy (GameObject.FindWithTag("bigfire"));
				Destroy (GameObject.FindWithTag("smallfire"));
			}
		}

		if (Input.GetAxis ("Vertical") > 0) {
			if (BigFire == false) {
				
				GameObject ForwardFire = Instantiate (fireprefab, transform.position, transform.rotation) as GameObject;
				if (ForwardFire == null)
					Debug.LogWarning ("No prefab to instantiate! Assign in the Inspector.");
				else
					ForwardFire.transform.parent = transform;
				BigFire = true;
				SmallFire = false;
				NormalFire = false;
				Destroy (GameObject.FindWithTag ("smallfire"));
				Destroy (GameObject.FindWithTag ("normalfire"));
			}
		}
			if (Input.GetAxis ("Vertical") < 0) {
				if (SmallFire == false) {

					GameObject BackFire = Instantiate(fireprefab2, transform.position, transform.rotation) as GameObject;
					if (BackFire == null)
						Debug.LogWarning("No prefab to instantiate! Assign in the Inspector.");
					else
						BackFire.transform.parent = transform;
					SmallFire = true;
					NormalFire = false;
					BigFire = false;
					Destroy (GameObject.FindWithTag("bigfire"));
					Destroy (GameObject.FindWithTag("normalfire"));
				}
			}
		

	}
}


   