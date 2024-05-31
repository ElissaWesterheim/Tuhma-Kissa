using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taloAudio : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;

    private void OnMouseDown()
    {
        AudioSource.PlayClipAtPoint(_clip, transform.position);
    }    
}
