using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Restarter : MonoBehaviour
{
    private Spawnpoints spawnpointManager;
    [SerializeField] private GameObject spawnpointObject;

    [DllImport("__Internal")]
    private static extern void AdRelive();

    private void Start()
    {
        transform.parent = null;
        spawnpointManager = spawnpointObject.GetComponent<Spawnpoints>();
    }

    public void ShowAdButton() //функция для кнопки
    {
        AdRelive();
        Time.timeScale = 0;
    }

    public void RelivePlayer()//функция, вызываемая в JS
    {
        Time.timeScale = 1;
        spawnpointManager.Spawn();
    }

    public void Skip()
    {
        spawnpointManager.GoToStart();
    }
}
