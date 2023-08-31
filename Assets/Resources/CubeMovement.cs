using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeMovement : MonoBehaviour
{
    public float speed = 50;
    bool isPressed = false;
    bool isPressed_2 = false;
    protected Rigidbody rb;
    float temp;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        temp = rb.position.y; 
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.LeftArrow)) || (Input.GetKey(KeyCode.A)))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if ((Input.GetKey(KeyCode.RightArrow)) || (Input.GetKey(KeyCode.D)))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        if ((Input.GetKey(KeyCode.UpArrow)) || (Input.GetKey(KeyCode.W)))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }

        if ((Input.GetKey(KeyCode.DownArrow)) || (Input.GetKey(KeyCode.S)))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (isPressed == true)
            {
                isPressed = false;              
            }
            else 
            {
                isPressed = true;               
            }
        }
        if(isPressed == true)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * speed);
            transform.Rotate(Vector3.right * Time.deltaTime * speed);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            if (isPressed_2 == true)
            {
                isPressed_2 = false;
            }
            else
            {
                isPressed_2 = true;               
            }
        }
        if (isPressed_2 == true)
        {           
            transform.position = new Vector3(rb.position.x, Mathf.Sin(Time.time * 3) * (2 + 19120402 % 10) + temp, rb.position.z);
        }
    }
}
