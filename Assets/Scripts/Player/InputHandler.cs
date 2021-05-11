using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public static InputHandler instance;
    private Controls controls;

    
    public Vector2 move;
    public Vector2 look;
    public bool pickupDown = false;
    public bool sprintDown = true;
    public bool jumpDown = false;
    public bool resetDown = false;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this);
        } else
        {
            instance = this;
        }

        controls = new Controls();
    }

    private void OnEnable ()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    } 

    private void Start()
    { 

        controls.Locomotion.Move.performed += controls => move =controls.ReadValue<Vector2>();
            
        
        controls.Locomotion.Look.performed += controls => look = controls.ReadValue<Vector2>();

        controls.Locomotion.Jump.performed += controls => jumpDown = true;
        controls.Locomotion.Jump.canceled += controls => jumpDown = false;

        controls.Locomotion.Sprint.performed += controls => sprintDown = true;
        controls.Locomotion.Sprint.canceled += controls => sprintDown = false;

        controls.Locomotion.Pickup.performed += controls =>pickupDown = true;
        controls.Locomotion.Pickup.canceled += controls => pickupDown = false;

        controls.Locomotion.Reset.performed += controls => resetDown = true;
        controls.Locomotion.Reset.canceled += controls => resetDown = false;
    }
}
