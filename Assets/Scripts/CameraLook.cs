using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraLook : MonoBehaviour
{

    private Quaternion targetRotation;
    CinemachineTransposer cameraTransposer;
    [SerializeField]
    CinemachineVirtualCamera cameraReference;
    [SerializeField]
    private float rotationSpeed = 15;
    Vector2 input;
    private void Start()
    {
        //We need to use this Cinemachine specific method to access Transposer
        cameraTransposer = cameraReference.GetCinemachineComponent<CinemachineTransposer>();
        targetRotation = transform.rotation;


    }


    public void Cam()
    {
      input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        int rotationDirection = 0;
        //if (Input.GetKey(KeyCode.Q))
        //    rotationDirection = -1;
        //if (Input.GetKey(KeyCode.E))
            rotationDirection = 1;
        targetRotation = transform.rotation * Quaternion.Euler(Vector3.up * rotationDirection * rotationSpeed);
    }
}
