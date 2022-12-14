using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public float timeBtwSpawn;
    public float startTimeBtwSpawn = 5;
    public float decreaseTime;
    public float minTime = 0.65f;

    private int spawnSide;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        spawnSide = Random.Range(0, 4);
    }

    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            if (spawnSide == 0)
            {
                Instantiate(enemy, new Vector3(player.transform.position.x - 35f, player.transform.position.y + Random.Range(-25f, 25f), 0f), Quaternion.identity);
                spawnSide = Random.Range(0, 4);
            }
            if (spawnSide == 1)
            {
                Instantiate(enemy, new Vector3(player.transform.position.x + 35f, player.transform.position.y + Random.Range(-25f, 25f), 0f), Quaternion.identity);
                spawnSide = Random.Range(0, 4);
            }
            if (spawnSide == 2)
            {
                Instantiate(enemy, new Vector3(player.transform.position.x + Random.Range(-22, 22), player.transform.position.y + 25f, 0f), Quaternion.identity);
                spawnSide = Random.Range(0, 4);
            }
            if (spawnSide == 3)
            {
                Instantiate(enemy, new Vector3(player.transform.position.x + Random.Range(-22, 22), player.transform.position.y - 25f, 0f), Quaternion.identity);
                spawnSide = Random.Range(0, 4);
            }
            if (startTimeBtwSpawn >= minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }
            timeBtwSpawn = startTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }

        if (GameController.gameController.gameOver)
        {
            Destroy(this);
        }
    }
}
