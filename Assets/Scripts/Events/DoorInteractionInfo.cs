using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorInteractionInfo : MonoBehaviour
{

    public GameObject panel;
    public GameObject eventObj;
    public string textToShow = "Text";
    public int Distance = 5;


    void Update()
    {
        if (eventObj == null)
        {
            panel.GetComponent<Text>().text = "";
        }


        if (panel != null && eventObj != null)
        {
            if (Vector3.Distance(eventObj.transform.position, this.transform.position) < Distance)
            {
                panel.GetComponent<Text>().text = textToShow;
            } 
            else
            {
                panel.GetComponent<Text>().text = "";
            }
        }
    }
}
