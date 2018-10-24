using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEESST : MonoBehaviour {
    public float time;
    public float coll;
	// Use this for initialization
	void Start () {
     
    }
	
	// Update is called once per frame
	void Update ()
    {
       
        for (int i = 0;  i < 3; i++)
        {
           
            time += Time.deltaTime;
            if (time > coll)
            {
                time = 0;
                PlayerPrefs.SetInt("NEXT", i);
                Application.LoadLevel(i);
             
               
            }


        }
    }
}
