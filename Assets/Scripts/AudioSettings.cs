using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine;

//code from https://www.youtube.com/watch?v=G-JUp8AMEx0
public class AudioSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider voiceSlider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume") && PlayerPrefs.HasKey("voiceVolume"))
        {
            LoadVolume();
        }
        //else
        //{
           // SetMusicVolume();
        //}
    }
    public void SetMusicVolume()
    {
        float musicVolume = musicSlider.value;
        myMixer.SetFloat("music", Mathf.Log10(musicVolume)* 20);
        PlayerPrefs.SetFloat("musicVolume", musicVolume);

        float voiceVolume = voiceSlider.value;
        myMixer.SetFloat("voice", Mathf.Log10(voiceVolume)* 20);
        PlayerPrefs.SetFloat("voiceSlider", voiceVolume);
    }

    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");   
        voiceSlider.value = PlayerPrefs.GetFloat("voiceVolume");
        SetMusicVolume(); 
    }


}
