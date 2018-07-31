using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject deathAnimation;
    public int health = 1;
    void OnTriggerEnter2D()
    {
	    health--;
    }

    void Update() { 
		if (health <= 0) {
		    Die ();
        }
    }

    void Die()
    {
        deathAnimation = (GameObject)Instantiate(deathAnimation, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
