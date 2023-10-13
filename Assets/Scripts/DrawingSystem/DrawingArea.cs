using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingArea : MonoBehaviour
{
    public bool canDraw = false;

    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.CompareTag("Cursor"))
        {
            canDraw = true;
        }

    }
    private void OnTriggerExit2D(Collider2D colision)
    {
        if (colision.CompareTag("Cursor"))
        {
            canDraw = false;
        }

    }
}
