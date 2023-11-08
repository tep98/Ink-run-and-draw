using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    private Spawnpoints spawnpointManager;
    [SerializeField] private GameObject restartCanvas;
    [SerializeField] private GameObject spawnpointObject;

    [SerializeField] private Animator screenAnim;

    private void Start()
    {
        spawnpointManager = spawnpointObject.GetComponent<Spawnpoints>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        screenAnim.SetBool("killPlayer", true);
    }

    public void setRestartScreen()
    {
        restartCanvas.SetActive(true);
        spawnpointManager.TempSpawn();
    }
}
