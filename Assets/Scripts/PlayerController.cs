using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    private float moveInput;

    [SerializeField] private float jumpForce;
    [SerializeField] private Transform feetPosition;
    [SerializeField] private float jumpCheckRadius;
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] private bool isOnGround;

    public GameObject currentLever;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    private Animator playerAnim;
    private bool isRun;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();

        playerAnim = GetComponentInChildren<Animator>();
    }
    
    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (moveInput > 0)
        {
            playerAnim.SetBool("isRun", true);
            sprite.flipX = false;
        }

        else if (moveInput < 0)
        {
            playerAnim.SetBool("isRun", true);
            sprite.flipX = true;
        }

        else if (moveInput == 0)
        {
            playerAnim.SetBool("isRun", false);
        }

        isOnGround = Physics2D.OverlapCircle(feetPosition.position, jumpCheckRadius, whatIsGround);
        if (isOnGround && Input.GetButton("Jump"))
        {
            rb.velocity = Vector2.up * jumpForce;
            playerAnim.SetTrigger("takeOf");
        }

        if (isOnGround)
        {
            playerAnim.SetBool("isJump", false);
        }
        else
        {
            playerAnim.SetBool("isJump", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Lever")
            {
                currentLever= other.gameObject;
            }
        }
    
    public void ActivateCurrentLever()
    {
        if (currentLever != null)
        {
            currentLever.GetComponent<Lever>().EnableLever();
        }
    }

    public void DeactivateCurrentLever()
    {
        if (currentLever != null)
        {
            currentLever.GetComponent<Lever>().DisableLever();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActivateCurrentLever();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            DeactivateCurrentLever();
        }
    }

}
