using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject prefab;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
       if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position,
        transform.rotation);
        }
    }
}
