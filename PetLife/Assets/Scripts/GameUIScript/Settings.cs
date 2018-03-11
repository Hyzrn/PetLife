using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour {

    public GameObject SettingsMenu;
    public GameObject BackgroundSplash;

    public GameObject ListMenu;
    public GameObject SoundImg;
    public GameObject MusicImg;
    public GameObject FacebookImg;
    public GameObject SoundOn;
    public GameObject SoundOff;
    public GameObject MusicOn;
    public GameObject MusicOff;
    public GameObject FacebookOn;
    public GameObject FacebookOff;

    public GameObject OptionInfoBtn;
    public GameObject HelpBtn;
    public GameObject PolicyBtn;
    public GameObject TermsBtn;
    public GameObject ParentBtn;
    public GameObject CreditsBtn;

    public GameObject ShareBtn;
    public GameObject FacebookShareBtn;
    public GameObject TwitterShareBtn;




    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SettingsOpen()
    {
        BackgroundSplash.SetActive(true);
        SettingsMenu.SetActive(true);
        Debug.Log("TIKLADIN AMK");
        SoundImg.SetActive(true);
        MusicImg.SetActive(true);
        FacebookImg.SetActive(true);
        SoundOn.SetActive(true);
        SoundOff.SetActive(false);
        MusicOn.SetActive(true);
        MusicOff.SetActive(false);
        FacebookOn.SetActive(false);
        FacebookOff.SetActive(true);

        HelpBtn.SetActive(false);
        PolicyBtn.SetActive(false);
        TermsBtn.SetActive(false);
        ParentBtn.SetActive(false);
        CreditsBtn.SetActive(false);

        FacebookShareBtn.SetActive(false);
        TwitterShareBtn.SetActive(false);

    }
    public void SettingsClosed()
    {
        SettingsMenu.SetActive(false);
        BackgroundSplash.SetActive(false);      
    }
    public void SoundON()
    {
        SoundOn.SetActive(false);
        SoundOff.SetActive(true);
    }
    public void SoundOFF()
    {
        SoundOn.SetActive(true);
        SoundOff.SetActive(false);
    }
    public void MusicON()
    {
        MusicOn.SetActive(false);
        MusicOff.SetActive(true);
    }
    public void MusicOFF()
    {
        MusicOn.SetActive(true);
        MusicOff.SetActive(false);
    }
    public void FacebookON()
    {
        FacebookOn.SetActive(false);
        FacebookOff.SetActive(true);
    }
    public void FacebookOFF()
    {
        FacebookOn.SetActive(true);
        FacebookOff.SetActive(false);
    }
    #region Option Info Menu

    public void OptionInfoON()
    {
        SoundImg.SetActive(false);
        MusicImg.SetActive(false);
        FacebookImg.SetActive(false);
        SoundOn.SetActive(false);
        SoundOff.SetActive(false);
        MusicOn.SetActive(false);
        MusicOff.SetActive(false);
        FacebookOn.SetActive(false);
        FacebookOff.SetActive(false);
        HelpBtn.SetActive(true);
        PolicyBtn.SetActive(true);
        TermsBtn.SetActive(true);
        ParentBtn.SetActive(true);
        CreditsBtn.SetActive(true);
        FacebookShareBtn.SetActive(false);
        TwitterShareBtn.SetActive(false);

    }

    #endregion

    #region Share Menu
    public void ShareON()
    {
        SoundImg.SetActive(false);
        MusicImg.SetActive(false);
        FacebookImg.SetActive(false);
        SoundOn.SetActive(false);
        SoundOff.SetActive(false);
        MusicOn.SetActive(false);
        MusicOff.SetActive(false);
        FacebookOn.SetActive(false);
        FacebookOff.SetActive(false);
        HelpBtn.SetActive(false);
        PolicyBtn.SetActive(false);
        TermsBtn.SetActive(false);
        ParentBtn.SetActive(false);
        CreditsBtn.SetActive(false);
        FacebookShareBtn.SetActive(true);
        TwitterShareBtn.SetActive(true);
    }

    #endregion

    #region List Menu

    public void ListMENU()
    {
        SoundImg.SetActive(true);
        MusicImg.SetActive(true);
        FacebookImg.SetActive(true);
        SoundOn.SetActive(true);
        SoundOff.SetActive(false);
        MusicOn.SetActive(true);
        MusicOff.SetActive(false);
        FacebookOn.SetActive(false);
        FacebookOff.SetActive(true);
        HelpBtn.SetActive(false);
        PolicyBtn.SetActive(false);
        TermsBtn.SetActive(false);
        ParentBtn.SetActive(false);
        CreditsBtn.SetActive(false);
        FacebookShareBtn.SetActive(false);
        TwitterShareBtn.SetActive(false);
    }
    #endregion


}
