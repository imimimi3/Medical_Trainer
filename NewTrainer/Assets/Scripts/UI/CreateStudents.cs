using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using TMPro;

using PatientObj;
using Ratings;

namespace StudentsData
{
    public class CreateStudents : MonoBehaviour
    {
        GameObject textStudent;

        GameObject textResults;

        public static int resultDiagnosis;

        GameObject canvasMenu;
        GameObject canvasResult;

        //Student newStudent;

        //string nameStudent;

        void Start()
        {
            textStudent = GameObject.Find("TextStudent");
            textResults = GameObject.Find("TextResults");

            canvasMenu = GameObject.Find("CanvasMenu");
            canvasResult = GameObject.Find("CanvasResult");
            canvasResult.SetActive(false);
            //res = "";
        }

        public void OnStart()
        {
            //nameStudent = textStudent.GetComponent<TextMeshProUGUI>().text;
            Student.Name = textStudent.GetComponent<TextMeshProUGUI>().text;

            PatientChoice.patientName = "";

            Rating.fNose = false; 
            Rating.fEars = false;
            Rating.fMouth = false; 
            Rating.fKT = false;
            Rating.fXray = false;
            Rating.fBlood = false;
            Rating.fCOVID = false;

            resultDiagnosis = 2;
        }

        string numberPatient, result;

        string res = "", resS;

        public void OnRes()
        {
            canvasMenu.SetActive(false);
            canvasResult.SetActive(true);

            res = $@"{Student.Name}       {Student.NumberPatient}      {Student.Result}";

            if(res != resS)
                if(res != "")
                {
                    Results.TextRes += res + "\n";
                    resS = res;
                }

            textResults.GetComponent<TextMeshProUGUI>().text = Results.TextRes;
        }

        public void OnBack()
        {
            canvasMenu.SetActive(true);
            canvasResult.SetActive(false);
        }
    }
}