using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("numbers from 1 to 31:"); // Use Debug.Log, not Console.WriteLine

        // Loop through even numbers from 1 to 31
        for (int i = 1; i <= 31; i += 1)
        {
            Debug.Log(i); // Use Debug.Log in Unity for console output



            if (i == 27)
            {
                Debug.Log("Its my Birthday");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
