using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    [SerializeField] private Transform pathParent;
    [SerializeField] public float duration;
    public PathType pathType = PathType.CatmullRom;


    // Update is called once per frame
    void Update()
    {




    }


    public void StartCar()
    {
        //if (Input.GetKeyDown(KeyCode.I))
        //{

            Vector3[] pathArray = new Vector3[pathParent.childCount];

            for (int i = 0; i < pathArray.Length; i++)
            {
                pathArray[i] = pathParent.GetChild(i).position;
            }

            Tween t = transform.DOPath(pathArray, duration * 1f, pathType)
           .SetOptions(true)
            .SetLookAt(0.001f);
            t.SetEase(Ease.Linear).SetLoops(-1);



    //    }
    }

    public void Exit()
    {
      
        Application.Quit();
    }
}
