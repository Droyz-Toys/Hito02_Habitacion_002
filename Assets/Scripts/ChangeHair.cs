using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHair : MonoBehaviour
{
    [SerializeField] GameObject[] pelos;
    [SerializeField] int actualIndex;


    public void Start()
    {

   }

    public void IncreaseHair()
    {
        if ( actualIndex >= pelos.Length - 1)
        {
            actualIndex = 0;

        }
        else
        {
            actualIndex ++;
        }

        ActiveHair(actualIndex);
    }

    public void DecreaseHair()
    {
        if (actualIndex == 0)
        {
            actualIndex = pelos.Length - 1;
        }
        else
        {
            actualIndex--;
        }

        ActiveHair(actualIndex);
    }

    public void ActiveHair(int index)
    {
        for (int i=0; i<pelos.Length; i++)
        {
            pelos[i].SetActive(false);
        }

        pelos[index].SetActive(true);
    }


}
