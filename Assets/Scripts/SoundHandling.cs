using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SoundHandling : MonoBehaviour
{
    public Camera cam;
    public static bool soundTurnedOn = true;

    // Update is called once per frame
    void Update()
    {
        //cam.GetComponent<AudioSource>().enabled = soundTurnedOn;
        cam.GetComponent<AudioSource>().enabled = soundTurnedOn;
    }
}
