using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCandy : MonoBehaviour
{
    private int itemCount = 0;
    
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Candy")
        {
            Destroy(col.gameObject);
            itemCount++;
            Debug.Log(itemCount);
        }
    }

}
