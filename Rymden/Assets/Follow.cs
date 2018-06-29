using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

	public Transform thingToFollow;

	void LateUpdate()
	{
		transform.position = thingToFollow.position;
	}
}
