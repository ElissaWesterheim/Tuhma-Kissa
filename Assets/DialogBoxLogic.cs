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
        OnMouseDown();        
    }

    void OnMouseDown()
    {
        popUpWindow popsUp = GameObject.FindGameObjectWithTag("JumpDown hypata").GetComponent<popUpWindow>();
        popsUp.PopUp(popUp);
    }
}
