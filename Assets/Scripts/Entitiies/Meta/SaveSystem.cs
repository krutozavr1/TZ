using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public void LoadSavedData()//called from player mechs script when it instantiates
    {
        SetLastDifficulty();
        SetHighScore();
    }

    private void SetLastDifficulty()
    {
        string lastDifficulty = PlayerPrefs.GetString("difficulty");
        DifficultySelector selector = FindObjectsOfType<DifficultySelector>(true)[0];
        switch (lastDifficulty)
        { 
            case "easy" : selector.SetEasyDifficulty();break;
            case "medium" : selector.SetMediumDifficulty();break;
            case "hard" : selector.SetHardDifficulty();break;
            
        }  
    }

    private void SetHighScore()
    {
        FindObjectOfType<HighScore>().SetHighScore(PlayerPrefs.GetInt("highScore"));
    }
}
