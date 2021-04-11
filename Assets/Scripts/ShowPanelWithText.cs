using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPanelWithText : MonoBehaviour
{
    public enum TextWariant
    {
        Press,
        Hold
    }

    public TextWariant textWariant;
    public GameObject panel;
    public Text panelInfoText;

    private GameObject player;    

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        panel.SetActive(false);
    }


    void Update()
    {
        panel.SetActive(false);
        float distance = Vector3.Distance(player.transform.position, this.transform.position);

        if (this != null && distance < 3f)
        {
            if (textWariant.ToString() == "Press")
            {
                panel.SetActive(true);
                panelInfoText.GetComponent<Text>().text = "Press E";
            }
            else if (textWariant.ToString() == "Hold")
            {
                panel.SetActive(true);
                panelInfoText.GetComponent<Text>().text = "Hold E";
            }
        }
    }
}
