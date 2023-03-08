using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject hazard;
    public Vector3 spawnValues;

    void Update()
    {
        if(Input.GetButtonDown("Fire3"))
        {
            SpawnEnemies();
        }
    }

    void SpawnEnemies()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
        Instantiate(hazard, spawnPosition, Quaternion.identity);
    }
}
