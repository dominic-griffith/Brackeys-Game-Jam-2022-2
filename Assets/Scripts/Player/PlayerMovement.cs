using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float runSpeed = 40f;
    private float horizontalMove = 0f;
    private bool jump = false;

    private void Update()
    {
        GetInput();
    }

    private void FixedUpdate()
    {
        MoveCharacter();
    }

    private void GetInput()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    private void MoveCharacter()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
