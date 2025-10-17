using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public Light targetPointLight; // Assign your Light component here in the Inspector

    void Update()
    {
        // Check if the 'L' key is pressed down
        if (Input.GetKeyDown(KeyCode.L))
        {
            // Toggle the enabled state of the light
            if (targetPointLight != null)
            {
                targetPointLight.enabled = !targetPointLight.enabled;
            }
        }
    }
}
