using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Any initialization logic for Start() goes here
    }

    // OnTriggerEnter is called when the Collider other enters the trigger.
    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.CompareTag(gameObject.tag)) // Using CompareTag for efficiency
        {
            // Assuming the Light component is on the same GameObject as this script
            Light goalLight = GetComponent<Light>();
            if (goalLight != null) // Check if the Light component exists
            {
                goalLight.intensity = 0;
            }
            Destroy(collidedWith);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
