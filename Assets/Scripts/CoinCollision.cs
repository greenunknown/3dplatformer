using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            
            gameObject.SetActive(false);
        }
            
    }
}
