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
        
        float result = health - poisonDamage;
        health = health - poisonDamage;

        health = health - poisonDamage;

        health = health - poisonDamage;

        health = health - poisonDamage;

        health = health - poisonDamage;

        health = health - poisonDamage;

        health = health - poisonDamage;

        health = health - poisonDamage;

        Debug.Log(health);
        Debug.Log("player has been unalived");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
