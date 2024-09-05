using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class LevelSelectionMenu : MonoBehaviour
{
    [SerializeField] private AudioSource music;

    public void LoadLevel(int level)
    {
        SceneManager.LoadScene("Level " + level);
    }

    public void LoadBonusLevel()
    {
        SceneManager.LoadScene("Bonus Level");
    }
}
