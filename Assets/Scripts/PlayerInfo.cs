using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    public static int collectedCandy = 0;
    public static bool eventObj1 = false;
    public static bool eventObj2 = false;
    public static bool eventObj3 = false;

    public Image eventObj1Img;
    public Image eventObj2Img;
    public Image eventObj3Img;
    public GameObject panel;

    private GameObject textField;
    private int toCollect;
    private bool objectsCollected = false;

    void Start()
    {
        collectedCandy = 0;
        eventObj1 = false;
        eventObj2 = false;
        eventObj3 = false;
        toCollect = SpawnCandies.objectsNumber;

        textField = GameObject.Find("Collected");
        textField.GetComponent<Text>().text = collectedCandy.ToString() + " / " + toCollect.ToString();

        eventObj1Img.enabled = false;
        eventObj2Img.enabled = false;
        eventObj3Img.enabled = false;
    }

    void Update()
    {
        textField.GetComponent<Text>().text = collectedCandy.ToString() + " / " + toCollect.ToString();

        if (eventObj1 && eventObj1Img.enabled == false)
        {
            eventObj1Img.enabled = true;
        }

        if (eventObj2 && eventObj2Img.enabled == false)
        {
            eventObj2Img.enabled = true;
        }

        if (eventObj3 && eventObj3Img.enabled == false)
        {
            eventObj3Img.enabled = true;
        }

        if (!objectsCollected && eventObj1 && eventObj2 && eventObj3)
        {
            // Nagroda za zebranie wszystkich trzech obiektów eventowych (do przemyślenia jeszcze)
            collectedCandy += 200;
            objectsCollected = true;
        }

        if (collectedCandy >= toCollect)
        {
            Debug.Log("Victory");
            panel.SetActive(true);
            Time.timeScale = 0f;
            ShowMenu.gamePaused = true;
        }
    }
}
