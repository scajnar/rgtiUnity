using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    [SerializeField] private Rigidbody rb;
    // Start is called before the first frame update
    [System.NonSerialized] public int jumpforce = 210;
    [System.NonSerialized] public int speed_left_right = 5;
    [System.NonSerialized] public int speed_forward = 3;
    void Update(){
        // var speed_vector = new Vector3(speed_left_right, 0 , 0);
        var forward = new Vector3(0,0,speed_forward);
        var vel = new Vector3(Input.GetAxis("Horizontal")*speed_left_right, 0 , 0); // ali Input.GetAxis("Vertical")*speed_left_right za zadnjo komponento - premikanje naprej in nazaj
        vel.y = rb.velocity.y;
        rb.velocity = (vel) + forward;

        if(Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(Vector3.up * jumpforce);
        }
    }
/*
    // Update is called once per frame
    void Update(){
        
        if(Input.GetKeyDown("w")){
            GetComponent<Rigidbody>().velocity = new Vector3(0,0,5);
        }

        if(Input.GetKeyDown("space")){
            GetComponent<Rigidbody>().velocity = new Vector3(0,5,0);
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
*/
}
