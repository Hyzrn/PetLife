using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Shop : MonoBehaviour {

    public GameObject ShopBtn1;
    public GameObject ShopBtn2;
    public GameObject ShopBtn3;
    public GameObject ShopBtn4;
    public GameObject ShopBtn5;
    public GameObject ShopBtn6;


    public GameObject ShopPage1Img;
    public GameObject ShopPage2Img;

    public GameObject ShopSkillMenuPanel;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShopPageRight()
    {
        if (ShopPage1Img == true)
        {
            ShopPage1Img.SetActive(false);
            ShopPage2Img.SetActive(true);

            ShopBtn1.SetActive(false);
            ShopBtn2.SetActive(false);
            ShopBtn3.SetActive(false);

            ShopBtn4.SetActive(true);
            ShopBtn5.SetActive(true);
            ShopBtn6.SetActive(true);
         }
          
    }
    public void ShopPageLeft()
    {
      
        if (ShopPage2Img == true)
        {
            ShopPage2Img.SetActive(false);
            ShopPage1Img.SetActive(true);
            ShopBtn1.SetActive(true);
            ShopBtn2.SetActive(true);
            ShopBtn3.SetActive(true);

            ShopBtn4.SetActive(false);
            ShopBtn5.SetActive(false);
            ShopBtn6.SetActive(false);
        }

    }
    public void ExitShop()
    {
        Application.LoadLevel(3);
    }
    public void ExitSkillShopMenu()
    {
        ShopSkillMenuPanel.SetActive(false);
    }
    
   
}


