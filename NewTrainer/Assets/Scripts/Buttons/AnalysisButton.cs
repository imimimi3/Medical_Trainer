using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using TMPro;
using Anamn;
using Ratings;

using PatientObj;

public class AnalysisButton : MonoBehaviour
{
    GameObject buttonsAnalysis;

    GameObject image;

    GameObject textBlood;

    GameObject textCovid;

    string patientName = "";

    //public EventS eventS;


    void Start()
    {
        buttonsAnalysis = GameObject.Find("ButtonsAnalysis");
        buttonsAnalysis.SetActive(false);

        image = GameObject.Find("ImageTablet");

        textBlood = GameObject.Find("TextBlood");

        textBlood.GetComponent<TextMeshProUGUI>().text = "";

        textCovid = GameObject.Find("TextCovid");
    }

    void Update()
    {
        if(patientName == "")
            patientName = PatientChoice.patientName;
    }

    bool analysisOnClick = false;
    public void AnalysisOn()
    {
        if (!analysisOnClick)
        {
            buttonsAnalysis.SetActive(true);
            analysisOnClick = true;
        }
        else
        {
            buttonsAnalysis.SetActive(false);
            analysisOnClick = false;
        }
    }

    Sprite sprite;

    bool xrayOnClick = false;
    public void XRayOn()
    {
        if(patientName == "2")
            if (!xrayOnClick)
            {
                sprite = Resources.Load<Sprite>("Images/Xray");
                image.GetComponent<Image>().overrideSprite = sprite;
                xrayOnClick = true;

                Rating.fXray = true;
                Rating.fKT = true;
            }
            else
            {
                sprite = Resources.Load<Sprite>("Images/Empty");
                image.GetComponent<Image>().overrideSprite = sprite;
                xrayOnClick = false;
            }
    }

    bool bloodOnClick = false;
    public void BloodOn()
    {
        if(!bloodOnClick)
        {
            textBlood.SetActive(true);
            if(patientName == "1")
                textBlood.GetComponent<TextMeshProUGUI>().text = Anamnesis.Blood1;
            if(patientName == "2")
                textBlood.GetComponent<TextMeshProUGUI>().text = Anamnesis.Blood2;
            bloodOnClick = true;

            Rating.fBlood = true;
        }
        else
        {
            textBlood.SetActive(false);
            bloodOnClick = false;
        }
    }

    bool KTOnClick = false;
    public void KTOn()
    {
        if(patientName == "1")
            if (!KTOnClick)
            {
                sprite = Resources.Load<Sprite>("Images/KT25");
                image.GetComponent<Image>().overrideSprite = sprite;
                KTOnClick = true;

                Rating.fKT = true;
                Rating.fXray = true;
            }
            else
            {
                sprite = Resources.Load<Sprite>("Images/Empty");
                image.GetComponent<Image>().overrideSprite = sprite;
                KTOnClick = false;
            }
    }

    bool covidOnClick = false;
    public void CovidOn()
    {
        if(!covidOnClick)
        {
            textCovid.SetActive(true);
            if(patientName == "1")
                textCovid.GetComponent<TextMeshProUGUI>().text = Anamnesis.Covid1;
            if(patientName == "2")
                textCovid.GetComponent<TextMeshProUGUI>().text = Anamnesis.Covid2;
            covidOnClick = true;

            Rating.fCOVID = true;
        }
        else
        {
            textCovid.SetActive(false);
            covidOnClick = false;
        }
    }
}
