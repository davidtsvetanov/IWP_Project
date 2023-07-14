using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTrigger : MonoBehaviour
{
    public GameObject basketball;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Hands")
        {
            basketball.SetActive(true);
            text.SetActive(false);
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Hands")
        {
            basketball.SetActive(false);
            text.SetActive(true);
        }
    }
}
