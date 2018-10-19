using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrollmoving : MonoBehaviour {
    public float scrollSpeed;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float offset = Time.time * scrollSpeed;
        gameObject.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
       
    }
}
