using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Array : MonoBehaviour
{
    //[SerializeField] int[] pelo = new int [5];
    [SerializeField] GameObject[] pelo;

    // Start is called before the first frame update
    void Start()
    {
        pelo[0].SetActive(false);
        pelo[1].SetActive(false);
        pelo[2].SetActive(false);
        //for (int i = 0; i < pelo.Length; i++)
        //{
        //    pelo[i]

        //}

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Pelo()
    {
        for (int i = 0; i < pelo.Length; i++)
        {
 
                pelo[0].SetActive(true);

                pelo[1].SetActive(false);
                pelo[2].SetActive(false);
                pelo[3].SetActive(false);
            
   
        }

    }


    public void Pelo1()
    {
        for (int i = 0; i < pelo.Length; i++)
        {
            pelo[0].SetActive(false);
            pelo[1].SetActive(true);
            pelo[2].SetActive(false);
            pelo[3].SetActive(false);

        }
    }

    public void Pelo2()
    {
        for (int i = 0; i < pelo.Length; i++)
        {
            pelo[0].SetActive(false);
            pelo[1].SetActive(false);
            pelo[2].SetActive(true);
            pelo[3].SetActive(false);

        }
    }
    public void Pelo3()
    {
        for (int i = 0; i < pelo.Length; i++)
        {
            pelo[0].SetActive(false);
            pelo[1].SetActive(false);
            pelo[2].SetActive(false);
            pelo[3].SetActive(true);

        }
    }


}


