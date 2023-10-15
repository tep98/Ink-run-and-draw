using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] private GameObject leverObj;
    public bool leverON;

    private Animator leverAnim;

    private void Start()
    {
        leverAnim = GetComponent<Animator>();
    }

    public void EnableLever()
    {
        leverON = true;
        leverAnim.SetBool("enable", true);
    }

    public void DisableLever()
    {
        leverON = false;
        leverAnim.SetBool("enable", false);
    }
}
