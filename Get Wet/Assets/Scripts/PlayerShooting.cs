﻿using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 20;
    public float ammo = 10;
    public float speed2 = 20;
    public float ammo2 = 10;
    public Rigidbody projectile2;
    float time = -1;
    float time2 = -1;
    PlayerManager playermanager;
    void Start()
    {


    }
    // Update is called once per frame
    void Update()
    {


    }

    public void PrimaryWeapon()
    {
        if (time <= Time.timeSinceLevelLoad)
        {
            Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            time = Time.timeSinceLevelLoad;
            time = time + 0.2f;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            this.GetComponent<AudioSource>().Play();
            ammo = ammo - 1f;
            //PlayerManager.Instance.AddAmmo(0, -1);
        }
        //PlayerManager.Instance.AddAmmo(0, -1);
    }
    public void SecondaryWeapon()
    {
        if (time2 <= Time.timeSinceLevelLoad)
        {
            Rigidbody instantiatedProjectile2 = Instantiate(projectile2, transform.position, transform.rotation) as Rigidbody;
            time2 = Time.timeSinceLevelLoad;
            time2 = time2 + 0.2f;
            instantiatedProjectile2.velocity = transform.TransformDirection(new Vector3(0, 0, speed2));
            this.GetComponent<AudioSource>().Play();
            ammo2 = ammo2 - 1f;
            //PlayerManager.Instance.AddAmmo2(0, -1);
        }
        //PlayerManager.Instance.AddAmmo2(0, -1);
    }
}

