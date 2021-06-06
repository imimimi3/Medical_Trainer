using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

//using TMPro;
//using Anamn;

//using DialogueSystem;

public class EventS : MonoBehaviour
{
    GameObject hud;
    //GameObject tAnam;
    GameObject player;

    ModelTrigger model;

    GameObject instruction;
        
    void Start()
    {
        hud = GameObject.Find("Sentence View");
        
        player = GameObject.Find("Player");
        
        model =  GameObject.Find("ObjectModel").GetComponent<ModelTrigger>();

        instruction = GameObject.Find("Instruction");

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        player.GetComponent<PlayerMovement>().enabled = false;
    }

    bool touch = false;

    void Update()
    {
        if(!model.modelIn)
        {
            if (Input.GetMouseButtonDown(1) && !touch)
            {
                hud.transform.position += new Vector3(-2500, 0, 0);

                // Включаем курсор и делаем его видимым
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

                player.GetComponent<PlayerMovement>().enabled = false;

                touch = true;
            }
            else
                if (Input.GetMouseButtonDown(1) && touch)
                {
                    hud.transform.position += new Vector3(2500, 0, 0);

                    // Выключаем курсор и делаем его невидимым
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;

                    player.GetComponent<PlayerMovement>().enabled = true;

                    touch = false;
                }
        }
        
    }

    public void OnInstruction()
    {
        instruction.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        player.GetComponent<PlayerMovement>().enabled = true;
    }


/*
    public Camera mainCamera;

    public void UIOn()
    {
        RaycastHit hit;
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            patient = hit.transform.GetComponent<PatientTrigger>();
            if (patient != null && patient.PatientName != string.Empty)
            {
                if (Input.GetKeyDown(KeyCode.T))
                {
                    if(patient.PatientName == "1")
                        DialogueController.Instance.StartDialogue(dialogue1);
                    if(patient.PatientName == "2") 
                        DialogueController.Instance.StartDialogue(dialogue2);
                    
                    if(patientName == "")
                        patientName = patient.PatientName;

                    hud.transform.position += new Vector3(-2500, 0, 0);

                    // Включаем курсор и делаем его видимым
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;

                    player.GetComponent<PlayerMovement>().enabled = false;

                    touch = true;
                }
            }

            if (Input.GetMouseButtonDown(1) && !touch)
            {
                //hud.SetActive(true);
                hud.transform.position += new Vector3(-2500, 0, 0);

                // Включаем курсор и делаем его видимым
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

                player.GetComponent<PlayerMovement>().enabled = false;

                touch = true;
            }
            else
                if (Input.GetMouseButtonDown(1) && touch)
                {
                    //hud.SetActive(false);
                    hud.transform.position += new Vector3(2500, 0, 0);

                    // Выключаем курсор и делаем его невидимым
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;

                    player.GetComponent<PlayerMovement>().enabled = true;

                    touch = false;
                }
        }
    }

    bool anamOnClick = false;

    public void AnamnesisOn()
    {
        if (!anamOnClick)
        {
            //tAnam.SetActive(true);
            tAnam.transform.position += new Vector3(-2500, 0, 0);
            anamOnClick = true;
        }
        else
        {
            //tAnam.SetActive(false);
            tAnam.transform.position += new Vector3(2500, 0, 0);
            anamOnClick = false;
        }
    }
*/
}



/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using TMPro;
using Anamn;

using DialogueSystem;

public class EventS : MonoBehaviour
{
    GameObject hud;
    GameObject tAnam;
    GameObject player;

    ModelTrigger model;
        
    void Start()
    {
        // Делаем невидимым поле с вопросами/ответами
        hud = GameObject.Find("Sentence View");
        hud.transform.position += new Vector3(2500, 0, 0);

        tAnam = GameObject.Find("TextAnamnesis");
        tAnam.transform.position += new Vector3(2500, 0, 0);

        player = GameObject.Find("Player");

        model =  GameObject.Find("ObjectModel").GetComponent<ModelTrigger>();
    }

    bool touch = false;

    [Header("Пациент 1")]
    [SerializeField]
    private Dialogue dialogue1;
    [Header("Пациент 2")]
    [SerializeField]
    private Dialogue dialogue2;

    PatientTrigger patient;

    public string patientName = "";

    void Update()
    {
        if(!model.modelIn)
        {
            UIOn();
        }
        
    }

    public Camera mainCamera;

    public void UIOn()
    {
        RaycastHit hit;
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            patient = hit.transform.GetComponent<PatientTrigger>();
            if (patient != null && patient.PatientName != string.Empty)
            {
                if (Input.GetKeyDown(KeyCode.T))
                {
                    if(patient.PatientName == "1")
                        DialogueController.Instance.StartDialogue(dialogue1);
                    if(patient.PatientName == "2") 
                        DialogueController.Instance.StartDialogue(dialogue2);
                    
                    if(patientName == "")
                        patientName = patient.PatientName;

                    hud.transform.position += new Vector3(-2500, 0, 0);

                    // Включаем курсор и делаем его видимым
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;

                    player.GetComponent<PlayerMovement>().enabled = false;

                    touch = true;
                }
            }

            if (Input.GetMouseButtonDown(1) && !touch)
            {
                //hud.SetActive(true);
                hud.transform.position += new Vector3(-2500, 0, 0);

                // Включаем курсор и делаем его видимым
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

                player.GetComponent<PlayerMovement>().enabled = false;

                touch = true;
            }
            else
                if (Input.GetMouseButtonDown(1) && touch)
                {
                    //hud.SetActive(false);
                    hud.transform.position += new Vector3(2500, 0, 0);

                    // Выключаем курсор и делаем его невидимым
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;

                    player.GetComponent<PlayerMovement>().enabled = true;

                    touch = false;
                }
        }
    }

    bool anamOnClick = false;

    public void AnamnesisOn()
    {
        if (!anamOnClick)
        {
            //tAnam.SetActive(true);
            tAnam.transform.position += new Vector3(-2500, 0, 0);
            anamOnClick = true;
        }
        else
        {
            //tAnam.SetActive(false);
            tAnam.transform.position += new Vector3(2500, 0, 0);
            anamOnClick = false;
        }
    }
}
*/