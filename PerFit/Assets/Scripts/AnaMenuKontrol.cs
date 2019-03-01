﻿using UnityEngine;
using UnityEngine.UI;

public class AnaMenuKontrol : MonoBehaviour {

    public Button playButton;
    public Text versionCode;

    public Canvas anaMenuCanvas;
    public Canvas tutorialCanvas;

    public GameObject buttonsForMobile;
    public GameObject buttonsForPc;

    void Awake()
    {
//#if UNITY_EDITOR
        //buttonsForPc.SetActive(true);
#if UNITY_WEBGL
        buttonsForPc.SetActive(true);
        buttonsForMobile.SetActive(false);
#elif UNITY_ANDROID
        buttonsForMobile.SetActive(true);
        buttonsForPc.SetActive(false);
#else
        Debug.Log("platform bulunamadı");
#endif
    }

    public void openTutorialScreen()
    {
        anaMenuCanvas.enabled = false;
        tutorialCanvas.enabled = true;
    }

    public void backToMainMenu()
    {
        anaMenuCanvas.enabled = true;
        tutorialCanvas.enabled = false;
    }

#if UNITY_ANDROID
    public void ShowLeaderboards()
    {
        GooglePlayKontrol.ShowLeaderboardsUI();
    }
#endif
}