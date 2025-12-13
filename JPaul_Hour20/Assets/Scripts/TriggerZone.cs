using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    // Start is called before the first frame update (optional, can be removed if empty)
    void Start()
    {
        // Optional: you can remove this function if it remains empty
    }

    // Update is called once per frame (optional, can be removed if empty)
    void Update()
    {
        // Optional: you can remove this function if it remains empty
    }

    // This function is called when another collider enters the trigger collider
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); // Destroys the GameObject that entered the trigger
    }
}
