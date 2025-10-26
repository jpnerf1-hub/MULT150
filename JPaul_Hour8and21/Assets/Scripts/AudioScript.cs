using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        // Find the audio source component on the cube
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) // Changed from Input.GetButtonDown("Jump")
        {
            if (audioSource.isPlaying == true)
            {
                audioSource.Stop();
            }
            else
            {
                audioSource.Play();
            }
        }
    }
}
