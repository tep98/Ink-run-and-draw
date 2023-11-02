using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restarter : MonoBehaviour
{
    private Spawnpoints spawnpointManager;
    [SerializeField] private GameObject deathTrigger;
    [SerializeField] private GameObject spawnpointObject;

    private void Start()
    {
        spawnpointManager = spawnpointObject.GetComponent<Spawnpoints>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //ad restart
        spawnpointManager.Spawn();
    }
}
