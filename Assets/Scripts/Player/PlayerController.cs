using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController controllerInstance;
    private InputHandler inputHandler;
    private CharacterController controller;
    public int speedModifier;
    private bool hasDoubleJump = false; //the player has picked up the double jump powerup
    private bool hasWallJump = false; //player has picked up wall jump 
    private bool ceilinged;
    private bool walled = false; //are they touching a wall
    private bool wallJumpUsed; //the player has used wall jump since they last double jumped or left the ground
    private bool doubleJumpUsed; //the player has used double jump since they have left the ground
    public Transform cam;

    public bool isPickingUp; //whether or not the player is pressing the pickup button
    public int numTimesJumped;
    public bool isMoving = false;

    public Vector3 currentCheckpoint;   //the checkpoint the player touched last
    private bool isRespawning;      //has the player triggered something to cause a respawn

    public bool isGrounded = true;
    #region HandlingGravity
    [SerializeField]
    private Transform groundCheck;      //is player touching ground
    [SerializeField]
    private float GRAVITY = -9.8f;      //gravitational constant
    [SerializeField]
    private Vector3 velocity;
    [SerializeField]
    private LayerMask groundMask;
    [SerializeField]
    private float GROUND_DISTANCE = .4f;
    [SerializeField]
    private bool grounded = false;
    [SerializeField]
    private float JUMP_HEIGHT = 1.8f;
    [SerializeField]
    private float WALL_DISTANCE = 1f;
    [SerializeField]
    private Transform wallCheck;
    [SerializeField]
    private LayerMask wallMask;
    [SerializeField]
    private LayerMask ceilingMask;
    [SerializeField]
    private Transform ceilingCheck;
    [SerializeField]
    private float CEILING_DISTANCE = 1f;
    #endregion

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
            hasDoubleJump = true;
        }

        if(other.CompareTag("Wall Jump"))
        {
            Destroy(other.gameObject);
            hasWallJump = true;
        }

        if (other.CompareTag("Checkpoint"))
        {
            SetCheckpoint(other.transform.position);
        }
        if(other.CompareTag("Next Level"))
        {
            SetCheckpoint(new Vector3(other.transform.position.x + 50, other.transform.position.y, other.transform.position.z));
            isRespawning = true;
        } 
        if(other.CompareTag("Death Barrier"))
        {
            isRespawning = true;
        }
        if(other.CompareTag("Double Jump Reset"))
        {
            doubleJumpUsed = false;
            Destroy(other.gameObject);
        }
        
    }
    void Start()
    {
        controller = GetComponent<CharacterController>();
        inputHandler = InputHandler.instance;
    }
    private void Awake()
    {
        if (controllerInstance != null)
        {
            Destroy(this);
        }
        else
        {
            controllerInstance = this;
        }
    }

    void FixedUpdate()
    {
        HandleMovement(Time.deltaTime);
        HandleGravity(Time.deltaTime);
        HandleJump();
        HandleSprint();
        HandlePickup();
        HandleRespawn();
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
        grounded = Physics.CheckSphere(groundCheck.position, GROUND_DISTANCE, groundMask);
        walled = Physics.CheckSphere(wallCheck.position, WALL_DISTANCE, wallMask);
        ceilinged = Physics.CheckSphere(ceilingCheck.position, CEILING_DISTANCE, ceilingMask);

        if (grounded && velocity.y < 0)
        {
            velocity.y = -1.5f;
            doubleJumpUsed = false;
            wallJumpUsed = false;
        } 
            velocity.y += GRAVITY * delta;
            controller.Move(velocity * delta);

        if (ceilinged)
        {
            velocity.y = -1.3f;
        }

        if(transform.position.y < -10)
        {
            isRespawning = true;
        }
        
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
        velocity.y = Mathf.Sqrt(JUMP_HEIGHT * -2f * GRAVITY);
    }

    private void HandleJump()
    {
        
        if (inputHandler.jumpDown && grounded)
        {
            Jump();
        }
        if (hasDoubleJump)  //has the player picked up the double jump powerup
        {
            if (!doubleJumpUsed && inputHandler.jumpDown && !grounded && velocity.y < 3)  //are they in the air and still have double jump and are pressing jump
            {
                doubleJumpUsed = true;   //make sure that they can't double jump again
                Jump();
                wallJumpUsed = false;
            }
        }
        if(hasWallJump && walled && !wallJumpUsed && inputHandler.jumpDown && velocity.y < 3)
        {
            Jump();
            wallJumpUsed = true;
        }
    }
    private void HandleRespawn()
    {
        if (inputHandler.resetDown)
        {
            isRespawning = true;
        }

        if (isRespawning)
        {
            transform.position = currentCheckpoint;
            isRespawning = false;
        } 

    }

    public void SetCheckpoint(Vector3 newCheckpoint)
    {
        currentCheckpoint = newCheckpoint;
    }
   
}


//how to checkpoint with button click
/* if(inputHandler.resetDown){
        isResetting = true

        if(isResetting){
        transform.position= checkpoint
    }
    */