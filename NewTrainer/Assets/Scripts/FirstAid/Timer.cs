using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

using UnityEngine.UI;

using TMPro;

namespace Aid
{
    public class Timer : MonoBehaviour
    {
        public static float timer = 90;

        public static bool timeOver = false;
        public static double timeEnd;

        public static DateTime timerEnd;

        void Start()
        {
            
        }

        public TextMeshProUGUI textTime;

        bool timerS = false;
        void Update()
        {
            if(!timerS)
                timerEnd = DateTime.Now.AddSeconds(timer);
            
            TimeSpan delta;

            if(!Answers.trigerEnd)
                if (Answers.trigerStart)
                {
                    delta = timerEnd - DateTime.Now;
                    textTime.text = delta.Minutes.ToString("00") + ":" + delta.Seconds.ToString("00");
                        
                    if (delta.TotalSeconds <= 0)
                    {
                        textTime.text = "ВРЕМЯ ВЫШЛО!!!";
                        timeOver = true;
                    }

                    timerS = true;
                }
            else
                timeEnd = delta.TotalSeconds;
        }
    }
}