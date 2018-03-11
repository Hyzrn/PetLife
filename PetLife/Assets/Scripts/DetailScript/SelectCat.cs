using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCat : MonoBehaviour {

    public GameObject CatBtn1Active;
    public GameObject CatBtn1Passive;
    public GameObject CatBtn2Active;
    public GameObject CatBtn2Passive;
    public GameObject CatBtn3Active;
    public GameObject CatBtn3Passive;
    public GameObject CatBtn4Active;
    public GameObject CatBtn4Passive;
    public GameObject CatBtn5Active;
    public GameObject CatBtn5Passive;
    public GameObject CatBtn6Active;
    public GameObject CatBtn6Passive;
    public GameObject CloseMenu;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ClosePanel()
    {
        CloseMenu.SetActive(false);       
    }
    public void SelectCatBtn1()
    {
        CatBtn1Active.SetActive(true);
        CatBtn1Passive.SetActive(false);
        Debug.Log("btncat1 bastın");
        CatBtn2Active.SetActive(false);
        CatBtn3Active.SetActive(false);
        CatBtn4Active.SetActive(false);
        CatBtn5Active.SetActive(false);
        CatBtn6Active.SetActive(false);

        //CatBtn1Passive.SetActive(true);
        CatBtn2Passive.SetActive(true);
        CatBtn3Passive.SetActive(true);
        CatBtn4Passive.SetActive(true);
        CatBtn5Passive.SetActive(true);
        CatBtn6Passive.SetActive(true);

    }

    public void SelectCatBtn2()
    {
        CatBtn2Active.SetActive(true);
        CatBtn2Passive.SetActive(false);
        Debug.Log("btncat2 bastın");
        CatBtn1Active.SetActive(false);
        CatBtn3Active.SetActive(false);
        CatBtn4Active.SetActive(false);
        CatBtn5Active.SetActive(false);
        CatBtn6Active.SetActive(false);

        CatBtn1Passive.SetActive(true);
       // CatBtn2Passive.SetActive(true);
        CatBtn3Passive.SetActive(true);
        CatBtn4Passive.SetActive(true);
        CatBtn5Passive.SetActive(true);
        CatBtn6Passive.SetActive(true);
    }
    public void SelectCatBtn3()
    {
        CatBtn3Active.SetActive(true);
        CatBtn3Passive.SetActive(false);
        Debug.Log("btncat3 bastın");
        CatBtn1Active.SetActive(false);
        CatBtn2Active.SetActive(false);
        CatBtn4Active.SetActive(false);
        CatBtn5Active.SetActive(false);
        CatBtn6Active.SetActive(false);

        CatBtn1Passive.SetActive(true);
        CatBtn2Passive.SetActive(true);
        //CatBtn3Passive.SetActive(true);
        CatBtn4Passive.SetActive(true);
        CatBtn5Passive.SetActive(true);
        CatBtn6Passive.SetActive(true);
    }
    public void SelectCatBtn4()
    {
        CatBtn4Active.SetActive(true);
        CatBtn4Passive.SetActive(false);
        Debug.Log("btncat4 bastın");
        CatBtn1Active.SetActive(false);
        CatBtn2Active.SetActive(false);
        CatBtn3Active.SetActive(false);
        CatBtn5Active.SetActive(false);
        CatBtn6Active.SetActive(false);

        CatBtn1Passive.SetActive(true);
        CatBtn2Passive.SetActive(true);
        CatBtn3Passive.SetActive(true);
        //CatBtn4Passive.SetActive(true);
        CatBtn5Passive.SetActive(true);
        CatBtn6Passive.SetActive(true);
    }
    public void SelectCatBtn5()
    {
        CatBtn5Active.SetActive(true);
        CatBtn5Passive.SetActive(false);
        Debug.Log("btncat5 bastın");
        CatBtn1Active.SetActive(false);
        CatBtn2Active.SetActive(false);
        CatBtn3Active.SetActive(false);
        CatBtn4Active.SetActive(false);
        CatBtn6Active.SetActive(false);

        CatBtn1Passive.SetActive(true);
        CatBtn2Passive.SetActive(true);
        CatBtn3Passive.SetActive(true);
        CatBtn4Passive.SetActive(true);
       // CatBtn5Passive.SetActive(true);
        CatBtn6Passive.SetActive(true);
    }
    public void SelectCatBtn6()
    {
        CatBtn6Active.SetActive(true);
        CatBtn6Passive.SetActive(false);
        Debug.Log("btncat6 bastın");
        CatBtn1Active.SetActive(false);
        CatBtn2Active.SetActive(false);
        CatBtn3Active.SetActive(false);
        CatBtn4Active.SetActive(false);
        CatBtn5Active.SetActive(false);

        CatBtn1Passive.SetActive(true);
        CatBtn2Passive.SetActive(true);
        CatBtn3Passive.SetActive(true);
        CatBtn4Passive.SetActive(true);
        CatBtn5Passive.SetActive(true);
       // CatBtn6Passive.SetActive(true);
    }

}
