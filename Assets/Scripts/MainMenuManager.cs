using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenuManager : MonoBehaviour
{
    public GameObject mainMenuWindow;
    public GameObject settingsWindow;
    public GameObject sureWantToQuitGameWindow;

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void PlayerChooseNormalDifficulty()
    {

    }

    public void PlayerChooseHardDifficulty()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }


    public void CheckIfPlayerWantToQuitGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            sureWantToQuitGameWindow.SetActive(true);
            mainMenuWindow.SetActive(false);
            settingsWindow.SetActive(false);
        }
    }

    void Update()
    {
        CheckIfPlayerWantToQuitGame();
    }
}
