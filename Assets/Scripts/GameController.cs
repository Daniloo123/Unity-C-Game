using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI TimerText;
    public int MatchTime = 60;
    private int score = 0;
    private float timer = 60f;
    private bool isGameOver = false;
    public GameOverScreen gameOverScreen;
    public static GameController Instance;

    void Start()
    {
        ScoreText.text = "Score: 0";
        UpdateTimerText();
        //StartCoroutine(Countdown());
    }

    void Update()
    {
        if (!isGameOver)
        {
            timer -= Time.deltaTime;
            UpdateTimerText();

            if (timer <= 0)
            {
                //debug.log("HIER zijn we");
                EndGame();
            }
        }
    }

    // IEnumerator Countdown()
    // {
    //     while (MatchTime > 0)
    //     {
    //         yield return new WaitForSeconds(1);
    //         MatchTime--;
    //         UpdateTimerText();
    //     }
    //     TimerText.text = "Time's up!";
    //     EndGame();
    // }

    void UpdateTimerText()
    {
        TimerText.text = "Time: " + MatchTime;
    }

    public void IncreaseScore()
    {
        score++;
        ScoreText.text = "Score: " + score.ToString();
    }

    void EndGame()
    {
        isGameOver = true;
        Time.timeScale = 0f;
        gameOverScreen.ShowGameOverScreen(score);
    }
}
