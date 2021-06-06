using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DialogueSystem;

namespace PatientObj
{
    public class PatientChoice : MonoBehaviour
    {
        public static string patientName = "";

        [Header("Пациент 1")]
        [SerializeField]
        private Dialogue dialogue1;
        [Header("Пациент 2")]
        [SerializeField]
        private Dialogue dialogue2;

        GameObject tPlan;

        GameObject hud;
        GameObject tAnam;
        GameObject player;

        ModelTrigger model;

        GameObject patientChoiseO;

        void Start()
        {
            // Делаем невидимым поле с вопросами/ответами
            hud = GameObject.Find("Sentence View");
            hud.transform.position += new Vector3(2500, 0, 0);

            tAnam = GameObject.Find("TextAnamnesis");
            tAnam.transform.position += new Vector3(2500, 0, 0);

            player = GameObject.Find("Player");

            model =  GameObject.Find("ObjectModel").GetComponent<ModelTrigger>();


            patientChoiseO = GameObject.Find("PatientChoiseO"); 


            tPlan = GameObject.Find("TextPlan");
            tPlan.SetActive(false);
            //tPlan.transform.position += new Vector3(-0.01f, -0.01f, -0.01f);//0.11083 0.01 0.15518 new 0.11083f, 0.006f, 0.155f
        }

        
        void Update()
        {
            if(!model.modelIn)
            {
                //UIOn();
            }
        }

        //DialogueController.Instance.StartDialogue(dialogue1);

        public void ChoiseP1()
        {
            DialogueController.Instance.StartDialogue(dialogue1);

            patientName = "1";

            patientChoiseO.SetActive(false);

            tPlan.SetActive(true);

            //UIOn();
        }

        public void ChoiseP2()
        {
            DialogueController.Instance.StartDialogue(dialogue2);

            patientName = "2";

            patientChoiseO.SetActive(false);

           tPlan.SetActive(true);

            //UIOn();
        }





        //bool touch = false;
        //public Camera mainCamera;

        void UIOn()
        {
           hud.transform.position += new Vector3(-2500, 0, 0);

            // Включаем курсор и делаем его видимым
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            player.GetComponent<PlayerMovement>().enabled = false;
        }
    }
}