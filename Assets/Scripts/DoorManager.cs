using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    [SerializeField] private GameObject leverObject;
    private Lever leverManager;

    private Animator doorAnim;

    private void Start()
    {
        doorAnim = GetComponent<Animator>(); 
    }

    private void Update()
    {
        leverManager = leverObject.GetComponent<Lever>();

        if (leverManager.leverON)
        {
            doorAnim.SetBool("openDoor", true);
        }
        else if (!leverManager.leverON)
        {
            doorAnim.SetBool("openDoor", false);
        }



        if (GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().currentLever != null)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                leverManager.EnableLever();
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                leverManager.DisableLever();
            }
        }
    }
}
