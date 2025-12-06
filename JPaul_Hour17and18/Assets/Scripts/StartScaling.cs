using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScaling : MonoBehaviour
{
    public Animator objectAnimator; // Declared public Animator variable

    void Start()
    {
        // Assign the Animator component to the public variable
        objectAnimator = GetComponent<Animator>();

        if (objectAnimator == null)
        {
            Debug.LogError("Animator component not found on this GameObject.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (objectAnimator != null)
            {
                objectAnimator.SetTrigger("ScaleTrigger"); // Use the public variable
            }
        }
    }
}
