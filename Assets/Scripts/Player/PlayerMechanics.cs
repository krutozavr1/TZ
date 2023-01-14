using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMechanics : Player
{
    HighScore score;
    int startPos, curScore = 0, overallTries = 0;
    float timePlayed = 0;

    void Start()
    {
        FindObjectOfType<SaveSystem>().LoadSavedData();
        startPos = (int)transform.position.x;
        score = FindObjectOfType<HighScore>();
        overallTries = PlayerPrefs.GetInt("tries", 0);
    }

    void Update()
    {
        timePlayed += Time.deltaTime;
        curScore = (int)(transform.position.x - startPos);
        score.ChangeCurScore(curScore);
    }

    private void Die()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        score.SaveHighScore();
        overallTries++;
        PlayerPrefs.SetInt("tries", overallTries);
        UpdateDeathScreenInfo();
    }

    private void UpdateDeathScreenInfo()
    {
        DeathScreen screen = FindObjectsOfType<DeathScreen>(true)[0];
        screen.ShowDeathScreen();
        screen.UpdateTimer(timePlayed);
        screen.UpdateTries(overallTries);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Death")
        {
            Die();
        }
    }
}
