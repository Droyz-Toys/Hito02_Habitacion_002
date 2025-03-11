using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoMove : MonoBehaviour
{

    public Transform target;
    Vector3 targetLastPos;
    Tweener tween;

    void Start()
    {
        tween = transform.DOMove(target.position, 2).SetAutoKill(false);
        targetLastPos = target.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (targetLastPos == target.position) return;
        tween.ChangeEndValue(target.position, true).Restart();
        targetLastPos = target.position;
    }
}
