using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectShield : MonoBehaviour
{
    public GameObject orbit;
    public bool shield;
    public AudioSource powerupFX;
    private Collider other;
    public static System.DateTime Now { get; }
    [System.NonSerialized] private System.DateTime powerup_time;
    void OnTriggerEnter(Collider other) {
        powerupFX.Play();
        this.other = other;
        CollectItemsCounter.powerup_count += 1;
        this.gameObject.SetActive(false);
        this.EnableShield(System.DateTime.UtcNow);
        Invoke(nameof(ResetPlayerShield), 5);
    }

    void EnableShield(System.DateTime pickup_time)
    {
        Debug.Log("Pickup time je "+pickup_time);
        this.powerup_time = System.DateTime.UtcNow;

        PlayerCollision.shield = true;
        //this.other.transform.Find("Orbit").SetActive(false);
        this.orbit.SetActive(true);
        
    }

    public void ResetPlayerShield()
    {
        PlayerCollision.shield = false;
        //GameObject.Find("Orbit").SetActive(false);
        this.orbit.SetActive(false);
    }
}
