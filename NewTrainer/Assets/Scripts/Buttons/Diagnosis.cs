using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using TMPro;
using Anamn;

using Ratings;

using PatientObj;

using StudentsData;

public class Diagnosis : MonoBehaviour
{
    GameObject buttonsDiagnosis;
    GameObject textD1;
    GameObject textD2;
    GameObject textD3;
    GameObject textD4;

    GameObject notification;

    ModelTrigger model;
    
    void Start()
    {
        buttonsDiagnosis = GameObject.Find("ButtonsDiagnosis");
        buttonsDiagnosis.transform.position += new Vector3(2500, 0, 0);

        textD1 = GameObject.Find("TextD1");
        textD2 = GameObject.Find("TextD2");
        textD3 = GameObject.Find("TextD3");
        textD4 = GameObject.Find("TextD4");

        notification = GameObject.Find("TextNotification");
        notification.SetActive(false);

        model= GameObject.Find("ObjectModel").GetComponent<ModelTrigger>();
    }

    string patientName = "";
    //public EventS eventS;

    

    bool dostup = false;
    bool mod = false;

    void Update()
    {
        if(patientName == "")
            patientName = PatientChoice.patientName;

        if(model.modelIn)
            mod = true;
        
        if (Rating.fNose && Rating.fEars && Rating.fMouth && mod && patientName != "")
            dostup = true;
    }

    bool diagnosisOnClick = false;

    public void DiagnosisOn()
    {
        if(dostup)
            if (!diagnosisOnClick)
            {
                buttonsDiagnosis.transform.position += new Vector3(-2500, 0, 0);

                if(patientName == "1")
                {
                    textD1.GetComponent<Text>().text = Anamnesis.Diagnosis1[0];
                    textD2.GetComponent<Text>().text = Anamnesis.Diagnosis1[1];
                    textD3.GetComponent<Text>().text = Anamnesis.Diagnosis1[2];
                    textD4.GetComponent<Text>().text = Anamnesis.Diagnosis1[3];
                }
                if(patientName == "2")
                {
                    textD1.GetComponent<Text>().text = Anamnesis.Diagnosis2[0];
                    textD2.GetComponent<Text>().text = Anamnesis.Diagnosis2[1];
                    textD3.GetComponent<Text>().text = Anamnesis.Diagnosis2[2];
                    textD4.GetComponent<Text>().text = Anamnesis.Diagnosis2[3];
                }

                diagnosisOnClick = true;
            }
            else
            {
                buttonsDiagnosis.transform.position += new Vector3(2500, 0, 0);
                diagnosisOnClick = false;
            }
    }

    bool dOn = false;

    public void D1On()
    {
        if(!dOn)
        {
            notification.SetActive(true);
            notification.GetComponent<TextMeshProUGUI>().text = "Диагноз поставлен НЕ правильно";
            CreateStudents.resultDiagnosis = 0;
            dOn = true;
        }
    }

    public void D2On()
    {
        if(!dOn)
        {
            if(patientName == "1")
            {
                notification.SetActive(true);
                notification.GetComponent<TextMeshProUGUI>().text = "Диагноз поставлен правильно";
                CreateStudents.resultDiagnosis = 1;
            }
            if(patientName == "2")
            {
                notification.SetActive(true);
                notification.GetComponent<TextMeshProUGUI>().text = "Диагноз поставлен НЕ правильно";
                CreateStudents.resultDiagnosis = 0;
            }
            dOn = true;
        }
    }

    public void D3On()
    {
        if(!dOn)
        {
            if(patientName == "1")
            {
                notification.SetActive(true);
                notification.GetComponent<TextMeshProUGUI>().text = "Диагноз поставлен НЕ правильно";
                CreateStudents.resultDiagnosis = 0;
            }
            if(patientName == "2")
            {
                notification.SetActive(true);
                notification.GetComponent<TextMeshProUGUI>().text = "Диагноз поставлен правильно";
                CreateStudents.resultDiagnosis = 1;
            }
            dOn = true;
        }
    }

    public void D4On()
    {
        if(!dOn)
        {
            notification.SetActive(true);
            notification.GetComponent<TextMeshProUGUI>().text = "Диагноз поставлен НЕ правильно";
            CreateStudents.resultDiagnosis = 0;
            dOn = true;
        }
    }
}
