using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHIRCHOOSE : MonoBehaviour {
    public GameObject CHAIR1;
    public GameObject CHAIR2;
    public GameObject CHAIR3;
    public GameObject CHAIR4;
    public GameObject CHAIR5;
    // Use this for initialization
    void Start () {
        if (PlayerPrefs.GetInt("chari1") == 1)
        {
            CHAIR1.SetActive(true);
            CHAIR2.SetActive(false);
            CHAIR3.SetActive(false);
            CHAIR4.SetActive(false);
            CHAIR5.SetActive(false);
        }
        if (PlayerPrefs.GetInt("chari2") == 1)
        {
            CHAIR2.SetActive(true);
            CHAIR1.SetActive(false);
            CHAIR3.SetActive(false);
            CHAIR4.SetActive(false);
            CHAIR5.SetActive(false);
        }
        if (PlayerPrefs.GetInt("chari3") == 1)
        {
            CHAIR3.SetActive(true);
            CHAIR2.SetActive(false);
            CHAIR1.SetActive(false);
            CHAIR4.SetActive(false);
            CHAIR5.SetActive(false);
        }
        if (PlayerPrefs.GetInt("chari4") == 1)
        {
            CHAIR4.SetActive(true);
            CHAIR2.SetActive(false);
            CHAIR3.SetActive(false);
            CHAIR1.SetActive(false);
            CHAIR5.SetActive(false);
        }
        if (PlayerPrefs.GetInt("chari5") == 1)
        {
            CHAIR5.SetActive(true);
            CHAIR2.SetActive(false);
            CHAIR3.SetActive(false);
            CHAIR4.SetActive(false);
            CHAIR1.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void chair1chose()
    {
        PlayerPrefs.SetInt("chari1", 1);
        PlayerPrefs.DeleteKey("chari2");
        PlayerPrefs.DeleteKey("chari3");
        PlayerPrefs.DeleteKey("chari4");
        PlayerPrefs.DeleteKey("chari5");
        CHAIR1.SetActive(true);
        CHAIR2.SetActive(false);
        CHAIR3.SetActive(false);
        CHAIR4.SetActive(false);
        CHAIR5.SetActive(false);
    }
    public void chair2chose()
    {
        PlayerPrefs.SetInt("chari2", 1);
        PlayerPrefs.DeleteKey("chari1");
        PlayerPrefs.DeleteKey("chari3");
        PlayerPrefs.DeleteKey("chari4");
        PlayerPrefs.DeleteKey("chari5");
        CHAIR1.SetActive(false);
        CHAIR2.SetActive(true);
        CHAIR3.SetActive(false);
        CHAIR4.SetActive(false);
        CHAIR5.SetActive(false);
    }
    public void chair3chose()
    {
        PlayerPrefs.SetInt("chari3", 1);
        PlayerPrefs.DeleteKey("chari1");
        PlayerPrefs.DeleteKey("chari2");
        PlayerPrefs.DeleteKey("chari4");
        PlayerPrefs.DeleteKey("chari5");
        CHAIR1.SetActive(false);
        CHAIR2.SetActive(false);
        CHAIR3.SetActive(true);
        CHAIR4.SetActive(false);
        CHAIR5.SetActive(false);
    }
    public void chair4chose()
    {
        PlayerPrefs.SetInt("chari4", 1);
        PlayerPrefs.DeleteKey("chari2");
        PlayerPrefs.DeleteKey("chari1");
        PlayerPrefs.DeleteKey("chari3");
        PlayerPrefs.DeleteKey("chari5");
        CHAIR1.SetActive(false);
        CHAIR2.SetActive(false);
        CHAIR3.SetActive(false);
        CHAIR4.SetActive(true);
        CHAIR5.SetActive(false);
    }
    public void chair5chose()
    {
        PlayerPrefs.SetInt("chari5", 1);
        PlayerPrefs.DeleteKey("chari2");
        PlayerPrefs.DeleteKey("chari3");
        PlayerPrefs.DeleteKey("chari4");
        PlayerPrefs.DeleteKey("chari1");
        CHAIR1.SetActive(false);
        CHAIR2.SetActive(false);
        CHAIR3.SetActive(false);
        CHAIR4.SetActive(false);
        CHAIR5.SetActive(true);
    }
}
