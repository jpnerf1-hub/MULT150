using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float sensitivityX = 2f;
    public float sensitivityY = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Calculate translation amounts
        float translateX = mouseX * sensitivityX * Time.deltaTime;
        float translateY = mouseY * sensitivityY * Time.deltaTime;

        // Apply translation to the camera
        // Move left/right relative to the camera's local right direction
        transform.Translate(Vector3.right * translateX, Space.Self);
        // Move up/down relative to the camera's local up direction
        transform.Translate(Vector3.up * translateY, Space.Self);
    }
}
