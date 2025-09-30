using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class PlayerMovement: MonoBehaviour
{

    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    public float forwardForce = 2000f;  // Variable that determines the forward force
    public float speed;
    public float sidewaysForce = 500f;  // Variable that determines the sideways force

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.

    public FixedJoystick moveJoystick;

    void update()
    {
    }
    
        void FixedUpdate()
    {// Add a forward force
     //rb.AddForce(0, 0, forwardForce * Time.deltaTime);
     // Add a forward force
     //rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        {
            float hoz = moveJoystick.Horizontal;
            float ver = moveJoystick.Vertical;
            Vector3 direction = new Vector3(hoz, 0, ver).normalized;
            transform.Translate(direction * 0.02f, Space.World);
        }

        if (Input.GetKey("w"))  // If the player is pressing the "w" key
        {
            // Add a force to go forward
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("s"))  // If the player is pressing the "s" key
        {
            // Add a force to go back
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("d"))  // If the player is pressing the "d" key
        {        // Add a force to the right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))  // If the player is pressing the "a" key
        {        // Add a force to the left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (rb.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}