using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using TMPro;

using StudentsData;

namespace Aid
{
    public class Answers : MonoBehaviour
    {
        public static bool trigerStart = false, trigerEnd = false;

        public TextMeshProUGUI quectionText;
        public TextMeshProUGUI text1;
        public TextMeshProUGUI text2;
        public TextMeshProUGUI text3;
        public TextMeshProUGUI text4;

        public TextMeshProUGUI notifications;

        public static int numberQuestion = 0;
        // Start is called before the first frame update
        void Start()
        {
            //notifications.text = "";
        }

        // Update is called once per frame
        void Update()
        {
            if(trigerStart)
            {
                Question1();
            }

            if (!Timer.timeOver)
                switch (numberQuestion)
                {
                    case 1:  Question2();
                    break;

                    case 2:  Question3();
                    break;

                    case 3:  Question4();
                    break;

                    case 4:  Question5();
                    break;

                    case 5:  Question6();
                    break;

                    case 6:  Question7();
                    if (ModelAid.trigerModel == 1)
                        {
                            notifications.color = Color.green;
                            notifications.text = Questions.notificationsR[numberQuestion];

                            Answers.numberQuestion++;

                            //ResultAid.resultP;
                            EventAid.UIon();
                        }
                        else if(ModelAid.trigerModel == 0)
                        {
                            notifications.color = Color.red;
                            notifications.text = Questions.notificationsF[numberQuestion];

                            Answers.numberQuestion++;

                            ResultAid.resultP -= 12;
                            EventAid.UIon();
                        }
                        
                    break;

                    case 7:  Question8();
                    break;

                    case 8:  Question9();
                    break;

                    case 9:  Question10();
                    break;

                    case 10:  Question11();
                    break;

                    case 11:  Question12();
                    break;


                    default:
                        if(trigerEnd)
                        {
                            notifications.text = "Поздравляем, вы спасли пострадавшего";
                            
                            quectionText.text = "";
                            text1.text = "";
                            text2.text = "";
                            text3.text = "";
                            text4.text = "";

                        }
                    break;
                }
            else
                notifications.text = "Время вышло, вы не успели";
        }

        bool on1 = false;
        void Question1()
        {
            if(!on1)
            {
                quectionText.text = Questions.questionsA[0];
                text1.text = Questions.answer1[0];
                text2.text = Questions.answer1[1];
                text3.text = Questions.answer1[2];
                text4.text = Questions.answer1[3];

                EventAid.UIon();

                on1 = true;

                //numberQuestion++;
            }
        }

        void Question2()
        {
            quectionText.text = Questions.questionsA[1];
            text1.text = Questions.answer2[0];
            text2.text = Questions.answer2[1];
            text3.text = Questions.answer2[2];
            text4.text = Questions.answer2[3];

            //EventAid.UIon();
        }

        void Question3()
        {
            quectionText.text = Questions.questionsA[2];
            text1.text = Questions.answer3[0];
            text2.text = Questions.answer3[1];
            text3.text = Questions.answer3[2];
            text4.text = Questions.answer3[3];

            //EventAid.UIon();
        }

        void Question4()
        {
            quectionText.text = Questions.questionsA[3];
            text1.text = Questions.answer4[0];
            text2.text = Questions.answer4[1];
            text3.text = Questions.answer4[2];
            text4.text = Questions.answer4[3];

            //EventAid.UIon();
        }

        void Question5()
        {
            quectionText.text = Questions.questionsA[4];
            text1.text = Questions.answer5[0];
            text2.text = Questions.answer5[1];
            text3.text = Questions.answer5[2];
            text4.text = Questions.answer5[3];

            //EventAid.UIon();
        }
        void Question6()
        {
            quectionText.text = Questions.questionsA[5];
            text1.text = Questions.answer6[0];
            text2.text = Questions.answer6[1];
            text3.text = Questions.answer6[2];
            text4.text = Questions.answer6[3];

            //EventAid.UIon();
        }
        void Question7()
        {
            quectionText.text = Questions.questionsA[6];
            text1.text = Questions.answer7[0];
            text2.text = Questions.answer7[1];
            text3.text = Questions.answer7[2];
            text4.text = Questions.answer7[3];

            //EventAid.UIon();
        }

        void Question8()
        {
            quectionText.text = Questions.questionsA[7];
            text1.text = Questions.answer8[0];
            text2.text = Questions.answer8[1];
            text3.text = Questions.answer8[2];
            text4.text = Questions.answer8[3];

            //EventAid.UIon();
        }

        void Question9()
        {
            quectionText.text = Questions.questionsA[8];
            text1.text = Questions.answer9[0];
            text2.text = Questions.answer9[1];
            text3.text = Questions.answer9[2];
            text4.text = Questions.answer9[3];

            //EventAid.UIon();
        }

        void Question10()
        {
            quectionText.text = Questions.questionsA[9];
            text1.text = Questions.answer10[0];
            text2.text = Questions.answer10[1];
            text3.text = Questions.answer10[2];
            text4.text = Questions.answer10[3];

            //EventAid.UIon();
        }

        void Question11()
        {
            quectionText.text = Questions.questionsA[10];
            text1.text = Questions.answer11[0];
            text2.text = Questions.answer11[1];
            text3.text = Questions.answer11[2];
            text4.text = Questions.answer11[3];

            //EventAid.UIon();
        }

        void Question12()
        {
            quectionText.text = Questions.questionsA[11];
            text1.text = Questions.answer12[0];
            text2.text = Questions.answer12[1];
            text3.text = Questions.answer12[2];
            text4.text = Questions.answer12[3];

            //EventAid.UIon();
        }
    }
}