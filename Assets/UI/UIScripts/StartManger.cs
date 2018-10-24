using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0)
        {
            Application.LoadLevel(1);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Application.LoadLevel(1);
        }
      
    }
    public void Quitgame()
    {

        Application.Quit();
    }
}
