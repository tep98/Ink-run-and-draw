using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoints : MonoBehaviour
{
    public GameObject[] spawnPoint;
    public GameObject currentPoint;
    [SerializeField] private GameObject player;

    public void SetCurrentSpawnpoint(GameObject newSpawnpoint)
    {
        currentPoint = newSpawnpoint;
    }

    public void Spawn()
    {
        player.transform.position = currentPoint.transform.position;
    }
}
