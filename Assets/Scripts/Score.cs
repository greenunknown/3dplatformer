using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public PlayerCollision player;
    public Text scoreText;
    public int PlayerScore;


    // Update is called once per frame
    void Update()
    {
       scoreText.text = player.PlayerScore.ToString();
    }
}
