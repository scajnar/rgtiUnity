using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{   
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float jumpforce = 200;
    // Start is called before the first frame update
    void Start(){

    }
    void Update(){
        var speed = 15;
        var speed_vector = new Vector3(speed, 0 , 0);
        var forward = new Vector3(0,0,3);
        var vel = new Vector3(Input.GetAxis("Horizontal")*speed, 0 , Input.GetAxis("Vertical")*speed);
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
