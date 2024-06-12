using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;


public class DialogBoxLogic : MonoBehaviour
{
    public string popUp;
     
    void Update()
    {
    popUpWindow popsUp = GameObject.FindGameObjectWithTag("Verb").GetComponent<popUpWindow>();
    popsUp.PopUp(popUp);
    }
    
}
