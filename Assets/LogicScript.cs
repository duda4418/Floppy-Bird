using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public Text scoreText;
    public GameObject GameOverScreen;
    public AudioSource addScoreDing;
    public AudioSource gameOverSound;
    public int playerScore;

    [ContextMenu("Increase score")]
    public void addScore(int points)
    {
        playerScore += points;
        scoreText.text = playerScore.ToString();
        addScoreDing.Play();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        GameOverScreen.SetActive(true);
        gameOverSound.Play();
    }
}
