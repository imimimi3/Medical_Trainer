using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnamnesisButton : MonoBehaviour
{
    GameObject tAnamn;

    void Start()
    {
        tAnamn = GameObject.Find("TextAnamnesis");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool anamOnClick = false;

        public void AnamnesisOn()
        {
            if (!anamOnClick)
            {
                //tAnam.SetActive(true);
                tAnamn.transform.position += new Vector3(-2500, 0, 0);
                anamOnClick = true;
            }
            else
            {
                //tAnam.SetActive(false);
                tAnamn.transform.position += new Vector3(2500, 0, 0);
                anamOnClick = false;
            }
        } 
}
