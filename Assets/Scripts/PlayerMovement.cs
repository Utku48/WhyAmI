using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    CharacterController controller;
    public float speed;
    public float JumpSpeed;

    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    void Update()

    {
        #region Movement
        float RightLeft = Input.GetAxis("Horizontal");
        float ForwardBack = Input.GetAxis("Vertical");

        Vector3 move = transform.right * RightLeft + transform.forward * ForwardBack;

        controller.Move(move * speed * Time.deltaTime);

        #endregion


    }
}




