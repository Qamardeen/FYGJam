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
    [SerializeField] TextMeshProUGUI scoreCounter, timeCounter;

    public bool gamePlaying { get; private set; }

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
        gamePlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SlayTier1Enemy()
    {
        enemiesSlain++;

        string scoreCounterStr = "Score: " + enemiesSlain + bossesSlain * 100;
        scoreCounter.text = scoreCounterStr;
    }

    public void SlayBossEnemy()
    {
        bossesSlain++;

        string scoreCounterStr = "Score: " + enemiesSlain + bossesSlain * 100;
        scoreCounter.text = scoreCounterStr;

        if (bossesSlain >= numOfBosses)
        {
            EndGame();
        }
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
    }
}
