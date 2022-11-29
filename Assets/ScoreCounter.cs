using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TextMeshPro scoreText;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }
    // Add Some Score To The Text When The Player Hit The CheckPoint
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "RedBall")
        {
            score += 1;
            scoreText.text = score.ToString();
            Debug.Log("Collided");
        }
    }
}
