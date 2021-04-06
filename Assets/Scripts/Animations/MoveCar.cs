using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public float speed = 5f;

    private float rotation;

    void Start()
    {
        rotation = transform.localRotation.eulerAngles.y;
    }

    void FixedUpdate()
    {
        if (rotation == 0 || rotation == 360)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (rotation == 90 || rotation == -270)
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }

        if (rotation == 180 || rotation == -180)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (rotation == -90 || rotation == 270)
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
    }
}
