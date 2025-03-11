using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAccesorios : MonoBehaviour
{
    [SerializeField] GameObject[] accesorios;
    [SerializeField] int actualIndex;


    public void Start()
    {

    }

    public void IncreaseAccesorios()
    {
        if (actualIndex >= accesorios.Length - 1)
        {
            actualIndex = 0;

        }
        else
        {
            actualIndex++;
        }

        ActiveAccesorios(actualIndex);
    }

    public void DecreaseAccesorios()
    {
        if (actualIndex == 0)
        {
            actualIndex = accesorios.Length - 1;
        }
        else
        {
            actualIndex--;
        }

        ActiveAccesorios(actualIndex);
    }

    public void ActiveAccesorios(int index)
    {
        for (int i = 0; i < accesorios.Length; i++)
        {
            accesorios[i].SetActive(false);
        }

        accesorios[index].SetActive(true);
    }
}
