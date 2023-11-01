using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSwitcher : MonoBehaviour
{
    public GameObject point;
    private void OnTriggerEnter2D(Collider2D other)
    {
        point = other.gameObject;
    }
}
