using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

using PatientObj;

using Aid;

namespace StudentsData
{
    public class ResultAid : MonoBehaviour
    {
        public static int resultP = 100;
        public void Finish()
        {
            Student.NumberPatient = "Оказание первой помощи";

            if(Timer.timeOver)
                Student.Result = "Закончилось время";
            else
                Student.Result = "Набрано очков: " + resultP.ToString();// + " Оставшееся время: " + Timer.timeEnd.ToString("00");
        }
    }
}