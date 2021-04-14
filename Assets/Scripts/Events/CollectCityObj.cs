using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCityObj : MonoBehaviour
{
    public GameObject eventObj;
    public GameObject panel;

    void Update()
    {
        if (eventObj != null)
        {
            float dist = Vector3.Distance(eventObj.transform.position, this.transform.position);

            if (Input.GetButtonDown("Action") && dist < 3)
            {
                if (eventObj.tag == "Pizza")
                {
                    PlayerInfo.eventObj1 = true;
                }

                if (eventObj.tag == "HotDog")
                {
                    PlayerInfo.eventObj2 = true;
                }

                if (eventObj.tag == "Fries")
                {
                    PlayerInfo.eventObj3 = true;
                }

                Destroy(eventObj);
                Destroy(panel);
            }
        }
    }
}
