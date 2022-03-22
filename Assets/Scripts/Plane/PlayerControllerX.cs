using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // Private Variables
    private float speed = 15.0f;
    private float rotationSpeed = 110.0f;
    // private float turnSpeed = 25.0f;
    // private float horizontalInput;
    // private float forwardInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed );

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);

        // We turn the vehicle
        // transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
