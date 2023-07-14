using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    //when the glass gets hit by a bullet, it gets destroyed
    void OnCollisionEnter(Collision col){

        if(col.gameObject.tag == "Bullet"){
            Destroy(gameObject);
        }
    }
}
