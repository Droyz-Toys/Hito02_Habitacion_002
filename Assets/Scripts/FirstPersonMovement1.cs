using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FirstPersonMovement1 : MonoBehaviour
{





    private void Start()
    {
 
    }




    void Update()
    {

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = new Vector3 (x,0f,z);
        transform.position += move;


        


 
    }
}