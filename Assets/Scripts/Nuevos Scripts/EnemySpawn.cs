using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EnemySpawn : MonoBehaviour
{
    private float minX, maxX, minY, maxY;
    [SerializeField] private Transform[] coords;
    [SerializeField] private GameObject[] enemies;
    [SerializeField] private float EnemyTime;
    private float TimeLapse;

    // Start is called before the first frame update
    void Start()
    {
        maxX = coords.Max(coord => coord.position.x);
        minX = coords.Min(coord => coord.position.x);
        maxY = coords.Max(coord => coord.position.y);
        minY = coords.Min(coord => coord.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        TimeLapse = TimeLapse + Time.deltaTime;

        if(TimeLapse >= EnemyTime)
        {
            TimeLapse = 0;
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        int enemyNumber = Random.Range(0, enemies.Length);
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY));

        Instantiate(enemies[enemyNumber], randomPosition, Quaternion.identity);
    }
}
