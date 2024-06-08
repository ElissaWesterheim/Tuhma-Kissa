using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//code used is from this youtube video: https://www.youtube.com/watch?v=VaDhk2eOQXM from Clipper youtube channel
public class popUpWindow : MonoBehaviour
{
    public Animator animator;
    public GameObject popUpBox;
    public TMP_Text popUptext;

    public void PopUp(string text)
    {
        popUpBox.SetActive(true);
        popUptext.text = text;
        animator.SetTrigger("popsUp"); 
    }
}
