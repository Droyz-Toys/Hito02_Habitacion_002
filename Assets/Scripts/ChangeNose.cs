using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeNose : MonoBehaviour
{
    [SerializeField] GameObject[] nose;
    [SerializeField] int actualIndex;


    public void Start()
    {

    }

    public void IncreaseNose()
    {
        if (actualIndex >= nose.Length - 1)
        {
            actualIndex = 0;

        }
        else
        {
            actualIndex++;
        }

        ActiveNose(actualIndex);
    }

    public void DecreaseNose()
    {
        if (actualIndex == 0)
        {
            actualIndex = nose.Length - 1;
        }
        else
        {
            actualIndex--;
        }

        ActiveNose(actualIndex);
    }

    public void ActiveNose(int index)
    {
        for (int i = 0; i < nose.Length; i++)
        {
           nose[i].SetActive(false);
        }

        nose[index].SetActive(true);
    }
}
