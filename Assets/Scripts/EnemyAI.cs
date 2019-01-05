using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 10f;
    
 
    void FixedUpdate()
    {
        rb.AddForce(0, 0 , forwardForce * Time.deltaTime);
        
    }
}