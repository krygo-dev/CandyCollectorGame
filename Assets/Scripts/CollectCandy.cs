using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCandy : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Candy")
        {
            Destroy(col.gameObject);
            PlayerInfo.collectedCandy++;
        }
    }

}
