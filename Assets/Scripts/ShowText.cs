using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{

    public GameObject textField;
    public GameObject obj;
    public string textToShow = "Text";

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    void Update()
    {
        if (textField != null && obj != null)
        {
            if (Vector3.Distance(obj.transform.position, this.transform.position) < 5)
            {
                textField.GetComponent<Text>().text = textToShow;
            } 
            else
            {
                textField.GetComponent<Text>().text = "";
            }
        }
    }
}
