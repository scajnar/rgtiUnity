using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            GetComponent<Rigidbody>().velocity = new Vector3(0,5,0);
        }
        if(Input.GetKeyDown("w")){
            GetComponent<Rigidbody>().velocity = new Vector3(0,0,5);
        }
        if(Input.GetKeyDown("s")){
            GetComponent<Rigidbody>().velocity = new Vector3(0,0,-5);
        }
        if(Input.GetKeyDown("a")){
            GetComponent<Rigidbody>().velocity = new Vector3(-5,0,0);
        }
        if(Input.GetKeyDown("d")){
            GetComponent<Rigidbody>().velocity = new Vector3(5,0,0);
        }
    }
}
