﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnManger : MonoBehaviour {
    public GameObject Option;
    public GameObject Shop;
    public GameObject Charicchose;
    public GameObject shopX1;
    public GameObject shopX2;
    public GameObject shopX3;
    public GameObject menusound;
    public GameObject ingamesound;

    // Use this for initialization
    void Start ()
    {
		if(PlayerPrefs.GetInt("Shopx1") == 1)
        {
            shopX1.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Shopx2") == 1)
        {
            shopX1.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Shopx3") == 1)
        {
            shopX1.SetActive(false);
        }
        PlayerPrefs.DeleteKey("Stage");
        menusound.GetComponent<UISlider>().value = 1;
        ingamesound.GetComponent<UISlider>().value = 1;
        //PlayerPrefs.SetFloat("sound1", menusound.GetComponent<UISlider>().value);
        //PlayerPrefs.SetFloat("sound2", ingamesound.GetComponent<UISlider>().value);

    }
	
	// Update is called once per frame
	void Update ()
    {
        //menusound.GetComponent<UISlider>().value = PlayerPrefs.GetFloat("sound1");
        //ingamesound.GetComponent<UISlider>().value = PlayerPrefs.GetFloat("sound2");
        if (Input.GetKey(KeyCode.Space))
        {
            PlayerPrefs.DeleteAll();
        }
	}
    public void onOption()
    {
        menusound.GetComponent<UISlider>().value = PlayerPrefs.GetFloat("sound1");
       ingamesound.GetComponent<UISlider>().value = PlayerPrefs.GetFloat("sound2");
        Option.transform.localPosition = new Vector3(923, 0, 0);
    }
    public void offOption()
    {
        Option.transform.localPosition = new Vector3(0, 0, 0);
    }
    public void onshop()
    {
        Shop.transform.localPosition = new Vector3(923, 0, 0);
    }
    public void offshop()
    {
        Shop.transform.localPosition = new Vector3(0, 0, 0);
    }
    public void onchirkchoos()
    {
        Charicchose.transform.localPosition = new Vector3(923, 0, 0);
    }
    public void offchirckchoos()
    {
        Charicchose.transform.localPosition = new Vector3(0, 0, 0);
    }
    public void toPlay()
    {
        Application.LoadLevel(2);
    }
    public void cancleoption()
    {
        menusound.GetComponent<UISlider>().value = PlayerPrefs.GetFloat("soudn1");
        menusound.GetComponent<UISlider>().value = PlayerPrefs.GetFloat("soudn2");
        
        Option.transform.localPosition = new Vector3(0, 0, 0);
    }
    public void Okoption()
    {
        
        PlayerPrefs.SetFloat("sound1", menusound.GetComponent<UISlider>().value);
        PlayerPrefs.SetFloat("sound2", ingamesound.GetComponent<UISlider>().value);
        Option.transform.localPosition = new Vector3(0, 0, 0);
    }
    public void chair1buy()
    {
        if (PlayerPrefs.GetInt("Gold") >= 7)
        {
            shopX1.SetActive(false);
            PlayerPrefs.SetInt("Gold", PlayerPrefs.GetInt("Gold") - 7);
            PlayerPrefs.SetInt("Shopx1", 1);

        }
           
       
      
    }
    public void chair2buy()
    {
        if (PlayerPrefs.GetInt("Gold") >= 80)
        {
            shopX2.SetActive(false);
            PlayerPrefs.SetInt("Gold", PlayerPrefs.GetInt("Gold") - 80);
            PlayerPrefs.SetInt("Shopx1", 1);
        }
    }
    public void chair3buy()
    {
        if (PlayerPrefs.GetInt("Shopx2") >= 100)
        {
            shopX3.SetActive(false);
            PlayerPrefs.SetInt("Gold", PlayerPrefs.GetInt("Gold") - 90);
            PlayerPrefs.SetInt("Shopx3", 1);
        }
    }
    public void Quit()
    {
        Application.Quit();
    }
}
