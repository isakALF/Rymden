﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {

    public float timer = 1f;
	void Start () {
        Destroy(gameObject, timer);
	}
}
