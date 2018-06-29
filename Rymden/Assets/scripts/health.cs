using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
	{
		public int Hp = 1;

		void OnTriggerEnter2D()
		{
			Debug.Log("Trigger!");

			Hp--;
		}
			void Update() { 
				if (Hp <= 0) {
			Die ();
			}
		}
		void Die() {
			Destroy(gameObject);
		}

	}
