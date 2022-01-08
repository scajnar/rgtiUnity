using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    [SerializeField] private Rigidbody rb;
    // Start is called before the first frame update
    [System.NonSerialized] public int jumpforce = 300;
    [System.NonSerialized] public int speed_left_right = 5;
    [System.NonSerialized] public int speed_forward = 3;

    bool canJump = true;
    void Update(){
        // var speed_vector = new Vector3(speed_left_right, 0 , 0);
        var forward = new Vector3(0,0,speed_forward);
        var vel = new Vector3(Input.GetAxis("Horizontal")*speed_left_right, 0 , 0); // ali Input.GetAxis("Vertical")*speed_left_right za zadnjo komponento - premikanje naprej in nazaj
        vel.y = rb.velocity.y;
        rb.velocity = (vel) + forward;

        if(Input.GetKeyDown(KeyCode.Space) && this.gameObject.transform.position.y <= 5 && canJump == true){
            rb.AddForce(Vector3.up * jumpforce);
            canJump = false;
            Invoke("Cooldown", 0.2f);

        }
    }
    
    void Cooldown(){
        canJump = true;
    }
}
