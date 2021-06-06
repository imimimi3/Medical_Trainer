using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using Anamn;
using TMPro;

namespace Anamn
{
    public class AnamnesisT : MonoBehaviour
    {
        public static void AnamnesisT_1(int value)
        {
            GameObject tPlan;
            GameObject tAnamn;

            tPlan = GameObject.Find("TextPlan");
            tAnamn = GameObject.Find("TextAnamnesis");

            tAnamn.GetComponent<TextMeshProUGUI>().text += Anamnesis.valueSt1[value];

            tPlan.GetComponent<TextMeshProUGUI>().text = tAnamn.GetComponent<TextMeshProUGUI>().text;
        }

        public static void AnamnesisT_2(int value)
        {
            GameObject tPlan;
            GameObject tAnamn;

            tPlan = GameObject.Find("TextPlan");
            tAnamn = GameObject.Find("TextAnamnesis");

            tAnamn.GetComponent<TextMeshProUGUI>().text += Anamnesis.valueSt2[value];

            tPlan.GetComponent<TextMeshProUGUI>().text = tAnamn.GetComponent<TextMeshProUGUI>().text;
        }
    }
}