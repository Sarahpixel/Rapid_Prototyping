using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SceneFader : MonoBehaviour
{
    public CanvasGroup cvs;
    // Start is called before the first frame update
    void Start()
    {
        cvs.alpha = 1;
        FadeCanvas(0);
    }
    void FadeCanvas(float _fadeTo)
    {
        cvs.DOFade(_fadeTo, 5);
    }
    
}
