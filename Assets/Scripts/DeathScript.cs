using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    [SerializeField] private Animator screenAnim;

    private void OnTriggerEnter2D(Collider2D other)
    {
        KillPlayer();
        Destroy(other.gameObject);
    }

    public void KillPlayer()
    {
        screenAnim.SetBool("killPlayer", true);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
