using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityBorderTrees : MonoBehaviour
{
    public GameObject tree;
    public GameObject smallerTree;
    public Transform parent;

    void Awake()
    {
        RaycastHit hit;
        float positionX, positionY, positionZ;
        int maxSpawnY = 22;
        Vector3 position;

        // First row
        for (int i = 0; i < 1000; i += 3)
        {
            positionX = 0;
            positionZ = i;
            positionY = -0.1f;
            position = new Vector3(positionX, positionY, positionZ);
            Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);

            positionX = 1000;
            positionZ = i;
            positionY = -0.1f;
            position = new Vector3(positionX, positionY, positionZ);
            Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);

            positionX = i;
            positionY = -0.1f;
            positionZ = 0;
            position = new Vector3(positionX, positionY, positionZ);
            Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);

            positionX = i;
            positionY = -0.1f;
            positionZ = 1000;
            position = new Vector3(positionX, positionY, positionZ);
            Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
        }

        // Second row
        for (int i = 3; i < 997; i += 3)
        {
            positionX = 3;
            positionZ = i;
            positionY = -0.1f;
            position = new Vector3(positionX, positionY, positionZ);
            Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);

            positionX = 997;
            positionZ = i;
            positionY = -0.1f;
            position = new Vector3(positionX, positionY, positionZ);
            Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);

            positionX = i;
            positionY = -0.1f;
            positionZ = 3;
            position = new Vector3(positionX, positionY, positionZ);
            Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);

            positionX = i;
            positionY = -0.1f;
            positionZ = 997;
            position = new Vector3(positionX, positionY, positionZ);
            Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
        }

        // Third row
        for (int i = 7; i < 993; i += 3)
        {
            positionX = 7;
            positionZ = i;
            positionY = -0.1f;
            position = new Vector3(positionX, positionY, positionZ);
            Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);

            positionX = 993;
            positionZ = i;
            positionY = -0.1f;
            position = new Vector3(positionX, positionY, positionZ);
            Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);

            positionX = i;
            positionY = -0.1f;
            positionZ = 7;
            position = new Vector3(positionX, positionY, positionZ);
            Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);

            positionX = i;
            positionY = -0.1f;
            positionZ = 993;
            position = new Vector3(positionX, positionY, positionZ);
            Instantiate(tree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
        }

        // Fourth row
        for (int i = 10; i < 990; i += 3)
        {
            positionX = 10;
            positionZ = i;
            positionY = -0.1f;
            position = new Vector3(positionX, positionY, positionZ);
            Instantiate(smallerTree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);

            positionX = 990;
            positionZ = i;
            positionY = -0.1f;
            position = new Vector3(positionX, positionY, positionZ);
            Instantiate(smallerTree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);

            positionX = i;
            positionY = -0.1f;
            positionZ = 10;
            position = new Vector3(positionX, positionY, positionZ);
            Instantiate(smallerTree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);

            positionX = i;
            positionY = -0.1f;
            positionZ = 990;
            position = new Vector3(positionX, positionY, positionZ);
            Instantiate(smallerTree, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
        }
    }
}
