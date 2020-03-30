﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform firepoint;
    public GameObject paperPrefab;

    // Update is called once per frame
    void Update()
    {
       if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // shooting logic
        Instantiate(paperPrefab, firepoint.position, firepoint.rotation);

    }
}