using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BTN_OUTELASTIC : MonoBehaviour
{
    Sequence mySequence;

    // Start is called before the first frame update
    void Start() => mySequence = DOTween.Sequence().OnStart(() =>
                  {
                      transform.localScale = Vector3.zero;
                  }).Append(transform.DOScale(new Vector3 (1.2f, 1.2f, 1.2f), 1).SetEase(Ease.OutBounce))
        .SetDelay(3.0f);
    // Update is called once per frame

}
