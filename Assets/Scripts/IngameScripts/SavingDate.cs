﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingDate : MonoBehaviour {
  
    public GameObject gold;
 
	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        gold.GetComponent<UILabel>().text = "" + PlayerPrefs.GetInt("Gold");
    }
}
