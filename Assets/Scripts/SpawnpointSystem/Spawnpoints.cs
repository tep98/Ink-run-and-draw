using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoints : MonoBehaviour
{
    public GameObject[] spawnPoint;
    public GameObject currentPoint;
    public int currentPointIndex;
    [SerializeField] private GameObject player;

    public void SetCurrentSpawnpoint(int index)
    {
        currentPointIndex = index;
        currentPoint = spawnPoint[currentPointIndex];
    }

    public void Spawn()
    {
        player.transform.position = spawnPoint[currentPointIndex].transform.position;
    }
}
