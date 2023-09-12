using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoremenegar : MonoBehaviour
{

    public Text scoreText;
    public Text highScoreText;
    private int score;
    private int highScore;
    private Hero hero;

    private void Start()
    {
        hero = FindObjectOfType<Hero>();
        if (hero == null)
        {

            return;
        }
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        
        InvokeRepeating("IncreaseScore", 1f, 1f);
        
        UpdateHighScoreText(); 
    }

    public void IncreaseScore()
    {
        if (hero == null)
        {
            CancelInvoke("IncreaseScore");
            if (score > highScore)
            {
                highScore = score;
                PlayerPrefs.SetInt("HighScore", highScore);
                UpdateHighScoreText();
            }
            return;
        }
        score++;
        UpdateScoreText();

        
    }

    private void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }

    private void UpdateHighScoreText()
    {
        highScoreText.text = "Макс. счет: " + highScore.ToString();
    }
}


