using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineClimbing : MonoBehaviour
{
    public GameObject line;
    public GameObject panel;

    private Transform character;

    void Start()
    {
        character = GetComponent<Transform> ();
        panel.SetActive(false);
    }

    void Update()
    {
        panel.SetActive(false);
        float dist = FlatDistance(line.transform.position, character.transform.position);

        if (dist < 3f)
        {
            panel.SetActive(true);
        }

        if (Input.GetButton("Action") && dist < 1)
        {
            character.Translate(Vector3.up * Time.deltaTime * 25);
        }

        if (Input.GetButton("Action") && character.transform.position.y > 29)
        {
            character.Translate(Vector3.forward * Time.deltaTime * 10);
        }
    }

    private float FlatDistance(Vector3 pos1, Vector3 pos2)
    {
        pos1.y = 0;
        pos2.y = 0;
        return Vector3.Distance(pos1, pos2);
    }
}
