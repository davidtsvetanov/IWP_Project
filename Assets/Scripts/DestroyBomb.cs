using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyBomb : MonoBehaviour
{
    public ParticleSystem particleEffectPrefabBomb;
    private int score = 0;
    public TextMeshPro scoreText;


    private void Start()
    {
        scoreText.text = score.ToString();
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Sword")
        {
           
            score = 0;
            Instantiate(particleEffectPrefabBomb, transform.position, transform.rotation);
            
        }
    }
    }
