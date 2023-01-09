using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBawlingBall : MonoBehaviour
{

    public Vector3 respawnPosition;
    public Quaternion respawnRotation;

    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "kegel" || collision.gameObject.tag == "floor")
        {
            Invoke("ResetPosition", 5f);
        }
    }

    void ResetPosition()
    {
        gameObject.transform.position = respawnPosition;
        gameObject.transform.rotation = respawnRotation;
    }
}