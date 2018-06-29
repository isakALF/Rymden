using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingFire2 : MonoBehaviour {

    public GameObject fireprefab;
   
    // Update is called once per frame
    void Start () {

        if (Input.GetButton("Vertical") == true) {
            Instantiate(fireprefab, transform.position, transform.rotation);
        }
    }
}

