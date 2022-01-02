using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectItemsCounter : MonoBehaviour
{   [System.NonSerialized] public static int powerup_count;
    public GameObject PowerUpCountDisplay;

    void Update()
    {
        PowerUpCountDisplay.GetComponent<Text>().text = "" + powerup_count;

    }
}
