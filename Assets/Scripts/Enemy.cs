using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float speed;
    private float currentSpeed;
    private Rigidbody2D rb;
    private Animator enemyAnim;

    private SpriteRenderer enemySprite;

    [SerializeField] private GameObject deathObject;
    private DeathScript deathManager;

    [SerializeField] private GameObject playerSpriteObject;
    private Animator playerAnim;

    private Transform target;

    private EnemyFollow followChecker;
    private bool isInVision;

    private bool isCloseToWall;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        enemySprite = GetComponent<SpriteRenderer>();
        enemyAnim = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        followChecker = GetComponentInChildren<EnemyFollow>();

        playerAnim = playerSpriteObject.GetComponent<Animator>();

        currentSpeed = speed;
        deathManager = deathObject.GetComponent<DeathScript>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(currentSpeed, rb.velocity.y);

        isInVision = followChecker.isInVision;

        if (isInVision)
        {
            if (target.position.x - transform.position.x < 0)
            {
                currentSpeed = speed * -1;
                enemySprite.flipX = true;
            }
            else
            {
                currentSpeed = speed;
                enemySprite.flipX = false;
            }
        }
        else if (isCloseToWall)
        {
            Return();
            isCloseToWall = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isInVision && other.gameObject.layer == 6)
        {
            Return();
        }
        else if (isInVision && other.gameObject.layer == 6)
        {
            isCloseToWall = true;
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().enabled = false;
            enemyAnim.SetTrigger("killPlayer");
            playerAnim.SetTrigger("killPlayer");
            deathManager.KillPlayer();
            currentSpeed = 0;
        }
    }

    private void Return()
    {
        currentSpeed *= -1;
        enemySprite.flipX = !enemySprite.flipX;
    }
}
