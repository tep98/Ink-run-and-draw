using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverSwitchLeft : MonoBehaviour
{
    private Animator leverAnim;
    private Lever leverManager;
    [SerializeField] private GameObject lever;

    private void Start()
    {
        leverAnim = GetComponent<Animator>();
        leverManager = lever.GetComponent<Lever>();

    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        leverManager.EnableLever();
    }
}

