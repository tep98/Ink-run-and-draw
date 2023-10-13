using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    [SerializeField] private Animator screenAnim;
    [SerializeField] private GameObject deathScreenEffect;


    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        screenAnim.SetTrigger("killPlayer");     
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
