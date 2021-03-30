using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    public static int collectedCandy = 0;
    private GameObject textField;
    private int toCollect;

    void Start()
    {
        toCollect = SpawnCandies.objectsNumber;
        textField = GameObject.Find("Collected");
        textField.GetComponent<Text>().text = collectedCandy.ToString() + " / " + toCollect.ToString();
    }

    void Update()
    {
        textField.GetComponent<Text>().text = collectedCandy.ToString() + " / " + toCollect.ToString();
    }
}
