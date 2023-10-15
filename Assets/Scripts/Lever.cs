using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] private GameObject leverObj;
    public bool leverON;
    private PlayerController playerControlManager;
    private GameObject leverExtern;

    private Animator leverAnim;

    private void Start()
    {
        leverAnim = GetComponent<Animator>();
    }

    private void Update()
    {
        playerControlManager = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        leverExtern = playerControlManager.currentLever;

        leverObj = leverExtern;

        if (leverObj!=null)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                leverON = true;
                leverAnim.SetBool("enable", true);

            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                leverON = false;
                leverAnim.SetBool("enable", false);
            }
        }
    }

    public void AnimSwitch(bool enableVar)
    {
        leverAnim.SetBool("enable", !enableVar);
    }
}
