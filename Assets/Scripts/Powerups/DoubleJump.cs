using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    private InputHandler inputHandler;
    public Transform powerupTransform;
    private PlayerController player;
    void Start()
    {
        player = PlayerController.controllerInstance;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
