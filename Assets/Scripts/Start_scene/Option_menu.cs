using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option_menu : MonoBehaviour
{
    public GameObject PauseUI;
    private bool paused = false;

    void Start()
    {
        PauseUI.SetActive(false);
    }
    
    void Update()
    {
        if (paused)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }

        if (!paused)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void Resume()
    {
        paused = !paused;
    }

    public void Pause()
    {
        paused = !paused;
    }
}
