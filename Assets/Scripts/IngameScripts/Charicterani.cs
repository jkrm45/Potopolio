using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charicterani : MonoBehaviour {
    public Animation Runf;
    public Animation RunL;
    public Animation RunR;
    public Animation Jump;
    
    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Runf.Play("RUN00_F");
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RunL.Play("RUN00_L");
        }
    }
}
