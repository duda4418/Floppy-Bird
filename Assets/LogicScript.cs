using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    public GameObject GameOverScreen;
    public AudioSource addScoreDing;
    public AudioSource gameOverSound;
    public int playerScore;
    private int highScore;
    private bool gameIsActive = true;
    
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highscore", 0);
        highScoreText.text = "High Score: " + highScore.ToString();
    }

    [ContextMenu("Increase score")]
    public void addScore(int points)
    {
        if(gameIsActive)
        {
            playerScore += points;
            scoreText.text = playerScore.ToString();
            addScoreDing.Play();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        if(gameIsActive)
        {
            gameOverSound.Play();
            GameOverScreen.SetActive(true);
            gameIsActive = false;
        }
        if(playerScore > highScore)
        {
            highScore = playerScore;
            PlayerPrefs.SetInt("highscore", highScore);
            highScoreText.text = "High Score: " + highScore.ToString();
        }
    }
}
