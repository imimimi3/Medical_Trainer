using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using TMPro;

using StudentsData;

namespace Aid
{
    public class Buttons : MonoBehaviour
    {
        public TextMeshProUGUI notifications;

        public int buttonNumber;

        public bool triger1, triger2, triger3, triger4, triger5, triger6, triger8, triger9, triger10, triger11, triger12;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        void Update()
        {
            
        }
        
        public void onClick()
        {
            if (!Timer.timeOver)
                switch (Answers.numberQuestion)
                {
                    case 0:
                        if(buttonNumber == Questions.rightAnswer[Answers.numberQuestion])
                        {
                            triger1 = true;
                            //Timer.timerEnd = DateTime.Now.AddSeconds(15);
                        }
                        else 
                        {
                            triger1 = false;
                            ResultAid.resultP -= 8;
                        }
                        WriteNotification(Answers.numberQuestion,triger1);
                        Answers.numberQuestion++;
                        break;
                    
                    case 1:
                        if(buttonNumber == Questions.rightAnswer[Answers.numberQuestion])
                        {
                            triger2 = true;
                            //Timer.timerEnd = DateTime.Now.AddSeconds(15);
                        }
                        else 
                        {
                            triger2 = false;
                            ResultAid.resultP -= 8;
                        }
                        WriteNotification(Answers.numberQuestion,triger2);
                        Answers.numberQuestion++;
                        break;
                    
                    case 2:
                        if(buttonNumber == Questions.rightAnswer[Answers.numberQuestion])
                        {
                            triger3 = true;
                            //Timer.timerEnd = DateTime.Now.AddSeconds(15);
                        }
                        else 
                        {
                            triger3 = false;
                            ResultAid.resultP -= 8;
                        }
                        WriteNotification(Answers.numberQuestion,triger3);
                        Answers.numberQuestion++;
                        break;

                    case 3:
                        if(buttonNumber == Questions.rightAnswer[Answers.numberQuestion])
                        {
                            triger4 = true;
                            //Timer.timerEnd = DateTime.Now.AddSeconds(15);
                        }
                        else 
                        {
                            triger4 = false;
                            ResultAid.resultP -= 8;
                        }
                        WriteNotification(Answers.numberQuestion,triger4);
                        Answers.numberQuestion++;
                        break;

                    case 4:
                        if(buttonNumber == Questions.rightAnswer[Answers.numberQuestion])
                        {
                            triger5 = true;
                            //Timer.timerEnd = DateTime.Now.AddSeconds(15);
                        }
                        else 
                        {
                            triger5 = false;
                            ResultAid.resultP -= 8;;
                        }
                        WriteNotification(Answers.numberQuestion,triger5);
                        Answers.numberQuestion++;
                        break;

                    case 5:
                        if(buttonNumber == Questions.rightAnswer[Answers.numberQuestion])
                        {
                            triger6 = true;
                            //Timer.timerEnd = DateTime.Now.AddSeconds(15);
                        }
                        else 
                        {
                            triger6 = false;
                            ResultAid.resultP -= 8;
                        }
                        WriteNotification(Answers.numberQuestion,triger6);
                        Answers.numberQuestion++;
                        break;
                    
                    case 6: EventAid.UIoff();
                    break;
                    
                    case 7:
                        if(buttonNumber == Questions.rightAnswer[Answers.numberQuestion])
                        {
                            triger8 = true;
                            //Timer.timerEnd = DateTime.Now.AddSeconds(15);
                        }
                        else 
                        {
                            triger8 = false;
                            ResultAid.resultP -= 8;
                        }
                        WriteNotification(Answers.numberQuestion,triger8);
                        Answers.numberQuestion++;
                        break;
                    
                    case 8:
                        if(buttonNumber == Questions.rightAnswer[Answers.numberQuestion])
                        {
                            triger9 = true;
                            //Timer.timerEnd = DateTime.Now.AddSeconds(15);
                        }
                        else 
                        {
                            triger9 = false;
                            ResultAid.resultP -= 8;
                        }
                        WriteNotification(Answers.numberQuestion,triger9);
                        Answers.numberQuestion++;
                        break;

                    case 9:
                        if(buttonNumber == Questions.rightAnswer[Answers.numberQuestion])
                        {
                            triger10 = true;
                            //Timer.timerEnd = DateTime.Now.AddSeconds(15);
                        }
                        else 
                        {
                            triger10 = false;
                            ResultAid.resultP -= 8;
                        }
                        WriteNotification(Answers.numberQuestion,triger10);
                        Answers.numberQuestion++;
                        break;

                    case 10:
                        if(buttonNumber == Questions.rightAnswer[Answers.numberQuestion])
                        {
                            triger11 = true;
                            //Timer.timerEnd = DateTime.Now.AddSeconds(15);
                        }
                        else 
                        {
                            triger11 = false;
                            ResultAid.resultP -= 8;
                        }
                        WriteNotification(Answers.numberQuestion,triger11);
                        Answers.numberQuestion++;
                        break;

                    case 11:
                        if(buttonNumber == Questions.rightAnswer[Answers.numberQuestion])
                        {
                            triger12 = true;
                            //Timer.timerEnd = DateTime.Now.AddSeconds(15);
                        }
                        else 
                        {
                            triger12 = false;
                            ResultAid.resultP -= 8;
                        }
                        WriteNotification(Answers.numberQuestion,triger12);

                        Answers.trigerEnd = true;
                        
                        Answers.numberQuestion++;
                        break;
                    
                    default: 
                    break;
                }
        }

        public void WriteNotification(int number, bool triger)
        {
            if (triger)
            {
                notifications.color = Color.green;
                notifications.text = Questions.notificationsR[number];
            }
            else
            {
                notifications.color = Color.red;
                notifications.text = Questions.notificationsF[number];
            }
        }
    }
}