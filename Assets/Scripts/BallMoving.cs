using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoving : MonoBehaviour {
    public float BallSpeed = 4f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
        transform.Translate(0, 0,BallSpeed * Time.deltaTime);
       
        if (transform.position.x <-10 )
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
