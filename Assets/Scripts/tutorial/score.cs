using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    GameObject stickman;
    GameObject Score_text;

    void Start()
    {
        
    }
 
    void OnEnable()
    {
        this.stickman = GameObject.Find("stickman");
        this.Score_text = GameObject.Find("Score_text");
    }

    void Update()
    {
        float length = this.stickman.transform.position.x + 65.5f;
        this.Score_text.GetComponent<Text>().text = length.ToString("F1") + " POINT";
    }
}
