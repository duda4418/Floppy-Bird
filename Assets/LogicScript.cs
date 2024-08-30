using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public Text scoreText;
    public int playerScore;
    public GameObject GameOverScreen;

    [ContextMenu("Increase score")]
    public void addScore(int points)
    {
        playerScore += points;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
