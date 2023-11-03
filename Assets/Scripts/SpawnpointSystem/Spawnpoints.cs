using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoints : MonoBehaviour
{
    public GameObject[] spawnPoint;
    public GameObject currentPoint;
    public int currentPointIndex;
    private AdRestartTimer adTimerManager;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject restartCanvas;
    [SerializeField] private GameObject adTimer;

    private void Start()
    {
        currentPointIndex = Progress.Instance.PlayerInfo.Spawnpoint;
        currentPoint = spawnPoint[currentPointIndex];
    }

    public void SetCurrentSpawnpoint(int index)
    {
        currentPointIndex = index;
        currentPoint = spawnPoint[currentPointIndex];
        adTimerManager = adTimer.GetComponent<AdRestartTimer>();
    }

    public void Spawn()
    {
        player.transform.position = spawnPoint[currentPointIndex].transform.position;
        restartCanvas.SetActive(false);
    }

    public void TempSpawn()
    {
        player.transform.position = spawnPoint[currentPointIndex].transform.position;
        adTimerManager.ResetTimer();

    }

    public void GoToStart()
    {
        player.transform.position = spawnPoint[0].transform.position;
        restartCanvas.SetActive(false);
    }
}
