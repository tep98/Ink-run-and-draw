using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
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
