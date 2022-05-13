using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public CharacterController playerController;

    public Transform groundCheck;
    public float groundDistance = 0.2f;
    public LayerMask groundMask;
    bool isGrounded;
    bool isJumping;
    Vector3 velocity;
    public float gravity = -9.81f;
    public float playerSpeed = 12.0f;
    public float jumpHeight = 2.0f;
    public float sprintSpeed = 15.0f;

    private void Awake()
    {
        isJumping = false;        
    }

    void Update()
    {
        Move();
        //Dash(); 
        Jump();
    }

    private void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        playerController.Move(move * playerSpeed * Time.deltaTime);

    }

    private void Jump()
    {
        if (!isJumping)
        {
            velocity.y += gravity * Time.deltaTime;

            //playerController.Move(velocity * Time.deltaTime);

            if (Physics.CheckSphere(groundCheck.position, groundDistance, groundMask))
            {
                isGrounded = true;
            }

            //if grounded reset velocity
            if (isGrounded && velocity.y == -0.4)
            {
                velocity.y = 0f;
            }

            if (Input.GetButtonDown("Jump"))
            {
                if (isGrounded && velocity.y == -0.4)
                {
                    velocity.y = Mathf.Sqrt(jumpHeight * -2.0f * gravity);
                }
            }
        }
        else if (isJumping)
        { 
            return;
        }
    }
}
