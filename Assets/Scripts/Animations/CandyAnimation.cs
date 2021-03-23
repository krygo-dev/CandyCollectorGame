using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyAnimation : MonoBehaviour
{
    public float speed = 5f;
    public float height = 0.5f;
    public float rotationSpeed = 20;

    Vector3 pos;

    private void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        float newY = Mathf.Sin(Time.time * speed) * height + pos.y;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        transform.RotateAround(pos, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
