using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMapmanger : MonoBehaviour {
    public List<GameObject> Map;
    public GameObject Land;
    public GameObject Road;
    public GameObject ice;
    public GameObject cannon;
    public GameObject yellow;
    public GameObject Revers;
    public GameObject aaaa;
   
    // Use this for initialization
    void Start ()
    {
        //Map = new List<GameObject>();

        //for (int i = 0; i < 25; i++)
        //{
        //    Map.Add(Road);
        //}
        //Map = new List<GameObject>();
        //foreach (GameObject item in GameObject.FindGameObjectsWithTag("List"))
        //{
        //    Map.Add(item);
        //}

        for (int i = 0; i < 25; i++)
        {
            RanmdonGround();
           
            aaaa.transform.parent = Map[i].transform;
            aaaa.transform.localPosition = Vector3.zero;
            Setative();




        }
        //Map = new List<GameObject>();
        //foreach (GameObject item in GameObject.FindGameObjectsWithTag("List"))
        //{
        //    Map.Add(item);
        //}


    }

    // Update is called once per frame
    void Update ()
    {
        
    }
    int Ranmdom()
    {
        int ranstage = Random.Range(0, 100);
        if (ranstage < 85) 
        {
            ranstage = 0;
        }
        if (ranstage >= 85 && ranstage <89)
        {
            ranstage = 1;
        }
        if (ranstage >= 89 && ranstage < 92)
        {
            ranstage = 2;
        }
        if (ranstage >= 92 && ranstage < 97)
        {
            ranstage = 3;
        }
        if (ranstage >= 97 && ranstage < 100)
        {
            ranstage = 4;
        }
        return ranstage;
    }
    int RandomLand()
    {
        int ranstage2 = Random.Range(0, 100);
        if (ranstage2 < 80)
        {
            ranstage2 = 1;
        }
        if (ranstage2 > 80 && ranstage2 < 100)
        {
            ranstage2 = 0;
        }


        return ranstage2;
    }


    void RanmdonGround()
    {
        
        switch (Ranmdom())
        {
            case 0:
                aaaa = Instantiate(Land, transform.position, transform.rotation);
                
                break;
            case 1:
                aaaa =Instantiate(ice, transform.position, transform.rotation);
                break;
            case 2:
                aaaa= Instantiate(cannon, transform.position, transform.rotation);
                break;
            case 3:
                aaaa= Instantiate(yellow, transform.position, transform.rotation);
                break;
            case 4:
                aaaa = Instantiate(Revers, transform.position, transform.rotation);
                break;
            default:
                break;
        }
    }
    void Setative()
    {
        switch (RandomLand())
        {
            case 0:
                aaaa.SetActive(false);
               
                break;
            case 1:
                aaaa.SetActive(true); 

                break;

            default:
                break;
        }
    }
}
