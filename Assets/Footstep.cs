using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footstep : MonoBehaviour
{
    PlayerController player;
    AudioSource audioSource;

    public float footstepTimer = 0;
    public float footstepFreq = 1;
    void Start()
    {
        player = GetComponent<PlayerController>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (player.isMoving) {

            if (footstepTimer >= 0)
            {
                footstepTimer -= Time.deltaTime;
            } else
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
