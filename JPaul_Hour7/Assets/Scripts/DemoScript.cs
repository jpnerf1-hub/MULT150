using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health;
        health = 100;
        int potion = 20;

        health = health - 30; // health -= 30;
        health = health + potion; // health +=20; potion
        Debug.Log("health is " + health);
        Debug.Log("potion is " + potion);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
