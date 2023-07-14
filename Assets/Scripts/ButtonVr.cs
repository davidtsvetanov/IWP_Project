using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVr : MonoBehaviour
{
    public GameObject button;
    public GameObject ball;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    public Transform spawnPoint;
    GameObject presser;
    bool isPressed;
    // Start is called before the first frame update
    void Start()
    {
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            button.transform.localPosition = new Vector3(0,  0.71f, 0);
            
            onPress.Invoke();
            isPressed = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        
        if (other.tag == "Hands")
        {
            Debug.Log("topkaaa");
            button.transform.localPosition = new Vector3(0, 0.78f, 0);
            onRelease.Invoke();
            isPressed = false;
            
        }
    }

    public void SpawnBall()
    {
        Instantiate(ball, spawnPoint.position, spawnPoint.rotation);
    }

}
