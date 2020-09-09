using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UiManager : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("wolfRunmoved");
    }

public void doExitGame()
{
    Application.Quit();
}

    public void levelComplete()
    {
        SceneManager.LoadScene("winMenu");
    }
}