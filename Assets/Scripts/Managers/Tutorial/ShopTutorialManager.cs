﻿using System;
using Assets.Scripts.Interfaces.UI;
using Assets.Scripts.Services;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Managers.Tutorial
{
    public class ShopTutorialManager : TutorialManager, ILanguageUI
    {
        public Text lifeShieldBuffTxt;
        public Text storedLifeShieldTxt;
        public Text dashBuffTxt;
        public Text creditsTxt;
        public Text tokensTxt;


        private void Awake()
        {
            var tutorialData = TutorialDataService.GetTutorialData();
            base.DeactivatePanel(tutorialData.dontShowShopTutorial);
            Time.timeScale = 1;

            LoadTextsLanguage();
        }

        public void LoadTextsLanguage()
        {
            var ld = LanguageService.GetLanguageDictionary();

            if (ld.isLoaded)
            {
                dontShowThisAgainTxt.text = ld.tutDontShowAgain;

                lifeShieldBuffTxt.text = ld.tutShopLifeShieldBuff;
                storedLifeShieldTxt.text = ld.tutShopStoredLifeShield;
                dashBuffTxt.text = ld.tutShopDashBuff;
                creditsTxt.text = ld.tutShopCredits;
                tokensTxt.text = ld.tutShopToken;
            }
        }

        public void PressOk()
        {
            var tutorialData = TutorialDataService.GetTutorialData();
            tutorialData.dontShowShopTutorial = dontShowToggle.isOn;

            base.SaveAndRelease(tutorialData);
        }

        public void ShowTutorial()
        {
            var tutorialData = TutorialDataService.GetTutorialData();
            dontShowToggle.isOn = tutorialData.dontShowShopTutorial;

            DeactivatePanel(false);
        }
    }
}
