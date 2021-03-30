using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpToHouse : MonoBehaviour
{
    public GameObject spring;
    private Rigidbody character;
    private Vector3 driftPos;
    private Vector3 endPos = new Vector3(303f, 27.5f, -221.12f);
    private float time = 1f;
    private float driftTimer = 0;
    private bool isDrifting = false;

    void Start()
    {
        character = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float dist = FlatDistance(spring.transform.position, character.transform.position);

        if (Input.GetButtonDown("Action") && dist < 2)
        {
            StartDrift();
        }

        if (isDrifting)
        {
            driftTimer += Time.deltaTime;

            if (driftTimer > time)
            {
                EndDrift();
            } 
            else
            {
                float ratio = driftTimer / time;
                transform.position = Vector3.Lerp(driftPos, endPos, ratio);
            }
        }
    }

    private float FlatDistance(Vector3 pos1, Vector3 pos2)
    {
        pos1.y = 0;
        pos2.y = 0;
        return Vector3.Distance(pos1, pos2);
    }

    private void StartDrift()
    {
        isDrifting = true;
        driftTimer = 0;
        driftPos = transform.position;
    }

    private void EndDrift()
    {
        isDrifting = false;
        transform.position = endPos;
    }
}
