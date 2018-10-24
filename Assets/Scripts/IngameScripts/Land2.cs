using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Land2 : MonoBehaviour
{
    public GameObject trapp3;
   public GameObject trapp4;
   public GameObject trapp5;
    



    // Use this for initialization
    void Start()
{
    Randomemake();
    //GameObject trapp1obj = Instantiate(trapp1, transform.position, transform.rotation);

    //trapp1obj.transform.parent = transform;
}

// Update is called once per frame
void Update()
{

}
int Randomtree()
{
    int ran = Random.Range(0, 100);
    if (ran < 87)
    {
        ran = 0;
    }
    if (ran >= 99&& ran < 93)
    {
        ran = 1;
    }
    if (ran >= 93 && ran <98)
    {
        ran = 2;
    }
    if (ran >= 98 && ran <100)
     {
            ran = 3;
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

            GameObject trapp3obj = Instantiate(trapp3, transform.position + new Vector3(- 0.755f, 0.205f ,- 0.867f), transform.rotation);

            trapp3obj.transform.parent = transform;
            break;
        case 2:
            GameObject trapp4obj = Instantiate(trapp4, transform.position + new Vector3(-0.696f, 0.026f, - 0.798f), transform.rotation);

            trapp4obj.transform.parent = transform;

            break;
            case 3:
                GameObject trapp5obj = Instantiate(trapp5, transform.position + new Vector3(-0.72f, 0.087f, - 0.732f), transform.rotation);

                trapp5obj.transform.parent = transform;
                break;
         




            default:
            break;
    }
}
}

