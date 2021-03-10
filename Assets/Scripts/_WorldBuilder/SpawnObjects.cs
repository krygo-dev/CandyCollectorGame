using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public int objectsNumber = 3000;
    public GameObject gameObject;
    public Transform parent;

    void Awake()
    {
        RaycastHit hit;
        float randomPositionX, randomPositionY, randomPositionZ;
        Vector3 randomPosition;

        for (int i = 0; i < objectsNumber; i++)
        {
            randomPositionX = Random.Range(-440.0f, 440.0f);
            randomPositionZ = Random.Range(-440.0f, 440.0f);
            randomPositionY = 100.0f;

            randomPosition = new Vector3(randomPositionX, randomPositionY, randomPositionZ);

            if (Physics.Raycast(randomPosition, Vector3.down, out hit, 200.0f))
            {
                randomPositionY = hit.point.y;

                if (randomPositionY >= -1 && randomPositionY <= 22)
                {
                    randomPosition = new Vector3(randomPositionX, randomPositionY, randomPositionZ);

                    // No rotation, object perfectly aligned with with world or parent axes
                    //Instantiate(gameObject, randomPosition, Quaternion.identity);

                    // Random Y rotation, looks more realistic
                    //gameObject.AddComponent<MeshCollider>(); //collision
                    Instantiate(gameObject, randomPosition, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), parent);
                }
            }
        }
    }
}
