﻿using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Managers
{

    public class PauseManager : MonoBehaviour
    {
        public GameObject pausePanel;
        public Button pauseButton;

        ScenesManager scenesManager;
        const int unpausedValue = 1;
        const int pausedValue = 0;

        bool isPaused;
        private void Start()
        {
            scenesManager = GameObject.Find("SceneManager").GetComponent<ScenesManager>();
            pauseButton.gameObject.SetActive(true);
        }
        public void PauseGame()
        {

            if (isPaused)
            {
                UnpauseGame();
                return;
            }
            pausePanel.SetActive(true);
            Time.timeScale = pausedValue;
            isPaused = !isPaused;
        }

        public void UnpauseGame()
        {
            Time.timeScale = unpausedValue;

            //Remove the pause panel
            pausePanel.SetActive(false);

            isPaused = false;
        }

        public void ReturnToMainMenu()
        {
            Time.timeScale = unpausedValue;
            scenesManager.LoadMainMenu();
        }
    }
}
