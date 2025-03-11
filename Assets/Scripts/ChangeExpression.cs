using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeExpression : MonoBehaviour
{
    [SerializeField] GameObject[] expressions;
    [SerializeField] int actualIndex;


    public void Start()
    {

    }

    public void IncreaseExpression()
    {
        if (actualIndex >= expressions.Length - 1)
        {
            actualIndex = 0;

        }
        else
        {
            actualIndex++;
        }

        ActiveExpressions(actualIndex);
    }

    public void DecreaseExpression()
    {
        if (actualIndex == 0)
        {
            actualIndex = expressions.Length - 1;
        }
        else
        {
            actualIndex--;
        }

        ActiveExpressions(actualIndex);
    }

    public void ActiveExpressions(int index)
    {
        for (int i = 0; i < expressions.Length; i++)
        {
           expressions[i].SetActive(false);
        }

        expressions[index].SetActive(true);
    }
}
