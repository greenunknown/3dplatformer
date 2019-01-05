using UnityEngine;


public class PlayerCollision : MonoBehaviour
{  
    public int PlayerScore = 0;
    public UnityEngine.Object Coin;
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Coin")
        {
           
            PlayerScore += 1;
        }
    }
}
