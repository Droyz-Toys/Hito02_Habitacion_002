using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ArrayAccesorios : MonoBehaviour
{
    //[SerializeField] int[] pelo = new int [5];
    [SerializeField] GameObject[] accesorio;

    // Start is called before the first frame update
    void Start()
    {
        accesorio[0].SetActive(false);
        accesorio[1].SetActive(false);
        accesorio[2].SetActive(false);
        accesorio[3].SetActive(false);
        //for (int i = 0; i < pelo.Length; i++)
        //{
        //    pelo[i]

        //}

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void accesorio00()
    {
        for (int i = 0; i < accesorio.Length; i++)
        {

            accesorio[0].SetActive(true);

            accesorio[1].SetActive(false);
            accesorio[2].SetActive(false);
            accesorio[3].SetActive(false);
            
   
        }

    }


    public void accesorio1()
    {
        for (int i = 0; i < accesorio.Length; i++)
        {
            accesorio[0].SetActive(false);
            accesorio[1].SetActive(true);
            accesorio[2].SetActive(false);
            accesorio[3].SetActive(false);

        }
    }

    public void accesorio2()
    {
        for (int i = 0; i < accesorio.Length; i++)
        {
            accesorio[0].SetActive(false);
            accesorio[1].SetActive(false);
            accesorio[2].SetActive(true);
            accesorio[3].SetActive(false);

        }
    }
    public void accesorio3()
    {
        for (int i = 0; i < accesorio.Length; i++)
        {
            accesorio[0].SetActive(false);
            accesorio[1].SetActive(false);
            accesorio[2].SetActive(false);
            accesorio[3].SetActive(true);

        }
    }


}


