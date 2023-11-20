using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Restarter : MonoBehaviour
{
    private Spawnpoints spawnpointManager;
    [SerializeField] private GameObject spawnpointObject;
    [SerializeField] private Button adButton;
    [SerializeField] private AudioSource music;

    [DllImport("__Internal")]
    private static extern void AdRelive();

    private void Start()
    {
        transform.parent = null;
        spawnpointManager = spawnpointObject.GetComponent<Spawnpoints>();
    }

    public void ShowAdButton() //функция для кнопки
    {
        adButton.interactable = false;
        AdRelive();
        Time.timeScale = 0;
        music.volume = 0f;
    }

    public void RelivePlayer()//функция, вызываемая в JS
    {
        adButton.interactable = true;
        Time.timeScale = 1;
        music.volume = 1f;
        spawnpointManager.Spawn();
    }

    public void Skip()
    {
        spawnpointManager.GoToStart();
    }
}
