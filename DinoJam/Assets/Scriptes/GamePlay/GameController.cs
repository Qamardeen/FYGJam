using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController gameController;

    public GameObject hudContainer, gameOverPanel;
    public int numOfBosses;
    [SerializeField] TextMeshProUGUI scoreCounter, timeCounter, timeplayed, finalScore;

    public bool gamePlaying { get; private set; }

    private string scoreCounterStr;
    private int enemiesSlain;
    private int bossesSlain;
    private float startTime, elapsedTime;

    TimeSpan timePlaying;

    private void Awake()
    {
        gameController = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        bossesSlain = 0;
        enemiesSlain = 0;
        scoreCounter.text = "Score: " + enemiesSlain;
        gamePlaying = false;

        BeginGame();
    }

    private void Update()
    {
        if (gamePlaying)
        {
            elapsedTime = Time.time - startTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);

            string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
            timeCounter.text = timePlayingStr;
        }
    }

    public void SlayTier1Enemy()
    {
        enemiesSlain++;

        scoreCounterStr = "Score: " + enemiesSlain;
        scoreCounter.text = scoreCounterStr;
    }

    public void SlayBossEnemy()
    {
        bossesSlain++;
        enemiesSlain = enemiesSlain + 100;

        scoreCounterStr = "Score: " + enemiesSlain;
        scoreCounter.text = scoreCounterStr;

        if (bossesSlain >= numOfBosses)
        {
            EndGame();
        }
    }

    public void SlayPlayer()
    {
        EndGame();
    }

    private void BeginGame()
    {
        gamePlaying = true;
        startTime = Time.time;
    }

    private void EndGame()
    {
        gamePlaying = false;
        Invoke("ShowGameOverPanel", 1.25f);
    }

    private void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
        hudContainer.SetActive(false);
        string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
        timeplayed.text = timePlayingStr;
        finalScore.text = scoreCounterStr;
    }
}
