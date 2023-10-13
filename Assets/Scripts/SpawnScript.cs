using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    private Animator screenAnim;

    private void Start()
    {
        screenAnim = GetComponent<Animator>();
    }

    public void SetActivationFalse()
    {
        screenAnim.SetBool("isSpawn", true);
    }
}
