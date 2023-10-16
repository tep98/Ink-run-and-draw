using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDependence : MonoBehaviour
{
    [SerializeField] private GameObject[] objectsToEnable;
    [SerializeField] private GameObject[] objectsToDisable;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (objectsToEnable != null)
            {
                foreach (GameObject element in objectsToEnable) 
                {
                    element.SetActive(true);
                }
            }
            if (objectsToDisable != null)
            {
                foreach (GameObject element in objectsToDisable)
                {
                    element.SetActive(false);
                }
            }

        }
    }
}
