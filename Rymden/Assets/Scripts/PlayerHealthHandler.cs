using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthHandler : MonoBehaviour
{
	[SerializeField] private int health = 0;
    [SerializeField] private List<GameObject> healthObjects = new List<GameObject>();

    void OnTriggerEnter2D()
    {
        health--;
        Destroy(healthObjects[0]);
        healthObjects.RemoveAt(0);
    }
    void Update() { 
		if (health <= 0)
			Die();
	}
    void Die() {
        Destroy(gameObject);
    }

}