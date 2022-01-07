using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitPlayer : MonoBehaviour
{
    public Transform target;
    public float orbitDistance = 10.0f;
    public float orbitDegreesPerSec = 180.0f;
    void Start()
    {
        
    }

    void Orbit(){
        if(target != null){
            transform.position = target.position + (transform.position - target.position).normalized * orbitDistance;
            transform.RotateAround(target.position, Vector3.up, orbitDegreesPerSec * Time.deltaTime);
        }
    }


    void LateUpdate()
    {
        Orbit();
    }
}
