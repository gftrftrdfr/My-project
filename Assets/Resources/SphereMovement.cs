using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    protected Rigidbody rb;
    public float force = 50;
    public float speed = 50;
    bool isPressed = false;
    public float yPosition = 20;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {       
        if (Input.GetKeyDown(KeyCode.T))
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
        if (isPressed == true)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * speed);
            transform.Rotate(Vector3.right * Time.deltaTime * speed);
            transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
            rb.useGravity = false;
            rb.AddForce(0 * Physics.gravity);
        }
        else
        {
            if (rb.position.y > 2.5)
            {
                rb.AddForce(Physics.gravity);
                rb.drag = 1;
            }
            else
            {
                rb.AddForce(-force * Physics.gravity);
                rb.drag = 1;
            }
        }
    }
}
