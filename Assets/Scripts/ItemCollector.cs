using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

//majority of this code is from the following Youtube channel: https://www.youtube.com/watch?v=J77CMuAwVDY&list=PLrnPJCHvNZuCVTz6lvhR81nnaf1a-b67U&index=11
//The playlist for this tutorial is currently Unlisted on YT.
public class ItemCollector : MonoBehaviour
{
    private int treat = 0;
    private int verb = 0;
    
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
