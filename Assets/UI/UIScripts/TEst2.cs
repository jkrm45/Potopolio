using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEst2 : MonoBehaviour {
   
       public GameObject enemy;

    public float spawnTime = 2.0f;



    float deltaSpawnTime = 0.0f;

    int spawnCnt = 1;

    int maxSpawnCnt = 10;



    // Use this for initialization 

    void Start()
    {



    }



    // Update is called once per frame 

    void Update()

    {

        if (spawnCnt > maxSpawnCnt) // spawncnt가 maxspawncnt 수가되면 생성 스탑!!!  갯수제한 

        {

            return;

        }



        deltaSpawnTime += Time.deltaTime;

        if (deltaSpawnTime > spawnTime)

        {

            deltaSpawnTime = 0.0f;



            GameObject enemyObj = Instantiate(enemy) as GameObject;

            float x = Random.Range(-20.0f, 20.0f);

            enemyObj.transform.position = new Vector3(x, 0.1f, 20.0f);



            enemyObj.name = "Enemy_" + spawnCnt;

            ++spawnCnt;

        }





    }

}
    

