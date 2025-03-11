using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    //private float upForce = 250f;
    //private Rigidbody rb;
    //private Transform transform;



    [SerializeField] GameObject vrCam01;
    [SerializeField] GameObject vrCam02;
    [SerializeField] GameObject vrCam03;
    [SerializeField] GameObject vrCam04;

    private PlayerInput playerInput;
    private Touch dar;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        //   rb = GetComponent<Rigidbody>();
        //  rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }


    //public void Rotate()
    //{
    //    // rb.transform.Rotate(0,90,0);
    //    // rb.AddForce(Vector3.up * upForce);transform.Rotate(0,90,0);
    //    transform.Rotate(0, 90, 0);
    //    Debug.Log("Rotate");
    //}



    //public void Update()
    //{

    //    if (Input.GetKeyDown(KeyCode.C))

    //        vrCam02.SetActive(false);
    //        vrCam01.SetActive(false);
    //    }

    //    if (Input.GetKeyDown(KeyCode.P))
    //    {

    //        vrCam02.SetActive(false);
    //        vrCam01.SetActive(true);
    //    }
    //}

    public void CamaraNext01(/*InputAction.CallbackContext callbackContext*/)
    {
        vrCam01.SetActive(true);

        vrCam02.SetActive(false);

        vrCam03.SetActive(false);

        vrCam04.SetActive(false);
    }

    public void CamaraNext02()
    {
        vrCam01.SetActive(false);

        vrCam02.SetActive(true);

        vrCam03.SetActive(false);

        vrCam04.SetActive(false);

    }

    public void CamaraNext03()
    {
        vrCam01.SetActive(false);

        vrCam02.SetActive(false);

        vrCam03.SetActive(true);

        vrCam04.SetActive(false);

    }


    public void CamaraNext04()
    {
        vrCam01.SetActive(false);

        vrCam02.SetActive(false);

        vrCam03.SetActive(false);

        vrCam04.SetActive(true);

    }


}


