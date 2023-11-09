using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class SavesLoader : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void StartGame();


    private void Start()
    {
        StartGame();
    }
}
