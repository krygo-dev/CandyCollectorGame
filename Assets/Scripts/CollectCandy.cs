using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCandy : MonoBehaviour
{
    private int itemCount = 0;
    private GameObject textField;
    private int toCollect;

    void Start()
    {
        toCollect = SpawnCandies.objectsNumber;
        textField = GameObject.Find("Collected");
        textField.GetComponent<Text>().text = itemCount.ToString() + " / " + toCollect.ToString();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Candy")
        {
            Destroy(col.gameObject);
            itemCount++;
            textField.GetComponent<Text>().text = itemCount.ToString() + " / " + toCollect.ToString();
            Debug.Log(itemCount);
        }
    }

}
