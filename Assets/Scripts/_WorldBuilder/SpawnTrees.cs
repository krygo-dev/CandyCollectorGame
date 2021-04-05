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
        const float vill1X = -305f;
        const float vill1Z = -182f;
        const float vill1Radius = 30;
        const float vill2X = 276f;
        const float vill2Z = -328f;
        const float vill2Radius = 25;
        const float vill3X = 372f;
        const float vill3Z = 333f;
        const float vill3Radius = 40;
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
                if (Pow(randomPositionX - castleCenterX, 2) + Pow(randomPositionZ - castleCenterZ, 2) <= Pow(castleCircleRadius, 2) ||
                    Pow(randomPositionX - vill1X, 2) + Pow(randomPositionZ - vill1Z, 2) <= Pow(vill1Radius, 2) ||
                    Pow(randomPositionX - vill2X, 2) + Pow(randomPositionZ - vill2Z, 2) <= Pow(vill2Radius, 2) ||
                    Pow(randomPositionX - vill3X, 2) + Pow(randomPositionZ - vill3Z, 2) <= Pow(vill3Radius, 2))
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
            }

            if (validPosition)
            {
                Instantiate(gameObject, randomPosition, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                i++;
            }
        }
    }
}
