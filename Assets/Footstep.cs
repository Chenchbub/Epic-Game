using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footstep : MonoBehaviour
{
    PlayerController player;
    AudioSource audioSource;

    InputHandler input;

    public float footstepTimer = 0;
    public float footstepFreq = 1;
    void Start()
    {
        player = GetComponent<PlayerController>();
        audioSource = GetComponent<AudioSource>();
        input = InputHandler.instance;
    }

    // Update is called once per frame
    private void Update()
    {
        if (player.isMoving) {

            if (footstepTimer >= 0)
            {
                footstepTimer -= Time.deltaTime;
            } else if(footstepTimer <= 0 && !input.jumpDown)
            {
                Debug.Log("Footstep");
                //play footstep sound
                audioSource.Play();
                //restart timer
                footstepTimer = footstepFreq;
            }
        } else
        {
            footstepTimer = 0;
        }
    }
   
}
