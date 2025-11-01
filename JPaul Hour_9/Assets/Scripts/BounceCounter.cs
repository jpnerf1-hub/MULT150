using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    private int collisionCount = 0;

    // OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider
    void OnCollisionEnter(Collision collision)
    {
        // Check if the object we collided with has the "CubeTag" tag
        if (collision.gameObject.CompareTag("CubeTag"))
        {
            collisionCount++;
            Debug.Log("Sphere has collided with the cube " + collisionCount + " times.");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
