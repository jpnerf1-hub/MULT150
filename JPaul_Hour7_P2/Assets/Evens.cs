using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Even numbers from 22 to 100:"); // Use Debug.Log, not Console.WriteLine

        // Loop through even numbers from 22 to 100
        for (int i = 22; i <= 100; i += 2)
        {
            Debug.Log(i); // Use Debug.Log in Unity for console output
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}