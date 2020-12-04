using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelect_Scenes : MonoBehaviour
{
    float span;
    float delta;

    void start()
    {
        span = 0.2f;
        delta = 0.0f;
    }

    public void ChangeGameScene()
    {
        this.delta = 0.0f;
        while (this.delta < 0.25f)
        {
            if(this.delta > span)
            {
                SceneManager.LoadScene(1);
            }

            this.delta += Time.deltaTime;
        }
    }
}
