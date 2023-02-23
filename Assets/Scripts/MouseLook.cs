using System;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Crosshair crosshair;
    public float mouseSensitivity = 100.0f;
    public float clampAngle = 80.0f;

    private float rotY = 0.0f; // rotation around the up/y axis
    private float rotX = 0.0f; // rotation around the right/x axis
    bool IsMouseOverGameWindow { get { return !(0 > Input.mousePosition.x || 0 > Input.mousePosition.y || Screen.width < Input.mousePosition.x || Screen.height < Input.mousePosition.y); } }

    void Start()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
    }

    void Update()
    {
        //if (!IsMouseOverGameWindow) return;
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = -Input.GetAxis("Mouse Y");

        rotY += mouseX * mouseSensitivity * Time.deltaTime;
        rotX += mouseY * mouseSensitivity * Time.deltaTime;

        rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

        Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
        transform.rotation = localRotation;

        if (Input.GetButton("Fire1"))
        {
            
            //print("Fire 1");
            //print(crosshair.GetTarget());
        }
        if (Input.GetButton("Fire2"))
        {
            //print("Fire 2");
        }
        if (Input.GetButton("Fire3"))
        {
            //print("Fire 3");
        }
        if (Input.GetButton("Jump"))
        {
            //print("Jump");
        }

    }
}