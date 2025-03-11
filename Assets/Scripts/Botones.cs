using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
    [SerializeField] GameObject botones;
    // Start is called before the first frame update
    void Start()
    {
        botones = GameObject.FindGameObjectWithTag("Botones");
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
        if (zInput != 0)
        {

             botones.SetActive(false);

        }
        else
        {
            botones.SetActive(true);
        }


        if (-xInput != 0)
        {

       botones.SetActive(false);


        }
    }
}
