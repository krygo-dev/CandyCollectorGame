using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrees : MonoBehaviour
{
    public int objectsNumber = 3000;
    public GameObject gameObject;
    public Transform parent;

    void Awake()
    {
        RaycastHit hit;
        float randomPositionX, randomPositionY, randomPositionZ;
        Vector3 randomPosition;

        int i = 0;

        while (i < objectsNumber)
        {
            randomPositionX = Random.Range(-440.0f, 440.0f);
            randomPositionZ = Random.Range(-440.0f, 440.0f);
            randomPositionY = 100.0f;

            if (randomPositionX > -386 && randomPositionX < -142 && randomPositionZ > -13 && randomPositionZ < 337)
            {
                continue;
            }
            else
            {
                randomPosition = new Vector3(randomPositionX, randomPositionY, randomPositionZ);

                if (Physics.Raycast(randomPosition, Vector3.down, out hit, 200.0f))
                {
                    randomPositionY = hit.point.y - 0.6f;

                    if (randomPositionY >= -1 && randomPositionY <= 22)
                    {
                        randomPosition = new Vector3(randomPositionX, randomPositionY, randomPositionZ);
                        Instantiate(gameObject, randomPosition, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                    }
                }

                i++;
            }
        }
    }
}
