using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingEngineFire : MonoBehaviour {

	// Use this for initialization
    public Sprite normalFire;
  	public Sprite bigFire;
	public Sprite smallFire;
	private SpriteRenderer spriteRenderer;
	// Update is called once per frame

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
	void Update () {

        if (Input.GetAxis("Vertical") > 0)
            spriteRenderer.sprite = bigFire;
        else if (Input.GetAxis("Vertical") < 0)
            spriteRenderer.sprite = smallFire;
        else
            spriteRenderer.sprite = normalFire;
	}
}


   