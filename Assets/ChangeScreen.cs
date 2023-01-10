using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeScreen : MonoBehaviour
{
    public GameObject button;
    public GameObject coolMindsScreen;
    public GameObject ControllScreen;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    public Transform spawnPoint;
    GameObject presser;
    bool isPressed;
    bool isControlls = true;
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
    public void ScreenChange()
    {
        coolMindsScreen.SetActive(true);
        ControllScreen.SetActive(false);
        isControlls = false;
        ScreenChangeToControlls();

    }
    public void ScreenChangeToControlls()
    {
        if(isControlls == false)
        {
            isControlls = true;
            coolMindsScreen.SetActive(false);
            coolMindsScreen.SetActive(true);
        }
    }
   
}
