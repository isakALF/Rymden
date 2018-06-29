using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public GameObject bulletprefab;
    // public GameObject PlayerShip;
    // public GameObject GunSpotR;

    public float fireDelay = 0.25f;
    float cooldownTimer = 0;

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        // GunSpotR = PlayerShip.transform.Find("GunSpotR").gameObject;
        if (Input.GetButton("Fire1") && cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;
            Instantiate(bulletprefab, transform.position, transform.rotation);
        }
    }
}