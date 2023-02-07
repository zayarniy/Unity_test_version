using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
    // Start is called before the first frame update

    CharacterController characterController;
    public float Speed = 1f;
    void Start()
    {
        characterController=GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical")>0)
        {
            Vector3 moveDirection = Camera.main.transform.forward;
            moveDirection *= Speed * Time.deltaTime;
            transform.position += moveDirection;
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            Vector3 moveDirection = Camera.main.transform.forward;
            moveDirection *= Speed * Time.deltaTime;
            transform.position -= moveDirection;
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            Vector3 moveDirection = Camera.main.transform.right;
            moveDirection *= Speed * Time.deltaTime;
            transform.position -= moveDirection;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            Vector3 moveDirection = Camera.main.transform.right;
            moveDirection *= Speed * Time.deltaTime;
            transform.position += moveDirection;
        }

        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //characterController.Move(move * Time.deltaTime * Speed);
    }
}
