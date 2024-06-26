using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    [SerializeField] private string sceneName = "Start Game";

    public void OnMouseDown()
    {
        ChangeScene(sceneName);
    }
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadExistingScene(string sceneExists)
    {
        //playerPrefs.SetInt 
        //something about changing from bool to int. t/f if treat/verb has been collected.
    }
}
