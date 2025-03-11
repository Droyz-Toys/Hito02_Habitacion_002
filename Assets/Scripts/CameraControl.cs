using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] Transform _target;
    [SerializeField] float _distanceFromTarget = 10f;

    [SerializeField] float sensitivity = 1000f;

    private float _yaw = 0f;
    private float _pitch = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();

        Quaternion yawRotation = Quaternion.Euler(_pitch, _yaw, 0f);

        RotateCamera(yawRotation);

    }

    public void HandleInput()
    {
        Vector2 inputDelta = Vector2.zero;

        //if (Input.touchCount > 0)
        //{
        //    Touch touch = Input.GetTouch(0);
        //    inputDelta = touch.deltaPosition;
        //}

        //else if (Input.GetMouseButton(0))
        //{
            inputDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        //}

        _yaw += inputDelta.x * sensitivity * Time.deltaTime;
     _pitch -= inputDelta.y * sensitivity * Time.deltaTime;
    }

    public void RotateCamera(Quaternion rotation)
    {
        Vector3 positionOffset = rotation * new Vector3(0, 0, -_distanceFromTarget);
        transform.position = _target.position + positionOffset;
        transform.rotation = rotation;
    }
}
