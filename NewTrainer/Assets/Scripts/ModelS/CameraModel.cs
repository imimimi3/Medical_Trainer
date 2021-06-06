using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using TMPro;
using Anamn;

using PatientObj;

public class CameraModel : MonoBehaviour
{
    public Camera cameraTop;
    public Camera cameraLeft;
    public Camera cameraRight;

    public GameObject mainCamera;

    GameObject player;

    //ModelTrigger model;

    void Start()
    {
        cameraTop.enabled = false;
        cameraLeft.enabled = false;
        cameraRight.enabled = false;

        mainCamera = GameObject.Find("Main Camera");

        player = GameObject.Find("Player");
    }

    bool onModel = false;

    string patientName = "";

    

    void Update()
    {
        if(patientName == "")
            patientName = PatientChoice.patientName;
        
        if(!onModel)
            ModelOn();
        else
        {
            MoveCamera();

            Palpation();

            if (Input.GetKeyDown(KeyCode.E))
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                player.GetComponent<PlayerMovement>().enabled = true;

                mainCamera.SetActive(true);

                cameraTop.enabled = false;
                cameraLeft.enabled = false;
                cameraRight.enabled = false;

                onModel = false;

                model.modelIn = false;
            }
        }
    }

    //public EventS eventS;

    ModelTrigger model;
    RaycastHit hit;
    Ray ray;

    public void ModelOn()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit) && !onModel)
        {
            model = hit.transform.GetComponent<ModelTrigger>();
            if (model != null && Input.GetKeyDown(KeyCode.E))
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                player.GetComponent<PlayerMovement>().enabled = false;

                cameraTop.enabled = true;
                mainCamera.SetActive(false);

                onModel = true;

                model.modelIn = true;
            }
        }
    }

    string cameraNow =""; 

    public void MoveCamera()
    {
        if(Input.GetKeyDown("up"))
        {
            cameraTop.enabled = true;
            cameraLeft.enabled = false;
            cameraRight.enabled = false;

            cameraNow = "up";
        }

        if(Input.GetKeyDown("left"))
        {
            cameraLeft.enabled = true;
            cameraTop.enabled = false;
            cameraRight.enabled = false;

            cameraNow = "left";
        }

        if(Input.GetKeyDown("right"))
        {
            cameraRight.enabled = true;
            cameraTop.enabled = false;
            cameraLeft.enabled = false;

            cameraNow = "right";
        }
    }

    PalpationTrigger sphere;

    public Material Red;
    public Material Green;

    public void Palpation()
    {
        Camera cam;

        switch (cameraNow)
        {
            case "right":
                cam = cameraRight;
                break;
            case "left":
                cam = cameraLeft;
                break;
            default:
                cam = cameraTop;
                break;
        }

        int[] palpation = {};

        ray = cam.ScreenPointToRay(Input.mousePosition);
           
        if (Physics.Raycast(ray, out hit))
        {
            sphere = hit.transform.GetComponent<PalpationTrigger>();
                
            if(sphere != null && Input.GetMouseButtonDown(0))
            {
                //Debug.Log(sphere.sphereNumber);

                if (patientName == "1")
                    palpation = Anamnesis.Palpation1;
                if (patientName == "2")
                    palpation = Anamnesis.Palpation2;
                
                foreach (int number in palpation)
                    {
                        hit.transform.GetComponent<MeshRenderer>().enabled = true;

                        if (number.ToString() == sphere.sphereNumber)
                            hit.transform.GetComponent<MeshRenderer>().material = Red;
                        else 
                            hit.transform.GetComponent<MeshRenderer>().material = Green;
                    }
            }  
        }
    }
}
