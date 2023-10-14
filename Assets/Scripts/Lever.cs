using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] private GameObject leverObj;
    public bool leverON;
    private PlayerController playerControlManager;
    private GameObject leverExtern;

    private void Update()
    {
        playerControlManager = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        leverExtern = playerControlManager.currentLever;

        leverObj = leverExtern;

        if (leverObj!=null)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                //animator
                leverON = true;
                leverObj.SetActive(true);

            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                //animator
                leverON = false;
                leverObj.SetActive(false);
            }
        }
    }
}
