using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField]
    Energy energy;

    public GameObject bulletprefab;
   
    public float fireDelay = 0.25f;
    float cooldownTimer = 0;
    
    public float energyGain = 8;

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        energyGain += Time.deltaTime;
    
        // GunSpotR = PlayerShip.transform.Find("GunSpotR").gameObject;
        if (Input.GetButton("Fire1") && cooldownTimer <= 0 && energy.currentEnergy > 0)
        {
            cooldownTimer = fireDelay;
            Instantiate(bulletprefab, transform.position, transform.rotation);
            energy.DecromentEnergy();
        }
      
    }
}