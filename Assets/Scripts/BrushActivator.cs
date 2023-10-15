using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushActivator : MonoBehaviour
{
    [SerializeField] private GameObject drawingCursor;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Animator>().SetTrigger("take");
            gameObject.GetComponent<BoxCollider2D>().enabled = false;

        }
    }    
    
    public void GiveACursor()
    {
        drawingCursor.SetActive(true);
        gameObject.SetActive(false);
    }
}
