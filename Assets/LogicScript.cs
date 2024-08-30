using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public Text scoreText;
    public int playerScore;

    [ContextMenu("Increase score")]
    public void addScore(int points)
    {
        playerScore += points;
        scoreText.text = playerScore.ToString();
    }

}
