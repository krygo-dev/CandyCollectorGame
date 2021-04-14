using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPressDoorController : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private bool doorClosed = true;
    public GameObject obj;
    public int Distance = 3;


    void Update()
    {

        float doorAndCameraDistance = Vector3.Distance(obj.transform.position, this.transform.position);
        bool areDoorAndCameraAtSameHightLevel = isSameHightLevel(obj.transform.position, this.transform.position);
        
        if (doorAndCameraDistance < Distance && areDoorAndCameraAtSameHightLevel)
        {
            if(Input.GetKeyDown(KeyCode.E))
        {
            if (doorClosed)
            {
                myDoor.Play("OpenDoor", 0, 0.0f);
                doorClosed = !doorClosed;

                //gameObject.SetActive(false);
            }

            else if (!doorClosed)
            {
                myDoor.Play("CloseDoor", 0, 0.0f);
                doorClosed = !doorClosed;

                //gameObject.SetActive(false);
            }
        }
        }
    }

    private bool isSameHightLevel(Vector3 pos1, Vector3 pos2)
    {
        if (pos1.y - pos2.y < -1.5f || pos1.y - pos2.y > 1.5f)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
