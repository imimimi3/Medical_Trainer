using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using TMPro;
using Anamn;

using Ratings;

using DialogueSystem;

using PatientObj;

public class StudyButton : MonoBehaviour
{
    GameObject buttonsStudy;

    GameObject textIndicators;

    GameObject textPlanInd;

    string patientName = "";

    //public EventS eventS;

    //GameObject notification;

    GameObject thermometer;
    GameObject thermometer37;
    GameObject thermometer38;

    GameObject buttonsInspect;

    GameObject image;

    void Start()
    {
        buttonsInspect = GameObject.Find("ButtonsInspect");
        buttonsInspect.SetActive(false);

        buttonsStudy = GameObject.Find("ButtonsStudy");
        buttonsStudy.SetActive(false);

        textIndicators = GameObject.Find("TextIndicators");
        textIndicators.GetComponent<TextMeshProUGUI>().text = "";

        textPlanInd = GameObject.Find("TextPlanInd");

        //event = GameObject.Find("Scripts").GetComponent(typeof(EventS));
        
        //notification = GameObject.Find("TextNotification");
        //notification.SetActive(false);

        thermometer = GameObject.Find("Cylinder001");
        thermometer37 = GameObject.Find("Cylinder0037");
        thermometer38 = GameObject.Find("Cylinder0038");
        thermometer37.SetActive(false);
        thermometer38.SetActive(false);

        image = GameObject.Find("ImageTabletIns");
    }

    void Update()
    {
        if(patientName == "")
            patientName = PatientChoice.patientName;
    }

    bool stOnClick = false;
    public void StudyOn()
    {
        if (!stOnClick)
        {
            buttonsStudy.SetActive(true);
            stOnClick = true;
        }
        else
        {
            buttonsStudy.SetActive(false);
            stOnClick = false;
        }
    }

    bool tempOnClick = false;
    public void TempOn()
    {
        if(!tempOnClick)
        {
            if(patientName == "1")
            {
                textIndicators.GetComponent<TextMeshProUGUI>().text += Anamnesis.valueInd1[0];

                thermometer.SetActive(false);
                thermometer37.SetActive(true);
            }
            if(patientName == "2")
            {
                textIndicators.GetComponent<TextMeshProUGUI>().text += Anamnesis.valueInd2[0];
                thermometer.SetActive(false);
                thermometer38.SetActive(true);
            }
            tempOnClick = true;

            textPlanInd.GetComponent<TextMeshProUGUI>().text = textIndicators.GetComponent<TextMeshProUGUI>().text;
        }
    }

    bool HSOnClick = false;
    public void HSOn()
    {
        if(!HSOnClick)
        {
            if(patientName == "1")
                textIndicators.GetComponent<TextMeshProUGUI>().text += Anamnesis.valueInd2[1];
            if(patientName == "2")
                textIndicators.GetComponent<TextMeshProUGUI>().text += Anamnesis.valueInd2[1];
            HSOnClick = true;

            textPlanInd.GetComponent<TextMeshProUGUI>().text = textIndicators.GetComponent<TextMeshProUGUI>().text;
        }
    }

    bool pressOnClick = false;
    public void PressOn()
    {
        if(!pressOnClick)
        {
            if(patientName == "1")
                textIndicators.GetComponent<TextMeshProUGUI>().text += Anamnesis.valueInd2[2];
            if(patientName == "2")
                textIndicators.GetComponent<TextMeshProUGUI>().text += Anamnesis.valueInd2[2];
            pressOnClick = true;

            textPlanInd.GetComponent<TextMeshProUGUI>().text = textIndicators.GetComponent<TextMeshProUGUI>().text;
        }
    }

    
    bool InspectOnClick = false;
    public void InspectOn()
    {
        if (!InspectOnClick)
        {
            //notification.SetActive(true);
            //notification.GetComponent<TextMeshProUGUI>().text = "Для осмотра пройдите к манекену и нажмите клавишу Е";
            

            buttonsInspect.SetActive(true);

            InspectOnClick = true;
        }
        else
        {
            buttonsInspect.SetActive(false);

            //notification.SetActive(false);
            InspectOnClick = false;
        }
    }

    Sprite sprite;

    

    bool noseOnClick;
    public void NoseOn()
    {
        if (!noseOnClick)
        {
            sprite = Resources.Load<Sprite>("Images/nose");
            image.GetComponent<Image>().overrideSprite = sprite;
            noseOnClick = true;

            Rating.fNose = true;
        }
        else
        {
            sprite = Resources.Load<Sprite>("Images/Empty");
            image.GetComponent<Image>().overrideSprite = sprite;
            noseOnClick = false;
        }
    }


    bool earsOnClick;
    public void EarsOn()
    {
        if (!earsOnClick)
        {
            sprite = Resources.Load<Sprite>("Images/ears");
            image.GetComponent<Image>().overrideSprite = sprite;
            earsOnClick = true;

            Rating.fEars = true;
        }
        else
        {
            sprite = Resources.Load<Sprite>("Images/Empty");
            image.GetComponent<Image>().overrideSprite = sprite;
            earsOnClick = false;
        }
    }


    bool mouthOnClick;
    public void MouthOn()
    {
        if (!mouthOnClick)
        {
            sprite = Resources.Load<Sprite>("Images/mouth");
            image.GetComponent<Image>().overrideSprite = sprite;
            mouthOnClick = true;

            Rating.fMouth = true;
        }
        else
        {
            sprite = Resources.Load<Sprite>("Images/Empty");
            image.GetComponent<Image>().overrideSprite = sprite;
            mouthOnClick = false;
        }
    }
}
