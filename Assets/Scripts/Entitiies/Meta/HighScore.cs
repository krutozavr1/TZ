using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;

public class HighScore : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI highScoreUI, curentScoreUI;
    int curHighScore = 0;

    public void ChangeCurScore(int score)
    {
        curentScoreUI.text = "Расстояние: " + score.ToString();
        if (score > curHighScore)
        {
            SetHighScore(score);
        }
    }

    public void SetHighScore(int score)
    {
        curHighScore = score;
        highScoreUI.text = "Рекорд: " + curHighScore.ToString();
        PlayerPrefs.SetInt("highScore", curHighScore);
    }

    public void SaveHighScore()
    {
        PlayerPrefs.SetInt("highScore", curHighScore);
    }
}
