﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {
    public GameObject Firpos;
    public GameObject Ball;
    public GameObject FireEffect;
    public float cooltime;
    public float dely;
	// Use this for initialization
	void Start () {
        if (transform.position.x > 2)
        {
            transform.Rotate(0, 90, 0);
        }
        if (transform.position.x < -2.5)
        {
            transform.Rotate(0, -90, 0);
        }

    }
	
	// Update is called once per frame
	void Update () {
        dely += Time.deltaTime;
        if (dely > cooltime)
        {
            GameObject Ballobj= Instantiate(Ball, Firpos.transform.position, transform.rotation);
            GameObject fireeffectobj = Instantiate(FireEffect, Firpos.transform.position, transform.rotation);
            Ballobj.transform.parent = transform;
            fireeffectobj.transform.parent = transform;
            Destroy(fireeffectobj, 1f);
            dely = 0;
            
        }
     
    }
}