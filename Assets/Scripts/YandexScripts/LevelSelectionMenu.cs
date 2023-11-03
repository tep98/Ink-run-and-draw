using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;

public class LevelSelectionMenu : MonoBehaviour
{
    public GameObject[] levelButtons;
    public GameObject[] levelButtonsBlocked;
    [SerializeField] private AudioSource music;

    [DllImport("__Internal")]
    private static extern void AdBonus();
    private int maxLevel = 1;

    private void Start()
    {
        UpdateMenu();
    }

    public void UpdateMenu()
    {
        maxLevel = Progress.Instance.PlayerInfo.Level;
        
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 <= maxLevel)
            {
                levelButtons[i].SetActive(true);
                levelButtonsBlocked[i].SetActive(false);
            }
            else
            {
                levelButtons[i].SetActive(false);
                levelButtonsBlocked[i].SetActive(true);
            }
        }
    }

    public void LoadLevel(int level)
    {
        SceneManager.LoadScene("Level " + level);
    }

    public void AdButton()
    {
        AdBonus();
        Time.timeScale = 0;
        music.volume = 0f;
    }

    public void GetBonus()
    {
        Time.timeScale = 1;
        music.volume = 1f;
        SceneManager.LoadScene("Bonus Level");
    }
}
