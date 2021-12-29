using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public static System.DateTime Now { get; }
    [System.NonSerialized] public bool powerup = false;
    [System.NonSerialized] private System.DateTime powerup_time;
    

    void OnTriggerEnter(Collider other) {
        // coinFX.Play();
        this.gameObject.SetActive(false);
        this.IncreasePlayerSpeed(System.DateTime.UtcNow);
        Invoke(nameof(ResetPlayerSpeed), 3);
    }

    void IncreasePlayerSpeed(System.DateTime pickup_time)
    {
        Debug.Log("Pickup time je"+pickup_time);
        this.powerup_time = System.DateTime.UtcNow;
        GameObject.Find("Player").GetComponent<PlayerMovement>().speed_forward += 3;
        GameObject.Find("Player").GetComponent<PlayerMovement>().jumpforce = 250;
        // powerup = true;
        // Debug.Log("V powerup == false, this.powerup_time je "+this.powerup_time);

    }

    void ResetPlayerSpeed()
    {
        GameObject.Find("Player").GetComponent<PlayerMovement>().speed_forward = 3;
        GameObject.Find("Player").GetComponent<PlayerMovement>().jumpforce = 210;

    }
}
