using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour {
    public float MapMoveSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0, 0, -MapMoveSpeed * Time.deltaTime);
        if (transform.position.z < -45)
        {
            Destroy(gameObject);
        }
	}
}
