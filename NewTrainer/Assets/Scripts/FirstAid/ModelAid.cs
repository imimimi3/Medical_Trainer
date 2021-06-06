using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using TMPro;
using Anamn;

namespace Aid
{
    public class ModelAid : MonoBehaviour
    {
        public Camera cameraTop;
        public Camera cameraLeft;
        public Camera cameraRight;

        GameObject mainCamera;

        GameObject player;
        
        void Start()
        {
            cameraTop.enabled = false;
            cameraLeft.enabled = false;
            cameraRight.enabled = false;

            mainCamera = GameObject.Find("Main Camera");

            player = GameObject.Find("Player");
        }

        bool onModel = false;

        public static int trigerModel = 2;

        void Update()
        {
            if(!onModel)
                ModelOn();
            else
            {
                MoveCamera();
                
                if (trigerModel == 2)
                    Point();

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

        ModelAidTrigger model;
        RaycastHit hit;
        Ray ray;

        public void ModelOn()
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit) && !onModel)
            {
                model = hit.transform.GetComponent<ModelAidTrigger>();
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

        string cameraNow = ""; 

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

        public Material Red;
        public Material Green;

        SphereN sphere;

        void Point()
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
                sphere = hit.transform.GetComponent<SphereN>();
                    
                if(sphere != null && Input.GetMouseButtonDown(0))
                {
                    if (sphere.sphereT)
                    {
                        trigerModel = 1;
                        hit.transform.GetComponent<MeshRenderer>().material = Green;
                    }
                    else 
                    {
                        hit.transform.GetComponent<MeshRenderer>().material = Red;
                        trigerModel = 0;
                    }
                }  
            }
        }
    }
}
