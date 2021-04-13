using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPressDoorController : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private bool doorClosed = true;
    public GameObject obj;
    public int Distance = 5;


    void Update()
    {
        if (Vector3.Distance(obj.transform.position, this.transform.position) < Distance)
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
}
