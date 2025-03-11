using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    [SerializeField] Material [] chageMaterial;
    [SerializeField] GameObject[] cube;
    [SerializeField] GameObject[] nose;
    [SerializeField] GameObject[] accesorios;
    [SerializeField] GameObject[] ojos;
    [SerializeField] GameObject skin;


    // [SerializeField] int actualIndex;

    public void ChangeToRed(int index)
    {
        for (int i = 0; i < cube.Length; i++)
        {
      
            cube[i].GetComponent<MeshRenderer>().material = chageMaterial[0] ;
 
        }

    }
    public void ChangeToRedOjos(int index)
    {
        for (int i = 0; i < ojos.Length; i++)
        {

            ojos[i].GetComponent<SkinnedMeshRenderer>().material.color = Color.red;
            //  ojos[i].GetComponent<SkinnedMeshRenderer>().material = chageMaterial[0];
       


        }

    }
    public void ChangeToRedSkin(int index)
    {
        for (int i = 0; i < nose.Length; i++)
        {
            nose[i].GetComponent<MeshRenderer>().material = chageMaterial[0];
  
      
        }

        skin.GetComponent<SkinnedMeshRenderer>().material = chageMaterial[0];
    }

    public void ChangeToRedAccesorios(int index)
    {
        for (int i = 0; i < accesorios.Length; i++)
        {

            accesorios[i].GetComponent<MeshRenderer>().material = chageMaterial[0];
        }

    }

    public void ChangeToBlack(int index)
    {
        for (int i = 0; i < cube.Length; i++)
        {
            cube[i].GetComponent<MeshRenderer>().material = chageMaterial[1];

        }


    }
    public void ChangeToBlackOjos(int index)
    {
        for (int i = 0; i < ojos.Length; i++)
        {

            ojos[i].GetComponent<SkinnedMeshRenderer>().material.color = Color.black;

        }

    }

    public void ChangeToBlackSkin(int index)
    {
        for (int i = 0; i < nose.Length; i++)
        {
            nose[i].GetComponent<MeshRenderer>().material = chageMaterial[1];
        }

        skin.GetComponent<SkinnedMeshRenderer>().material = chageMaterial[1];

    }

    public void ChangeToBlackAccesorios(int index)
    {
        for (int i = 0; i < accesorios.Length; i++)
        {

            accesorios[i].GetComponent<MeshRenderer>().material = chageMaterial[1];
        }

    }

    public void ChangeToYellow(int index)
    {
        for (int i = 0; i < cube.Length; i++)
        {
            cube[i].GetComponent<MeshRenderer>().material = chageMaterial[2];

        }

    }


    public void ChangeToYellowSkin(int index)
    {
        for (int i = 0; i < nose.Length; i++)
        {
            nose[i].GetComponent<MeshRenderer>().material = chageMaterial[2];
        }

        skin.GetComponent<SkinnedMeshRenderer>().material = chageMaterial[2];
        

    }

    public void ChangeToYellowOjos(int index)
    {
        for (int i = 0; i < ojos.Length; i++)
        {

            ojos[i].GetComponent<SkinnedMeshRenderer>().material.color = Color.yellow;
            //  ojos[i].GetComponent<SkinnedMeshRenderer>().material = chageMaterial[0];
        }

    }
    public void ChangeToYellowAccesorios(int index)
    {
        for (int i = 0; i < accesorios.Length; i++)
        {

            accesorios[i].GetComponent<MeshRenderer>().material = chageMaterial[2];
        }

    }


    public void ChangeToBlue(int index)
    {
        for (int i = 0; i < cube.Length; i++)
        {
            cube[i].GetComponent<MeshRenderer>().material = chageMaterial[3];

        }

    }

    public void ChangeToBlueSkin(int index)
    {
        for (int i = 0; i < nose.Length; i++)
        {
            nose[i].GetComponent<MeshRenderer>().material = chageMaterial[3];
        }
        skin.GetComponent<SkinnedMeshRenderer>().material = chageMaterial[3];

    }

    public void ChangeToBlueOjos(int index)
    {
        for (int i = 0; i < ojos.Length; i++)
        {

            ojos[i].GetComponent<SkinnedMeshRenderer>().material.color = Color.cyan;
            //  ojos[i].GetComponent<SkinnedMeshRenderer>().material = chageMaterial[0];
        }

    }

    public void ChangeToBlueAccesorios(int index)
    {
        for (int i = 0; i < accesorios.Length; i++)
        {

            accesorios[i].GetComponent<MeshRenderer>().material = chageMaterial[3];
        }

    }


}
