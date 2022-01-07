using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSizeDown : MonoBehaviour
{

    private Collider other;
    public static System.DateTime Now { get; }
    [System.NonSerialized] private System.DateTime powerup_time;
    void OnTriggerEnter(Collider other) {
        // sizeFX.Play();
        this.other = other;
        CollectItemsCounter.powerup_count += 1;
        this.gameObject.SetActive(false);
        this.DecreasePlayerSize(System.DateTime.UtcNow, other);
        Invoke(nameof(ResetPlayerSize), 3);
    }

    void DecreasePlayerSize(System.DateTime pickup_time, Collider other)
    {
        Debug.Log("Pickup time je "+pickup_time);
        this.powerup_time = System.DateTime.UtcNow;
        other.gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f); 
        // powerup = true;
        // Debug.Log("V powerup == false, this.powerup_time je "+this.powerup_time);

    }

    public void ResetPlayerSize()
    {
        this.other.gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f); 

    }
}
