using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class YoYo : MonoBehaviour
{

    public Transform sphere;
    public float duration = 4;
  //  public int number = 5;

    public void Update()
    {
        //if (Input.GetKeyDown(KeyCode.L))
        //{
        //    Sequence s = DOTween.Sequence();
        //    s.Append(sphere.DOMoveY(-10, duration).SetRelative().SetEase(Ease.InOutQuad));
        //    s.SetLoops(number, LoopType.Yoyo);
        //}
    }


    public void Yo()
    {
        Sequence s = DOTween.Sequence();
        s.Append(sphere.DOMoveY(-10, duration).SetRelative().SetEase(Ease.InOutQuad));
        s.SetLoops(-1, LoopType.Yoyo);
    }
    
}
