using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LevelProgressManager
{
    public static void SaveMaxLevel(int level)
    {
        if (level > Progress.Instance.PlayerInfo.Level)
        {
            Progress.Instance.PlayerInfo.Level = level;
            Progress.Instance.Save();
        }
    }
}

