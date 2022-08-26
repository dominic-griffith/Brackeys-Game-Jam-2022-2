using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float runSpeed = 40f;

    private PhotonView view;
    private float horizontalMove = 0f;
    private bool jump = false;

    private void Start()
    {
        view = GetComponent<PhotonView>();
    }

    private void Update()
    {
        if (view.IsMine)
        {
            GetInput();
        }
        
    }

    private void FixedUpdate()
    {
        if(view.IsMine)
        {
            MoveCharacter();
        } 
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
