using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoaderMove : MonoBehaviour
{
    // [SerializeField] private GameObject player;
    private void Update()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 0f);
    }
    
}
