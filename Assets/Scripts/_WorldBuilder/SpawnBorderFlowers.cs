using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBorderFlowers : MonoBehaviour
{
    public GameObject flower;
    public Transform parent;

    void Awake()
    {
        RaycastHit hit;
        float positionX, positionY, positionZ;
        int maxSpawnY = 12;
        Vector3 position;

        // First row
        for (int i = -500; i < 490; i += 15)
        {
            positionX = 495;
            positionZ = i;
            positionY = 100.0f;
            position = new Vector3(positionX, positionY, positionZ);

            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y - 5f;

                if (positionY < maxSpawnY)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(flower, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }

            positionX = -495;
            positionY = 100.0f;
            position = new Vector3(positionX, positionY, positionZ);
            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y - 5f;

                if (positionY < maxSpawnY)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(flower, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }

            positionX = i;
            positionY = 100.0f;
            positionZ = 495;
            position = new Vector3(positionX, positionY, positionZ);
            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y - 5f;

                if (positionY < maxSpawnY)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(flower, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }

            positionY = 100.0f;
            positionZ = -495;
            position = new Vector3(positionX, positionY, positionZ);
            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y - 5f;

                if (positionY < maxSpawnY)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(flower, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }
        }

        // Second row
        for (int i = -475; i < 460; i += 15)
        {
            positionX = 475;
            positionZ = i;
            positionY = 100.0f;
            position = new Vector3(positionX, positionY, positionZ);

            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y - 5f;

                if (positionY < maxSpawnY)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(flower, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }

            positionX = -475;
            positionY = 100.0f;
            position = new Vector3(positionX, positionY, positionZ);

            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y - 5f;

                if (positionY < maxSpawnY)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(flower, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }

            positionX = i;
            positionY = 100.0f;
            positionZ = 475;
            position = new Vector3(positionX, positionY, positionZ);
            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y - 5f;

                if (positionY < maxSpawnY)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(flower, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }

            positionY = 100.0f;
            positionZ = -475;
            position = new Vector3(positionX, positionY, positionZ);
            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y - 5f;

                if (positionY < maxSpawnY)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(flower, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }
        }
    }
}

