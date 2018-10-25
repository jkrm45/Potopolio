using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicsound : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("sound1");
	}
}
