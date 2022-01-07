using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollow : MonoBehaviour
{
    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);
        transform.position = Player.transform.position + new Vector3(0, 10, -10);
    }
}
