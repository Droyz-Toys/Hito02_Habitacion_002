using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatada : MonoBehaviour
{
    [SerializeField] Animator anim;

    [SerializeField] int damage;

    void Awake()
    {

        anim = GameObject.FindGameObjectWithTag("Boy").GetComponentInChildren<Animator>();

    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boy")
        {
            anim.SetBool("Reaction", true);

            Boy enemyBar = other.gameObject.GetComponent<Boy>();
            enemyBar.LessLive(damage);
        }



    }


}
