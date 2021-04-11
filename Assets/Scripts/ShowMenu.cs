using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMenu : MonoBehaviour
{
    public GameObject panel;

    private bool menuShown;
    
    void Start()
    {
        panel.SetActive(false);
        menuShown = false;
    }

    void Update()
    {
        if (Input.GetButton("Cancel") && !menuShown)
        {
            menuShown = true;
            //panel.SetActive(true);
        } 
        else if (Input.GetButton("Cancel") && menuShown)
        {
            menuShown = false;
            //panel.SetActive(false);
        }

        panel.SetActive(menuShown);
    }
}
