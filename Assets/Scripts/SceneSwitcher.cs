using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    private GameObject finishObject;
    private Animator finishAnim;
    private string sceneName;

    private Animator screenAnim;

    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        finishObject = GameObject.FindGameObjectWithTag("Finish");
        finishAnim = finishObject.GetComponent<Animator>();
        screenAnim = GameObject.FindGameObjectWithTag("VisualSwitcher").GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            switch (sceneName)
            {
            case "Level 1":  
                    screenAnim.SetTrigger("nextScene");
                    finishObject.GetComponent<BoxCollider2D>().enabled = false;
                    break;


            case "Level 2":

                break;


            case "Level 3":

                break;


            case "Level 4":

                break;


            case "Level 5":

                break;
                
            }
        }
    }
}
