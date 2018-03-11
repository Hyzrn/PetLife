using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Navigation : MonoBehaviour {

    public GameObject NavigationButtonOpen;
    public GameObject NavigationMenu;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NavigationOpen()
    {
        NavigationButtonOpen.SetActive(false);
        NavigationMenu.SetActive(true);
    }
    public void NavigationClosed()
    {
        NavigationMenu.SetActive(false);
        NavigationButtonOpen.SetActive(true);
    }
}
