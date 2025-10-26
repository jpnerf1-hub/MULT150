using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int healthpoints = 3992;

    // Start is called before the first frame update
    void Start()
    {
        // Call UsePotion() and update healthpoints 4 times
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);

        // Log the final healthpoints value
        Debug.Log("Final Health: " + healthpoints);
    }

    // Update is called once per frame
    void Update()
    {
        // This method is not used for this specific task
    }

    // Function to use a potion and increase health
    int UsePotion(int health)
    {
        health += 400; // Add 400 to the health parameter
        return health; // Return the new health value
    }
}
