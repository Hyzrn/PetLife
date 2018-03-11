using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Information : MonoBehaviour {

    public GameObject GameSplashInformation;
    public GameObject InformationMenu;
  
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InformationMenuOpen()
    {
        GameSplashInformation.SetActive(true);
        InformationMenu.SetActive(true);
      

    }
    public void InformationMenuClosed()
    {
        GameSplashInformation.SetActive(false);
        InformationMenu.SetActive(false);
    }
}
