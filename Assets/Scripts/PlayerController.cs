using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private float jumpForce;
    [SerializeField] private Transform feetPosition;
    [SerializeField] private float jumpCheckRadius;
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] private bool isOnGround;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
    
    private void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            Run();
        }

        isOnGround = Physics2D.OverlapCircle(feetPosition.position, jumpCheckRadius, whatIsGround);
        if (isOnGround && Input.GetButton("Jump"))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void Run()
    {
        Vector3 direction = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);

        sprite.flipX = direction.x < 0f;
    }
}
