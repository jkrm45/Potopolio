using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuillCannon : MonoBehaviour {
    public GameObject Cannon;
	// Use this for initialization
	void Start ()
    {
        GameObject Cannonobj = Instantiate(Cannon) as GameObject;
        Cannonobj.transform.parent = transform;
        Cannonobj.transform.position = transform.position + new Vector3(-0.741f, 0.211f, -0.679f);
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
