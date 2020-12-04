using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LOGO_DROP_DOWN : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() => transform.DOLocalMoveY(-461, 2).SetRelative().SetEase(Ease.OutBounce);

    void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.SetResolution(1280, 720, true);
    }
    void Update()
    {
        
    }
}
