using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectionMenu : MonoBehaviour
{
    public GameObject[] levelButtons;
    public GameObject[] levelButtonsBlocked;
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
}
