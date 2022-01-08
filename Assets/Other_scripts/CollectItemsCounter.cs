using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectItemsCounter : MonoBehaviour
{   [System.NonSerialized] public static int powerup_count;
    //public AudioSource powerupFX;
    public GameObject PowerUpCountDisplay;

    void Update()
    {
        //powerupFX.Play();
        PowerUpCountDisplay.GetComponent<Text>().text = "" + powerup_count;

    }
}
