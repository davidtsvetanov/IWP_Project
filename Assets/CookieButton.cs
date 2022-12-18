using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CookieButton : MonoBehaviour
{
    public GameObject button;
    public List<GameObject> prefabs = new List<GameObject>();
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
            button.transform.localPosition = new Vector3(0, 0.71f, 0);

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

    public void SpawnCookie()
    {
        int randomIndex = Random.Range(0, prefabs.Count);

        // Get the prefab at the randomly generated index
        GameObject prefab = prefabs[randomIndex];
        Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
    }

}