using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private InputHandler inputHandler;
    private CharacterController controller;
    public int speedModifier;
    public bool hasDoubleJump = false; //the player has picked up the double jump powerup
    public bool doubleJumpUsed; //the player has used double jump since they have left the ground
    public Transform cam;
    public bool isPickingUp; //whether or not the player is pressing the pickup button
    public int numTimesJumped;
    public bool isMoving = false;
    #region HandlingGravity
    [SerializeField]
    private Transform groundCheck;
    [SerializeField]
    private float gravity = -9.8f;
    [SerializeField]
    private Vector3 velocity;
    [SerializeField]
    private LayerMask groundMask;
    [SerializeField]
    private float groundDistance = .4f;
    [SerializeField]
    private bool grounded = false;
    [SerializeField]
    private float jumpHeight = 1.8f;
    #endregion

    void Start()
    {
        controller = GetComponent<CharacterController>();
        inputHandler = InputHandler.instance;
    }

    void FixedUpdate()
    {
        HandleMovement(Time.deltaTime);
        HandleGravity(Time.deltaTime);
        HandleJump();
        HandleSprint();
        HandlePickup();
    }
            
    private void HandleMovement(float delta)
    {
        
        Vector3 movement = (inputHandler.move.x * transform.right) + (inputHandler.move.y * transform.forward);

        if (movement.Equals(Vector3.zero))
        {
            isMoving = false;
        }
        else
        {
            isMoving = true;
        }

        controller.Move(movement * speedModifier * delta);
    }

    private void HandleGravity(float delta)
    {
        grounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (grounded && velocity.y < 0)
        {
            velocity.y = -1.5f;
            doubleJumpUsed = false;
        } 
            velocity.y += gravity * delta;
            controller.Move(velocity * delta);
        
    }

    private void HandlePickup()
    {
        if (inputHandler.pickupDown)
        {
            isPickingUp = true;
        } else
        {
            isPickingUp = false;
        }
    }

    private void HandleSprint()
    {
        if(inputHandler.sprintDown)
        {
            speedModifier = 8;
        } else
        {
            speedModifier = 5;
        }
    }


    private void Jump() //math for the jump to make it more organized and neat
    {
        velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
    }

    private void HandleJump()
    {
        
        if (inputHandler.jumpDown && grounded)
        {
            Jump();
        }
        if (hasDoubleJump)  //has the player picked up the double jump powerup
        {
            if (!doubleJumpUsed && inputHandler.jumpDown && !grounded && velocity.y < 4)  //are they in the air and still have double jump and are pressing jump
            {
                doubleJumpUsed = true;   //make sure that they can't double jump again
                Jump();
            }
        }
            

    }


}
