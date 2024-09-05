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

    private void Start()
    {
        spawnpointManager = spawnpointObject.GetComponent<Spawnpoints>();
    }

    public void RelivePlayer()
    {
        spawnpointManager.Spawn();
    }

    public void Skip()
    {
        spawnpointManager.GoToStart();
    }
}
