using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTransition : MonoBehaviour
{
    private AudioSource endLevel;
    //private Quiz quiz2; ask Supervisor about this
   
    private void Start()
    {
        //endLevel = GetComponent<AudioSource>();
        //quiz2 = GetComponent<Quiz>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PlayerCat")
        {
            //endLevel.Play();
            CompleteLevel();

        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //quiz2.***(); this where it calls/switches to the MSForms for Quiz 2
    }

}
