using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameBTM : MonoBehaviour {
    public GameObject start;
    public GameObject Stagetime;
    public float stageplaytime;
    public float time;
    public GameObject Enemystage;
    public int StageNum;
    public int StageLvup = 0;

    // Use this for initialization
    void Start () {
        StageNum = 2;
        StageLvup = PlayerPrefs.GetInt("Stage");
     
    }
	
	// Update is called once per frame
	void Update () {
        //print(StageNum);
        //print(PlayerPrefs.GetInt("Stage"));
        time = time - Time.deltaTime;
        Stagetime.GetComponent<UIProgressBar>().value = time / stageplaytime;
        if (time <= 0)
        {
            StageLvup++;
            PlayerPrefs.SetInt("Stage", StageLvup);
            //Enemystage.GetComponent<Land>().enabled = false;
            //Enemystage.GetComponent<Land2>().enabled = true;
            Application.LoadLevel(StageNum+ PlayerPrefs.GetInt("Stage"));
  
        }
        if (PlayerPrefs.GetInt("Stage") == 0)
        {
            Enemystage.GetComponent<Land>().enabled = false;
            Enemystage.GetComponent<Land2>().enabled = false;
        }
        if (PlayerPrefs.GetInt("Stage") == 1)
        {
            Enemystage.GetComponent<Land>().enabled = true;
            Enemystage.GetComponent<Land2>().enabled = false;
        }
        if (PlayerPrefs.GetInt("Stage") == 2)
        {
            Enemystage.GetComponent<Land2>().enabled = true;
            Enemystage.GetComponent<Land>().enabled = false;
        }
        if (PlayerPrefs.GetInt("Stage") == 4)
        {
            Enemystage.GetComponent<Land>().enabled = true;
            Enemystage.GetComponent<Land2>().enabled = false;
        }
        if (PlayerPrefs.GetInt("Stage") > 5)
        {
            Application.LoadLevel(1);
        }
	}
    public void Pause()
    {
        start.transform.localPosition = new Vector3(9,146, 0);
        Time.timeScale = 0;
    }
    public void Play()
    {
        start.transform.localPosition = new Vector3(470, 146, 0);
        Time.timeScale = 1;
    }
    public void Restart()
    {
        Time.timeScale = 1;
        Application.LoadLevel(1);
    }
}
