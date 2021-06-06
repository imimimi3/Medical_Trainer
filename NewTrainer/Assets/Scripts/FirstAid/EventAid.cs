using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using TMPro;
//using Anamn;

//using DialogueSystem;

namespace Aid
{
    public class EventAid : MonoBehaviour
    {
        static GameObject player;

        static GameObject hud;
        GameObject instruction;
        static GameObject notifications;
            
        void Start()
        {
            player = GameObject.Find("Player");
            
            hud = GameObject.Find("QuestionsMenu");
            //hud.SetActive(false);
            hud.transform.position += new Vector3(2500, 0, 0);

            // Выключаем курсор и делаем его невидимым
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            player.GetComponent<PlayerMovement>().enabled = false;

            instruction = GameObject.Find("Instruction");

            notifications =  GameObject.Find("TextNotification");
            notifications.transform.position += new Vector3(2500, 0, 0);
        }

        static bool touch = false;

        void Update()
        {
                if (Input.GetMouseButtonDown(1) && !touch)
                {
                    UIon();
                }
                else
                    if (Input.GetMouseButtonDown(1) && touch)
                    {
                        UIoff();
                    }
        }

        public void OnInstruction()
        {
            instruction.SetActive(false);

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            player.GetComponent<PlayerMovement>().enabled = true;
            
            notifications.GetComponent<TextMeshProUGUI>().text = "";
        }

        public static void UIon()
        {
            hud.transform.position += new Vector3(-2500, 0, 0);

            notifications.transform.position += new Vector3(-2500, 0, 0);

            // Включаем курсор и делаем его видимым
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            player.GetComponent<PlayerMovement>().enabled = false;

            touch = true;
        }

        public static void UIoff()
        {
            hud.transform.position += new Vector3(2500, 0, 0);

            notifications.transform.position += new Vector3(2500, 0, 0);

            // Выключаем курсор и делаем его невидимым
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            player.GetComponent<PlayerMovement>().enabled = true;   

            touch = false;
        }
    }
}