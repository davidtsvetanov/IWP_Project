using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleAI : MonoBehaviour
{
    public float radius = 0.1f;
    public float speed = 1.0f;
    public GameObject whale;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = speed * Time.deltaTime;
        whale.transform.RotateAround(Vector3.zero, Vector3.up, angle);
    }
}
