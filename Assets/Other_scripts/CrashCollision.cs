using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashCollision : MonoBehaviour
{
    public static bool shield = false;
    void OnTriggerEnter(Collider collision)
    {

        if(collision.gameObject.name == "Player"){
            Destroy(collision.gameObject);
            Debug.Log("HIT");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
