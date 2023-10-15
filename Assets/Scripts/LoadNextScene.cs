using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    [SerializeField] private int currentScene;

    public void LoadNextSceneFunc()
    {
        SceneManager.LoadScene(currentScene+1);
    }
}