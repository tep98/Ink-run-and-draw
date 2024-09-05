using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public int nextLevelNumber;

    private void OnTriggerEnter2D(Collider2D other)
    {
        OnLevelComplete();
    }
    public void OnLevelComplete()
    {
        SceneManager.LoadScene("MainMenu");
    }
}