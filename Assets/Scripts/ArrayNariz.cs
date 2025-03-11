using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ArrayNariz : MonoBehaviour
{
    //[SerializeField] int[] pelo = new int [5];
    [SerializeField] GameObject[] nariz;

    // Start is called before the first frame update
    void Start()
    {
        nariz[0].SetActive(false);
        nariz[1].SetActive(false);
        nariz[2].SetActive(false);
        nariz[3].SetActive(false);
        //for (int i = 0; i < pelo.Length; i++)
        //{
        //    pelo[i]

        //}

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void nariz00()
    {
        for (int i = 0; i < nariz.Length; i++)
        {

            nariz[0].SetActive(true);

            nariz[1].SetActive(false);
            nariz[2].SetActive(false);
            nariz[3].SetActive(false);
            
   
        }

    }


    public void nariz1()
    {
        for (int i = 0; i < nariz.Length; i++)
        {
            nariz[0].SetActive(false);
            nariz[1].SetActive(true);
            nariz[2].SetActive(false);
            nariz[3].SetActive(false);

        }
    }

    public void nariz2()
    {
        for (int i = 0; i < nariz.Length; i++)
        {
            nariz[0].SetActive(false);
            nariz[1].SetActive(false);
            nariz[2].SetActive(true);
            nariz[3].SetActive(false);

        }
    }
    public void nariz3()
    {
        for (int i = 0; i < nariz.Length; i++)
        {
            nariz[0].SetActive(false);
            nariz[1].SetActive(false);
            nariz[2].SetActive(false);
            nariz[3].SetActive(true);

        }
    }


}


