using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SoundClick : MonoBehaviour
{
    public GameObject toggle;

    void Start()
    {
        toggle.GetComponent<Toggle>().isOn = !SoundHandling.soundTurnedOn;
    }

    void Update()
    {
        SoundHandling.soundTurnedOn = !toggle.GetComponent<Toggle>().isOn;
    }
}
