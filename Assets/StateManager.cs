using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public static StateManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
        Destroy(gameObject);
        return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
