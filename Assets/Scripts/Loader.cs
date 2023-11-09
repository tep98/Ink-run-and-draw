using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        OnLoad();
    }
    public void OnLoad()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
