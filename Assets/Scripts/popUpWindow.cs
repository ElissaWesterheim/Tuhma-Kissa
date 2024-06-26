using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

//code used is from this youtube video: https://www.youtube.com/watch?v=hvgfFNorZH8&t=269s

public class popUpWindow : MonoBehaviour
{
    public TextMeshProUGUI DialogueText;
    public String[] Sentences;
    private int Index = 0;
    public float DialogueSpeed;
    public Animator animator;
    private bool StartDialogue = true;
    public Button button;
    
    void Start()
    {
         button = GetComponent<Button>();
         button.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
        if (StartDialogue)
            {
                animator.SetTrigger("popsUp");
                StartDialogue = false;
            }
        else
        {
            NextSentence();
        }
    }
   

    void NextSentence()
    {
        if (Index <= Sentences.Length - 1)
        {
            DialogueText.text = "";
            StartCoroutine(WriteSentences());
            
        }
        else
        {
            DialogueText.text = "";
            animator.SetTrigger("popClose");
            Index = 0;
            StartDialogue = true;
        }
    }
    IEnumerator WriteSentences()
    {
        foreach(char Character in Sentences[Index].ToCharArray())
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);
        }
        Index++;
    }

}
