using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Canvas001 : MonoBehaviour
{
    [SerializeField] GameObject piel;
    [SerializeField] GameObject nariz;
    [SerializeField] GameObject pelos;
    [SerializeField] GameObject expresiones;
    [SerializeField] GameObject accesorios;






    public void PelosMenu()
    {
        pelos.SetActive(true);
        accesorios.SetActive(false);
        nariz.SetActive(false);
        piel.SetActive(false);
        accesorios.SetActive(false);
        expresiones.SetActive(false);
    }

    public void AccesoriosMenu()
    {
        pelos.SetActive(false);
        accesorios.SetActive(true);
        nariz.SetActive(false);
        piel.SetActive(false);
        expresiones.SetActive(false);
    }

    public void NarizMenu()
    {
        pelos.SetActive(false);
        accesorios.SetActive(false);
        nariz.SetActive(true);
        piel.SetActive(false);
        accesorios.SetActive(false);
        expresiones.SetActive(false);
    }

    public void PielMenu()
    {
        pelos.SetActive(false);
        accesorios.SetActive(false);
        nariz.SetActive(false);

        piel.SetActive(true);

        accesorios.SetActive(false);
        expresiones.SetActive(false);
    }

    public void ExpresionesMenu()
    {
        pelos.SetActive(false);
        accesorios.SetActive(false);
        nariz.SetActive(false);
        piel.SetActive(false);
        accesorios.SetActive(false);

        expresiones.SetActive(true);
    }
    public void Exit()
    {

        Application.Quit();
    }

    public void Back()
    {

        SceneManager.LoadScene(0);
    }

    public void Chico()
    {

        SceneManager.LoadScene(2);
    }
}
