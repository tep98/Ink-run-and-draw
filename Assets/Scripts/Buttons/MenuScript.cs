using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    //LevelChoice
    public void FirstLevel()
    {
        SceneManager.LoadScene("Level 1");
    }

    //Main Menu

    public void Exit()
    {
        Application.Quit();
    }


    //PauseMenu
    public void MenuBtn()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
