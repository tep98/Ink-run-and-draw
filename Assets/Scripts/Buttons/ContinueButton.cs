using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : MonoBehaviour
{
    [SerializeField] private GameObject pauseUI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            {
                pauseUI.SetActive(false);

            }
    }

    public void Continue()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1;
    }

}
