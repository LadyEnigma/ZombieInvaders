using UnityEngine;
using System.Collections;

public class SpawnObjects : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnWidth;
    public float spawnHeight;
    public int numberOfEnemiesX;
    public int numberOfEnemiesY;

    void Start()
    {
        for (int i = 0; i < numberOfEnemiesX; i++)
        {
            for (int j = 0; j < numberOfEnemiesY; j++)
            {
                Vector3 spawnPosition = transform.position;
                spawnPosition.x += i * (spawnWidth / numberOfEnemiesX);
                spawnPosition.y += j * (spawnHeight / numberOfEnemiesY);
                GameObject newObject = Instantiate (objectToSpawn, spawnPosition, transform.rotation) as GameObject;
                newObject.transform.parent = gameObject.transform;
            }
        }
    }

    void Update()
    {
        if (transform.childCount == 0)
        {
            Start ();
        }
    }

    void OnDrawGizmos()
    {
        for (int i = 0; i < numberOfEnemiesX; i++)
        {
            for (int j = 0; j < numberOfEnemiesY; j++)
            {
                Vector3 spawnPosition = transform.position;
                spawnPosition.x += i * (spawnWidth / numberOfEnemiesX);
                spawnPosition.y += j * (spawnHeight / numberOfEnemiesY);
                Gizmos.DrawLine (spawnPosition + Vector3.left, spawnPosition + Vector3.right);
                Gizmos.DrawLine (spawnPosition + Vector3.up, spawnPosition + Vector3.down);
                Gizmos.DrawLine (spawnPosition + Vector3.forward, spawnPosition + Vector3.back);
            }
        }
    }
}
