using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetCard : MonoBehaviour {

    public GameObject PetCardsMenu;
    public GameObject GameSplashPetCard;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void PetCardMenuOpen()
    {
        PetCardsMenu.SetActive(true);
        GameSplashPetCard.SetActive(true);
    }
    public void PetCardMenuClosed()
    {
        PetCardsMenu.SetActive(false);
        GameSplashPetCard.SetActive(false);
    }
}
