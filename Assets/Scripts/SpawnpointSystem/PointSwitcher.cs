using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSwitcher : MonoBehaviour
{
    private Spawnpoints spawnpointManager;
    [SerializeField] private GameObject spawnpointObject;
    public int pointIndex;

    private void Start()
    {
        spawnpointManager = spawnpointObject.GetComponent<Spawnpoints>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            spawnpointManager.SetCurrentSpawnpoint(pointIndex);
        }
    }
}
