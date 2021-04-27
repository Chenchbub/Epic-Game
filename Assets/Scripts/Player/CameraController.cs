using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private InputHandler inputHandler;
    [SerializeField]
    private Transform playerParent;
    [SerializeField]
    private float hSens = 100f;
    [SerializeField]
    private float vSens = 100f;
    [SerializeField]
    private float sens = 100f;

    private float xRot = 0f;
    // Start is called before the first frame update
    void Start()
    {
        inputHandler = InputHandler.instance;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        HandleLook(Time.deltaTime);
    }
    private void HandleLook(float delta)
    {
        float mouseX;
        float mouseY;

        if (hSens == vSens)
        {
            mouseX = inputHandler.look.x * sens * delta;
            mouseY = inputHandler.look.y * sens * delta;
        }
        else
        {
            mouseX = inputHandler.look.x * hSens * delta;
            mouseY = inputHandler.look.y * vSens * delta;
        }
        //handle tilting the camera
        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90, 90);

        transform.localRotation = Quaternion.Euler(xRot, 0, 0);
        //handle rotating the player
        playerParent.Rotate(Vector3.up, mouseX);
    }
}

