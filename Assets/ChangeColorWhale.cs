using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorWhale : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame

    void OnCollisionEnter(Collision collision)
    {


        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "green")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;

        }
        if (collision.gameObject.tag == "blueBullet")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;

        }
        if (collision.gameObject.tag == "yBullet")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;

        }
        if (collision.gameObject.tag == "pink")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.black;
            Debug.Log("there is collision");

        }
    }
}
