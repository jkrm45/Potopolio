using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap1 : MonoBehaviour {
    public float trap1speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, trap1speed * Time.deltaTime, Space.World);
        if (transform.position.z > 3.5f)
        {
            trap1speed = -trap1speed;
        }
        if (transform.position.z < -3f)
        {
            trap1speed = -trap1speed;
        }
    }
}
