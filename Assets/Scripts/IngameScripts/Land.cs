using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Land : MonoBehaviour {
    public GameObject trapp1;
    public GameObject trapp2;

	// Use this for initialization
	void Start () {
        Randomemake();
        //GameObject trapp1obj = Instantiate(trapp1, transform.position, transform.rotation);

        //trapp1obj.transform.parent = transform;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    int Randomtree()
    {
        int ran = Random.Range(0, 100);
        if (ran < 90)
        {
            ran = 0;
        }
        if (ran >=90 && ran <95)
        {
            ran = 1;
        }
        if (ran >= 95 && ran < 100)
        {
            ran = 2;
        }
        return ran;
    }
    void Randomemake()
    {
        switch (Randomtree())          
        {
            case 0:
                
               
                break;
            case 1:
                
                GameObject trapp2obj = Instantiate(trapp1, transform.position+new Vector3(0.112f,  0.159f, - 0.029f), transform.rotation);

                trapp2obj.transform.parent = transform;
                break;
            case 2:
                GameObject trapp1obj = Instantiate(trapp2, transform.position + new Vector3(-0.313f, 0.195f, -0.276f), transform.rotation);

                trapp1obj.transform.parent = transform;
                
                break;
                    
            default:
                break;
        }
    }
}
