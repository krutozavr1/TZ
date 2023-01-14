using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    Button button;

    void Start()
    {
        button = GetComponent<Button>();
    }

    public void BecomeInteractable()
    {
        button.interactable = true;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }
}
