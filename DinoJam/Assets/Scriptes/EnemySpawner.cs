using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float timeBtwSpawn;
    public float startTimeBtwSpawn = 5;
    public float decreaseTime;
    public float minTime = 0.65f;
    public int spawnSide;
    void Start()
    {
        spawnSide = Random.Range(0, 4);
    }

    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            if (spawnSide == 0)
            {
                Instantiate(enemy, new Vector3(-15f, Random.Range(-15f, 15f), 0f), Quaternion.identity);
                spawnSide = Random.Range(0, 4);
            }
            if (spawnSide == 1)
            {
                Instantiate(enemy, new Vector3(15f, Random.Range(-15f, 15f), 0f), Quaternion.identity);
                spawnSide = Random.Range(0, 4);
            }
            if (spawnSide == 2)
            {
                Instantiate(enemy, new Vector3(Random.Range(-12, 12), 15f, 0f), Quaternion.identity);
                spawnSide = Random.Range(0, 4);
            }
            if (spawnSide == 3)
            {
                Instantiate(enemy, new Vector3(Random.Range(-12, 12), -15f, 0f), Quaternion.identity);
                spawnSide = Random.Range(0, 4);
            }
            timeBtwSpawn = startTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
