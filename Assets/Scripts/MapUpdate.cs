using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapUpdate : MonoBehaviour {
    public GameObject map1;
    public GameObject map2;
    public GameObject map3;
    public GameObject map4;
    public GameObject map5;
    public GameObject map6;
    public GameObject map7;
    public GameObject map8;
    public GameObject map9;
    public GameObject map10;
    public GameObject map11;
    public float Stagtime;
    public float time;
    public float Cooltime;
    public float time2;
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
    int Ranmdom()
    {
        int ranstage = Random.Range(0, 9);
        return ranstage;
    }
    void Randommap()
    {
        switch (Ranmdom())
        {
            case 0:
                Instantiate(map1,transform.localPosition+new Vector3(0,0,3), transform.rotation);
                break;
            case 1:
                Instantiate(map2, transform.localPosition + new Vector3(0, 0,3), transform.rotation);
                break;
            case 2:
                Instantiate(map3, transform.localPosition + new Vector3(0, 0, 3), transform.rotation);
                break;
               
            case 3:
                Instantiate(map4, transform.localPosition + new Vector3(0, 0, 3), transform.rotation);
                break;
              
            case 4:
                Instantiate(map5, transform.localPosition + new Vector3(0, 0, 3), transform.rotation);
                break;
                
            case 5:
                Instantiate(map6, transform.localPosition + new Vector3(0, 0, 3), transform.rotation);
                break;
              
            case 6:
                Instantiate(map7, transform.localPosition + new Vector3(0, 0, 3), transform.rotation);
                break;
               
            case 7:
                Instantiate(map8, transform.localPosition + new Vector3(0, 0, 3), transform.rotation);
                break;
               
            case 8:
                Instantiate(map9, transform.localPosition + new Vector3(0, 0, 3), transform.rotation);
                break;
               
            case 9:
                break;
              
            default:
                break;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Map" /*|| other.gameObject.tag == "Gray" || other.gameObject.tag == "Yellow" || other.gameObject.tag == "Boast"*/)
        {
            Randommap();
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
