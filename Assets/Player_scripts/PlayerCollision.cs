using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public AudioSource hitFX;
    public AudioSource deathFX;
    public bool alreadyHit = false;
    public static bool shield = false;
    public PlayerMovement movement;

    void OnCollisionEnter(Collision other){

        if(shield == true){
            Physics.IgnoreCollision(GameObject.FindWithTag("Player").transform.GetComponent<Collider>(), other.gameObject.transform.GetComponent<Collider>());
        }
        else {
            Physics.IgnoreCollision(GameObject.FindWithTag("Player").transform.GetComponent<Collider>(), other.gameObject.transform.GetComponent<Collider>(), false);
        
            if(other.collider.tag == "Obstacle" && alreadyHit == false)
            {   
                hitFX.Play();
                alreadyHit = true;
                Invoke("DeathSound", 0.3f);
                movement.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
            
            }
            
        }
        // if(other.collider.tag == "Boundary")
        // {
        //     movement.enabled = false;
        //     FindObjectOfType<GameManager>().EndGame();
        // }

    }

    void DeathSound()
    {
        deathFX.Play();
    }
}
