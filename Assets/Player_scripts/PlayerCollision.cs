using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public static bool shield = false;
    public PlayerMovement movement;

    void OnCollisionEnter(Collision other){

        if(shield == true){
            Physics.IgnoreCollision(GameObject.FindWithTag("Player").transform.GetComponent<Collider>(), other.gameObject.transform.GetComponent<Collider>());
        }
        else {
            Physics.IgnoreCollision(GameObject.FindWithTag("Player").transform.GetComponent<Collider>(), other.gameObject.transform.GetComponent<Collider>(), false);
        
            if(other.collider.tag == "Obstacle")
            {
                movement.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
            
            }
        }

        


    }
}
