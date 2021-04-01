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

    private GameObject textField;
    public Image eventObj1Img;
    public Image eventObj2Img;
    public Image eventObj3Img;
    private int toCollect;

    void Start()
    {
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
    }
}
