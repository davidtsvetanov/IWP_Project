using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyFruit : MonoBehaviour
{
    public ParticleSystem particleEffectPrefabFruit;
    public ParticleSystem particleEffectPrefabBomb;
    public int score = 0;
    public TextMeshPro scoreText;


    private void Start()
    {
        scoreText.text = score.ToString();
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Sword")
        {
            
            score++;
            Debug.Log(score);
            // Instantiate the particle effect at the position and rotation of the object being destroyed
            Instantiate(particleEffectPrefabFruit, transform.position, transform.rotation);
            
            // Destroy the object
           // Destroy(gameObject);
        }
       /* if (collision.gameObject.tag == "Bomb")
        {
            // Instantiate the particle effect at the position and rotation of the object being destroyed
            Instantiate(particleEffectPrefabBomb, transform.position, transform.rotation);
            score = 0;
            // Destroy the object
            Destroy(gameObject);
        }
       */
    }
}
