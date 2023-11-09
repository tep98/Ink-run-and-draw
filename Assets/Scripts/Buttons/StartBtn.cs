using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBtn : MonoBehaviour
{
    [SerializeField] private GameObject StartUI;
    [SerializeField] private GameObject ChoiceUI;

    public void Startbtn()
    {
        Progress.Instance.LoadExt();
        StartUI.SetActive(false);
        ChoiceUI.SetActive(true);
    }
}
