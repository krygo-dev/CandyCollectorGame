using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBorderTrees : MonoBehaviour
{
    public GameObject gameObject;
    public Transform parent;

    void Awake()
    {
        RaycastHit hit;
        float positionX, positionY, positionZ;
        Vector3 position;

        // First row
        for (int i = -500; i < 500; i += 20)
        {
            positionX = 495;
            positionZ = i;
            positionY = 100.0f;
            position = new Vector3(positionX, positionY, positionZ);

            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                position = new Vector3(positionX, positionY, positionZ);
                Instantiate(gameObject, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
            }

            positionX = -495;
            positionY = 100.0f;
            position = new Vector3(positionX, positionY, positionZ);
            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                position = new Vector3(positionX, positionY, positionZ);
                Instantiate(gameObject, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
            }

            positionX = i;
            positionY = 100.0f;
            positionZ = 495;
            position = new Vector3(positionX, positionY, positionZ);
            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                position = new Vector3(positionX, positionY, positionZ);
                Instantiate(gameObject, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
            }

            positionY = 100.0f;
            positionZ = -495;
            position = new Vector3(positionX, positionY, positionZ);
            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                position = new Vector3(positionX, positionY, positionZ);
                Instantiate(gameObject, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
            }
        }

        // Second row
        for (int i = -475; i < 475; i += 20)
        {
            positionX = 480;
            positionZ = i;
            positionY = 100.0f;
            position = new Vector3(positionX, positionY, positionZ);

            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                position = new Vector3(positionX, positionY, positionZ);
                Instantiate(gameObject, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
            }

            positionX = -480;
            positionY = 100.0f;
            position = new Vector3(positionX, positionY, positionZ);

            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                position = new Vector3(positionX, positionY, positionZ);
                Instantiate(gameObject, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
            }

            positionX = i;
            positionY = 100.0f;
            positionZ = 480;
            position = new Vector3(positionX, positionY, positionZ);
            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                position = new Vector3(positionX, positionY, positionZ);
                Instantiate(gameObject, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
            }

            positionY = 100.0f;
            positionZ = -480;
            position = new Vector3(positionX, positionY, positionZ);
            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                position = new Vector3(positionX, positionY, positionZ);
                Instantiate(gameObject, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
            }
        }

        // Third row
        for (int i = -460; i < 460; i += 20)
        {
            positionX = 465;
            positionZ = i;
            positionY = 100.0f;
            position = new Vector3(positionX, positionY, positionZ);

            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                position = new Vector3(positionX, positionY, positionZ);
                Instantiate(gameObject, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
            }

            positionX = -465;
            positionY = 100.0f;
            position = new Vector3(positionX, positionY, positionZ);

            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                position = new Vector3(positionX, positionY, positionZ);
                Instantiate(gameObject, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
            }

            positionX = i;
            positionY = 100.0f;
            positionZ = 465;
            position = new Vector3(positionX, positionY, positionZ);
            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                position = new Vector3(positionX, positionY, positionZ);
                Instantiate(gameObject, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
            }

            positionY = 100.0f;
            positionZ = -465;
            position = new Vector3(positionX, positionY, positionZ);
            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                position = new Vector3(positionX, positionY, positionZ);
                Instantiate(gameObject, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
            }
        }
    }
}
