using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySelector : MonoBehaviour
{

    public void SetEasyDifficulty()
    {
        PlayerPrefs.SetString("difficulty", "easy");
        FindObjectOfType<PlayerMovement>().SetStartSpeed(10);
        FindObjectOfType<LevelSpawner>().SetSpawnCd(2.4f);
        gameObject.SetActive(false);
    }
    
    public void SetMediumDifficulty()
    {
        PlayerPrefs.SetString("difficulty", "medium");
        FindObjectOfType<PlayerMovement>().SetStartSpeed(15);
        FindObjectOfType<LevelSpawner>().SetSpawnCd(2.1f);
        gameObject.SetActive(false);
    }

    public void SetHardDifficulty()
    {
        PlayerPrefs.SetString("difficulty", "hard");
        FindObjectOfType<PlayerMovement>().SetStartSpeed(20);
        FindObjectOfType<LevelSpawner>().SetSpawnCd(1.8f);
        gameObject.SetActive(false);
    }

    public void SaveSelectedDifficulty(string difficulty)//called from buttons on start screen
    {
        PlayerPrefs.SetString("difficulty", difficulty);

    }
}
