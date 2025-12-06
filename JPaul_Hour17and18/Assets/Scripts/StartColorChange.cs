using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartColorChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Animator objectAnimator; // Assign in Inspector

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            objectAnimator.SetTrigger("StartColorChange");
        }
    }
}
