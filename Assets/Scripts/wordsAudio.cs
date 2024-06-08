using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class wordsAudio : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public void OnMouseDown()
    {
        source.PlayOneShot(clip);
    }    
}
