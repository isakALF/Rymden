using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour {

    [SerializeField]
    List<Sprite> energySprites;

    SpriteRenderer spriteRenderer;

    public int currentEnergy;
    int maxEnergy;

    [SerializeField]
    [Tooltip("cooldown in frames")]
    int cooldown;

    int cooldownMax;

    public void DecromentEnergy(int energyValue = 1 ) {
        currentEnergy -= energyValue;
        spriteRenderer.sprite = energySprites[currentEnergy];
    }

    public void IncromentEnergy(int energyValue = 1) {
        currentEnergy += energyValue;
        spriteRenderer.sprite = energySprites[currentEnergy];
    }

    // Use this for initialization
    void Start () {
        cooldownMax = cooldown;
        maxEnergy = energySprites.Count - 1;
        currentEnergy = maxEnergy;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if (currentEnergy < maxEnergy)
        {
            cooldown--;
            if (cooldown <= 0) {
                IncromentEnergy();
                cooldown = cooldownMax;
            }
        }
	}
}
