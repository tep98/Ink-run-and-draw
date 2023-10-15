using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverSwitchLeft : MonoBehaviour
{
    private Animator leverAnim;
    private Lever leverManager;
    private bool switchLever = false;
    [SerializeField] private GameObject lever;

    private void Start()
    {
        leverAnim = GetComponent<Animator>();
        leverManager = lever.GetComponent<Lever>();

    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        leverManager.AnimSwitch(switchLever);
    }
}

