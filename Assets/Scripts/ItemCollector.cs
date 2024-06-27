using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class ItemCollector : MonoBehaviour
{
    private int treat = 0;
    private int verb = 0;
    
    //[SerializeField] private string sceneName = "Jump minigame";
    [SerializeField] private AudioSource collectibleSFX;
    [SerializeField] private TMP_Text treatsTotalText;
    [SerializeField] private TMP_Text verbText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Treat"))
        {
            Destroy(collision.gameObject);
            treat++;
            treatsTotalText.text = "Treats: " + treat;
            collectibleSFX.Play();
        }

        if (collision.gameObject.CompareTag("Verb"))  
        {
            Destroy(collision.gameObject);
            verb++;
            verbText.text = "Verbs learned: " + verb;
            collectibleSFX.Play();
        }
    }

 
}
