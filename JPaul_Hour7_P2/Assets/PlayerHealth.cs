using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       float health = 1004f;
       float poisonDamage = 125.5f;

        Debug.Log(health);

        health -= poisonDamage;

        Debug.Log(health);

        while (health > 0)
        {
            health -= poisonDamage;

            Debug.Log(health);
        }
        if (health <= 0)
        {
            Debug.Log("Player has been unalived");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
