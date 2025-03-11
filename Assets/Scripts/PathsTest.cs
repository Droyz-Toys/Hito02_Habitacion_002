using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PathsTest : MonoBehaviour
{

    public Vector3[] path1;
    public float pathTime;
    Sequence mySequence;
    // Start is called before the first frame update

    private void Awake()
    {
        DOTween.Init(false, true, LogBehaviour.ErrorsOnly);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            transform.DOPath(path1, pathTime, PathType.CatmullRom,
            PathMode.Full3D, 10, Color.white).SetEase(Ease.InOutCubic);
        }

        else if (Input.GetKeyDown(KeyCode.I))
        {
            transform.DOPath(path1, pathTime, PathType.CatmullRom, PathMode.Full3D, 10, Color.white).SetLoops(3, LoopType.Yoyo).SetEase(Ease.InOutCubic);
        }

        else if (Input.GetKeyDown(KeyCode.U))
        {
            mySequence = DOTween.Sequence();
            mySequence.Append(transform.DOPath(path1, pathTime,
            PathType.CatmullRom, PathMode.Full3D, 10,
            Color.white).SetLoops(3, LoopType.Yoyo).SetEase(Ease.InOutCubic)).OnComplete(() => { Debug.Log("Finish!"); });
        }

        else if (Input.GetKeyDown(KeyCode.Y))
        {
            mySequence.Kill();
        }

    }

}
    
