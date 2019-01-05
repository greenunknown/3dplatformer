using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyController : MonoBehaviour
{
    public float lookRadius = 30f;
    Transform target;
    NavMeshAgent agent;
    
   
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
  
    void Update()
    {
        
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
