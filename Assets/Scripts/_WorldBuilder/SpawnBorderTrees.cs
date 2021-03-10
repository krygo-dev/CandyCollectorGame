using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBorderTrees : MonoBehaviour
{
    public GameObject tree;
    public GameObject smallerTree;
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

                if (positionY < 22)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }

            positionX = -495;
            positionY = 100.0f;
            position = new Vector3(positionX, positionY, positionZ);
            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                if (positionY < 22)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }

            positionX = i;
            positionY = 100.0f;
            positionZ = 495;
            position = new Vector3(positionX, positionY, positionZ);
            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                if (positionY < 22)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }

            positionY = 100.0f;
            positionZ = -495;
            position = new Vector3(positionX, positionY, positionZ);
            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                if (positionY < 22)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
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

                if (positionY < 22)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }

            positionX = -480;
            positionY = 100.0f;
            position = new Vector3(positionX, positionY, positionZ);

            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                if (positionY < 22)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }

            positionX = i;
            positionY = 100.0f;
            positionZ = 480;
            position = new Vector3(positionX, positionY, positionZ);
            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                if (positionY < 22)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }

            positionY = 100.0f;
            positionZ = -480;
            position = new Vector3(positionX, positionY, positionZ);
            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                if (positionY < 22)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
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

                if (positionY < 22)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }

            positionX = -465;
            positionY = 100.0f;
            position = new Vector3(positionX, positionY, positionZ);

            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                if (positionY < 22)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }

            positionX = i;
            positionY = 100.0f;
            positionZ = 465;
            position = new Vector3(positionX, positionY, positionZ);
            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                if (positionY < 22)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }

            positionY = 100.0f;
            positionZ = -465;
            position = new Vector3(positionX, positionY, positionZ);
            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y;

                if (positionY < 22)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }
        }

        // Fourth row
        for (int i = -449; i <= 449; i += 9)
        {
            positionX = 450;
            positionZ = i;
            positionY = 100.0f;
            position = new Vector3(positionX, positionY, positionZ);

            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y - 0.5f;

                if (positionY < 20)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(smallerTree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }

            positionX = -450;
            positionY = 100.0f;
            position = new Vector3(positionX, positionY, positionZ);

            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y - 0.5f;

                if (positionY < 20)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(smallerTree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }

            positionX = i;
            positionZ = 450;
            positionY = 100.0f;
            position = new Vector3(positionX, positionY, positionZ);

            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y - 0.5f;

                if (positionY < 20)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(smallerTree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }

            positionZ = -450;
            positionY = 100.0f;
            position = new Vector3(positionX, positionY, positionZ);

            if (Physics.Raycast(position, Vector3.down, out hit, 200.0f))
            {
                positionY = hit.point.y - 0.5f;

                if (positionY < 20)
                {
                    position = new Vector3(positionX, positionY, positionZ);
                    Instantiate(smallerTree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }
        }
    }
}
