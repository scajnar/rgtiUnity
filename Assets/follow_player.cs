using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_player : MonoBehaviour
{   
    public Transform player_movement;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3(player_movement.position.x, player_movement.position.y + 3, player_movement.position.z - 3);
    }
}
