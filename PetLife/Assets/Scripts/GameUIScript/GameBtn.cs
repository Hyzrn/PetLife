using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBtn : MonoBehaviour {

    public GameObject GameButtonOpen;
    public GameObject GameButtonClose;
    public GameObject GameBtn1;
    public GameObject GameBtn2;
    public GameObject GameBtn3;
    public GameObject GameBtn4;
    public GameObject GameBtn5;
    public GameObject GameBtn6;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    
    }
    public void GameButtonMenuOpen()
    {
        GameButtonOpen.SetActive(false);
        GameButtonClose.SetActive(true);
        GameBtn1.SetActive(true);
        GameBtn2.SetActive(true);
        GameBtn3.SetActive(true);
        GameBtn4.SetActive(true);
        GameBtn5.SetActive(true);
        GameBtn6.SetActive(true);
        
    }
    public void GameButtonMenuClose()
    {
        GameButtonClose.SetActive(false);
        GameButtonOpen.SetActive(true);
        GameBtn1.SetActive(false);
        GameBtn2.SetActive(false);
        GameBtn3.SetActive(false);
        GameBtn4.SetActive(false);
        GameBtn5.SetActive(false);
        GameBtn6.SetActive(false);
    }
}
