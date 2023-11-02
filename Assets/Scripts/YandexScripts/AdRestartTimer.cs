using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdRestartTimer : MonoBehaviour
{
    private float StartTimeBtwSpawns = 5;
    private int leftSec = 5;
    private float timeBtwSpawns;

    private Spawnpoints spawnpointManager;
    [SerializeField] private GameObject spawnpointObject;
    [SerializeField] private Text Timer;

    void Start()
    {
        spawnpointManager = spawnpointObject.GetComponent<Spawnpoints>();
        timeBtwSpawns = StartTimeBtwSpawns;
        Timer.text = leftSec.ToString();
    }

    void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            timeBtwSpawns = StartTimeBtwSpawns;
            spawnpointManager.GoToStart();    
        }
        else
        {
            leftSec = (int)timeBtwSpawns + 1;
            Timer.text = leftSec.ToString();
            timeBtwSpawns -= Time.deltaTime;
        }
    }

    public void ResetTimer()
    {
        timeBtwSpawns = StartTimeBtwSpawns;
    }
}
