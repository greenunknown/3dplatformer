using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 200f;
    public float sidewaysForce = 200f;
    public float jumpForce = 200f;

    // FixedUpdate is called once per frame for consistent intervals
    void FixedUpdate()
    {
        // Forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);    
    }
}
