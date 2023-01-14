using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DeathScreen : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI tries, time;

    public void ShowDeathScreen()
    {
        gameObject.SetActive(true);
    }

    public  void HideDeathSceen()
    {
        gameObject.SetActive(false);

    }

    public void StartAgain()
    {
        SceneManager.LoadScene("main");
    }

    public void ChangeDifficulty()
    {
        FindObjectsOfType<DifficultySelector>(true)[0].gameObject.SetActive(true);
    }

    public void UpdateTimer(float timePlayed)
    {
        time.text = "Последняя попытка: " + timePlayed.ToString("0.00") + " сек";
    }

    public void UpdateTries(int cnt)
    {
        tries.text = "Всего попыток: " + cnt.ToString();

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
