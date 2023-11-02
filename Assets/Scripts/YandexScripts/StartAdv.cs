using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class StartAdv : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void StartAdBanner();
    
    private void Start()
    {
        StartAdBanner();
        Time.timeScale = 0;
    }
    

    public void OffPause()
    {
        Time.timeScale = 1;
    }
}
