using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingBtn : MonoBehaviour
{
    [SerializeField] private GameObject previousMenu;
    [SerializeField] private GameObject activeMenu;

    public void Setting()
    {
        previousMenu.SetActive(false);
        activeMenu.SetActive(true);
    }
    public void BackBtn()
    {
        previousMenu.SetActive(true);
        activeMenu.SetActive(false);
    }
}
