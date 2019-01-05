using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 1000f;
    //public float jumpForce = 2f;
    public bool isGrounded = true;

    public float fallMultiplier = 240f;
    public float lowJumpMultiplier = 2f;

    void Awake() {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionStay(Collision other)
    {
        if(other.gameObject.tag == "ground" || other.gameObject.tag == "platform")
            isGrounded = true;
        else
            isGrounded = false;
        Debug.Log(isGrounded);
    }

    IEnumerator wait(int seconds)
    {
        yield return new WaitForSeconds(seconds);
    }

    // FixedUpdate is called once per frame for consistent intervals
    void Update()
    {
        // Forward
        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);   
        }
        
        // Left
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
         
        // Right
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        // Back
        if(Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }

        // Jump
        /* 
        //if(Input.GetKey("space")) // && isGrounded)
        //{
            //rb.AddForce(0, 50 * jumpForce * Time.deltaTime, 0);
            //isGrounded = false;
            if(rb.velocity.y < 0) {
                rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
            } else if(rb.velocity.y > 0 && !Input.GetButton("Jump")) {
                rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
            }
        //}
        */
        Debug.Log(rb.velocity.y);
    }
}
