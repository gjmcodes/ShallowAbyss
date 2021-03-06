﻿using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Managers.Shop
{
    public class AlertMessageManager : MonoBehaviour
    {
        public Text alertText;
        public float maxDisplayTime;
        public float currentTickTime;
        public bool hasMessage;

        private void Update()
        {
            if (hasMessage)
            {
                currentTickTime += Time.deltaTime;

                if (currentTickTime > maxDisplayTime)
                {
                    alertText.text = string.Empty;
                    currentTickTime = 0;
                    hasMessage = false;
                    transform.parent.gameObject.SetActive(false);
                }
            }
          
        }

        public void SetAlertMessage(string msg)
        {
            transform.parent.gameObject.SetActive(true);
            alertText.text = msg;
            hasMessage = true;
        }
    }
}
