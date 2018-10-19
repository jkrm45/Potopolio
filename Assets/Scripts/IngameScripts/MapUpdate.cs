using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapUpdate : MonoBehaviour {
    public GameObject map;
    
    //public List<GameObject> Map;


    // Use this for initialization
    void Start ()
    {
        //Map = new List<GameObject>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //time += Time.deltaTime; 
        //time2 += Time.deltaTime;
        //if (time < Stagtime)
        //{
        //    if (time2 > Cooltime)
        //    {
        //        Randommap();
        //        time2 = 0;
        //    }
        //}
        //else
        //{
        //    time = 0;
        //}
        //foreach (GameObject item in GameObject.FindGameObjectsWithTag("Map"))
        //{
        //    Map.Add(item);
        //}


    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Map" /*|| other.gameObject.tag == "Gray" || other.gameObject.tag == "Yellow" || other.gameObject.tag == "Boast"*/)
        {
            Instantiate(map, transform.position+new Vector3(0,0,3), transform.rotation);
        }
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "Map" /*|| other.gameObject.tag == "Gray" || other.gameObject.tag == "Yellow" || other.gameObject.tag == "Boast"*/)
    //    {
    //        Randommap();
    //    }
    //}
}
