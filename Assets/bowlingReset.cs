using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowlingReset : MonoBehaviour
{
   

    // The position and rotation where the object will be respawned
    public Vector3 respawnPosition;
    public Quaternion respawnRotation;


  


  

    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BowlingBall" || collision.gameObject.tag == "kegel")
        {
            Debug.Log("trq izlizia");
            Invoke("ResetPosition", 3f);
        }
    }

    void ResetPosition()
    {
        gameObject.transform.position = respawnPosition;
        gameObject.transform.rotation = respawnRotation;
    }

   
}
