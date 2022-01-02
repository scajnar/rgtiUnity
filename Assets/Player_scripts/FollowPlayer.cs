using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{   
    public Transform PlayerMovement;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(PlayerMovement.position.x, PlayerMovement.position.y + 3, PlayerMovement.position.z - 3);
    }
}
