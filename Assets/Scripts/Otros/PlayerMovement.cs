

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using TMPro;

//public class PlayerMovement : MonoBehaviour
//{

//    public CharacterController controller;
//    public float speed = 10f;
//    public float gravity = -9.8f;
//    public Transform groundCheck;
//    public float sphereRadius = 0.3f;
//    public float jumpForce = 10;

//    public LayerMask groundLayer;

//    bool isGrounded;


//    //Vector3 velocity;
//    private Vector3 direction;

//    //public float jumpHeight =3;

//    public bool ableDoubleJump = false;

//    public Animator anim;
//    public Transform model;

//    [SerializeField]
//    //public int playerPoints;
//    public TMP_Text puntosText;
//    public TMP_Text granadasText;
//    public TMP_Text vidasText;
//    public TMP_Text llavesText;
//    public TMP_Text saltoText;
//    [SerializeField] private CanvasDataSO scoreSO;



//    [SerializeField] GameObject vrCam03;
//    [SerializeField] GameObject vrCam01;
//    [SerializeField] GameObject vrCam02;



//    void Start()
//    {

//        puntosText.text = " Puntos : " + scoreSO.Puntos;
//        vidasText.text = " Vidas : " + scoreSO.Vidas;
//        granadasText.text = " Granads : " + scoreSO.Vidas;
//        llavesText.text = " Llaves : " + scoreSO.Llaves;
//    }

//    public void AddJump(int salto)
//    {
//        scoreSO.Salto += salto;
//        saltoText.text = " Doble Salto : " + scoreSO.Salto;
//    }

//    public void LessJump(int salto)
//    {
//        scoreSO.Salto -= salto;
//        saltoText.text = " Doble Salto : " + scoreSO.Salto;
//    }
//    public void AddScore(int puntos)
//    {

//        scoreSO.Puntos += puntos;
//        puntosText.text = " Puntos : " + scoreSO.Puntos;

//    }

//    public void LessLives(int vidas)
//    {
//        scoreSO.Vidas -= vidas;
//        vidasText.text = " Vidas : " + scoreSO.Vidas;
//    }



//    public void AddKey(int key)
//    {
//        scoreSO.Llaves += key;
//        llavesText.text = " Llaves : " + scoreSO.Llaves;
//    }


//    public void LessShoot(int granadas)
//    {
//        scoreSO.Granadas -= granadas;
//        //granadasText.text = " Granadas : " + scoreSO.Granadas;
//    }


//    void Update()
//    {


//        float zInput = Input.GetAxis("Vertical");
//        direction.z = zInput * speed;

//        direction.y += gravity * Time.deltaTime;

//        bool isGrounded = Physics.CheckSphere(groundCheck.position, 0.05f, groundLayer);
//        anim.SetBool("isGrounded", isGrounded);

//        if (isGrounded)
//        {

//            direction.y = 0;
//            ableDoubleJump = false;
//            if (Input.GetButtonDown("Jump"))
//            {
//                direction.y = jumpForce;
//            }

//            if (Input.GetButtonDown("Fire1"))
//            // if (Input.GetKeyDown("Fire1"))
//            {

//                scoreSO.Granadas -= 1;
//                granadasText.text = " Granadas : " + scoreSO.Granadas;
//                anim.SetTrigger("fireBall");
//            }


//            if (Input.GetButtonDown("Fire1"))
//            // if (Input.GetKeyDown("Fire1"))
//            {

//                scoreSO.Granadas -= 1;
//                granadasText.text = " Granadas : " + scoreSO.Granadas;
//                anim.SetTrigger("fireBall");
//                anim.SetBool("isGrounded", false);
//            }

//            if (Input.GetKeyDown(KeyCode.C))
//            {
//                vrCam03.SetActive(true);
//                vrCam02.SetActive(false);
//                vrCam01.SetActive(false);
//            }


//            if (Input.GetKeyDown(KeyCode.P))
//            {
//                vrCam03.SetActive(false);
//                vrCam02.SetActive(false);
//                vrCam01.SetActive(true);

//            }
//        }

//        else
//        {
//            DoubleJump();

   
          
//        }


//        if (zInput != 0)
//        {
//            anim.SetFloat("speed", Mathf.Abs(zInput));
//            Quaternion newRotation = Quaternion.LookRotation(new Vector3(0, 0, zInput));
//            model.rotation = newRotation;
//        }


//        controller.Move(direction * Time.deltaTime);


//    }


//    public void DoubleJump()
//    {
//        ableDoubleJump = true;

//        if (ableDoubleJump & Input.GetButtonDown("Jump"))
//        {
//            if (scoreSO.Salto >  0)
//            {
//                scoreSO.Salto -= 1;
//                saltoText.text = " Doble Salto  : " + scoreSO.Salto;

//                anim.SetTrigger("dobleJump");
//                direction.y = jumpForce * 1.5f;

//                ableDoubleJump = true;


//                gravity = -20f;
//            }

//        }


//    }




//}

