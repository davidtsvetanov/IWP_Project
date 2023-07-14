using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorWhale : MonoBehaviour
{
    
    public Material WhaleGreen;
    public Material WhaleBlue;
    public Material WhaleYellow;
    public Material WhalePink;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "GreenCookie")
        {
            gameObject.GetComponent<Renderer>().material = WhaleGreen;

        }
        if (collision.gameObject.tag == "BlueCookie")
        {
            gameObject.GetComponent<Renderer>().material = WhaleBlue;

        }
        if (collision.gameObject.tag == "YellowCookie")
        {
            gameObject.GetComponent<Renderer>().material = WhaleYellow;

        }
        if (collision.gameObject.tag == "PinkCookie")
        {
            gameObject.GetComponent<Renderer>().material = WhalePink;
            //Debug.Log("there is collision");

        }
    }
}
