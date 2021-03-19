using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Math;

public class SpawnTrees : MonoBehaviour
{
    public int objectsNumber = 3000;
    public GameObject gameObject;
    public Transform parent;

    void Awake()
    {
        RaycastHit hit;
        float randomPositionX, randomPositionY, randomPositionZ;
        float checkRadius = 3f;
        const float castleCenterX = -178f;
        const float castleCenterZ = 262.5f;
        const float castleCircleRadius = 30;
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

                randomPositionX = Random.Range(-440.0f, 440.0f);
                randomPositionZ = Random.Range(-440.0f, 440.0f);
                randomPositionY = 100.0f;

                // Check if (X, Z) in Castle circle
                if (Pow(randomPositionX - castleCenterX, 2) + Pow(randomPositionZ - castleCenterZ, 2) <= Pow(castleCircleRadius, 2))
                {
                    validPosition = false;
                } 
                else
                {
                    randomPosition = new Vector3(randomPositionX, randomPositionY, randomPositionZ);

                    if (Physics.Raycast(randomPosition, Vector3.down, out hit, 200.0f))
                    {
                        randomPositionY = hit.point.y - 0.6f;

                        if (randomPositionY >= -1 && randomPositionY <= 42)
                        {
                            randomPosition = new Vector3(randomPositionX, randomPositionY, randomPositionZ);
                            validPosition = true;
                            Collider[] colliders = Physics.OverlapSphere(randomPosition, checkRadius);

                            foreach (Collider col in colliders)
                            {
                                if (col.tag == "Obstacle")
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
            }

            if (validPosition)
            {
                Instantiate(gameObject, randomPosition, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                i++;
            }
        }
    }
}
