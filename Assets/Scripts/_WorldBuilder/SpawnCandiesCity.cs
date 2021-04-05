using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Math;

public class SpawnCandiesCity : MonoBehaviour
{
    public static int objectsNumber = 500;
    public GameObject gameObject;
    public Transform parent;

    void Awake()
    {
        RaycastHit hit;
        float randomPositionX, randomPositionY, randomPositionZ;
        float checkRadius = 3f;
        int maxSpawnAttempts = 10;

        Vector3 randomPosition = Vector3.zero;

        int i = 0;

        while (i < objectsNumber)
        {
            bool validPosition = false;
            int spawnAttempts = 0;

            while (!validPosition && spawnAttempts < maxSpawnAttempts)
            {
                spawnAttempts++;

                randomPositionX = Random.Range(12f, 988f);
                randomPositionZ = Random.Range(12f, 988f);
                randomPositionY = 100f;

                randomPosition = new Vector3(randomPositionX, randomPositionY, randomPositionZ);

                if (Physics.Raycast(randomPosition, Vector3.down, out hit, 200.0f))
                {
                    randomPositionY = hit.point.y;

                    if (randomPositionY >= -1 && randomPositionY <= 1)
                    {
                        randomPosition = new Vector3(randomPositionX, randomPositionY + 1f, randomPositionZ);
                        validPosition = true;
                        Collider[] colliders = Physics.OverlapSphere(randomPosition, checkRadius);

                        foreach (Collider col in colliders)
                        {
                            if (col.tag == "Obstacle" || col.tag == "Candy")
                            {
                                validPosition = false;
                            }
                        }
                    }
                    else
                    {
                        validPosition = false;
                    }
                }
            }

            if (validPosition)
            {
                Instantiate(gameObject, randomPosition, Quaternion.Euler(new Vector3(45, Random.Range(0, 360), 0)), parent);
                i++;
            }
        }
    }
}
