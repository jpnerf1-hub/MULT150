using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpinning : MonoBehaviour
{
    public Animator animator; // Consistent variable name

    void Start()
    {
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("Spin");
        }
    }
}
