using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityParkFlowers : MonoBehaviour
{
    public int objectsNumber = 20;
    public GameObject gameObject;
    public Transform parent;

    void Awake()
    {
        float checkRadius = 3f;
        int maxSpawnAttempts = 10;
        float randomPositionX, randomPositionZ;
        Vector3 randomPosition = Vector3.zero;
        int i = 0;

        while  (i < objectsNumber)
        {
            bool validPosition = false;
            int spawnAttempts = 0;

            while (!validPosition && spawnAttempts < maxSpawnAttempts)
            {
                spawnAttempts++;

                randomPositionX = Random.Range(552f, 632f);
                randomPositionZ = Random.Range(653f, 673f);

                randomPosition = new Vector3(randomPositionX, 0.4f, randomPositionZ);

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

            if (validPosition)
            {
                Instantiate(gameObject, randomPosition, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                i++;
            }
        }
    }
}
