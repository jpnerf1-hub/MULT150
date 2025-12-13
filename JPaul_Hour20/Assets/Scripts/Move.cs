using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Change "privateGameControl" to "GameControl"
    private GameControl control; // Line 7

    void Start()
    {
        control = GameObject.FindObjectOfType<GameControl>();
    }
    void Update()
    {
        transform.Translate(0, 0, control.startSpeed);
    }
}
