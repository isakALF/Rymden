using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageByDamage : MonoBehaviour
{
	public int health = 0;

    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger!");

        health--;
    }
    void Update() { 
		if (health <= 0) {
			Die ();
			Destroy (GameObject.FindWithTag ("health"));
		}
		if (health == 2) {
			Destroy (GameObject.FindWithTag ("health 2"));
		}
		if (health == 1) {
			Destroy (GameObject.FindWithTag ("health 1"));
		}
	}
    void Die() {
        Destroy(gameObject);
    }

}