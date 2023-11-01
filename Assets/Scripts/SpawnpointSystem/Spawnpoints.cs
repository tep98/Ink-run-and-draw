using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoints : MonoBehaviour
{
    public Transform[] spawnPoint;
    [SerializeField] private GameObject currentPoint;
    [SerializeField] private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player.transform.position = currentPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
