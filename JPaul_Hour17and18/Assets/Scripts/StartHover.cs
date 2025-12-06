using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartHover : MonoBehaviour
{
    // Add the [SerializeField] attribute here to make the private animator field visible in the Inspector
    [SerializeField] private Animator animator;

    void Start()
    {
        // It's still good practice to get the component in code,
        // but adding [SerializeField] will show the reference in the Inspector as well.
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (animator != null)
            {
                animator.SetTrigger("Hover");// Activates the trigger
            }
        }
}   }

