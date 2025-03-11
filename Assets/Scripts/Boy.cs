using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boy : MonoBehaviour
{
    [SerializeField] public StaminaBar barraVida;
    [SerializeField] private float vida;
    [SerializeField] private float maximaVida;

    [SerializeField] Animator anim;


    [SerializeField] GameObject staminaBar;

    void Start()
    {
        anim = GameObject.FindGameObjectWithTag("Boy").GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LessLive(int damage)
    {
        vida -= damage;
        barraVida.CambiarVidaActual(vida);

        if (vida <= 0)
        {
            anim.SetTrigger("Fall");
            //Agent.enabled = false;
            //EV.enabled = false;

            //anim.SetBool("isWalking", false);

            //EM.enabled = false;


            ////  boxCollider.enabled = false;


            //StartCoroutine(TemporizadorDestroy());
        StartCoroutine(TemporizadorEstamina());

        }


    }


    IEnumerator TemporizadorEstamina()
    {
        yield return new WaitForSeconds(1f);
        staminaBar.SetActive(false);


    }
}
