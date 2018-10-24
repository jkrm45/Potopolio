using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEst2 : MonoBehaviour {
    public float speed = 3f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchdeltapositon = Input.GetTouch(0).deltaPosition;
            transform.Translate(touchdeltapositon.x * Time.deltaTime * speed, 0, 0);
        }
    }
}
