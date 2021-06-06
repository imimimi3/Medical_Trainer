using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using StudentsData;

namespace Aid
{
    public class AidStart : MonoBehaviour
    {
        public void OnAid()
        {
            Timer.timer = 90;
            Answers.trigerStart = false;

            Answers.numberQuestion = 0;
            ModelAid.trigerModel = 2;

            Timer.timeOver = false;
            Answers.trigerEnd = false;

            ResultAid.resultP = 100;
        }
    }
}